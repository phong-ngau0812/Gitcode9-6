
use asiaticadb
GO

-- Drop the 'tblAttractionsGallery_UpdateDetail' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_UpdateDetail') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_UpdateDetail]
GO

-- Gets all records from the 'tblAttractionsGallery' table.
CREATE PROCEDURE [tblAttractionsGallery_UpdateDetail]
@AttractionsID int
AS
Update tblAttractionsGallery
Set IsDetail = 0
Where AttractionsID = @AttractionsID
GO