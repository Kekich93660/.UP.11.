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
    public partial class Prod_form : Form
    {
        public Prod_form()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.DataGridViewColumn Col;

        private void button5_Click(object sender, EventArgs e)
        {
            Col = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
                {
                case 0:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn6;
                    break;
            }
            if (radioButton1.Checked)
                makerProdDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                makerProdDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st08DataSet);

        }

        private void productBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st08DataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st08DataSet.makerProd". При необходимости она может быть перемещена или удалена.
            this.makerProdTableAdapter.Fill(this.st08DataSet.makerProd);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st08DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.st08DataSet.Product);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            makerProdBindingSource.Filter = "maker ='" + comboBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            makerProdBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < makerProdDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < makerProdDataGridView.RowCount - 1; j++)
                {
                    makerProdDataGridView[i, j].Style.BackColor = Color.White;
                    makerProdDataGridView[i, j].Style.ForeColor = Color.Black;

                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < makerProdDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < makerProdDataGridView.RowCount - 1; j++)
                {
                    if (makerProdDataGridView[i,j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        makerProdDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        makerProdDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
