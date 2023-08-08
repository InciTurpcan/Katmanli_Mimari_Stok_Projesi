using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ders9_NTierDesing_Katmanli_Mimari.DataLayer
{
    public class connection
    {
        //veri tabanına bağlantı işlemleri burada olacak

        //iakademi veritabanı bağlantı methodu
        //192.168.35.45--ip
        //login=ddddd
        //password=123.
        //iakademiDB

        public static SqlConnection baglantı
        {
            get 
            {
                SqlConnection sqlcon = new SqlConnection("Server=LAPTOP-GL2LON0G;Trusted_Connection=True;Database=NORTHWND");
                return sqlcon;
            }
        }
 
    }
}
