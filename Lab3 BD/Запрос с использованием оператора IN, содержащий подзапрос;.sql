SELECT IdItem, IdOrder, Quantity FROM Items 
WHERE IdProduct IN(SELECT IdProduct FROM Products WHERE PrPrice > 100 );
