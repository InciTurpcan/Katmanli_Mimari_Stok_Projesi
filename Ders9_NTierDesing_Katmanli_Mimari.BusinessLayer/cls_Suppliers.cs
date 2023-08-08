using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Ders9_NTierDesing_Katmanli_Mimari.DataLayer;

namespace Ders9_NTierDesing_Katmanli_Mimari.BusinessLayer
{
    public class cls_Suppliers
    {

        public static bool insert(string Suppliersname)
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("sp_Suppliers_Insert", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@CompanyName", Suppliersname);

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

        public static SqlDataReader SelectSupplierList()
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("select * from suppliers", sqlcon);

            sqlcon.Open();
            SqlDataReader supplierlist = sqlcmd.ExecuteReader();
            return supplierlist;

        }
        public static bool update(string CompanyName, int SupplierID)
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("sp_Suppliers_Update", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@CompanyName", CompanyName);
            sqlcmd.Parameters.AddWithValue("@SupplierID", SupplierID);
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

        public static bool delete(string SuppliersDelete, int SupplierID)
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("sp_Suppliers_Delete", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@SupplierID", SupplierID);
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

        public static int SelectSupplierID(string CompanyName)
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("select SupplierID from Suppliers where CompanyName = @CompanyName", sqlcon);
            sqlcmd.Parameters.AddWithValue("@CompanyName", CompanyName);

            sqlcon.Open();
            SqlDataReader List = sqlcmd.ExecuteReader();
            int SupplierID = 0;
            while (List.Read())
            {

                SupplierID = Convert.ToInt32(List[0]);

            }
            return SupplierID ;

        }




    }


}
