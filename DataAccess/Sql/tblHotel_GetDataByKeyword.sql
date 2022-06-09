use asiaticadb
GO

-- Drop the 'tblHotel_GetDataByKeyword' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_GetDataByKeyword') AND type='P')
	DROP PROCEDURE [tblHotel_GetDataByKeyword]
GO

CREATE PROCEDURE [tblHotel_GetDataByKeyword]
(
@Lang nvarchar(10),	
@CountryID nvarchar(2),
@key nvarchar(1500)
)
AS

declare @sqlTemp nvarchar(2000)
DECLARE @NextString NVARCHAR(255)
DECLARE @Pos INT
DECLARE @NextPos INT
DECLARE @String NVARCHAR(1500)
DECLARE @Delimiter NVARCHAR(40)

SET @sqlTemp = ''
SET @String = @key
SET @Delimiter = ' '
SET @String = @String + @Delimiter
SET @Pos = charindex(@Delimiter,@String)

WHILE (@pos <> 0)
BEGIN
SET @NextString = substring(@String,1,@Pos - 1)
Set @sqlTemp = @sqlTemp + ' Or Tag like N''%'+@NextString+'%'''
SET @String = substring(@String,@pos+1,len(@String))
SET @pos = charindex(@Delimiter,@String)
END 

declare @sql nvarchar(4000)
--drop table #Temp
CREATE TABLE #Temp
(
	[TempID] [int]  IDENTITY(1,1) NOT NULL,
	ID decimal,
	Title nvarchar(500),
	SubDescription ntext,
	TypeID int,
	Lang nvarchar(10)
)

set @sql = 
('
	insert into #Temp
	(
		ID,
		Title,
		SubDescription,
		TypeID,
		Lang
	)
	SELECT HotelID, HotelName, SubDescription, 3, Lang from tblHotelLang Where Lang='''+@Lang+''' And (HotelName like N''%'+@key+'%'' '+@sqlTemp+') And AttractionsID in (select ID From tblAttractions Where CountryID='+@CountryID+')
')

EXEC (@sql)

select * from #Temp

go
