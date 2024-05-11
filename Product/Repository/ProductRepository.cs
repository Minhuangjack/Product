using System.Collections.Generic;
using static Product.Biz.Models.ProductModel;
using static Product.Models.ProductModel;
namespace Product.Repository
{
    public class ProductRepository
    {
        Biz.Services.ProductService productService;
        public ProductRepository() 
        {
            productService = new Biz.Services.ProductService();
        }
        public List<Response.ProductResponse.ProductDetail> ListProductDetail(string Product_Type)
        {
            var myProductList = productService.ListByProductType(Product_Type);
            var myProductListResponse = new List<Response.ProductResponse.ProductDetail>();
            foreach (var wkItem in myProductList)
            {
                var wkProductDetail = new Response.ProductResponse.ProductDetail() 
                {
                    Product_Id = wkItem.Product_Id,
                    Product_Name = wkItem.Product_Name,
                    Product_Type = wkItem.Product_Type,
                };
            }
            return myProductListResponse;
        }

        public void InsertProduct(ProductData product)
        {
            InsertProduct insertProduct = new InsertProduct() 
            {
                Product_Id = product.Product_Id,
                Product_Name= product.Product_Name,
                Product_Type = product.Product_Type,
            };
            productService.InsertProduct(insertProduct);
        }
    }
}