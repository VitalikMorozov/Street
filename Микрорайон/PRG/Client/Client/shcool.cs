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
    public partial class shcool : Form
    {
        public shcool()
        {
            InitializeComponent();
        }

        private void shcool_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.RODSTVO". При необходимости она может быть перемещена или удалена.
            this.rODSTVOTableAdapter1.Fill(this.aKTDataSet.RODSTVO);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.RODSTVO". При необходимости она может быть перемещена или удалена.
            //    this.rODSTVOTableAdapter.Fill(this.gBUDataSet.RODSTVO);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.School". При необходимости она может быть перемещена или удалена.

        }


        private void button1_Click_1(object sender, EventArgs e)
        { try {
                this.Validate();
                this.rODSTVOBindingSource1.EndEdit();
                this.rODSTVOTableAdapter1.Update(this.aKTDataSet);
                panel1.Visible = false;
            
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

        private void nazTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' ') )
            {
                e.Handled = true;
                MessageBox.Show("Некоректный ввод!", "ERROR");
            }
        }
    }
}
