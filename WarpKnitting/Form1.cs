using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarpKnitting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 买丝入库(object sender, EventArgs e)
        {
            BLL.Customer Customer = new BLL.Customer();
            BLL.Product Product = new BLL.Product();
            List<string> MyList1 = new List<string>();
            List<string> MyList2 = new List<string>();
            List<string> MyList3 = new List<string>();
            MyList1 = Product.MyList("型号", "加弹丝");//读原丝的型号r
            MyList2 = Customer.MyList_NoAll("名称", "丝厂");//读卖方的名称
            MyList3 = Customer.MyList_NoAll("名称", "布厂");//读卖方的名称
            FormEnterbound formEnterbound = new FormEnterbound(MyList1, MyList2,MyList3);
            formEnterbound.ShowDialog();
        }

        private void 卖白坯布出厂(object sender, EventArgs e)
        {

            FormOutbound formOutbound = new FormOutbound();
            formOutbound.ShowDialog();
        }

        private void 货交染厂出厂(object sender, EventArgs e)
        {
            FormOutboundDye formDyeOutbound = new FormOutboundDye();
            formDyeOutbound.ShowDialog();
        }

        private void 本厂查询(object sender, EventArgs e)
        {
            FormQuerycs form2Querycs = new FormQuerycs();
            form2Querycs.ShowDialog();
        }

        private void 染厂出库(object sender, EventArgs e)
        {
            FormDyeOutbound formDyeOutbound = new FormDyeOutbound();
            formDyeOutbound.ShowDialog();
        }

        private void 染厂查询(object sender, EventArgs e)
        {
            FormDyeQuerycs formDyeQuerycs = new FormDyeQuerycs();
            formDyeQuerycs.ShowDialog();
        }

        private void 客户(object sender, EventArgs e)
        {
            string[] temArr = { "丝厂", "加弹厂", "布厂", "染厂", "买方" };
            List<string> MyList1 = new List<string>(temArr);
            FormCustomer formCustomer = new FormCustomer(MyList1);
            formCustomer.ShowDialog();
        }

        private void 常用型号(object sender, EventArgs e)
        {
            string[] temArr = { "原丝", "加弹丝", "白坯布", "色布" };
            List<string> MyList1 = new List<string>(temArr);
            FormProduct formXinghao = new FormProduct(MyList1);
            formXinghao.ShowDialog();
        }
    }
}
