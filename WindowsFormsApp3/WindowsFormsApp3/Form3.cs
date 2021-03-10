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
    public partial class Nout_form : Form
    {
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        public Nout_form()
        {
            InitializeComponent();
        }

        private void laptopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.laptopBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st08DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st08DataSet.Laptop". При необходимости она может быть перемещена или удалена.
            this.laptopTableAdapter.Fill(this.st08DataSet.Laptop);

        }

        private void ramLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            laptopBindingSource.MoveFirst();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            laptopBindingSource.MovePrevious();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            laptopBindingSource.MoveNext();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            laptopBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            laptopBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            laptopBindingSource.RemoveCurrent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();

            laptopBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.st08DataSet);
        }
    }
}
