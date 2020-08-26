using System.Drawing;

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
            this.menuBar1 = new TerrariaMultiServer.UserControls.MenuBar();
            this.SuspendLayout();
            // 
            // listBoxServers
            // 
            this.listBoxServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(157)))));
            this.listBoxServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxServers.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxServers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBoxServers.FormattingEnabled = true;
            this.listBoxServers.ItemHeight = 14;
            this.listBoxServers.Location = new System.Drawing.Point(13, 60);
            this.listBoxServers.Name = "listBoxServers";
            this.listBoxServers.Size = new System.Drawing.Size(208, 84);
            this.listBoxServers.Sorted = true;
            this.listBoxServers.TabIndex = 1;
            this.listBoxServers.SelectedIndexChanged += new System.EventHandler(this.listBoxServers_SelectedIndexChanged);
            // 
            // btnAddServer
            // 
            this.btnAddServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnAddServer.FlatAppearance.BorderSize = 0;
            this.btnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServer.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddServer.Location = new System.Drawing.Point(12, 161);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(99, 23);
            this.btnAddServer.TabIndex = 2;
            this.btnAddServer.Text = "Add Server";
            this.btnAddServer.UseVisualStyleBackColor = false;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // btnRemoveServer
            // 
            this.btnRemoveServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnRemoveServer.FlatAppearance.BorderSize = 0;
            this.btnRemoveServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveServer.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveServer.Location = new System.Drawing.Point(121, 161);
            this.btnRemoveServer.Name = "btnRemoveServer";
            this.btnRemoveServer.Size = new System.Drawing.Size(99, 23);
            this.btnRemoveServer.TabIndex = 3;
            this.btnRemoveServer.Text = "Remove Server";
            this.btnRemoveServer.UseVisualStyleBackColor = false;
            this.btnRemoveServer.Click += new System.EventHandler(this.btnRemoveServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnStartServer.FlatAppearance.BorderSize = 0;
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartServer.Location = new System.Drawing.Point(12, 190);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(208, 23);
            this.btnStartServer.TabIndex = 4;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnStopServer.FlatAppearance.BorderSize = 0;
            this.btnStopServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopServer.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStopServer.Location = new System.Drawing.Point(12, 219);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(208, 23);
            this.btnStopServer.TabIndex = 5;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = false;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(223, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Console Log";
            // 
            // txtBoxCommand
            // 
            this.txtBoxCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(157)))));
            this.txtBoxCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCommand.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxCommand.Location = new System.Drawing.Point(227, 280);
            this.txtBoxCommand.Name = "txtBoxCommand";
            this.txtBoxCommand.Size = new System.Drawing.Size(495, 21);
            this.txtBoxCommand.TabIndex = 9;
            this.txtBoxCommand.TextChanged += new System.EventHandler(this.txtBoxCommand_TextChanged);
            this.txtBoxCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxCommand_KeyDown);
            // 
            // btnSubmitCommand
            // 
            this.btnSubmitCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnSubmitCommand.FlatAppearance.BorderSize = 0;
            this.btnSubmitCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitCommand.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCommand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmitCommand.Location = new System.Drawing.Point(727, 278);
            this.btnSubmitCommand.Name = "btnSubmitCommand";
            this.btnSubmitCommand.Size = new System.Drawing.Size(61, 22);
            this.btnSubmitCommand.TabIndex = 10;
            this.btnSubmitCommand.Text = "Submit";
            this.btnSubmitCommand.UseVisualStyleBackColor = false;
            this.btnSubmitCommand.Click += new System.EventHandler(this.btnSubmitCommand_Click);
            // 
            // btnSaveWorld
            // 
            this.btnSaveWorld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnSaveWorld.FlatAppearance.BorderSize = 0;
            this.btnSaveWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveWorld.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWorld.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveWorld.Location = new System.Drawing.Point(12, 248);
            this.btnSaveWorld.Name = "btnSaveWorld";
            this.btnSaveWorld.Size = new System.Drawing.Size(208, 23);
            this.btnSaveWorld.TabIndex = 12;
            this.btnSaveWorld.Text = "Save World";
            this.btnSaveWorld.UseVisualStyleBackColor = false;
            this.btnSaveWorld.Click += new System.EventHandler(this.btnSaveWorld_Click);
            // 
            // txtBoxServerLog
            // 
            this.txtBoxServerLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(157)))));
            this.txtBoxServerLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxServerLog.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServerLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxServerLog.Location = new System.Drawing.Point(227, 60);
            this.txtBoxServerLog.Multiline = true;
            this.txtBoxServerLog.Name = "txtBoxServerLog";
            this.txtBoxServerLog.ReadOnly = true;
            this.txtBoxServerLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxServerLog.Size = new System.Drawing.Size(562, 211);
            this.txtBoxServerLog.TabIndex = 13;
            // 
            // btnServerSettings
            // 
            this.btnServerSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.btnServerSettings.FlatAppearance.BorderSize = 0;
            this.btnServerSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerSettings.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServerSettings.Location = new System.Drawing.Point(12, 277);
            this.btnServerSettings.Name = "btnServerSettings";
            this.btnServerSettings.Size = new System.Drawing.Size(208, 23);
            this.btnServerSettings.TabIndex = 14;
            this.btnServerSettings.Text = "Settings";
            this.btnServerSettings.UseVisualStyleBackColor = false;
            this.btnServerSettings.Click += new System.EventHandler(this.btnServerSettings_Click);
            // 
            // menuBar1
            // 
            this.menuBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.menuBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(800, 30);
            this.menuBar1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.menuBar1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Terraria Server Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private UserControls.MenuBar menuBar1;
    }
}

