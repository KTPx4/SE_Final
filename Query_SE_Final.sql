Create database SE_Final

go

use SE_Final

go
Create table Goods
(
	GoodsID varchar(10) Primary Key,
	GoodsName varchar(50),
	Unit varchar(50),
	Quan int,
	Price money,
	Country varchar(100)
)
go
Create table Agent
(
	AgentID varchar(10) Primary Key,
	AgentName varchar(50),
	Phone varchar(10),
	Address varchar(50),
	Users varchar(50),
	Pass varchar(50)

)
go
Create table Accountant
(
	AID varchar(10) Primary Key,
	AName varchar(50),
	Auser varchar(50),
	Apass varchar(50)
)
go
Create table Payment
(
	PaymentID varchar(10) Primary Key,
	Name varchar(50)
)
go
Create table Supplier
(
	SupID varchar(10) Primary Key, 
	Name varchar(50), 
	Address varchar(100), 
	Phone varchar(10)
)
go
Create table [Order]
(
	OrderID varchar(10) Primary Key, 
	AgentID varchar(10),
	date date, 
	Payment varchar(10), 
	TotalAmount Money,

	CONSTRAINT FK_O_A FOREIGN KEY (AgentID)
    REFERENCES Agent(AgentID),

	CONSTRAINT FK_O_P FOREIGN KEY (Payment)
    REFERENCES Payment(PaymentID),

)
go
Create table OrderDetail
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
Create table PaymentDetail
(
	PDID varchar(10) Primary Key,
	OrderID varchar(10),
	Status varchar(10),
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
	OrderID varchar(10),
	Employee varchar(10), 
	DeliveryDate date, 
	Status varchar(10),
	FOREIGN KEY (OrderID) REFERENCES  [Order](OrderID),
	FOREIGN KEY (Employee) REFERENCES Accountant(AID)
)

