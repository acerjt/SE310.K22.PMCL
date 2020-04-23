using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net.Http;
using RemoteService;

namespace MaintainProducts
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        HttpClient client = new HttpClient();
        string baseUri = "http://localhost:50535/api/product/";

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage resp = client.GetAsync(baseUri).Result;

                resp.EnsureSuccessStatusCode();
                
                List<RemoteService.Models.Products> products = resp.Content.ReadAsAsync<List<RemoteService.Models.Products>>().Result;
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

            int ID = int.Parse(txtProductID.Text);
            string Name= txtProductName.Text;
            float Price = float.Parse(txtProductPrice.Text);
            int Quantity = int.Parse(txtProductQuantity.Text);

            RemoteService.Models.Products products = new RemoteService.Models.Products
            {
                ProductID = ID,
                ProductName = Name,
                UnitPrice = Price,
                Quantity = Quantity
            };

            HttpResponseMessage resp = client.PostAsJsonAsync(baseUri, products).Result;
            resp.EnsureSuccessStatusCode();
            MessageBox.Show("Product is saved");
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
                int ID = int.Parse(txtProductID.Text);
                HttpResponseMessage resp = client.DeleteAsync(baseUri + ID).Result;
                resp.EnsureSuccessStatusCode();
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
                int ID = int.Parse(txtProductID.Text);
                HttpResponseMessage resp = client.GetAsync(baseUri + ID).Result;
                resp.EnsureSuccessStatusCode();

                RemoteService.Models.Products products = resp.Content.ReadAsAsync<RemoteService.Models.Products>().Result;
                if (products == null)
                {
                    MessageBox.Show("Product not found.");
                }
                else
                {
                    txtProductName.Text = products.ProductName;
                    txtProductPrice.Text = products.UnitPrice.ToString();
                    txtProductQuantity.Text = products.Quantity.ToString();
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
            txtProductPrice.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;

            dgvProducts.DataSource = null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
