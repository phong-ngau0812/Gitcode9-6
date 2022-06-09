USE [asiaticadb]
Go

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HtmlCached](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[NewsID] [bigint] NULL,
	[CatID] [int] NULL,
	[ChangeTime] [datetime] NULL,
 CONSTRAINT [PK_HtmlCached] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
Create TRIGGER [dbo].[tblTestimonial_HtmlCached]
   ON  [dbo].[tblTestimonial]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @TourID int,@PostedDate datetime
	select @ID = ID, @TourID= TourID,@PostedDate = PostedDate from Deleted 
	if (@ID is null) 
	begin
		select @ID =  ID,@TourID= TourID,@PostedDate = PostedDate from INSERTED
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@TourID= TourID,@PostedDate = PostedDate from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@TourID is null) set @TourID = 0
	if (@PostedDate is null) set @PostedDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@TourID,@PostedDate)	

END

go

Create proc [dbo].[Insert_HtmlCached]
as
begin
 INSERT INTO [dbo].[HtmlCached]([NewsID],[CatID],[ChangeTime])VALUES('',0,dateadd(day,-1,getdate()))
 select NewsID, CatID as Cat_ID from [HtmlCached] where [ChangeTime] <=getdate() and len(NewsID) > 1
 delete from [HtmlCached] where [ChangeTime] <=getdate() 
 EXEC dbo.AspNet_SqlCacheUpdateChangeIdStoredProcedure N'tblTestimonial'
end

go

Create TRIGGER [dbo].[tblAttractions_HtmlCached]
   ON  [dbo].[tblAttractions]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @CountryID int,@RegDate datetime
	select @ID = ID, @CountryID= CountryID,@RegDate = RegDate from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@CountryID= CountryID,@RegDate = RegDate from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@CountryID= CountryID,@RegDate = RegDate from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@CountryID is null) set @CountryID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@CountryID,@RegDate)	

END


go

Create TRIGGER [dbo].[tblAttractionsGallery_HtmlCached]
   ON  [dbo].[tblAttractionsGallery]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @AttractionsID int,@RegDate datetime
	select @ID = ID, @AttractionsID= AttractionsID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@AttractionsID= AttractionsID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@AttractionsID= AttractionsID,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@AttractionsID is null) set @AttractionsID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@AttractionsID,@RegDate)	

END


go

Create TRIGGER [dbo].[tblBannerHome_HtmlCached]
   ON  [dbo].[tblBannerHome]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @CountryID int,@RegDate datetime
	select @ID = ID, @CountryID= CountryID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@CountryID= CountryID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@CountryID= CountryID,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@CountryID is null) set @CountryID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@CountryID,@RegDate)	

END


go

Create TRIGGER [dbo].[tblHotel_HtmlCached]
   ON  [dbo].[tblHotel]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @CateID int,@RegDate datetime
	select @ID = ID, @CateID= CateID,@RegDate = RegDate from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@CateID= CateID,@RegDate = RegDate from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@CateID= CateID,@RegDate = RegDate from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@CateID is null) set @CateID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@CateID,@RegDate)	

END

go

Create TRIGGER [dbo].[tblHotelCategory_HtmlCached]
   ON  [dbo].[tblHotelCategory]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @CountryID int,@RegDate datetime
	select @ID = ID, @CountryID= CountryID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@CountryID= CountryID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@CountryID= CountryID,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@CountryID is null) set @CountryID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@CountryID,@RegDate)	

END

go

Create TRIGGER [dbo].[tblHotelGallery_HtmlCached]
   ON  [dbo].[tblHotelGallery]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @HotelID int,@RegDate datetime
	select @ID = ID, @HotelID= HotelID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@HotelID= HotelID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@HotelID= HotelID,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@HotelID is null) set @HotelID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@HotelID,@RegDate)	

END

go

Create TRIGGER [dbo].[tblHotelService_HtmlCached]
   ON  [dbo].[tblHotelService]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @Status int,@RegDate datetime
	select @ID = ID, @Status= Status,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@Status= Status,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@Status= Status,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@Status is null) set @Status = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@Status,@RegDate)	

END


go

Create TRIGGER [dbo].[tblHotelStyle_HtmlCached]
   ON  [dbo].[tblHotelStyle]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @Status int,@RegDate datetime
	select @ID = ID, @Status= Status,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@Status= Status,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@Status= Status,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@Status is null) set @Status = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@Status,@RegDate)	

END

go

Create TRIGGER [dbo].[tblNews_HtmlCached]
   ON  [dbo].[tblNews]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @CateID int,@RegDate datetime
	select @ID = ID, @CateID= CateID,@RegDate = RegDate from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@CateID= CateID,@RegDate = RegDate from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@CateID= CateID,@RegDate = RegDate from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@CateID is null) set @CateID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@CateID,@RegDate)	

END



go

Create TRIGGER [dbo].[tblPromotion_HtmlCached]
   ON  [dbo].[tblPromotion]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @Status int,@RegDate datetime
	select @ID = ID, @Status= Status,@RegDate = RegDate from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@Status= Status,@RegDate = RegDate from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@Status= Status,@RegDate = RegDate from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@Status is null) set @Status = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@Status,@RegDate)	

END


go

Create TRIGGER [dbo].[tblStaff_HtmlCached]
   ON  [dbo].[tblStaff]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @ObjectID int,@RegDate datetime
	select @ID = ID, @ObjectID= ObjectID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@ObjectID= ObjectID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@ObjectID= ObjectID,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@ObjectID is null) set @ObjectID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@ObjectID,@RegDate)	

END


go

Create TRIGGER [dbo].[tblTestimonialGallery_HtmlCached]
   ON  [dbo].[tblTestimonialGallery]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @TestimonialID int,@RegDate datetime
	select @ID = ID, @TestimonialID= TestimonialID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@TestimonialID= TestimonialID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@TestimonialID= TestimonialID,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@TestimonialID is null) set @TestimonialID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@TestimonialID,@RegDate)	

END


go

Create TRIGGER [dbo].[tblTour_HtmlCached]
   ON  [dbo].[tblTour]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @CateID int,@RegDate datetime
	select @ID = ID, @CateID= CateID,@RegDate = RegDate from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@CateID= CateID,@RegDate = RegDate from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@CateID= CateID,@RegDate = RegDate from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@CateID is null) set @CateID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@CateID,@RegDate)	

END

go

Create TRIGGER [dbo].[tblTourAttractions_HtmlCached]
   ON  [dbo].[tblTourAttractions]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @TourID int, @AttractionsID int,@RegDate datetime
	select @TourID = TourID, @AttractionsID= AttractionsID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@TourID is null) 
	begin
		select @TourID =  TourID,@AttractionsID= AttractionsID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@TourID is null)
	begin
	   select @TourID =  TourID,@AttractionsID= AttractionsID,@RegDate = getdate() from Deleted
	end 
	if (@TourID is null) set @TourID = 0
	if (@AttractionsID is null) set @AttractionsID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@TourID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@TourID,@AttractionsID,@RegDate)	

END


go

Create TRIGGER [dbo].[tblTourCategory_HtmlCached]
   ON  [dbo].[tblTourCategory]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @CountryID int,@RegDate datetime
	select @ID = ID, @CountryID= CountryID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@CountryID= CountryID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@CountryID= CountryID,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@CountryID is null) set @CountryID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@CountryID,@RegDate)	

END

go

Create TRIGGER [dbo].[tblTourGallery_HtmlCached]
   ON  [dbo].[tblTourGallery]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @TourID int,@RegDate datetime
	select @ID = ID, @TourID= TourID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@TourID= TourID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@TourID= TourID,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@TourID is null) set @TourID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@TourID,@RegDate)	

END

go

Create TRIGGER [dbo].[tblTourHotel_HtmlCached]
   ON  [dbo].[tblTourHotel]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @HotelID int,@RegDate datetime
	select @ID = TourID, @HotelID= HotelID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  TourID,@HotelID= HotelID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  TourID,@HotelID= HotelID,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@HotelID is null) set @HotelID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@HotelID,@RegDate)	

END


go

Create TRIGGER [dbo].[tblTourPrograme_HtmlCached]
   ON  [dbo].[tblTourPrograme]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @TourID int,@RegDate datetime
	select @ID = ID, @TourID= TourID,@RegDate = RegDate from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@TourID= TourID,@RegDate = RegDate from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@TourID= TourID,@RegDate = RegDate from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@TourID is null) set @TourID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@TourID,@RegDate)	

END

go

Create TRIGGER [dbo].[tblTravelGuide_HtmlCached]
   ON  [dbo].[tblTravelGuide]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @CountryID int,@RegDate datetime
	select @ID = ID, @CountryID= CountryID,@RegDate = RegDate from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@CountryID= CountryID,@RegDate = RegDate from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@CountryID= CountryID,@RegDate = RegDate from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@CountryID is null) set @CountryID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@CountryID,@RegDate)	

END

go

Create TRIGGER [dbo].[tblTravelReport_HtmlCached]
   ON  [dbo].[tblTravelReport]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @CountryID int,@RegDate datetime
	select @ID = ID, @CountryID= CountryID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@CountryID= CountryID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@CountryID= CountryID,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@CountryID is null) set @CountryID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@CountryID,@RegDate)	

END


go

Create TRIGGER [dbo].[tblTravelReport_HtmlCached]
   ON  [dbo].[tblTravelReport]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @CountryID int,@RegDate datetime
	select @ID = ID, @CountryID= CountryID,@RegDate = getdate() from Deleted -- where Deleted.News_Status = 3
	if (@ID is null) 
	begin
		select @ID =  ID,@CountryID= CountryID,@RegDate = getdate() from INSERTED--  where INSERTED.News_Status = 3
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@CountryID= CountryID,@RegDate = getdate() from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@CountryID is null) set @CountryID = 0
	if (@RegDate is null) set @RegDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@CountryID,@RegDate)	

END

Go
Alter TRIGGER [dbo].[tblAbout_HtmlCached]
   ON  [dbo].[tblAbout]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @ID int, @ParentID int,@PostedDate datetime
	select @ID = ID, @ParentID= ParentID,@PostedDate = RegDate from Deleted 
	if (@ID is null) 
	begin
		select @ID =  ID,@ParentID= ParentID,@PostedDate = RegDate from INSERTED
	end
	if(@ID is null)
	begin
	   select @ID =  ID,@ParentID= ParentID,@PostedDate = RegDate from Deleted
	end 
	if (@ID is null) set @ID = 0
	if (@ParentID is null) set @ParentID = 0
	if (@PostedDate is null) set @PostedDate = getdate()
	if (@ID > 0)
    INSERT INTO HtmlCached(NewsID,CatID,ChangeTime)VALUES(@ID,@ParentID,@PostedDate)	

END