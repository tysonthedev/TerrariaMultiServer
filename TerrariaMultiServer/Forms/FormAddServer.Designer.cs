namespace TerrariaMultiServer
{
    partial class FormAddServer
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
            this.txtBoxServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxServerDirectory = new System.Windows.Forms.TextBox();
            this.btnDirectoryWindow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxServerName
            // 
            this.txtBoxServerName.Location = new System.Drawing.Point(102, 12);
            this.txtBoxServerName.Name = "txtBoxServerName";
            this.txtBoxServerName.Size = new System.Drawing.Size(308, 20);
            this.txtBoxServerName.TabIndex = 0;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(12, 15);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(69, 13);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "Server Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Directory";
            // 
            // txtBoxServerDirectory
            // 
            this.txtBoxServerDirectory.Location = new System.Drawing.Point(102, 35);
            this.txtBoxServerDirectory.Name = "txtBoxServerDirectory";
            this.txtBoxServerDirectory.Size = new System.Drawing.Size(277, 20);
            this.txtBoxServerDirectory.TabIndex = 3;
            // 
            // btnDirectoryWindow
            // 
            this.btnDirectoryWindow.Location = new System.Drawing.Point(385, 34);
            this.btnDirectoryWindow.Name = "btnDirectoryWindow";
            this.btnDirectoryWindow.Size = new System.Drawing.Size(25, 22);
            this.btnDirectoryWindow.TabIndex = 4;
            this.btnDirectoryWindow.Text = "...";
            this.btnDirectoryWindow.UseVisualStyleBackColor = true;
            this.btnDirectoryWindow.Click += new System.EventHandler(this.btnDirectoryWindow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(398, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(398, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 119);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDirectoryWindow);
            this.Controls.Add(this.txtBoxServerDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.txtBoxServerName);
            this.Name = "FormAddServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxServerDirectory;
        private System.Windows.Forms.Button btnDirectoryWindow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}