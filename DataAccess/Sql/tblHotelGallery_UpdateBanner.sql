
use asiaticadb
GO

-- Drop the 'tblHotelGallery_UpdateBanner' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_UpdateBanner') AND type='P')
	DROP PROCEDURE [tblHotelGallery_UpdateBanner]
GO

-- Gets all records from the 'tblHotelGallery' table.
CREATE PROCEDURE [tblHotelGallery_UpdateBanner]
@HotelID int
AS
Update tblHotelGallery
Set IsBanner = 0
Where HotelID = @HotelID
GO