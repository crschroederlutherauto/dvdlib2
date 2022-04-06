CREATE PROCEDURE [dbo].[GetByReleaseYear]
	@searchTerm NVARCHAR(MAX)
AS
	SELECT * FROM [dbo].[DVDs]
	WHERE @searchTerm LIKE ReleaseYear