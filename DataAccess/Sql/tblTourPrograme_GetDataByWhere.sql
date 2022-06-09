
use asiaticadb
GO

-- Drop the 'tblTourPrograme_GetDataByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblTourPrograme_GetDataByWhere') AND type='P')
	DROP PROCEDURE [tblTourPrograme_GetDataByWhere]
GO

-- Gets all records from the 'tblTourPrograme' table.
CREATE PROCEDURE [tblTourPrograme_GetDataByWhere]
@Lang nvarchar(10) = '',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
Select * into #temp From tblHotelLang where Lang = @Lang
execute('
	select tp.*,#temp.HotelName,#temp.City From tblTourPrograme as tp 
INNER JOIN #temp On tp.HotelID = #temp.HotelID
')
GO

