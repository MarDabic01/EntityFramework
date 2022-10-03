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
    public partial class Form2 : Form
    {
        Form1 forma1 = new Form1();

        public Form2(Form1 forma1)
        {
            this.forma1 = forma1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new NORTHWNDContext())
            {
                Employee emp = new Employee
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    BirthDate = dateTimePicker1.Value
                };
                ctx.Employees.Add(emp);
                ctx.SaveChanges();
            }
            forma1.refreshList();
            Close();
        }
    }
}
