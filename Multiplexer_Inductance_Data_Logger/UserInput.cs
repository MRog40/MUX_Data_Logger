//Michael Rogers
//Wurth Electronics Midcom
//Multiplexed Inductance Measurement Data Logger

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Timers;

namespace Multiplexer_Inductance_Data_Logger
{
    public partial class UserInput : Form
    {
        //Global Variables
        public SerialPort Wayne_Kerr;
        public SerialPort Arduino;
        StreamWriter sw;
        TimeSpan startTimeSpan;
        TimeSpan periodTimeSpan;
        System.Threading.Timer timer;
        int multiplier = 0;
        bool rtd = false;
        bool Stopped = false;
        string dir = "";

        //Executed when the program is ran
        public UserInput()
        {
            InitializeComponent();
            Console.Title = "Multiplexed Inductance Measurement Output";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("This window is the live test output.\nPress Start to begin the test.");
        }
        //Disallow from entering weird characters into the file name box
        private void FileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|]"))
            {
                e.Handled = true;
            }
        }
        //This function is executed when you click Test
        private void Test_Click(object sender, EventArgs e)
        {
            string output = "";
            Calculate_Multiplier();
            Setup_Ports();
            System_Setup();
            Send(":TRIG");
            Thread.Sleep(300);
            Send("++read eoi");
            Thread.Sleep(410);
            output += Read(0) + " " + Units.Text;
            Console.WriteLine("Test Output: " + output);
            Thread.Sleep(100);
            Wayne_Kerr.Close();
            Arduino.Close();
        }
        //This is the main function executed when the Start button is pressed
        private void Start_Click(object sender, EventArgs e)
        {
            if (FileName.Text.Length > 0)
            {
                Stopped = false;
                Console.WriteLine("Starting Test...");
                string time = "";
                if (RTD.Text.Equals("YES")) //Set bool for whether RTD is being used
                    rtd = true;
                string Header = Create_Header();
                Setup_Ports();
                System_Setup();
                Create_File(FileName.Text);
                File_Print(FileName.Text + ".CSV\n" + Header);
                Calculate_Multiplier();
                //Call Measuring at every minute interval starting now
                startTimeSpan = TimeSpan.Zero;
                periodTimeSpan = TimeSpan.FromSeconds(60);
                timer = new System.Threading.Timer((ex) =>
                {
                    if (!Stopped)
                    {
                        time = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss  tt");
                        Measuring(time);
                        Set_Slot(0);
                    }
                }, null, startTimeSpan, periodTimeSpan);
            }
            else
            {
                MessageBox.Show("You must specify a file name.");
            }
        }
        //Executed when Stop is pressed, basically just closes ports and closes CSV
        private void Stop_Click(object sender, EventArgs e)
        {
            //Timer.Dispose();
            Close_Ports();
            Print("Stopped");
            Stopped = true;
        }
        //Functions
        //Calculate multiplier
        private void Calculate_Multiplier()
        {
            //Calculate units multiplier
            if (Units.Text == "H")
                multiplier = 1;
            else if (Units.Text == "mH")
                multiplier = 1000;
            else if (Units.Text == "µH")
                multiplier = 1000000;
        }
        //Close ports and file
        private void Close_Ports()
        {
            try
            {
                //Close the ports
                Wayne_Kerr.Close();
                Arduino.Close();
                Console.WriteLine("Ports Closed");
            }
            catch (Exception e) { MessageBox.Show("Close Ports Error: " + e.Message); }
            try
            {
                //Close the file
                sw.Close();
                Console.WriteLine("File Closed\nCSV is saved to " + dir);
            }
            catch (Exception e) { MessageBox.Show("Close File Error: " + e.Message); }

        }
        //Create the CSV file
        private void Create_File(string name)
        {
            //Get working DIR
            dir = AppDomain.CurrentDomain.BaseDirectory;
            //Create file at current filepath
            dir = dir + /* "\\" + */ FileName.Text + ".CSV";
            try
            {
                sw = new StreamWriter(dir);
            }
            catch (Exception e) { MessageBox.Show("Create File Error: " + e.Message); }

            Console.WriteLine("CSV is saved to " + dir);
        }
        //Prints line to CSV
        private void File_Print(string line)
        {
            if (!Stopped)
            {
                try
                {
                    //Write a line of text
                    sw.WriteLine(line);
                }
                catch (Exception e)
                {
                    Console.WriteLine("File Print Error: " + e.Message);
                    Console.WriteLine("If Stopped, ignore this error.");
                }
            }
        }
        //Creates CSV Header
        private string Create_Header()
        {
            string Header = "";
            Header += "Time, ";
            if (rtd)
                Header += "RTD Ohms, ";
            Header += "Part ";
            for (int i = 0; i < Convert.ToInt32(Parts.Value); i++)
            {
                Header += (i + 1).ToString();
                if (i < Convert.ToInt32(Parts.Value - 1))
                    Header += ", Part ";
            }
            return Header;
        }
        //Measures RTD resistor
        private string Measure_RTD()
        {
            string value = "";
            try
            {
                Set_Slot(15);
                Thread.Sleep(800);
                //Measure and record
                Send(":TRIG");
                Thread.Sleep(600);
                Send("++read eoi");
                Thread.Sleep(410);
                value = Read(1);
            }
            catch (Exception e) { Console.WriteLine("Measure RTD Error: " + e.Message); }
            return value;
        }
        //Start measurements, called every minute
        private void Measuring(string time)
        {
            if (!Stopped)
            {
                string measurements = "";
                measurements = Take_Measurements();
                Print(time + ", " + measurements);
            }
        }
        //Print data to console and to new file
        private void Print(string line)
        {
            //string fancyLine = line.Replace(", ",",\t");
            Console.WriteLine(line);
            File_Print(line);
        }
        //Read measurements from WK
        private string Read(int i)
        {
            if (!Stopped)
            {
                try
                {
                    string result = "";
                    result = Wayne_Kerr.ReadLine(); //"3.3E-3, 554"
                    Thread.Sleep(100);
                    if (result.Length < 3)
                        result = "999999, 1";
                    string[] outputs = result.Split(',');
                    if (result.Equals("999999, 1"))
                        return "    ";
                    else if (Double.Parse(outputs[i], System.Globalization.NumberStyles.Float) < 0)
                        return "    ";
                    else if (i == 0)
                        return (multiplier * Double.Parse(outputs[i], System.Globalization.NumberStyles.Float)).ToString();
                    else
                        return (Double.Parse(outputs[i], System.Globalization.NumberStyles.Float)).ToString();
                }
                catch (Exception e) { Console.WriteLine("Read Error: " + e.Message); return "    "; }
            }
            else
                return "    ";
        }
        //Send command to WK
        private void Send(string command)
        {
            if (!Stopped)
            {
                try
                {
                    Wayne_Kerr.WriteLine(command);
                }
                catch (Exception e) { Console.WriteLine("Send Error: " + e.Message); }
            }
        }
        //Create and open the ports
        private void Setup_Ports()
        {
            //Create the serial port with basic settings
            Wayne_Kerr = new SerialPort("COM" + WKPort.Text, 115200, Parity.None, 8, StopBits.One);
            Arduino = new SerialPort("COM" + ARPort.Text, 9600, Parity.None, 8, StopBits.One);
            try
            {
                Wayne_Kerr.Open();
            }
            catch(Exception e) { MessageBox.Show("Wayne Kerr Port Error: " + e.Message); }
            try
            {
                Arduino.Open();
            }
            catch (Exception e) { MessageBox.Show("Arduino Port Error: " + e.Message); }
        }
        //Set arduino multiplexer to select slot (0-15)
        private void Set_Slot(int i)
        {
            string channel;
            try
            {
                channel = i.ToString("X");
                Arduino.WriteLine(channel);
            }
            catch (Exception e) { Console.WriteLine("Set Slot Error: " + e.Message); }
        }
        //Setup Prologix and Wayne Kerr
        private void System_Setup()
        {
            //Set up Prologix Controller
            Send("++addr 6"); //Hardcoded to GPIB Address 6 (WK Settings)
            Send("++eos 2");
            Send("++eoi 1");
            Send("++auto 0");
            Send("++read_tmo_ms 1000");
            //Set up Wayne Kerr for measurements
            Send(":IMP:TEST:AC");
            Send(":IMP:FUNC:L");
            Send(":IMP:FUNC:R");
            Send(":IMP:FREQ " + Frequency.Text + "k");
            Send(":IMP:Lev " + (Convert.ToDouble(Voltage.Text) * 0.001).ToString() + "V");
            Send(":IMP:ALC " + ALC.Text);
            Send(":REP OFF");
            Send(":LOC-TRIG OFF");
            Send("++loc");
            Thread.Sleep(50);
            Send("++trg");
        }
        //Measure all 16 parts and write them to a single string
        private string Take_Measurements()
        {
            string measurements = "";
            int parts = 0;
            parts = Convert.ToInt32(Parts.Value);
            if (rtd && parts == 16)
                parts = 15;
            for (int i = 0; i < Convert.ToInt32(Parts.Value); i++)
            {
                try
                {
                    Set_Slot(i);
                    Thread.Sleep(800);
                    Send(":TRIG");
                    Thread.Sleep(600);
                    Send("++read eoi");
                    Thread.Sleep(410);
                    measurements += Read(0) + ", ";
                }
                catch (Exception e) { Console.WriteLine("Measure Inductance Error: " + e.Message); }
            }
            //remove the last ", "
            measurements = measurements.Substring(0, measurements.Length - 2);
            //If rtd is on, measure the last resistor and add it to measurements
            if (rtd)
                measurements = Measure_RTD() + ", " + measurements;
            Set_Slot(0);
            return measurements;
        }//END this func
    }//END Class
}//END Namespace