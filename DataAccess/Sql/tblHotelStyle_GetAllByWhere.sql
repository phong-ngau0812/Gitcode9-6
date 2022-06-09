use asiaticadb
GO

-- Drop the 'tblHotelStyle_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyle_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblHotelStyle_GetAllByWhere]
GO

-- Gets all records from the 'tblHotelStyle' table.
CREATE PROCEDURE [tblHotelStyle_GetAllByWhere]
@Lang nvarchar(10) = '',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order
Select * into #temp From tblHotelStyleLang where Lang = @Lang
execute('select hs.*, #temp.* From tblHotelStyle as hs LEFT JOIN #temp
On hs.ID = #temp.HotelStyleID ' + @Where + ' ' + @Order)

GO
