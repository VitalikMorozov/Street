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
namespace Микрорайон
{
    public partial class firstformdata : Form
    {
        public string ConnectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog = Mikroraen; Integrated Security = True";

        public firstformdata()
        {
            InitializeComponent();
            string query = "SELECT COUNT(Kod_Semi) as 'Count'      FROM Deti WHERE Kod_Shool IS NOT NULL ";
            SqlConnection SqlCon = new SqlConnection(ConnectionString);
            SqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, SqlCon);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
            DataTable TB = new DataTable();
            DataAdapter.Fill(TB);
            SqlCon.Close();
            TB.Rows[0].Field<int>("Count");
            label5.Text = TB.Rows[0].Field<int>("Count").ToString();


            string query1 = "SELECT COUNT(Kod_Semi) as 'Count'      FROM Deti WHERE Kod_DetSad IS NOT NULL ";
            SqlConnection SqlCon1 = new SqlConnection(ConnectionString);
            SqlCon1.Open();
            SqlCommand cmd1 = new SqlCommand(query1, SqlCon1);
            SqlDataAdapter DataAdapter1 = new SqlDataAdapter(cmd1);
            DataTable TB1 = new DataTable();
            DataAdapter1.Fill(TB1);
            SqlCon1.Close();
            TB1.Rows[0].Field<int>("Count");
            label3.Text = TB1.Rows[0].Field<int>("Count").ToString();

            string querySSYZ = "SELECT COUNT(Kod_Semi) as 'Count'      FROM Deti WHERE Kod_SSYZ IS NOT NULL ";
            SqlConnection SqlConSSYZ = new SqlConnection(ConnectionString);
            SqlConSSYZ.Open();
            SqlCommand cmdSSYZ = new SqlCommand(querySSYZ, SqlConSSYZ);
            SqlDataAdapter DataAdapterSSYZ = new SqlDataAdapter(cmdSSYZ);
            DataTable TBSSYZ = new DataTable();
            DataAdapterSSYZ.Fill(TBSSYZ);
            SqlConSSYZ.Close();
            TBSSYZ.Rows[0].Field<int>("Count");
            label7.Text = TBSSYZ.Rows[0].Field<int>("Count").ToString();

        }

        private void firstformdata_Load(object sender, EventArgs e)
        {
           

            // TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Deti". При необходимости она может быть перемещена или удалена.
 //           this.detiTableAdapter.Fill(this.mikroraenDataSet.Deti);
 //           label2.Text = Convert.ToString(dataGridView1.DisplayedRowCount(true)); //dataGridView1.RowCount.ToString();
 //           dataGridView1.Visible = false;
 ////int k=0,p=0,kl=0;
 //           for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
 //           {
 //               //   for (int j = 0; j < dataGridView1.RowCount; j++)
 //               //  {

 //               //if ((dataGridView1.Rows[i].Cells[5].Value != null ) || (Convert.ToString (dataGridView1.Rows[i].Cells[5].Value) != "") || (Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) != 0) && (dataGridView1.Rows[i].Cells[8].Value == null) || (Convert.ToString(dataGridView1.Rows[i].Cells[8].Value) == "") || (Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value) == 0) && (dataGridView1.Rows[i].Cells[6].Value == null) || (Convert.ToString(dataGridView1.Rows[i].Cells[6].Value) == "") || (Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value) == 0))
 //               // {
 //               //    k++;
 //               // }
 //               //if( (dataGridView1.Rows[i].Cells[5].Value == null)|| (dataGridView1.Rows[i].Cells[5].Value.ToString() == "") && (dataGridView1.Rows[i].Cells[8].Value == null) || (dataGridView1.Rows[i].Cells[8].Value.ToString() == "") && (dataGridView1.Rows[i].Cells[6].Value  != null ))
 //               //{
 //               //    p++;
 //               //}
 //               if (dataGridView1.Rows[i].Cells[5] != null)
 //               {
 //                   k++;
 //               }
 //           }
 //           for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
 //           {
 //               if (dataGridView1.Rows[i].Cells[6]!=null)
 //               {
 //                   p++;
 //               }
 //                   if ( (dataGridView1.Rows[i].Cells[5].Value == null) && (dataGridView1.Rows[i].Cells[8].Value != null) && (dataGridView1.Rows[i].Cells[6].Value == null))
 //                   {
 //                       kl++;
 //                   }
 //           //    }
 //           }
 //           label3.Text =Convert.ToString(k) ;
 //           label5.Text = Convert.ToString(p);
 //           label7.Text = Convert.ToString(kl);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
