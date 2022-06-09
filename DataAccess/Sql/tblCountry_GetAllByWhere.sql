use asiaticadb
GO

-- Drop the 'tblCountry_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountry_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblCountry_GetAllByWhere]
GO

-- Gets all records from the 'tblCountry' table.
CREATE PROCEDURE [tblCountry_GetAllByWhere]
@Lang nvarchar(10) = '',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

Select * into #temp From tblCountryLang where Lang = @Lang
execute('select c.*, #temp.* From tblCountry as c LEFT JOIN #temp
On c.ID = #temp.CountryID  ' + @Where + ' ' + @Order)

GO

