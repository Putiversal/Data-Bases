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
Alter PROCEDURE ProductsIn2Orders 
	-- Add the parameters for the stored procedure here
	@FirstOrder int,
	@SecondOrder int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pr.IdProduct, pr.PrName, pr.Descript, it.Total as Sum, ord.ShipDate 
	From Orders ord Inner Join Items it 
	on ord.IdOrder = it.IdOrder Inner Join Products pr 
	on pr.IdProduct = it.IdProduct 
	where ord. IdOrder = @FirstOrder

	SELECT pr.IdProduct, pr.PrName, pr.Descript, it.Total as Sum, ord.ShipDate 
	From Orders ord Inner Join Items it 
	on ord.IdOrder = it.IdOrder Inner Join Products pr 
	on pr.IdProduct = it.IdProduct 
	where ord. IdOrder = @SecondOrder
END
GO
