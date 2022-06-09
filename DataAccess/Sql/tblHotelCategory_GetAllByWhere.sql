use asiaticadb
GO

-- Drop the 'tblHotelCategory_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblHotelCategory_GetAllByWhere]
GO

-- Gets all records from the 'tblHotelCategory' table.
CREATE PROCEDURE [tblHotelCategory_GetAllByWhere]
@Lang nvarchar(10) = '',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order
Select * into #temp From tblHotelCategoryLang where Lang = @Lang
Select * into #temp2 From tblAttractionsLang where Lang = @Lang
execute('select hc.*, #temp.*, #temp2.AttractionsName,#temp2.SubDomainHotel From tblHotelCategory as hc LEFT JOIN #temp
On hc.ID = #temp.HotelCategoryID INNER JOIN #temp2
On hc.AttractionsID = #temp2.AttractionsID ' + @Where + ' ' + @Order)

GO
