using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Biz.Interfaces;
using Product.Dao.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Dao.Services.Tests
{
    [TestClass()]
    public class ProductServiceTests
    {
        IProduct product;
        [TestInitialize]
        public void Start()
        {
            product = new Biz.DataSource.FakeData.ProductFake();
        }

        [TestMethod()]
        public void TestProductListByProductType()
        {
            string myProductType = "測試資料";
            var myProduct = product.ListByProductType(myProductType);
            string myExpected = "AA001";

            Assert.AreEqual(myExpected, myProduct.FirstOrDefault().Product_Id);

        }
    }
}