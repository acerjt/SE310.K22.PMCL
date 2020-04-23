using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookService.localhost;


namespace BookService
{
    public partial class MaintainBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        public void LoadData()
        {
            BookService bookData = new BookService();
            gvBookList.DataSource = bookData.GetBookList();
            gvBookList.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            BookService bookData = new BookService();
            int ID = int.Parse(txtBookID.Text);
            string Title = txtBookTitle.Text;
            double Price = double.Parse(txtBookPrice.Text);
            int Quantity = int.Parse(txtBookQuantity.Text);

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
            BookService bookData = new BookService();
            int ID = int.Parse(txtBookID.Text);
            string Title = txtBookTitle.Text;
            double Price = double.Parse(txtBookPrice.Text);
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
            BookService bookData = new BookService();
            int ID = int.Parse(txtBookID.Text);
            Book book = new Book { BookID = ID };
            bookData.DeleteBook(book);
            LoadData();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BookService bookData = new BookService();
            int ID = int.Parse(txtBookID.Text);
            Book book = new Book
            {
                BookID = ID
            };
            var result = bookData.SearchBook(book);
            gvBookList.DataSource = result;
            gvBookList.DataBind();
        }

        protected void gvBookList_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = gvBookList.Rows[e.NewSelectedIndex];
            txtBookID.Text = row.Cells[1].Text;
            txtBookTitle.Text = row.Cells[2].Text;
            txtBookPrice.Text = row.Cells[3].Text;
            txtBookQuantity.Text = row.Cells[4].Text;
        }
    }
}