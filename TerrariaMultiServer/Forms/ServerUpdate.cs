using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace TerrariaMultiServer
{
    public partial class ServerUpdate : Form
    {
        string DownloadLocation;
        string fileDownloadLink;
        string serverDirectory;
        int versionUpdatingTo;
        WebClient webClient = new WebClient();
        public ServerUpdate(string _fileDownloadLink, int _versionUpdatingTo, string _serverDirectory)
        {
            fileDownloadLink = _fileDownloadLink;
            DownloadLocation = Application.StartupPath + "\\Downloads";
            if (!Directory.Exists(DownloadLocation)) Directory.CreateDirectory(DownloadLocation);
            serverDirectory = _serverDirectory;
            versionUpdatingTo = _versionUpdatingTo;
            InitializeComponent();
            this.Text = "Updating To Version " + versionUpdatingTo.ToString();
        }

        private void ServerUpdate_Load(object sender, EventArgs e)
        {

        }
        private void changeStatus(string message)
        {
            txtBoxStatus.Text = message;
        }
        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarDownloadProgress.Value = e.ProgressPercentage;
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            changeStatus("finished downloading latest version");
            btnCancel.Visible = false;
            changeStatus("extracting server files");
            if (!File.Exists(DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString() + ".zip"))
            {
                changeStatus("server zip file doesn't exist, can't update server");
                return;
            }
            else
            {
                if (!Directory.Exists(DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString()))
                {
                    ZipFile.ExtractToDirectory(DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString() + ".zip", DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString());
                }
                changeStatus("replacing old server files");
                UpdateServerFiles();
            }
        }
        void FindServerFilesDirectory(DirectoryInfo directoryInfo,ref string serverFilesDirectory)
        {
            FileInfo[] directoryFiles = directoryInfo.GetFiles();
            foreach (FileInfo file in directoryFiles)
            {
                if (file.Name == "TerrariaServer.exe") 
                {
                    serverFilesDirectory = directoryInfo.FullName;
                    return;
                }
            }
            DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                FindServerFilesDirectory(subDirectory,ref serverFilesDirectory);
            }
        }
        void UpdateServerFiles() 
        {
            void safeReplaceFile(string sourceFilePath, string destinationFilePath) 
            {
                //if both files exist then replace the destination file
                if (File.Exists(sourceFilePath) && File.Exists(destinationFilePath))
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                }
                //if the source file exists but not the destination file then just copy the source file over
                else if (File.Exists(sourceFilePath) && !File.Exists(destinationFilePath))
                {
                    File.Copy(sourceFilePath, destinationFilePath);
                }
                //if the source file doesn't exist then let the user know and don't do anything
                else 
                {
                    MessageBox.Show(sourceFilePath + " doesn't exist");
                }
            }
            string sourceDirectory = "";
            if (!Directory.Exists(DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString())) return;

            FindServerFilesDirectory(new DirectoryInfo(DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString()), ref sourceDirectory);

            if (sourceDirectory == "")
            {
                MessageBox.Show("couldn't find server files");
            }
            else if (Directory.Exists(sourceDirectory) && Directory.Exists(serverDirectory))
            {
                safeReplaceFile(sourceDirectory + "\\TerrariaServer.exe", serverDirectory + "\\TerrariaServer.exe");
                safeReplaceFile(sourceDirectory + "\\changelog.txt", serverDirectory + "\\changelog.txt");
                safeReplaceFile(sourceDirectory + "\\ReLogic.Native.dll", serverDirectory + "\\ReLogic.Native.dll");
                if (!File.Exists(serverDirectory + "serverconfig.txt")) safeReplaceFile(sourceDirectory + "\\serverconfig.txt", serverDirectory + "\\serverconfig.txt");
            }
            else 
            {
                MessageBox.Show("file path issues can't update server files");
            }
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to cancel the server download?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) webClient.CancelAsync();
            if (File.Exists(DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString() + ".zip"))
            {
                File.Delete(DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString() + ".zip");
            }
                this.Close();
        }

        private void ServerUpdate_Shown(object sender, EventArgs e)
        {
            changeStatus("checking downloads folder for latest version");
            if (File.Exists(DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString() + ".zip"))
            {
                changeStatus("found latest version");
                progressBarDownloadProgress.Value = 100;
                btnCancel.Visible = false;
                changeStatus("checking for already extracted files");
                if (!Directory.Exists(DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString()))
                {
                    changeStatus("extracting server files");
                    ZipFile.ExtractToDirectory(DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString() + ".zip", DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString());
                }
                else 
                {
                    changeStatus("files already extracted");
                }
                changeStatus("replacing old server files");
                UpdateServerFiles();

            }
            else
            {
                webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
                webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                webClient.DownloadFileAsync(new Uri(fileDownloadLink), DownloadLocation + "\\terraria-server-" + versionUpdatingTo.ToString() + ".zip");
                changeStatus("downloading latest version");
            }
        }
    }
}
