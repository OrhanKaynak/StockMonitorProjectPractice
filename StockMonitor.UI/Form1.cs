using System;
using System.Windows.Forms;
using StockMonitor.Business;
using StockMonitor.Entities;

namespace StockMonitor.UI
{
    public partial class Form1 : Form
    {
        ProductManager _productManager = new ProductManager();
        CategoryManager _categoryManager = new CategoryManager();

        int _selectedProductId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
            UpdateStatics();
        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productManager.GetAll();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryManager.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "Id";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductName = tbxName.Text,
                Price = string.IsNullOrEmpty(tbxPrice.Text) ? 0 : Convert.ToDecimal(tbxPrice.Text),
                Stock = string.IsNullOrEmpty(tbxStock.Text) ? 0 : Convert.ToInt32(tbxStock.Text),
                CategoryId = Convert.ToInt32(cbxCategory.SelectedValue)
            };
            _productManager.Add(product);

            MessageBox.Show("Ürün başarıyla eklendi");

            LoadProducts();
            UpdateStatics();
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
                    cbxCategory.SelectedValue = selectedRow.Cells["CategoryId"].Value;
                }
                catch (Exception)
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

            _productManager.Delete(_selectedProductId);

            MessageBox.Show("Ürün silindi!");

            LoadProducts();
            UpdateStatics();

            _selectedProductId = 0;

            tbxName.Clear();
            tbxPrice.Clear();
            tbxStock.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek ürünü listeden seçiniz.");
                return;
            }

            Product product = new Product
            {
                Id = _selectedProductId,
                ProductName = tbxName.Text,
                Price = Convert.ToDecimal(tbxPrice.Text),
                Stock = Convert.ToInt32(tbxStock.Text),
                CategoryId = Convert.ToInt32(cbxCategory.SelectedValue)
            };
            _productManager.Update(product);

            MessageBox.Show("Ürün başarıyla güncellendi.");
            LoadProducts();
            UpdateStatics();

            tbxName.Clear();
            tbxPrice.Clear();
            tbxStock.Clear();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;

            if (string.IsNullOrEmpty(key))
            {
                LoadProducts();
            }
            else
            {
                dgwProducts.DataSource = _productManager.GetProductsByName(key);
            }
        }

        private void dgwProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwProducts.Rows[e.RowIndex];
                if (row.Cells["Stock"].Value != null)
                {
                    int stock = Convert.ToInt32(row.Cells["Stock"].Value);

                    if (stock < 10)
                    {
                        row.DefaultCellStyle.BackColor = Color.OrangeRed;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void UpdateStatics()
        {
            int count = _productManager.GetProductCount();
            lblProductCount.Text = count.ToString();

            decimal total = _productManager.GetTotalAmount();
            lblTotalAmount.Text = total.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
