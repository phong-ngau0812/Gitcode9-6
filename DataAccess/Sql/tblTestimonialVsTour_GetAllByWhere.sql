use asiaticadb
GO

-- Drop the 'tblTestimonialVsTour_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTestimonialVsTour_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblTestimonialVsTour_GetAllByWhere]
GO

-- Gets all records from the 'tblTestimonialVsTour' table.
CREATE PROCEDURE [tblTestimonialVsTour_GetAllByWhere]
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

execute('select tt.*, t.*,n.NationalityName, tu.TourCode,tu.TourName From tblTestimonialVsTour as tt INNER JOIN tblTestimonial as t
ON tt.TestimonialID = t.ID
LEFT JOIN tblNationality as n
On t.NationalityID = n.ID 
LEFT JOIN tblTour as tu
ON tt.TourID = tu.ID ' + @Where + ' ' + @Order)
GO


