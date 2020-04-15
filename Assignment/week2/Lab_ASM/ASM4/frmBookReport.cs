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
    public partial class frmBookReport : Form
    {
        DataTable dataTableBook = new DataTable();
        BookData bookData = new BookData();
        public frmBookReport()
        {
            InitializeComponent();
        }

        private void frmBookReport_Load(object sender, EventArgs e)
        {
            dataTableBook = bookData.GettProducts();

            dataTableBook.PrimaryKey = new DataColumn[]
            {
                dataTableBook.Columns["BookID"]
            };

            bsBook.DataSource = dataTableBook;

            dgvListBook.DataSource = bsBook;
            bsBook.Sort = "BookPrice DESC";
        }
    }
}
