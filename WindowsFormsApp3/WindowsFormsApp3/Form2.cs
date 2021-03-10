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
    public partial class PC_form : Form
    {
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        public PC_form()
        {
            InitializeComponent();
        }

        private void pCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st08DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st08DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.st08DataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st08DataSet.Laptop". При необходимости она может быть перемещена или удалена.
            this.laptopTableAdapter.Fill(this.st08DataSet.Laptop);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st08DataSet.PC". При необходимости она может быть перемещена или удалена.
            this.pCTableAdapter.Fill(this.st08DataSet.PC);

        }

        private void speedLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pCBindingSource.MoveFirst();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pCBindingSource.MovePrevious();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pCBindingSource.MoveNext();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pCBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pCBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pCBindingSource.RemoveCurrent();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            
            pCBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.st08DataSet);
        }

        private void codeLabel_Click(object sender, EventArgs e)
        {

        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
