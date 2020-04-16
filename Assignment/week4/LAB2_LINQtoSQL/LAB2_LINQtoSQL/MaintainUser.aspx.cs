using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB2_LINQtoSQL
{
    public partial class MaintainUser : System.Web.UI.Page
    {
        UserInfoDataContext data = new UserInfoDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadData();
            }
        }

        public void LoadData()
        {
            gvUserInforList.DataSource = data.UserInfos;
            gvUserInforList.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            dynamic u = new UserInfo()
            {
                Username = txtUserName.Text,
                Password = txtPassword.Text,
                BirthDate = DateTime.Parse(txtBirthDate.Text),
                Address = txtAddress.Text,
                Email = txtEmail.Text
            };

            data.UserInfos.InsertOnSubmit(u);
            data.SubmitChanges();
            LoadData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UserInfo u = data.UserInfos.SingleOrDefault(us => us.Username.Equals(txtUserName.Text));

            u.Password = txtPassword.Text;
            u.BirthDate = DateTime.Parse(txtBirthDate.Text);
            u.Address = txtAddress.Text;
            u.Email = txtEmail.Text;
            data.SubmitChanges();
            LoadData();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            UserInfo u = data.UserInfos.SingleOrDefault(us => us.Username.Equals(txtUserName.Text));

            data.UserInfos.DeleteOnSubmit(u);
            data.SubmitChanges();
            LoadData();
        }

        protected void gvUserInfoList_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow selectedRow = gvUserInforList.Rows[e.NewSelectedIndex];

            txtUserName.Text = selectedRow.Cells[1].Text;
            txtPassword.Text = selectedRow.Cells[2].Text;
            txtBirthDate.Text = selectedRow.Cells[3].Text;
            txtAddress.Text = selectedRow.Cells[4].Text;
            txtEmail.Text = selectedRow.Cells[5].Text;
        }
    }
}