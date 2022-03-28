CREATE TRIGGER Customers_INSERT
ON Customers
AFTER INSERT
AS
UPDATE Customers SET FirstName = UPPER(FirstName) WHERE FirstName = (SELECT FirstName FROM inserted);
