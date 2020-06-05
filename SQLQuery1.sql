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

insert into GoodsType values('��װ')
insert into GoodsType values('�ٻ�') --12
insert into GoodsType values('�ҷ�')
insert into GoodsType values('��Ʒ')
insert into GoodsType values('�Ҿ�') --15
insert into GoodsType values('�˶�')
insert into GoodsType values('ҽҩ')
insert into GoodsType values('����') --18

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
	--GoodsIIImg          varchar(max),     --ͼƬ
	GoodsSize           bit,              --��Ʒ���  ��Ҫ���/����Ҫ���
	--GoodsPrice        money,            ԭ��
	GoodsJifen          int,              --���ͻ���1
	GoodsIntroductory   varchar(500),     --��Ʒ���
	GoodsSend           int,              --��Ʒ���� 
	GoodsSale           bit,              --��Ʒ�ۺ�    7���������˻�
	GoodsBuyStock       bit,              --������    ������¼����
	GodsOnTimes         int,              --�ϼ�ʱ��    1�����ϼ�   2��ʱ�ϼ�   3������
)	
insert into Goods values('Ǯ��','3','59.35','35205','1','1','200','200','1','Ů���۵�ѧ���ɰ�����title','1','20','�ɿɰ�����һ��Ůʿѧ������������ۺ������','1','1','1','1')
insert into Goods values('ñ��','1','79.88','15470','0','2','200','200','1','���ñŮʿ�ﶬ����ٴ�ë�߿���','0','20','�ٴ�ñ�ӣ�ʱ�м���','1','1','1','1')
insert into Goods values('Ǯ��','3','59.35','35205','1','1','200','200','1','Ů���۵�ѧ���ɰ�����title','1','20','�ɿɰ�����һ��Ůʿѧ������������ۺ������','1','1','1','1')
insert into Goods values('ñ��','1','79.88','15470','0','2','200','200','1','���ñŮʿ�ﶬ����ٴ�ë�߿���','0','20','�ٴ�ñ�ӣ�ʱ�м���','1','1','1','1')


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
