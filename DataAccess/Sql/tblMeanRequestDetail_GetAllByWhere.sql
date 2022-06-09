

use asiaticadb
GO

-- Drop the 'tblMeanRequestDetail_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblMeanRequestDetail_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblMeanRequestDetail_GetAllByWhere]
GO

-- Gets all records from the 'tblMeanRequestDetail' table.
CREATE PROCEDURE [tblMeanRequestDetail_GetAllByWhere]
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

execute('select md.*,m.* From tblMeanRequestDetail as md INNER JOIN tblMean as m
On md.MeanID=m.ID ' + @Where + ' ' + @Order)

GO
