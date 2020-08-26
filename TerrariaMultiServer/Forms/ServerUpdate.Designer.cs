namespace TerrariaMultiServer
{
    partial class ServerUpdate
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
            this.progressBarDownloadProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxStatus = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuBar = new TerrariaMultiServer.UserControls.MenuBar();
            this.SuspendLayout();
            // 
            // progressBarDownloadProgress
            // 
            this.progressBarDownloadProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(157)))));
            this.progressBarDownloadProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(157)))));
            this.progressBarDownloadProgress.Location = new System.Drawing.Point(12, 56);
            this.progressBarDownloadProgress.Name = "progressBarDownloadProgress";
            this.progressBarDownloadProgress.Size = new System.Drawing.Size(291, 23);
            this.progressBarDownloadProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarDownloadProgress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Download Progress";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(157)))));
            this.txtBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxStatus.Location = new System.Drawing.Point(55, 85);
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.ReadOnly = true;
            this.txtBoxStatus.Size = new System.Drawing.Size(248, 20);
            this.txtBoxStatus.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(12, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(291, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(315, 30);
            this.menuBar.TabIndex = 5;
            // 
            // ServerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(315, 140);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarDownloadProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServerUpdate";
            this.Text = "Server Update";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerUpdate_FormClosing);
            this.Load += new System.EventHandler(this.ServerUpdate_Load);
            this.Shown += new System.EventHandler(this.ServerUpdate_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarDownloadProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private UserControls.MenuBar menuBar;
    }
}