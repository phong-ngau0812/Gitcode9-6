use [asiaticadb]
GO

-- Drop the 'tblUser_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblUser_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblUser_GetAllByWhere]
GO

-- Gets all records from the 'tblUser' table.
CREATE PROCEDURE [tblUser_GetAllByWhere]
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

execute('select u.* From tblUser as u ' + @Where + ' ' + @Order)

Go

