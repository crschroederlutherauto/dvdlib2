CREATE PROCEDURE [dbo].[GetByDirector]
	@searchTerm NVARCHAR(MAX)
AS
	SELECT * FROM [dbo].[DVDs]
	WHERE @searchTerm LIKE Director