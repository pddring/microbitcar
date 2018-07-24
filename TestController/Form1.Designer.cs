namespace TestController
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
            this.chkHeadlights = new System.Windows.Forms.CheckBox();
            this.chkRearLights = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstCOMPorts = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.sliderSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.radioForwads = new System.Windows.Forms.RadioButton();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkDoors = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSpeed)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkHeadlights
            // 
            this.chkHeadlights.AutoSize = true;
            this.chkHeadlights.Location = new System.Drawing.Point(6, 19);
            this.chkHeadlights.Name = "chkHeadlights";
            this.chkHeadlights.Size = new System.Drawing.Size(79, 17);
            this.chkHeadlights.TabIndex = 0;
            this.chkHeadlights.Text = "Head lights";
            this.chkHeadlights.UseVisualStyleBackColor = true;
            this.chkHeadlights.CheckedChanged += new System.EventHandler(this.chkHeadlights_CheckedChanged);
            // 
            // chkRearLights
            // 
            this.chkRearLights.AutoSize = true;
            this.chkRearLights.Location = new System.Drawing.Point(6, 52);
            this.chkRearLights.Name = "chkRearLights";
            this.chkRearLights.Size = new System.Drawing.Size(76, 17);
            this.chkRearLights.TabIndex = 1;
            this.chkRearLights.Text = "Rear lights";
            this.chkRearLights.UseVisualStyleBackColor = true;
            this.chkRearLights.CheckedChanged += new System.EventHandler(this.chkRearLights_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDoors);
            this.groupBox1.Controls.Add(this.chkHeadlights);
            this.groupBox1.Controls.Add(this.chkRearLights);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lights";
            // 
            // lstCOMPorts
            // 
            this.lstCOMPorts.FormattingEnabled = true;
            this.lstCOMPorts.Location = new System.Drawing.Point(6, 19);
            this.lstCOMPorts.Name = "lstCOMPorts";
            this.lstCOMPorts.Size = new System.Drawing.Size(188, 43);
            this.lstCOMPorts.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.lstCOMPorts);
            this.groupBox2.Location = new System.Drawing.Point(144, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(87, 71);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 71);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // sliderSpeed
            // 
            this.sliderSpeed.LargeChange = 20;
            this.sliderSpeed.Location = new System.Drawing.Point(6, 26);
            this.sliderSpeed.Maximum = 1023;
            this.sliderSpeed.Minimum = -1023;
            this.sliderSpeed.Name = "sliderSpeed";
            this.sliderSpeed.Size = new System.Drawing.Size(188, 45);
            this.sliderSpeed.SmallChange = 5;
            this.sliderSpeed.TabIndex = 5;
            this.sliderSpeed.TickFrequency = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.radioLeft);
            this.groupBox3.Controls.Add(this.radioRight);
            this.groupBox3.Controls.Add(this.radioForwads);
            this.groupBox3.Controls.Add(this.sliderSpeed);
            this.groupBox3.Location = new System.Drawing.Point(350, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 113);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speed and Direction";
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Location = new System.Drawing.Point(240, 54);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(50, 17);
            this.radioRight.TabIndex = 7;
            this.radioRight.TabStop = true;
            this.radioRight.Text = "Right";
            this.radioRight.UseVisualStyleBackColor = true;
            // 
            // radioForwads
            // 
            this.radioForwads.AutoSize = true;
            this.radioForwads.Location = new System.Drawing.Point(126, 54);
            this.radioForwads.Name = "radioForwads";
            this.radioForwads.Size = new System.Drawing.Size(68, 17);
            this.radioForwads.TabIndex = 6;
            this.radioForwads.TabStop = true;
            this.radioForwads.Text = "Forwards";
            this.radioForwads.UseVisualStyleBackColor = true;
            // 
            // radioLeft
            // 
            this.radioLeft.AutoSize = true;
            this.radioLeft.Location = new System.Drawing.Point(6, 53);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(43, 17);
            this.radioLeft.TabIndex = 8;
            this.radioLeft.TabStop = true;
            this.radioLeft.Text = "Left";
            this.radioLeft.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(215, 26);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // chkDoors
            // 
            this.chkDoors.AutoSize = true;
            this.chkDoors.Location = new System.Drawing.Point(6, 83);
            this.chkDoors.Name = "chkDoors";
            this.chkDoors.Size = new System.Drawing.Size(54, 17);
            this.chkDoors.TabIndex = 2;
            this.chkDoors.Text = "Doors";
            this.chkDoors.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 133);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Micro:bit car controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sliderSpeed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkHeadlights;
        private System.Windows.Forms.CheckBox chkRearLights;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstCOMPorts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TrackBar sliderSpeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.RadioButton radioRight;
        private System.Windows.Forms.RadioButton radioForwads;
        private System.Windows.Forms.CheckBox chkDoors;
    }
}

