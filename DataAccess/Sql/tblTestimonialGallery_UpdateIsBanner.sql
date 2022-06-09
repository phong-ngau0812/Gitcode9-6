
use asiaticadb
GO

-- Drop the 'tblTestimonialGallery_UpdateIsBanner' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTestimonialGallery_UpdateIsBanner') AND type='P')
	DROP PROCEDURE [tblTestimonialGallery_UpdateIsBanner]
GO

-- Gets all records from the 'tblTestimonialGallery' table.
CREATE PROCEDURE [tblTestimonialGallery_UpdateIsBanner]
@TestimonialID int
AS
Update tblTestimonialGallery
Set IsBanner = 0
Where TestimonialID = @TestimonialID
GO