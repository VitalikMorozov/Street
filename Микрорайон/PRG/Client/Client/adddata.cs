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
    public partial class adddata : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));
        public adddata()
        {
            InitializeComponent();
       //     SqlConnection myConnection = new SqlConnection(ConnectionString);

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roditeliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roditeliBindingSource.EndEdit();
    //        this.tableAdapterManager.UpdateAll(this.mikroraenDataSet);

        }

        private void adddata_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.PROJ_VMESTE". При необходимости она может быть перемещена или удалена.
            this.pROJ_VMESTETableAdapter.Fill(this.aKTDataSet.PROJ_VMESTE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.RODSTVO". При необходимости она может быть перемещена или удалена.
            //this.rODSTVOTableAdapter.Fill(this.gBUDataSet.RODSTVO);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Strana_proj". При необходимости она может быть перемещена или удалена.
            //this.strana_projTableAdapter.Fill(this.gBUDataSet.Strana_proj);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Roditeli". При необходимости она может быть перемещена или удалена.
            //this.roditeliTableAdapter.Fill(this.gBUDataSet.Roditeli);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Roditeli". При необходимости она может быть перемещена или удалена.
            //this.roditeliTableAdapter.Fill(this.gBUDataSet.Roditeli);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gbuDataSet1.Roditeli". При необходимости она может быть перемещена или удалена.
            //   this.roditeliTableAdapter.Fill(this.gbuDataSet1.Roditeli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gbuDataSet1.Roditeli". При необходимости она может быть перемещена или удалена.
            // this.roditeliTableAdapter.Fill(this.gbuDataSet1.Roditeli);


            //        // TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Deti". При необходимости она может быть перемещена или удалена.
            //       this.detiTableAdapter.Fill(this.mikroraenDataSet.Deti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.SSYZ". При необходимости она может быть перемещена или удалена.
            //         this.sSYZTableAdapter.Fill(this.mikroraenDataSet.SSYZ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.School". При необходимости она может быть перемещена или удалена.
            //this.schoolTableAdapter.Fill(this.mikroraenDataSet.School);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Det_sad". При необходимости она может быть перемещена или удалена.
            //this.det_sadTableAdapter.Fill(this.mikroraenDataSet.Det_sad);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Ulica". При необходимости она может быть перемещена или удалена.
            //this.ulicaTableAdapter.Fill(this.mikroraenDataSet.Ulica);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Roditeli". При необходимости она может быть перемещена или удалена.
            //this.roditeliTableAdapter.Fill(this.mikroraenDataSet.Roditeli);

            SqlDataAdapter sqlDa = new SqlDataAdapter(" SELECT dbo.UCHA.ID_REBENKA, dbo.Klass.ID_Klass, dbo.Klass.ID_KLASSRUk, dbo.KlassRuk.ID_Klass_ruck, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.ID_ROD, dbo.UCHA.FamRebenca AS Учащийся, dbo.PROJ_VMESTE.Fam AS Фамилия, dbo.PROJ_VMESTE.Im AS Имя, dbo.PROJ_VMESTE.Otche AS Отчество, dbo.PROJ_VMESTE.PHONE AS Телефон, dbo.PROJ_VMESTE.DATA_ROJ AS[Дата роджения], dbo.PROJ_VMESTE.MESTO_RAB AS[Место работы], dbo.PROJ_VMESTE.MESTO_UCH AS[Место учебы], dbo.PROJ_VMESTE.Primech AS Примечание, dbo.PROJ_VMESTE.SEM_POLOJEN AS[Семейное положение], dbo.RODSTVO.Naz AS Родство, dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.RODSTVO.ID_RODST FROM            dbo.UCHA INNER JOIN dbo.PROJ_VMESTE ON dbo.UCHA.ID_REBENKA = dbo.PROJ_VMESTE.id_REBENKA INNER JOIN dbo.RODSTVO ON dbo.PROJ_VMESTE.ID_VID_RODSTVA = dbo.RODSTVO.ID_RODST INNER JOIN dbo.Klass ON dbo.UCHA.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.KlassRuk ON dbo.Klass.ID_KLASSRUk = dbo.KlassRuk.ID_Klass_ruck  where ID_Klass_ruck = " + help.IDKLASS + " ", con);
            DataTable DT = new DataTable();
            sqlDa.Fill(DT);
            PROJDataGridView.DataSource = DT;

            PROJDataGridView.Columns[0].Visible = false;
            PROJDataGridView.Columns[1].Visible = false;
            PROJDataGridView.Columns[2].Visible = false;
            PROJDataGridView.Columns[3].Visible = false;
            PROJDataGridView.Columns[4].Visible = false;
            PROJDataGridView.Columns[5].Visible = false;
            PROJDataGridView.Columns[17].Visible = false;
            PROJDataGridView.Columns[18].Visible = false;
            data_RojDateTimePicker.MaxDate = DateTime.Now;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
          
        //    SqlCommand command = new SqlCommand("INSERT INTO dbo.Deti[(Kod_semi, FamRebenca, ImRebenca, OtcheRebenca, Data_Roj, Kod_DetSad, Kod_Shool, Klass, Kod_SSYZ)] values(@)


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection myConnection1 = new SqlConnection(ConnectionString);
            //string sql ="INSERT INTO dbo.Roditeli  (  FamOtca,ImOtca,OtcheOtca,FamMater,ImMater,OtcheMater, Kod_Ul, Dom, Korpus,Kvartira,Propisca,Primechanie) values(@FamOtca,@ImOtca,@OtcheOtca,@FamMater,@ImMater,@OtcheMater, @Kod_Ul, @Dom, @Korpus,@Kvartira,@Propisca,@Primechanie)";
            //SqlCommand cmd_SQL = new SqlCommand(sql, myConnection1);
            //cmd_SQL.Parameters.AddWithValue("@FamOtca", textBox11.Text);
            //cmd_SQL.Parameters.AddWithValue("@ImOtca", textBox1.Text);
            //cmd_SQL.Parameters.AddWithValue("@OtcheOtca", textBox2.Text);
            //cmd_SQL.Parameters.AddWithValue("@FamMater", textBox3.Text);
            //cmd_SQL.Parameters.AddWithValue("@ImMater", textBox4.Text);
            //cmd_SQL.Parameters.AddWithValue("@OtcheMater", textBox5.Text);

            //cmd_SQL.Parameters.AddWithValue("@Kod_Ul", comboBox1.Text);

            //cmd_SQL.Parameters.AddWithValue("@Dom", textBox10.Text);
            //cmd_SQL.Parameters.AddWithValue("@Korpus", textBox9.Text);
            //cmd_SQL.Parameters.AddWithValue("@Kvartira", textBox8.Text);
            //cmd_SQL.Parameters.AddWithValue("@Propisca", comboBox5.Text);
            //cmd_SQL.Parameters.AddWithValue("@Primechanie", textBox6.Text);
            //this.sSYZTableAdapter.Update(this.mikroraenDataSet.SSYZ);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.School". При необходимости она может быть перемещена или удалена.
            //this.schoolTableAdapter.Update(this.mikroraenDataSet.School);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Det_sad". При необходимости она может быть перемещена или удалена.
            //this.det_sadTableAdapter.Update(this.mikroraenDataSet.Det_sad);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Ulica". При необходимости она может быть перемещена или удалена.
            //this.ulicaTableAdapter.Update(this.mikroraenDataSet.Ulica);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Roditeli". При необходимости она может быть перемещена или удалена.
            //this.roditeliTableAdapter.Update(this.mikroraenDataSet.Roditeli);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roditeliDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
       //     string query = "INSERT INTO Deti VALUES   ("+kod_semiTextBox.Text +","+ textBox12.Text+","+textBox17.Text+","+textBox16.Text+","+ "Convert(datetime,'" + date + "')"+","+sad+","+school+","+klass+","+ sSYZ +" )" ; 
      //      SqlConnection SqlCon = new SqlConnection(ConnectionString);
        //    SqlCommand cmd = new SqlCommand(query, SqlCon);
            //SqlCon.Open();
            ////cmd.ExecuteNonQuery();
            //SqlCon.Close();
            try
            {
                

                this.Validate();
             //   this.detiBindingSource.EndEdit();
                MessageBox.Show("Сохранение успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение неуспешно" + ex.Message);
            }

        }

        private void panelssyz_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void roditeliBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.roditeliBindingSource1.EndEdit();
         //   this.tableAdapterManager.UpdateAll(this.gBUDataSet);

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selector1 s = new selector1("Ulica");
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
            {
                string query = "SELECT * FROM Ulica Where ID_Улица = " + help.id;
                SqlCommand SqlCom = new SqlCommand(query, con);
                SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
                DataTable DT = new DataTable();
                sqlDa.Fill(DT);
                textBox2.Text = DT.Rows[0].Field<string>("Название");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectorreb s = new selectorreb("UCHA");
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
            {
                string query = "SELECT * FROM UCHA Where ID_REBENKA = " + help.id5;
                SqlCommand SqlCom = new SqlCommand(query, con);
                SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
                DataTable DT = new DataTable();
                sqlDa.Fill(DT);
                textBox6.Text = DT.Rows[0].Field<string>("FamRebenca");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            selectorrod s = new selectorrod("RODSTVO");
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
            {
                string query = "SELECT * FROM RODSTVO Where ID_RODST = " + help.id6;
                SqlCommand SqlCom = new SqlCommand(query, con);
                SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
                DataTable DT = new DataTable();
                sqlDa.Fill(DT);
                textBox5.Text = DT.Rows[0].Field<string>("Naz");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
          
            textBox3.Text = Convert.ToString(help.id);
            id_REBENKATextBox.Text = Convert.ToString(help.id5);
            iD_STRANATextBox.Text = Convert.ToString(help.id7);
            textBox4.Text = Convert.ToString(help.id6);
            //textBox2.Text = Convert.ToString(help.id);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO  PROJ_VMESTE ([id_REBENKA],[Fam],[Im],[Otche],[PHONE],[DATA_ROJ],[MESTO_RAB],[MESTO_UCH],[Primech],[SEM_POLOJEN] ,[ID_VID_RODSTVA])  " +
                    "VALUES(N'" + help.id5 + "', N'" + famTextBox.Text + "',N'" + imTextBox.Text + "',N'" + otcheTextBox.Text + "',N'" + phoneMaskedTextBox.Text + "',N'" + data_RojDateTimePicker.Text + "',N'" + zANYATextBox.Text + "',N'" + textBox1.Text + "',N'" +primechTextBox.Text + "',N'" + textBox2.Text + "',N'" + help.id6 + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Данные успешно сохранены!");
                SqlDataAdapter sqlDa = new SqlDataAdapter(" SELECT dbo.UCHA.ID_REBENKA, dbo.Klass.ID_Klass, dbo.Klass.ID_KLASSRUk, dbo.KlassRuk.ID_Klass_ruck, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.ID_ROD, dbo.UCHA.FamRebenca AS Учащийся, dbo.PROJ_VMESTE.Fam AS Фамилия, dbo.PROJ_VMESTE.Im AS Имя, dbo.PROJ_VMESTE.Otche AS Отчество, dbo.PROJ_VMESTE.PHONE AS Телефон, dbo.PROJ_VMESTE.DATA_ROJ AS[Дата роджения], dbo.PROJ_VMESTE.MESTO_RAB AS[Место работы], dbo.PROJ_VMESTE.MESTO_UCH AS[Место учебы], dbo.PROJ_VMESTE.Primech AS Примечание, dbo.PROJ_VMESTE.SEM_POLOJEN AS[Семейное положение], dbo.RODSTVO.Naz AS Родство, dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.RODSTVO.ID_RODST FROM            dbo.UCHA INNER JOIN dbo.PROJ_VMESTE ON dbo.UCHA.ID_REBENKA = dbo.PROJ_VMESTE.id_REBENKA INNER JOIN dbo.RODSTVO ON dbo.PROJ_VMESTE.ID_VID_RODSTVA = dbo.RODSTVO.ID_RODST INNER JOIN dbo.Klass ON dbo.UCHA.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.KlassRuk ON dbo.Klass.ID_KLASSRUk = dbo.KlassRuk.ID_Klass_ruck  where ID_Klass_ruck = " + help.IDKLASS + " ", con);
                DataTable DT = new DataTable();
                sqlDa.Fill(DT);
                PROJDataGridView.DataSource = DT;
                PROJDataGridView.Columns[0].Visible = false;
                PROJDataGridView.Columns[1].Visible = false;
                PROJDataGridView.Columns[2].Visible = false;
                PROJDataGridView.Columns[3].Visible = false;
                PROJDataGridView.Columns[4].Visible = false;
                PROJDataGridView.Columns[5].Visible = false;
                PROJDataGridView.Columns[17].Visible = false;
                PROJDataGridView.Columns[18].Visible = false;
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            this.Validate();
            //    this.klassBindingSource.EndEdit();
            this.pROJ_VMESTETableAdapter.Update(this.aKTDataSet);
//            this.roditeliTableAdapter.Update(this.gBUDataSet);
            pN.Visible = false;   
  //          this.roditeliTableAdapter.Fill(this.gBUDataSet.Roditeli);
            this.pROJ_VMESTETableAdapter.Fill(this.aKTDataSet.PROJ_VMESTE);
            famTextBox.Text =""; imTextBox.Text = ""; otcheTextBox.Text = ""; phoneMaskedTextBox.Text = ""; zANYATextBox.Text = ""; textBox1.Text = ""; primechTextBox.Text = ""; textBox2.Text = "";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        //private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        //{
        //    panel1.Visible = true;
        //}

        private void button6_Click(object sender, EventArgs e)
        { try
            {
                DataTable datatable1 = PROJDataGridView.DataSource as DataTable;
                DataTable dta = PROJDataGridView.DataSource as DataTable;
                DataRow row = datatable1.NewRow();

                datatable1.Rows.Add(row);

                pN.Visible = true;
                //  panel1.Visible = true;
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Delete From PROJ_VMESTE Where PROJ_VMESTE.ID_ROD = " + Convert.ToInt32(PROJDataGridView.CurrentRow.Cells[5].Value)+ "", con);


             
              
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //avto_Load(sender, e);


                SqlDataAdapter sqlDa = new SqlDataAdapter(" SELECT dbo.UCHA.ID_REBENKA, dbo.Klass.ID_Klass, dbo.Klass.ID_KLASSRUk, dbo.KlassRuk.ID_Klass_ruck, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.ID_ROD, dbo.UCHA.FamRebenca AS Учащийся, dbo.PROJ_VMESTE.Fam AS Фамилия, dbo.PROJ_VMESTE.Im AS Имя, dbo.PROJ_VMESTE.Otche AS Отчество, dbo.PROJ_VMESTE.PHONE AS Телефон, dbo.PROJ_VMESTE.DATA_ROJ AS[Дата роджения], dbo.PROJ_VMESTE.MESTO_RAB AS[Место работы], dbo.PROJ_VMESTE.MESTO_UCH AS[Место учебы], dbo.PROJ_VMESTE.Primech AS Примечание, dbo.PROJ_VMESTE.SEM_POLOJEN AS[Семейное положение], dbo.RODSTVO.Naz AS Родство, dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.RODSTVO.ID_RODST FROM            dbo.UCHA INNER JOIN dbo.PROJ_VMESTE ON dbo.UCHA.ID_REBENKA = dbo.PROJ_VMESTE.id_REBENKA INNER JOIN dbo.RODSTVO ON dbo.PROJ_VMESTE.ID_VID_RODSTVA = dbo.RODSTVO.ID_RODST INNER JOIN dbo.Klass ON dbo.UCHA.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.KlassRuk ON dbo.Klass.ID_KLASSRUk = dbo.KlassRuk.ID_Klass_ruck  where ID_Klass_ruck = " + help.IDKLASS + " ", con);
                DataTable DT = new DataTable();
                sqlDa.Fill(DT);
                PROJDataGridView.DataSource = DT;
                PROJDataGridView.Columns[0].Visible = false;
                PROJDataGridView.Columns[1].Visible = false;
                PROJDataGridView.Columns[2].Visible = false;
                PROJDataGridView.Columns[3].Visible = false;
                PROJDataGridView.Columns[4].Visible = false;
                PROJDataGridView.Columns[5].Visible = false;
                PROJDataGridView.Columns[17].Visible = false;
                PROJDataGridView.Columns[18].Visible = false;

            }
            catch { MessageBox.Show("Невозможно удаление записи!", "ERROR"); }
        }

        private void data_RojDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void zANYATextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Ввод только русских букв!", "ERROR");
            }
        }

        private void PROJDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        { try
            {
                selectorreb s = new selectorreb("UCHA");
                s.ShowDialog();
                if (s.DialogResult == DialogResult.OK)
                {
                    string query = "SELECT * FROM UCHA Where ID_REBENKA = " + help.id5;
                    SqlCommand SqlCom = new SqlCommand(query, con);
                    SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
                    DataTable DT = new DataTable();
                    sqlDa.Fill(DT);
                    textBox6.Text = DT.Rows[0].Field<string>("FamRebenca");
                }
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        { try
            {
                selectorrod s = new selectorrod("RODSTVO");
                s.ShowDialog();
                if (s.DialogResult == DialogResult.OK)
                {
                    string query = "SELECT * FROM RODSTVO Where ID_RODST = " + help.id6;
                    SqlCommand SqlCom = new SqlCommand(query, con);
                    SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
                    DataTable DT = new DataTable();
                    sqlDa.Fill(DT);
                    textBox5.Text = DT.Rows[0].Field<string>("Naz");
                }
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        { try
            {
                textBox3.Text = Convert.ToString(help.id);
                id_REBENKATextBox.Text = Convert.ToString(help.id5);
                iD_STRANATextBox.Text = Convert.ToString(help.id7);
                textBox4.Text = Convert.ToString(help.id6);
                //textBox2.Text = Convert.ToString(help.id);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO  PROJ_VMESTE ([id_REBENKA],[Fam],[Im],[Otche],[PHONE],[DATA_ROJ],[MESTO_RAB],[MESTO_UCH],[Primech],[SEM_POLOJEN] ,[ID_VID_RODSTVA])  " +
                        "VALUES(N'" + help.id5 + "', N'" + famTextBox.Text + "',N'" + imTextBox.Text + "',N'" + otcheTextBox.Text + "',N'" + phoneMaskedTextBox.Text + "',N'" + data_RojDateTimePicker.Text + "',N'" + zANYATextBox.Text + "',N'" + textBox1.Text + "',N'" + primechTextBox.Text + "',N'" + textBox2.Text + "',N'" + help.id6 + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данные успешно сохранены!");
                    SqlDataAdapter sqlDa = new SqlDataAdapter(" SELECT dbo.UCHA.ID_REBENKA, dbo.Klass.ID_Klass, dbo.Klass.ID_KLASSRUk, dbo.KlassRuk.ID_Klass_ruck, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.ID_ROD, dbo.UCHA.FamRebenca AS Учащийся, dbo.PROJ_VMESTE.Fam AS Фамилия, dbo.PROJ_VMESTE.Im AS Имя, dbo.PROJ_VMESTE.Otche AS Отчество, dbo.PROJ_VMESTE.PHONE AS Телефон, dbo.PROJ_VMESTE.DATA_ROJ AS[Дата роджения], dbo.PROJ_VMESTE.MESTO_RAB AS[Место работы], dbo.PROJ_VMESTE.MESTO_UCH AS[Место учебы], dbo.PROJ_VMESTE.Primech AS Примечание, dbo.PROJ_VMESTE.SEM_POLOJEN AS[Семейное положение], dbo.RODSTVO.Naz AS Родство, dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.RODSTVO.ID_RODST FROM            dbo.UCHA INNER JOIN dbo.PROJ_VMESTE ON dbo.UCHA.ID_REBENKA = dbo.PROJ_VMESTE.id_REBENKA INNER JOIN dbo.RODSTVO ON dbo.PROJ_VMESTE.ID_VID_RODSTVA = dbo.RODSTVO.ID_RODST INNER JOIN dbo.Klass ON dbo.UCHA.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.KlassRuk ON dbo.Klass.ID_KLASSRUk = dbo.KlassRuk.ID_Klass_ruck  where ID_Klass_ruck = " + help.IDKLASS + " ", con);
                    DataTable DT = new DataTable();
                    sqlDa.Fill(DT);
                    PROJDataGridView.DataSource = DT;
                    PROJDataGridView.Columns[0].Visible = false;
                    PROJDataGridView.Columns[1].Visible = false;
                    PROJDataGridView.Columns[2].Visible = false;
                    PROJDataGridView.Columns[3].Visible = false;
                    PROJDataGridView.Columns[4].Visible = false;
                    PROJDataGridView.Columns[5].Visible = false;
                    PROJDataGridView.Columns[17].Visible = false;
                    PROJDataGridView.Columns[18].Visible = false;

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
                this.Validate();
                //    this.klassBindingSource.EndEdit();
                this.pROJ_VMESTETableAdapter.Update(this.aKTDataSet);
                //            this.roditeliTableAdapter.Update(this.gBUDataSet);
                pN.Visible = false;
                //          this.roditeliTableAdapter.Fill(this.gBUDataSet.Roditeli);
                this.pROJ_VMESTETableAdapter.Fill(this.aKTDataSet.PROJ_VMESTE);
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void famTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Ввод только русских букв!", "ERROR");
            }
        }

        private void zANYATextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8) && (e.KeyChar != ' ') && (e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar < 'А' || e.KeyChar > 'я'))
            {
                e.Handled = true;
                MessageBox.Show("Ошибка ввода данных!", "ERROR");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Ввод только русских букв!", "ERROR");
            }
        }
    }
}
