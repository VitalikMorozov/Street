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
    public partial class enterAKTINFOM : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));

        public enterAKTINFOM()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void enterAKTINFOM_Load(object sender, EventArgs e)
        {
            data_RojDateTimePicker.MaxDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO  AKT ([Data_obsled] ,[ID_REBENKA],[OTVET_za_VOSPIT],[VZAIMO_OT],[vuplat],[VLADEL_ZILAYA],[PLOSH_POMECH],[OBESPECH],[BUT_UDOB],[NAL_SPAL_MESTA],[NAL_RAB_MESTA],[KOLVO_V_KOMNATE],[PRIMECH],[ZAK])  " +
                    "VALUES(N'" + data_RojDateTimePicker.Text + "',N'" + help.id5 + "', N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "',N'" + textBox7.Text + "',N'" + textBox8.Text + "',N'" + textBox9.Text + "',N'" + textBox11.Text + "',N'" + textBox12.Text + "',N'" + textBox10.Text + "',N'" + textBox13.Text + "')", con);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Данные успешно сохранены!");
              con.Close();  
                
                
                
                //SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT        dbo.Xar_uch.ID_XARAKTERISTIKA, dbo.Xar_uch.ID_OBSLED, dbo.UCHA.ID_REBENKA, dbo.AKT.ID_OBSLED AS Expr1, dbo.AKT.ID_REBENKA AS reb, dbo.AKT.Data_obsled AS [Дата обследования], dbo.UCHA.FamRebenca AS Ребенок, dbo.AKT.OTVET_za_VOSPIT AS [Отвественный за воспитание], dbo.AKT.VZAIMO_OT AS [Взаимоотношения в семье], dbo.AKT.vuplat AS Выплаты, dbo.AKT.VLADEL_ZILAYA AS [Собственник жилищной площади], dbo.AKT.PLOSH_POMECH AS [Площадь жилого помещения], dbo.AKT.OBESPECH AS [Обеспеченность семьи], dbo.AKT.BUT_UDOB AS [Бытовые удобства], dbo.AKT.NAL_SPAL_MESTA AS [Наличие спального места], dbo.AKT.NAL_RAB_MESTA AS [Наличие рабочего места], dbo.AKT.KOLVO_V_KOMNATE AS [Количество человек в комнате], dbo.AKT.PRIMECH AS Примечание, dbo.AKT.ZAK AS Заключение, dbo.KlassRuk.ID_Klass_ruck, dbo.Klass.ID_Klass, dbo.Klass.ID_KLASSRUk, dbo.UCHA.ImRebenca, dbo.UCHA.OtcheRebenca, dbo.UCHA.Data_Roj, dbo.UCHA.phone, dbo.UCHA.ID_KLASS AS Expr2, dbo.UCHA.ID_DOM, dbo.UCHA.Kvartira, dbo.Xar_uch.USPEV,  dbo.Xar_uch.ZAN_V_SVOB_VREM, dbo.Xar_uch.NARU_V_POVEDENI, dbo.KlassRuk.FAM, dbo.KlassRuk.IM, dbo.KlassRuk.OTCHE, dbo.Klass.BUKVA, dbo.Klass.Number, dbo.Klass.SPECIALIZACIAYA FROM            dbo.UCHA INNER JOIN dbo.AKT ON dbo.UCHA.ID_REBENKA = dbo.AKT.ID_REBENKA INNER JOIN dbo.Xar_uch ON dbo.AKT.ID_OBSLED = dbo.Xar_uch.ID_OBSLED INNER JOIN dbo.Klass ON dbo.UCHA.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.KlassRuk ON dbo.Klass.ID_KLASSRUk = dbo.KlassRuk.ID_Klass_ruck WHERE KlassRuk.ID_Klass_ruck = " + help.IDKLASS + " ", con);
                //DataTable DT = new DataTable();
                //sqlDa.Fill(DT);
                //rODSTVODataGridView.DataSource = DT;
                //rODSTVODataGridView.Columns[0].Visible = false;
                //rODSTVODataGridView.Columns[1].Visible = false;
                //rODSTVODataGridView.Columns[2].Visible = false;
                //rODSTVODataGridView.Columns[3].Visible = false;
                //rODSTVODataGridView.Columns[4].Visible = false;
                //rODSTVODataGridView.Columns[7].Visible = false;
                //rODSTVODataGridView.Columns[8].Visible = false;
                //rODSTVODataGridView.Columns[9].Visible = false; rODSTVODataGridView.Columns[10].Visible = false; rODSTVODataGridView.Columns[11].Visible = false; rODSTVODataGridView.Columns[12].Visible = false; rODSTVODataGridView.Columns[13].Visible = false;
                //rODSTVODataGridView.Columns[14].Visible = false; rODSTVODataGridView.Columns[15].Visible = false; rODSTVODataGridView.Columns[16].Visible = false; rODSTVODataGridView.Columns[17].Visible = false; rODSTVODataGridView.Columns[18].Visible = false;
                //rODSTVODataGridView.Columns[19].Visible = false; rODSTVODataGridView.Columns[20].Visible = false; rODSTVODataGridView.Columns[21].Visible = false; rODSTVODataGridView.Columns[22].Visible = false; rODSTVODataGridView.Columns[23].Visible = false;
                //rODSTVODataGridView.Columns[24].Visible = false; rODSTVODataGridView.Columns[25].Visible = false; rODSTVODataGridView.Columns[26].Visible = false; rODSTVODataGridView.Columns[27].Visible = false; rODSTVODataGridView.Columns[28].Visible = false;
                //rODSTVODataGridView.Columns[31].Visible = false; rODSTVODataGridView.Columns[32].Visible = false; rODSTVODataGridView.Columns[33].Visible = false; rODSTVODataGridView.Columns[34].Visible = false; rODSTVODataGridView.Columns[35].Visible = false;
                //rODSTVODataGridView.Columns[36].Visible = false;

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' ') && (e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '"') && (e.KeyChar != '.') && (e.KeyChar != '/') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Не верный ввод данных!", "ERROR");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' ') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
                MessageBox.Show("Не верный ввод данных!", "ERROR");
            }
        }
    }
}
