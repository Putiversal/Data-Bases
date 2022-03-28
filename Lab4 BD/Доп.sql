SELECT Orders.OrderDate, Products.PrName, Items.Quantity, Items.Total 



FROM     dbo.Items INNER JOIN
         dbo.Orders ON dbo.Items.IdOrder = dbo.Orders.IdOrder INNER JOIN
         dbo.Products ON dbo.Items.IdProduct = dbo.Products.IdProduct