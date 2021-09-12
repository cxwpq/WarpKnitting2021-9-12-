using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WarpKnitting.Model;

namespace WarpKnitting.BLL
{
    public class Outbound
    {
        DAL.Outbound DAL = new DAL.Outbound();
        public DataSet DataSet1(Int32 T)
        {
            return DAL.DataSet1(T);
        }

        public void UpdateExecuteDataSet1(DataTable mTable)
        {
            DAL.UpdateExecuteDataSet1(mTable);
        }


        public DataSet Query(boundQuery model)
        {
            if (model.Producer == "全部")
            {
                return (model.Type == "全部") ? DAL.Query1(model) : DAL.Query2(model);
            }
            else
            {
                return (model.Type == "全部") ? DAL.Query3(model) : DAL.Query4(model);
            }
        }


    }
}
