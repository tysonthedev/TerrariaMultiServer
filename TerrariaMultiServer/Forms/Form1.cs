using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerrariaMultiServer.Properties;

namespace TerrariaMultiServer
{
    public partial class Form1 : Form
    {
        ServerManager serverManager;
        public Form1()
        {
            InitializeComponent();
            serverManager = new ServerManager();
            listBoxServers.DataSource = serverManager.serverList;
            listBoxServers.DisplayMember = "serverName";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverManager.SaveData();
            for (int i = 0; i < serverManager.serverList.Count; i++)
            {
                if(serverManager.serverList[i].isRunning)
                serverManager.serverList[i].StopServer();
            }
        }
        private void btnAddServer_Click(object sender, EventArgs e)
        {
            serverManager.AddServer();
        }
        private void btnRemoveServer_Click(object sender, EventArgs e)
        {
            if (listBoxServers.SelectedItem == null) return;
            serverManager.RemoveServerAt(listBoxServers.SelectedIndex);
        }
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (listBoxServers.SelectedItem == null)
            {
                MessageBox.Show("No Server Selected");
                return;
            }
            else
            {
                serverManager.StartServerAt(listBoxServers.SelectedIndex);
                listBoxServers_SelectedIndexChanged(null, EventArgs.Empty);
            }
        }
        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (listBoxServers.SelectedItem == null)
            {
                MessageBox.Show("No Server Selected");
                return;
            }
            else
            {
                serverManager.StopServerAt(listBoxServers.SelectedIndex);
            }
        }
        int previousIndex = 0;
        private void listBoxServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxServers.SelectedItem == null) return;
            if (listBoxServers.SelectedIndex < 0) return;
            if(serverManager.serverList.Count > previousIndex)
            serverManager.serverList[previousIndex].LogChanged -= ServerLogChanged;
            serverManager.serverList[listBoxServers.SelectedIndex].LogChanged += ServerLogChanged;
            txtBoxServerLog.Lines = serverManager.serverList[listBoxServers.SelectedIndex].serverLog;
            previousIndex = listBoxServers.SelectedIndex;
        }

        private void ServerLogChanged(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtBoxServerLog.Lines = serverManager.serverList[listBoxServers.SelectedIndex].serverLog;
                txtBoxServerLog.SelectionStart = txtBoxServerLog.Text.Length;
                txtBoxServerLog.ScrollToCaret();
            });
        }

        private void btnSaveWorld_Click(object sender, EventArgs e)
        {
            if(listBoxServers.SelectedItem != null)
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                serverManager.serverList[listBoxServers.SelectedIndex].RunCommand("save");
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }

        private async void btnSubmitCommand_Click(object sender, EventArgs e)
        {
            await serverManager.serverList[listBoxServers.SelectedIndex].RunCommand(txtBoxCommand.Text);
        }

        private void txtBoxCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == Keys.Enter.ToString()) 
            {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                serverManager.serverList[listBoxServers.SelectedIndex].RunCommand(txtBoxCommand.Text);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                txtBoxCommand.Text = "";
                e.SuppressKeyPress = true;
            }
        }

        private void btnServerSettings_Click(object sender, EventArgs e)
        {
            if (listBoxServers.SelectedItem != null) 
            {
                SettingsDialogue settingsDialogue = new SettingsDialogue(serverManager.serverList[listBoxServers.SelectedIndex].serverConfig, serverManager.appConfig);
                if (settingsDialogue.ShowDialog() == DialogResult.Yes) 
                {
                    serverManager.appConfig = settingsDialogue.appConfig;
                    if (listBoxServers.SelectedItem != null)
                        serverManager.serverList[listBoxServers.SelectedIndex].serverConfig = settingsDialogue.terrariaConfig;

                }
            }
        }
        private void txtBoxCommand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
