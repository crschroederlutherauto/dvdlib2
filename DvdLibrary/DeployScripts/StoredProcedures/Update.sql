CREATE PROCEDURE [dbo].[Update]
	@DVDID INT,
	@Title NVARCHAR(MAX),
	@ReleaseYear NVARCHAR(MAX),
	@Director NVARCHAR(MAX),
	@Rating NVARCHAR(MAX),
	@Notes NVARCHAR(MAX)
AS
	UPDATE [dbo].[DVDs]
	SET Title = @Title,
		ReleaseYear = @ReleaseYear,
		Director = @Director,
		Rating = @Rating,
		Notes = @Notes
	WHERE @DVDID = DVDID