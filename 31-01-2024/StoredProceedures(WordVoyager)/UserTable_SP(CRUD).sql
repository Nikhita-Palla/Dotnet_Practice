-- Using the database
use WordVoyager;



-- Creating proceedure for inserting values to user table
create procedure InsertUsers
	@UserId int,
	@UserName nvarchar(100),
	@Email nvarchar(100),
	@PasswordHash varchar(100),
	@RegistrationDate datetime
as
begin
	insert into dbo.UserTable(UserId,UserName,Email,PasswordHash,RegistrationDate) 
	values (@UserId,@UserName,@Email,@PasswordHash,@RegistrationDate)
end;

-- Executing the above proceedure to add users to UserTable
exec InsertUsers 1,'Seeta','seeta@epam.com','hqsueba','2024-01-22';
exec InsertUsers 2,'Geeta','geeta@epam.com','vsg34sv','2024-01-23';
exec InsertUsers 3,'Meeta','meeta@epam.com','qvbhxs','2024-01-25';
exec InsertUsers 4,'Sheela','sheela@epam.com','wbqhdg','2024-01-22';
exec InsertUsers 5,'Ram','ram@epam.com','qshbehb','2024-01-21';
exec InsertUsers 6,'Shyam','shyam@epam.com','cbhvrjer','2024-01-19';


-- Creating proceedure when one column is not given
create procedure InsertUsers1
	@UserId int,
	@UserName nvarchar(100),
	@Email nvarchar(100),
	@RegistrationDate datetime
as
begin
	insert into dbo.UserTable(UserId,UserName,Email,RegistrationDate) 
	values (@UserId,@UserName,@Email,@RegistrationDate)
end;

-- Executing proceedure when one column is not given
exec InsertUsers1 8,'Shyam','shyam@epam.com','2024-01-19';

-- Creating proceedure to update the Email when UserId is given.
create procedure updateEmail
	@UserId int,
	@NewEmail nvarchar(100)
as
begin
	update UserTable set Email=@NewEmail where UserId=@UserId
end

-- Executing the proceedure to update the password when UserId is given.
exec updateEmail 2,'venkat@epam.com'
exec updateEmail 4,'sheela.k@epam.com'
exec updateEmail 8,'raghu@epam.com'


-- Creating proceedure to update the UserName when UserId is given.
create procedure updateUserName
	@UserId int,
	@NewUserName nvarchar(100)
as
begin
	update UserTable set UserName=@NewUserName where UserId=@UserId
end

-- Executing the proceedure to update the password when UserId is given.
exec updateUserName 2,'Venkat'
exec updateUserName 8,'Raghu'




-- Creating proceedure to update the PasswordHash when UserId is given.
create procedure updatePasswordHash
	@UserId int,
	@NewPasswordHash varchar(100)
as
begin
	update UserTable set PasswordHash=@NewPasswordHash where UserId=@UserId
end

-- Executing the proceedure to update the password when UserId is given.
exec updatePasswordHash 2,'qwfdsoijde'
exec updatePasswordHash 6,'gwedbjx'




--Creating a proceedure to delete a row based on UserId
create procedure deleteUser
	@UserId int
as
begin
	delete from UserTable where UserId=@UserId
end

-- Executing proceedure to delete a row based on UserId
exec deleteUser 6




-- Creating proceedures to select users with all the columns based on Email
create procedure getUserWithEmail
	@Email nvarchar(100)
as
begin
	select * from UserTable where Email=@Email
end;

-- Executing the proceedure which select users with all the columns based on Email
exec getUserWithEmail 'seeta@epam.com'



-- Creating proceedures to get UserName with UserId
create procedure getUserNameWithUserId
	@UserId int
as
begin
	select UserName from UserTable where UserId=@UserId
end;

-- Executing the proceedure which select users with all the columns based on Email
exec getUserNameWithUserId 1
exec getUserNameWithUserId 5



-- Creating proceedures to select all the users from the UserTable
create procedure getUserTable
as
begin
	select * from UserTable
end;

-- Executing the proceedure which selects all the users from the UserTable
exec getUserTable


