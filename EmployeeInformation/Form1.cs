using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public partial class EmployInformation : Form
    {
        public EmployInformation()
        {
            InitializeComponent();
        }
        Employee aEmployee=new Employee();
        private void showButton_Click(object sender, EventArgs e)
        {
            aEmployee.id = idTextBox.Text;
            aEmployee.name = nameTextBox.Text;
            aEmployee.salary = salaryTextBox.Text;
            MessageBox.Show("Employee Information." + "\nID:" + aEmployee.id + "\nName:" + aEmployee.name + "\nSalary:" +aEmployee.salary);
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";

        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = aEmployee.id;
            nameTextBox.Text = aEmployee.name;
            salaryTextBox.Text = aEmployee.salary;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
            aEmployee.id = aEmployee.name = aEmployee.salary = null;
        }
    }
}
