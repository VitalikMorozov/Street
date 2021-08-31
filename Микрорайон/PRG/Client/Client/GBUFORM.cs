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
using Word = Microsoft.Office.Interop.Word;
namespace Микрорайон
{
    public partial class GBUFORM : Form
    {
        public SqlConnection con = new SqlConnection(@"  Data Source = ADMIN\SQLEXPRESS; Initial Catalog = GBU; Integrated Security = True");

       private readonly string templatefilename = @"";
        public GBUFORM()
        {
            InitializeComponent();
        }

        private void GBUFORM_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.allda". При необходимости она может быть перемещена или удалена.
            this.alldaTableAdapter.Fill(this.aKTDataSet.allda);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "GBUDataSet.View_2". При необходимости она может быть перемещена или удалена.
            //this.view_2TableAdapter.Fill(this.GBUDataSet.View_2);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "GBUDataSet.OBSLED". При необходимости она может быть перемещена или удалена.
            //this.OBSLEDTableAdapter.Fill(this.GBUDataSet.OBSLED);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "GBUDataSet.Deti". При необходимости она может быть перемещена или удалена.
            //this.DetiTableAdapter.Fill(this.GBUDataSet.Deti);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "GBUDataSet.Roditeli". При необходимости она может быть перемещена или удалена.
            //this.RoditeliTableAdapter.Fill(this.GBUDataSet.Roditeli);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "GBUDataSet.Ulica". При необходимости она может быть перемещена или удалена.
            //this.UlicaTableAdapter.Fill(this.GBUDataSet.Ulica);
            ////      SqlDataAdapter fil = new SqlDataAdapter(" SELECT dbo.Deti.FamRebenca AS Фамилия, dbo.Deti.ImRebenca AS Имя, dbo.Deti.OtcheRebenca AS Отчество, dbo.Deti.Data_Roj AS Дата_рождения, dbo.Deti.phone AS Телефон, dbo.Ulica.Название AS Улица, dbo.DOM.Num_dom AS[Номер дома], dbo.Deti.Kvartira AS Квартира, dbo.Klass.Number AS Класс, dbo.DOM.ID_ULICA, dbo.Klass.ID_Klass AS Expr2, dbo.Roditeli.Fam AS[Фамилия родителя]," +
            //          "                        dbo.Roditeli.Im AS[Имя родителя], dbo.Roditeli.Otche AS[Отчество родителя], dbo.Roditeli.ZANYA AS[Род занятия], dbo.Roditeli.ID_DOM AS Expr4, dbo.Roditeli.Kvartira AS Адрес," +
            //          "                         dbo.Roditeli.Primech AS Примечание, dbo.Roditeli.ID_VID_RODSTVA, dbo.Roditeli.PROJ_VMESTE AS[Проживание вместе], dbo.Roditeli.DOP_ADRES AS[доп адрес]," +
            //          "                        dbo.OBSLED.Data_obsled AS[Дата обследования], dbo.OBSLED.USPEVAEMOSTi AS успеваемость, dbo.OBSLED.UCHASTIE AS[участие родителя], dbo.OBSLED.Zanyatosti AS[занятость в свободное время]," +
            //          "                      dbo.OBSLED.uxod AS[Кто осуществляет уход], dbo.OBSLED.Sos_zdoriviya AS[состояние здоровья], dbo.OBSLED.rejim_dnaya AS[Режим дня], dbo.OBSLED.otdux AS Отдых," +
            //          "                      dbo.OBSLED.vzaimootn AS Взаимоотношение, dbo.OBSLED.vuplat AS[Выплаты на ребенка], dbo.OBSLED.nanimatel AS[Наниматель жилья], dbo.OBSLED.projivauchie AS Проживающие," +
            //          "                         dbo.OBSLED.obcha_plochad AS[Общая площадь], dbo.OBSLED.pomoch AS[Помощь в которой нуждается несовершеннолетний], dbo.OBSLED.vivod AS Выводы, dbo.Strana_proj.Naz AS Страна," +
            //          "                         dbo.RODSTVO.Naz AS Родство, dbo.Strana_proj.ID_STRANA AS Expr7, dbo.OBSLED.ID_REBENKA AS Expr6, dbo.RODSTVO.ID_RODST, dbo.Ulica.ID_Улица, dbo.DOM.ID_DOM, dbo.Deti.ID_DOM AS Expr1," +
            //          "                         dbo.Deti.ID_REBENKA, dbo.Klass.ID_KLASSRUk, dbo.Roditeli.id_REBENKA AS Expr3, dbo.Deti.ID_KLASS, dbo.Roditeli.ID_ROD, dbo.Roditeli.ID_STRANA, dbo.OBSLED.ID_OBSLED" +
            //          "FROM            dbo.Deti INNER JOIN" +
            //          "                         dbo.DOM ON dbo.Deti.ID_DOM = dbo.DOM.ID_DOM INNER JOIN" +
            //          "                         dbo.Klass ON dbo.Deti.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN" +
            //          "                         dbo.OBSLED ON dbo.Deti.ID_REBENKA = dbo.OBSLED.ID_REBENKA INNER JOIN" +
            //          "                         dbo.Roditeli ON dbo.Deti.ID_REBENKA = dbo.Roditeli.id_REBENKA AND dbo.DOM.ID_DOM = dbo.Roditeli.ID_DOM INNER JOIN" +
            //          "                         dbo.RODSTVO ON dbo.Roditeli.ID_VID_RODSTVA = dbo.RODSTVO.ID_RODST INNER JOIN" +
            //          "                         dbo.Strana_proj ON dbo.Roditeli.ID_STRANA = dbo.Strana_proj.ID_STRANA INNER JOIN" +
            //          "                         dbo.Ulica ON dbo.DOM.ID_ULICA = dbo.Ulica.ID_Улица", con);
            //      SqlCommandBuilder cb = new SqlCommandBuilder(fil);
            //      DataSet ds = new DataSet();
            //     // BindingSource BS = new BindingSource();
            //      fil.Fill(ds);
            //    bindingSource1.DataSource = ds;

            ////      bindingNavigator1.BindingSource = bindingSource1;
            //      view_2DataGridView.DataSource = ds.Tables[0];

            //            SELECT dbo.Deti.FamRebenca AS Фамилия, dbo.Deti.ImRebenca AS Имя, dbo.Deti.OtcheRebenca AS Отчество, dbo.Deti.Data_Roj AS Дата_рождения, dbo.Deti.phone AS Телефон, dbo.Ulica.Название AS Улица, 
            //                         dbo.DOM.Num_dom AS[Номер дома], dbo.Deti.Kvartira AS Квартира, dbo.Klass.Number AS Класс, dbo.DOM.ID_ULICA, dbo.Klass.ID_Klass AS Expr2, dbo.Roditeli.Fam AS[Фамилия родителя],
            //                        dbo.Roditeli.Im AS[Имя родителя], dbo.Roditeli.Otche AS[Отчество родителя], dbo.Roditeli.ZANYA AS[Род занятия], dbo.Roditeli.ID_DOM AS Expr4, dbo.Roditeli.Kvartira AS Адрес, 
            //                         dbo.Roditeli.Primech AS Примечание, dbo.Roditeli.ID_VID_RODSTVA, dbo.Roditeli.PROJ_VMESTE AS[Проживание вместе], dbo.Roditeli.DOP_ADRES AS[доп адрес],
            //                        dbo.OBSLED.Data_obsled AS[Дата обследования], dbo.OBSLED.USPEVAEMOSTi AS успеваемость, dbo.OBSLED.UCHASTIE AS[участие родителя], dbo.OBSLED.Zanyatosti AS[занятость в свободное время],
            //                      dbo.OBSLED.uxod AS[Кто осуществляет уход], dbo.OBSLED.Sos_zdoriviya AS[состояние здоровья], dbo.OBSLED.rejim_dnaya AS[Режим дня], dbo.OBSLED.otdux AS Отдых, 
            //                         dbo.OBSLED.vzaimootn AS Взаимоотношение, dbo.OBSLED.vuplat AS[Выплаты на ребенка], dbo.OBSLED.nanimatel AS[Наниматель жилья], dbo.OBSLED.projivauchie AS Проживающие, 
            //                         dbo.OBSLED.obcha_plochad AS[Общая площадь], dbo.OBSLED.pomoch AS[Помощь в которой нуждается несовершеннолетний], dbo.OBSLED.vivod AS Выводы, dbo.Strana_proj.Naz AS Страна, 
            //                         dbo.RODSTVO.Naz AS Родство, dbo.Strana_proj.ID_STRANA AS Expr7, dbo.OBSLED.ID_REBENKA AS Expr6, dbo.RODSTVO.ID_RODST, dbo.Ulica.ID_Улица, dbo.DOM.ID_DOM, dbo.Deti.ID_DOM AS Expr1, 
            //                         dbo.Deti.ID_REBENKA, dbo.Klass.ID_KLASSRUk, dbo.Roditeli.id_REBENKA AS Expr3, dbo.Deti.ID_KLASS, dbo.Roditeli.ID_ROD, dbo.Roditeli.ID_STRANA, dbo.OBSLED.ID_OBSLED
            //FROM            dbo.Deti INNER JOIN
            //                         dbo.DOM ON dbo.Deti.ID_DOM = dbo.DOM.ID_DOM INNER JOIN
            //                         dbo.Klass ON dbo.Deti.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN
            //                         dbo.OBSLED ON dbo.Deti.ID_REBENKA = dbo.OBSLED.ID_REBENKA INNER JOIN
            //                         dbo.Roditeli ON dbo.Deti.ID_REBENKA = dbo.Roditeli.id_REBENKA AND dbo.DOM.ID_DOM = dbo.Roditeli.ID_DOM INNER JOIN
            //                         dbo.RODSTVO ON dbo.Roditeli.ID_VID_RODSTVA = dbo.RODSTVO.ID_RODST INNER JOIN
            //                         dbo.Strana_proj ON dbo.Roditeli.ID_STRANA = dbo.Strana_proj.ID_STRANA INNER JOIN
            //                         dbo.Ulica ON dbo.DOM.ID_ULICA = dbo.Ulica.ID_Улица
            this.reportViewer1.RefreshReport();
        }

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
        //    Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
        //    Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
        //    worksheet = workbook.Sheets["Лист1"];
        //    worksheet = workbook.ActiveSheet;
        //    worksheet.Name = "АКТ";

        //    for (int i = 1; i < view_2DataGridView .Columns.Count + 1; i++)
        //    {
        //        worksheet.Cells[1, i] = view_2DataGridView.Columns[i - 1].HeaderText;
        //    }

        //    for (int i = 0; i < view_2DataGridView.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < view_2DataGridView.Columns.Count; j++)
        //        {
        //            worksheet.Cells[i + 2, j + 1] = view_2DataGridView.Rows[i].Cells[j].Value;
        //        }
        //    }

        //    var saveFileDialoge = new SaveFileDialog();
        //    saveFileDialoge.FileName = "ЖБУ";
        //    saveFileDialoge.DefaultExt = ".xlsx";
        //    if (saveFileDialoge.ShowDialog() == DialogResult.OK)
        //    {
        //        workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //    }
        //    app.Quit();
        //}
    }
        //private void ReplaceWordStub(string stubToReplace, string text, ref Word.Document wordDocument)
        //{


        //}

    }

