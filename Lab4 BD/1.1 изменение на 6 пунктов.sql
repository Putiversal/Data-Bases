ALTER VIEW dbo.MyView as

SELECT 
Customers.LastName AS 'CustomerSurname', 
Customers.City As 'City', 
Customers.[Email] AS 'Email',
Customers.Adress As 'Adress', 
Customers.CompanyName AS 'Company', 
Customers.FirstName as 'FirstName' 

From Customers
