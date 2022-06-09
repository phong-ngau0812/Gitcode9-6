
use asiaticadb
GO

-- Drop the 'tblAttractionsGallery_UpdateBanner' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_UpdateBanner') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_UpdateBanner]
GO

-- Gets all records from the 'tblAttractionsGallery' table.
CREATE PROCEDURE [tblAttractionsGallery_UpdateBanner]
@AttractionsID int
AS
Update tblAttractionsGallery
Set IsBanner = 0
Where AttractionsID = @AttractionsID
GO