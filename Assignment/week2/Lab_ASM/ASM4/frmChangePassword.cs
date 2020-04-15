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
    public partial class frmChangePassword : Form
    {
        Employee emp = new Employee();
        LoginDB LoginDB = new LoginDB();
        public frmChangePassword()
        {
            InitializeComponent();
        }

        public frmChangePassword(Employee employee)
        {
            InitializeComponent();
            emp = employee;
            txtEmpID.Text = emp.ID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text == string.Empty ||  txtRetypePass.Text == string.Empty)
            {
                MessageBox.Show("Field must be fill");
                return;
            }
            else if(txtNewPass.Text != txtRetypePass.Text)
            {
                MessageBox.Show("Password and Retype not the same");
                return;
            }
            emp.Role = true;
            emp.Password = txtNewPass.Text;
            bool result = LoginDB.ChangePass(ref emp);
            if (result)
            {
                MessageBox.Show("Change Password successful.");
            }
            else
                MessageBox.Show("Change Password fail.");
        }
    }
}
