using Product.Biz.Interfaces;
using Product.Biz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Biz.DataSource.FakeData
{
    public class ProductFake : IProduct
    {
        public void InsertProductType(ProductModel.InsertProduct product)
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
