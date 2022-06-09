use [asiaticadb]
GO

-- Drop the 'tblPermissionRole_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPermissionRole_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblPermissionRole_GetAllByWhere]
GO

-- Gets all records from the 'tblPermissionRole' table.
CREATE PROCEDURE [tblPermissionRole_GetAllByWhere]
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

execute('select pr.RoleID, pr.PermissionFlg, f.* From tblPermissionRole as pr RIGHT JOIN tblFunction as f
On pr.FunctionID = f.ID ' + @Where + ' ' + @Order)

GO



