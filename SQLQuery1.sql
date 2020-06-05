create database E_commerce
go
use E_commerce

create table UserInfo
(
	Id int primary key identity,
	Uname  varchar(500),     --账号
	RealName   varchar(500),   --真实姓名
	Pass    varchar(5000),    --密码
	Email    varchar(5000),    --电子邮件
	Phone    varchar(5000),    --手机号
)
insert into UserInfo values('admin','顾中豪','000','1427865035@qq.com','15030305695')

select * from UserInfo
select *  from select *  from TiXian
insert into TiXian values(getdate())
select *  from TiXian
drop table Wallet


create table Wallet
(
Id int identity primary key,
yueMoney decimal,
dayMoney decimal,
dayModeryZc decimal,
leijishouru decimal,
leijizhichu decimal
)
insert into Wallet values(500000.21,54877.2,5864.1,8745.4,8745.5)
create  table  TiXian
(
Id int identity primary key,
Data varchar(80),
jine decimal,
Zt varchar(80)
)