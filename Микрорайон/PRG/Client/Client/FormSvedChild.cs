using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelObj = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Микрорайон
{
    public partial class FormSvedChild : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));

        public FormSvedChild()
        {
            InitializeComponent();

        }

        private void FormSvedChild_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.DOM". При необходимости она может быть перемещена или удалена.
            this.dOMTableAdapter.Fill(this.aKTDataSet.DOM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.Klass". При необходимости она может быть перемещена или удалена.
            this.klassTableAdapter.Fill(this.aKTDataSet.Klass);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.UCHA". При необходимости она может быть перемещена или удалена.
            this.uCHATableAdapter.Fill(this.aKTDataSet.UCHA);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Deti". При необходимости она может быть перемещена или удалена.
            //con.Open();

            //SqlDataAdapter fil = new SqlDataAdapter("SELECT        dbo.Deti.FamRebenca AS Фамилия, dbo.Deti.ImRebenca AS Имя, dbo.Deti.OtcheRebenca AS Отчество, dbo.Deti.Data_Roj AS [Дата рождения], dbo.Deti.phone AS Телефон, dbo.Klass.Number AS Класс, dbo.Ulica.Название AS Улица, dbo.DOM.Num_dom AS Дом FROM            dbo.Deti INNER JOIN    dbo.DOM ON dbo.Deti.ID_DOM = dbo.DOM.ID_DOM INNER JOIN dbo.Klass ON dbo.Deti.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.Ulica ON dbo.DOM.ID_ULICA = dbo.Ulica.ID_Улица", con);
            //SqlCommandBuilder cb = new SqlCommandBuilder(fil);
            //DataSet ds = new DataSet();
            //fil.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            //this.detiTableAdapter1.Fill(this.gbuDataSet1.Deti);
            //this.klassTableAdapter1.Fill(this.gbuDataSet1.Klass);
            //this.domTableAdapter1.Fill(this.gbuDataSet1.DOM);
            data_RojDateTimePicker.MaxDate = DateTime.Now;

        }

        private void MenuVert_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Roditeli rod = new Roditeli(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{

            //    if (dataGridView1.CurrentRow.Cells[0].Value == dataGridView2.Rows[i].Cells[0].Value)

                // if (dataGridView1.CurrentRow.Cells[0].Value == dataGridView2.Rows[i].Cells[0].Value)
                {
                    //for (int i1 = 0; i1 < dataGridView3.Rows.Count; i1++)
                    //{

                    //    if ( dataGridView3.Rows[i1].Cells[1].Value == dataGridView2.Rows[i].Cells[7].Value )
                    //    {
                    //  if (dataGridView2.Rows[i].Cells[7].Value == dataGridView3.Rows[i].Cells[1].Value)
                    //   dataGridView2.Rows[i-1].Selected = true;

                   

                    //      }

                    //}



                }
            }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           }

        private void button3_Click(object sender, EventArgs e)
        {
            //DataRow row = gbuDataSet1.Tables[0].NewRow();
            //gbuDataSet1.Tables[0].Rows.Add(row);
            panel1.Visible = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(help.id3);
                textBox4.Text = Convert.ToString(help.id4);

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO UCHA        (FamRebenca ,ImRebenca ,OtcheRebenca,Data_Roj ,phone   ,ID_KLASS ,ID_DOM ,Kvartira) VALUES(N'" + famRebencaTextBox.Text + "',N'" + imRebencaTextBox.Text + "',N'" + otcheRebencaTextBox.Text + "',N'" + data_RojDateTimePicker.Text + "',N'" + phoneMaskedTextBox.Text + "'," + Convert.ToInt32(textBox3.Text) + "," + Convert.ToInt32(textBox4.Text) + "," + Convert.ToInt32(kvartiraTextBox.Text) + ")");               //         INSERT into Klass (Number, ID_KLASSRUk)  values (N'" + numberTextBox.Text + "', " + Convert.ToInt32(help.id1) + ")");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Данные успешно сохранены!");
                this.Validate();
                //    this.klassBindingSource.EndEdit();

                //       this.detiTableAdapter1.Update(this.gbuDataSet1);
                this.uCHATableAdapter.Update(this.aKTDataSet);
                panel1.Visible = false;
                //     this.detiTableAdapter1.Fill(this.gbuDataSet1.Deti);
                this.uCHATableAdapter.Fill(this.aKTDataSet.UCHA);
                famRebencaTextBox.Text = "";
                imRebencaTextBox.Text = "";
                otcheRebencaTextBox.Text = "";
                //     data_RojDateTimePicker.Value =DateTime.Now;
                phoneMaskedTextBox.Text = "";
                textBox3.Text = ""; textBox4.Text = ""; kvartiraTextBox.Text = ""; textBox1.Text = ""; textBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void famRebencaLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { try
            {
                selector3 s1 = new selector3("Klass");
                s1.ShowDialog();
                if (s1.DialogResult == DialogResult.OK)
                {
                    string query = "SELECT * FROM Klass Where ID_Klass = " + help.id3;
                    SqlCommand SqlCom = new SqlCommand(query, con);
                    SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
                    DataTable DT = new DataTable();
                    sqlDa.Fill(DT);
                    textBox1.Text = Convert.ToString(DT.Rows[0].Field<int>("Number"));
                }
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Text = "Добавление";
        }

        private void button3_Click_1(object sender, EventArgs e)
        { try
            {
                selector4 s1 = new selector4("domUlica");
                s1.ShowDialog();
                if (s1.DialogResult == DialogResult.OK)
                {
                    string query = "SELECT * FROM  domUlica  Where ID_DOM = " + help.id4;
                    SqlCommand SqlCom = new SqlCommand(query, con);
                    SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
                    DataTable DT = new DataTable();
                    sqlDa.Fill(DT);
                    textBox2.Text = Convert.ToString(DT.Rows[0].Field<string>("Улица"));
                }
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void detiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void famRebencaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Ввод только русских букв!", "ERROR");
            }

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        { try
            {
                panel1.Visible = true;
                label1.Text = "Редактирование";
                button4.Visible = true;
                panel5.Visible = false;
                button1.Visible = false;

                famRebencaTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                imRebencaTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                otcheRebencaTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                data_RojDateTimePicker.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                phoneMaskedTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox3.Text = ""; textBox4.Text = ""; kvartiraTextBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString(); textBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString(); textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                //SqlCommand cmd = new SqlCommand("UPDATE  DOM set Num_Dom='" + Convert.ToInt32(num_domTextBox.Text) + "',ID_ULICA='" + Convert.ToInt32(textBox2.Text) + "' where(Num_Dom =' " + Convert.ToInt32(num_domTextBox.Text) + "')", con); // (Num_Dom,ID_ULICA)  values (" + Convert.ToInt32(num_domTextBox.Text) + "," + Convert.ToInt32(textBox2.Text) + ")");

                //cmd.Connection = con;

                //cmd.ExecuteNonQuery();

                //con.Close();


                //MessageBox.Show("Данные успешно сохранены!");




                //this.Validate();
                //this.dOMBindingSource.EndEdit();
                //this.dOMTableAdapter.Update(this.gBUDataSet);

                //panel1.Visible = false;
                //this.dOMTableAdapter.Fill(this.gBUDataSet.DOM);
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //try
                // {
                textBox3.Text = Convert.ToString(help.id3);
                textBox4.Text = Convert.ToString(help.id4);
                //            textBox2.Text = Convert.ToString(help.id);
                SqlCommand cmd = new SqlCommand("Update  UCHA   set  FamRebenca=N'" + famRebencaTextBox.Text + "' ,ImRebenca =N'" + imRebencaTextBox.Text + "',OtcheRebenca=N'" + otcheRebencaTextBox.Text + "',Data_Roj=N'" + data_RojDateTimePicker.Text + "' ,phone=N'" + phoneMaskedTextBox.Text + "'  ,ID_KLASS=" + Convert.ToInt32(textBox3.Text) + " ,ID_DOM=" + Convert.ToInt32(textBox4.Text) + " ,Kvartira='" + Convert.ToInt32(kvartiraTextBox.Text) + "' where(FamRebenca=N'" + famRebencaTextBox.Text + "')", con);              //         INSERT into Klass (Number, ID_KLASSRUk)  values (N'" + numberTextBox.Text + "', " + Convert.ToInt32(help.id1) + ")");

                con.Open();
                //    // =" + + "=" + help.id + ")", con);
                cmd.Connection = con;

                //       cmd.ExecuteNonQuery();

                con.Close();

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Данные успешно сохранены!");
                this.uCHATableAdapter.Fill(this.aKTDataSet.UCHA);
                panel1.Visible = false;


                //}
                //  catch { MessageBox.Show("Заполните все поля!", "ERROR"); }
                //this.Validate();
                //this.dOMBindingSource.EndEdit();
                //this.dOMTableAdapter.Update(this.gBUDataSet);

                //panel1.Visible = false;
                //this.dOMTableAdapter.Fill(this.gBUDataSet.DOM);


                this.Validate();
                this.uCHATableAdapter.Update(this.aKTDataSet);
                this.uCHABindingSource.EndEdit();
                ////      this.detiBindingSource.EndEdit();
                this.uCHATableAdapter.Update(this.aKTDataSet);
                ////      this.detiTableAdapter1.Update(this.gbuDataSet1);
                //      panel1.Visible = false;
                //  //    this.detiTableAdapter1.Fill(this.gbuDataSet1.Deti);
                this.uCHATableAdapter.Fill(this.aKTDataSet.UCHA);

                famRebencaTextBox.Text = "";
                imRebencaTextBox.Text = "";
                otcheRebencaTextBox.Text = "";
                //data_RojDateTimePicker.Value = DateTime.Now;
                phoneMaskedTextBox.Text = "";
                textBox3.Text = ""; textBox4.Text = ""; kvartiraTextBox.Text = ""; textBox1.Text = ""; textBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "УЧЕНИКИ";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "output";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void kvartiraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar != 8) && (e.KeyChar != ' ') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
                MessageBox.Show("Ошибка ввода данных!", "ERROR");
            }
        }

        //private void toolStripButton2_Click(object sender, EventArgs e)
        //{
        //    string query = "Select dbo.Deti.FamRebenca AS Фамилия, dbo.Deti.ImRebenca AS Имя, dbo.Deti.OtcheRebenca AS Отчество, dbo.Deti.Data_Roj AS [Дата рождения], dbo.Deti.phone AS Телефон, dbo.Klass.Number AS Класс, dbo.Ulica.Название AS Улица, dbo.DOM.Num_dom AS Дом, Kvartira AS Квартира " +
        //                  "From dbo.Deti INNER JOIN dbo.DOM ON dbo.Deti.ID_DOM = dbo.DOM.ID_DOM INNER JOIN dbo.Klass ON dbo.Deti.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.Ulica ON dbo.DOM.ID_ULICA = dbo.Ulica.ID_Улица " +
        //                  "Where " +
        //                   "dbo.Ulica.Название like '%" + toolStripTextBox1.Text + "%' OR " +

        //                   "dbo.Klass.Number like '%" + toolStripTextBox1.Text + "%' ";
        //}

        //private void imgS_Click(object sender, EventArgs e)
        //{
        //    toolStripTextBox1.Text = "";
        //    SqlDataAdapter fil = new SqlDataAdapter("SELECT dbo.Deti.FamRebenca AS Фамилия, dbo.Deti.ImRebenca AS Имя, dbo.Deti.OtcheRebenca AS Отчество, dbo.Deti.Data_Roj AS [Дата рождения], dbo.Deti.phone AS Телефон, dbo.Klass.Number AS Класс, dbo.Ulica.Название AS Улица, dbo.DOM.Num_dom AS Дом, Kvartira AS Квартира FROM dbo.Deti INNER JOIN dbo.DOM ON dbo.Deti.ID_DOM = dbo.DOM.ID_DOM INNER JOIN dbo.Klass ON dbo.Deti.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.Ulica ON dbo.DOM.ID_ULICA = dbo.Ulica.ID_Улица", con);
        //    SqlCommandBuilder cb = new SqlCommandBuilder(fil);
        //    DataSet ds = new DataSet();
        //    fil.Fill(ds);
        //    bindingSource1.DataSource = ds;

        //    bindingNavigator1.BindingSource = bindingSource1;
        //    dataGridView1.DataSource = ds.Tables[0];
        //}
    }

     
        //private void toolStripButton3_Click(object sender, EventArgs e)
        //{
        //    int k = 0;
        //    if (toolStripComboBox1.Text == "Детские сады")
        //    {
        //        k++;
        //        var b = comboBox1.Text;
        //        int bb = 0;
        //        foreach (DataGridViewRow r in dataGridView6.Rows)
        //            if (b == r.Cells[1].Value)
        //            {
        //                bb = (int)r.Cells[0].Value;
        //                break;
        //            }
        //        textBox2.Text = Convert.ToString(bb);
        //        detiBindingSource.Filter = "Kod_SSYZ = \'" + Convert.ToInt32(textBox2.Text) + "\'"; 
        //    }
        //    else { k = 0; }
        //    if (toolStripComboBox1.Text == "СУУЗ ВУЗ (Другое)")
        //    {
        //        k++;
        //        var b = comboBox1.Text;
        //        int bb = 0;
        //        foreach (DataGridViewRow r in dataGridView5.Rows)
        //            if (b == r.Cells[1].Value)
        //            {
        //                bb = (int)r.Cells[0].Value;
        //                break;
        //            }
        //        textBox2.Text = Convert.ToString(bb);
        //        detiBindingSource.Filter = "Kod_SSYZ = \'" + Convert.ToInt32(textBox2.Text) + "\'";
        //    }
        //    else { k = 0; }
        //    if (toolStripComboBox1.Text == "Школы")
        //    {
        //        k++;
        //        var b = comboBox1.Text;
        //        int bb = 0;
        //        foreach (DataGridViewRow r in dataGridView4.Rows)
        //            if (b == r.Cells[1].Value)
        //            {
        //                bb = (int)r.Cells[0].Value;
        //                break;
        //            }
        //        textBox2.Text = Convert.ToString(bb);
        //        detiBindingSource.Filter = "Kod_Shool = \'" + Convert.ToInt32(textBox2.Text) + "\'"; 
        //    }
        //    else { k = 0; }
        //    if (k == 0)
        //    {


        //        MessageBox.Show("Таких данных нет");
        //        detiBindingSource.Filter = String.Empty;
        //    }
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //      textBox2.Text = comboBox1.SelectedValue.ToString();
        //}

        //private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (toolStripComboBox1.Text == "Школы")
        //    {
        //        panel3.Visible = true;
        //        comboBox1.Visible = true;
        //        comboBox2.Visible = false;
        //        comboBox3.Visible = false;
        //    }
        //    if (toolStripComboBox1.Text == "СУУЗ ВУЗ (Другое)")
        //    {
        //        panel3.Visible = true;
        //        comboBox1.Visible = false;
        //        comboBox2.Visible = true;
        //        comboBox3.Visible = false;
        //    }

        //    if (toolStripComboBox1.Text == "Детские сады")
        //    {
        //        panel3.Visible = true;
        //        comboBox3.Visible = true;
        //        comboBox2.Visible = false;
        //        comboBox1.Visible = false;
        //    }
        //}

       

        //private void toolStripButton4_Click(object sender, EventArgs e)
        //{
        //    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
        //    Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
        //    Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
        //    worksheet = workbook.Sheets["Лист1"];
        //    worksheet = workbook.ActiveSheet;
        //    worksheet.Name = "Дети";

        //    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
        //    {
        //        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
        //    }

        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
        //        {
        //            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
        //        }
        //    }

        //    var saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.FileName = "output";
        //    saveFileDialog.DefaultExt = ".xlsx";
        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //    }
        //    app.Quit();
        //}

     
}


