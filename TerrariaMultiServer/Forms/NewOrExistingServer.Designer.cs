namespace TerrariaMultiServer.Forms
{
    partial class NewOrExistingServer
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
            this.btnNewServer = new System.Windows.Forms.Button();
            this.btnExistingServer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuBar1 = new TerrariaMultiServer.UserControls.MenuBar();
            this.SuspendLayout();
            // 
            // btnNewServer
            // 
            this.btnNewServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnNewServer.FlatAppearance.BorderSize = 0;
            this.btnNewServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewServer.Location = new System.Drawing.Point(12, 40);
            this.btnNewServer.Name = "btnNewServer";
            this.btnNewServer.Size = new System.Drawing.Size(110, 23);
            this.btnNewServer.TabIndex = 0;
            this.btnNewServer.Text = "New Server";
            this.btnNewServer.UseVisualStyleBackColor = false;
            this.btnNewServer.Click += new System.EventHandler(this.btnNewServer_Click);
            // 
            // btnExistingServer
            // 
            this.btnExistingServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnExistingServer.FlatAppearance.BorderSize = 0;
            this.btnExistingServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExistingServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExistingServer.Location = new System.Drawing.Point(128, 40);
            this.btnExistingServer.Name = "btnExistingServer";
            this.btnExistingServer.Size = new System.Drawing.Size(110, 23);
            this.btnExistingServer.TabIndex = 1;
            this.btnExistingServer.Text = "Existing Server";
            this.btnExistingServer.UseVisualStyleBackColor = false;
            this.btnExistingServer.Click += new System.EventHandler(this.btnExistingServer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(12, 69);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(224, 23);
            this.btnCancel.TabIndex = 2;
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
            this.menuBar1.Size = new System.Drawing.Size(248, 30);
            this.menuBar1.TabIndex = 3;
            // 
            // NewOrExistingServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(248, 100);
            this.ControlBox = false;
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExistingServer);
            this.Controls.Add(this.btnNewServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewOrExistingServer";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.NewOrExistingServer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewServer;
        private System.Windows.Forms.Button btnExistingServer;
        private System.Windows.Forms.Button btnCancel;
        private UserControls.MenuBar menuBar1;
    }
}