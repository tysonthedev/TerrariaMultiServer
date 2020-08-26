namespace TerrariaMultiServer
{
    partial class MissingFilesDialogue
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
            this.lblMissingFiles = new System.Windows.Forms.Label();
            this.txtBoxMissingFiles = new System.Windows.Forms.TextBox();
            this.menuBar1 = new TerrariaMultiServer.UserControls.MenuBar();
            this.SuspendLayout();
            // 
            // lblMissingFiles
            // 
            this.lblMissingFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissingFiles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMissingFiles.Location = new System.Drawing.Point(12, 39);
            this.lblMissingFiles.Name = "lblMissingFiles";
            this.lblMissingFiles.Size = new System.Drawing.Size(260, 13);
            this.lblMissingFiles.TabIndex = 0;
            this.lblMissingFiles.Text = "Missing Files";
            this.lblMissingFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxMissingFiles
            // 
            this.txtBoxMissingFiles.AcceptsReturn = true;
            this.txtBoxMissingFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(157)))));
            this.txtBoxMissingFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMissingFiles.Enabled = false;
            this.txtBoxMissingFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxMissingFiles.Location = new System.Drawing.Point(12, 55);
            this.txtBoxMissingFiles.Multiline = true;
            this.txtBoxMissingFiles.Name = "txtBoxMissingFiles";
            this.txtBoxMissingFiles.ReadOnly = true;
            this.txtBoxMissingFiles.Size = new System.Drawing.Size(260, 142);
            this.txtBoxMissingFiles.TabIndex = 1;
            this.txtBoxMissingFiles.Text = "\r\n";
            this.txtBoxMissingFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuBar1
            // 
            this.menuBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.menuBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(284, 30);
            this.menuBar1.TabIndex = 2;
            // 
            // MissingFilesDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.txtBoxMissingFiles);
            this.Controls.Add(this.lblMissingFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MissingFilesDialogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Missing Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMissingFiles;
        private System.Windows.Forms.TextBox txtBoxMissingFiles;
        private UserControls.MenuBar menuBar1;
    }
}