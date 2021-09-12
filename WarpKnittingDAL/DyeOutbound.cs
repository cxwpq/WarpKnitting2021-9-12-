using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WarpKnitting.Model;

namespace WarpKnitting.DAL
{
    public class DyeOutbound
    {
        public DataSet DataSet1(Int32 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM ( ");
            strSql.Append("select top 30 * ");
            strSql.Append("FROM DyeOutbound ");
            //strSql.Append("where " + SQLString + " = 1 ");
            strSql.Append("order by ID desc");
            strSql.Append(") TAL ORDER BY ID");
            return DbHelperOleDb.ExecuteDataSet1(strSql.ToString());
        }
        //  SELECT* FROM(SELECT TOP 10 * FROM 表1 ORDER BY 标志ID DESC)TAL ORDER BY 标志ID

        public void UpdateExecuteDataSet1(DataTable mTable)
        {
            DbHelperOleDb.UpdateExecuteDataSet1(mTable);
        }

        public DataSet Query1(DyeFactoryQuery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM Outbound ");
            strSql.Append("where 出厂日期 BETWEEN  '" + model.EnterFactoryDate1 + "' and '" + model.EnterFactoryDate2 + "' ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }

        public DataSet Query2(DyeFactoryQuery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM Outbound ");
            strSql.Append("where 出厂日期 BETWEEN  '" + model.EnterFactoryDate1 + "' and '" + model.EnterFactoryDate2 + "' ");
            strSql.Append("and 型号 = '" + model.Type + "' ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }

        public DataSet Query1A(DyeFactoryQuery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM DyeOutbound ");
            strSql.Append("where 出厂日期 BETWEEN  '" + model.EnterFactoryDate1 + "' and '" + model.EnterFactoryDate2 + "' ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }

        public DataSet Query2A(DyeFactoryQuery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM DyeOutbound ");
            strSql.Append("where 出厂日期 BETWEEN  '" + model.EnterFactoryDate1 + "' and '" + model.EnterFactoryDate2 + "' ");
            strSql.Append("and 客户名称 = '" + model.Customer + "' ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }

        public DataSet Query3(DyeFactoryQuery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM DyeOutbound ");
            strSql.Append("where 出厂日期 BETWEEN  '" + model.EnterFactoryDate1 + "' and '" + model.EnterFactoryDate2 + "' ");
            strSql.Append("and 染厂 = '" + model.DyeFactoryName + "' ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }

        public DataSet Query4(DyeFactoryQuery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("FROM DyeOutbound ");
            strSql.Append("where 出厂日期 BETWEEN  '" + model.EnterFactoryDate1 + "' and '" + model.EnterFactoryDate2 + "' ");
            strSql.Append("and 染厂 = '" + model.DyeFactoryName + "' ");
            strSql.Append("and 客户名称 = '" + model.Customer + "' ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }

        public DataSet Query7(Int32 i)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,柜号,染厂,进厂日期,型号,克重,重量,匹数 ");
            strSql.Append("FROM DyeEnterBound ");
            strSql.Append("where 柜号 = " + i + " ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }

        public DataSet Query8(Int32 i)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,柜号,染厂,客户名称,出厂日期,型号,克重,染后重量,单价,金额,匹数 ");
            strSql.Append("FROM DyeOutBound ");
            strSql.Append("where 柜号 = " + i + " ");
            strSql.Append("order by ID");
            return DbHelperOleDb.Query(strSql.ToString());
        }
    }
}

