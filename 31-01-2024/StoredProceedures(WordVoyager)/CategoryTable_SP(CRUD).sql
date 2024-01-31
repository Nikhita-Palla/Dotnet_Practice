-- Using the database
use WordVoyager;



-- Creating proceedure for inserting values to CategoryTable
create procedure InsertCategory
	@CategoryId int,
	@name nvarchar(100),
	@Description text
as
begin
	insert into CategoryTable(CategoryId,name,Description) 
	values (@CategoryId,@name,@Description)
end;

-- Executing the above proceedure to add category to CategoryTable
exec InsertCategory 1,'Technology', 'Articles related to technology and innovation'
exec InsertCategory 2,'Travel', 'Explore the world through travel articles'




-- Creating proceedure to update the description of a category when CategoryId is given
create procedure updateDescriptionInCategoryId
	@CategoryId int,
	@NewDescription text
as
begin
	update CategoryTable set Description=@NewDescription where CategoryId=@CategoryId
end

-- Executing proceedure to update the description of a category when CategoryId is given
exec updateDescriptionInCategoryId 1,'Technology and Innovation'




--Creating a proceedure to delete a row based on CategoryId
create procedure deleteCategoryId
	@CategoryId int
as
begin
	delete from CategoryTable where CategoryId=@CategoryId
end

-- Executing proceedure to delete a row based on ArticleId
exec deleteCategoryId 1



-- Creating proceedures to select categories with all the columns based on CategoryId
create procedure getCategoryWithCategoryId
	@CategoryId int
as
begin
	select * from CategoryTable where CategoryId=@CategoryId
end;

-- Executing proceedures to select categories with all the columns based on CategoryId
exec getCategoryWithCategoryId 1



-- Creating proceedures to get Description with CategoryId
create procedure getDescriptionWithCategoryId
	@CategoryId int
as
begin
	select Description from CategoryTable where CategoryId=@CategoryId
end;

-- Executing proceedures to get Description with CategoryId
exec getDescriptionWithCategoryId 1




-- Creating proceedures to select all the categories from the CategoryTable
create procedure getCategoryTable
as
begin
	select * from CategoryTable
end;

-- Executing proceedures to select all the categories from the CategoryTable
exec getCategoryTable


