﻿using Sales_and_Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Data_Access_Layer
{
    class ProductDataAccess
    {
        DataAccess dataAccess;
        public ProductDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Product> GetAllProducts()
        {
            string sql = "SELECT * FROM Products";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }

        public int InsertProduct(Product product)
        {
            string sql = "INSERT INTO Products(ProductName,Price,Quantity,CategoryId) VALUES('"+product.ProductName+"',"+product.Price+","+product.Quantity+","+product.CategoryId+")";
            return this.dataAccess.ExecuteQuery(sql);
        }

        public int GetCategoryId(string categoryName)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryName='"+categoryName+"'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return (int)reader["CategoryId"];
        }
        public List<Product> GetProductsForSearch(string productName)
        {
            string sql = "SELECT * FROM Products WHERE ProductName LIKE '"+productName+"%'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }
    }
}