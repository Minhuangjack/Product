namespace Product.Response
{
    public class ProductResponse
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
            /// 商品類別
            /// </summary>
            public string Product_Type { get; set; }
        }
    }
}