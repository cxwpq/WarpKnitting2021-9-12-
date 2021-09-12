using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WarpKnitting.BLL
{
    public class Customer
    {
        DAL.Customer DAL = new DAL.Customer();

        public DataSet DataSet1(string T)
        {
            return DAL.DataSet1(T);
        }

        public DataSet DataSet1( )
        {
            return DAL.DataSet1();
        }

        public void UpdateExecuteDataSet1(DataTable mTable)
        {
            DAL.UpdateExecuteDataSet1( mTable);
        }

        public List<string> MyList(string name ,string Text)
        {
            List<string> MyList = new List<string>();
            DataTable dt = DataSet1(Text).Tables[0]; 
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MyList.Add(dt.Rows[i][name].ToString());
            }
            MyList.Add("全部");
            return MyList;
        }

        public List<string> MyList_NoAll(string name, string Text)
        {
            List<string> MyList = new List<string>();
            DataTable dt = DataSet1(Text).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MyList.Add(dt.Rows[i][name].ToString());
            }
            return MyList;
        }
    }
}
