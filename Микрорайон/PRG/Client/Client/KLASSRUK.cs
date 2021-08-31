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
using System.Threading;

namespace Микрорайон
{
    public partial class KLASSRUK : Form
    {
        public KLASSRUK()
        {
            InitializeComponent();
            //   firstformdata fm = new firstformdata();

            // FullFormEnPanel(fm);
          
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
      [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть приложение ? ", "Внимание! ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnnMax.Visible = false;
            btnnRest.Visible = true;
        }

        private void btnnRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnnMax.Visible = true;
            btnnRest.Visible = false;
        }

        private void btnnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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

        private void btnnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnnExit_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите закрыть приложение ? ", "Внимание! ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnnRest_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnnMax.Visible = true;
            btnnRest.Visible = false;
        }

        private void btnnMax_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnnMax.Visible = false;
            btnnRest.Visible = true;
        }

        private void KLASSRUK_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuVert_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSved_Click(object sender, EventArgs e)
        {
            detsad add = new detsad();
       //     add.bindingNavigatorAddNewItem.Visible = false;
     //       add.bindingNavigatorDeleteItem.Visible = false;
      //      add.toolStripButton1.Visible = true;
      //      add.button3.Visible = true;
            FullFormEnPanel(add);
            panelData.Visible = false;
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.SkyBlue;
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40); 
        }

        private void buttonVvod_Click(object sender, EventArgs e)
        {

            ulica fm = new ulica();

          //  fm.bindingNavigatorAddNewItem.Visible = false;
          //fm.bindingNavigatorDeleteItem.Visible = false;
          //  fm.toolStripButton1.Visible = true;

            FullFormEnPanel(fm);
            panelData.Visible = false;
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.SkyBlue;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            country fd = new country();
      //      fd.bindingNavigatorAddNewItem.Visible = false;
        //    fd.bindingNavigatorDeleteItem.Visible = false;
          //  fd.toolStripButton1.Visible = true;
            FullFormEnPanel(fd);
            panelData.Visible = false;
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button7.BackColor = Color.SkyBlue;
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelData.Visible = true;

        }

        private void btnnExit_Click_2(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите закрыть приложение ? ", "Внимание! ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnnRest_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnnMax.Visible = true;
            btnnRest.Visible = false;

        }

        private void btnnMin_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnnMax_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnnMax.Visible = false;
            btnnRest.Visible = true;

        }

        private void TOPPAnel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VIEWER fm = new VIEWER();

            
            FullFormEnPanel(fm);
            panelData.Visible = false;
            button3.BackColor = Color.SkyBlue;
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GBUEDIT fm = new GBUEDIT();


            FullFormEnPanel(fm);
            panelData.Visible = false;
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.SkyBlue;
            button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adddata fm = new adddata();
            FullFormEnPanel(fm);
            panelData.Visible = false;



            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.SkyBlue;
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            VIEWER fm = new VIEWER();


            FullFormEnPanel(fm);
            panelData.Visible = false;
            button3.BackColor = Color.SkyBlue;
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KLASSRUK_Load(object sender, EventArgs e)
        {
         //   Form1 nw = new Form1();
            label1.Text = Convert.ToString( help.a)+" "+Convert.ToString(help.a1)+" "+Convert.ToString(help.a2);
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
