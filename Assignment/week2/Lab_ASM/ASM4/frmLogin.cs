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
    public partial class frmLogin : Form
    {
        private LoginDB loginDB = new LoginDB();
        private Employee employee = new Employee();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            employee.ID = txtEmpID.Text;
            employee.Password = txtEmpPassword.Text;
            bool result = loginDB.Login(ref employee);

            if(!result)
            {
                MessageBox.Show("ID and Password is not correct");
                return;
            }

         
            if(employee != null)
            {
                if(!employee.Role)
                {
                    frmChangePassword frmChangePassword = new frmChangePassword(employee);
                    this.Hide();
                    frmChangePassword.ShowDialog();
                    
                }
                else
                {
                    frmMaintain frmMaintain = new frmMaintain();
                    this.Hide();
                    frmMaintain.ShowDialog();
                }
            }

            this.Show();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registry registry = new Registry();
            registry.ShowDialog();
        }
    }
}
