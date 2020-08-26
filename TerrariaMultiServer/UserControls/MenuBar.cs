using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaMultiServer.UserControls
{
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }
        bool dragWindow = false;
        Point originalMouseLocation = new Point(0,0);
        Point offset = new Point(0, 0);
        private void MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isParentForm()) return;
            dragWindow = true;
            originalMouseLocation = e.Location;
            offset = new Point(Cursor.Position.X - this.Parent.Location.X,Cursor.Position.Y - this.Parent.Location.Y);
        }

        private void MenuBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragWindow = false;
        }

        private void MenuBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isParentForm()) return;
            if (!dragWindow) return;
            this.Parent.Location = new Point(Cursor.Position.X - offset.X, Cursor.Position.Y - offset.Y);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!isParentForm()) return;
            ((Form)(this.Parent)).Close();
        }
        bool isParentForm() 
        {
            if (this.Parent == null) return false;
            if (this.Parent is Form) return true;
            return false;
        }
    }
}
