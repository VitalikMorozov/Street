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
    public partial class VIEWER : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));
        public VIEWER()
        {
            InitializeComponent();
        }

        private void VIEWER_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.проживвместе". При необходимости она может быть перемещена или удалена.
            this.проживвместеTableAdapter.Fill(this.aKTDataSet.проживвместе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.проживвместе". При необходимости она может быть перемещена или удалена.
            this.проживвместеTableAdapter.Fill(this.aKTDataSet.проживвместе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.PROJ_VMESTE". При необходимости она может быть перемещена или удалена.
            this.pROJ_VMESTETableAdapter.Fill(this.aKTDataSet.PROJ_VMESTE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.UCHA". При необходимости она может быть перемещена или удалена.
            this.uCHATableAdapter.Fill(this.aKTDataSet.UCHA);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Strana_proj". При необходимости она может быть перемещена или удалена.
            //this.strana_projTableAdapter.Fill(this.gBUDataSet.Strana_proj);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.RODSTVO". При необходимости она может быть перемещена или удалена.
            //this.rODSTVOTableAdapter.Fill(this.gBUDataSet.RODSTVO);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.DOM". При необходимости она может быть перемещена или удалена.
            //this.dOMTableAdapter.Fill(this.gBUDataSet.DOM);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Ulica". При необходимости она может быть перемещена или удалена.
            //this.ulicaTableAdapter.Fill(this.gBUDataSet.Ulica);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Klass". При необходимости она может быть перемещена или удалена.
            //this.klassTableAdapter.Fill(this.gBUDataSet.Klass);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Roditeli". При необходимости она может быть перемещена или удалена.
            //this.roditeliTableAdapter.Fill(this.gBUDataSet.Roditeli);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Deti". При необходимости она может быть перемещена или удалена.
            //this.detiTableAdapter.Fill(this.gBUDataSet.Deti);

            //    string query =  "SELECT        dbo.UCHA.ID_REBENKA, dbo.UCHA.FamRebenca, dbo.UCHA.ImRebenca, dbo.UCHA.OtcheRebenca, dbo.UCHA.Kvartira, dbo.UCHA.ID_DOM, dbo.UCHA.phone, dbo.UCHA.ID_KLASS, dbo.UCHA.Data_Roj,              dbo.KlassRuk.ID_Klass_ruck, dbo.Klass.ID_KLASSRUk, dbo.Klass.ID_Klass AS Expr1, dbo.Klass.BUKVA, dbo.Klass.Number, dbo.Klass.SPECIALIZACIAYA FROM dbo.UCHA INNER JOIN dbo.Klass ON dbo.UCHA.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN  dbo.KlassRuk ON dbo.Klass.ID_KLASSRUk = dbo.KlassRuk.ID_Klass_ruck where(ID_Klass_ruck = '" + help.IDKLASS + "' ", con  ;
            try
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT        dbo.UCHA.ID_REBENKA, dbo.UCHA.FamRebenca AS Фамилия, dbo.UCHA.ImRebenca AS Имя, dbo.UCHA.OtcheRebenca AS Отчество, dbo.UCHA.Data_Roj AS [Дата рождения], dbo.UCHA.phone AS Телефон,  dbo.UCHA.ID_KLASS, dbo.Klass.Number AS Класс, dbo.Klass.BUKVA, dbo.NACH_DANN.ULICA AS Улица, dbo.DOM.Num_dom AS Дом, dbo.UCHA.Kvartira AS Квартира, dbo.UCHA.ID_DOM AS EX1,  dbo.Klass.SPECIALIZACIAYA, dbo.KlassRuk.ID_Klass_ruck, dbo.Klass.ID_KLASSRUk, dbo.Klass.ID_Klass AS Expr1, dbo.DOM.ID_DOM, dbo.DOM.ID_NACH_DAN, dbo.NACH_DANN.ID_Улица,  dbo.NACH_DANN.INDEX_GOR, dbo.NACH_DANN.GOROD FROM            dbo.UCHA INNER JOIN dbo.Klass ON dbo.UCHA.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.KlassRuk ON dbo.Klass.ID_KLASSRUk = dbo.KlassRuk.ID_Klass_ruck INNER JOIN dbo.DOM ON dbo.UCHA.ID_DOM = dbo.DOM.ID_DOM INNER JOIN dbo.NACH_DANN ON dbo.DOM.ID_NACH_DAN = dbo.NACH_DANN.ID_Улица where ID_Klass_ruck = " + help.IDKLASS + " ", con);
                DataTable DT = new DataTable();
                sqlDa.Fill(DT);

                detiDataGridView.DataSource = DT;


                detiDataGridView.Columns[0].Visible = false;
                detiDataGridView.Columns[6].Visible = false;
                detiDataGridView.Columns[8].Visible = false;
                detiDataGridView.Columns[12].Visible = false;
                detiDataGridView.Columns[13].Visible = false;
                detiDataGridView.Columns[14].Visible = false;
                detiDataGridView.Columns[15].Visible = false;
                detiDataGridView.Columns[16].Visible = false;
                detiDataGridView.Columns[17].Visible = false;
                detiDataGridView.Columns[18].Visible = false;
                detiDataGridView.Columns[19].Visible = false;
                detiDataGridView.Columns[20].Visible = false;
                detiDataGridView.Columns[21].Visible = false;

                List<string> SelectedRows = new List<string>();
                foreach (DataGridViewRow r in detiDataGridView.SelectedRows)
                {
                    SelectedRows.Add(r.Cells[0].Value.ToString());
                }

                string ss = SelectedRows[0];

                SqlDataAdapter sqlrod = new SqlDataAdapter("SELECT        dbo.PROJ_VMESTE.ID_ROD, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.Fam AS Фамилия, dbo.PROJ_VMESTE.Im AS Имя, dbo.PROJ_VMESTE.Otche AS Отчество,  dbo.PROJ_VMESTE.PHONE AS Телефон, dbo.PROJ_VMESTE.DATA_ROJ AS [Дата рождения], dbo.PROJ_VMESTE.MESTO_RAB AS [Место работы], dbo.PROJ_VMESTE.MESTO_UCH AS [Место учебы],  dbo.PROJ_VMESTE.Primech AS Примечание, dbo.PROJ_VMESTE.SEM_POLOJEN AS [Семейное положение], dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.UCHA.ID_REBENKA, dbo.DOM.ID_DOM, dbo.DOM.Num_dom, dbo.DOM.ID_NACH_DAN, dbo.NACH_DANN.ID_Улица, dbo.NACH_DANN.INDEX_GOR, dbo.NACH_DANN.GOROD, dbo.NACH_DANN.ULICA, dbo.RODSTVO.ID_RODST,  dbo.RODSTVO.Naz AS [Вид родства] FROM            dbo.DOM INNER JOIN dbo.NACH_DANN ON dbo.DOM.ID_NACH_DAN = dbo.NACH_DANN.ID_Улица INNER JOIN dbo.UCHA ON dbo.DOM.ID_DOM = dbo.UCHA.ID_DOM INNER JOIN dbo.PROJ_VMESTE INNER JOIN dbo.RODSTVO ON dbo.PROJ_VMESTE.ID_VID_RODSTVA = dbo.RODSTVO.ID_RODST ON dbo.UCHA.ID_REBENKA = dbo.PROJ_VMESTE.id_REBENKA where UCHA.ID_REBENKA = " + ss + " ", con);
                DataTable DTrod = new DataTable();
                sqlrod.Fill(DTrod);

                roditeliDataGridView.DataSource = DTrod;

                roditeliDataGridView.Columns[0].Visible = false;
                roditeliDataGridView.Columns[1].Visible = false;
                roditeliDataGridView.Columns[11].Visible = false;
                roditeliDataGridView.Columns[12].Visible = false;
                roditeliDataGridView.Columns[13].Visible = false;
                roditeliDataGridView.Columns[14].Visible = false;
                roditeliDataGridView.Columns[15].Visible = false;
                roditeliDataGridView.Columns[16].Visible = false;
                roditeliDataGridView.Columns[17].Visible = false;
                roditeliDataGridView.Columns[18].Visible = false;
                roditeliDataGridView.Columns[19].Visible = false;
                roditeliDataGridView.Columns[20].Visible = false;
            }
            catch {
                MessageBox.Show("У классного руководителя отсутствуют ученики","ERROR");
            }

        }

        private void detiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detiBindingSource.EndEdit();
         //   this.tableAdapterManager.UpdateAll(this.gBUDataSet);

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void detiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> SelectedRows = new List<string>();
            foreach (DataGridViewRow r in detiDataGridView.SelectedRows)
            {
                SelectedRows.Add(r.Cells[0].Value.ToString());
            }

            string ss = SelectedRows[0];

            SqlDataAdapter sqlrod = new SqlDataAdapter("SELECT        dbo.PROJ_VMESTE.ID_ROD, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.Fam AS Фамилия, dbo.PROJ_VMESTE.Im AS Имя, dbo.PROJ_VMESTE.Otche AS Отчество,  dbo.PROJ_VMESTE.PHONE AS Телефон, dbo.PROJ_VMESTE.DATA_ROJ AS [Дата рождения], dbo.PROJ_VMESTE.MESTO_RAB AS [Место работы], dbo.PROJ_VMESTE.MESTO_UCH AS [Место учебы],  dbo.PROJ_VMESTE.Primech AS Примечание, dbo.PROJ_VMESTE.SEM_POLOJEN AS [Семейное положение], dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.UCHA.ID_REBENKA, dbo.DOM.ID_DOM, dbo.DOM.Num_dom, dbo.DOM.ID_NACH_DAN, dbo.NACH_DANN.ID_Улица, dbo.NACH_DANN.INDEX_GOR, dbo.NACH_DANN.GOROD, dbo.NACH_DANN.ULICA, dbo.RODSTVO.ID_RODST,  dbo.RODSTVO.Naz AS [Вид родства] FROM            dbo.DOM INNER JOIN dbo.NACH_DANN ON dbo.DOM.ID_NACH_DAN = dbo.NACH_DANN.ID_Улица INNER JOIN dbo.UCHA ON dbo.DOM.ID_DOM = dbo.UCHA.ID_DOM INNER JOIN dbo.PROJ_VMESTE INNER JOIN dbo.RODSTVO ON dbo.PROJ_VMESTE.ID_VID_RODSTVA = dbo.RODSTVO.ID_RODST ON dbo.UCHA.ID_REBENKA = dbo.PROJ_VMESTE.id_REBENKA where UCHA.ID_REBENKA = " + ss + " ", con);
            DataTable DTrod = new DataTable();
            sqlrod.Fill(DTrod);

            roditeliDataGridView.DataSource = DTrod;
            roditeliDataGridView.Columns[0].Visible = false;
            roditeliDataGridView.Columns[1].Visible = false;
            roditeliDataGridView.Columns[11].Visible = false;
            roditeliDataGridView.Columns[12].Visible = false;
            roditeliDataGridView.Columns[13].Visible = false;
            roditeliDataGridView.Columns[14].Visible = false;
            roditeliDataGridView.Columns[15].Visible = false;
            roditeliDataGridView.Columns[16].Visible = false;
            roditeliDataGridView.Columns[17].Visible = false;
            roditeliDataGridView.Columns[18].Visible = false;
            roditeliDataGridView.Columns[19].Visible = false;
            roditeliDataGridView.Columns[20].Visible = false;
        }

        private void detiDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> SelectedRows = new List<string>();
            foreach (DataGridViewRow r in detiDataGridView.SelectedRows)
            {
                SelectedRows.Add(r.Cells[0].Value.ToString());
            }

            string ss = SelectedRows[0];

            SqlDataAdapter sqlrod = new SqlDataAdapter("SELECT        dbo.PROJ_VMESTE.ID_ROD, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.Fam AS Фамилия, dbo.PROJ_VMESTE.Im AS Имя, dbo.PROJ_VMESTE.Otche AS Отчество,  dbo.PROJ_VMESTE.PHONE AS Телефон, dbo.PROJ_VMESTE.DATA_ROJ AS [Дата рождения], dbo.PROJ_VMESTE.MESTO_RAB AS [Место работы], dbo.PROJ_VMESTE.MESTO_UCH AS [Место учебы],  dbo.PROJ_VMESTE.Primech AS Примечание, dbo.PROJ_VMESTE.SEM_POLOJEN AS [Семейное положение], dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.UCHA.ID_REBENKA, dbo.DOM.ID_DOM, dbo.DOM.Num_dom, dbo.DOM.ID_NACH_DAN, dbo.NACH_DANN.ID_Улица, dbo.NACH_DANN.INDEX_GOR, dbo.NACH_DANN.GOROD, dbo.NACH_DANN.ULICA, dbo.RODSTVO.ID_RODST,  dbo.RODSTVO.Naz AS [Вид родства] FROM            dbo.DOM INNER JOIN dbo.NACH_DANN ON dbo.DOM.ID_NACH_DAN = dbo.NACH_DANN.ID_Улица INNER JOIN dbo.UCHA ON dbo.DOM.ID_DOM = dbo.UCHA.ID_DOM INNER JOIN dbo.PROJ_VMESTE INNER JOIN dbo.RODSTVO ON dbo.PROJ_VMESTE.ID_VID_RODSTVA = dbo.RODSTVO.ID_RODST ON dbo.UCHA.ID_REBENKA = dbo.PROJ_VMESTE.id_REBENKA where UCHA.ID_REBENKA = " + ss + " ", con);
            DataTable DTrod = new DataTable();
            sqlrod.Fill(DTrod);

            roditeliDataGridView.DataSource = DTrod;
            roditeliDataGridView.Columns[0].Visible = false;
            roditeliDataGridView.Columns[1].Visible = false;
            roditeliDataGridView.Columns[11].Visible = false;
            roditeliDataGridView.Columns[12].Visible = false;
            roditeliDataGridView.Columns[13].Visible = false;
            roditeliDataGridView.Columns[14].Visible = false;
            roditeliDataGridView.Columns[15].Visible = false;
            roditeliDataGridView.Columns[16].Visible = false;
            roditeliDataGridView.Columns[17].Visible = false;
            roditeliDataGridView.Columns[18].Visible = false;
            roditeliDataGridView.Columns[19].Visible = false;
            roditeliDataGridView.Columns[20].Visible = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
