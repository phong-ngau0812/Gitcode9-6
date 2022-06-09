use asiaticadb
GO

-- Drop the 'tblExclusive_GetTopByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblExclusive_GetTopByWhere') AND type='P')
	DROP PROCEDURE [tblExclusive_GetTopByWhere]
GO

-- Gets all records from the 'tblExclusive' table.
CREATE PROCEDURE [tblExclusive_GetTopByWhere]
@Lang nvarchar(10) = '',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

Select * into #temp From tblCountryLang where Lang = @Lang
Select * into #temp2 From tblAttractionsLang where Lang = @Lang
execute('
Select top 3 e.*,#temp.CountryName,#temp2.AttractionsName,et.cssclass,et.Title as TypeName From tblExclusive as e LEFT JOIN #temp
ON e.CountryID = #temp.CountryID  LEFT JOIN #temp2 ON e.AttractionsID=#temp2.AttractionsID 
LEFT JOIN tblExclusiveType as et ON e.ExclusiveTypeID=et.ID ' + @Where + ' ' + @Order)
GO
