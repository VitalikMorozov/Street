using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Микрорайон
{
    public partial class zamdir : Form
    {
        public zamdir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelData.Visible = true;
        }
        public void FullFormEnPanel(object formfull) //full form data
        {
            if (this.panelcontent.Controls.Count > 0)
                this.panelcontent.Controls.RemoveAt(0);
            Form fh = formfull as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelcontent.Controls.Add(fh);
            this.panelcontent.Tag = fh;
            fh.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
     [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void buttonSved_Click(object sender, EventArgs e)
        {
            childrenprev fm = new childrenprev();

            FullFormEnPanel(fm); 
            panelData.Visible = false;
        }

        private void buttonVvod_Click(object sender, EventArgs e)
        {
            GBUFORM fm = new GBUFORM();

            FullFormEnPanel(fm);
            panelData.Visible = false;
        }

        private void btnnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void TOPPAnel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnnRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnnMax.Visible = true;
            btnnRest.Visible = false;

        }

        private void btnnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnnMax.Visible = false;
            btnnRest.Visible = true;
        }

        private void btnnMax_Click_1(object sender, EventArgs e)
        {
   this.WindowState = FormWindowState.Maximized;
            btnnMax.Visible = false;
            btnnRest.Visible = true;
        }

        private void btnnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть приложение ? ", "Внимание! ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonSved_Click_1(object sender, EventArgs e)
        {
            childrenprev fm = new childrenprev();

            FullFormEnPanel(fm);
            panelData.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonVvod_Click_1(object sender, EventArgs e)
        {
            GBUFORM fm = new GBUFORM();

            FullFormEnPanel(fm);
            panelData.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void zamdir_Load(object sender, EventArgs e)
        {
            childrenprev fm = new childrenprev();

            FullFormEnPanel(fm);
            panelData.Visible = false;
        }
    }
}
