
use asiaticadb
GO

-- Drop the 'tblHotelGallery_UpdateList' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_UpdateList') AND type='P')
	DROP PROCEDURE [tblHotelGallery_UpdateList]
GO

-- Gets all records from the 'tblHotelGallery' table.
CREATE PROCEDURE [tblHotelGallery_UpdateList]
@HotelID int
AS
Update tblHotelGallery
Set IsList = 0
Where HotelID = @HotelID
GO