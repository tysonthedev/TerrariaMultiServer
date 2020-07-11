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
    public partial class MissingFilesDialogue : Form
    {
        public MissingFilesDialogue(string[] missingFilesList)
        {
            InitializeComponent();
            txtBoxMissingFiles.Lines = missingFilesList;
        }
    }
}
