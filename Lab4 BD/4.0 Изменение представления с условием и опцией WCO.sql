ALTER VIEW dbo.MyView as SELECT 
Customers.LastName AS 'CustomerSurname', 
Customers.City As 'City', 
Customers.Email AS 'Email',
Customers.Adress As 'Adress', 
Customers.CompanyName AS 'Company',
Customers.FirstName as 'FirstName', 
Customers.IndexCode as 'Index' 

FROM Customers 
WHERE City = 'Tambov' WITH CHECK OPTION;
--WITH CHECK OPTION может указываться для обновляемых (updatable) 
--представлений, через которые можно добавлять или изменять данные.