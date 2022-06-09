create proc [dbo].[Insert_HtmlCached]
as
begin
 INSERT INTO [dbo].[HtmlCached]([NewsID],[CatID],[ChangeTime])VALUES('',0,dateadd(day,-1,getdate()))
 select NewsID, CatID as Cat_ID from [HtmlCached] where [ChangeTime] <=getdate() and len(NewsID) > 1
 delete from [HtmlCached] where [ChangeTime] <=getdate() 
 --EXEC dbo.AspNet_SqlCacheUpdateChangeIdStoredProcedure N'tblTestimonials'
end