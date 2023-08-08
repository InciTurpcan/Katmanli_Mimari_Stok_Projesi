using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ders9_NTierDesing_Katmanli_Mimari.DataLayer;

namespace Ders9_NTierDesing_Katmanli_Mimari.BusinessLayer
{
    public class cls_Category
    {
        //methodlar
        //kategori kaydet--save
        //güncelle--update
        //silme--delete
        //listele--select

        public static bool insert(string categoryname)
        {

           //dataLayer altındaki, connection  içinden bağlantı ayarını alacak
            /* SqlCommand sqlcmd = new SqlCommand("insert into categories values (@degisken)", sqlcon);
             sqlcmd.Parameters.AddWithValue("@degisken",categoryname)*/

            /*
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection= sqlcon;
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_Category_Insert";
            */
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("sp_Category_Insert", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@CategoryName", categoryname);

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

       
        public static SqlDataReader SelectCategoryList()
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("select * from categories", sqlcon);

            sqlcon.Open();
            SqlDataReader categorylist = sqlcmd.ExecuteReader();
            return categorylist;

        }
        
        
        public static bool update(string categoryupdate,int CategoryID)
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("sp_Category_Update", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@CategoryName", categoryupdate) ;
            sqlcmd.Parameters.AddWithValue("@CategoryID", CategoryID);


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

        public static bool delete(string categorydelete, int CategoryID)
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("sp_Category_Delete", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@CategoryID", CategoryID);


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

        public static int SelectCategoryID(string CategoryName)
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("select CategoryID from Categories where CategoryName=@CategoryName", sqlcon);
            sqlcmd.Parameters.AddWithValue("@CategoryName", CategoryName);

            sqlcon.Open();
            SqlDataReader List = sqlcmd.ExecuteReader();
            int CategoryID = 0;
            while (List.Read())
            {

                CategoryID = Convert.ToInt32(List[0]);

            }
            return CategoryID;

        }
    }
}
