using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.EnterpriseServices;
using Product.Dao.Interfaces;
using Product.Dao.Models;
using System;
using static Product.Dao.Models.ProductModel;
namespace Product.Dao.DataSource
{
    // 連結資料庫
    public class ProductDB: IProduct
    {
        string cvConnectionString;
        public ProductDB()
        {
            this.cvConnectionString = "Server = localhost; User ID = ***; Password = ***; Database = DatabaseName";
        }
        
        public DataSet ProductListByProductType(string Product_Type)
        {
            DataSet myDS;
            string myStoreProcedure = "Product_List";
            using (SqlConnection connection = new SqlConnection(cvConnectionString))
            {
                SqlCommand commond = new SqlCommand();
                commond.CommandText = FormatCommandText(myStoreProcedure);
                commond.CommandType = CommandType.StoredProcedure;
                commond.Parameters.AddWithValue("@Product_Type", Product_Type);
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    myDS = new DataSet();
                    adapter.Fill(myDS, "Product");
                }
            }
            return myDS;
        }


        public void InsertProduct(ProductModel.ProductDetail productDetail)
        {
            string myStoreProcedure = "Product_Insert";
            using (SqlConnection connection = new SqlConnection(cvConnectionString))
            {
                SqlCommand commond = new SqlCommand();
                commond.CommandText = FormatCommandText(myStoreProcedure);
                commond.CommandType = CommandType.StoredProcedure;
                commond.Parameters.AddWithValue("@Product_Id", productDetail.Product_Id);
                commond.Parameters.AddWithValue("@Product_Name", productDetail.Product_Name);
                commond.Parameters.AddWithValue("@Product_Stock", productDetail.Product_Stock);
                commond.Parameters.AddWithValue("@Product_Type", productDetail.Product_Type);
                connection.Open();
                commond.ExecuteNonQuery();
            }
        }

        #region 自定義函式
        private string FormatCommandText(string Command_Text)
        {
            string myReturn = "";
            try
            {
                Regex myRegEx = new Regex("(?<=(@[A-Za-z0-9_]+\\s*=\\s*))'", RegexOptions.IgnoreCase);
                return myRegEx.Replace(Command_Text, "N'");
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        #endregion

    }
}

