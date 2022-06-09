use asiaticadb
GO

-- Drop the 'tblHotelCategory_GetDataRandom' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_GetDataRandom') AND type='P')
	DROP PROCEDURE [tblHotelCategory_GetDataRandom]
GO

-- Gets all records from the 'tblHotelCategory' table.
CREATE PROCEDURE [tblHotelCategory_GetDataRandom]
@Lang nvarchar(10) = '',
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

execute('Select * From tblHotelCategory ' + @Where + ' ' + @Order)

GO
