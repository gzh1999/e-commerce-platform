create database E_commerce
go
use E_commerce

create table UserInfo
(
	Id int primary key identity,
	Uname  varchar(500),     --�˺�
	RealName   varchar(500),   --��ʵ����
	Pass    varchar(5000),    --����
	Email    varchar(5000),    --�����ʼ�
	Phone    varchar(5000),    --�ֻ���
)
insert into UserInfo values('admin','���к�','000','1427865035@qq.com','15030305695')

select * from UserInfo where Uname='xrk'
select * from UserInfo where Id=5