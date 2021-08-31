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
    public partial class selector3 : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));
        public selector3(string table)
        {
            InitializeComponent();
            string query = "SELECT     ID_Klass, Number AS Номер, BUKVA AS Буква, SPECIALIZACIAYA AS Специализация, ID_KLASSRUk  FROM " + table;
            SqlCommand SqlCom = new SqlCommand(query, con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
            DataTable DT = new DataTable();
            sqlDa.Fill(DT);
            dataGridView1.DataSource = DT;
            dataGridView1.Columns[0].Visible = false;
           
            dataGridView1.Columns[4].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void button4_Click(object sender, EventArgs e)
        {
       this.DialogResult = DialogResult.OK;
            help.id3 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            this.Close();
        }
    }
}
