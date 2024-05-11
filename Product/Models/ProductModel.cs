using System.ComponentModel.DataAnnotations;

namespace Product.Models
{
    public class ProductModel
    {
        public class ProductData
        {
            /// <summary>
            /// 產品序號
            /// </summary>
            [Required]
            public string Product_Id { get; set; }
            /// <summary>
            /// 產品名稱
            /// </summary>
            [Required]
            public string Product_Name { get; set; }
            /// <summary>
            /// 商品類別
            /// </summary>
            [Required]
            public string Product_Type { get; set; }
        }
    }
}