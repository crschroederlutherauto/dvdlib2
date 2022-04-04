CREATE PROCEDURE [dbo].[GetByRating]
	@Rating NVARCHAR(MAX)
AS
	SELECT * FROM [dbo].[DVDs]
	WHERE @Rating = Rating