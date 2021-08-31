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
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Configuration;
using System.IO;
using System.Reflection;
namespace Микрорайон
{
    public partial class childrenprev : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));

        public childrenprev()
        {
            InitializeComponent();
        }

        private void detiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detiBindingSource.EndEdit();

        }

        private void childrenprev_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Deti". При необходимости она может быть перемещена или удалена.
//            this.detiTableAdapter.Fill(this.gBUDataSet.Deti);
            //SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT        dbo.AKT.ID_OBSLED, dbo.AKT.ID_REBENKA, dbo.AKT.Data_obsled AS [Дата обследования], dbo.UCHA.FamRebenca AS [Фамилия учащегося], dbo.AKT.OTVET_za_VOSPIT AS [Ответсвенный за воспитание],  dbo.AKT.VZAIMO_OT AS [Взаимоотношения в семье], dbo.AKT.vuplat AS Выплаты, dbo.AKT.VLADEL_ZILAYA AS [Владелец жилья], dbo.AKT.PLOSH_POMECH AS [Площадь жилого помещения],  dbo.AKT.OBESPECH AS [Материальная обеспеченность], dbo.AKT.BUT_UDOB AS [Бытовые удобства], dbo.AKT.NAL_SPAL_MESTA AS [Наличие спального места],  dbo.AKT.NAL_RAB_MESTA AS [Наличие рабочего места], dbo.AKT.KOLVO_V_KOMNATE AS [Количество проживающих в комнате], dbo.AKT.PRIMECH AS Примечание, dbo.AKT.ZAK AS Заключение,  dbo.KlassRuk.ID_Klass_ruck, dbo.KlassRuk.Login, dbo.KlassRuk.password, dbo.KlassRuk.FAM, dbo.KlassRuk.IM, dbo.KlassRuk.OTCHE, dbo.Klass.ID_Klass, dbo.Klass.BUKVA, dbo.Klass.Number,  dbo.Klass.SPECIALIZACIAYA, dbo.Klass.ID_KLASSRUk, dbo.RODSTVO.ID_RODST, dbo.RODSTVO.Naz, dbo.PROJ_VMESTE.ID_ROD, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.Fam AS Expr2,  dbo.PROJ_VMESTE.Im AS Expr3, dbo.PROJ_VMESTE.Otche AS Expr4, dbo.PROJ_VMESTE.PHONE, dbo.PROJ_VMESTE.DATA_ROJ, dbo.PROJ_VMESTE.MESTO_RAB, dbo.PROJ_VMESTE.MESTO_UCH,  dbo.PROJ_VMESTE.Primech AS Expr5, dbo.PROJ_VMESTE.SEM_POLOJEN, dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.UCHA.ID_REBENKA AS Expr6, dbo.UCHA.ImRebenca, dbo.UCHA.OtcheRebenca,  dbo.UCHA.Data_Roj AS Expr7, dbo.UCHA.phone AS Expr8, dbo.UCHA.ID_KLASS AS Expr9, dbo.UCHA.ID_DOM, dbo.UCHA.Kvartira, dbo.NACH_DANN.ID_Улица, dbo.NACH_DANN.INDEX_GOR,  dbo.NACH_DANN.GOROD, dbo.NACH_DANN.ULICA, dbo.DOM.ID_DOM AS Expr10, dbo.DOM.Num_dom, dbo.DOM.ID_NACH_DAN, dbo.Xar_uch.ID_XARAKTERISTIKA, dbo.Xar_uch.ID_OBSLED AS Expr11, dbo.Xar_uch.USPEV, dbo.Xar_uch.ZAN_V_SVOB_VREM, dbo.Xar_uch.NARU_V_POVEDENI FROM            dbo.AKT INNER JOIN dbo.KlassRuk INNER JOIN dbo.Klass ON dbo.KlassRuk.ID_Klass_ruck = dbo.Klass.ID_KLASSRUk INNER JOIN dbo.RODSTVO INNER JOIN dbo.PROJ_VMESTE ON dbo.RODSTVO.ID_RODST = dbo.PROJ_VMESTE.ID_VID_RODSTVA INNER JOIN dbo.UCHA ON dbo.PROJ_VMESTE.id_REBENKA = dbo.UCHA.ID_REBENKA ON dbo.Klass.ID_Klass = dbo.UCHA.ID_KLASS INNER JOIN dbo.NACH_DANN INNER JOIN dbo.DOM ON dbo.NACH_DANN.ID_Улица = dbo.DOM.ID_NACH_DAN ON dbo.UCHA.ID_DOM = dbo.DOM.ID_DOM ON dbo.AKT.ID_REBENKA = dbo.UCHA.ID_REBENKA INNER JOIN dbo.Xar_uch ON dbo.AKT.ID_OBSLED = dbo.Xar_uch.ID_OBSLED WHERE KlassRuk.ID_Klass_ruck = " + help.IDKLASS + " ", con);

            //DataTable DT = new DataTable();
            //sqlDa.Fill(DT);
            //detiDataGridView.DataSource = DT;

            //   SqlDataAdapter fil = new SqlDataAdapter("SELECT dbo.Deti.FamRebenca AS Фамилия, dbo.Deti.ImRebenca AS Имя, dbo.Deti.OtcheRebenca AS Отчество, dbo.Deti.Data_Roj AS [Дата рождения], dbo.Deti.phone AS Телефон, dbo.Klass.Number AS Класс, dbo.Ulica.Название AS Улица, dbo.DOM.Num_dom AS Дом, Kvartira AS Квартира FROM dbo.Deti INNER JOIN dbo.DOM ON dbo.Deti.ID_DOM = dbo.DOM.ID_DOM INNER JOIN dbo.Klass ON dbo.Deti.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.Ulica ON dbo.DOM.ID_ULICA = dbo.Ulica.ID_Улица", con);
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT    dbo.UCHA.FamRebenca AS [Фамилия] , dbo.UCHA.ImRebenca AS [Имя], dbo.UCHA.OtcheRebenca as [Отчество],  dbo.UCHA.Data_Roj AS [Дата рождения], dbo.UCHA.phone AS [Телефон], dbo.NACH_DANN.ULICA as [Улица],dbo.DOM.Num_dom as [Номер дома], dbo.UCHA.Kvartira as [Квартира], dbo.Klass.Number as [Номер], dbo.Klass.BUKVA as [Буква] ,dbo.AKT.ID_REBENKA, dbo.AKT.Data_obsled AS [Дата обследования], dbo.AKT.OTVET_za_VOSPIT AS [Ответсвенный за воспитание],  dbo.AKT.VZAIMO_OT AS [Взаимоотношения в семье], dbo.AKT.ID_OBSLED, dbo.AKT.vuplat AS Выплаты, dbo.AKT.VLADEL_ZILAYA AS [Владелец жилья], dbo.AKT.PLOSH_POMECH AS [Площадь жилого помещения],  dbo.AKT.OBESPECH AS [Материальная обеспеченность], dbo.AKT.BUT_UDOB AS [Бытовые удобства], dbo.AKT.NAL_SPAL_MESTA AS [Наличие спального места],  dbo.AKT.NAL_RAB_MESTA AS [Наличие рабочего места], dbo.AKT.KOLVO_V_KOMNATE AS [Количество проживающих в комнате], dbo.AKT.PRIMECH AS Примечание, dbo.AKT.ZAK AS Заключение,  dbo.KlassRuk.ID_Klass_ruck, dbo.KlassRuk.Login, dbo.KlassRuk.password, dbo.KlassRuk.FAM, dbo.KlassRuk.IM, dbo.KlassRuk.OTCHE, dbo.Klass.ID_Klass,   dbo.Klass.SPECIALIZACIAYA, dbo.Klass.ID_KLASSRUk, dbo.RODSTVO.ID_RODST, dbo.RODSTVO.Naz, dbo.PROJ_VMESTE.ID_ROD, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.Fam AS Expr2,  dbo.PROJ_VMESTE.Im AS Expr3, dbo.PROJ_VMESTE.Otche AS Expr4, dbo.PROJ_VMESTE.PHONE, dbo.PROJ_VMESTE.DATA_ROJ, dbo.PROJ_VMESTE.MESTO_RAB, dbo.PROJ_VMESTE.MESTO_UCH,  dbo.PROJ_VMESTE.Primech AS Expr5, dbo.PROJ_VMESTE.SEM_POLOJEN, dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.UCHA.ID_REBENKA AS Expr6, dbo.UCHA.ID_KLASS AS Expr9, dbo.UCHA.ID_DOM, dbo.NACH_DANN.ID_Улица, dbo.NACH_DANN.INDEX_GOR,  dbo.NACH_DANN.GOROD, dbo.DOM.ID_DOM AS Expr10,  dbo.DOM.ID_NACH_DAN, dbo.Xar_uch.ID_XARAKTERISTIKA, dbo.Xar_uch.ID_OBSLED AS Expr11, dbo.Xar_uch.USPEV, dbo.Xar_uch.ZAN_V_SVOB_VREM, dbo.Xar_uch.NARU_V_POVEDENI ,  dbo.Xar_uch.sost_zdorov FROM            dbo.AKT INNER JOIN dbo.KlassRuk INNER JOIN dbo.Klass ON dbo.KlassRuk.ID_Klass_ruck = dbo.Klass.ID_KLASSRUk INNER JOIN dbo.RODSTVO INNER JOIN dbo.PROJ_VMESTE ON dbo.RODSTVO.ID_RODST = dbo.PROJ_VMESTE.ID_VID_RODSTVA INNER JOIN dbo.UCHA ON dbo.PROJ_VMESTE.id_REBENKA = dbo.UCHA.ID_REBENKA ON dbo.Klass.ID_Klass = dbo.UCHA.ID_KLASS INNER JOIN dbo.NACH_DANN INNER JOIN dbo.DOM ON dbo.NACH_DANN.ID_Улица = dbo.DOM.ID_NACH_DAN ON dbo.UCHA.ID_DOM = dbo.DOM.ID_DOM ON dbo.AKT.ID_REBENKA = dbo.UCHA.ID_REBENKA INNER JOIN dbo.Xar_uch ON dbo.AKT.ID_OBSLED = dbo.Xar_uch.ID_OBSLED  ", con);

            SqlCommandBuilder cb = new SqlCommandBuilder(sqlDa);
            DataSet ds = new DataSet();
            sqlDa.Fill(ds);
            bindingSource1.DataSource = ds;
            
            detiBindingNavigator.BindingSource = bindingSource1;
            detiDataGridView.DataSource = ds.Tables[0];

            for (int ii = 0; ii < detiDataGridView.ColumnCount; ii++)
            {
                detiDataGridView.Columns[ii].Visible = false;
            }
            detiDataGridView.Columns[0].Visible = true;
            detiDataGridView.Columns[1].Visible = true;
            detiDataGridView.Columns[2].Visible = true;
            detiDataGridView.Columns[3].Visible = true;
            detiDataGridView.Columns[4].Visible = true;
            detiDataGridView.Columns[5].Visible = true;

            detiDataGridView.Columns[6].Visible = true;
            detiDataGridView.Columns[7].Visible = true;
            detiDataGridView.Columns[8].Visible = true;
            detiDataGridView.Columns[9].Visible = true;

            SqlDataAdapter sqlDaq = new SqlDataAdapter("SELECT        dbo.UCHA.ID_REBENKA, dbo.UCHA.FamRebenca AS Фамилия, dbo.UCHA.ImRebenca AS Имя, dbo.UCHA.OtcheRebenca AS Отчество, dbo.UCHA.Data_Roj AS [Дата рождения], dbo.UCHA.phone AS Телефон, dbo.Klass.Number AS Номер, dbo.Klass.BUKVA AS Буква, dbo.NACH_DANN.ULICA AS Улица, dbo.DOM.Num_dom AS [Номер дома], dbo.UCHA.Kvartira AS Квартира FROM            dbo.Klass INNER JOIN dbo.UCHA ON dbo.Klass.ID_Klass = dbo.UCHA.ID_KLASS INNER JOIN dbo.DOM ON dbo.UCHA.ID_DOM = dbo.DOM.ID_DOM INNER JOIN dbo.NACH_DANN ON dbo.DOM.ID_NACH_DAN = dbo.NACH_DANN.ID_Улица", con);

            DataTable DT = new DataTable();
            sqlDaq.Fill(DT);

            dataGridView1.DataSource = DT;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string query = "SELECT dbo.UCHA.FamRebenca AS[Фамилия], dbo.UCHA.ImRebenca AS[Имя], dbo.UCHA.OtcheRebenca as [Отчество],  dbo.UCHA.Data_Roj AS[Дата рождения], dbo.UCHA.phone AS[Телефон], dbo.NACH_DANN.ULICA as [Улица],dbo.DOM.Num_dom as [Номер дома], dbo.UCHA.Kvartira as [Квартира], dbo.Klass.Number as [Номер], dbo.Klass.BUKVA as [Буква] ,dbo.AKT.ID_REBENKA, dbo.AKT.Data_obsled AS[Дата обследования], dbo.AKT.OTVET_za_VOSPIT AS[Ответсвенный за воспитание], dbo.AKT.VZAIMO_OT AS[Взаимоотношения в семье], dbo.AKT.ID_OBSLED, dbo.AKT.vuplat AS Выплаты, dbo.AKT.VLADEL_ZILAYA AS[Владелец жилья], dbo.AKT.PLOSH_POMECH AS[Площадь жилого помещения], dbo.AKT.OBESPECH AS[Материальная обеспеченность], dbo.AKT.BUT_UDOB AS[Бытовые удобства], dbo.AKT.NAL_SPAL_MESTA AS[Наличие спального места], dbo.AKT.NAL_RAB_MESTA AS[Наличие рабочего места], dbo.AKT.KOLVO_V_KOMNATE AS[Количество проживающих в комнате], dbo.AKT.PRIMECH AS Примечание, dbo.AKT.ZAK AS Заключение,  dbo.KlassRuk.ID_Klass_ruck, dbo.KlassRuk.Login, dbo.KlassRuk.password, dbo.KlassRuk.FAM, dbo.KlassRuk.IM, dbo.KlassRuk.OTCHE, dbo.Klass.ID_Klass,   dbo.Klass.SPECIALIZACIAYA, dbo.Klass.ID_KLASSRUk, dbo.RODSTVO.ID_RODST, dbo.RODSTVO.Naz, dbo.PROJ_VMESTE.ID_ROD, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.Fam AS Expr2,  dbo.PROJ_VMESTE.Im AS Expr3, dbo.PROJ_VMESTE.Otche AS Expr4, dbo.PROJ_VMESTE.PHONE, dbo.PROJ_VMESTE.DATA_ROJ, dbo.PROJ_VMESTE.MESTO_RAB, dbo.PROJ_VMESTE.MESTO_UCH,  dbo.PROJ_VMESTE.Primech AS Expr5, dbo.PROJ_VMESTE.SEM_POLOJEN, dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.UCHA.ID_REBENKA AS Expr6, dbo.UCHA.ID_KLASS AS Expr9, dbo.UCHA.ID_DOM, dbo.NACH_DANN.ID_Улица, dbo.NACH_DANN.INDEX_GOR,  dbo.NACH_DANN.GOROD, dbo.DOM.ID_DOM AS Expr10,  dbo.DOM.ID_NACH_DAN, dbo.Xar_uch.ID_XARAKTERISTIKA, dbo.Xar_uch.ID_OBSLED AS Expr11, dbo.Xar_uch.USPEV, dbo.Xar_uch.ZAN_V_SVOB_VREM, dbo.Xar_uch.NARU_V_POVEDENI FROM            dbo.AKT INNER JOIN dbo.KlassRuk INNER JOIN dbo.Klass ON dbo.KlassRuk.ID_Klass_ruck = dbo.Klass.ID_KLASSRUk INNER JOIN dbo.RODSTVO INNER JOIN dbo.PROJ_VMESTE ON dbo.RODSTVO.ID_RODST = dbo.PROJ_VMESTE.ID_VID_RODSTVA INNER JOIN dbo.UCHA ON dbo.PROJ_VMESTE.id_REBENKA = dbo.UCHA.ID_REBENKA ON dbo.Klass.ID_Klass = dbo.UCHA.ID_KLASS INNER JOIN dbo.NACH_DANN INNER JOIN dbo.DOM ON dbo.NACH_DANN.ID_Улица = dbo.DOM.ID_NACH_DAN ON dbo.UCHA.ID_DOM = dbo.DOM.ID_DOM ON dbo.AKT.ID_REBENKA = dbo.UCHA.ID_REBENKA INNER JOIN dbo.Xar_uch ON dbo.AKT.ID_OBSLED = dbo.Xar_uch.ID_OBSLED  " +
                          "Where " +
                           "dbo.NACH_DANN.ULICA  like '%" + toolStripTextBox1.Text + "%' OR " +

                           " dbo.Klass.Number  like '%" + toolStripTextBox1.Text + "%'  OR" +
                           " dbo.Klass.BUKVA  like '%" + toolStripTextBox1.Text + "%'  OR" +
                           " dbo.UCHA.FamRebenca  like '%" + toolStripTextBox1.Text + "%'  OR"+
                           " dbo.UCHA.ImRebenca like '%" + toolStripTextBox1.Text + "%'  OR" +
                           " dbo.UCHA.OtcheRebenca like '%" + toolStripTextBox1.Text + "%'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter SomeAdapter = new SqlDataAdapter(cmd);
            DataSet SomeDataSet = new DataSet();
            DataSet ds = new DataSet();
            SomeAdapter.Fill(ds);
            bindingSource1.DataSource = ds;

            detiBindingNavigator.BindingSource = bindingSource1;
            detiDataGridView.DataSource = ds.Tables[0];
            for (int ii = 0; ii < detiDataGridView.ColumnCount; ii++)
            {
                detiDataGridView.Columns[ii].Visible = false;
            }
            detiDataGridView.Columns[0].Visible = true;
            detiDataGridView.Columns[1].Visible = true;
            detiDataGridView.Columns[2].Visible = true;
            detiDataGridView.Columns[3].Visible = true;
            detiDataGridView.Columns[4].Visible = true;
            detiDataGridView.Columns[5].Visible = true;

            detiDataGridView.Columns[6].Visible = true;
            detiDataGridView.Columns[7].Visible = true;
            detiDataGridView.Columns[8].Visible = true;
            detiDataGridView.Columns[9].Visible = true;
            con.Close();

        }

        private void imgS_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT    dbo.UCHA.FamRebenca AS [Фамилия] , dbo.UCHA.ImRebenca AS [Имя], dbo.UCHA.OtcheRebenca as [Отчество],  dbo.UCHA.Data_Roj AS [Дата рождения], dbo.UCHA.phone AS [Телефон], dbo.NACH_DANN.ULICA as [Улица],dbo.DOM.Num_dom as [Номер дома], dbo.UCHA.Kvartira as [Квартира], dbo.Klass.Number as [Номер], dbo.Klass.BUKVA as [Буква] ,dbo.AKT.ID_REBENKA, dbo.AKT.Data_obsled AS [Дата обследования], dbo.AKT.OTVET_za_VOSPIT AS [Ответсвенный за воспитание],  dbo.AKT.VZAIMO_OT AS [Взаимоотношения в семье], dbo.AKT.ID_OBSLED, dbo.AKT.vuplat AS Выплаты, dbo.AKT.VLADEL_ZILAYA AS [Владелец жилья], dbo.AKT.PLOSH_POMECH AS [Площадь жилого помещения],  dbo.AKT.OBESPECH AS [Материальная обеспеченность], dbo.AKT.BUT_UDOB AS [Бытовые удобства], dbo.AKT.NAL_SPAL_MESTA AS [Наличие спального места],  dbo.AKT.NAL_RAB_MESTA AS [Наличие рабочего места], dbo.AKT.KOLVO_V_KOMNATE AS [Количество проживающих в комнате], dbo.AKT.PRIMECH AS Примечание, dbo.AKT.ZAK AS Заключение,  dbo.KlassRuk.ID_Klass_ruck, dbo.KlassRuk.Login, dbo.KlassRuk.password, dbo.KlassRuk.FAM, dbo.KlassRuk.IM, dbo.KlassRuk.OTCHE, dbo.Klass.ID_Klass,   dbo.Klass.SPECIALIZACIAYA, dbo.Klass.ID_KLASSRUk, dbo.RODSTVO.ID_RODST, dbo.RODSTVO.Naz, dbo.PROJ_VMESTE.ID_ROD, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.Fam AS Expr2,  dbo.PROJ_VMESTE.Im AS Expr3, dbo.PROJ_VMESTE.Otche AS Expr4, dbo.PROJ_VMESTE.PHONE, dbo.PROJ_VMESTE.DATA_ROJ, dbo.PROJ_VMESTE.MESTO_RAB, dbo.PROJ_VMESTE.MESTO_UCH,  dbo.PROJ_VMESTE.Primech AS Expr5, dbo.PROJ_VMESTE.SEM_POLOJEN, dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.UCHA.ID_REBENKA AS Expr6, dbo.UCHA.ID_KLASS AS Expr9, dbo.UCHA.ID_DOM, dbo.NACH_DANN.ID_Улица, dbo.NACH_DANN.INDEX_GOR,  dbo.NACH_DANN.GOROD, dbo.DOM.ID_DOM AS Expr10,  dbo.DOM.ID_NACH_DAN, dbo.Xar_uch.ID_XARAKTERISTIKA, dbo.Xar_uch.ID_OBSLED AS Expr11, dbo.Xar_uch.USPEV, dbo.Xar_uch.ZAN_V_SVOB_VREM, dbo.Xar_uch.NARU_V_POVEDENI ,  dbo.Xar_uch.sost_zdorov FROM            dbo.AKT INNER JOIN dbo.KlassRuk INNER JOIN dbo.Klass ON dbo.KlassRuk.ID_Klass_ruck = dbo.Klass.ID_KLASSRUk INNER JOIN dbo.RODSTVO INNER JOIN dbo.PROJ_VMESTE ON dbo.RODSTVO.ID_RODST = dbo.PROJ_VMESTE.ID_VID_RODSTVA INNER JOIN dbo.UCHA ON dbo.PROJ_VMESTE.id_REBENKA = dbo.UCHA.ID_REBENKA ON dbo.Klass.ID_Klass = dbo.UCHA.ID_KLASS INNER JOIN dbo.NACH_DANN INNER JOIN dbo.DOM ON dbo.NACH_DANN.ID_Улица = dbo.DOM.ID_NACH_DAN ON dbo.UCHA.ID_DOM = dbo.DOM.ID_DOM ON dbo.AKT.ID_REBENKA = dbo.UCHA.ID_REBENKA INNER JOIN dbo.Xar_uch ON dbo.AKT.ID_OBSLED = dbo.Xar_uch.ID_OBSLED  ", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(sqlDa);
            DataSet ds = new DataSet();
            sqlDa.Fill(ds);
            bindingSource1.DataSource = ds;

            detiBindingNavigator.BindingSource = bindingSource1;
            detiDataGridView.DataSource = ds.Tables[0];
            for (int ii = 0; ii < detiDataGridView.ColumnCount; ii++)
            {
                detiDataGridView.Columns[ii].Visible = false;
            }
            detiDataGridView.Columns[0].Visible = true;
            detiDataGridView.Columns[1].Visible = true;
            detiDataGridView.Columns[2].Visible = true;
            detiDataGridView.Columns[3].Visible = true;
            detiDataGridView.Columns[4].Visible = true;
            detiDataGridView.Columns[5].Visible = true;

            detiDataGridView.Columns[6].Visible = true;
            detiDataGridView.Columns[7].Visible = true;
            detiDataGridView.Columns[8].Visible = true;
            detiDataGridView.Columns[9].Visible = true;

        }

        private void detiBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        //Find and Replace Method
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();


                //find and replace
                this.FindAndReplace(wordApp, "<dateobsled>", detiDataGridView.CurrentRow.Cells[11].Value.ToString());
                this.FindAndReplace(wordApp, "<FIOUCH>", detiDataGridView.CurrentRow.Cells[0].Value.ToString() + " " + detiDataGridView.CurrentRow.Cells[1].Value.ToString() + " " + detiDataGridView.CurrentRow.Cells[2].Value.ToString());
                this.FindAndReplace(wordApp, "<dateroj>", detiDataGridView.CurrentRow.Cells[3].Value.ToString());
                this.FindAndReplace(wordApp, "<adres>", detiDataGridView.CurrentRow.Cells[52].Value.ToString() + "," + detiDataGridView.CurrentRow.Cells[53].Value.ToString() + " " + detiDataGridView.CurrentRow.Cells[5].Value.ToString() + " д." + detiDataGridView.CurrentRow.Cells[6].Value.ToString() + " кв." + detiDataGridView.CurrentRow.Cells[7].Value.ToString() + ", +" + detiDataGridView.CurrentRow.Cells[4].Value.ToString());
                this.FindAndReplace(wordApp, "<projiv>", detiDataGridView.CurrentRow.Cells[38].Value.ToString() + " " + detiDataGridView.CurrentRow.Cells[39].Value.ToString() + " " + detiDataGridView.CurrentRow.Cells[40].Value.ToString() + " ," + detiDataGridView.CurrentRow.Cells[42].Value.ToString() + " ," + detiDataGridView.CurrentRow.Cells[41].Value.ToString() + " ," + detiDataGridView.CurrentRow.Cells[43].Value.ToString() + " ," + detiDataGridView.CurrentRow.Cells[44].Value.ToString() + " " + detiDataGridView.CurrentRow.Cells[45].Value.ToString() + " " + detiDataGridView.CurrentRow.Cells[46].Value.ToString() + "(" + detiDataGridView.CurrentRow.Cells[35].Value.ToString() + " ).");
                this.FindAndReplace(wordApp, "<otvets>", detiDataGridView.CurrentRow.Cells[12].Value.ToString());
                this.FindAndReplace(wordApp, "<klass>", detiDataGridView.CurrentRow.Cells[8].Value.ToString() + " " + detiDataGridView.CurrentRow.Cells[9].Value.ToString() + " (" + detiDataGridView.CurrentRow.Cells[32].Value.ToString() + ")");
                this.FindAndReplace(wordApp, "<uspev>", detiDataGridView.CurrentRow.Cells[58].Value.ToString());
                this.FindAndReplace(wordApp, "<zan>", detiDataGridView.CurrentRow.Cells[59].Value.ToString());
                this.FindAndReplace(wordApp, "<sostzdor>", detiDataGridView.CurrentRow.Cells[61].Value.ToString());
                this.FindAndReplace(wordApp, "<poved>", detiDataGridView.CurrentRow.Cells[60].Value.ToString());
                this.FindAndReplace(wordApp, "<vzaimootn>", detiDataGridView.CurrentRow.Cells[13].Value.ToString());
                this.FindAndReplace(wordApp, "<viplat>", detiDataGridView.CurrentRow.Cells[15].Value.ToString());
                this.FindAndReplace(wordApp, "<nanim>", detiDataGridView.CurrentRow.Cells[16].Value.ToString());
                this.FindAndReplace(wordApp, "<spalmesto>", detiDataGridView.CurrentRow.Cells[20].Value.ToString());
                this.FindAndReplace(wordApp, "<rabmesto>", detiDataGridView.CurrentRow.Cells[21].Value.ToString());
                this.FindAndReplace(wordApp, "<kolvo>", detiDataGridView.CurrentRow.Cells[22].Value.ToString());
                this.FindAndReplace(wordApp, "<plosiudob>", detiDataGridView.CurrentRow.Cells[19].Value.ToString() + " Площадь жилого помещения" + detiDataGridView.CurrentRow.Cells[17].Value.ToString());
                this.FindAndReplace(wordApp, "<matobes>", detiDataGridView.CurrentRow.Cells[18].Value.ToString());
                this.FindAndReplace(wordApp, "<vivod>", "Примечание: " + detiDataGridView.CurrentRow.Cells[23].Value.ToString() + ".  Заключение: " + detiDataGridView.CurrentRow.Cells[24].Value.ToString());

            }
            else
            {
                MessageBox.Show("Во время выполнения произошла ошибка (Файл не найден!)");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Файл создан!");
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Word.Document doc = null;
            try
            {
                CreateWordDocument(@"C:\PRG\Client\temp.docx", @"C:\PRG\Client\Client\bin\Debug\СФОРМИРОВАННЫЙ-AKT.docx");
                //F:\1EDUCATION\4\PredDiplom\Client\Client\
                //
            }
            catch (Exception ex)
            {
                // Если произошла ошибка, то
                // закрываем документ и выводим информацию
                //doc.Close();
                //doc = null;
                Console.WriteLine("Во время выполнения произошла ошибка!");
                Console.ReadLine();
            }
        }
    }
}
