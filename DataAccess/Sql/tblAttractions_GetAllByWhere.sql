use asiaticadb
GO

-- Drop the 'tblAttractions_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblAttractions_GetAllByWhere]
GO

-- Gets all records from the 'tblAttractions' table.
CREATE PROCEDURE [tblAttractions_GetAllByWhere]
@Lang nvarchar(10) = '',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

Select * into #temp From tblAttractionsLang where Lang = @Lang
execute('select a.*, #temp.* From tblAttractions as a LEFT JOIN #temp
On a.ID = #temp.AttractionsID ' + @Where + ' ' + @Order)

GO


