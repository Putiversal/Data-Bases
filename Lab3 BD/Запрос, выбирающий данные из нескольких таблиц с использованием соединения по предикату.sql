SELECT Orders.OrderDate,Orders.Status, Customers.CompanyName, Customers.FirstName 

FROM Orders INNER JOIN Customers 
ON Orders.IdCustomer = Customers.IdCustomer;