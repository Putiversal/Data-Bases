USE Sales

IF OBJECT_ID ('dbo.Orders', 'U') IS NOT NULL DROP TABLE dbo.Orders;
CREATE TABLE dbo.Orders (
IdOrder BIGINT IDENTITY(1,1) CONSTRAINT pk_order PRIMARY KEY,
IdCustomer INT NOT NULL,
OrderDate DATE NOT NULL,
ShipDate Date NULL,
PaidDate Date NULL,
[Status] char(1) check ([Status] = 'C' or [Status] = 'P')
);

IF OBJECT_ID ('dbo.Customers', 'U') IS NOT NULL DROP TABLE dbo.Customers;
CREATE TABLE dbo.Customers (
IdCustomer INT IDENTITY(1,1) CONSTRAINT pk_customer PRIMARY KEY,
CompanyName nvarchar (100),
LastName nvarchar (50) NOT NULL,
FirstName nvarchar (50) NOT NULL,
HomeAddress nvarchar (100),
City nvarchar (20),
IndexCode INT,
Phone nvarchar (20),
[E-mail] nvarchar (40)
);

IF OBJECT_ID ('dbo.Products', 'U') IS NOT NULL DROP TABLE dbo.Products;
CREATE TABLE dbo.Products (
IdProduct INT IDENTITY(1,1) CONSTRAINT pk_products PRIMARY KEY,
PrName nvarchar (100) NOT NULL,
PrPrice smallmoney NULL, 
InStock int NULL, 
ReOrder bit NULL,
Description nvarchar (100) NULL
);

IF OBJECT_ID ('dbo.Items', 'U') IS NOT NULL DROP TABLE dbo.Items;
CREATE TABLE dbo.Items (
IdItem INT IDENTITY(1,1) CONSTRAINT pk_items PRIMARY KEY,
IdOrder BIGINT NOT NULL,
IdProduct int NOT NULL, 
Quantity int NOT NULL,
Total int NULL
);


ALTER TABLE dbo.Orders
ADD CONSTRAINT FR_Ord_Cust
	FOREIGN KEY (IdCustomer) REFERENCES Customers (IdCustomer)

ALTER TABLE dbo.Items
ADD CONSTRAINT FR_It_Ord
	FOREIGN KEY (IdOrder) REFERENCES Orders (IdOrder)

ALTER TABLE dbo.Items
ADD CONSTRAINT FR_It_Prod
	FOREIGN KEY (IdProduct) REFERENCES Products (IdProduct)
