set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER PROCEDURE [dbo].[sp_TrackerCustomerBooked]
(
@Lang varchar(10)
)
AS
declare @sql nvarchar(4000)
--drop table #Temp
CREATE TABLE #Temp
(
	[TempID] [int]  IDENTITY(1,1) NOT NULL,
	UID nvarchar(255),
	IPAddress nvarchar(50),
	VisitDate DateTime,
	Actions nvarchar(50),
	SourceCode nvarchar(50),
	CampaignCode nvarchar(50),
	UrlLink nvarchar(1000),
	Email nvarchar(255),	
	FirstName nvarchar(255),
	LastName nvarchar(255),
	Lang nvarchar(10)
	
)
set @sql = 
('
	insert into #Temp
	(
		UID,
		IPAddress,
		VisitDate,
		Actions,
		SourceCode,
		CampaignCode,
		UrlLink,
		Email,
		FirstName,
		LastName,
		Lang
	)
	SELECT t.UID, t.IPAddress, t.VisitDate, t.Actions, t.SourceCode, t.CampaignCode, t.UrlLink, c.Email, c.FirstName, c.LastName, c.Lang FROM tblTracker as t INNER JOIN tblCustomer as c On t.UID = c.UID WHERE t.Lang='''+@Lang+'''')

EXEC (@sql)

set @sql = 
('
	insert into #Temp
	(
		UID,
		IPAddress,
		VisitDate,
		Actions,
		SourceCode,
		CampaignCode,
		UrlLink,
		Email,
		FirstName,
		LastName,
		Lang
	)
	SELECT t.UID, t.IPAddress, t.VisitDate, t.Actions, t.SourceCode, t.CampaignCode, t.UrlLink, c.Email, c.FirstName, c.LastName, c.Lang FROM tblTracker as t INNER JOIN tblContact as c On t.UID = c.UID WHERE t.Lang='''+@Lang+'''')

EXEC (@sql)

select * from #Temp Order By VisitDate DESC


exec [sp_TrackerCustomerBooked] 'it'