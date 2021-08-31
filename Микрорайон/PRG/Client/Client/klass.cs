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
    public partial class klass : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));
        public klass()
        {
            InitializeComponent();
        }

        private void klassBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klassBindingSource.EndEdit();
         //   this.tableAdapterManager.UpdateAll(this.gBUDataSet);

        }

        private void klass_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.KlassRuk". При необходимости она может быть перемещена или удалена.
            this.klassRukTableAdapter1.Fill(this.aKTDataSet.KlassRuk);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.Klass". При необходимости она может быть перемещена или удалена.
            this.klassTableAdapter.Fill(this.aKTDataSet.Klass);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.KlassRuk". При необходимости она может быть перемещена или удалена.
     //       this.klassRukTableAdapter.Fill(this.gBUDataSet.KlassRuk);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Klass". При необходимости она может быть перемещена или удалена.
       //   this.klassTableAdapter1.Fill(this.gBUDataSet.Klass);

        }

        private void button1_Click(object sender, EventArgs e)
        { try
            {
                //  textBox2.Text = Convert.ToString(help.id2);
                // numberTextBox1.Text = numberTextBox.Text;

                SqlCommand cmd = new SqlCommand("INSERT into Klass (Number,BUKVA,SPECIALIZACIAYA, ID_KLASSRUk)  values (N'" + numberTextBox.Text + "','" + textBox3.Text + "','" + Convert.ToString(textBox4.Text) + "', " + Convert.ToInt32(help.id2) + ")");
                //    // =" + + "=" + help.id + ")", con);
                con.Open();
                cmd.Connection = con;

                //       [BUKVA] ,[Number],[SPECIALIZACIAYA] ,[ID_KLASSRUk]

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Данные успешно сохранены!");
                numberTextBox.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox1.Text = "";






                this.Validate();
                //    this.klassBindingSource.EndEdit();
                this.klassBindingSource1.EndEdit();
                this.klassTableAdapter.Update(this.aKTDataSet);

                this.klassTableAdapter.Fill(this.aKTDataSet.Klass);
                //   this.klassTableAdapter1.Update(this.gBUDataSet);
                panel1.Visible = false;
                //     this.klassTableAdapter1.Fill(this.gBUDataSet.Klass);
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Text = "Добавить";
            button1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        { try
            {
                selector2 s1 = new selector2("KlassRuk");
                s1.ShowDialog();
                if (s1.DialogResult == DialogResult.OK)
                {
                    string query = "SELECT * FROM KlassRuk Where ID_Klass_ruck = " + help.id2;
                    SqlCommand SqlCom = new SqlCommand(query, con);
                    SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
                    DataTable DT = new DataTable();
                    sqlDa.Fill(DT);
                    textBox1.Text = DT.Rows[0].Field<string>("FAM");
                }
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void klassDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button1.Visible = false;
            panel5.Visible = false;
            button3.Visible = true;
            label1.Text = "Редактировать";
            numberTextBox.Enabled = false;
          numberTextBox.Text = klassDataGridView.CurrentRow.Cells[1].Value.ToString(); textBox3.Text = klassDataGridView.CurrentRow.Cells[2].Value.ToString(); textBox4.Text = klassDataGridView.CurrentRow.Cells[3].Value.ToString(); textBox1.Text = klassDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update  Klass   set  Number=N'" + numberTextBox.Text + "', BUKVA = N'" + textBox3.Text + "',SPECIALIZACIAYA = N'" + Convert.ToString(textBox4.Text) + "'  , ID_KLASSRUk =" + Convert.ToInt32(help.id2) + "  where(Number=N'" + numberTextBox.Text + "')", con);              //         INSERT into Klass (Number, ID_KLASSRUk)  values (N'" + numberTextBox.Text + "', " + Convert.ToInt32(help.id1) + ")");
                                                                                                                                                                                                                                                                                                                              //    // =" + + "=" + help.id + ")", con);
                cmd.Connection = con;
                con.Open();
                //   cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Данные успешно сохранены!");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //this.Validate();
                //this.dOMBindingSource.EndEdit();
                //this.dOMTableAdapter.Update(this.gBUDataSet);

                //panel1.Visible = false;
                //this.dOMTableAdapter.Fill(this.gBUDataSet.DOM);


                this.Validate();
                this.klassBindingSource.EndEdit();
                this.klassTableAdapter.Update(this.aKTDataSet);
                //     this.klassTableAdapter1.Update(this.gBUDataSet);
                panel1.Visible = false;
                //     this.klassTableAdapter1.Fill(this.gBUDataSet.Klass);
                this.klassBindingSource1.EndEdit();
                this.klassTableAdapter.Update(this.aKTDataSet);

                this.klassTableAdapter.Fill(this.aKTDataSet.Klass);
                //   this.klassTableAdapter1.Update(this.gBUDataSet);
                panel1.Visible = false;
                numberTextBox.Enabled = true;
                //       this.klassTableAdapter1.Fill(this.gBUDataSet.Klass);
                numberTextBox.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' ')  && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Не верный ввод данных!", "ERROR");
            }
        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar != 8) && (e.KeyChar != ' ') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
                MessageBox.Show("Не верный ввод данных!", "ERROR");
            }
        }
    }
}
