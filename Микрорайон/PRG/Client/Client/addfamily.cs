using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Микрорайон
{
    public partial class addfamily : Form
    {
        public addfamily()
        {
            InitializeComponent();
        }

        private void roditeliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.roditeliBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.mikroraenDataSet);

        }

        private void addfamily_Load(object sender, EventArgs e)
        {
            //  а это настройка для автофильтра значений по первым вводимым символам
            //comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Deti". При необходимости она может быть перемещена или удалена.
            //this.detiTableAdapter.Fill(this.mikroraenDataSet.Deti);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Ulica". При необходимости она может быть перемещена или удалена.
            //this.ulicaTableAdapter.Fill(this.mikroraenDataSet.Ulica);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.Roditeli". При необходимости она может быть перемещена или удалена.
            //this.roditeliTableAdapter.Fill(this.mikroraenDataSet.Roditeli);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            MenuVert.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                this.Validate();
            //    this.roditeliTableAdapter.en EndEdit();
                //this.roditeliTableAdapter.Update(this.mikroraenDataSet.Roditeli);
                //MessageBox.Show("Сохранение успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение неуспешно" + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kod_UlTextBox.Text = comboBox1.SelectedValue.ToString();
        }

        private void famOtcaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Ввод только русских букв!", "ERROR");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string al = comboBox2.SelectedValue.ToString();

               
                roditeliBindingSource.Filter = "Kod_Ul = \'" + Convert.ToInt32(al) + "\'";
            
        }
    }
}
