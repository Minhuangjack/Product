CREATE TABLE [dbo].[Product]
(
	[Product_No] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Product_Id] NVARCHAR(50) NOT NULL, 
    [Product_Name] NVARCHAR(50) NOT NULL, 
    [Product_Stock] INT NOT NULL, 
    [Product_Type] NVARCHAR(50) NOT NULL
)
