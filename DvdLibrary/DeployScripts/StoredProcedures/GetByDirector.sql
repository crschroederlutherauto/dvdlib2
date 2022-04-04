CREATE PROCEDURE [dbo].[GetByDirector]
	@Director NVARCHAR(MAX)
AS
	SELECT * FROM [dbo].[DVDs]
	WHERE @Director = Director