
use asiaticadb
GO

-- Drop the 'tblTourPrograme_GetHotelByTourID' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTourPrograme_GetHotelByTourID') AND type='P')
	DROP PROCEDURE [tblTourPrograme_GetHotelByTourID]
GO

-- Gets all records from the 'tblTourPrograme' table.
CREATE PROCEDURE [tblTourPrograme_GetHotelByTourID]
@Lang nvarchar(10),
@TourID decimal(18,0)
AS
Select * into #temp From tblHotelLang where Lang = @Lang
execute('
	select h.ID,h.CateID,h.AttractionsID,h.HotelStyleID,h.Star,h.Rating,#temp.HotelName,#temp.City,#temp.Address,tp.Night
from tblHotel as h Left Join #temp on h.ID = #temp.HotelID INNER JOIN 
(select HotelID,OrderBy,count(*) as Night From tblTourPrograme
Where TourID='+@TourID+' And HotelID<>0
Group by HotelID,OrderBy) as tp
ON h.ID = tp.HotelID  Order By OrderBy')
GO


