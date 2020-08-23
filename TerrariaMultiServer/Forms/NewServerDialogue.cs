using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaMultiServer.Forms
{
    public partial class NewServerDialogue : Form
    {
        public string serverName;
        public string serverDirectory;
        public NewServerDialogue()
        {
            InitializeComponent();
        }


        private void btnSelectServerDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = true;
            folderDialog.SelectedPath = txtBoxServerDirectory.Text;
            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxServerDirectory.Text = folderDialog.SelectedPath;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtBoxServerName.Text == "")
            {
                MessageBox.Show("missing a server name");
                return;
            }
            if (!Directory.Exists(txtBoxServerDirectory.Text))
            {
                MessageBox.Show("missing or invalid server directory");
                return;
            }
            serverName = txtBoxServerName.Text;
            serverDirectory = txtBoxServerDirectory.Text;
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void NewServerDialogue_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
