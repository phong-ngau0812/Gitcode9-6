use asiaticadb
GO

-- Drop the 'tblAttractions_GetDataByKeyword' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_GetDataByKeyword') AND type='P')
	DROP PROCEDURE [tblAttractions_GetDataByKeyword]
GO

CREATE PROCEDURE [tblAttractions_GetDataByKeyword]
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
Set @sqlTemp = @sqlTemp
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
	SELECT AttractionsID, AttractionsName, Description, 2,Lang from tblAttractionsLang Where Lang = '''+@Lang+''' And AttractionsName like N''%'+@key+'%'' '+@sqlTemp+' And AttractionsID in (Select ID From tblAttractions Where Levels<>1 And CountryID='+@CountryID+')
')

EXEC (@sql)

select * from #Temp

go
