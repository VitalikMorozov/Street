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
    
    public partial class selectorreb : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));
        public selectorreb(String table)
        {
            InitializeComponent();
            string query = "SELECT * From dbo.UCHA INNER JOIN dbo.Klass ON dbo.UCHA.ID_KLASS = dbo.Klass.ID_Klass INNER JOIN dbo.KlassRuk ON dbo.Klass.ID_KLASSRUk = dbo.KlassRuk.ID_Klass_ruck  where ID_Klass_ruck = " + help.IDKLASS + " ";
            SqlCommand SqlCom = new SqlCommand(query, con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
            DataTable DT = new DataTable();
            sqlDa.Fill(DT);
            dataGridView1.DataSource = DT;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
       


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            help.id5 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            help.id5 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            this.Close();
        }
    }
}
