namespace Inventory_Management_System_E_.Presentation_Layer
{
    partial class ProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.productCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadProductListGridView = new System.Windows.Forms.DataGridView();
            this.backToHomeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchProductNameTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadProductListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteProductButton);
            this.groupBox1.Controls.Add(this.UpdateProductButton);
            this.groupBox1.Controls.Add(this.productCategoryComboBox);
            this.groupBox1.Controls.Add(this.productQuantityTextBox);
            this.groupBox1.Controls.Add(this.productPriceTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.productNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(110, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Add/Update/Delete";
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(309, 331);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(95, 30);
            this.DeleteProductButton.TabIndex = 10;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.Location = new System.Drawing.Point(189, 331);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(95, 30);
            this.UpdateProductButton.TabIndex = 9;
            this.UpdateProductButton.Text = "Update";
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // productCategoryComboBox
            // 
            this.productCategoryComboBox.FormattingEnabled = true;
            this.productCategoryComboBox.Location = new System.Drawing.Point(167, 238);
            this.productCategoryComboBox.Name = "productCategoryComboBox";
            this.productCategoryComboBox.Size = new System.Drawing.Size(154, 27);
            this.productCategoryComboBox.TabIndex = 8;
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantityTextBox.Location = new System.Drawing.Point(167, 178);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(154, 26);
            this.productQuantityTextBox.TabIndex = 7;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceTextBox.Location = new System.Drawing.Point(167, 118);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(154, 26);
            this.productPriceTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(46, 331);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(117, 30);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(167, 53);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(154, 26);
            this.productNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // loadProductListGridView
            // 
            this.loadProductListGridView.AllowUserToAddRows = false;
            this.loadProductListGridView.AllowUserToDeleteRows = false;
            this.loadProductListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadProductListGridView.Location = new System.Drawing.Point(634, 285);
            this.loadProductListGridView.Name = "loadProductListGridView";
            this.loadProductListGridView.ReadOnly = true;
            this.loadProductListGridView.Size = new System.Drawing.Size(453, 232);
            this.loadProductListGridView.TabIndex = 1;
            this.loadProductListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadProductListGridView_CellClick);
            // 
            // backToHomeButton
            // 
            this.backToHomeButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToHomeButton.Location = new System.Drawing.Point(110, 59);
            this.backToHomeButton.Name = "backToHomeButton";
            this.backToHomeButton.Size = new System.Drawing.Size(97, 31);
            this.backToHomeButton.TabIndex = 2;
            this.backToHomeButton.Text = "Home";
            this.backToHomeButton.UseVisualStyleBackColor = true;
            this.backToHomeButton.Click += new System.EventHandler(this.backToHomeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(819, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "List of Products";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Search by Product Name";
            // 
            // searchProductNameTextBox
            // 
            this.searchProductNameTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductNameTextBox.Location = new System.Drawing.Point(863, 222);
            this.searchProductNameTextBox.Name = "searchProductNameTextBox";
            this.searchProductNameTextBox.Size = new System.Drawing.Size(172, 26);
            this.searchProductNameTextBox.TabIndex = 10;
            this.searchProductNameTextBox.TextChanged += new System.EventHandler(this.searchProductNameTextBox_TextChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(634, 177);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1159, 682);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.searchProductNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backToHomeButton);
            this.Controls.Add(this.loadProductListGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductManagement_FormClosing);
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadProductListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox productCategoryComboBox;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView loadProductListGridView;
        private System.Windows.Forms.Button backToHomeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchProductNameTextBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button UpdateProductButton;
    }
}