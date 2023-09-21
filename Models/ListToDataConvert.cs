using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace test_app_1.Models
{
    public class ListToDatatableConvert
    {
        public DataTable ToDataTable<T>(List<T> E)
        {
            DataTable dt = new DataTable(typeof(T).Name);
            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public|BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                dt.Columns.Add(property.Name);
            }
            foreach (T ea in E)
            {
                var values = new object[properties.Length];
                for(int i=0; i< properties.Length; i++)
                {
                    var xd = properties[i].GetValue(ea, null);
                    values[i] = properties[i].GetValue(ea, null);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }
    }
}
