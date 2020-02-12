namespace Multiplexer_Inductance_Data_Logger
{
    partial class UserInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Parts = new System.Windows.Forms.NumericUpDown();
            this.Stop = new System.Windows.Forms.Button();
            this.Frequency = new System.Windows.Forms.NumericUpDown();
            this.Voltage = new System.Windows.Forms.NumericUpDown();
            this.ARPort = new System.Windows.Forms.NumericUpDown();
            this.WKPort = new System.Windows.Forms.NumericUpDown();
            this.Units = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RTD = new System.Windows.Forms.ComboBox();
            this.ALC = new System.Windows.Forms.ComboBox();
            this.Test = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WKPort)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(141, 333);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 40);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wayne Kerr Comm Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Arduino Comm Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Voltage (mV)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Frequency (kHz)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ALC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Parts";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(96, 293);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(208, 26);
            this.FileName.TabIndex = 14;
            this.FileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FileName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name File";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(301, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = ".CSV";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Parts
            // 
            this.Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parts.Location = new System.Drawing.Point(245, 174);
            this.Parts.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.Parts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(100, 26);
            this.Parts.TabIndex = 6;
            this.Parts.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(247, 333);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 40);
            this.Stop.TabIndex = 19;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Frequency
            // 
            this.Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frequency.Location = new System.Drawing.Point(245, 108);
            this.Frequency.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Frequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Frequency.Name = "Frequency";
            this.Frequency.Size = new System.Drawing.Size(100, 26);
            this.Frequency.TabIndex = 4;
            this.Frequency.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Voltage
            // 
            this.Voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltage.Location = new System.Drawing.Point(245, 76);
            this.Voltage.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.Voltage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Voltage.Name = "Voltage";
            this.Voltage.Size = new System.Drawing.Size(100, 26);
            this.Voltage.TabIndex = 3;
            this.Voltage.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ARPort
            // 
            this.ARPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARPort.Location = new System.Drawing.Point(245, 44);
            this.ARPort.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ARPort.Name = "ARPort";
            this.ARPort.Size = new System.Drawing.Size(100, 26);
            this.ARPort.TabIndex = 2;
            this.ARPort.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // WKPort
            // 
            this.WKPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WKPort.Location = new System.Drawing.Point(245, 12);
            this.WKPort.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.WKPort.Name = "WKPort";
            this.WKPort.Size = new System.Drawing.Size(100, 26);
            this.WKPort.TabIndex = 1;
            this.WKPort.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Units
            // 
            this.Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Units.FormattingEnabled = true;
            this.Units.Items.AddRange(new object[] {
            "H",
            "mH",
            "µH"});
            this.Units.Location = new System.Drawing.Point(245, 206);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(100, 28);
            this.Units.TabIndex = 7;
            this.Units.Text = "mH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Units";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(112, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Channel 16 RTD";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RTD
            // 
            this.RTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTD.FormattingEnabled = true;
            this.RTD.Items.AddRange(new object[] {
            "NO",
            "YES"});
            this.RTD.Location = new System.Drawing.Point(245, 240);
            this.RTD.Name = "RTD";
            this.RTD.Size = new System.Drawing.Size(100, 28);
            this.RTD.TabIndex = 8;
            this.RTD.Text = "NO";
            // 
            // ALC
            // 
            this.ALC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALC.FormattingEnabled = true;
            this.ALC.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.ALC.Location = new System.Drawing.Point(245, 140);
            this.ALC.Name = "ALC";
            this.ALC.Size = new System.Drawing.Size(100, 28);
            this.ALC.TabIndex = 24;
            this.ALC.Text = "OFF";
            // 
            // Test
            // 
            this.Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test.Location = new System.Drawing.Point(35, 333);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(100, 40);
            this.Test.TabIndex = 25;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 380);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.ALC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RTD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.WKPort);
            this.Controls.Add(this.ARPort);
            this.Controls.Add(this.Voltage);
            this.Controls.Add(this.Frequency);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Parts);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInput";
            this.Text = "Multiplexed Inductance Measurement";
            ((System.ComponentModel.ISupportInitialize)(this.Parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WKPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Parts;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.NumericUpDown Frequency;
        private System.Windows.Forms.NumericUpDown Voltage;
        private System.Windows.Forms.NumericUpDown ARPort;
        private System.Windows.Forms.NumericUpDown WKPort;
        private System.Windows.Forms.ComboBox Units;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox RTD;
        private System.Windows.Forms.ComboBox ALC;
        private System.Windows.Forms.Button Test;
    }
}

