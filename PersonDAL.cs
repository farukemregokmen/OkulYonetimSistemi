using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using System.CodeDom;

namespace OkulYonetimSistemi
{
    internal class PersonDAL
    {
    interface IGiris
        {
            bool GirisYap(string adSoyad, string sifre);
        }
        public class Ogretmenler:IGiris
        {
            public int Id { get; set; }
            public string AdSoyad { get; set; }
            public string Sifre { get; set; }
            public string Brans { get; set; }
            public string Yetki { get; set; }

            public bool GirisYap(string adSoyad, string sifre)
            {
                using (var connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;Initial Catalog=OkulYonetimSis;Integrated Security=True"))
                {
                    connection.Open();
                    var command = new SqlCommand("SELECT * FROM Ogretmenler WHERE OgretmenAdSoyad=@adSoyad AND OgretmenSifre=@OgretmenSifre", connection);
                    command.Parameters.AddWithValue("@adSoyad", AdSoyad);
                    command.Parameters.AddWithValue("@OgretmenSifre", Sifre);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();
                    connection.Close();
                    System.Windows.Forms.MessageBox.Show("Giris Basarili");
                }
                return true;
            }
        }
        public class Ogrenci
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Sifre { get; set; }
            public string Sinif { get; set; }
        }
    }
}
