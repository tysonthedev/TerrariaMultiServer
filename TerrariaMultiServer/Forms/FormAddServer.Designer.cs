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
            this.menuBar1 = new TerrariaMultiServer.UserControls.MenuBar();
            this.SuspendLayout();
            // 
            // txtBoxServerName
            // 
            this.txtBoxServerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(157)))));
            this.txtBoxServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxServerName.Font = new System.Drawing.Font("Leelawadee", 8.25F);
            this.txtBoxServerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxServerName.Location = new System.Drawing.Point(102, 42);
            this.txtBoxServerName.Name = "txtBoxServerName";
            this.txtBoxServerName.Size = new System.Drawing.Size(308, 21);
            this.txtBoxServerName.TabIndex = 0;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Leelawadee", 8.25F);
            this.lblServerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerName.Location = new System.Drawing.Point(12, 45);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(70, 14);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "Server Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Directory";
            // 
            // txtBoxServerDirectory
            // 
            this.txtBoxServerDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(157)))));
            this.txtBoxServerDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxServerDirectory.Font = new System.Drawing.Font("Leelawadee", 8.25F);
            this.txtBoxServerDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxServerDirectory.Location = new System.Drawing.Point(102, 65);
            this.txtBoxServerDirectory.Name = "txtBoxServerDirectory";
            this.txtBoxServerDirectory.Size = new System.Drawing.Size(277, 21);
            this.txtBoxServerDirectory.TabIndex = 3;
            // 
            // btnDirectoryWindow
            // 
            this.btnDirectoryWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnDirectoryWindow.FlatAppearance.BorderSize = 0;
            this.btnDirectoryWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectoryWindow.Font = new System.Drawing.Font("Leelawadee", 8.25F);
            this.btnDirectoryWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDirectoryWindow.Location = new System.Drawing.Point(385, 65);
            this.btnDirectoryWindow.Name = "btnDirectoryWindow";
            this.btnDirectoryWindow.Size = new System.Drawing.Size(25, 22);
            this.btnDirectoryWindow.TabIndex = 4;
            this.btnDirectoryWindow.Text = "...";
            this.btnDirectoryWindow.UseVisualStyleBackColor = false;
            this.btnDirectoryWindow.Click += new System.EventHandler(this.btnDirectoryWindow_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Leelawadee", 8.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(12, 91);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(398, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Leelawadee", 8.25F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(12, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(398, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuBar1
            // 
            this.menuBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.menuBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(422, 30);
            this.menuBar1.TabIndex = 7;
            // 
            // FormAddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(422, 150);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDirectoryWindow);
            this.Controls.Add(this.txtBoxServerDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.txtBoxServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Server";
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
        private UserControls.MenuBar menuBar1;
    }
}