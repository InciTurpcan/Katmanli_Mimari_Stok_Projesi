using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ders9_NTierDesing_Katmanli_Mimari.DataLayer;


namespace Ders9_NTierDesing_Katmanli_Mimari.BusinessLayer
{
    public class cls_Product
    {
        public int ProductID { get; set; }
        public string Productname { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public decimal  Price{ get; set; }
        public int UnitsInStock { get; set; }  
        public bool insert()
        {

            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("insert into Products (ProductName,CategoryID,SupplierID,UnitPrice,UnitsInStock) values" +
                " (@ProductName,@CategoryID,@SupplierID,@UnitPrice,@UnitsInStock)", sqlcon);
            sqlcmd.Parameters.AddWithValue("@Productname", Productname);
            sqlcmd.Parameters.AddWithValue("@SupplierID", SupplierID);
            sqlcmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            sqlcmd.Parameters.AddWithValue("@UnitPrice", Price);
            sqlcmd.Parameters.AddWithValue("@UnitsInStock", UnitsInStock);


            try
            {
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public bool update()
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("sp_Product_Update", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@ProductID", ProductID);
            sqlcmd.Parameters.AddWithValue("@ProductName", Productname);
            sqlcmd.Parameters.AddWithValue("@SupplierID", SupplierID);
            sqlcmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            sqlcmd.Parameters.AddWithValue("@UnitPrice", Price);
            sqlcmd.Parameters.AddWithValue("@UnitsInStock", UnitsInStock);
           

            try
            {
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

            
        }

        public  bool delete()
        {

            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("sp_Product_Delete", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@ProductID", ProductID);
           


            try
            {
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }
        public static SqlDataReader SelectProductList()
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("select * from vw_Product_Update_Delete", sqlcon);

            sqlcon.Open();
            SqlDataReader productlist = sqlcmd.ExecuteReader();
            return productlist;
        }

        public static int SelectProductID(string ProductName)
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("select ProductID from Products where ProductName=@ProductName", sqlcon);
            sqlcmd.Parameters.AddWithValue("@ProductName", ProductName);

            sqlcon.Open();
            SqlDataReader List = sqlcmd.ExecuteReader();
            int ProductID = 0;
            while (List.Read())
            {

                ProductID = Convert.ToInt32(List[0]);

            }
            return ProductID;

        }
    }
}
