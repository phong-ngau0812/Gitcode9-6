use asiaticadb
GO

-- Drop the 'tblHotelService_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelService_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblHotelService_GetAllByWhere]
GO

-- Gets all records from the 'tblHotelService' table.
CREATE PROCEDURE [tblHotelService_GetAllByWhere]
@Lang nvarchar(10) = '',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order
Select * into #temp From tblHotelServiceLang where Lang = @Lang
execute('select hs.*, #temp.* From tblHotelService as hs LEFT JOIN #temp
On hs.ID = #temp.HotelServiceID ' + @Where + ' ' + @Order)

GO
