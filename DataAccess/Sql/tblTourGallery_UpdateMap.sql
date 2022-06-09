
use asiaticadb
GO

-- Drop the 'tblTourGallery_UpdateMap' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTourGallery_UpdateMap') AND type='P')
	DROP PROCEDURE [tblTourGallery_UpdateMap]
GO

-- Gets all records from the 'tblTourGallery' table.
CREATE PROCEDURE [tblTourGallery_UpdateMap]
@TourID int
AS
Update tblTourGallery
Set IsMap = 0
Where TourID = @TourID
GO