using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
namespace Микрорайон
{
    public partial class GBUEDIT : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));
        private readonly String TemplateFileName = @"\AKT.dotx";
        public GBUEDIT()
        {
            InitializeComponent();
        }

        private void oBSLEDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oBSLEDBindingSource.EndEdit();
          //  this.tableAdapterManager.UpdateAll(this.gBUDataSet);

        }

        private void GBUEDIT_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Deti". При необходимости она может быть перемещена или удалена.
            //this.detiTableAdapter.Fill(this.gBUDataSet.Deti);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.View_2". При необходимости она может быть перемещена или удалена.
            //this.view_2TableAdapter.Fill(this.gBUDataSet.View_2);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.OBSLED". При необходимости она может быть перемещена или удалена.
            //this.oBSLEDTableAdapter.Fill(this.gBUDataSet.OBSLED);
            //oBSLEDDataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;


            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT        dbo.AKT.ID_OBSLED, dbo.AKT.ID_REBENKA, dbo.AKT.Data_obsled AS [Дата обследования], dbo.UCHA.FamRebenca AS [Фамилия учащегося], dbo.AKT.OTVET_za_VOSPIT AS [Ответсвенный за воспитание],  dbo.AKT.VZAIMO_OT AS [Взаимоотношения в семье], dbo.AKT.vuplat AS Выплаты, dbo.AKT.VLADEL_ZILAYA AS [Владелец жилья], dbo.AKT.PLOSH_POMECH AS [Площадь жилого помещения],  dbo.AKT.OBESPECH AS [Материальная обеспеченность], dbo.AKT.BUT_UDOB AS [Бытовые удобства], dbo.AKT.NAL_SPAL_MESTA AS [Наличие спального места],  dbo.AKT.NAL_RAB_MESTA AS [Наличие рабочего места], dbo.AKT.KOLVO_V_KOMNATE AS [Количество проживающих в комнате], dbo.AKT.PRIMECH AS Примечание, dbo.AKT.ZAK AS Заключение,  dbo.KlassRuk.ID_Klass_ruck, dbo.KlassRuk.Login, dbo.KlassRuk.password, dbo.KlassRuk.FAM, dbo.KlassRuk.IM, dbo.KlassRuk.OTCHE, dbo.Klass.ID_Klass, dbo.Klass.BUKVA, dbo.Klass.Number,  dbo.Klass.SPECIALIZACIAYA, dbo.Klass.ID_KLASSRUk, dbo.RODSTVO.ID_RODST, dbo.RODSTVO.Naz, dbo.PROJ_VMESTE.ID_ROD, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.Fam AS Expr2,  dbo.PROJ_VMESTE.Im AS Expr3, dbo.PROJ_VMESTE.Otche AS Expr4, dbo.PROJ_VMESTE.PHONE, dbo.PROJ_VMESTE.DATA_ROJ, dbo.PROJ_VMESTE.MESTO_RAB, dbo.PROJ_VMESTE.MESTO_UCH,  dbo.PROJ_VMESTE.Primech AS Expr5, dbo.PROJ_VMESTE.SEM_POLOJEN, dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.UCHA.ID_REBENKA AS Expr6, dbo.UCHA.ImRebenca, dbo.UCHA.OtcheRebenca,  dbo.UCHA.Data_Roj AS Expr7, dbo.UCHA.phone AS Expr8, dbo.UCHA.ID_KLASS AS Expr9, dbo.UCHA.ID_DOM, dbo.UCHA.Kvartira, dbo.NACH_DANN.ID_Улица, dbo.NACH_DANN.INDEX_GOR,  dbo.NACH_DANN.GOROD, dbo.NACH_DANN.ULICA, dbo.DOM.ID_DOM AS Expr10, dbo.DOM.Num_dom, dbo.DOM.ID_NACH_DAN, dbo.Xar_uch.ID_XARAKTERISTIKA, dbo.Xar_uch.ID_OBSLED AS Expr11, dbo.Xar_uch.USPEV, dbo.Xar_uch.ZAN_V_SVOB_VREM, dbo.Xar_uch.NARU_V_POVEDENI,  dbo.Xar_uch.sost_zdorov FROM            dbo.AKT INNER JOIN dbo.KlassRuk INNER JOIN dbo.Klass ON dbo.KlassRuk.ID_Klass_ruck = dbo.Klass.ID_KLASSRUk INNER JOIN dbo.RODSTVO INNER JOIN dbo.PROJ_VMESTE ON dbo.RODSTVO.ID_RODST = dbo.PROJ_VMESTE.ID_VID_RODSTVA INNER JOIN dbo.UCHA ON dbo.PROJ_VMESTE.id_REBENKA = dbo.UCHA.ID_REBENKA ON dbo.Klass.ID_Klass = dbo.UCHA.ID_KLASS INNER JOIN dbo.NACH_DANN INNER JOIN dbo.DOM ON dbo.NACH_DANN.ID_Улица = dbo.DOM.ID_NACH_DAN ON dbo.UCHA.ID_DOM = dbo.DOM.ID_DOM ON dbo.AKT.ID_REBENKA = dbo.UCHA.ID_REBENKA INNER JOIN dbo.Xar_uch ON dbo.AKT.ID_OBSLED = dbo.Xar_uch.ID_OBSLED WHERE KlassRuk.ID_Klass_ruck = " + help.IDKLASS + " ", con);

            DataTable DT = new DataTable();
            sqlDa.Fill(DT);
            oBSLEDDataGridView.DataSource = DT;
            oBSLEDDataGridView.Columns[0].Visible = false;
            oBSLEDDataGridView.Columns[1].Visible = false;
            for (int ii=16; ii< oBSLEDDataGridView.ColumnCount; ii++)
            {
            oBSLEDDataGridView.Columns[ii].Visible = false;
            }
            
            //oBSLEDDataGridView.Columns[3].Visible = false;
            //oBSLEDDataGridView.Columns[4].Visible = false;
          
            con.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GBUFORM ds = new GBUFORM();
            ds.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        { try
            {
                enterAKTINFOM s = new enterAKTINFOM();
                s.ShowDialog();
                if (s.DialogResult == DialogResult.OK)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT        dbo.AKT.ID_OBSLED, dbo.AKT.ID_REBENKA, dbo.AKT.Data_obsled AS [Дата обследования], dbo.UCHA.FamRebenca AS [Фамилия учащегося], dbo.AKT.OTVET_za_VOSPIT AS [Ответсвенный за воспитание],  dbo.AKT.VZAIMO_OT AS [Взаимоотношения в семье], dbo.AKT.vuplat AS Выплаты, dbo.AKT.VLADEL_ZILAYA AS [Владелец жилья], dbo.AKT.PLOSH_POMECH AS [Площадь жилого помещения],  dbo.AKT.OBESPECH AS [Материальная обеспеченность], dbo.AKT.BUT_UDOB AS [Бытовые удобства], dbo.AKT.NAL_SPAL_MESTA AS [Наличие спального места],  dbo.AKT.NAL_RAB_MESTA AS [Наличие рабочего места], dbo.AKT.KOLVO_V_KOMNATE AS [Количество проживающих в комнате], dbo.AKT.PRIMECH AS Примечание, dbo.AKT.ZAK AS Заключение,  dbo.KlassRuk.ID_Klass_ruck, dbo.KlassRuk.Login, dbo.KlassRuk.password, dbo.KlassRuk.FAM, dbo.KlassRuk.IM, dbo.KlassRuk.OTCHE, dbo.Klass.ID_Klass, dbo.Klass.BUKVA, dbo.Klass.Number,  dbo.Klass.SPECIALIZACIAYA, dbo.Klass.ID_KLASSRUk, dbo.RODSTVO.ID_RODST, dbo.RODSTVO.Naz, dbo.PROJ_VMESTE.ID_ROD, dbo.PROJ_VMESTE.id_REBENKA AS Expr1, dbo.PROJ_VMESTE.Fam AS Expr2,  dbo.PROJ_VMESTE.Im AS Expr3, dbo.PROJ_VMESTE.Otche AS Expr4, dbo.PROJ_VMESTE.PHONE, dbo.PROJ_VMESTE.DATA_ROJ, dbo.PROJ_VMESTE.MESTO_RAB, dbo.PROJ_VMESTE.MESTO_UCH,  dbo.PROJ_VMESTE.Primech AS Expr5, dbo.PROJ_VMESTE.SEM_POLOJEN, dbo.PROJ_VMESTE.ID_VID_RODSTVA, dbo.UCHA.ID_REBENKA AS Expr6, dbo.UCHA.ImRebenca, dbo.UCHA.OtcheRebenca,  dbo.UCHA.Data_Roj AS Expr7, dbo.UCHA.phone AS Expr8, dbo.UCHA.ID_KLASS AS Expr9, dbo.UCHA.ID_DOM, dbo.UCHA.Kvartira, dbo.NACH_DANN.ID_Улица, dbo.NACH_DANN.INDEX_GOR,  dbo.NACH_DANN.GOROD, dbo.NACH_DANN.ULICA, dbo.DOM.ID_DOM AS Expr10, dbo.DOM.Num_dom, dbo.DOM.ID_NACH_DAN, dbo.Xar_uch.ID_XARAKTERISTIKA, dbo.Xar_uch.ID_OBSLED AS Expr11, dbo.Xar_uch.USPEV, dbo.Xar_uch.ZAN_V_SVOB_VREM, dbo.Xar_uch.NARU_V_POVEDENI, dbo.Xar_uch.sost_zdorov  FROM            dbo.AKT INNER JOIN dbo.KlassRuk INNER JOIN dbo.Klass ON dbo.KlassRuk.ID_Klass_ruck = dbo.Klass.ID_KLASSRUk INNER JOIN dbo.RODSTVO INNER JOIN dbo.PROJ_VMESTE ON dbo.RODSTVO.ID_RODST = dbo.PROJ_VMESTE.ID_VID_RODSTVA INNER JOIN dbo.UCHA ON dbo.PROJ_VMESTE.id_REBENKA = dbo.UCHA.ID_REBENKA ON dbo.Klass.ID_Klass = dbo.UCHA.ID_KLASS INNER JOIN dbo.NACH_DANN INNER JOIN dbo.DOM ON dbo.NACH_DANN.ID_Улица = dbo.DOM.ID_NACH_DAN ON dbo.UCHA.ID_DOM = dbo.DOM.ID_DOM ON dbo.AKT.ID_REBENKA = dbo.UCHA.ID_REBENKA INNER JOIN dbo.Xar_uch ON dbo.AKT.ID_OBSLED = dbo.Xar_uch.ID_OBSLED WHERE KlassRuk.ID_Klass_ruck = " + help.IDKLASS + "  ", con);

                    DataTable DT = new DataTable();
                    sqlDa.Fill(DT);
                    oBSLEDDataGridView.DataSource = DT;

                    con.Close();
                    oBSLEDDataGridView.Columns[0].Visible = false;
                    oBSLEDDataGridView.Columns[1].Visible = false;
                    for (int ii = 16; ii < oBSLEDDataGridView.ColumnCount; ii++)
                    {
                        oBSLEDDataGridView.Columns[ii].Visible = false;
                    }

                    //  textBox6.Text = DT.Rows[0].Field<string>("FamRebenca");
                }
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
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
                this.FindAndReplace(wordApp, "<dateobsled>",  oBSLEDDataGridView.CurrentRow.Cells[2].Value.ToString());
                this.FindAndReplace(wordApp, "<FIOUCH>", oBSLEDDataGridView.CurrentRow.Cells[3].Value.ToString()+" "+ oBSLEDDataGridView.CurrentRow.Cells[42].Value.ToString()+ " "+ oBSLEDDataGridView.CurrentRow.Cells[43].Value.ToString());
                this.FindAndReplace(wordApp, "<dateroj>", oBSLEDDataGridView.CurrentRow.Cells[44].Value.ToString());
                this.FindAndReplace(wordApp, "<adres>", oBSLEDDataGridView.CurrentRow.Cells[50].Value.ToString()+","+ oBSLEDDataGridView.CurrentRow.Cells[51].Value.ToString()+" "+ oBSLEDDataGridView.CurrentRow.Cells[52].Value.ToString()+" д."+ oBSLEDDataGridView.CurrentRow.Cells[54].Value.ToString()+" кв."+ oBSLEDDataGridView.CurrentRow.Cells[48].Value.ToString()+", +"+ oBSLEDDataGridView.CurrentRow.Cells[45].Value.ToString());
                this.FindAndReplace(wordApp, "<projiv>", oBSLEDDataGridView.CurrentRow.Cells[31].Value.ToString()+" "+ oBSLEDDataGridView.CurrentRow.Cells[32].Value.ToString()+" "+ oBSLEDDataGridView.CurrentRow.Cells[33].Value.ToString()+" ,"+ oBSLEDDataGridView.CurrentRow.Cells[35].Value.ToString()+" ,"+ oBSLEDDataGridView.CurrentRow.Cells[34].Value.ToString()+" ,"+ oBSLEDDataGridView.CurrentRow.Cells[36].Value.ToString()+" ,"+ oBSLEDDataGridView.CurrentRow.Cells[37].Value.ToString()+" "+oBSLEDDataGridView.CurrentRow.Cells[38].Value.ToString()+" "+ oBSLEDDataGridView.CurrentRow.Cells[39].Value.ToString()+"(" + oBSLEDDataGridView.CurrentRow.Cells[33].Value.ToString()+" ).");
                this.FindAndReplace(wordApp, "<otvets>", oBSLEDDataGridView.CurrentRow.Cells[4].Value.ToString());
                this.FindAndReplace(wordApp, "<klass>", oBSLEDDataGridView.CurrentRow.Cells[24].Value.ToString()+ " "+ oBSLEDDataGridView.CurrentRow.Cells[23].Value.ToString()+" ("+oBSLEDDataGridView.CurrentRow.Cells[25].Value.ToString()+")");
                this.FindAndReplace(wordApp, "<uspev>", oBSLEDDataGridView.CurrentRow.Cells[58].Value.ToString());
                this.FindAndReplace(wordApp, "<zan>", oBSLEDDataGridView.CurrentRow.Cells[59].Value.ToString());
                this.FindAndReplace(wordApp, "<sostzdor>", oBSLEDDataGridView.CurrentRow.Cells[61].Value.ToString());
                this.FindAndReplace(wordApp, "<poved>", oBSLEDDataGridView.CurrentRow.Cells[60].Value.ToString());
                this.FindAndReplace(wordApp, "<vzaimootn>", oBSLEDDataGridView.CurrentRow.Cells[5].Value.ToString());
                this.FindAndReplace(wordApp, "<viplat>", oBSLEDDataGridView.CurrentRow.Cells[6].Value.ToString());
                this.FindAndReplace(wordApp, "<nanim>", oBSLEDDataGridView.CurrentRow.Cells[7].Value.ToString());
                this.FindAndReplace(wordApp, "<spalmesto>", oBSLEDDataGridView.CurrentRow.Cells[11].Value.ToString());
                this.FindAndReplace(wordApp, "<rabmesto>", oBSLEDDataGridView.CurrentRow.Cells[12].Value.ToString());
                this.FindAndReplace(wordApp, "<kolvo>", oBSLEDDataGridView.CurrentRow.Cells[13].Value.ToString());
                this.FindAndReplace(wordApp, "<plosiudob>", oBSLEDDataGridView.CurrentRow.Cells[10].Value.ToString()+" Площадь жилого помещения"+ oBSLEDDataGridView.CurrentRow.Cells[8].Value.ToString());
                this.FindAndReplace(wordApp, "<matobes>", oBSLEDDataGridView.CurrentRow.Cells[9].Value.ToString());
                this.FindAndReplace(wordApp, "<vivod>","Примечание: " + oBSLEDDataGridView.CurrentRow.Cells[14].Value.ToString() +".  Заключение: "+ oBSLEDDataGridView.CurrentRow.Cells[10].Value.ToString());

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

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаём объект документа
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
