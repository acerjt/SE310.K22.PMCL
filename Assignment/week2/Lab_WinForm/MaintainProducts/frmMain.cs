using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintainProducts
{
    public partial class frmMain : Form
    {
        ProductData data = new ProductData();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                int ProID = int.Parse(txtProductID.Text);
                string ProName = txtProductName.Text;
                float Price = float.Parse(txtUnitPrice.Text);
                int Quantity = int.Parse(txtQuantity.Text);

                Product product = new Product
                {
                    ProductID = ProID,
                    ProductName = ProName,
                    UnitPrice = Price,
                    Quantity = Quantity
                };
                data.AddNew(product);
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = data.GetProductList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int ProID = int.Parse(txtProductID.Text);
               

              
                data.Remove(ProID);
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = data.GetProductList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            int ProID = int.Parse(txtProductID.Text);
            Product product = data.Find(ProID);

            if (product == null)
                MessageBox.Show("Product not found");
            else
            {
                txtProductName.Text = product.ProductName;
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtQuantity.Text = product.Quantity.ToString();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }
    }
}
