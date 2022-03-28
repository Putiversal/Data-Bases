USE lab3;
IF OBJECT_ID('dbo.Orders', 'U') IS NOT NULL DROP TABLE dbo.Orders;
CREATE TABLE dbo.Orders
(
IdOrder INT IDENTITY(1,1) CONSTRAINT pk_order PRIMARY KEY,
IdCustomer INT NOT NULL,
OrderDate DATE NOT NULL,
ShipDate DATE NULL,
PaidDate DATE NULL,
[Status] char(1),
);
IF OBJECT_ID('dbo.Customers', 'U') IS NOT NULL DROP TABLE dbo.Customers;
CREATE TABLE dbo.Customers
(
IdCustomer INT IDENTITY(1,1) CONSTRAINT pk_customer PRIMARY KEY,
CompanyName nvarchar(50) NULL,
LastName nvarchar(50) NOT NULL,
FirstName nvarchar(50) NOT NULL,
Adress nvarchar(100) NULL,
City nvarchar(20) NULL,
IndexCode INT NULL,
Phone nvarchar(11) NULL,
Email nvarchar(30) NULL,
);
IF OBJECT_ID('dbo.Items', 'U') IS NOT NULL DROP TABLE dbo.Items;
CREATE TABLE dbo.Items
(
IdItem INT IDENTITY(1,1) CONSTRAINT pk_item PRIMARY KEY,
IdOrder INT NOT NULL,
IdProduct INT NOT NULL,
Quantity INT NOT NULL,
Total INT NULL,
);
IF OBJECT_ID('dbo.Products', 'U') IS NOT NULL DROP TABLE dbo.Products;
CREATE TABLE dbo.Products
(
IdProduct INT IDENTITY(1,1) CONSTRAINT pk_product PRIMARY KEY,
PrName nvarchar(50) NOT NULL,
PrPrice INT NULL,
InStock INT NULL,
ReOrder INT NULL,
Descript nvarchar(50) NULL,
);

INSERT INTO dbo.Customers(CompanyName, LastName, FirstName, Adress, City, IndexCode, Phone, Email)
VALUES ('Mishutka','Buriy','Michail','Lesovaya Street','Moscow','117544','88005553535','burmich@yandex.ru')
INSERT INTO dbo.Customers(CompanyName, LastName, FirstName, Adress, City, IndexCode, Phone, Email)
VALUES ('Volki','Volkov','Valeriy','Bratskaya Street','Moscow','117555','88879654534','volkval@yandex.ru')
INSERT INTO dbo.Customers(CompanyName, LastName, FirstName, Adress, City, IndexCode, Phone, Email)
VALUES ('Norka','Norkina','Alisa','Chaschoba Street','Tambov','111756','88963456787','LisaNorka@yandex.ru')
INSERT INTO dbo.Customers(CompanyName, LastName, FirstName, Adress, City, IndexCode, Phone, Email)
VALUES ('Hare','Zaytcev','Pavel','Polevaya Street','Tambov','111457','88963456787','zaycev_net@yandex.ru')
INSERT INTO dbo.Customers(CompanyName, LastName, FirstName, Adress, City, IndexCode, Phone, Email)
VALUES ('Burundiki','Oreshkin','Konstantin','Duplo Street','Tambov','114322','89287666543','Givemeorehi@yandex.ru')
INSERT INTO dbo.Customers(CompanyName, LastName, FirstName, Adress, City, IndexCode, Phone, Email)
VALUES ('Listya','Berezov','Anton','Sadovaya Street','Saint Petersburg','116545','89353470929','TreeBereza@yandex.ru')
INSERT INTO dbo.Customers(CompanyName, LastName, FirstName, Adress, City, IndexCode, Phone, Email)
VALUES ('Katushka','Molodaya','Katya','Raduga Street','Saint Petersburg','116546','89353470920','MKatya@yandex.ru')
INSERT INTO dbo.Customers(CompanyName, LastName, FirstName, Adress, City, IndexCode, Phone, Email)
VALUES ('Serebro','Metallov','Sergey','Kamennaya Street','Yaroslavl','116585','89353470976','SilverMetall@yandex.ru')
INSERT INTO dbo.Customers(CompanyName, LastName, FirstName, Adress, City, IndexCode, Phone, Email)
VALUES ('Rabotka','Shirshov','Artyom','Son Street','Tambov','116222','89353470112','Artyomka@yandex.ru')
INSERT INTO dbo.Customers(CompanyName, LastName, FirstName, Adress, City, IndexCode, Phone, Email)
VALUES ('HeroCompany','Trushkin','Herman','Spasenie Street','Moscow','116333','89353470888','HeroHero@yandex.ru')

INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (3, '12.01.2021', '12.01.2021', '12.01.2021', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (1, '10.01.2021', '10.01.2021', '10.01.2021', 'C');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (2, '11.01.2021', '11.01.2021', '11.01.2021', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (4, '13.01.2021', '13.01.2021', '13.01.2021', 'C');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (3, '12.01.2021', '12.01.2021', '12.01.2021', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (1, '10.01.2021', '10.01.2021', '10.01.2021', 'C');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (2, '11.01.2021', '11.01.2021', '11.01.2021', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (4, '13.01.2021', '13.01.2021', '13.01.2021', 'C');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (5, '12.01.2021', '12.01.2021', '12.01.2021', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (6, '10.01.2021', '10.01.2021', '10.01.2021', 'C');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (7, '11.01.2021', '11.01.2021', '11.01.2021', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (8, '13.01.2021', '13.01.2021', '13.01.2021', 'C');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (9, '12.01.2021', '12.01.2021', '12.01.2021', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (10, '10.01.2021', '10.01.2021', '10.01.2021', 'C');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (9, '11.01.2021', '11.01.2021', '11.01.2021', 'P');
INSERT INTO dbo.Orders (IdCustomer, OrderDate, ShipDate, PaidDate, [Status])
VALUES (7, '13.01.2021', '13.01.2021', '13.01.2021', 'C');

INSERT INTO dbo.Products(PrName, PrPrice, InStock, ReOrder, Descript)
VALUES ('Noodle', 200, 12, 1, 'Super rollton')
INSERT INTO dbo.Products(PrName, PrPrice, InStock, ReOrder, Descript)
VALUES ('Borch', 300, 10, 1, 'With Pampushkas')
INSERT INTO dbo.Products(PrName, PrPrice, InStock, ReOrder, Descript)
VALUES ('Steak', 400, 7, 1, 'For real men')
INSERT INTO dbo.Products(PrName, PrPrice, InStock, ReOrder, Descript)
VALUES ('Kartoshka', 100, 2, 1, 'Fried Potato')
INSERT INTO dbo.Products(PrName, PrPrice, InStock, ReOrder, Descript)
VALUES ('Burger', 150, 2, 1, 'Big Mac')
INSERT INTO dbo.Products(PrName, PrPrice, InStock, ReOrder, Descript)
VALUES ('Kola', 50, 10, 1, 'Just drink')
INSERT INTO dbo.Products(PrName, PrPrice, InStock, ReOrder, Descript)
VALUES ('Tea', 20, 100, 100, 'Black')
INSERT INTO dbo.Products(PrName, PrPrice, InStock, ReOrder, Descript)
VALUES ('Shashlyk', 500, 2, 2, 'Maiskie')
INSERT INTO dbo.Products(PrName, PrPrice, InStock, ReOrder, Descript)
VALUES ('Gulyash', 300, 1, 1, 'Po Coridoru')

INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (5, 2, 2, 2)
INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (6, 3, 3, 3)
INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (7, 4, 5, 5)
INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (8, 5, 1, 1)
INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (8, 2, 1, 1)
INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (7, 5, 5, 5)
INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (1, 2, 3, 4)
INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (5, 6, 7, 8)
INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (2, 4, 6, 8)
INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (1, 5, 1, 1)
INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (3, 2, 1, 1)
INSERT INTO dbo.Items (IdOrder, IdProduct, Quantity, Total)
VALUES (5, 5, 5, 5)


UPDATE dbo.Orders SET ShipDate = GETDATE()
WHERE [Status] = 'P'

ALTER TABLE dbo.Orders
ADD CONSTRAINT FR_Ord_Cust
FOREIGN KEY (IdCustomer) REFERENCES Customers (IdCustomer);

ALTER TABLE dbo.Items
ADD CONSTRAINT FR_Item_Prod
FOREIGN KEY (IdProduct) REFERENCES Products (IdProduct);

ALTER TABLE dbo.Items
ADD CONSTRAINT FR_Item_Ord
FOREIGN KEY (IdOrder) REFERENCES Orders(IdOrder)