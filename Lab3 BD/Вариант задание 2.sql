Select City, Count(City) as number, ord.Status 
from Customers cus INNER JOIN Orders ord 
ON cus.IdCustomer = ord.IdCustomer 
GROUP BY City, ord.Status 
HAVING ord.Status='P'