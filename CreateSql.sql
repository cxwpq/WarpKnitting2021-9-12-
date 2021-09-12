use Weixing

CREATE TABLE Customer (Id int IDENTITY(1, 1) PRIMARY KEY not null, ���� nvarchar(20),��ַ nvarchar(50),��� nvarchar(20))

CREATE TABLE Product (Id int IDENTITY(1, 1) PRIMARY KEY not null, �ͺ� nvarchar(20),���� nvarchar(20),��Ӧ�ͺ� nvarchar(20))

CREATE TABLE EnterBound (Id int IDENTITY(1, 1) PRIMARY KEY not null, ˿�� nvarchar(20),�������� Date,�ͺ� nvarchar(20),���� int,���� decimal(14, 2),���� decimal(8, 2),
��� decimal(14, 2) ,���� nvarchar(20),����int)

CREATE TABLE OutBound (Id int IDENTITY(1, 1) PRIMARY KEY not null, ���� nvarchar(20),�������� Date,�ͺ� nvarchar(20),���� decimal(14, 2),���� decimal(8, 2),
��� decimal(14, 2) ,�ͻ����� nvarchar(20),ƥ�� int, Ⱦ�� nvarchar(20),����int)

CREATE TABLE DyeEnterBound (Id int IDENTITY(1, 1) PRIMARY KEY not null, Ⱦ�� nvarchar(20),�������� Date,�ͺ� nvarchar(20),���� int,���� decimal(14, 2) ,
ƥ�� int,��� int,���� nvarchar(20),����int) 

CREATE TABLE DyeOutBound (Id int IDENTITY(1, 1) PRIMARY KEY not null, Ⱦ�� nvarchar(20),�������� Date,�ͺ� nvarchar(20),���� int,Ⱦ������ decimal(14, 2),���� decimal(8, 2),
��� decimal(14, 2) ,ƥ�� int,��� int,�ͻ����� nvarchar(20),����int)
