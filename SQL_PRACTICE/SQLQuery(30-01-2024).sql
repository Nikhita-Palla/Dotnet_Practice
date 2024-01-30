-- Creating database WordVoyager
create database WordVoyager;

-- To use the database
use WordVoyager;

-- Creating usertable (Stores information about users who can be authors and/or reader)
create table UserTable(
UserId int PRIMARY KEY,
UserName nvarchar(100),
Email nvarchar(100),
PasswordHash nvarchar(100),
RegistrationDate datetime
);
-- to see structure of UserTable
SP_help 'UserTable';

-- Creating Article table (Stores the articles published on the website)
create table ArticleTable(
ArticleId int PRIMARY KEY,
Title nvarchar(100),
Content text,
PublishedDate datetime,
LastModifiedDate datetime,
AuthorId int foreign key references UserTable(UserId),
CategoryId int foreign key references CategoryTable(CategoryId),
);
-- to see structure of ArticleTable
SP_help 'ArticleTable';

-- Category table ( Stores different categories for articles.)
create table CategoryTable(
CategoryId int primary key,
name nvarchar(100),
Description text
);
-- to see structure of CategoryTable
SP_help 'CategoryTable';

-- Comment Table (Stores comments made on articles)
create table CommentTable(
CommentId int primary key,
ArticleId int foreign key references ArticleTable(ArticleId),
Userid int foreign key references UserTable(UserId),
Content text,
CommentDate datetime
);
-- to see structure of CommentTable
SP_help 'CommentTable';

-- Article tag table (Manages the many-to-many relationship between articles and tags.So making the ArticleId and TagId as primary keys)
create table ArticleTagTable (
ArticleId int foreign key references ArticleTable(ArticleId),
TagId INT FOREIGN KEY REFERENCES TagTable(TagId),
primary key (ArticleId, TagId)
);
-- to see structure of ArticleTagTable
SP_help 'ArticleTagTable';

-- Tag table ( stores tags for articles)
create table TagTable (
TagId int primary key,
Name nvarchar(100)
);
-- to see structure of TagTable
SP_help 'TagTable';

-- Attachment Table ( Stores attachments related to articles)
create table AttachmentTable (
AttachmentId int primary key,
ArticleId int foreign key references ArticleTable(ArticleId),
FileName nvarchar(100),
FileType nvarchar(100),
FilePath nvarchar(100),
UploadDate datetime
);
-- to see structure of AttachmentTable
SP_help 'AttachmentTable';