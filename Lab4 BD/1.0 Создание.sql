CREATE VIEW MyView AS SELECT 
Customers.LastName AS 'CustomerSurname', 
Customers.City As 'City', 
Customers.[Email] AS 'Email' FROM Customers;