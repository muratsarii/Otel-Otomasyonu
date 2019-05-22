using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace OtelOtomasyonu.ORM
{
    public class Tools
    {
        private static SqlConnection _baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (_baglanti == null)
                    _baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                return _baglanti;
            }
        }
        public static bool Exec (SqlCommand komut )
        {
            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                    komut.Connection.Open();
                int etk = komut.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (komut.Connection.State != ConnectionState.Closed)
                    komut.Connection.Close();
            }
        }
        public static void ParametreOlustur<T>(SqlCommand komut, KomutTip komuttip, T ent)
        {
            PropertyInfo[] propertyInfo = typeof(T).GetProperties();
            foreach (PropertyInfo pi in propertyInfo)
            {
                string name = pi.Name;
                if (name.ToLower() == "ıd" || name.ToLower() == "id" && komuttip == KomutTip.Insert)
                    continue;
                else if (komuttip== KomutTip.Delete && name.ToLower() != "ıd" || name.ToLower() != "id")
                    continue;
                object value = pi.GetValue(ent);
                komut.Parameters.AddWithValue("@" + name, value);
            }
        }
    }
}
