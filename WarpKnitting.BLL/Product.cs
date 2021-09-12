using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WarpKnitting.BLL
{
    public class Product
    {
        DAL.Product DAL = new DAL.Product();

        public DataSet DataSet1()
        {
            return DAL.DataSet1();
        }

        public void UpdateExecuteDataSet1(DataTable mTable)
        {
            DAL.UpdateExecuteDataSet1(mTable);
        }

        public List<string> MyList(string xinghao, string attribute)
        {
            List<string> MyList = new List<string>();
            DataTable dt = DAL.DataSet1(attribute).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MyList.Add(dt.Rows[i][xinghao].ToString());
            }
            MyList.Add("全部");
            return MyList;
        }

        public List<string> MyList_NoAll(string xinghao, string attribute)
        {
            List<string> MyList = new List<string>();
            DataTable dt = DAL.DataSet1(attribute).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MyList.Add(dt.Rows[i][xinghao].ToString());
            }
            return MyList;
        }
    }
}
