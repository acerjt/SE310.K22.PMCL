using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ASM3
{
    public partial class Form1 : Form
    {
        ProductDB productDB = new ProductDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProduct();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool val1 = ValidateData();
            bool val2 = AddValidate();
            if (!(val1 && val2))
                return;
            int ID = int.Parse(txtProductID.Text);
            string Name = txtProductName.Text;
            int Quantitiy = int.Parse(txtQuantity.Text);
            float Price = float.Parse(txtUnitPrice.Text);

            Product product = new Product {
                ProductID = ID,
                ProductName = Name,
                UnitPrice = Price,
                Quantity = Quantitiy
            };

            bool result = productDB.AddNewProduct(product);
            if(result)
            {
                MessageBox.Show("Product Saved");
            }
            else
            {
                MessageBox.Show("Add Fail");
            }

            GetAllProduct();
        }

        private void GetAllProduct()
        {


            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();

            dgvProductList.DataSource = productDB.GettProducts();

            txtProductID.DataBindings.Add("Text", dgvProductList.DataSource, "ProductID");
            txtProductName.DataBindings.Add("Text", dgvProductList.DataSource, "ProductName");
            txtUnitPrice.DataBindings.Add("Text", dgvProductList.DataSource, "UnitPrice");
            txtQuantity.DataBindings.Add("Text", dgvProductList.DataSource, "Quantity");


            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool val1 = ValidateData();
            bool val2 = AddValidate();
            if (!(val1 && val2))
                return;
            int ID = int.Parse(txtProductID.Text);
            string Name = txtProductName.Text;
            float Price = float.Parse(txtUnitPrice.Text);
            int productQuantity = int.Parse(txtQuantity.Text);

            Product product = new Product
            {
                ProductID = ID,
                ProductName = Name,
                UnitPrice = Price,
                Quantity = productQuantity
            };
            if (productDB.UpdateProduct(product))
            {
                GetAllProduct();
            }
            else
                MessageBox.Show("Fail");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool val1 = ValidateData();
            if (!val1)
                return;
            int ID = int.Parse(txtProductID.Text);
            string Name = txtProductName.Text;
            float Price = float.Parse(txtUnitPrice.Text);
            int productQuantity = int.Parse(txtQuantity.Text);

            Product product = new Product
            {
                ProductID = ID,
                ProductName = Name,
                UnitPrice = Price,
                Quantity = productQuantity
            };
            if (productDB.RemoveProduct(product))
            {
                GetAllProduct();

            }
            else
                MessageBox.Show("Fail");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            bool val1 = ValidateData();
            if (!val1)
                return;
            int ID = int.Parse(txtProductID.Text);
            Product product = productDB.FindProduct(ID);

            if(product != null)
            {
                txtProductID.Text = product.ProductID.ToString();
                txtProductName.Text = product.ProductName.ToString();
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtQuantity.Text = product.Quantity.ToString();
            }
            else
            {
                MessageBox.Show("Product does not exist");
            }
        }

        private bool ValidateData()
        {
            if (txtProductID.Text == string.Empty)
            {
                MessageBox.Show("Data must be fill");
                return false;
            }

            if(int.Parse(txtProductID.Text)  < 0)
            {
                MessageBox.Show("Id must be positive");
                return false;
            }
            return true;
        }

        private bool AddValidate()
        {
            if(txtProductName.Text == string.Empty || txtQuantity.Text == string.Empty || txtUnitPrice.Text == string.Empty)
            {
                MessageBox.Show("Data must be fill");
                return false;
            }

            if (int.Parse(txtProductID.Text) < 0 || int.Parse(txtQuantity.Text) < 0 || float.Parse(txtUnitPrice.Text) < 0)
            {
                MessageBox.Show("Id must be positive");
                return false;
            }

            return true;
        }
    }
}
