using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Product.Dao.Models.ProductModel;

namespace Product.Dao.Interfaces
{
    public interface IProduct
    {
        DataSet ProductListByProductType(string Product_Type);

        void InsertProduct(ProductDetail productDetail);
    }
}
