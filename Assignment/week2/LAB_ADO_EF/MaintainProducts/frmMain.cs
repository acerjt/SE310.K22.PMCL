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
        MySaleEntities db = new MySaleEntities();

   


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int ProID = int.Parse(txtProductID.Text);
                Product product = db.Products.Find(ProID);

                db.Products.Remove(product);
                db.SaveChanges();
                
                MessageBox.Show("Delete successful");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int ProID = int.Parse(txtProductID.Text);
                Product product = db.Products.Find(ProID);
                if(product == null)
                {
                    MessageBox.Show("Product not found.");
                }
                else
                {
                    txtProductName.Text = product.ProductName;
                    txtUnitPrice.Text = product.UnitPrice.ToString();
                    txtQuantity.Text = product.Quantity.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                int ProID = int.Parse(txtProductID.Text);
                string Name = txtProductName.Text;
                float Price = float.Parse(txtUnitPrice.Text);
                int Quantity = int.Parse(txtQuantity.Text);


                Product product = new Product
                {
                    ProductID = ProID,
                    ProductName = Name,
                    UnitPrice = Price,
                    Quantity = Quantity
                };

                db.Products.Add(product);
                db.SaveChanges();
                MessageBox.Show("Product is Saved.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = db.Products.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
