-- Using the database
use WordVoyager;



-- Creating proceedure for inserting values to Articletable
create procedure InsertArticles
	@Title nvarchar(100),
	@Content text,
	@PublishedDate datetime,
	@LastModifiedDate datetime,
	@AuthorId int,
	@CategoryId int
as
begin
	insert into ArticleTable(Title,Content,PublishedDate,LastModifiedDate,AuthorId,CategoryId) 
	values (@Title,@Content,@PublishedDate,@LastModifiedDate,@AuthorId,@CategoryId)
end;

-- Executing the above proceedure to add articles to ArticleTable
exec InsertArticles 'Introduction to SQL', 'This is a guide to SQL...', '2022-01-05 08:45:00', '2022-01-05 08:45:00', 1, 1
exec InsertArticles 'Best Places to Visit in 2022', 'Explore amazing destinations...', '2022-01-10 15:20:00', '2022-01-12 09:30:00', 2, 2;




-- Creating proceedure to update the Title of a article when ArticleId is given
create procedure updateTitleInArticleTable
	@ArticleId int,
	@NewTitle nvarchar(100)
as
begin
	update ArticleTable set Title=@NewTitle where ArticleId=@ArticleId
end

-- Executing the proceedure to update the Title of a article when ArticleId is given
exec updateTitleInArticleTable 1,'Introduction to MySQL'




--Creating a proceedure to delete a row based on ArticleId
create procedure deleteArticle
	@ArticleId int
as
begin
	delete from ArticleTable where ArticleId=@ArticleId
end

-- Executing proceedure to delete a row based on ArticleId
exec deleteArticle 1



-- Creating proceedures to select articles with all the columns based on AuthorId
create procedure getArticleWithAuthorId
	@AuthorId nvarchar(100)
as
begin
	select * from ArticleTable where AuthorId=@AuthorId
end;

-- Executing proceedures to select articles with all the columns based on AuthorId
exec getArticleWithAuthorId 1



-- Creating proceedures to get title with ArticleId
create procedure getTitleWithArticleId
	@ArticleId int
as
begin
	select Title from ArticleTable where ArticleId=@ArticleId
end;

-- Executing proceedures to get title with ArticleId
exec getTitleWithArticleId 1




-- Creating proceedures to select all the articles from the ArticleTable
create procedure getArticleTable
as
begin
	select * from ArticleTable
end;

-- Executing proceedures to select all the articles from the ArticleTable
exec getArticleTable


