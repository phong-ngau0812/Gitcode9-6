use asiaticadb
GO

-- Drop the 'tblAttractionsGallery_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_GetAllByWhere]
GO

-- Gets all records from the 'tblAttractionsGallery' table.
CREATE PROCEDURE [tblAttractionsGallery_GetAllByWhere]
@Lang nvarchar(10) = '',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

Select * into #temp From tblAttractionsGalleryLang where Lang = @Lang
execute('select ag.*, #temp.* From tblAttractionsGallery as ag LEFT JOIN #temp
On ag.ID = #temp.AttractionsGalleryID ' + @Where + ' ' + @Order)

GO


