using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM4
{
    public partial class Registry : Form
    {
        LoginDB loginDB = new LoginDB();
        public Registry()
        {
            InitializeComponent();
        }

        private void Registry_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistry_Click(object sender, EventArgs e)
        {

            if (txtPass.Text == string.Empty || txtRetypePass.Text == string.Empty)
            {
                MessageBox.Show("Field must be fill");
                return;
            }
            else if (txtPass.Text != txtRetypePass.Text)
            {
                MessageBox.Show("Password and Retype not the same");
                return;
            }
            Employee employee = new Employee();
            employee.ID = txtEmpID.Text;
            employee.Password= txtPass.Text;
            employee.Role = true;

            bool result = loginDB.Registry(employee);

            if (result)
            {
                MessageBox.Show("Registry successful");
            }
            else
                MessageBox.Show("Registry fail");

        }
    }
}
