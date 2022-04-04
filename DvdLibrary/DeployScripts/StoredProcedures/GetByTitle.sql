CREATE PROCEDURE [dbo].[GetByTitle]
	@Title NVARCHAR(MAX)
AS
	SELECT * FROM [dbo].[DVDs]
	WHERE @Title = Title