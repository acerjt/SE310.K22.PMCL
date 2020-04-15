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
    public partial class Form1 : Form
    {
        ProductData productData = new ProductData();

        DataTable dataTableProduct;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = 1;
            if (dataTableProduct.Rows.Count > 0)
            {
                ID = int.Parse(dataTableProduct.Compute("MAX(BookID)", "").ToString()) + 1;
            }

            txtProductID.Text = ID.ToString();
            
            
            string Name = txtProductName.Text;
            double Price = double.Parse(txtUnitPrice.Text);
            int productQuantity = int.Parse(txtQuantity.Text);


            Products products = new Products
            {
                ProductID = ID,
                ProductName = Name,
                UnitPrice = Price,
                Quantity = productQuantity
            };

            frmProductDetails frmProductDetails = new frmProductDetails(true, products);

            DialogResult r = frmProductDetails.ShowDialog();

            if (r == DialogResult.OK)
            {
                products = frmProductDetails.ProducAddOrEdit;

                dataTableProduct.Rows.Add(products.ProductID, products.ProductName, products.UnitPrice, products.Quantity);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtProductID.Text);
            string Name = txtProductName.Text;
            double Price = float.Parse(txtUnitPrice.Text);
            int productQuantity = int.Parse(txtQuantity.Text);

            Products products = new Products {
                ProductID = ID,
                ProductName = Name,
                UnitPrice = Price,
                Quantity = productQuantity
            };

            frmProductDetails frmProductDetails = new frmProductDetails(false, products);
            DialogResult r = frmProductDetails.ShowDialog();

            if(r == DialogResult.OK)
            {
                DataRow row = dataTableProduct.Rows.Find(products.ProductID);
                row["ProductName"] = products.ProductName;
                row["UnitPrice"] = products.UnitPrice;
                row["Quantity"] = products.Quantity;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtProductID.Text);
            if (productData.DeleteProduct(ID))
            {
                DataRow dataRow = dataTableProduct.Rows.Find(ID);
                dataTableProduct.Rows.Remove(dataRow);
                MessageBox.Show("Successful.");
            }
            else
                MessageBox.Show("Fail");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataTableProduct = productData.GettProducts();

            dataTableProduct.PrimaryKey = new DataColumn[]
            {
                dataTableProduct.Columns["ProductID"]
            };
            dataTableProduct.Columns.Add("SubTotal", typeof(double), "Quantity * UnitPrice");

            bsProducts.DataSource = dataTableProduct;

            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();

            txtProductID.DataBindings.Add("Text", bsProducts, "ProductID");
            txtProductName.DataBindings.Add("Text", bsProducts, "ProductName");
            txtUnitPrice.DataBindings.Add("Text", bsProducts, "UnitPrice");
            txtQuantity.DataBindings.Add("Text", bsProducts, "Quantity");

    
            dgvProductList.DataSource = bsProducts;
            bsProducts.Sort = "ProductID DESC";


        }
    }
}
