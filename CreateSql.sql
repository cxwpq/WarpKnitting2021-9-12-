use Weixing

CREATE TABLE Customer (Id int IDENTITY(1, 1) PRIMARY KEY not null, 名称 nvarchar(20),地址 nvarchar(50),类别 nvarchar(20))

CREATE TABLE Product (Id int IDENTITY(1, 1) PRIMARY KEY not null, 型号 nvarchar(20),属性 nvarchar(20),对应型号 nvarchar(20))

CREATE TABLE EnterBound (Id int IDENTITY(1, 1) PRIMARY KEY not null, 丝厂 nvarchar(20),进厂日期 Date,型号 nvarchar(20),包数 int,重量 decimal(14, 2),单价 decimal(8, 2),
金额 decimal(14, 2) ,名称 nvarchar(20),单号int)

CREATE TABLE OutBound (Id int IDENTITY(1, 1) PRIMARY KEY not null, 名称 nvarchar(20),出厂日期 Date,型号 nvarchar(20),重量 decimal(14, 2),单价 decimal(8, 2),
金额 decimal(14, 2) ,客户名称 nvarchar(20),匹数 int, 染厂 nvarchar(20),单号int)

CREATE TABLE DyeEnterBound (Id int IDENTITY(1, 1) PRIMARY KEY not null, 染厂 nvarchar(20),进厂日期 Date,型号 nvarchar(20),克重 int,重量 decimal(14, 2) ,
匹数 int,柜号 int,名称 nvarchar(20),单号int) 

CREATE TABLE DyeOutBound (Id int IDENTITY(1, 1) PRIMARY KEY not null, 染厂 nvarchar(20),出厂日期 Date,型号 nvarchar(20),克重 int,染进重量 decimal(14, 2),单价 decimal(8, 2),
金额 decimal(14, 2) ,匹数 int,柜号 int,客户名称 nvarchar(20),单号int)
