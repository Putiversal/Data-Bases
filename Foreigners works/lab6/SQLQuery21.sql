CREATE TRIGGER Customers_UPDATE
ON Customers
AFTER UPDATE
AS
SELECT '������ ���������', IdCustomer, FirstName, LastName  FROM deleted;
