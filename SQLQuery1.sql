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

select RealName from UserInfo where Uname = 'admin'

drop table UserInfo
