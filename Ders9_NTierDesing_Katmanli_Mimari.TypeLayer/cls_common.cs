using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9_NTierDesing_Katmanli_Mimari.TypeLayer
{
    public class cls_common
    {
        //CRUD
        //Create(insert-yeni kayıt)
        //Read(listeleme)
        //Update(güncelleme)
        //Delete(silme)
       
        public static string messages(string tablename,string CRUD,bool isok)
        {
            

            if (isok== true)
            {
                if (CRUD=="insert")
                {
                    return tablename + " tablosuna başarıyla kaydedildi.";
                }
                else if (CRUD=="update")
                {
                    return tablename + "tablosu başarıyla güncellendi.";
                }
                else if (CRUD=="delete")
                {
                    return tablename + "tablosundan başarıyla silindi.";
                }
                else
                {
                    return "Yanlış CRUD parametresi girdiniz.";
                }
            }

            else 
            {
                if (CRUD=="insert")
                {
                    return tablename + " tablosuna başarıyla kaydedilemedi.";
                }

                else if (CRUD=="update")
                {
                    return tablename + "tablosu başarıyla güncellenemedi.";
                }

                else if (CRUD=="delete")
                {
                    return tablename + "tablosundan başarıyla silinemedi.";
                }

                else
                {
                    return "Yanlış CRUD parametresi girdiniz.";
                }
            }
            
        }

    }
}
