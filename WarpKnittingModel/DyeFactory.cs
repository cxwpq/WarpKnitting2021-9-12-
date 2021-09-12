using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarpKnitting.Model
{
    public class DyeFactory
    {
        public Int32 ID { get; set; }
        public string DyeFactoryName { get; set; }
        public string Customer { get; set; }
        public DateTime OutFactoryDate { get; set; }
        public string Type { get; set; }
        public string G_Weight { get; set; }
        public float Weight { get; set; }
        public float Price { get; set; }
        public decimal Amount { get; set; }
        public string OrderNumber { get; set; }
        public string ContainerNumber { get; set; }
    }

    public class DyeFactoryQuery
    {
        public Int32 ID { get; set; }
        public DateTime EnterFactoryDate1 { get; set; }
        public DateTime EnterFactoryDate2 { get; set; }
        public string DyeFactoryName { get; set; }
        public string Type { get; set; }
        public string ContainerNumber { get; set; }
        public string Customer { get; set; }
    }
}
//CREATE TABLE DyeFactory (Id int IDENTITY(1, 1) PRIMARY KEY not null,染厂名称 nvarchar(20), 出厂日期 Date,型号 nvarchar(10),克重 nvarchar(8),重量 float,单价 decimal(7, 2),金额 decimal(14, 2),客户 nvarchar(20),单号 nvarchar(20),装箱号 nvarchar(20))

