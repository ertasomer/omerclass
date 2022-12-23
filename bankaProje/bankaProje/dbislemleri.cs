using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace bankaProje
{
    class dbislemleri
    {
        SqlConnection baglan;
        SqlCommand komut;
        public string sonuc;
        public dbislemleri()
        {
            string baglanti = "server=4ZR4L1N1Z\\SQLEXPRESS;database=bank;user=omer;password=adolf;";
            baglan = new SqlConnection(baglanti);
            baglan.Open();
        }

        public string kgiriskontrol(double kadi)
        {
            string sql = "select ad+' '+soyad as adsoyad from kullaniciAna where Tc='" +kadi+"'";
            komut = new SqlCommand(sql, baglan);
            sonuc = (string)komut.ExecuteScalar();
            return sonuc;
        }

        //public int kullaniciekle(string Tc, string aldigikart, string ad, string soyad, int yas, string kayittarihi, string dogumtarihi, string adres)
        //{
        //    Convert.ToDateTime(dogumtarihi);
        //    Convert.ToDateTime(kayittarihi);
        //    string sql = "insert into KullaniciBilgileri (kadi,ksifre,ad,soyad,yetki) values ('" + kadi + "','" + sifre
        //        + "','" + ad + "','" + soyad + "'," + yetki + ")";
        //    komut = new SqlCommand();
        //    komut.CommandText = sql;
        //    komut.Connection = baglan;
        //    return (int)komut.ExecuteNonQuery();
        //}
      
    }
}
