
use asiaticadb
GO

-- Drop the 'tblHotelGallery_UpdateDetail' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_UpdateDetail') AND type='P')
	DROP PROCEDURE [tblHotelGallery_UpdateDetail]
GO

-- Gets all records from the 'tblHotelGallery' table.
CREATE PROCEDURE [tblHotelGallery_UpdateDetail]
@HotelID int
AS
Update tblHotelGallery
Set IsDetail = 0
Where HotelID = @HotelID
GO