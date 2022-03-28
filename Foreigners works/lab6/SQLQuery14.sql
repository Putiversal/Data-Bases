-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE ProductsByOrders 
	-- Add the parameters for the stored procedure here
	@FirstOrder integer,
	@SecondOrder integer
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pr.IdProduct, pr.PrName, pr.Descript,it.Total, pr.PrPrice*it.Total as Sum, ord.ShipDate from Orders ord INNER JOIN Items it on ord.IdOrder = it.IdOrder 
	INNER JOIN Products  pr on pr.IdProduct = it.IdProduct where ord.IdOrder = @FirstOrder
	SELECT pr.IdProduct, pr.PrName, pr.Descript,it.Total, pr.PrPrice*it.Total as Sum, ord.ShipDate from Orders ord 
	INNER JOIN Items it on ord.IdOrder = it.IdOrder INNER JOIN Products  pr on pr.IdProduct = it.IdProduct where ord.IdOrder = @SecondOrder 
END
GO
