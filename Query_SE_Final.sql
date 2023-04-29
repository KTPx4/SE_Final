Create database SE_Final

go
--drop database SE_Final
use SE_Final

go
Create table Goods
(
	GoodsID varchar(10) Primary Key,
	GoodsName varchar(50),
	Unit varchar(50),
	Price money,
	Country varchar(100)   ,
	is_deleted bit	  -- new update
)
go
Create table Warehouse
(
	
	GoodsID varchar(10) ,
	Quan int,
	FOREIGN KEY (GoodsID) REFERENCES Goods(GoodsID)
)
go
Create table Agent
(
	AgentID varchar(10) Primary Key,
	AgentName varchar(50),
	Phone varchar(10),
	Address varchar(50),
	Users varchar(50) Unique,
	Pass varchar(50)	,
	is_deleted bit	  -- new update
)
go
Create table Accountant
(
	AID varchar(10) Primary Key,
	AName varchar(50),
	Auser varchar(50) Unique,
	Apass varchar(50)		  ,
	is_deleted bit	  -- new update
)
go
Create table Payment
(
	PaymentID varchar(10) Primary Key,
	Name varchar(50)	 ,
	is_deleted bit	  -- new update
)
go
Create table Supplier
(
	SupID varchar(10) Primary Key, 
	Name varchar(50), 
	Address varchar(100), 
	Phone varchar(10)	  ,
	is_deleted bit	  -- new update
)
go
Create table [Order]	 -- insert row at webform
(
	OrderID varchar(10) Primary Key, 
	AgentID varchar(10),
	Odate date, 
	PaymentID varchar(10), 
	TotalAmount Money,

	is_Hide bit	   -- new update

	CONSTRAINT FK_O_A FOREIGN KEY (AgentID)
    REFERENCES Agent(AgentID),

	CONSTRAINT FK_O_P FOREIGN KEY (PaymentID)
    REFERENCES Payment(PaymentID),

)
go
Create table OrderDetail	 -- insert row at webform
( 
	DetailID varchar(10) Primary Key, 
	OrderID varchar(10), 
	GoodsID varchar(10), 
	Quantity int,

	CONSTRAINT FK_OD_O FOREIGN KEY (OrderID)
    REFERENCES [Order](OrderID),

	CONSTRAINT FK_OD_G FOREIGN KEY (GoodsID)
    REFERENCES Goods(GoodsID),
)

go
Create table PaymentDetail	  -- insert row at webform
(
	PDID varchar(10) Primary Key,
	OrderID varchar(10) Unique,
	Status int, -- 0 for waiting, 1 for success , -1 for failed
	
	FOREIGN KEY (OrderID) REFERENCES [Order](OrderID)
)
go
Create table GoodsReceipt 
(
	ReceiptID varchar(10) Primary Key,  
	ReceiptDate date, 
	SupID varchar(10), 
	Employee varchar(10),
	TotalAmount money,
	FOREIGN KEY (SupID) REFERENCES Supplier(SupID),
	FOREIGN KEY (Employee) REFERENCES Accountant(AID)
)
go
Create table GoodsReceiptDetail 
(
	RDID varchar(10) Primary Key, 
	ReceiptID varchar(10), 
	GoodsID varchar(10) , 
	Quan int, 
	Amount money,
	FOREIGN KEY (ReceiptID) REFERENCES GoodsReceipt(ReceiptID),
	FOREIGN KEY (GoodsID) REFERENCES Goods(GoodsID)
)
go

Create table GoodsDelivery
(
	DeliveryID varchar(10) Primary Key, 
	OrderID varchar(10) Unique,
	Employee varchar(10), 
	DeliveryDate date, 
	Status int, -- 0 for is waiting delivery, 1 success, -1 for failed

	FOREIGN KEY (OrderID) REFERENCES  [Order](OrderID),
	FOREIGN KEY (Employee) REFERENCES Accountant(AID)
)

go
Create table AdminSystem
(
	AdminID varchar(10),
	users varchar(50),
	pass varchar(50) ,
	name varchar(100)
)
go
Insert into AdminSystem values
	('admin01', 'admin', '12345', 'ADMIN SYSTEM')
go
insert into Goods values
	('G0001', 'Iphone 6', 'one', 1000, 'USA', 0),
	('G0002', 'Iphone 7', 'one', 1500, 'USA', 0),
	('G0003', 'Iphone 8', 'one', 1700, 'USA', 0),
	('G0004', 'Iphone 9', 'one', 1800, 'USA', 0),
	('G0005', 'Iphone 10', 'one', 2000, 'USA', 0),
	('G0006', 'Iphone 11', 'one', 1500, 'USA', 0),
	('G0007', 'Iphone 12', 'one', 3000, 'USA', 0),
	('G0008', 'SamSung XS', 'one', 1200, 'Kore', 0),
	('G0009', 'Redmi not 8', 'one', 1100, 'China', 0),
	('G0010', 'Redmi not 9', 'one', 2300, 'China', 0),
	('G0011', 'Redmi not 10', 'one', 2500, 'China', 0),
	('G0012', 'Redmi not 11', 'one', 2200, 'China', 0),
	('G0013', 'Xiaomi Pocolo 11', 'one', 2200, 'China', 0),
	('G0014', 'SamSung Note 9', 'one', 2400, 'India', 0),
	('G0015', 'SamSung J2 Pro', 'one', 1200, 'Thailands', 0)

go
insert into Warehouse values
	('G0001', 4),
	('G0002', 1),
	('G0003', 6),
	('G0004', 7),
	('G0005', 3),
	('G0006', 8),
	('G0007', 2),
	('G0008', 9),
	('G0009', 12),
	('G0010', 35),
	('G0011', 11),
	('G0012', 12),
	('G0013', 14),
	('G0014', 32),
	('G0015', 11)	
	
go

Insert into Accountant values
	('A0001', 'Joinh William', 'Join12', '12345', 0),
	('A0002', 'Kio Charles', 'kio', '12345', 0),
	('A0003', 'Lio Smith', 'lio', '12345', 0),
	('A0004', 'Kevin Nguyen', 'kevin12', '12345', 0),
	('A0005', 'Luxi M', 'luxix', '12345', 0),
	('A0006', 'Luffy Monkey D', 'luffyy', '12345', 0),
	('A0007', 'Zoro Chiro', 'zoroo', '12345', 0),
	('A0008', 'Usop Gods', 'Udau', '12345', 0),
	('A0009', 'Choper Meem', 'chopercute', '13345', 0),
	('A0010', 'Nami William', 'nami111', '12345', 0),
	('A0011', 'Sanji Vinsmoke', 'sj123', '12345', 0),
	('A0012', 'Kaido Dilo', 'kaido', '123345', 0),
	('A0013', 'Dragon Monkey D', 'dragon', '14345', 0),
	('A0014', 'Grap MD', 'MDGrap', '11111', 0),
	('A0015', 'Admin', 'admin', '12345', 0)
go

insert into Agent values
	('AG0001', 'Shop Kaio', '0901010111', '123, abc, USA', 'shopkaio', '12345', 0),
	('AG0002', 'Shop Gao', '0905410111', '123, abc, USA', 'gao123', '12345', 0),
	('AG0003', 'Shop Laya', '0950032451', '123, abc, USA', 'lay111', '12345', 0),
	('AG0004', 'Shop Hayo', '0914455115', '123, abc, USA', 'hayoo', '12345', 0),
	('AG0005', 'Shop Youuu', '090645212', '123, abc, USA', 'yuu1', '12345', 0),
	('AG0006', 'Shop Laika', '095423131', '123, abc, USA', 'laikaka', '12345', 0),
	('AG0007', 'Shop Jika', '0944342113', '123, abc, USA', 'jikala', '12345', 0),
	('AG0008', 'Shop Hio', '0900101114', '123, abc, USA', 'hiooo', '12345', 0),
	('AG0009', 'Shop Alio', '0900010111', '123, abc, USA', 'aliio', '12345', 0),
	('AG0010', 'Shop Libabo', '0964010111', '123, abc, USA', 'sliba', '12345', 0),
	('AG0011', 'Shop Laught', '0963610111', '123, abc, USA', 'laughts', '12345', 0),
	('AG0012', 'Shop Tells', '0954929111', '123, abc, USA', 'theo123', '12345', 0),
	('AG0013', 'Shop IT', '0947395729', '123, abc, USA', 'ito11', '12345', 0),
	('AG0014', 'Shop Nisi', '0989034211', '123, abc, USA', 'shopnisi', '12345', 0),
	('AG0015', 'Shop Kawasi', '0988883111', '123, abc, USA', 'kawasi', '12345', 0),
	('AG0016', 'Shop ADMIN', '9999999999', '1234, aaa, VietNam', 'admin', '12345', 0)

Go
Insert into Payment values
	('P0001', 'Payment by Online' , 0),
	('P0002', 'Payment by Cash', 0)

go
Insert into Supplier values
	('S0001', 'Company Alent', '241, Laika, USA', '0101374011', 0),
	('S0002', 'Company Azenka', '111, Qaka, VietNam', '0101936511', 0),
	('S0003', 'Company Erilent', '11, Haka, Thailands', '0186330101', 0),
	('S0004', 'Company Kakalot', '12, Liva, China', '0193657101', 0),
	('S0005', 'Company Hayalot', '141, Nisa, Cambodia', '0101010101', 0),
	('S0006', 'Company Biroshin', '221, Haka, France', '0101010101', 0),
	('S0007', 'Company Ihihi', '411, Ohio, India', '0101010101', 0),
	('S0008', 'Company Ghensin', '911,  hfk,USA', '0101010101', 0),
	('S0009', 'Company Leighi', '521, Shaga, USA', '0101010101', 0),
	('S0010', 'Company Reileiy', '999, Qisa, China', '0101010101', 0),
	('S0011', 'Company Locaco', '183, Loila, Thailand', '0101010101', 0),
	('S0012', 'Company Haido', '981, Nasaa, VietNam', '0101010101', 0)
go

insert into [Order] values
	('O0001', 'AG0001', '2022/09/16', 'P0001', 19000, 0), 
	('O0002', 'AG0002', '2022/08/13', 'P0001', 66900, 0) , 
	('O0003', 'AG0001', '2022/01/18', 'P0001', 76500, 0),
	('O0004', 'AG0001', '2022/07/17', 'P0001', 52500, 0),
	('O0005', 'AG0003', '2022/04/16', 'P0001', 66900, 0),
	('O0006', 'AG0004', '2022/05/22', 'P0002', 27700, 0),
	('O0007', 'AG0003', '2022/05/25', 'P0002', 18900, 0),
	('O0008', 'AG0003', '2022/09/11', 'P0001', 51300, 0)

go

Insert into OrderDetail values
	('OD0001', 'O0001', 'G0001', 5),
	('OD0002', 'O0001', 'G0005', 7),

	('OD0003', 'O0002', 'G0003', 9),
	('OD0004', 'O0002', 'G0004', 12),
	('OD0005', 'O0002', 'G0005', 15),

	('OD0006', 'O0003', 'G0006', 11),
	('OD0007', 'O0003', 'G0007', 20),

	('OD0008', 'O0004', 'G0002', 35),

	('OD0009', 'O0005', 'G0003', 3),
	('OD0010', 'O0005', 'G0005', 6),
	('OD0011', 'O0005', 'G0006', 8),
	('OD0012', 'O0005', 'G0007', 9),
	('OD0013', 'O0005', 'G0008', 9),

	('OD0014', 'O0006', 'G0001', 7),
	('OD0015', 'O0006', 'G0002', 7),
	('OD0016', 'O0006', 'G0003', 6),

	('OD0017', 'O0007', 'G0004', 5),
	('OD0018', 'O0007', 'G0009', 9),

	('OD0019', 'O0008', 'G0010', 9),
	('OD0020', 'O0008', 'G0013', 9),
	('OD0021', 'O0008', 'G0015', 9)


go
Insert into PaymentDetail values
	('PD0001', 'O0001', 0),
	('PD0002', 'O0002', 1),
	('PD0003', 'O0003', -1),
	('PD0004', 'O0004', 0),
	('PD0005', 'O0005', 0),
	('PD0006', 'O0006', 1),
	('PD0007', 'O0007', 1),
	('PD0008', 'O0008', 1)

go

Insert into GoodsDelivery values
	('GD0001', 'O0002', 'A0001', '2023/01/12', 0),	
	('GD0003', 'O0004', 'A0001', '2023/02/12', 0),
	('GD0004', 'O0005', 'A0003', '2023/03/11', 1),
	('GD0005', 'O0006', 'A0002', '2023/03/19', 1),
	('GD0006', 'O0007', 'A0004', '2023/04/16', 0),
	('GD0007', 'O0008', 'A0006', '2023/05/21', 1)

go

Insert Into GoodsReceipt values
	('GR0001', '2023/04/25', 'S0001', 'A0001', 17500),
	('GR0002', '2023/05/24', 'S0002', 'A0001', 27300),
	('GR0003', '2023/05/23', 'S0003', 'A0003', 12000),
	('GR0004', '2023/06/22', 'S0002', 'A0002', 33000),
	('GR0005', '2023/07/19', 'S0007', 'A0004', 33000),
	('GR0006', '2023/08/18', 'S0006', 'A0003', 192300),
	('GR0007', '2023/09/17', 'S0003', 'A0002', 123000)
	
go

Insert into GoodsReceiptDetail values
	('GRD0001', 'GR0001', 'G0001', 3, 3000),
	('GRD0002', 'GR0001', 'G0002', 4, 6000),
	('GRD0003', 'GR0001', 'G0003', 5, 8500),

	('GRD0004', 'GR0002', 'G0001', 3, 3000),
	('GRD0005', 'GR0002', 'G0002', 1, 1500),
	('GRD0006', 'GR0002', 'G0003', 6, 10200),
	('GRD0007', 'GR0002', 'G0004', 7, 12600),

	('GRD0008', 'GR0003', 'G0005', 3, 6000),
	('GRD0009', 'GR0003', 'G0006', 4, 6000),

	('GRD0010', 'GR0004', 'G0007', 3, 9000),
	('GRD0011', 'GR0004', 'G0008', 9, 10800),
	('GRD0012', 'GR0004', 'G0009', 12, 13200),

	('GRD0013', 'GR0005', 'G0001', 15, 15000),
	('GRD0014', 'GR0005', 'G0002', 12, 18000),

	('GRD0015', 'GR0006', 'G0001', 32, 32000),
	('GRD0016', 'GR0006', 'G0002', 31, 46500),
	('GRD0017', 'GR0006', 'G0003', 32, 54400),
	('GRD0018', 'GR0006', 'G0004', 33, 59400),

	('GRD0019', 'GR0007', 'G0001', 23, 23000),
	('GRD0020', 'GR0007', 'G0002', 13, 19500),
	('GRD0021', 'GR0007', 'G0005', 23, 46000),
	('GRD0022', 'GR0007', 'G0006', 23, 34500)	 



go
update Accountant set AName ='kkk' where AID ='A0001'
--select* from goods
--select* from Warehouse

select* from Accountant
select * from agent
select top 1 AgentID from Agent order by AgentID desc	  



select g.GoodsID, g.GoodsName, g.Price, od.Quantity
from orderdetail od, Goods g
where od.OrderID in 
				 (select o.OrderID
					from [order] o, Agent a
					where a.AgentID ='AG0002' and a.AgentID = o.AgentID)
					and od.GoodsID = g.GoodsID


SELECT * FROM Goods WHERE GoodsName LIKE 'samsung xs'
