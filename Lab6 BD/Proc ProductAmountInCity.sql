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
CREATE PROCEDURE ProductAmountInCity 
	-- Add the parameters for the stored procedure here
	@City nvarchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pr.PrName, Sum(it.Total) as Amount, cus.City from Customers cus 
	Inner Join Orders ord on cus.IdCustomer = ord.IdCustomer
	Inner Join Items it on ord.IdOrder = it.IdOrder
	Inner Join Products pr on pr.IdProduct = it.IdProduct
	Group by pr.PrName, cus.City Having cus.city = @City
	 
END
GO
