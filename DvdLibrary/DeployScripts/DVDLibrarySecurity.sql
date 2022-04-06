CREATE LOGIN DvdLibraryApp WITH PASSWORD='Testing123!'
GO

USE DVDLibrary
GO

CREATE USER DVDLibraryApp FOR LOGIN DvdLibraryApp
GO

GRANT EXECUTE ON [dbo].[Create] TO DVDLibraryApp
GRANT EXECUTE ON [dbo].[Delete] TO DVDLibraryApp
GRANT EXECUTE ON [dbo].[GetAll] TO DVDLibraryApp
GRANT EXECUTE ON [dbo].[GetByDirector] TO DVDLibraryApp
GRANT EXECUTE ON [dbo].[GetByID] TO DVDLibraryApp
GRANT EXECUTE ON [dbo].[GetByRating] TO DVDLibraryApp
GRANT EXECUTE ON [dbo].[GetByReleaseYear] TO DVDLibraryApp
GRANT EXECUTE ON [dbo].[GetByTitle] TO DVDLibraryApp
GRANT EXECUTE ON [dbo].[Update] TO DVDLibraryApp
GO

GRANT SELECT ON [dbo].[DVDs] TO DVDLibraryApp
GRANT INSERT ON [dbo].[DVDs] TO DVDLibraryApp
GRANT UPDATE ON [dbo].[DVDs] TO DVDLibraryApp
GRANT DELETE ON [dbo].[DVDs] TO DVDLibraryApp
GO