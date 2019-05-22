using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM
{
    public interface IORM<T> where T :class
    {
        DataTable Select(string procName);
        bool Insert(T entites);
        bool Update(T entites);
        bool Delete(T entities);
    }
}
