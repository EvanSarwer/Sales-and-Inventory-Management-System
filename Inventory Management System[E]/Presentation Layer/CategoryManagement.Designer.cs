namespace Inventory_Management_System_E_.Presentation_Layer
{
    partial class CategoryManagement
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
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.updateCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryWiseProductDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.categoryWiseProductcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backToHomeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWiseProductDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteCategoryButton);
            this.groupBox1.Controls.Add(this.updateCategoryButton);
            this.groupBox1.Controls.Add(this.addCategoryButton);
            this.groupBox1.Controls.Add(this.categoryNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Add/Update/Delete";
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(376, 116);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(134, 29);
            this.deleteCategoryButton.TabIndex = 2;
            this.deleteCategoryButton.Text = "Delete Category";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // updateCategoryButton
            // 
            this.updateCategoryButton.Location = new System.Drawing.Point(225, 116);
            this.updateCategoryButton.Name = "updateCategoryButton";
            this.updateCategoryButton.Size = new System.Drawing.Size(135, 29);
            this.updateCategoryButton.TabIndex = 2;
            this.updateCategoryButton.Text = "Update Category";
            this.updateCategoryButton.UseVisualStyleBackColor = true;
            this.updateCategoryButton.Click += new System.EventHandler(this.updateCategoryButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(80, 116);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(124, 29);
            this.addCategoryButton.TabIndex = 2;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(177, 50);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(158, 26);
            this.categoryNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // loadCategoryDataGridView
            // 
            this.loadCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadCategoryDataGridView.Location = new System.Drawing.Point(821, 184);
            this.loadCategoryDataGridView.Name = "loadCategoryDataGridView";
            this.loadCategoryDataGridView.Size = new System.Drawing.Size(246, 263);
            this.loadCategoryDataGridView.TabIndex = 5;
            this.loadCategoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadCategoryDataGridView_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(887, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category List";
            // 
            // categoryWiseProductDataGridView
            // 
            this.categoryWiseProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryWiseProductDataGridView.Location = new System.Drawing.Point(42, 103);
            this.categoryWiseProductDataGridView.Name = "categoryWiseProductDataGridView";
            this.categoryWiseProductDataGridView.Size = new System.Drawing.Size(549, 229);
            this.categoryWiseProductDataGridView.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refreshButton);
            this.groupBox2.Controls.Add(this.categoryWiseProductcomboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.categoryWiseProductDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(78, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 357);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Product List by Category";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(487, 47);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(104, 29);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // categoryWiseProductcomboBox
            // 
            this.categoryWiseProductcomboBox.FormattingEnabled = true;
            this.categoryWiseProductcomboBox.Location = new System.Drawing.Point(195, 49);
            this.categoryWiseProductcomboBox.Name = "categoryWiseProductcomboBox";
            this.categoryWiseProductcomboBox.Size = new System.Drawing.Size(165, 27);
            this.categoryWiseProductcomboBox.TabIndex = 7;
            this.categoryWiseProductcomboBox.SelectedIndexChanged += new System.EventHandler(this.categoryWiseProductcomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category Name";
            // 
            // backToHomeButton
            // 
            this.backToHomeButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToHomeButton.Location = new System.Drawing.Point(78, 52);
            this.backToHomeButton.Name = "backToHomeButton";
            this.backToHomeButton.Size = new System.Drawing.Size(115, 29);
            this.backToHomeButton.TabIndex = 8;
            this.backToHomeButton.Text = "Home";
            this.backToHomeButton.UseVisualStyleBackColor = true;
            this.backToHomeButton.Click += new System.EventHandler(this.backToHomeButton_Click);
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1149, 747);
            this.Controls.Add(this.backToHomeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadCategoryDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryManagement_FormClosing);
            this.Load += new System.EventHandler(this.CategoryManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadCategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWiseProductDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateCategoryButton;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.DataGridView loadCategoryDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView categoryWiseProductDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox categoryWiseProductcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button backToHomeButton;
    }
}