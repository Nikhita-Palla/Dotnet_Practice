-- Using the database
use WordVoyager;



-- Creating proceedure for inserting values to CommentTable
create procedure InsertComment
	@ArticleId int,
	@UserId int,
	@Content text,
	@CommentDate datetime
as
begin
	insert into CommentTable(ArticleId,Userid,Content,CommentDate) 
	values (@ArticleId,@UserId,@Content,@CommentDate)
end;

-- Executing the above proceedure to add category to CategoryTable
exec InsertComment  1, 2, 'Great guide!', '2022-01-06 11:10:00'
exec InsertComment  2, 1, 'I want to visit these places!', '2022-01-12 10:00:00'




-- Creating proceedure to update the content of a comment when CommentId is given
create procedure updateCommentInCommentId
	@CommentId int,
	@NewContent text
as
begin
	update CommentTable set Content=@NewContent where CommentId=@CommentId
end

-- Executing proceedure to update the content of a comment when CommentId is given
exec updateCommentInCommentId 1,'Great guide! , It is higly helpful'




--Creating a proceedure to delete a row based on CommentId
create procedure deleteCommentId
	@CommentId int
as
begin
	delete from CommentTable where CommentId=@CommentId
end

-- Executing proceedure to delete a row based on CommentId
exec deleteCommentId 1



-- Creating proceedures to select comments with all the columns based on CommentId
create procedure getCommentWithCommentId
	@CommentId int
as
begin
	select * from CommentTable where CommentId=@CommentId
end;

-- Executing proceedures to select comments with all the columns based on CommentId
exec getCommentWithCommentId 2



-- Creating proceedures to get Content with CommentId
create procedure getContentWithCommentId
	@CommentId int
as
begin
	select Content from CommentTable where CommentId=@CommentId
end;

-- Executing proceedures to get Content with CommentId
exec getContentWithCommentId 2



-- Creating proceedures to select all the comments from the CommentTable
create procedure getCommentTable
as
begin
	select * from CommentTable
end;

-- Executing proceedures to select all the comments from the CommentTable
exec getCommentTable


