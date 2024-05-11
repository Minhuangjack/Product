using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Dao.Models
{
    public class ProductModel
    {
        public class ProductDetail
        {
            /// <summary>
            /// 產品序號
            /// </summary>
            public string Product_Id { get; set; }
            /// <summary>
            /// 產品名稱
            /// </summary>
            public string Product_Name { get; set; }
            /// <summary>
            /// 商品庫存
            /// </summary>
            public int Product_Stock { get; set; }
            /// <summary>
            /// 商品類別
            /// </summary>
            public string Product_Type { get; set; }

        }
    }
}
