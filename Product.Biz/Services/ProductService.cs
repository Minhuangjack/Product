using Product.Biz.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product.Biz.Interfaces;
using Product.Biz.Models;
using DAO = Product.Dao;
using static Product.Biz.Models.ProductModel;
using Product.Dao.DataSource;
namespace Product.Biz.Services
{
    public class ProductService
    {
        private IProduct product;

        public IProduct ProductDAO
        {
            private get
            {
                if (product == null)
                {
                    product = new ProductDAO();
                }
                return product;
            }
            set { this.ProductDAO = value; }
        }
        ProductService()
        {
            product =  new ProductDAO();
        }

        public List<ProductModel.ListProductByProductType> ListByProductType(string Product_Type)
        {
            return product.ListByProductType(Product_Type);
        }
    }
}
