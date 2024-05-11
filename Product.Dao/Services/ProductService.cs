﻿
using Product.Dao.DataSource;
using Product.Dao.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Product.Dao.Models.ProductModel;

namespace Product.Dao.Services
{
    public class ProductService
    {
        private IProduct productDAO;

        public IProduct ProductDAO
        {
            private get 
            {
                if (productDAO == null)
                {
                    productDAO = new ProductDAO();
                }
                return productDAO;
            }
            set { this.ProductDAO = value; }
        }

        public ProductService()
        {
        }

        public List<ProductDetail> ProductListByProductType(string Product_Type)
        {
            List<ProductDetail> productDetails = new List<ProductDetail>();
            DataSet myProductDS = productDAO.ProductListByProductType(Product_Type);
            foreach (DataRow wkRow in myProductDS.Tables["Product"].Rows)
            {
                var wkProductDetail = new ProductDetail()
                { 
                    Product_Id = wkRow["Product_Id"].ToString(),
                    Product_Name = wkRow["Product_Name"].ToString(),
                    Product_Stock = int.Parse(wkRow["Product_Stock"].ToString()),
                    Product_Type = wkRow["Product_Type"].ToString()
                };
                productDetails.Add(wkProductDetail);
            }
            return productDetails;
        }

        public void InsertProductList(ProductDetail productDetail)
        {
            productDAO.InsertProduct(productDetail);
        }

    }
}