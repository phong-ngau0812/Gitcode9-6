
use asiaticadb
GO

-- Drop the 'tblAttractionsGallery_UpdateList' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_UpdateList') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_UpdateList]
GO

-- Gets all records from the 'tblAttractionsGallery' table.
CREATE PROCEDURE [tblAttractionsGallery_UpdateList]
@AttractionsID int
AS
Update tblAttractionsGallery
Set IsList = 0
Where AttractionsID = @AttractionsID
GO