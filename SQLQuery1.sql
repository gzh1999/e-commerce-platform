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

select * from UserInfo where Uname = 'admin'

create table GoodsType
(
	Id            int primary key identity,
	TypeName      varchar(500),      --��������
)
insert into GoodsType values('Ůװ')
insert into GoodsType values('��װ')
insert into GoodsType values('Ь��')--3
insert into GoodsType values('ʳƷ')
insert into GoodsType values('����')
insert into GoodsType values('�ֻ�')
insert into GoodsType values('����')
insert into GoodsType values('����')--8
insert into GoodsType values('��ױ')
insert into GoodsType values('ĸӤ')



create table GoodsKind
(
	Id            int primary key identity,
	KindName      varchar(500),      --��������
)
insert into GoodsKind values('��ͨ��Ʒ'),('��TA����Ʒ'),('��ͨ/��TA����Ʒ')

create table GoodsSend
(
	Id            int primary key identity,
	SendName      varchar(500),      --�������
)
insert into GoodsSend values('Բͨ'),('����'),('��ͨ'),('�ϴ�'),('˳��')

create table Goods
(
	Id                  int  primary key identity,
	GoodsName           varchar(500),     --����
	GoodssType          int,              --����
	GoodsPrice          money,            --����
	GoodsSalesvolume    int,              --������11111111111111111111111111111111111111111111111
	GoodsOnStatus       bit,              --״̬�ϼ��¼� 111111111111111111111111111111111111111111111
	GoodsAuditStatus    int,              --���״̬    1���ͨ��    2���δͨ��  3����� 11111111111111111111111111
	GoodsStock          int,              --���  
	
	GoodsSum			int,			  --���� 111111111111111111
	--GoodssType        varchar(500),     ����  
	GoodsKind           int,              --���� ��ͨ��Ʒ
	--GoodsName         varchar(500),     ����
	GoodsTitle          varchar(500),     --����
	GoodsIIImg          varchar(max),     --ͼƬ
	GoodsSize           bit,              --��Ʒ���  ��Ҫ���/����Ҫ���
	--GoodsPrice        money,            ԭ��
	GoodsJifen          int,              --���ͻ���1
	GoodsIntroductory   varchar(500),     --��Ʒ���
	GoodsSend           int,              --��Ʒ���� 
	GoodsSale           bit,              --��Ʒ�ۺ�    7���������˻�
	GoodsBuyStock       bit,              --������    ������¼����
	GodsOnTimes         int,              --�ϼ�ʱ��    1�����ϼ�   2��ʱ�ϼ�   3������

)	
insert into Goods values('Ǯ��','3','59.35','35205','1','1','200','200','1','Ů���۵�ѧ���ɰ�����title','/imges/01.jpg','1','20','�ɿɰ�����һ��Ůʿѧ������������ۺ������','1','1','1','1')
insert into Goods values('ñ��','1','79.88','15470','0','2','200','200','1','���ñŮʿ�ﶬ����ٴ�ë�߿���','/imges/01.jpg','0','20','�ٴ�ñ�ӣ�ʱ�м���','1','1','1','1')
insert into Goods values('Ǯ��','3','59.35','35205','1','1','200','200','1','Ů���۵�ѧ���ɰ�����title','/imges/01.jpg','1','20','�ɿɰ�����һ��Ůʿѧ������������ۺ������','1','1','1','1')
insert into Goods values('ñ��','1','79.88','15470','0','2','200','200','1','���ñŮʿ�ﶬ����ٴ�ë�߿���','/imges/01.jpg','0','20','�ٴ�ñ�ӣ�ʱ�м���','1','1','1','1')


select * from Goods

select * from GoodsType



------------------����ҫ���� 
create table Wallet  --Ǯ��
(
Id int identity primary key,
yueMoney decimal,
dayMoney decimal,
dayModeryZc decimal,
leijishouru decimal,
leijizhichu decimal,
)

insert into Wallet values(985870,78548,78954,45785,12548)
select s.Id,s.yueMoney,s.dayMoney,s.dayModeryZc,s.leijishouru,s.leijizhichu from Wallet s


create table TiXian  --���ּ�¼��
(
Id		int identity primary key,
Data	varchar(50),
jine	decimal,
Zt		varchar(50),
)


-----------------------���ں�����
create table Users
(
	Id    int primary key identity,
	Name  varchar(20),--�û�����
	Mobile varchar(20),--�ֻ���
	Usite	varchar(50)  --��ǰ��ַ
)
insert into Users values('���պ�','17530191302','����ʡ������������')

select * from Users

create table Consignee(
	ConsigneeId	 int primary key identity,	-- �ջ�������
	ConName		varchar(20),	--�ջ�������
	ConMobile	varchar(20),	--�ֻ���
	Consite		varchar(50),	--�ջ���ַ
	postcode	varchar(10)		--�ʱ��
)	
insert into Consignee values('�ſ���','17530191302','����ʡ֣�����������Լ�ׯ��ί��','00000')

select * from Consignee
create table Orders
(
	OrdersId	int primary key identity,	-- ��������
	numberId	int ,						--�������
	GoodsId		int , -- ��Ʒ���
	consigneeId	int , -- �ջ������
	UsersId		int , -- �û����
	States		int check(States>0 and States<5) default(1),--1��������  2���ѷ��� 3������� 4���ѹر�
	StartTime		dateTime,   --����ʱ��
	EndTime			dateTime,   --����ʱ��
	Payment			int check(Payment>0 and Payment<2) default(1),	--֧����ʽ  1��֧����  2�����п�
	logistics		int	check(logistics>0 and logistics<5) default(1),--������˾ 1��Բͨ 2������ 3����ͨ 4���ϴ� 5��˳��
)
   
insert into Orders values(033322,3,1,1,1,'2020-5-21','2020-5-21',1,1)	   
insert into Orders values(033322,4,1,1,2,'2020-5-21','2020-5-21',1,1)	
insert into Orders values(033322,3,1,1,3,'2020-5-21','2020-5-21',1,1)

	   
insert into Orders values(033322,4,1,1,4,'2020-5-21','2020-5-21',1,1)	

insert into Orders values(033322,3,1,1,4,'2020-5-21','2020-5-21',1,1)	   
insert into Orders values(033322,4,1,1,3,'2020-5-21','2020-5-21',1,1)	   
select * from Orders

drop table Orders



