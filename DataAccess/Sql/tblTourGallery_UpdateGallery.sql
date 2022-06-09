
use asiaticadb
GO

-- Drop the 'tblTourGallery_UpdateGallery' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTourGallery_UpdateGallery') AND type='P')
	DROP PROCEDURE [tblTourGallery_UpdateGallery]
GO

-- Gets all records from the 'tblTourGallery' table.
CREATE PROCEDURE [tblTourGallery_UpdateGallery]
@TourID int
AS
Update tblTourGallery
Set IsGallery = 1
Where TourID = @TourID
GO