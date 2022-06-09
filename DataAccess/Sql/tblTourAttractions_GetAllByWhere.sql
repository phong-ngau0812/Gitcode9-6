use asiaticadb
GO

-- Drop the 'tblTourAttractions_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTourAttractions_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblTourAttractions_GetAllByWhere]
GO

-- Gets all records from the 'tblTourAttractions' table.
CREATE PROCEDURE [tblTourAttractions_GetAllByWhere]
@Lang nvarchar(10) = '',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

Select * into #temp From tblTour where Lang = @Lang
Select * into #temp2 From tblAttractionsLang where Lang = @Lang
execute('select ta.*, #temp.*,#temp2.SubDomainSite, #temp2.AttractionsName, #temp2.SubDescriptionSite From tblTourAttractions as ta INNER JOIN #temp
On ta.TourID=#temp.ID LEFT JOIN #temp2
On ta.AttractionsID = #temp2.AttractionsID
' + @Where + ' ' + @Order)

GO
