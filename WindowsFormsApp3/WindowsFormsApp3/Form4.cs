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
    public partial class Print_form : Form
    {
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        public Print_form()
        {
            InitializeComponent();
        }

        private void printerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st08DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st08DataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.st08DataSet.Printer);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void typeLabel_Click(object sender, EventArgs e)
        {

        }

        private void codeLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printerBindingSource.MoveFirst();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printerBindingSource.MovePrevious();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            printerBindingSource.MoveNext();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            printerBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printerBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printerBindingSource.RemoveCurrent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();

            printerBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.st08DataSet);
        }
    }
}
