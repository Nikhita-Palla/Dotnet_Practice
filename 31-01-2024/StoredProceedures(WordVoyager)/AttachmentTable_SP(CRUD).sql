-- Using the database
use WordVoyager;
 
 
-- Creating proceedure for inserting values to AttachmentTable
create procedure InsertAttachment
	@ArticleId int,
	@FileName nvarchar(100),
	@FileType nvarchar(100),
	@FilePath nvarchar(100),
	@UploadDate datetime
as
begin
	insert into AttachmentTable(ArticleId,FileName,FileType,FilePath,UploadDate) 
	values (@ArticleId,@FileName,@FileType,@FilePath,@UploadDate)
end;
 
-- Executing the above proceedure for inserting values to AttachmentTable
exec InsertAttachment 1, 'sql_diagram.png', 'image/png', '/attachments/sql_diagram.png', '2022-01-08 14:00:00'
exec InsertAttachment 2, 'travel_guide.pdf', 'application/pdf', '/attachments/travel_guide.pdf', '2022-01-14 11:45:00'
 
 
 
-- Creating proceedure to update the UploadDate of a Attachement when AttachmentId is given
create procedure updateUploadDateWithAttachmentId
	@AttachmentId int,
	@NewUploadDate datetime
as
begin
	update AttachmentTable set UploadDate=@NewUploadDate where AttachmentId=@AttachmentId
end
 
-- Executing proceedure to to update the FileName of a Attachement when AttachmentId is given
exec updateUploadDateWithAttachmentId 1,'2022-01-10 14:00:00'
 
 
 
--Creating a proceedure to delete a row based on AttachmentId
create procedure deleteAttachmentId
	@AttachmentId int
as
begin
	delete from AttachmentTable where AttachmentId=@AttachmentId
end
 
-- Executing proceedure to delete a row based on AttachmentId
exec deleteAttachmentId 1
 
 
-- Creating proceedures to select attachments with all the columns based on AttachmentId
create procedure getAttachmentWithAttachmentId
	@AttachmentId int
as
begin
	select * from AttachmentTable where AttachmentId=@AttachmentId
end;
 
-- Executing proceedures to select attachments with all the columns based on AttachmentId
exec getAttachmentWithAttachmentId 1
 
 
-- Creating proceedures to get FileName with AttachmentId
create procedure getFileNameWithAttachmentId
	@AttachmentId int
as
begin
	select FileName from AttachmentTable where AttachmentId=@AttachmentId
end;
 
-- Executing proceedures to get FileName with AttachmentId
exec getFileNameWithAttachmentId 1
 
 
 
-- Creating proceedures to select all the attachments from the AttachmentTable
create procedure getAttachmentTable
as
begin
	select * from AttachmentTable
end;
 
-- Executing proceedures to select all the attachments from the AttachmentTable
exec getAttachmentTable