namespace Jsysmon
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalRamLabe = new System.Windows.Forms.Label();
            this.lblTotalRam = new System.Windows.Forms.Label();
            this.lblInUse = new System.Windows.Forms.Label();
            this.lblInUseLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblExtIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ram in use:";
            // 
            // lblTotalRamLabe
            // 
            this.lblTotalRamLabe.AutoSize = true;
            this.lblTotalRamLabe.Location = new System.Drawing.Point(74, 18);
            this.lblTotalRamLabe.Name = "lblTotalRamLabe";
            this.lblTotalRamLabe.Size = new System.Drawing.Size(59, 13);
            this.lblTotalRamLabe.TabIndex = 2;
            this.lblTotalRamLabe.Text = "Total Ram:";
            // 
            // lblTotalRam
            // 
            this.lblTotalRam.AutoSize = true;
            this.lblTotalRam.Location = new System.Drawing.Point(148, 18);
            this.lblTotalRam.Name = "lblTotalRam";
            this.lblTotalRam.Size = new System.Drawing.Size(35, 13);
            this.lblTotalRam.TabIndex = 3;
            this.lblTotalRam.Text = "label4";
            // 
            // lblInUse
            // 
            this.lblInUse.AutoSize = true;
            this.lblInUse.Location = new System.Drawing.Point(147, 41);
            this.lblInUse.Name = "lblInUse";
            this.lblInUse.Size = new System.Drawing.Size(35, 13);
            this.lblInUse.TabIndex = 5;
            this.lblInUse.Text = "label4";
            // 
            // lblInUseLabel
            // 
            this.lblInUseLabel.AutoSize = true;
            this.lblInUseLabel.Location = new System.Drawing.Point(46, 41);
            this.lblInUseLabel.Name = "lblInUseLabel";
            this.lblInUseLabel.Size = new System.Drawing.Size(95, 13);
            this.lblInUseLabel.TabIndex = 4;
            this.lblInUseLabel.Text = "Total Ram in  Use:";
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Ext IP:";
            // 
            // lblExtIP
            // 
            this.lblExtIP.AutoSize = true;
            this.lblExtIP.Location = new System.Drawing.Point(143, 88);
            this.lblExtIP.Name = "lblExtIP";
            this.lblExtIP.Size = new System.Drawing.Size(35, 13);
            this.lblExtIP.TabIndex = 7;
            this.lblExtIP.Text = "label4";
            this.lblExtIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 135);
            this.Controls.Add(this.lblExtIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInUse);
            this.Controls.Add(this.lblInUseLabel);
            this.Controls.Add(this.lblTotalRam);
            this.Controls.Add(this.lblTotalRamLabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bishop Resource Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalRamLabe;
        private System.Windows.Forms.Label lblTotalRam;
        private System.Windows.Forms.Label lblInUse;
        private System.Windows.Forms.Label lblInUseLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExtIP;
    }
}

