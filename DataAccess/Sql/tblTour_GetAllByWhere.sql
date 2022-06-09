use asiaticadb
GO

-- Drop the 'tblTour_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTour_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblTour_GetAllByWhere]
GO

-- Gets all records from the 'tblTour' table.
CREATE PROCEDURE [tblTour_GetAllByWhere]
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

execute('select t.*, tc.SubDomain,tc.Title,tc.FullTitle From tblTour as t INNER JOIN tblTourCategory as tc
On t.CateID = tc.ID ' + @Where + ' ' + @Order)

GO


