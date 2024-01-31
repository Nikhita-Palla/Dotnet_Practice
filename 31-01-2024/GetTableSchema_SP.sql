use WordVoyager;

-- Creating proceedure to rename a column name
create procedure renameColumn
    @TableName nvarchar(100),
    @OldColumnName nvarchar(100),
    @NewColumnName nvarchar(100)
as
begin
    declare @query nvarchar(max);
 
    set @query = 'alter table ' + quotename(@TableName) +
               ' rename column ' + quotename(@OldColumnName) +
               ' to ' + quotename(@NewColumnName);
end
 
-- Executing the proceedure to rename column
exec renameColumn UserTable,UserName,Username

-- Creating proceedure to get TableSchema
create procedure GetTableSchema
    @TableName NVARCHAR(100)
as
begin
    -- Check if the table exists
    if exists (select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = @TableName)
    begin
        -- Retrieve schema information
        select
            COLUMN_NAME AS 'ColumnName',
            DATA_TYPE AS 'DataType',
            CHARACTER_MAXIMUM_LENGTH AS 'MaxLength',
            IS_NULLABLE AS 'IsNullable'
        from
            INFORMATION_SCHEMA.COLUMNS
        WHERE
            TABLE_NAME = @TableName;
    END
    ELSE
    BEGIN
        -- Table does not exist
        PRINT 'Table does not exist.';
    END
END;

exec GetTableSchema AttachmentTable
exec GetTableSchema ArticleTable