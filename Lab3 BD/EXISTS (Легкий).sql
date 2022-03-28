SELECT * FROM Customers cus 
WHERE EXISTS(SELECT * FROM Orders ord 
WHERE cus.IdCustomer = ord.IdCustomer AND OrderDate > '2021-01-12' )