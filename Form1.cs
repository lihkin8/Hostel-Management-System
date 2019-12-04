using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new available().Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            new supervisor().Show();
            this.Hide();
        }
    }
}
