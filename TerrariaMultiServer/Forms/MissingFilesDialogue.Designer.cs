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
            this.SuspendLayout();
            // 
            // lblMissingFiles
            // 
            this.lblMissingFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissingFiles.Location = new System.Drawing.Point(12, 9);
            this.lblMissingFiles.Name = "lblMissingFiles";
            this.lblMissingFiles.Size = new System.Drawing.Size(260, 13);
            this.lblMissingFiles.TabIndex = 0;
            this.lblMissingFiles.Text = "Missing Files";
            this.lblMissingFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxMissingFiles
            // 
            this.txtBoxMissingFiles.AcceptsReturn = true;
            this.txtBoxMissingFiles.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxMissingFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMissingFiles.Enabled = false;
            this.txtBoxMissingFiles.Location = new System.Drawing.Point(12, 25);
            this.txtBoxMissingFiles.Multiline = true;
            this.txtBoxMissingFiles.Name = "txtBoxMissingFiles";
            this.txtBoxMissingFiles.ReadOnly = true;
            this.txtBoxMissingFiles.Size = new System.Drawing.Size(260, 142);
            this.txtBoxMissingFiles.TabIndex = 1;
            this.txtBoxMissingFiles.Text = "\r\n";
            this.txtBoxMissingFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MissingFilesDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.txtBoxMissingFiles);
            this.Controls.Add(this.lblMissingFiles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MissingFilesDialogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MissingFilesDialogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMissingFiles;
        private System.Windows.Forms.TextBox txtBoxMissingFiles;
    }
}