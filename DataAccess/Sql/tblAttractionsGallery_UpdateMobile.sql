
use asiaticadb
GO

-- Drop the 'tblAttractionsGallery_UpdateMobile' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_UpdateMobile') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_UpdateMobile]
GO

-- Gets all records from the 'tblAttractionsGallery' table.
CREATE PROCEDURE [tblAttractionsGallery_UpdateMobile]
@AttractionsID int
AS
Update tblAttractionsGallery
Set IsMobile = 0
Where AttractionsID = @AttractionsID
GO