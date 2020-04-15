using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore
{
    public partial class frmProductDetails : Form
    {
        private bool addOrEdit;

        public Products ProducAddOrEdit { get; set; }

        public frmProductDetails()
        {
            InitializeComponent();
        }

        public frmProductDetails(bool flags, Products products):this()
        {
            addOrEdit = flags;
            ProducAddOrEdit = products;
            InitData();
        }

        private void InitData()
        {
            txtProductID.Text = ProducAddOrEdit.ProductID.ToString();
            txtProductName.Text = ProducAddOrEdit.ProductName.ToString();
            txtProductPrice.Text = ProducAddOrEdit.UnitPrice.ToString();
            txtProductQuantity.Text = ProducAddOrEdit.Quantity.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag;

            ProducAddOrEdit.ProductID = int.Parse(txtProductID.Text);
            ProducAddOrEdit.ProductName = txtProductName.Text;
            ProducAddOrEdit.UnitPrice= double.Parse(txtProductPrice.Text);
            ProducAddOrEdit.Quantity = int.Parse(txtProductQuantity.Text);

            ProductData productData = new ProductData();

            if(addOrEdit == true)
            {
                flag = productData.AddProduct(ProducAddOrEdit);
            }
            else
            {
                flag = productData.UpdateProduct(ProducAddOrEdit);
            }

            if (flag == true)
                MessageBox.Show("Save Successful.");
            else
                MessageBox.Show("Save Fail.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
