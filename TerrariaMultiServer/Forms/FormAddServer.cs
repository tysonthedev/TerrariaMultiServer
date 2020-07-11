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

namespace TerrariaMultiServer
{
    public partial class FormAddServer : Form
    {
        public FormData formData;
        public FormAddServer()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            formData = new FormData(txtBoxServerName.Text, txtBoxServerDirectory.Text);
            if (formData.serverName == "") 
            {
                MessageBox.Show("missing a server name");
                return;
            }
            if (!Directory.Exists(formData.serverDirectory)) 
            {
                MessageBox.Show("missing or invalid server directory");
                return;
            }
            //check to make sure this is a terraria server directory and has all of the files necessary for this program
            var requiredFiles = new[]
            {
                (nameOfFile:"changelog.txt",doesFileExist:false),
                (nameOfFile:"serverconfig.txt",doesFileExist:false),
                (nameOfFile: "start-server.bat", doesFileExist: false),
                (nameOfFile: "TerrariaServer.exe", doesFileExist: false),
                (nameOfFile: "ReLogic.Native.dll", doesFileExist: false)
            };
            string[] filesInDirectory = Directory.GetFiles(formData.serverDirectory);
            for (int i = 0; i < filesInDirectory.Length; i++)
            {
                for (int a = 0; a < requiredFiles.Length; a++)
                {
                    if (requiredFiles[a].nameOfFile == Path.GetFileName(filesInDirectory[i])) requiredFiles[a].doesFileExist = true;
                }
            }
            List<string> missingFiles = new List<string>();
            for (int i = 0; i < requiredFiles.Length; i++)
            {
                if (requiredFiles[i].doesFileExist == false)
                {
                    missingFiles.Add(requiredFiles[i].nameOfFile);
                }
            }
            if (missingFiles.Count > 0)
            {
                MissingFilesDialogue missingFilesDialogue = new MissingFilesDialogue(missingFiles.ToArray());
                missingFilesDialogue.ShowDialog();
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDirectoryWindow_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select Terraria Server Folder";
            folderBrowserDialog.ShowDialog();
            txtBoxServerDirectory.Text = folderBrowserDialog.SelectedPath;
        }
        public class FormData
        {
            public string serverName;
            public string serverDirectory;
            public FormData(string _serverName, string _serverDirectory) 
            {
                serverName = _serverName;
                serverDirectory = _serverDirectory;
            }
        }
    }
}
