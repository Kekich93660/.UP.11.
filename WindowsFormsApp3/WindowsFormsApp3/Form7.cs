using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Prod1_form : Form
    {
        private Prod_form Prod;
        public Prod1_form()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st08DataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st08DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.st08DataSet.Product);

        }

        private void modelLabel_Click(object sender, EventArgs e)
        {

        }

        private void modelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Prod = new Prod_form();
            Prod.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveFirst();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productBindingSource.MovePrevious();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveNext();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productBindingSource.RemoveCurrent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();

            productBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.st08DataSet);
        }
    }
}
