using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace _2_Donem_Proje
{
    interface Iislemler
    {
        bool Ekle<T>(T entity);
        bool Sil<T>(int ID);
        bool Guncelle<T>(T entity,int id);
        DataTable  Listele<T>();
    }
}
