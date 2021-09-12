using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarpKnitting.Model
{
    public class Customer
    {
        public Int32 ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string OrganizationCode  { get; set; }
        public bool Sellers { get; set; }
        public bool Buyer { get; set; }
        public bool DyeFactory { get; set; }
        public string PersonInCharge { get; set; }
        public string Linkman { get; set; }
        public string Intermediary { get; set; }
        public string Dianghuan { get; set; }
    }
}

//CREATE TABLE Customer(Id int IDENTITY(1, 1) PRIMARY KEY not null, 名称 nvarchar(20),地址 nvarchar(50),机构代码 nvarchar(20),卖方 bit, 买方 bit,染厂 bit, 负责人 nvarchar(20),联系人 nvarchar(10),中间人 nvarchar(20))