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
    public partial class frmMaintain : Form
    {
        BookData bookData = new BookData();

        DataTable dataTableBook;
        public frmMaintain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = 1;
            if (dataTableBook.Rows.Count > 0)
            {
                ID = int.Parse(dataTableBook.Compute("MAX(BookID)", "").ToString()) + 1;
            }

            txtBookID.Text = ID.ToString();


            string Name = txtBookName.Text;
            float Price = float.Parse(txtUnitPrice.Text);


            Book book = new Book
            {
                BookID = ID,
                BookName = Name,
                BookPrice = Price,
            };

           bool result = bookData.addNewBook(book);

            if (result)
            {
                MessageBox.Show("Add book successful");
                LoadData();
            }
            else
                MessageBox.Show("Add book fail");
        }

        private void LoadData()
        {
            dataTableBook = bookData.GettProducts();

            dataTableBook.PrimaryKey = new DataColumn[]
            {
                dataTableBook.Columns["BookID"]
            };
           
            bsBooks.DataSource = dataTableBook;

            txtBookID.DataBindings.Clear();
            txtBookName.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();

            txtBookID.DataBindings.Add("Text", bsBooks, "BookID");
            txtBookName.DataBindings.Add("Text", bsBooks, "BookName");
            txtUnitPrice.DataBindings.Add("Text", bsBooks, "BookPrice");


            dgvBookList.DataSource = bsBooks;
            bsBooks.Sort = "BookID DESC";


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtBookID.Text);
            string Name = txtBookName.Text;
            float Price = float.Parse(txtUnitPrice.Text);

            Book book = new Book
            {
                BookID = ID,
                BookName = Name,
                BookPrice = Price,
            };

            bool result = bookData.updateBook(book);
            if (result)
            {
                DataRow row = dataTableBook.Rows.Find(book.BookID);
                row["BookName"] = book.BookName;
                row["BookPrice"] = book.BookPrice;
                MessageBox.Show("Update successful");
                LoadData();
            }
            else
                MessageBox.Show("Update fail");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtBookID.Text);
            if (bookData.deleteBook(ID))
            {
                DataRow dataRow = dataTableBook.Rows.Find(ID);
                dataTableBook.Rows.Remove(dataRow);
                MessageBox.Show("Successful.");
            }
            else
                MessageBox.Show("Fail");
        }


        private void btnReport_Click(object sender, EventArgs e)
        {
            frmBookReport frmBookReport = new frmBookReport();
            frmBookReport.Show();
        }

        private void txtTitleEnter_TextChanged(object sender, EventArgs e)
        {
            string filter = "BookName like '%" + txtTitleEnter.Text + "%'";
            dataTableBook.DefaultView.RowFilter = filter;
            lblTotalQuantity.Text = "TotalQuantity: " + dataTableBook.Compute("SUM(BookPrice)", filter);
        }

        private void frmMaintain_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
