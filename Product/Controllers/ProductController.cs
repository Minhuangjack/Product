using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static Product.Models.ProductModel;
using BasisAPI.Attributes;
using Product.Repository;
namespace Product.Controllers
{
    [Route("Product")]
    public class ProductController : ApiController
    {
        ProductRepository productRepository;

        [Route("ProductList")]
        [HttpGet]
        public IEnumerable<Response.ProductResponse.ProductDetail> GetProductList(string Product_Type)
        {
            productRepository = new ProductRepository();
            List<Response.ProductResponse.ProductDetail> myProductDetail = productRepository.ListProductDetail(Product_Type);
            return myProductDetail;
        }

        [Route("AddProduct")]
        [HttpPost]
        [Member(MemberAttribute.MemberType.員工)]
        public HttpResponseMessage AddProductList(ProductData insertProduct)
        {
            productRepository = new ProductRepository();
            productRepository.InsertProduct(insertProduct);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
