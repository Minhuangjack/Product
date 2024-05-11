using System.Collections.Generic;
using Product.Biz.Interfaces;
using Product.Biz.Models;
using DAO = Product.Dao;
using static Product.Biz.Models.ProductModel;
using static Product.Dao.Models.ProductModel;


namespace Product.Biz.DataSource
{
    public class ProductDAO : IProduct
    {

        DAO.Services.ProductService productService;
        public ProductDAO()
        {
            productService = new DAO.Services.ProductService();
        }

        public void InsertProduct(InsertProduct product)
        {
            ProductDetail productDetail = new ProductDetail() 
            { 
                Product_Id = product.Product_Id,
                Product_Name = product.Product_Name,
                Product_Type = product.Product_Type,
            };
            productService.InsertProductDetail(productDetail);
        }

        public List<ProductModel.ListProductByProductType> ListByProductType(string Product_Type)
        {
            var myProductDaoDetails = productService.ProductListByProductType(Product_Type);
            List<ProductModel.ListProductByProductType> productListByProductTypes = new List<ProductModel.ListProductByProductType>();
            foreach (var wkProductDaoDetail in productListByProductTypes)
            {
                var wkProductListByProductType = new ProductModel.ListProductByProductType()
                {
                    Product_Id = wkProductDaoDetail.Product_Id,
                    Product_Name = wkProductDaoDetail.Product_Name,
                    Product_Stock = wkProductDaoDetail.Product_Stock,
                    Product_Type = wkProductDaoDetail.Product_Type
                };
                productListByProductTypes.Add(wkProductListByProductType);
            }
            // TODO 可以做驗證整理後回傳
            return productListByProductTypes;
        }
    }
}
