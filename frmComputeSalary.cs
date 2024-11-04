using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace;

namespace _08EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // converting string to numerical data types
            double ratePerHour = Convert.ToDouble(tbHourlyRate.Text);
            int hoursWorked = Convert.ToInt32(tbHoursWorked.Text);

            PartTimeEmployee PTE = new PartTimeEmployee(tbFirstName.Text, tbLastName.Text, tbDepartment.Text, tbJobTitle.Text);

            PTE.computeSalary(hoursWorked, ratePerHour);

            lblFirstNameHere.Text = PTE.getFirstName();
            lblLastNameHere.Text = PTE.getLastName();
            lblBasicSalaryHere.Text = PTE.getBasicSalary().ToString("F2");
        }

    }
}
