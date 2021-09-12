using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WarpKnitting.DAL
{
    public class Customer
    {
        public DataSet DataSet1(string SQLString)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM Customer ");
            strSql.Append("where 类别= '" + SQLString + "' ");
            strSql.Append("order by ID");
            return DbHelperOleDb.ExecuteDataSet1(strSql.ToString());
        }
        public DataSet DataSet1()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM Customer ");
            //   strSql.Append("where " + SQLString + " = 1 ");
            strSql.Append("order by ID");
            return DbHelperOleDb.ExecuteDataSet1(strSql.ToString());
        }

        public void UpdateExecuteDataSet1(DataTable mTable)
        {
            DbHelperOleDb.UpdateExecuteDataSet1(mTable);
        }

    }
}
