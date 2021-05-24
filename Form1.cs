using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upload_It_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DragTitle(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                title.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            DragTitle(e);
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // maybe later
        }

        private void name_MouseDown(object sender, MouseEventArgs e)
        {
            DragTitle(e);
        }
    }
}
