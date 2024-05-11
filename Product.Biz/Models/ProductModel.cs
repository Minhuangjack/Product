using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Biz.Models
{
    public class ProductModel
    {
        public class ListProductByProductType
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
        public class InsertProduct
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
