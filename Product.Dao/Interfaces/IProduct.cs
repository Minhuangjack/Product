using System.Data;
using static Product.Dao.Models.ProductModel;

namespace Product.Dao.Interfaces
{
    public interface IProduct
    {
        DataSet ProductListByProductType(string Product_Type);

        void InsertProduct(ProductDetail productDetail);
    }
}
