using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmMaintainBook : Form
    {
        BookData bookData = new BookData();
        DataTable dataBook;


        public frmMaintainBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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

            bool r = bookData.addNewBook(book);
            string s = (r == true ? "successful" : "fail");
            MessageBox.Show("Add " + s);

            getAllBooks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtBookID.Text);
            string Title = txtBookTitle.Text;
            float Price = float.Parse(txtBookPrice.Text);
            int Quantity = int.Parse(txtBookQuantity.Text);

            Book book = new Book {
                BookID = ID,
                BookTitle = Title,
                BookPrice = Price,
                BookQuantity = Quantity
            };

            bool r = bookData.updateBook(book);
            string s = (r==true?"succeccful" : "fail");
            MessageBox.Show("Update " + s);
            getAllBooks();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtBookID.Text);

            bool r = bookData.deleteBook(ID);
            string s = (r == true ? "successful" : "fail");
            MessageBox.Show("Delete " + s);

            getAllBooks();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            getAllBooks();
        }

        private void getAllBooks()
        {
            dataBook = bookData.getBooks();
            txtBookID.DataBindings.Clear();
            txtBookTitle.DataBindings.Clear();
            txtBookPrice.DataBindings.Clear();
            txtBookQuantity.DataBindings.Clear();

            txtBookID.DataBindings.Add("Text", dataBook, "BookID");
            txtBookTitle.DataBindings.Add("Text", dataBook, "BookTitle");
            txtBookPrice.DataBindings.Add("Text", dataBook, "BookPrice");
            txtBookQuantity.DataBindings.Add("Text", dataBook, "BookQuantity");

            dgvBookList.DataSource = dataBook;
            lblTotalQuantity.Text = "TotalQuantity: " + dataBook.Compute("SUM(BookQuantity)", string.Empty);

        }

        private void txtTitleEnter_TextChanged(object sender, EventArgs e)
        {
            string filter = "BookTitle like '%" + txtTitleEnter.Text + "%'";
            dataBook.DefaultView.RowFilter = filter;
            lblTotalQuantity.Text = "TotalQuantity: " + dataBook.Compute("SUM(BookQuantity)", filter);
        }

        private void frmMaintainBook_Load(object sender, EventArgs e)
        {

        }
    }
}
