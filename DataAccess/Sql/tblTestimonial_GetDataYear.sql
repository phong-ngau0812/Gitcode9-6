use asiaticadb
GO

-- Drop the 'tblTestimonial_GetDataYear' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTestimonial_GetDataYear') AND type='P')
	DROP PROCEDURE [tblTestimonial_GetDataYear]
GO

-- Gets all records from the 'tblTestimonial' table.
CREATE PROCEDURE [tblTestimonial_GetDataYear]
@Lang nvarchar(10)
AS
select year(PostedDate) as 'Year' From tblTestimonial 
Where Status=1 And Lang=@Lang Group by year(PostedDate)  Order By  year(PostedDate) DESC

GO
