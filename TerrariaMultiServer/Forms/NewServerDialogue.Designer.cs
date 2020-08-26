namespace TerrariaMultiServer.Forms
{
    partial class NewServerDialogue
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxServerDirectory = new System.Windows.Forms.TextBox();
            this.btnSelectServerDirectory = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuBar1 = new TerrariaMultiServer.UserControls.MenuBar();
            this.SuspendLayout();
            // 
            // txtBoxServerName
            // 
            this.txtBoxServerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(157)))));
            this.txtBoxServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxServerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxServerName.Location = new System.Drawing.Point(95, 36);
            this.txtBoxServerName.Name = "txtBoxServerName";
            this.txtBoxServerName.Size = new System.Drawing.Size(271, 20);
            this.txtBoxServerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Directory";
            // 
            // txtBoxServerDirectory
            // 
            this.txtBoxServerDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(157)))));
            this.txtBoxServerDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxServerDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxServerDirectory.Location = new System.Drawing.Point(95, 59);
            this.txtBoxServerDirectory.Name = "txtBoxServerDirectory";
            this.txtBoxServerDirectory.Size = new System.Drawing.Size(240, 20);
            this.txtBoxServerDirectory.TabIndex = 3;
            // 
            // btnSelectServerDirectory
            // 
            this.btnSelectServerDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnSelectServerDirectory.FlatAppearance.BorderSize = 0;
            this.btnSelectServerDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectServerDirectory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectServerDirectory.Location = new System.Drawing.Point(341, 59);
            this.btnSelectServerDirectory.Name = "btnSelectServerDirectory";
            this.btnSelectServerDirectory.Size = new System.Drawing.Size(25, 20);
            this.btnSelectServerDirectory.TabIndex = 4;
            this.btnSelectServerDirectory.Text = "...";
            this.btnSelectServerDirectory.UseVisualStyleBackColor = false;
            this.btnSelectServerDirectory.Click += new System.EventHandler(this.btnSelectServerDirectory_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(12, 85);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(354, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(12, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(354, 23);
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
            this.menuBar1.Size = new System.Drawing.Size(378, 30);
            this.menuBar1.TabIndex = 7;
            // 
            // NewServerDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(378, 145);
            this.ControlBox = false;
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSelectServerDirectory);
            this.Controls.Add(this.txtBoxServerDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewServerDialogue";
            this.Text = "New Server";
            this.Load += new System.EventHandler(this.NewServerDialogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxServerDirectory;
        private System.Windows.Forms.Button btnSelectServerDirectory;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private UserControls.MenuBar menuBar1;
    }
}