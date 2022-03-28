SELECT ord.IdOrder, ord.OrderDate, pr.PrPrice, 
IIF(pr.PrPrice > 250, '������', '������') as '���������' 
FROM Orders ord INNER JOIN Items it 
ON ord.IdOrder = it.IdOrder INNER JOIN Products pr 
ON it.IdProduct = pr.IdProduct;