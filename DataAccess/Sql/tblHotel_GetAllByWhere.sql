use asiaticadb
GO

-- Drop the 'tblHotel_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblHotel_GetAllByWhere]
GO

-- Gets all records from the 'tblHotel' table.
CREATE PROCEDURE [tblHotel_GetAllByWhere]
@Lang nvarchar(10)='',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

Select * into #temp From tblHotelLang where Lang = @Lang
execute('select h.*,#temp.* From tblHotel as h LEFT JOIN #temp
On h.ID = #temp.HotelID ' + @Where + ' ' + @Order)

GO

