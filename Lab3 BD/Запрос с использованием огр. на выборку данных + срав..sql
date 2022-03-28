SELECT * FROM dbo.Customers WHERE City = 'Moscow'  ORDER BY LastName ASC;
SELECT * FROM dbo.Items WHERE Quantity > 3 ORDER BY Quantity;
SELECT * FROM dbo.Orders WHERE Status= 'P' ORDER BY OrderDate;
SELECT * FROM dbo.Products WHERE PrPrice > 200 ORDER BY PrPrice;
