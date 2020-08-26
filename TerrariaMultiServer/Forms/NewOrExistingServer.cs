using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaMultiServer.Forms
{
    public partial class NewOrExistingServer : Form
    {
        public ServerFormReturnValue returnValue;
        public enum ServerFormReturnValue 
        {
            Cancel,
            NewServer,
            ExistingServer
        }
        public NewOrExistingServer()
        {
            InitializeComponent();
        }

        private void NewOrExistingServer_Load(object sender, EventArgs e)
        {

        }

        private void btnNewServer_Click(object sender, EventArgs e)
        {
            returnValue = ServerFormReturnValue.NewServer;
            this.Close();
        }

        private void btnExistingServer_Click(object sender, EventArgs e)
        {
            returnValue = ServerFormReturnValue.ExistingServer;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            returnValue = ServerFormReturnValue.Cancel;
            this.Close();
        }
    }
}
