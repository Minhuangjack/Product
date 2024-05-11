using System;
using System.Collections.Generic;
using Product.Biz.Interfaces;
using Product.Biz.Models;

namespace Product.Biz.DataSource.FakeData
{
    public class ProductFake : IProduct
    {
        public void InsertProduct(ProductModel.InsertProduct product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel.ListProductByProductType> ListByProductType(string Product_Type)
        {
            return new List<ProductModel.ListProductByProductType>() 
            {
                new ProductModel.ListProductByProductType() 
                {
                    Product_Type = "測試資料",
                    Product_Id = "AA001",
                    Product_Name = "FakeData",
                    Product_Stock = 9999
                }
            };
        }
    }
}
