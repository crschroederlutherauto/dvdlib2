CREATE PROCEDURE [dbo].[GetByRating]
	@searchText NVARCHAR(MAX)
AS
	SELECT * FROM [dbo].[DVDs]
	WHERE @searchText LIKE Rating