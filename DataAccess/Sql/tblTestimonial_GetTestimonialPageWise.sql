
USE [asiaticadb]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[tblTestimonial_GetTestimonialPageWise]
	@Lang nvarchar(10) = ''
	,@Year int = 0
    ,@PageIndex INT = 1
    ,@PageSize INT = 10
    ,@PageCount INT OUTPUT
AS
BEGIN
SET NOCOUNT ON;
			select ROW_NUMBER() OVER
            (
               ORDER BY t.PostedDate ASC
            ) AS RowNumber, t.*,n.NationalityName, tt.TourCode,tt.TourName INTO #Results From tblTestimonial as t LEFT JOIN tblNationality as n
On t.NationalityID = n.ID 
LEFT JOIN tblTour as tt
ON t.TourID = tt.ID 
Where t.Lang = @Lang And t.Status=1 And t.ObjectType = 1 And year(t.PostedDate)=@year
Order By PostedDate DESC

   
DECLARE @RecordCount INT

SELECT @RecordCount = COUNT(*) FROM #Results
 
    SET @PageCount = CEILING(CAST(@RecordCount AS DECIMAL(10, 2)) / CAST(@PageSize AS DECIMAL(10, 2)))
    PRINT       @PageCount
           
    SELECT * FROM #Results
    WHERE RowNumber BETWEEN(@PageIndex -1) * @PageSize + 1 AND(((@PageIndex -1) * @PageSize + 1) + @PageSize) - 1
     
	DROP TABLE #Results

END




