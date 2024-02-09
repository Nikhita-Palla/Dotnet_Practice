-- Using the database
use WordVoyager;



-- Creating proceedure for inserting values to TagTable
create procedure InsertTag
	@Name nvarchar(100)
as
begin
	insert into TagTable(Name) 
	values (@Name)
end;

-- Executing the above proceedure for inserting values to TagTable
exec InsertTag 'SQL'
exec InsertTag 'Travel'




-- Creating proceedure to update the name of a tag when TagId is given
create procedure updateTagNameWithTagId
	@TagId int,
	@NewName text
as
begin
	update TagTable set Name=@NewName where TagId=@TagId
end

-- Executing proceedure to update the name of a tag when TagId is given
exec updateTagNameWithTagId 1,'MySQL'




--Creating a proceedure to delete a row based on TagId
create procedure deleteTagId
	@TagId int
as
begin
	delete from TagTable where TagId=@TagId
end

-- Executing proceedure to delete a row based on TagId
exec deleteTagId 1



-- Creating proceedures to select tags with all the columns based on TagId
create procedure getTagWithTagId
	@TagId int
as
begin
	select * from TagTable where TagId=@TagId
end;

-- Executing proceedures to select tags with all the columns based on TagId
exec getTagWithTagId 2




-- Creating proceedures to select all the tags from the TagTable
create procedure getTagTable
as
begin
	select * from TagTable
end;

-- Executing proceedures to select all the tags from the TagTable
exec getTagTable


