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
    public partial class selector2 : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));
        public selector2(string table)
        {
            InitializeComponent();
            string query = "SELECT   ID_Klass_ruck, Login, password,KlassRuk.FAM+ ' ' + KlassRuk.IM +' '+KlassRuk.OTCHE as ФИО  FROM " + table;
            SqlCommand SqlCom = new SqlCommand(query, con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
            DataTable DT = new DataTable();
            sqlDa.Fill(DT);
            dataGridView1.DataSource = DT;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            help.id2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            this.Close();
        }
    }
}
