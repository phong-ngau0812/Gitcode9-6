use asiaticadb
GO

-- Drop the 'tblPriceRequest_GetAllByWhere' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPriceRequest_GetAllByWhere') AND type='P')
	DROP PROCEDURE [tblPriceRequest_GetAllByWhere]
GO

-- Gets all records from the 'tblPriceRequest' table.
CREATE PROCEDURE [tblPriceRequest_GetAllByWhere]
@Where nvarchar(4000) = '',
@Order nvarchar(4000) = ''
AS
IF @Where <> ''
		SET @Where = ' WHERE ' + @Where 

	IF @Order <> '' 
		SET @Order = ' ORDER BY ' + @Order

execute('Select r.*,c.Gender,c.FirstName,c.LastName,c.Email,t.TourName,t.TourCode From tblPriceRequest as r
LEFT JOIN tblCustomer as c
ON r.CustomerID = c.ID
LEFT JOIN tblTour as t
ON r.TourID = t.ID ' + @Where + ' ' + @Order)
GO