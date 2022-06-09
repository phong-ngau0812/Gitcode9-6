use asiaticadb
GO

-- Drop the 'tblTestimonialGallery_GetRandomDataByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTestimonialGallery_GetRandomDataByWhere') AND type='P')
	DROP PROCEDURE [tblTestimonialGallery_GetRandomDataByWhere]
GO

-- Gets all records from the 'tblTestimonialGallery' table.
CREATE PROCEDURE [tblTestimonialGallery_GetRandomDataByWhere]
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

execute('
Select top 1 tg.*,t.PostedDate From tblTestimonialGallery as tg INNER JOIN tblTestimonial as t
ON tg.TestimonialID = t.ID ' + @Where + ' ' + @Order)
GO
