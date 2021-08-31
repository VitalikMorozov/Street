using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Микрорайон
{
    public partial class Form1 : Form
    {
            public static string con = ConfigurationManager.AppSettings.Get("ServerConnectionString");

        //   public SqlConnection con = ConfigurationManager.AppSettings.Get("ServerConnectionString");
     //   public SqlConnection con =   new SqlConnection(@"  Data Source = ADMIN\SQLEXPRESS; Initial Catalog = AKT; Integrated Security = True");

        public Form1()
        {
        
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) FROM KlassRuk where  Login = '" + textBox1.Text + "' and password ='" + textBox2.Text + "'", con);
            
            DataTable dt = new DataTable();
           
            sda.Fill(dt);
            
           
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM KlassRuk where  Login = '" + textBox1.Text + "' ", con);

                DataTable dt2 = new DataTable();

                sda2.Fill(dt2);
                help.a = dt2.Rows[0].Field<string>("FAM");
                help.a1 = dt2.Rows[0].Field<string>("IM");
                help.a2= dt2.Rows[0].Field<string>("OTCHE");
                help.IDKLASS = dt2.Rows[0].Field<int>("ID_Klass_ruck");

                //       textBox4.Text = Convert.ToString(a);
                //    MessageBox.Show(a);
                KLASSRUK formMain = new KLASSRUK();
              
                formMain.Show();

            Hide();
              
            }

            if (textBox1.Text == "admin" && textBox2.Text == "admin")//(this.микрорайон_2000_данныеDataSet.Пользователь.Count >= 1 && this.микрорайон_2000_данныеDataSet.Пользователь[0].Пароль == textBox2.Text)
            {
                forms formMain = new forms();

                formMain.Show();

                Hide();
            }
            if (textBox1.Text == "ZAM" && textBox2.Text == "ZAM")//(this.микрорайон_2000_данныеDataSet.Пользователь.Count >= 1 && this.микрорайон_2000_данныеDataSet.Пользователь[0].Пароль == textBox2.Text)
            {
                zamdir formMain = new zamdir();

                formMain.Show();

                Hide();
            }
            if (textBox1.Text!="ZAM" ^ textBox1.Text!="admin" ^ dt.Rows[0][0].ToString() != "1" )
            {

                MessageBox.Show("Неверный логин или пароль!", "Ошибка аутентификации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
          

        }
            //for (int i=0; i <  klassRukDataGridView.Rows.Count - 1; i++)
            //{
            //    if (textBox1.Text == klassRukDataGridView.Rows[i].Cells[1].Value)
            //    {
            //        KLASSRUK formMain = new KLASSRUK();

            //        formMain.Show();

            //        Hide();
            //    }

            //}


            //   this.пользовательTableAdapter1.Fill(this.микрорайон_2000_данныеDataSet.Пользователь, textBox1.Text);
            //    if (textBox1.Text=="admin" && textBox2.Text == "admin")//(this.микрорайон_2000_данныеDataSet.Пользователь.Count >= 1 && this.микрорайон_2000_данныеDataSet.Пользователь[0].Пароль == textBox2.Text)
            //    {
            //        forms formMain = new forms();

            //        formMain.Show();

            //        Hide();
            //    }
            //    else
            //    {

            //        MessageBox.Show("Неверный логин или пароль!", "Ошибка аутентификации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textBox1.Text = "";
            //        textBox2.Text = "";
            //    }
            //}

        //    private void button2_Click(object sender, EventArgs e)
        //{

        //}

        private void klassRukBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klassRukBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.gBUDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.KlassRuk". При необходимости она может быть перемещена или удалена.
       //     this.klassRukTableAdapter.Fill(this.gBUDataSet.KlassRuk);
         //   con.Open();
        }
    }
}
