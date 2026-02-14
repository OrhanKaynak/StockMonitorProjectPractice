using System;
using System.Windows.Forms;
using StockMonitor.Business;
using StockMonitor.Entities;

namespace StockMonitor.UI
{
    public partial class Form1 : Form
    {
        ProductManager _productManager = new ProductManager();

        int _selectedProductId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productManager.GetAll();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductName = tbxName.Text,
                Price = Convert.ToDecimal(tbxPrice.Text),
                Stock = Convert.ToInt32(tbxStock.Text),
                CategoryId = 1
            };
            _productManager.Add(product);

            MessageBox.Show("Ürün başarıyla eklendi");

            LoadProducts();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgwProducts.CurrentRow;
            if (selectedRow != null)
            {
                try
                {
                    _selectedProductId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    tbxName.Text = selectedRow.Cells["ProductName"].Value.ToString();
                    tbxPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                    tbxStock.Text = selectedRow.Cells["Stock"].Value.ToString();
                }
                catch (Exception )
                {

                    MessageBox.Show("Lütfen geçerli bir satıra tıklayınız.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == 0)
            {
                MessageBox.Show("Lütfen silinecek satırı seçiniz!");
                return;
            }

            _productManager.Delete( _selectedProductId );

            MessageBox.Show("Ürün silindi!");

            LoadProducts() ;

            _selectedProductId = 0;

            tbxName.Clear();
            tbxPrice.Clear();
            tbxStock.Clear();
        }
    }
}
