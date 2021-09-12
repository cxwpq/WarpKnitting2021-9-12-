using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarpKnitting.Model
{
    public class Outbound
    {
        public Int32 ID { get; set; }
        public string OutFactoryObject { get; set; }
        public DateTime OutFactoryDate { get; set; }
        public string Type { get; set; }
        public string G_Weight { get; set; }
        public float Weight { get; set; }
        public float Price { get; set; }
        public decimal Amount { get; set; }
        public string OrderNumber { get; set; }
        public string ContainerNumber { get; set; }
    }
}
//CREATE TABLE OutBound (Id int IDENTITY(1, 1) PRIMARY KEY not null, 出厂日期 Date,型号 nchar(10),克重 nchar(8),重量 float,单价 decimal(7, 2),金额 decimal(14, 2),出厂对象 nchar(20),单号 nchar(20),柜号 nchar(20))
