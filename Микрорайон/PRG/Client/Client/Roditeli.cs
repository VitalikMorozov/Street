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
    public partial class Roditeli : Form
    {
        public string ConnectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog = Mikroraen; Integrated Security = True";

        public Roditeli(int id)
        {

        InitializeComponent();
            string query = "Select Roditeli.Kod_semi,FamOtca, ImOtca, OtcheOtca, FamMater, ImMater, OtcheMater,Ul,  Kod_Ulica,Dom, Korpus,       Kvartira,       Propisca,       Primechanie FROM Roditeli, Deti, Ulica Where Roditeli.Kod_semi = Deti.Kod_semi AND Ulica.Kod_Ulica=Roditeli.Kod_Ul  AND Deti.Kod_semi = " + id;
            SqlConnection SqlCon = new SqlConnection(ConnectionString);
            SqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, SqlCon);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
            DataTable TB = new DataTable();
            DataAdapter.Fill(TB);
            SqlCon.Close();
            TB.Rows[0].Field<int>("Kod_semi");
            TB.Rows[0].Field<string>("FamOtca");
            TB.Rows[0].Field<string>("ImOtca");
            TB.Rows[0].Field<string>("OtcheOtca");
            TB.Rows[0].Field<string>("FamMater");
            TB.Rows[0].Field<string>("ImMater");
            TB.Rows[0].Field<string>("OtcheMater");
            TB.Rows[0].Field<string>("Ul");
            TB.Rows[0].Field<int>("Dom");
            TB.Rows[0].Field<string>("Korpus");
            TB.Rows[0].Field<int>("Kvartira");
            TB.Rows[0].Field<bool>("Propisca");
            TB.Rows[0].Field<string>("Primechanie");

            if (TB.Rows[0].Field<string>("FamOtca") == null && TB.Rows[0].Field<string>("ImOtca") == null && TB.Rows[0].Field<string>("OtcheOtca") == null)
            {
                labelfamotca.Text ="";
                labelimotca.Text = "";
                labelotcheotca.Text = "";

            }
            else
             {

                     labelfamotca.Text = TB.Rows[0].Field<string>("FamOtca").ToString();
                       labelimotca.Text = TB.Rows[0].Field<string>("ImOtca").ToString();
                      labelotcheotca.Text = TB.Rows[0].Field<string>("OtcheOtca").ToString();

            }
            if (TB.Rows[0].Field<string>("FamMater") == null && TB.Rows[0].Field<string>("ImMater") == null && TB.Rows[0].Field<string>("OtcheMater") == null)
            {
                labelfammater.Text = "";
                labelimmater.Text = "";
                labelotchemater.Text = "";
            }
            else
            {
                labelfammater.Text = TB.Rows[0].Field<string>("FamMater").ToString();
                labelimmater.Text = TB.Rows[0].Field<string>("ImMater").ToString();
                labelotchemater.Text = TB.Rows[0].Field<string>("OtcheMater").ToString();
            }
              

            labelUl.Text = TB.Rows[0].Field<string>("Ul").ToString();
            labeldom.Text = TB.Rows[0].Field<int>("Dom").ToString();
            labelkv.Text = TB.Rows[0].Field<int>("Kvartira").ToString();
            if (TB.Rows[0].Field<string>("Korpus") == null)
            {
                labelkor.Text = "";
            }
            else
            {
                labelkor.Text = TB.Rows[0].Field<string>("Korpus").ToString();
            }
                labelpropis.Text = TB.Rows[0].Field<bool>("Propisca").ToString();

            if (TB.Rows[0].Field<string>("Primechanie") == null)
            {
                labelprimech.Text = "";
            }
            else
            {
                labelprimech.Text = TB.Rows[0].Field<string>("Primechanie").ToString();
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {
           
           this.Hide();
        }
    }
}
