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
   
    public partial class Form1 : Form
    {
        private PC_form PC;
        private Nout_form Nout;
        private Print_form Print;
        private Prod1_form Prod1;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prod1 = new Prod1_form();
            Prod1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PC = new PC_form();
            PC.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nout = new Nout_form();
            Nout.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Print = new Print_form();
            Print.Visible = true;
        }
    }
}
