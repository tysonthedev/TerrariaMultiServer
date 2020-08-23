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
            this.SuspendLayout();
            // 
            // txtBoxServerName
            // 
            this.txtBoxServerName.Location = new System.Drawing.Point(95, 6);
            this.txtBoxServerName.Name = "txtBoxServerName";
            this.txtBoxServerName.Size = new System.Drawing.Size(271, 20);
            this.txtBoxServerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Directory";
            // 
            // txtBoxServerDirectory
            // 
            this.txtBoxServerDirectory.Location = new System.Drawing.Point(95, 29);
            this.txtBoxServerDirectory.Name = "txtBoxServerDirectory";
            this.txtBoxServerDirectory.Size = new System.Drawing.Size(240, 20);
            this.txtBoxServerDirectory.TabIndex = 3;
            // 
            // btnSelectServerDirectory
            // 
            this.btnSelectServerDirectory.Location = new System.Drawing.Point(341, 29);
            this.btnSelectServerDirectory.Name = "btnSelectServerDirectory";
            this.btnSelectServerDirectory.Size = new System.Drawing.Size(25, 20);
            this.btnSelectServerDirectory.TabIndex = 4;
            this.btnSelectServerDirectory.Text = "...";
            this.btnSelectServerDirectory.UseVisualStyleBackColor = true;
            this.btnSelectServerDirectory.Click += new System.EventHandler(this.btnSelectServerDirectory_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 55);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(354, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(354, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewServerDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 117);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSelectServerDirectory);
            this.Controls.Add(this.txtBoxServerDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxServerName);
            this.Name = "NewServerDialogue";
            this.Text = "NewServerDialogue";
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
    }
}