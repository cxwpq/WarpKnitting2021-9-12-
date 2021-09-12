using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarpKnitting.Model
{
    public class Enterbound
    {
        public Int32 ID { get; set; }
        public string Producer { get; set; }
        public DateTime EnterFactoryDate { get; set; }
        public string Type { get; set; }
        public string G_Weight { get; set; }
        public float Weight { get; set; }
        public float Price { get; set; }
        public decimal Amount { get; set; }
        public string OrderNumber { get; set; }
        public string ContainerNumber { get; set; }
    }

    public class boundQuery
    {
        public Int32 ID { get; set; }
        public DateTime EnterFactoryDate1 { get; set; }
        public DateTime EnterFactoryDate2 { get; set; }
        public string Type { get; set; }
        public string Producer { get; set; }
    }

}
//CREATE TABLE EnterBound (Id int IDENTITY(1, 1) PRIMARY KEY not null, 入厂日期 Date,型号 nchar(10),重量 float,单价 decimal(7, 2),金额 decimal(14, 2) ,生产商 nchar(20))
