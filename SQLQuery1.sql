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

select * from UserInfo where Uname = 'admin'

create table GoodsType
(
	Id            int primary key identity,
	TypeName      varchar(500),      --分类名称
)
insert into GoodsType values('女装')
insert into GoodsType values('男装')
insert into GoodsType values('鞋包')--3
insert into GoodsType values('食品')
insert into GoodsType values('果蔬')
insert into GoodsType values('手机')
insert into GoodsType values('电脑')
insert into GoodsType values('电器')--8
insert into GoodsType values('美妆')
insert into GoodsType values('母婴')



create table GoodsKind
(
	Id            int primary key identity,
	KindName      varchar(500),      --类型名称
)
insert into GoodsKind values('普通商品'),('帮TA付商品'),('普通/帮TA付商品')

create table GoodsSend
(
	Id            int primary key identity,
	SendName      varchar(500),      --快递名称
)
insert into GoodsSend values('圆通'),('百世'),('申通'),('韵达'),('顺丰')

create table Goods
(
	Id                  int  primary key identity,
	GoodsName           varchar(500),     --名称
	GoodssType          int,              --分类
	GoodsPrice          money,            --单价
	GoodsSalesvolume    int,              --销售量11111111111111111111111111111111111111111111111
	GoodsOnStatus       bit,              --状态上架下架 111111111111111111111111111111111111111111111
	GoodsAuditStatus    int,              --审核状态    1审核通过    2审核未通过  3待审核 11111111111111111111111111
	GoodsStock          int,              --库存  
	
	GoodsSum			int,			  --数量 111111111111111111
	--GoodssType        varchar(500),     分类  
	GoodsKind           int,              --类型 普通商品
	--GoodsName         varchar(500),     名称
	GoodsTitle          varchar(500),     --标题
	GoodsIIImg          varchar(max),     --图片
	GoodsSize           bit,              --商品规格  需要规格/不需要规格
	--GoodsPrice        money,            原价
	GoodsJifen          int,              --赠送积分1
	GoodsIntroductory   varchar(500),     --商品简介
	GoodsSend           int,              --商品物流 
	GoodsSale           bit,              --商品售后    7天无理由退换
	GoodsBuyStock       bit,              --库存计数    买家拍下减库存
	GodsOnTimes         int,              --上架时间    1立即上架   2定时上架   3放入库存

)	
insert into Goods values('钱包','3','59.35','35205','1','1','200','200','1','女款折叠学生可爱韩版title','/imges/01.jpg','1','20','可可爱爱的一款女士学生韩版包包，粉红感满满','1','1','1','1')
insert into Goods values('帽子','1','79.88','15470','0','2','200','200','1','渔夫帽女士秋冬韩版百搭毛线裤子','/imges/01.jpg','0','20','百搭帽子，时尚减龄','1','1','1','1')
insert into Goods values('钱包','3','59.35','35205','1','1','200','200','1','女款折叠学生可爱韩版title','/imges/01.jpg','1','20','可可爱爱的一款女士学生韩版包包，粉红感满满','1','1','1','1')
insert into Goods values('帽子','1','79.88','15470','0','2','200','200','1','渔夫帽女士秋冬韩版百搭毛线裤子','/imges/01.jpg','0','20','百搭帽子，时尚减龄','1','1','1','1')


select * from Goods

select * from GoodsType



------------------张铎耀数据 
create table Wallet  --钱包
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


create table TiXian  --提现记录表
(
Id		int identity primary key,
Data	varchar(50),
jine	decimal,
Zt		varchar(50),
)


-----------------------闫亿豪数据
create table Users
(
	Id    int primary key identity,
	Name  varchar(20),--用户姓名
	Mobile varchar(20),--手机号
	Usite	varchar(50)  --当前地址
)
insert into Users values('闫艺豪','17530191302','河南省焦作市修武县')

select * from Users

create table Consignee(
	ConsigneeId	 int primary key identity,	-- 收货表主键
	ConName		varchar(20),	--收货人姓名
	ConMobile	varchar(20),	--手机号
	Consite		varchar(50),	--收货地址
	postcode	varchar(10)		--邮编号
)	
insert into Consignee values('张俊雷','17530191302','河南省郑州市荥阳市赵家庄村委会','00000')

select * from Consignee
create table Orders
(
	OrdersId	int primary key identity,	-- 订单主键
	numberId	int ,						--订单编号
	GoodsId		int , -- 商品外键
	consigneeId	int , -- 收货表外键
	UsersId		int , -- 用户外键
	States		int check(States>0 and States<5) default(1),--1：待发货  2：已发货 3：已完成 4：已关闭
	StartTime		dateTime,   --创建时间
	EndTime			dateTime,   --付款时间
	Payment			int check(Payment>0 and Payment<2) default(1),	--支付方式  1：支付宝  2：银行卡
	logistics		int	check(logistics>0 and logistics<5) default(1),--物流公司 1：圆通 2：百世 3：申通 4：韵达 5：顺丰
)
   
insert into Orders values(033322,3,1,1,1,'2020-5-21','2020-5-21',1,1)	   
insert into Orders values(033322,4,1,1,2,'2020-5-21','2020-5-21',1,1)	
insert into Orders values(033322,3,1,1,3,'2020-5-21','2020-5-21',1,1)

	   
insert into Orders values(033322,4,1,1,4,'2020-5-21','2020-5-21',1,1)	

insert into Orders values(033322,3,1,1,4,'2020-5-21','2020-5-21',1,1)	   
insert into Orders values(033322,4,1,1,3,'2020-5-21','2020-5-21',1,1)	   
select * from Orders

drop table Orders



