use asiaticadb
GO

-- Drop the 'sp_Search' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'sp_Search') AND type='P')
	DROP PROCEDURE [sp_Search]
GO

CREATE PROCEDURE [sp_Search]
(
	@Lang varchar(10),
	@CountryID varchar(2),
	@key nvarchar(1500)
)
AS
declare @sql nvarchar(4000)
--drop table #Temp
CREATE TABLE #Temp
(
	[TempID] [int]  IDENTITY(1,1) NOT NULL,
	ID int,
	Title nvarchar(500),
	SubDomain nvarchar(255),
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
		SubDomain,
		SubDescription,
		TypeID,
		Lang
	)
	SELECT ID, TourName, Null, Overview, 1, Lang FROM tblTour WHERE Lang='''+@Lang+''' And (TourName like N''%'+@key+'%'' Or Tag like N''%'+@key+'%'') And CateID in (Select ID From tblHotelCategory Where CountryID='+@CountryID+')
')

EXEC (@sql)

set @sql = 
('
	insert into #Temp
	(
		ID,
		Title,
		SubDomain,
		SubDescription,
		TypeID,
		Lang
	)
	SELECT AttractionsID, AttractionsName, SubDomainSite, Description, 2, Lang from tblAttractionsLang Where Lang='''+@Lang+''' And AttractionsName like N''%'+@key+'%'' And AttractionsID in (Select ID From tblAttractions Where Levels<>1 And CountryID='+@CountryID+')
')

EXEC (@sql)

set @sql = 
('
	insert into #Temp
	(
		ID,
		Title,
		SubDomain,
		SubDescription,
		TypeID,
		Lang
	)
	SELECT HotelID, HotelName, Null, SubDescription, 3, Lang from tblHotelLang Where Lang='''+@Lang+''' And (HotelName like N''%'+@key+'%'' Or Tag like N''%'+@key+'%'') And HotelID in (select ID From tblHotel Where AttractionsID in (Select AttractionsID From tblAttractions Where CountryID ='+@CountryID+'))
')

EXEC (@sql)

set @sql = 
('
	insert into #Temp
	(
		ID,
		Title,
		SubDomain,
		SubDescription,
		TypeID,
		Lang
	)
	SELECT ID, Title, SubDomain, Description, 4, Lang FROM tblTravelGuide WHERE Lang='''+@Lang+''' And (Title like N''%'+@key+'%'' Or Tag like N''%'+@key+'%'')
')

EXEC (@sql)

set @sql = 
('
	insert into #Temp
	(
		ID,
		Title,
		SubDomain,
		SubDescription,
		TypeID,
		Lang
	)
	SELECT ID, Title, SubDomain, Description, 5, Lang FROM tblAbout WHERE Lang='''+@Lang+''' And Title like N''%'+@key+'%''
')

EXEC (@sql)

select * from #Temp

go

