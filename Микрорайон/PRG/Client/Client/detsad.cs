using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Микрорайон
{
    public partial class detsad : Form
    {
          public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));
       // public static string con = ConfigurationManager.AppSettings.Get("ServerConnectionString");

        public detsad()
        {
            InitializeComponent();
        }

        private void detsad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.NACH_DANN". При необходимости она может быть перемещена или удалена.
            this.nACH_DANNTableAdapter.Fill(this.aKTDataSet.NACH_DANN);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.DOM". При необходимости она может быть перемещена или удалена.
            this.dOMTableAdapter1.Fill(this.aKTDataSet.DOM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Ulica". При необходимости она может быть перемещена или удалена.
            //this.ulicaTableAdapter.Fill(this.gBUDataSet.Ulica);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.DOM". При необходимости она может быть перемещена или удалена.
            //this.dOMTableAdapter.Fill(this.gBUDataSet.DOM);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.DOM". При необходимости она может быть перемещена или удалена.
            //this.dOMTableAdapter.Fill(this.gBUDataSet.DOM);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.дом_на_улице". При необходимости она может быть перемещена или удалена.
            //this.дом_на_улицеTableAdapter.Fill(this.gBUDataSet.дом_на_улице);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Det_sad". При необходимости она может быть перемещена или удалена.

            string query = "SELECT * FROM dbo.NACH_DANN";
             SqlCommand SqlCom = new SqlCommand(query,con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
            DataTable DT = new DataTable();
            sqlDa.Fill(DT);
           

        }

      

      

        private void button1_Click(object sender, EventArgs e)
        {

      //     iD_ULICATextBox.Text = Convert.ToString(iD_ULICAComboBox.SelectedValue.ToString());
            this.Validate();
            this.dOMBindingSource.EndEdit();
     //       this.dOMTableAdapter.Update(this.gBUDataSet);
            panel1.Visible = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
          
            panel1.Visible = true;

        }

        private void iD_ULICAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
//iD_ULICATextBox.Text =Convert.ToString( iD_ULICAComboBox.SelectedValue.ToString());
        }

        private void iD_ULICAComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        { try
            {
                textBox2.Text = Convert.ToString(help.id);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT into DOM (Num_Dom,ID_NACH_DAN)  values (" + Convert.ToInt32(num_domTextBox.Text) + ", N'" + Convert.ToInt32(textBox2.Text) + "')");
                //    // =" + + "=" + help.id + ")", con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Данные успешно сохранены!");




                this.Validate();
                //      this.dOMBindingSource.EndEdit();
                // this.dOMTableAdapter.Update(this.gBUDataSet);

                panel1.Visible = false;
                //    this.dOMTableAdapter.Fill(this.gBUDataSet.DOM);


                //     this.dOMBindingSource1.EndEdit();
                this.dOMTableAdapter1.Update(this.aKTDataSet);
                //   this.klassTableAdapter1.Update(this.gBUDataSet);
                panel1.Visible = false;
                this.dOMTableAdapter1.Fill(this.aKTDataSet.DOM);
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { try
            {
                selector1 s = new selector1("NACH_DANN");
                s.ShowDialog();
                if (s.DialogResult == DialogResult.OK)
                {
                    string query = "SELECT * FROM NACH_DANN Where ID_Улица = " + help.id;
                    SqlCommand SqlCom = new SqlCommand(query, con);
                    SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
                    DataTable DT = new DataTable();
                    sqlDa.Fill(DT);
                    textBox1.Text = DT.Rows[0].Field<string>("ULICA");
                }
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        { try
            {
                textBox2.Text = Convert.ToString(help.id);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE  DOM set Num_Dom='" + Convert.ToInt32(num_domTextBox.Text) + "',ID_NACH_DAN='" + Convert.ToInt32(textBox2.Text) + "' where(Num_Dom =' " + Convert.ToInt32(num_domTextBox.Text) + "')", con); // (Num_Dom,ID_ULICA)  values (" + Convert.ToInt32(num_domTextBox.Text) + "," + Convert.ToInt32(textBox2.Text) + ")");

                cmd.Connection = con;

                cmd.ExecuteNonQuery();

                con.Close();


                MessageBox.Show("Данные успешно сохранены!");




                this.Validate();
                this.dOMBindingSource.EndEdit();
                //      this.dOMTableAdapter.Update(this.gBUDataSet);

                panel1.Visible = false;
                //        this.dOMTableAdapter.Fill(this.gBUDataSet.DOM);
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void num_domTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8) && (e.KeyChar != ' ') && (e.KeyChar != '/') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Ввод только цифр!", "ERROR");
            }
        }
    }
}
