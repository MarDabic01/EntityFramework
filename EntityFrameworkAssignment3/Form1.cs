using EntityFrameworkAssignment3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkAssignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refreshList();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 forma = new Form2(this);
            forma.Show();
        }

        public void refreshList()
        {
            richTextBox1.Text = "";
            using (var ctx = new NORTHWNDContext())
            {
                var rezultat = from x in ctx.Employees select x;
                foreach (var x in rezultat)
                {
                    richTextBox1.Text += "ID:" + x.EmployeeId + " FIRST_NAME:" + x.FirstName + " LAST_NAME:" + x.LastName + " DATE_OF_BIRTH:" + x.BirthDate + "\n\n";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 forma3 = new Form3(this);
            forma3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 forma4 = new Form4(this);
            forma4.Show();
        }
    }
}
