CREATE PROCEDURE [dbo].[GetByReleaseYear]
	@ReleaseYear NVARCHAR(MAX)
AS
	SELECT * FROM [dbo].[DVDs]
	WHERE @ReleaseYear = ReleaseYear