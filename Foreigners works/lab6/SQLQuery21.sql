CREATE TRIGGER Customers_UPDATE
ON Customers
AFTER UPDATE
AS
SELECT 'Запись обновлена', IdCustomer, FirstName, LastName  FROM deleted;
