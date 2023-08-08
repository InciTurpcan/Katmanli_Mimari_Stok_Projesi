using Ders9_NTierDesing_Katmanli_Mimari.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9_NTierDesing_Katmanli_Mimari.BusinessLayer
{
    public class cls_Emplooye
    {
       

        public static SqlDataReader SelectEmployeeList()
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("select * from Employees", sqlcon);

            sqlcon.Open();
            SqlDataReader employeelist = sqlcmd.ExecuteReader();
            return employeelist;
        }
        public static bool insert(int ProductID,int EmployeeID,string Quantity)
        {

            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("insert into Sipariş (ProductID,EmployeeID,Quantity) values (@ProductID,@EmployeeID,@Quantity)", sqlcon);
            sqlcmd.Parameters.AddWithValue("@ProductID", ProductID);
            sqlcmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            sqlcmd.Parameters.AddWithValue("@Quantity", Quantity);
           


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
        

        public static int SelectEmployeeID(string LastName)
        {
            SqlConnection sqlcon = connection.baglantı;
            SqlCommand sqlcmd = new SqlCommand("select EmployeeID from Employees where LastName=@LastName", sqlcon);
            sqlcmd.Parameters.AddWithValue("@LastName", LastName);

            sqlcon.Open();
            SqlDataReader List = sqlcmd.ExecuteReader();
            int EmployeeID = 0;
            while (List.Read())
            {

                EmployeeID = Convert.ToInt32(List[0]);

            }
            return EmployeeID;

        }
    }


}
