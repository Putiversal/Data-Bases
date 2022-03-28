SELECT DISTINCT cus.CompanyName, cus.LastName, cus.FirstName, cus.Adress, cus.Phone, cus.City 
FROM Customers cus INNER JOIN Orders ord 
ON cus.IdCustomer = ord.IdCustomer
Where [Status] ='P'
ORDER BY cus.LastName, cus.City