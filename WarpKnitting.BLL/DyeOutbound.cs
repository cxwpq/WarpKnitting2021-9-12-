using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WarpKnitting.Model;

namespace WarpKnitting.BLL
{
    public class DyeOutbound
    {
        DAL.DyeOutbound DAL = new DAL.DyeOutbound();

        public DataSet DataSet1(Int32 T)
        {
            return DAL.DataSet1(T);
        }

        public void UpdateExecuteDataSet1(DataTable mTable)
        {
            DAL.UpdateExecuteDataSet1(mTable);
        }

        public DataSet Query1(DyeFactoryQuery model)
        {
            if (model.DyeFactoryName == "全部")
            {
                return DAL.Query1(model);
            }
            else
            {
                return DAL.Query2(model);
            }
        }

        public DataSet Query2(DyeFactoryQuery model)
        {
            if (model.DyeFactoryName == "全部")
            {
                return (model.Customer == "全部") ? DAL.Query1A(model) : DAL.Query2A(model);
            }
            else
            {
                return (model.Customer == "全部") ? DAL.Query3(model) : DAL.Query4(model);
            }
        }

        public DataTable Query3(DyeFactoryQuery model)
        {
            DataTable dt = dataTableAddColumn();
            DataTable dt1, dt2;
            DataRow drNem1, drNem2;
            Int32 i = Convert.ToInt32(model.DyeFactoryName);
            Int32 j = Convert.ToInt32(model.Customer);

            if (i > 0 && j > 0)
            {
                for (int k = i; k <= j; k++)
                {
                    Double Weight1 = 0;
                    Double piNumber1 = 0;
                    dt1 = DAL.Query7(k).Tables[0];
                    Int32 n = dt1.Columns.Count;
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        drNem1 = dt.NewRow();
                        for (int m = 1; m < n; m++)
                        {
                            drNem1[m] = dr1[m];
                        }
                        dt.Rows.Add(drNem1);
                        if (dr1["匹数"] != DBNull.Value) piNumber1 += Convert.ToDouble(dr1["匹数"]);
                        if (dr1["重量"] != DBNull.Value) Weight1 += Convert.ToDouble(dr1["重量"]);
                    }

                    Double piNumber2 = 0, Weight2 = 0, Amount2 = 0;
                    dt2 = DAL.Query8(k).Tables[0];
                    Int32 n1 = dt2.Columns.Count;
                    foreach (DataRow dr2 in dt2.Rows)
                    {
                        drNem2 = dt.NewRow();
                        for (int m = 1; m < n1; m++)
                        {
                            drNem2[m + n] = dr2[m];
                        }
                        dt.Rows.Add(drNem2);
                        if (dr2["匹数"] != DBNull.Value) piNumber2 += Convert.ToDouble(dr2["匹数"]);
                        if (dr2["染后重量"] != DBNull.Value) Weight2 += Convert.ToDouble(dr2["染后重量"]);
                        if (dr2["金额"] != DBNull.Value) Amount2 += Convert.ToDouble(dr2["金额"]);
                    }

                    if (dt1.Rows.Count > 0 || (dt2.Rows.Count > 0))
                    {
                        drNem1 = dt.NewRow();
                        drNem1["柜号"] = "合计";
                        drNem1["匹数"] = Weight1;
                        drNem1["匹数 "] = Weight2;
                        drNem1["重量"] = Weight1;
                        drNem1["染后重量"] = Weight2;
                        drNem1["金额"] = Amount2;
                        dt.Rows.Add(drNem1);
                    }
                }
            }
            return dt;
        }

        DataTable dataTableAddColumn()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("柜号", typeof(String));
            dt.Columns.Add("染厂", typeof(String));
            dt.Columns.Add("出本厂日期", typeof(DateTime));
            dt.Columns.Add("型号", typeof(String));
            dt.Columns.Add("克重", typeof(String));
            dt.Columns.Add("匹数", typeof(Int32));
            dt.Columns.Add("重量", typeof(float));
            dt.Columns.Add("单号", typeof(String));
            dt.Columns.Add("  ", typeof(String));
            dt.Columns.Add("柜号 ", typeof(String));
            dt.Columns.Add("染厂名称", typeof(String));
            dt.Columns.Add("买方", typeof(String));
            dt.Columns.Add("出染厂日期", typeof(DateTime));
            dt.Columns.Add("型号 ", typeof(String));
            dt.Columns.Add("克重 ", typeof(String));
            dt.Columns.Add("匹数 ", typeof(Int32));
            dt.Columns.Add("染后重量", typeof(float));
            dt.Columns.Add("单价", typeof(float));
            dt.Columns.Add("金额", typeof(Decimal));
            dt.Columns.Add("染后单号", typeof(String));
            return dt;
        }
    }
}
