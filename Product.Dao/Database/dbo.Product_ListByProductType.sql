CREATE PROCEDURE [dbo].[Product_ListByProductType]
	@Product_Type nvarchar(50)
AS
	SELECT Product_Id,
		   Product_Name,
		   Product_Type,
		   Product_Stock
    From Product WITH(NOLOCK)
	WHERE Product_Type = @Product_Type
RETURN 
