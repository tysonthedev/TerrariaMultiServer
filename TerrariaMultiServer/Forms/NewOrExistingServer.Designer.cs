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
            this.SuspendLayout();
            // 
            // btnNewServer
            // 
            this.btnNewServer.Location = new System.Drawing.Point(12, 10);
            this.btnNewServer.Name = "btnNewServer";
            this.btnNewServer.Size = new System.Drawing.Size(110, 23);
            this.btnNewServer.TabIndex = 0;
            this.btnNewServer.Text = "New Server";
            this.btnNewServer.UseVisualStyleBackColor = true;
            this.btnNewServer.Click += new System.EventHandler(this.btnNewServer_Click);
            // 
            // btnExistingServer
            // 
            this.btnExistingServer.Location = new System.Drawing.Point(128, 10);
            this.btnExistingServer.Name = "btnExistingServer";
            this.btnExistingServer.Size = new System.Drawing.Size(110, 23);
            this.btnExistingServer.TabIndex = 1;
            this.btnExistingServer.Text = "Existing Server";
            this.btnExistingServer.UseVisualStyleBackColor = true;
            this.btnExistingServer.Click += new System.EventHandler(this.btnExistingServer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 39);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(224, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewOrExistingServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 71);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExistingServer);
            this.Controls.Add(this.btnNewServer);
            this.Name = "NewOrExistingServer";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.NewOrExistingServer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewServer;
        private System.Windows.Forms.Button btnExistingServer;
        private System.Windows.Forms.Button btnCancel;
    }
}