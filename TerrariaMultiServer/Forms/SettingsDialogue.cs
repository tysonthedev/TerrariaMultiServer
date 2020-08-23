using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaMultiServer
{
    public partial class SettingsDialogue : Form
    {
        public string ServerName;
        public TerrariaConfig terrariaConfig;
        public AppConfig appConfig;

        public SettingsDialogue(string serverName,TerrariaConfig _terrariaConfig, AppConfig _appConfig)
        {
            InitializeComponent();
            ServerName = serverName;
            txtBoxServerName.Text = serverName;
            terrariaConfig = _terrariaConfig;
            appConfig = _appConfig;
            if (serverName == null) ServerName = "";
            if (terrariaConfig == null) terrariaConfig = new TerrariaConfig();
            if (appConfig == null) appConfig = new AppConfig();
            txtBoxPort.Text = terrariaConfig.config["port"];
            txtBoxMaxPlayers.Text = terrariaConfig.config["maxplayers"];
            txtBoxWorld.Text = terrariaConfig.config["world"];
            txtBoxWorldPath.Text = terrariaConfig.config["worldpath"];
            int comboBoxTemp;
            if (!int.TryParse(terrariaConfig.config["autocreate"], out comboBoxTemp)) comboBoxTemp = 0;
            comboBoxAutoCreate.SelectedIndex = comboBoxTemp == 3 ? 2 : comboBoxTemp - 1;
            txtBoxBanList.Text = terrariaConfig.config["banlist"];
            txtBoxWorldName.Text = terrariaConfig.config["worldname"];
            comboBoxSecure.SelectedIndex = int.TryParse(terrariaConfig.config["secure"], out comboBoxTemp) ? comboBoxTemp : 0;
            comboBoxUPNP.SelectedIndex = int.TryParse(terrariaConfig.config["upnp"], out comboBoxTemp) ? comboBoxTemp : 0;
            txtBoxIP.Text = terrariaConfig.config["ip"];
            txtBoxSeed.Text = terrariaConfig.config["seed"];
            comboBoxDifficulty.SelectedIndex = int.TryParse(terrariaConfig.config["difficulty"], out comboBoxTemp) ? comboBoxTemp : 0;
            txtBoxMOTD.Text = terrariaConfig.config["motd"];
            comboBoxLanguage.SelectedIndex = int.TryParse(terrariaConfig.config["language"], out comboBoxTemp) ? comboBoxTemp : 0;
            //the default priority we want for the user is normal
            comboBoxPriority.SelectedIndex = int.TryParse(terrariaConfig.config["priority"], out comboBoxTemp) ? comboBoxTemp : 3;
            txtBoxNpcStream.Text = terrariaConfig.config["npcstream"];
            txtBoxPassword.Text = terrariaConfig.config["password"];
            checkBoxCrossServerChat.Checked = appConfig.allowCrossServerChat;
            checkBoxCrossServerPlayingCommand.Checked = appConfig.doCrossServerPlayingCommand;
            checkBoxAllowMobileAppControl.Checked = appConfig.allowMobileAppControl;
            checkBoxAutoUpdateServer.Checked = appConfig.autoUpdateServer;
            checkBoxExit.Checked = appConfig.config["exit"];
            checkBoxExitNoSave.Checked = appConfig.config["exit-nosave"];
            checkBoxSave.Checked = appConfig.config["save"];
            checkBoxKick.Checked = appConfig.config["kick"];
            checkBoxBan.Checked = appConfig.config["ban"];
            checkBoxPassword.Checked = appConfig.config["password"];
            checkBoxPasswordSet.Checked = appConfig.config["setpassword"];
            checkBoxVersion.Checked = appConfig.config["version"];
            checkBoxTime.Checked = appConfig.config["time"];
            checkBoxPort.Checked = appConfig.config["port"];
            checkBoxMaxPlayers.Checked = appConfig.config["maxplayers"];
            checkBoxMotd.Checked = appConfig.config["motd"];
            checkBoxMotdSet.Checked = appConfig.config["setmotd"];
            checkBoxDawn.Checked = appConfig.config["dawn"];
            checkBoxNoon.Checked = appConfig.config["noon"];
            checkBoxDusk.Checked = appConfig.config["dusk"];
            checkBoxMidnight.Checked = appConfig.config["midnight"];
            checkBoxSettle.Checked = appConfig.config["settle"];
            checkBoxSeed.Checked = appConfig.config["seed"];
            checkBoxPlaying.Checked = appConfig.config["playing"];
        }

        private void SettingsDialogue_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ServerName = txtBoxServerName.Text;
            terrariaConfig.config["port"] = txtBoxPort.Text;
            terrariaConfig.config["maxplayers"] = txtBoxMaxPlayers.Text;
            terrariaConfig.config["world"] = txtBoxWorld.Text;
            terrariaConfig.config["autocreate"] = comboBoxAutoCreate.SelectedItem != null ? (comboBoxAutoCreate.SelectedIndex + 1).ToString() : "";
            terrariaConfig.config["banlist"] = txtBoxBanList.Text;
            terrariaConfig.config["worldname"] = txtBoxWorldName.Text;
            terrariaConfig.config["worldpath"] = txtBoxWorldPath.Text;
            terrariaConfig.config["secure"] = comboBoxSecure.SelectedItem != null ? comboBoxSecure.SelectedIndex.ToString() : "";
            terrariaConfig.config["upnp"] = comboBoxUPNP.SelectedItem != null ? comboBoxUPNP.SelectedIndex.ToString() : "";
            terrariaConfig.config["ip"] = txtBoxIP.Text;
            terrariaConfig.config["seed"] = txtBoxSeed.Text;
            terrariaConfig.config["difficulty"] = comboBoxDifficulty.SelectedItem != null ? comboBoxDifficulty.SelectedIndex.ToString() : "";
            terrariaConfig.config["motd"] = txtBoxMOTD.Text;
            terrariaConfig.config["language"] = comboBoxLanguage.SelectedItem != null ? comboBoxLanguage.Text : "";
            terrariaConfig.config["priority"] = comboBoxPriority.SelectedItem != null ? comboBoxPriority.SelectedIndex.ToString() : "";
            terrariaConfig.config["npcstream"] = txtBoxNpcStream.Text;
            terrariaConfig.config["password"] = txtBoxPassword.Text;
            appConfig.allowCrossServerChat = checkBoxCrossServerChat.Checked;
            appConfig.doCrossServerPlayingCommand = checkBoxCrossServerPlayingCommand.Checked;
            appConfig.allowMobileAppControl = checkBoxAllowMobileAppControl.Checked;
            appConfig.autoUpdateServer = checkBoxAutoUpdateServer.Checked;
            appConfig.config["exit"] = checkBoxExit.Checked;
            appConfig.config["exit-nosave"] = checkBoxExitNoSave.Checked;
            appConfig.config["save"] = checkBoxSave.Checked;
            appConfig.config["kick"] = checkBoxKick.Checked;
            appConfig.config["ban"] = checkBoxBan.Checked;
            appConfig.config["password"] = checkBoxPassword.Checked;
            appConfig.config["setpassword"] = checkBoxPasswordSet.Checked;
            appConfig.config["version"] = checkBoxVersion.Checked;
            appConfig.config["time"] = checkBoxTime.Checked;
            appConfig.config["port"] = checkBoxPort.Checked;
            appConfig.config["maxplayers"] = checkBoxMaxPlayers.Checked;
            appConfig.config["motd"] = checkBoxMotd.Checked;
            appConfig.config["setmotd"] = checkBoxMotdSet.Checked;
            appConfig.config["dawn"] = checkBoxDawn.Checked;
            appConfig.config["noon"] = checkBoxNoon.Checked;
            appConfig.config["dusk"] = checkBoxDusk.Checked;
            appConfig.config["midnight"] = checkBoxMidnight.Checked;
            appConfig.config["settle"] = checkBoxSettle.Checked;
            appConfig.config["seed"] = checkBoxSeed.Checked;
            appConfig.config["playing"] = checkBoxPlaying.Checked;
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void comboBoxAutoCreate_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void btnFileDialogueWorld_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.CheckFileExists = true;
            fileDialog.InitialDirectory = txtBoxWorld.Text;
            fileDialog.DefaultExt = ".wld";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) 
            {
                txtBoxWorld.Text = fileDialog.FileName;
            }
        }

        private void btnFileDialogueBanList_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.CheckFileExists = true;
            fileDialog.InitialDirectory = txtBoxBanList.Text;
            fileDialog.DefaultExt = ".txt";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxBanList.Text = fileDialog.FileName;
            }
        }

        private void btnFileDialogueWorldPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = true;
            folderDialog.SelectedPath = txtBoxWorldPath.Text;
            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxWorldPath.Text = folderDialog.SelectedPath;
            }
        }

        private void comboBoxAutoCreate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
