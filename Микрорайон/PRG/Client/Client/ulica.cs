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
    public partial class ulica : Form
    {
        public ulica()
        {
            InitializeComponent();
        }

       

        private void ulica_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.NACH_DANN". При необходимости она может быть перемещена или удалена.
            this.nACH_DANNTableAdapter.Fill(this.aKTDataSet.NACH_DANN);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Ulica". При необходимости она может быть перемещена или удалена.
     //       this.ulicaTableAdapter.Fill(this.gBUDataSet.Ulica);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.Ulica". При необходимости она может быть перемещена или удалена.
        

        }

      

        private void button1_Click_1(object sender, EventArgs e)
        { try
            {
                this.Validate();
                this.nACHDANNBindingSource.EndEdit();

                this.ulicaBindingSource.EndEdit();
                //    this.ulicaTableAdapter.Update(this.gBUDataSet);
                this.nACH_DANNTableAdapter.Update(this.aKTDataSet);
                panel1.Visible = false;
                this.nACH_DANNTableAdapter.Fill(this.aKTDataSet.NACH_DANN);
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void названиеTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void названиеTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar != 8) && (e.KeyChar != ' ') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
                MessageBox.Show("Некоректный ввод!", "ERROR");
            }
        }

        private void gORODTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' ') )
            {
                e.Handled = true;
                MessageBox.Show("Некоректный ввод!", "ERROR");
            }
        }

        private void ulicaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
