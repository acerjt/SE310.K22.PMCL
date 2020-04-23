using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWebApp.ServiceReference1;


namespace MyWebApp
{
    public partial class MaintainBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadData();
            }
        }

        public void LoadData()
        {
            ServiceClient bookData = new ServiceClient();
            gvBookList.DataSource = bookData.GetAllBooks();
            gvBookList.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceClient bookData = new ServiceClient();
            int ID = int.Parse(txtBookID.Text);
            string Title = txtBookTitle.Text;
            float Price = float.Parse(txtBookPrice.Text);
            int Quantity= int.Parse(txtBookQuantity.Text);

            Book book = new Book
            {
                BookID = ID,
                BookTitle = Title,
                BookPrice = Price,
                BookQuantity = Quantity
            };

            bookData.AddBook(book);
            LoadData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ServiceClient bookData = new ServiceClient();
            int ID = int.Parse(txtBookID.Text);
            string Title = txtBookTitle.Text;
            float Price = float.Parse(txtBookPrice.Text);
            int Quantity = int.Parse(txtBookQuantity.Text);

            Book book = new Book
            {
                BookID = ID,
                BookTitle = Title,
                BookPrice = Price,
                BookQuantity = Quantity
            };

            bookData.UpdateBook(book);
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ServiceClient bookData = new ServiceClient();
            int ID = int.Parse(txtBookID.Text);
           
            Book book = new Book
            {
                BookID = ID
            };

            bookData.DeleteBook(book);
            LoadData();
        }

        protected void gvBookList_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = gvBookList.Rows[e.NewSelectedIndex];

            txtBookID.Text = row.Cells[1].Text;
            txtBookTitle.Text = row.Cells[4].Text;
            txtBookPrice.Text = row.Cells[2].Text;
            txtBookQuantity.Text = row.Cells[3].Text;
        }
    }
}