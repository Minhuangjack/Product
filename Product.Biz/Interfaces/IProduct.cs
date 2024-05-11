using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Biz.Interfaces
{
    public interface IProduct
    {
        List<Models.ProductModel.ListProductByProductType> ListByProductType(string Product_Type);

        void InsertProductType(Models.ProductModel.InsertProduct product);

    }
}
