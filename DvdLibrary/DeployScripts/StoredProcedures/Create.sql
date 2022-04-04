CREATE PROCEDURE [dbo].[Create]
	@Title NVARCHAR(MAX),
	@ReleaseYear NVARCHAR(MAX),
	@Director NVARCHAR(MAX),
	@Rating NVARCHAR(MAX),
	@Notes NVARCHAR(MAX)
AS
	INSERT [dbo].[DVDs] (Title, ReleaseYear, Director, Rating, Notes)
	VALUES (@Title, @ReleaseYear, @Director, @Rating, @Notes)

	SELECT SCOPE_IDENTITY()