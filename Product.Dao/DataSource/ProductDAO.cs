using Product.Dao.Interfaces;
using Product.Dao.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Dao.DataSource
{
    // 連結資料庫
    public class ProductDAO: IProduct
    {
        public DataSet ProductListByProductType(string Product_Type)
        { 
            DataTable myDT = new DataTable("Product");
            myDT.Columns.Add("Product_Id", typeof(string));
            myDT.Columns.Add("Product_Name", typeof(string));
            myDT.Columns.Add("Product_Stock", typeof(int));
            myDT.Columns.Add("Product_Type", typeof(string));

            DataRow myRow = myDT.NewRow();
            myRow["Product_Id"] = "P0001";
            myRow["Product_Name"] = "1號產品";
            myRow["Product_Stock"] = 9999;
            myRow["Product_Type"] = "數據機";
            myDT.Rows.Add(myRow);
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDT);
            return myDS;
        }

        public void InsertProduct(ProductModel.ProductDetail productDetail)
        {
            // TODO 塞入資料
        }

    }
}

