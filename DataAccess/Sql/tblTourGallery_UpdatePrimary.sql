
use asiaticadb
GO

-- Drop the 'tblTourGallery_UpdatePrimary' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTourGallery_UpdatePrimary') AND type='P')
	DROP PROCEDURE [tblTourGallery_UpdatePrimary]
GO

-- Gets all records from the 'tblTourGallery' table.
CREATE PROCEDURE [tblTourGallery_UpdatePrimary]
@TourID int
AS
Update tblTourGallery
Set IsPrimary = 0
Where TourID = @TourID
GO