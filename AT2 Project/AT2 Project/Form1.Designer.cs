namespace AT2_Project
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbOff = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOutsideTemp = new System.Windows.Forms.TextBox();
            this.tbInsideTemp = new System.Windows.Forms.TextBox();
            this.tbInsideHumidity = new System.Windows.Forms.TextBox();
            this.cmbTempMax = new System.Windows.Forms.ComboBox();
            this.TempMax = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Location = new System.Drawing.Point(36, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(18, 53);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 34);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Items.AddRange(new object[] {
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbPort.Location = new System.Drawing.Point(18, 21);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 24);
            this.cmbPort.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOff);
            this.groupBox2.Controls.Add(this.rbBlue);
            this.groupBox2.Controls.Add(this.rbRed);
            this.groupBox2.Controls.Add(this.rbGreen);
            this.groupBox2.Location = new System.Drawing.Point(36, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mood Light";
            // 
            // rbOff
            // 
            this.rbOff.AutoSize = true;
            this.rbOff.Location = new System.Drawing.Point(25, 158);
            this.rbOff.Name = "rbOff";
            this.rbOff.Size = new System.Drawing.Size(56, 21);
            this.rbOff.TabIndex = 3;
            this.rbOff.TabStop = true;
            this.rbOff.Text = "OFF";
            this.rbOff.UseVisualStyleBackColor = true;
            this.rbOff.CheckedChanged += new System.EventHandler(this.RbOff_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(25, 116);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(57, 21);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.RbBlue_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(25, 76);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(55, 21);
            this.rbRed.TabIndex = 1;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.RbRed_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(25, 35);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(69, 21);
            this.rbGreen.TabIndex = 0;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.RbGreen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Outside Temp (LM35)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inside Temp (DHT11)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inside Humidity (DHT11)";
            // 
            // tbOutsideTemp
            // 
            this.tbOutsideTemp.Location = new System.Drawing.Point(437, 47);
            this.tbOutsideTemp.Name = "tbOutsideTemp";
            this.tbOutsideTemp.Size = new System.Drawing.Size(100, 22);
            this.tbOutsideTemp.TabIndex = 5;
            // 
            // tbInsideTemp
            // 
            this.tbInsideTemp.Location = new System.Drawing.Point(437, 97);
            this.tbInsideTemp.Name = "tbInsideTemp";
            this.tbInsideTemp.Size = new System.Drawing.Size(100, 22);
            this.tbInsideTemp.TabIndex = 6;
            // 
            // tbInsideHumidity
            // 
            this.tbInsideHumidity.Location = new System.Drawing.Point(437, 150);
            this.tbInsideHumidity.Name = "tbInsideHumidity";
            this.tbInsideHumidity.Size = new System.Drawing.Size(100, 22);
            this.tbInsideHumidity.TabIndex = 7;
            // 
            // cmbTempMax
            // 
            this.cmbTempMax.FormattingEnabled = true;
            this.cmbTempMax.Items.AddRange(new object[] {
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cmbTempMax.Location = new System.Drawing.Point(416, 214);
            this.cmbTempMax.Name = "cmbTempMax";
            this.cmbTempMax.Size = new System.Drawing.Size(121, 24);
            this.cmbTempMax.TabIndex = 8;
            // 
            // TempMax
            // 
            this.TempMax.Location = new System.Drawing.Point(272, 214);
            this.TempMax.Name = "TempMax";
            this.TempMax.Size = new System.Drawing.Size(121, 24);
            this.TempMax.TabIndex = 9;
            this.TempMax.Text = "Temp Max";
            this.TempMax.UseVisualStyleBackColor = true;
            this.TempMax.Click += new System.EventHandler(this.TempMax_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.Red;
            this.btnToggle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToggle.Location = new System.Drawing.Point(272, 266);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(265, 78);
            this.btnToggle.TabIndex = 10;
            this.btnToggle.Text = "Red LED Toggle";
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.BtnToggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 382);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.TempMax);
            this.Controls.Add(this.cmbTempMax);
            this.Controls.Add(this.tbInsideHumidity);
            this.Controls.Add(this.tbInsideTemp);
            this.Controls.Add(this.tbOutsideTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "IoT Prototype";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOff;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOutsideTemp;
        private System.Windows.Forms.TextBox tbInsideTemp;
        private System.Windows.Forms.TextBox tbInsideHumidity;
        private System.Windows.Forms.ComboBox cmbTempMax;
        private System.Windows.Forms.Button TempMax;
        private System.Windows.Forms.Button btnToggle;
    }
}

