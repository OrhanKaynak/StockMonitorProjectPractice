namespace StockMonitor.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwProducts = new DataGridView();
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            tbxStock = new TextBox();
            tbxPrice = new TextBox();
            tbxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbxCategory = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            tbxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(209, 0);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowHeadersWidth = 51;
            dgwProducts.Size = new Size(591, 450);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            dgwProducts.CellFormatting += dgwProducts_CellFormatting;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(tbxStock);
            groupBox1.Controls.Add(tbxPrice);
            groupBox1.Controls.Add(tbxName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-1, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 197);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Ekle";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 162);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(6, 162);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(58, 129);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxStock
            // 
            tbxStock.Location = new Point(73, 96);
            tbxStock.Name = "tbxStock";
            tbxStock.Size = new Size(125, 27);
            tbxStock.TabIndex = 5;
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(73, 56);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(125, 27);
            tbxPrice.TabIndex = 4;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(73, 20);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(125, 27);
            tbxName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 99);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Stok";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı";
            // 
            // cbxCategory
            // 
            cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(72, 203);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(131, 28);
            cbxCategory.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 206);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Kategori";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 254);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Ürün Ara";
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(72, 251);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(131, 27);
            tbxSearch.TabIndex = 5;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxSearch);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbxCategory);
            Controls.Add(groupBox1);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwProducts;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbxName;
        private Button btnAdd;
        private TextBox tbxStock;
        private TextBox tbxPrice;
        private Button btnDelete;
        private Button btnUpdate;
        private ComboBox cbxCategory;
        private Label label4;
        private Label label5;
        private TextBox tbxSearch;
    }
}
