
use asiaticadb
GO

-- Drop the 'tblTourGallery_UpdateBanner' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTourGallery_UpdateBanner') AND type='P')
	DROP PROCEDURE [tblTourGallery_UpdateBanner]
GO

-- Gets all records from the 'tblTourGallery' table.
CREATE PROCEDURE [tblTourGallery_UpdateBanner]
@TourID int
AS
Update tblTourGallery
Set IsBanner = 0
Where TourID = @TourID
GO