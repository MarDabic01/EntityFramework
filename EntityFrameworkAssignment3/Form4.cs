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
    public partial class Form4 : Form
    {
        Form1 forma1 = new Form1();

        public Form4(Form1 forma1)
        {
            this.forma1 = forma1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                label3.Text = "";
                int index = int.Parse(textBox1.Text);
                using (var ctx = new NORTHWNDContext())
                {
                    var x = (from e3 in ctx.Employees where e3.EmployeeId == index select e3).Single();
                    ctx.Employees.Remove(x);
                    ctx.SaveChanges();
                }
                Close();
                forma1.refreshList();
            }
            else
            {
                label3.Text = "Polje ID mora imati vrijednost";
            }
        }
    }
}
