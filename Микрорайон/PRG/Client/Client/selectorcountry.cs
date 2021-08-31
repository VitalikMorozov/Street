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
    public partial class selectorcountry : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));

        public selectorcountry(string table)
        {
            InitializeComponent();
            string query = "SELECT        dbo.AKT.ID_OBSLED, dbo.AKT.Data_obsled AS [Дата обследования], dbo.AKT.ID_REBENKA, dbo.AKT.OTVET_za_VOSPIT, dbo.AKT.VZAIMO_OT, dbo.AKT.vuplat, dbo.AKT.VLADEL_ZILAYA, dbo.AKT.PLOSH_POMECH, dbo.AKT.OBESPECH, dbo.AKT.BUT_UDOB, dbo.AKT.NAL_SPAL_MESTA, dbo.AKT.NAL_RAB_MESTA, dbo.AKT.KOLVO_V_KOMNATE, dbo.AKT.PRIMECH, dbo.AKT.ZAK, dbo.KlassRuk.ID_Klass_ruck, dbo.KlassRuk.Login, dbo.KlassRuk.password, dbo.KlassRuk.FAM, dbo.KlassRuk.IM, dbo.KlassRuk.OTCHE, dbo.UCHA.ID_REBENKA AS Expr1, dbo.UCHA.FamRebenca AS Фамилия, dbo.UCHA.ImRebenca AS Имя, dbo.UCHA.OtcheRebenca AS Отчество, dbo.UCHA.Data_Roj, dbo.UCHA.phone, dbo.UCHA.ID_KLASS, dbo.UCHA.ID_DOM, dbo.UCHA.Kvartira, dbo.Klass.ID_Klass AS Expr2, dbo.Klass.BUKVA, dbo.Klass.Number, dbo.Klass.SPECIALIZACIAYA, dbo.Klass.ID_KLASSRUk  FROM dbo.AKT INNER JOIN dbo.UCHA ON dbo.AKT.ID_REBENKA = dbo.UCHA.ID_REBENKA INNER JOIN dbo.Klass ON dbo.UCHA.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.KlassRuk ON dbo.Klass.ID_KLASSRUk = dbo.KlassRuk.ID_Klass_ruck where ID_Klass_ruck = " + help.IDKLASS + " ";
            SqlCommand SqlCom = new SqlCommand(query, con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
            DataTable DT = new DataTable();
            sqlDa.Fill(DT);
            dataGridView1.DataSource = DT;
  //          dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            help.id7 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            help.idREBOBSLED = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            help.id7 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            help.idREBOBSLED = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            this.Close();
        }
    }
}
