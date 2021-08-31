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
    public partial class ssyz : Form
    {
        public ssyz()
        {
            InitializeComponent();
        }

        private void ssyz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKTDataSet.KlassRuk". При необходимости она может быть перемещена или удалена.
            this.klassRukTableAdapter1.Fill(this.aKTDataSet.KlassRuk);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gBUDataSet.KlassRuk". При необходимости она может быть перемещена или удалена.
    //        this.klassRukTableAdapter.Fill(this.gBUDataSet.KlassRuk);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mikroraenDataSet.SSYZ". При необходимости она может быть перемещена или удалена.
         //   this.sSYZTableAdapter.Fill(this.mikroraenDataSet.SSYZ);

        }

        private void ulLabel_Click(object sender, EventArgs e)
        {

        }

        private void MenuVert_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.klassRukBindingSource1.EndEdit();
                //        this.klassRukBindingSource.EndEdit();
                this.klassRukTableAdapter1.Update(this.aKTDataSet);
                panel1.Visible = false;
            }
            catch
            {
                MessageBox.Show("Не верный ввод данных", "ERROR");
            }
            //    this.tableAdapterManager.UpdateAll(this.gBUDataSet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            
        }

        private void fIOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fIOTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void fIOTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' ') )
            {
                e.Handled = true;
                MessageBox.Show("неверный ввод данных!", "ERROR");
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != ' ') && (e.KeyChar < 'A' || e.KeyChar > 'z') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
                MessageBox.Show("неверный ввод данных!", "ERROR");
            }
        }
    }
}
