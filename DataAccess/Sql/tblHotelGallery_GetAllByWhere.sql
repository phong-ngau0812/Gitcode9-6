use asiaticadb
GO

-- Drop the 'tblHotelGallery_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblHotelGallery_GetAllByWhere]
GO

-- Gets all records from the 'tblHotelGallery' table.
CREATE PROCEDURE [tblHotelGallery_GetAllByWhere]
@Lang nvarchar(10)='',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order
Select * into #temp From tblHotelGalleryLang where Lang = @Lang
execute('select hg.*, #temp.* From tblHotelGallery as hg LEFT JOIN #temp
On hg.ID = #temp.HotelGalleryID ' + @Where + ' ' + @Order)

GO
