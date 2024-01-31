-- Using the database
use WordVoyager;



-- Creating proceedure for inserting values to ArticleTagTable
create procedure InsertArticleTag
	@ArticleId int,
	@TagId int
as
begin
	insert into ArticleTagTable(ArticleId,TagId) 
	values (@ArticleId,@TagId)
end;

-- Executing the above proceedure to add values to ArticleTagTable
exec InsertArticleTag 1,1
exec InsertArticleTag 2,2






-- Creating proceedures to select all the ArticleTag from the ArticleTag
create procedure getArticleTagTable
as
begin
	select * from ArticleTagTable
end;

-- Executing proceedures to select all the comments from the CommentTable
exec getArticleTagTable


