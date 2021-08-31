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
    public partial class forms : Form
    {
        public forms()
        {
            InitializeComponent();
     //       firstformdata fm = new firstformdata();

       //     FullFormEnPanel(fm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TOPPAnel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
        private void button1_Click(object sender, EventArgs e)
        {
            panelData.Visible = true;

        }

        private void buttonSved_Click(object sender, EventArgs e)
        {
          //  FormSvedChild fm = new FormSvedChild();
            klass fm = new klass();
            FullFormEnPanel(fm);
            panelData.Visible = false;
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button5.BackColor = Color.FromArgb(26, 32, 40);
            button6.BackColor = Color.FromArgb(26, 32, 40);
        //    button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.SkyBlue; 
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void buttonVvod_Click(object sender, EventArgs e)
        {
            detsad add = new detsad();

            FullFormEnPanel(add);
            panelData.Visible = false;
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button5.BackColor = Color.FromArgb(26, 32, 40);
            button6.BackColor = Color.FromArgb(26, 32, 40);
          //  button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor =  Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.SkyBlue;
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            panelData.Visible = false;
        }

      
        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            
        }

        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            firstformdata fm = new firstformdata();

            FullFormEnPanel(fm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ssyz fm = new ssyz();

            FullFormEnPanel(fm);
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.SkyBlue; 
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button5.BackColor = Color.FromArgb(26, 32, 40);
            button6.BackColor = Color.FromArgb(26, 32, 40);
        //    button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button3_Click(object sender, EventArgs e)
        {

           FormSvedChild fm = new FormSvedChild();

            FullFormEnPanel(fm);
            button3.BackColor = Color.SkyBlue;
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button5.BackColor = Color.FromArgb(26, 32, 40);
            button6.BackColor = Color.FromArgb(26, 32, 40);
        //    button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            shcool fm= new shcool();

            FullFormEnPanel(fm);
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.SkyBlue;
            button5.BackColor = Color.FromArgb(26, 32, 40);
            button6.BackColor = Color.FromArgb(26, 32, 40);
          //  button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ssyz fm = new ssyz();
            FullFormEnPanel(fm);
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button5.BackColor = Color.FromArgb(26, 32, 40);
            button6.BackColor = Color.SkyBlue; 
         //   button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            detsad fd = new detsad();
            FullFormEnPanel(fd);
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button5.BackColor = Color.SkyBlue; 
            button6.BackColor = Color.FromArgb(26, 32, 40);
         //   button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void forms_Load(object sender, EventArgs e)
        {

           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ulica fm = new ulica ();
            FullFormEnPanel(fm);
            panelData.Visible = false;

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
             shcool fd = new shcool();
            FullFormEnPanel(fd);
            panelData.Visible = false;
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button5.BackColor = Color.SkyBlue;
            button6.BackColor = Color.FromArgb(26, 32, 40);
         //   button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            country fd = new country();
            FullFormEnPanel(fd);
            panelData.Visible = false;
            button3.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button5.BackColor = Color.FromArgb(26, 32, 40);
            button6.BackColor = Color.SkyBlue;
         //   button7.BackColor = Color.FromArgb(26, 32, 40);
            buttonSved.BackColor = Color.FromArgb(26, 32, 40);
            buttonVvod.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
