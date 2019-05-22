using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
namespace _2_Donem_Proje
{
    public class KelimeORM : Iislemler
    {
        public  DataTable Listele<T>()
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("{0}_Select",typeof(T).Name),Araclar.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public bool Ekle<T>(T entity)
        {
            SqlCommand komut = new SqlCommand(string.Format("{0}_Insert", typeof(T).Name), Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] proplar = typeof(T).GetProperties();
            foreach (PropertyInfo p in proplar)
            {
                string ad = p.Name;
                object deger = p.GetValue(entity);
                komut.Parameters.AddWithValue("@" + ad, deger);
            }
            return Araclar.Calıstır(komut);
        }
        public bool Sil<T>(int ID)
        {
            SqlCommand komut = new SqlCommand(string.Format("{0}_Delete", typeof(T).Name), Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ID", ID);
           return Araclar.Calıstır(komut);
        }
        public bool Guncelle<T>(T entity,int id)
        {
            SqlCommand komut = new SqlCommand(string.Format("{0}_Update", typeof(T).Name), Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] proplar = typeof(T).GetProperties();
            komut.Parameters.AddWithValue("@ID",id);
            foreach (PropertyInfo p in proplar)
            {
                string ad = p.Name;
                object deger = p.GetValue(entity);
                komut.Parameters.AddWithValue("@" + ad, deger);
            }
            return Araclar.Calıstır(komut);
        }

       

       
    }
}
