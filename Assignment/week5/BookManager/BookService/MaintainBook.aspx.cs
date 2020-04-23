using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BookService
{
    public partial class MaintainBook : System.Web.UI.Page
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
            BookService bookService = new BookService();
            DataSet bookList = bookService.GetBookList();
            gvBookList.DataSource = bookList.Tables[0];
            gvBookList.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            int BookID = int.Parse(txtBookID.Text);
            string BookTitle = txtBookTitle.Text;
            float BookPrice = float.Parse(txtBookPrice.Text);
            int BookQuantity = int.Parse(txtBookQuantity.Text);
            bookService.AddBook(BookID, BookTitle, BookPrice, BookQuantity);
            LoadData();
        
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            int BookID = int.Parse(txtBookID.Text);
            string BookTitle = txtBookTitle.Text;
            float BookPrice = float.Parse(txtBookPrice.Text);
            int BookQuantity = int.Parse(txtBookQuantity.Text);
            bookService.UpdateBook(BookID, BookTitle, BookPrice, BookQuantity);
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            int BookID = int.Parse(txtBookID.Text);
            bookService.DeleteBook(BookID);
            LoadData();
        }

        protected void gvBookList_SelectedIndexChanging (object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = gvBookList.Rows[e.NewSelectedIndex];

            txtBookID.Text = row.Cells[1].Text;
            txtBookTitle.Text = row.Cells[2].Text;
            txtBookPrice.Text = row.Cells[3].Text;
            txtBookQuantity.Text = row.Cells[4].Text;
        }
    }
}