﻿namespace TestController
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
            this.components = new System.ComponentModel.Container();
            this.chkHeadlights = new System.Windows.Forms.CheckBox();
            this.chkRearLights = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDoors = new System.Windows.Forms.CheckBox();
            this.lstCOMPorts = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.radioForwads = new System.Windows.Forms.RadioButton();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnHorn = new System.Windows.Forms.Button();
            this.txtHorn = new System.Windows.Forms.TextBox();
            this.lblHorn = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCustomSend = new System.Windows.Forms.Button();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.distanceTimer = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.pbDistance = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            // chkDoors
            // 
            this.chkDoors.AutoSize = true;
            this.chkDoors.Location = new System.Drawing.Point(6, 83);
            this.chkDoors.Name = "chkDoors";
            this.chkDoors.Size = new System.Drawing.Size(54, 17);
            this.chkDoors.TabIndex = 2;
            this.chkDoors.Text = "Doors";
            this.chkDoors.UseVisualStyleBackColor = true;
            this.chkDoors.CheckedChanged += new System.EventHandler(this.chkDoors_CheckedChanged);
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
            this.groupBox2.Controls.Add(this.btnDisconnect);
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
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(134, 71);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(60, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(66, 71);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(62, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 71);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(54, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSpeed);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.radioLeft);
            this.groupBox3.Controls.Add(this.radioRight);
            this.groupBox3.Controls.Add(this.radioForwads);
            this.groupBox3.Location = new System.Drawing.Point(350, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 83);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speed and Direction";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(3, 16);
            this.tbSpeed.Minimum = -10;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(206, 45);
            this.tbSpeed.TabIndex = 10;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(215, 26);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
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
            this.radioLeft.CheckedChanged += new System.EventHandler(this.radioLeft_CheckedChanged);
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
            this.radioRight.CheckedChanged += new System.EventHandler(this.radioRight_CheckedChanged);
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
            this.radioForwads.CheckedChanged += new System.EventHandler(this.radioForwads_CheckedChanged);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 196);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(643, 147);
            this.lstOutput.TabIndex = 7;
            // 
            // btnHorn
            // 
            this.btnHorn.Location = new System.Drawing.Point(215, 16);
            this.btnHorn.Name = "btnHorn";
            this.btnHorn.Size = new System.Drawing.Size(75, 23);
            this.btnHorn.TabIndex = 11;
            this.btnHorn.Text = "Horn";
            this.btnHorn.UseVisualStyleBackColor = true;
            this.btnHorn.Click += new System.EventHandler(this.btnHorn_Click);
            // 
            // txtHorn
            // 
            this.txtHorn.Location = new System.Drawing.Point(69, 16);
            this.txtHorn.Name = "txtHorn";
            this.txtHorn.Size = new System.Drawing.Size(125, 20);
            this.txtHorn.TabIndex = 12;
            this.txtHorn.Text = "500";
            // 
            // lblHorn
            // 
            this.lblHorn.AutoSize = true;
            this.lblHorn.Location = new System.Drawing.Point(6, 16);
            this.lblHorn.Name = "lblHorn";
            this.lblHorn.Size = new System.Drawing.Size(57, 13);
            this.lblHorn.TabIndex = 13;
            this.lblHorn.Text = "Frequency";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblHorn);
            this.groupBox4.Controls.Add(this.txtHorn);
            this.groupBox4.Controls.Add(this.btnHorn);
            this.groupBox4.Location = new System.Drawing.Point(350, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 48);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Horn:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCustomSend);
            this.groupBox5.Controls.Add(this.txtCustom);
            this.groupBox5.Location = new System.Drawing.Point(12, 131);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(332, 59);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Custom";
            // 
            // btnCustomSend
            // 
            this.btnCustomSend.Location = new System.Drawing.Point(169, 16);
            this.btnCustomSend.Name = "btnCustomSend";
            this.btnCustomSend.Size = new System.Drawing.Size(75, 23);
            this.btnCustomSend.TabIndex = 15;
            this.btnCustomSend.Text = "Send";
            this.btnCustomSend.UseVisualStyleBackColor = true;
            this.btnCustomSend.Click += new System.EventHandler(this.btnCustomSend_Click);
            // 
            // txtCustom
            // 
            this.txtCustom.Location = new System.Drawing.Point(6, 19);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(157, 20);
            this.txtCustom.TabIndex = 14;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblDistance);
            this.groupBox6.Location = new System.Drawing.Point(350, 155);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(305, 35);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Distance:";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(3, 16);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(96, 13);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Click for an update";
            // 
            // distanceTimer
            // 
            this.distanceTimer.Enabled = true;
            this.distanceTimer.Interval = 500;
            this.distanceTimer.Tick += new System.EventHandler(this.distanceTimer_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pbDistance
            // 
            this.pbDistance.Location = new System.Drawing.Point(93, 349);
            this.pbDistance.Maximum = 2000;
            this.pbDistance.Name = "pbDistance";
            this.pbDistance.Size = new System.Drawing.Size(562, 23);
            this.pbDistance.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 370);
            this.Controls.Add(this.pbDistance);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Micro:bit car controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.RadioButton radioRight;
        private System.Windows.Forms.RadioButton radioForwads;
        private System.Windows.Forms.CheckBox chkDoors;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnHorn;
        private System.Windows.Forms.TextBox txtHorn;
        private System.Windows.Forms.Label lblHorn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCustomSend;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Timer distanceTimer;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.ProgressBar pbDistance;
    }
}

