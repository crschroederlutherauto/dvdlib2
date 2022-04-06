CREATE PROCEDURE [dbo].[GetByTitle]
	@searchTerm NVARCHAR(MAX)
AS
	SELECT * FROM [dbo].[DVDs]
	WHERE @searchTerm LIKE Title