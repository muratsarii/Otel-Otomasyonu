using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM
{
    public class ORMBase<T> : IORM<T> where T:class
    {
        private string ClassName
        {
            get
            {
                return typeof(T).Name;
            }
        }
        public bool Delete(T entities)
        {
            SqlCommand command = new SqlCommand(string.Format("prc_{0}_Delete", ClassName), Tools.Baglanti);
            command.CommandType = CommandType.StoredProcedure;
            Tools.ParametreOlustur<T>(command, KomutTip.Delete, entities);
            return Tools.Exec(command);
        }

        public bool Insert(T entites)
        {
            SqlCommand komut = new SqlCommand(string.Format("prc_{0}_Insert",ClassName), Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] properties = typeof(T).GetProperties();
            /*foreach (PropertyInfo pi in properties)
            {
                string name = pi.Name;
                if (name.ToLower()=="Id"||name.ToLower()=="ıd")
                    continue;
                object value = pi.GetValue(entites);
                //var value1 = pi.GetValue(entites);
                komut.Parameters.Add("@" + name, value);
            }*/
            Tools.ParametreOlustur<T>(komut, KomutTip.Insert, entites);
            return Tools.Exec(komut);
        }

        public DataTable Select(string procName)
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("prc_{0}_Select", ClassName), Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public bool Update(T entites)
        {
            SqlCommand komut = new SqlCommand(string.Format("prc_{0}_Update", ClassName), Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            Tools.ParametreOlustur<T>(komut, KomutTip.Update, entites);
            return Tools.Exec(komut);
        }
        
    }
}
