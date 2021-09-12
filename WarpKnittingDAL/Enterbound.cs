using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WarpKnitting.Model;

namespace WarpKnitting.DAL
{
    public class Enterbound
    {
        public DataSet DataSet1(Int32 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM ( ");
            strSql.Append("select top 100 percent * ");
            strSql.Append("FROM Enterbound ");
            //strSql.Append("where " + SQLString + " = 1 ");
            strSql.Append("order by ID");
            strSql.Append(") TAL ORDER BY ID");
            return DbHelperOleDb.ExecuteDataSet1(strSql.ToString());
        }

        public void UpdateExecuteDataSet1(DataTable mTable)
        {
            DbHelperOleDb.UpdateExecuteDataSet1(mTable);
        }

        public DataSet Query1(boundQuery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM Enterbound ");
            strSql.Append("where 入厂日期 BETWEEN  '" + model.EnterFactoryDate1 + "' and '" + model.EnterFactoryDate2 + "' ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }

        public DataSet Query2(boundQuery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM Enterbound ");
            strSql.Append("where 入厂日期 BETWEEN  '" + model.EnterFactoryDate1 + "' and '" + model.EnterFactoryDate2 + "' ");
            strSql.Append("and 型号 = '" + model.Type + "' ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }

        public DataSet Query3(boundQuery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM Enterbound ");
            strSql.Append("where 入厂日期 BETWEEN  '" + model.EnterFactoryDate1 + "' and '" + model.EnterFactoryDate2 + "' ");
            strSql.Append("and 丝厂 = '" + model.Producer + "' ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }

        public DataSet Query4(boundQuery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM Enterbound ");
            strSql.Append("where 入厂日期 BETWEEN  '" + model.EnterFactoryDate1 + "' and '" + model.EnterFactoryDate2 + "' ");
            strSql.Append("and 丝厂 = '" + model.Producer + "' ");
            strSql.Append("and 型号 = '" + model.Type + "' ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }

    }
}
