SELECT DISTINCT cus.FirstName, pr.PrName, pr.PrPrice 
FROM Customers cus INNER JOIN Orders ord 
ON cus.IdCustomer = ord.IdCustomer INNER JOIN Items it 
ON ord.IdOrder = it.IdOrder INNER JOIN Products pr 
ON it.IdProduct = pr.IdProduct 
WHERE pr.PrPrice > 50 
ORDER BY (PrPrice) DESC