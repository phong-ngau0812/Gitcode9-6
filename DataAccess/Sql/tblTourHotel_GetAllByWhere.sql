use asiaticadb
GO

-- Drop the 'tblTourHotel_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTourHotel_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblTourHotel_GetAllByWhere]
GO

-- Gets all records from the 'tblTourHotel' table.
CREATE PROCEDURE [tblTourHotel_GetAllByWhere]
@Lang nvarchar(10) = '',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order
Select * into #temp From tblHotelLang where Lang = @Lang
execute('select th.*, #temp.* From tblTourHotel as th LEFT JOIN #temp
On th.HotelID = #temp.HotelID ' + @Where + ' ' + @Order)

GO


--exec tblTourHotel_GetAllByWhere 'fr','TourID=1','OrderBy ASC'