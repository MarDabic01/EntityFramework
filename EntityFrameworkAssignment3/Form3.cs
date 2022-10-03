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
    public partial class Form3 : Form
    {
        Form1 forma1 = new Form1();

        public Form3(Form1 forma1)
        {
            this.forma1 = forma1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text != "")
            {
                label6.Text = "";
                int index = int.Parse(textBox4.Text);
                using (var ctx = new NORTHWNDContext())
                {
                    var x = (from e2 in ctx.Employees where e2.EmployeeId == index select e2).First();
                    if (textBox1.Text != "")
                        x.FirstName = textBox1.Text;
                    if (textBox2.Text != "")
                        x.LastName = textBox2.Text;
                    x.BirthDate = dateTimePicker1.Value;
                    ctx.SaveChanges();
                }
                Close();
                forma1.refreshList();
            }
            else
            {
                label6.Text = "Polje ID mora imati vrijednost";
            }
        }
    }
}
