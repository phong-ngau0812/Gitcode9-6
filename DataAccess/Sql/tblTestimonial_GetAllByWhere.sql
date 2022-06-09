use asiaticadb
GO

-- Drop the 'tblTestimonial_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTestimonial_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblTestimonial_GetAllByWhere]
GO

-- Gets all records from the 'tblTestimonial' table.
CREATE PROCEDURE [tblTestimonial_GetAllByWhere]
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

execute('select t.*,n.NationalityName From tblTestimonial as t LEFT JOIN tblNationality as n
On t.NationalityID = n.ID ' + @Where + ' ' + @Order)
GO