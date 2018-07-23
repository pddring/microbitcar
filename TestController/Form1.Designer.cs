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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.chkRearLights.Location = new System.Drawing.Point(6, 54);
            this.chkRearLights.Name = "chkRearLights";
            this.chkRearLights.Size = new System.Drawing.Size(76, 17);
            this.chkRearLights.TabIndex = 1;
            this.chkRearLights.Text = "Rear lights";
            this.chkRearLights.UseVisualStyleBackColor = true;
            this.chkRearLights.CheckedChanged += new System.EventHandler(this.chkRearLights_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHeadlights);
            this.groupBox1.Controls.Add(this.chkRearLights);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 100);
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
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
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
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(87, 71);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Micro:bit car controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
    }
}

