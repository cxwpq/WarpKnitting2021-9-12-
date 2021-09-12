using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WarpKnitting.BLL
{
    /// <summary>
    /// str1,str2对应的列为Double类型
    /// </summary>
    public static class DataTableAddSum
    {
        public static DataTable AddSum(DataTable dt, string str1, string str2, string str3)
        {
            Double m = 0, n = 0, k = 0;
            DataRow dataRow = dt.NewRow();
            foreach (DataRow row in dt.Rows)
            {
                if (row[str1] != DBNull.Value) m += Convert.ToDouble(row[str1]);
                if (row[str2] != DBNull.Value) n += Convert.ToDouble(row[str2]);
                if (row[str3] != DBNull.Value) k += Convert.ToDouble(row[str3]);
            }
            dataRow["型号"] = "合计";
            dataRow[str1] = m;
            dataRow[str2] = n;
            dataRow[str3] = k;
            dt.Rows.Add(dataRow);
            return dt;
        }

        public static DataTable AddSum(DataTable dt, string str1, string str2)
        {
            Double m = 0, n = 0;
            DataRow dataRow = dt.NewRow();
            foreach (DataRow row in dt.Rows)
            {
                if (row[str1] != DBNull.Value) m += Convert.ToDouble(row[str1]);
                if (row[str2] != DBNull.Value) n += Convert.ToDouble(row[str2]);
            }
            dataRow["型号"] = "合计";
            dataRow[str1] = m;
            dataRow[str2] = n;
            dt.Rows.Add(dataRow);
            return dt;
        }

        public static DataTable AddSum(DataTable dt, string str1)
        {
            Double m = 0;
            DataRow dataRow = dt.NewRow();
            foreach (DataRow row in dt.Rows)
            {
                m += Convert.ToDouble(row[str1]);
            }
            dataRow["型号"] = "合计";
            dataRow[str1] = m;
            dt.Rows.Add(dataRow);
            return dt;
        }
    }
}
