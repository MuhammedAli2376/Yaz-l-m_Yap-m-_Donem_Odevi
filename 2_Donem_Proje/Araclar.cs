using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace _2_Donem_Proje
{
   public static class Araclar
    {
        private static SqlConnection baglanti { get; set; }
        public static SqlConnection Baglanti
        {
            get
            {
                if(baglanti==null)
                    baglanti = new SqlConnection("Server=DESKTOP-TO5VRLK\\SQLEXPRESS;Database=Sozluk;Integrated Security=true");
                return baglanti;
            }
        }
       public static bool Calıstır(SqlCommand komut)
        {
            try
            {
                if (komut.Connection.State == ConnectionState.Closed)
                    komut.Connection.Open();
                int etk = komut.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (komut.Connection.State == ConnectionState.Open)
                    komut.Connection.Close();
            }
            

        }
        

    }
}
