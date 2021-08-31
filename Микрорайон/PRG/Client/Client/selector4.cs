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
    public partial class selector4 : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("ServerConnectionString"));

        public selector4(string table)
        {
            InitializeComponent();
            string query = "SELECT * From " + table;
            SqlCommand SqlCom = new SqlCommand(query, con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(SqlCom);
            DataTable DT = new DataTable();
            sqlDa.Fill(DT);
            dataGridView1.DataSource = DT;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void selector4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.DOM". При необходимости она может быть перемещена или удалена.
//            this.dOMTableAdapter.Fill(this.gBUDataSet.DOM);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            help.id4 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            this.Close();
        }
    }
}
