namespace TerrariaMultiServer
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
            this.listBoxServers = new System.Windows.Forms.ListBox();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.btnRemoveServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCommand = new System.Windows.Forms.TextBox();
            this.btnSubmitCommand = new System.Windows.Forms.Button();
            this.btnSaveWorld = new System.Windows.Forms.Button();
            this.txtBoxServerLog = new System.Windows.Forms.TextBox();
            this.btnServerSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxServers
            // 
            this.listBoxServers.FormattingEnabled = true;
            this.listBoxServers.Location = new System.Drawing.Point(12, 30);
            this.listBoxServers.Name = "listBoxServers";
            this.listBoxServers.Size = new System.Drawing.Size(208, 95);
            this.listBoxServers.TabIndex = 1;
            this.listBoxServers.SelectedIndexChanged += new System.EventHandler(this.listBoxServers_SelectedIndexChanged);
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(12, 131);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(99, 23);
            this.btnAddServer.TabIndex = 2;
            this.btnAddServer.Text = "Add Server";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // btnRemoveServer
            // 
            this.btnRemoveServer.Location = new System.Drawing.Point(121, 131);
            this.btnRemoveServer.Name = "btnRemoveServer";
            this.btnRemoveServer.Size = new System.Drawing.Size(99, 23);
            this.btnRemoveServer.TabIndex = 3;
            this.btnRemoveServer.Text = "Remove Server";
            this.btnRemoveServer.UseVisualStyleBackColor = true;
            this.btnRemoveServer.Click += new System.EventHandler(this.btnRemoveServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(12, 160);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(208, 23);
            this.btnStartServer.TabIndex = 4;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(12, 189);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(208, 23);
            this.btnStopServer.TabIndex = 5;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Console Log";
            // 
            // txtBoxCommand
            // 
            this.txtBoxCommand.Location = new System.Drawing.Point(226, 250);
            this.txtBoxCommand.Name = "txtBoxCommand";
            this.txtBoxCommand.Size = new System.Drawing.Size(495, 20);
            this.txtBoxCommand.TabIndex = 9;
            this.txtBoxCommand.TextChanged += new System.EventHandler(this.txtBoxCommand_TextChanged);
            this.txtBoxCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxCommand_KeyDown);
            // 
            // btnSubmitCommand
            // 
            this.btnSubmitCommand.Location = new System.Drawing.Point(727, 248);
            this.btnSubmitCommand.Name = "btnSubmitCommand";
            this.btnSubmitCommand.Size = new System.Drawing.Size(61, 22);
            this.btnSubmitCommand.TabIndex = 10;
            this.btnSubmitCommand.Text = "Submit";
            this.btnSubmitCommand.UseVisualStyleBackColor = true;
            this.btnSubmitCommand.Click += new System.EventHandler(this.btnSubmitCommand_Click);
            // 
            // btnSaveWorld
            // 
            this.btnSaveWorld.Location = new System.Drawing.Point(12, 218);
            this.btnSaveWorld.Name = "btnSaveWorld";
            this.btnSaveWorld.Size = new System.Drawing.Size(208, 23);
            this.btnSaveWorld.TabIndex = 12;
            this.btnSaveWorld.Text = "Save World";
            this.btnSaveWorld.UseVisualStyleBackColor = true;
            this.btnSaveWorld.Click += new System.EventHandler(this.btnSaveWorld_Click);
            // 
            // txtBoxServerLog
            // 
            this.txtBoxServerLog.Location = new System.Drawing.Point(226, 30);
            this.txtBoxServerLog.Multiline = true;
            this.txtBoxServerLog.Name = "txtBoxServerLog";
            this.txtBoxServerLog.ReadOnly = true;
            this.txtBoxServerLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxServerLog.Size = new System.Drawing.Size(562, 211);
            this.txtBoxServerLog.TabIndex = 13;
            // 
            // btnServerSettings
            // 
            this.btnServerSettings.Location = new System.Drawing.Point(12, 247);
            this.btnServerSettings.Name = "btnServerSettings";
            this.btnServerSettings.Size = new System.Drawing.Size(208, 23);
            this.btnServerSettings.TabIndex = 14;
            this.btnServerSettings.Text = "Settings";
            this.btnServerSettings.UseVisualStyleBackColor = true;
            this.btnServerSettings.Click += new System.EventHandler(this.btnServerSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.btnServerSettings);
            this.Controls.Add(this.txtBoxServerLog);
            this.Controls.Add(this.btnSaveWorld);
            this.Controls.Add(this.btnSubmitCommand);
            this.Controls.Add(this.txtBoxCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.btnRemoveServer);
            this.Controls.Add(this.btnAddServer);
            this.Controls.Add(this.listBoxServers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxServers;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Button btnRemoveServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCommand;
        private System.Windows.Forms.Button btnSubmitCommand;
        private System.Windows.Forms.Button btnSaveWorld;
        private System.Windows.Forms.TextBox txtBoxServerLog;
        private System.Windows.Forms.Button btnServerSettings;
    }
}

