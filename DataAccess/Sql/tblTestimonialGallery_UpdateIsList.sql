
use asiaticadb
GO

-- Drop the 'tblTestimonialGallery_UpdateIsList' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTestimonialGallery_UpdateIsList') AND type='P')
	DROP PROCEDURE [tblTestimonialGallery_UpdateIsList]
GO

-- Gets all records from the 'tblTestimonialGallery' table.
CREATE PROCEDURE [tblTestimonialGallery_UpdateIsList]
@TestimonialID int
AS
Update tblTestimonialGallery
Set IsList = 0
Where TestimonialID = @TestimonialID
GO