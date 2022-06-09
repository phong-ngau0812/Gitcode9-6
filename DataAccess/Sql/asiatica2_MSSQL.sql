
---	CuongLM Create 2008.11.14

----------------------------------------------------------
-- All rights reserved.
----------------------------------------------------------

USE [asiaticadb]
GO

----------------------------------------------------------
-- Stored procedures for the 'tblHotelCategory' table.
----------------------------------------------------------

-- Drop the 'tblHotelCategory_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_GetAll') AND type='P')
	DROP PROCEDURE [tblHotelCategory_GetAll]
GO

-- Gets all records from the 'tblHotelCategory' table.
CREATE PROCEDURE [tblHotelCategory_GetAll]
AS
	SELECT [ID], [CountryID], [AttractionsID], [ImageFile], [OrderBy], [Status]
	FROM [dbo].[tblHotelCategory]
GO

-- Drop the 'tblHotelCategory_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelCategory_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblHotelCategory' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblHotelCategory_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[ID] Int		,
					[CountryID] Int		,
					[AttractionsID] Int		,
					[ImageFile] nvarchar(255)		,
					[OrderBy] Int		,
					[Status] Int		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [ID], [CountryID], [AttractionsID], [ImageFile], [OrderBy], [Status]
		FROM [dbo].[tblHotelCategory]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblHotelCategory]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [CountryID], [AttractionsID], [ImageFile], [OrderBy], [Status] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [ID], [CountryID], [AttractionsID], [ImageFile], [OrderBy], [Status]
				FROM [dbo].[tblHotelCategory]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblHotelCategory]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [CountryID], [AttractionsID], [ImageFile], [OrderBy], [Status]
				FROM [dbo].[tblHotelCategory]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblHotelCategory]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblHotelCategory_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelCategory_GetAdHoc]
GO

-- Gets records from the 'tblHotelCategory' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblHotelCategory_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [CountryID], [AttractionsID], [ImageFile], [OrderBy], [Status]
		FROM [dbo].[tblHotelCategory]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblHotelCategory_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelCategory_GetByPrimaryKey]
GO

-- Gets a record from the 'tblHotelCategory' table using the primary key value.
CREATE PROCEDURE [tblHotelCategory_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [CountryID], [AttractionsID], [ImageFile], [OrderBy], [Status] 
	FROM [dbo].[tblHotelCategory] WHERE
		[ID] = @ID
GO

-- Drop the 'tblHotelCategory_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_Insert') AND type='P')
	DROP PROCEDURE [tblHotelCategory_Insert]
GO

-- Inserts a new record into the 'tblHotelCategory' table.
CREATE PROCEDURE [tblHotelCategory_Insert]
	@CountryID Int,
	@AttractionsID Int,
	@ImageFile nvarchar(255),
	@OrderBy Int,
	@Status Int
AS
	INSERT INTO [dbo].[tblHotelCategory]
	(
		[CountryID],
		[AttractionsID],
		[ImageFile],
		[OrderBy],
		[Status]
	)
	VALUES
	(
		@CountryID,
		@AttractionsID,
		@ImageFile,
		@OrderBy,
		@Status
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblHotelCategory_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_Update') AND type='P')
	DROP PROCEDURE [tblHotelCategory_Update]
GO

-- Updates a record in the 'tblHotelCategory' table.
CREATE PROCEDURE [tblHotelCategory_Update]
	-- The rest of writeable parameters
	@CountryID Int,
	@AttractionsID Int,
	@ImageFile nvarchar(255),
	@OrderBy Int,
	@Status Int,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblHotelCategory] SET
		[CountryID] = @CountryID,
		[AttractionsID] = @AttractionsID,
		[ImageFile] = @ImageFile,
		[OrderBy] = @OrderBy,
		[Status] = @Status
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblHotelCategory_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_Save') AND type='P')
	DROP PROCEDURE [tblHotelCategory_Save]
GO

-- Insert or updates a new record in the 'tblHotelCategory' table.
CREATE PROCEDURE [tblHotelCategory_Save]
	-- The rest of writeable parameters
	@CountryID Int,
	@AttractionsID Int,
	@ImageFile nvarchar(255),
	@OrderBy Int,
	@Status Int,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblHotelCategory] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblHotelCategory]
		(
			[CountryID],
			[AttractionsID],
			[ImageFile],
			[OrderBy],
			[Status]
		)
		VALUES
		(
			@CountryID,
			@AttractionsID,
			@ImageFile,
			@OrderBy,
			@Status
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblHotelCategory] SET
			[CountryID] = @CountryID,
			[AttractionsID] = @AttractionsID,
			[ImageFile] = @ImageFile,
			[OrderBy] = @OrderBy,
			[Status] = @Status
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblHotelCategory_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelCategory_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblHotelCategory' table using the primary key value.
CREATE PROCEDURE [tblHotelCategory_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblHotelCategory] WHERE
		[ID] = @ID
GO

-- Drop the 'tblHotelCategory_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_DeleteAll') AND type='P')
	DROP PROCEDURE [tblHotelCategory_DeleteAll]
GO

-- Deletes all records from the 'tblHotelCategory' table.
CREATE PROCEDURE [tblHotelCategory_DeleteAll]
AS
	DELETE FROM [dbo].[tblHotelCategory]
GO

-- Drop the 'tblHotelCategory_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategory_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelCategory_DeleteAdHoc]
GO

-- Deletes records from the 'tblHotelCategory' table that match the supplied where clause.
CREATE PROCEDURE [tblHotelCategory_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblHotelCategory]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblHotelCategoryLang' table.
----------------------------------------------------------

-- Drop the 'tblHotelCategoryLang_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategoryLang_GetAll') AND type='P')
	DROP PROCEDURE [tblHotelCategoryLang_GetAll]
GO

-- Gets all records from the 'tblHotelCategoryLang' table.
CREATE PROCEDURE [tblHotelCategoryLang_GetAll]
AS
	SELECT [HotelCategoryID], [Title], [SubDomain], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
	FROM [dbo].[tblHotelCategoryLang]
GO

-- Drop the 'tblHotelCategoryLang_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategoryLang_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelCategoryLang_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblHotelCategoryLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblHotelCategoryLang_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[HotelCategoryID] Int		,
					[Title] nvarchar(255)		,
					[SubDomain] nvarchar(255)		,
					[Description] ntext		,
					[Tag] nvarchar(1000)		,
					[SeoTitle] nvarchar(1000)		,
					[SeoKeyword] nvarchar(1000)		,
					[SeoDescription] nvarchar(1000)		,
					[Lang] nvarchar(10)		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [HotelCategoryID], [Title], [SubDomain], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
		FROM [dbo].[tblHotelCategoryLang]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblHotelCategoryLang]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[HotelCategoryID], [Title], [SubDomain], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [HotelCategoryID], [Title], [SubDomain], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
				FROM [dbo].[tblHotelCategoryLang]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblHotelCategoryLang]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [HotelCategoryID], [Title], [SubDomain], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
				FROM [dbo].[tblHotelCategoryLang]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblHotelCategoryLang]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblHotelCategoryLang_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategoryLang_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelCategoryLang_GetAdHoc]
GO

-- Gets records from the 'tblHotelCategoryLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblHotelCategoryLang_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [HotelCategoryID], [Title], [SubDomain], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
		FROM [dbo].[tblHotelCategoryLang]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblHotelCategoryLang_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategoryLang_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelCategoryLang_GetByPrimaryKey]
GO

-- Gets a record from the 'tblHotelCategoryLang' table using the primary key value.
CREATE PROCEDURE [tblHotelCategoryLang_GetByPrimaryKey]
	@HotelCategoryID Int,
	@Lang nvarchar(10)
AS
	SELECT [HotelCategoryID], [Title], [SubDomain], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang] 
	FROM [dbo].[tblHotelCategoryLang] WHERE
		[HotelCategoryID] = @HotelCategoryID AND
		[Lang] = @Lang
GO

-- Drop the 'tblHotelCategoryLang_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategoryLang_Insert') AND type='P')
	DROP PROCEDURE [tblHotelCategoryLang_Insert]
GO

-- Inserts a new record into the 'tblHotelCategoryLang' table.
CREATE PROCEDURE [tblHotelCategoryLang_Insert]
	@HotelCategoryID Int,
	@Title nvarchar(255),
	@SubDomain nvarchar(255),
	@Description ntext,
	@Tag nvarchar(1000),
	@SeoTitle nvarchar(1000),
	@SeoKeyword nvarchar(1000),
	@SeoDescription nvarchar(1000),
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblHotelCategoryLang]
	(
		[HotelCategoryID],
		[Title],
		[SubDomain],
		[Description],
		[Tag],
		[SeoTitle],
		[SeoKeyword],
		[SeoDescription],
		[Lang]
	)
	VALUES
	(
		@HotelCategoryID,
		@Title,
		@SubDomain,
		@Description,
		@Tag,
		@SeoTitle,
		@SeoKeyword,
		@SeoDescription,
		@Lang
	)
GO

-- Drop the 'tblHotelCategoryLang_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategoryLang_Update') AND type='P')
	DROP PROCEDURE [tblHotelCategoryLang_Update]
GO

-- Updates a record in the 'tblHotelCategoryLang' table.
CREATE PROCEDURE [tblHotelCategoryLang_Update]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	@SubDomain nvarchar(255),
	@Description ntext,
	@Tag nvarchar(1000),
	@SeoTitle nvarchar(1000),
	@SeoKeyword nvarchar(1000),
	@SeoDescription nvarchar(1000),
	-- Primary key parameters
	@HotelCategoryID Int,
	@Lang nvarchar(10)
AS
	UPDATE [dbo].[tblHotelCategoryLang] SET
		[Title] = @Title,
		[SubDomain] = @SubDomain,
		[Description] = @Description,
		[Tag] = @Tag,
		[SeoTitle] = @SeoTitle,
		[SeoKeyword] = @SeoKeyword,
		[SeoDescription] = @SeoDescription
	WHERE
		[HotelCategoryID] = @HotelCategoryID AND
		[Lang] = @Lang
GO
-- Drop the 'tblHotelCategoryLang_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategoryLang_Save') AND type='P')
	DROP PROCEDURE [tblHotelCategoryLang_Save]
GO

-- Insert or updates a new record in the 'tblHotelCategoryLang' table.
CREATE PROCEDURE [tblHotelCategoryLang_Save]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	@SubDomain nvarchar(255),
	@Description ntext,
	@Tag nvarchar(1000),
	@SeoTitle nvarchar(1000),
	@SeoKeyword nvarchar(1000),
	@SeoDescription nvarchar(1000),
	-- Primary key parameters
	@HotelCategoryID Int,
	@Lang nvarchar(10)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblHotelCategoryLang] Where 
	[HotelCategoryID] = @HotelCategoryID 
 AND 
	[Lang] = @Lang 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblHotelCategoryLang]
		(
			[HotelCategoryID],
			[Title],
			[SubDomain],
			[Description],
			[Tag],
			[SeoTitle],
			[SeoKeyword],
			[SeoDescription],
			[Lang]
		)
		VALUES
		(
			@HotelCategoryID,
			@Title,
			@SubDomain,
			@Description,
			@Tag,
			@SeoTitle,
			@SeoKeyword,
			@SeoDescription,
			@Lang
		)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblHotelCategoryLang] SET
			[Title] = @Title,
			[SubDomain] = @SubDomain,
			[Description] = @Description,
			[Tag] = @Tag,
			[SeoTitle] = @SeoTitle,
			[SeoKeyword] = @SeoKeyword,
			[SeoDescription] = @SeoDescription
		WHERE
			[HotelCategoryID] = @HotelCategoryID AND
			[Lang] = @Lang
	END
GO

-- Drop the 'tblHotelCategoryLang_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategoryLang_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelCategoryLang_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblHotelCategoryLang' table using the primary key value.
CREATE PROCEDURE [tblHotelCategoryLang_DeleteByPrimaryKey]
	@HotelCategoryID Int,
	@Lang nvarchar(10)
AS
	DELETE FROM [dbo].[tblHotelCategoryLang] WHERE
		[HotelCategoryID] = @HotelCategoryID AND
		[Lang] = @Lang
GO

-- Drop the 'tblHotelCategoryLang_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategoryLang_DeleteAll') AND type='P')
	DROP PROCEDURE [tblHotelCategoryLang_DeleteAll]
GO

-- Deletes all records from the 'tblHotelCategoryLang' table.
CREATE PROCEDURE [tblHotelCategoryLang_DeleteAll]
AS
	DELETE FROM [dbo].[tblHotelCategoryLang]
GO

-- Drop the 'tblHotelCategoryLang_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelCategoryLang_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelCategoryLang_DeleteAdHoc]
GO

-- Deletes records from the 'tblHotelCategoryLang' table that match the supplied where clause.
CREATE PROCEDURE [tblHotelCategoryLang_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblHotelCategoryLang]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblHotelGallery' table.
----------------------------------------------------------

-- Drop the 'tblHotelGallery_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_GetAll') AND type='P')
	DROP PROCEDURE [tblHotelGallery_GetAll]
GO

-- Gets all records from the 'tblHotelGallery' table.
CREATE PROCEDURE [tblHotelGallery_GetAll]
AS
	SELECT [ID], [HotelID], [ImageFile], [IsList], [IsDetail], [IsBanner], [Status]
	FROM [dbo].[tblHotelGallery]
GO

-- Drop the 'tblHotelGallery_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelGallery_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblHotelGallery' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblHotelGallery_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[ID] Int		,
					[HotelID] Int		,
					[ImageFile] nvarchar(255)		,
					[IsList] Int		,
					[IsDetail] Int		,
					[IsBanner] Int		,
					[Status] Int		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [ID], [HotelID], [ImageFile], [IsList], [IsDetail], [IsBanner], [Status]
		FROM [dbo].[tblHotelGallery]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblHotelGallery]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [HotelID], [ImageFile], [IsList], [IsDetail], [IsBanner], [Status] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [ID], [HotelID], [ImageFile], [IsList], [IsDetail], [IsBanner], [Status]
				FROM [dbo].[tblHotelGallery]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblHotelGallery]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [HotelID], [ImageFile], [IsList], [IsDetail], [IsBanner], [Status]
				FROM [dbo].[tblHotelGallery]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblHotelGallery]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblHotelGallery_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelGallery_GetAdHoc]
GO

-- Gets records from the 'tblHotelGallery' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblHotelGallery_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [HotelID], [ImageFile], [IsList], [IsDetail], [IsBanner], [Status]
		FROM [dbo].[tblHotelGallery]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblHotelGallery_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelGallery_GetByPrimaryKey]
GO

-- Gets a record from the 'tblHotelGallery' table using the primary key value.
CREATE PROCEDURE [tblHotelGallery_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [HotelID], [ImageFile], [IsList], [IsDetail], [IsBanner], [Status] 
	FROM [dbo].[tblHotelGallery] WHERE
		[ID] = @ID
GO

-- Drop the 'tblHotelGallery_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_Insert') AND type='P')
	DROP PROCEDURE [tblHotelGallery_Insert]
GO

-- Inserts a new record into the 'tblHotelGallery' table.
CREATE PROCEDURE [tblHotelGallery_Insert]
	@HotelID Int,
	@ImageFile nvarchar(255),
	@IsList Int,
	@IsDetail Int,
	@IsBanner Int,
	@Status Int
AS
	INSERT INTO [dbo].[tblHotelGallery]
	(
		[HotelID],
		[ImageFile],
		[IsList],
		[IsDetail],
		[IsBanner],
		[Status]
	)
	VALUES
	(
		@HotelID,
		@ImageFile,
		@IsList,
		@IsDetail,
		@IsBanner,
		@Status
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblHotelGallery_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_Update') AND type='P')
	DROP PROCEDURE [tblHotelGallery_Update]
GO

-- Updates a record in the 'tblHotelGallery' table.
CREATE PROCEDURE [tblHotelGallery_Update]
	-- The rest of writeable parameters
	@HotelID Int,
	@ImageFile nvarchar(255),
	@IsList Int,
	@IsDetail Int,
	@IsBanner Int,
	@Status Int,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblHotelGallery] SET
		[HotelID] = @HotelID,
		[ImageFile] = @ImageFile,
		[IsList] = @IsList,
		[IsDetail] = @IsDetail,
		[IsBanner] = @IsBanner,
		[Status] = @Status
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblHotelGallery_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_Save') AND type='P')
	DROP PROCEDURE [tblHotelGallery_Save]
GO

-- Insert or updates a new record in the 'tblHotelGallery' table.
CREATE PROCEDURE [tblHotelGallery_Save]
	-- The rest of writeable parameters
	@HotelID Int,
	@ImageFile nvarchar(255),
	@IsList Int,
	@IsDetail Int,
	@IsBanner Int,
	@Status Int,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblHotelGallery] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblHotelGallery]
		(
			[HotelID],
			[ImageFile],
			[IsList],
			[IsDetail],
			[IsBanner],
			[Status]
		)
		VALUES
		(
			@HotelID,
			@ImageFile,
			@IsList,
			@IsDetail,
			@IsBanner,
			@Status
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblHotelGallery] SET
			[HotelID] = @HotelID,
			[ImageFile] = @ImageFile,
			[IsList] = @IsList,
			[IsDetail] = @IsDetail,
			[IsBanner] = @IsBanner,
			[Status] = @Status
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblHotelGallery_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelGallery_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblHotelGallery' table using the primary key value.
CREATE PROCEDURE [tblHotelGallery_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblHotelGallery] WHERE
		[ID] = @ID
GO

-- Drop the 'tblHotelGallery_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_DeleteAll') AND type='P')
	DROP PROCEDURE [tblHotelGallery_DeleteAll]
GO

-- Deletes all records from the 'tblHotelGallery' table.
CREATE PROCEDURE [tblHotelGallery_DeleteAll]
AS
	DELETE FROM [dbo].[tblHotelGallery]
GO

-- Drop the 'tblHotelGallery_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGallery_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelGallery_DeleteAdHoc]
GO

-- Deletes records from the 'tblHotelGallery' table that match the supplied where clause.
CREATE PROCEDURE [tblHotelGallery_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblHotelGallery]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblHotelGalleryLang' table.
----------------------------------------------------------

-- Drop the 'tblHotelGalleryLang_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGalleryLang_GetAll') AND type='P')
	DROP PROCEDURE [tblHotelGalleryLang_GetAll]
GO

-- Gets all records from the 'tblHotelGalleryLang' table.
CREATE PROCEDURE [tblHotelGalleryLang_GetAll]
AS
	SELECT [HotelGalleryID], [ImageTitle], [ImageAlt], [Lang]
	FROM [dbo].[tblHotelGalleryLang]
GO

-- Drop the 'tblHotelGalleryLang_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGalleryLang_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelGalleryLang_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblHotelGalleryLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblHotelGalleryLang_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[HotelGalleryID] Int		,
					[ImageTitle] nvarchar(255)		,
					[ImageAlt] nvarchar(255)		,
					[Lang] nvarchar(10)		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [HotelGalleryID], [ImageTitle], [ImageAlt], [Lang]
		FROM [dbo].[tblHotelGalleryLang]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblHotelGalleryLang]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[HotelGalleryID], [ImageTitle], [ImageAlt], [Lang] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [HotelGalleryID], [ImageTitle], [ImageAlt], [Lang]
				FROM [dbo].[tblHotelGalleryLang]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblHotelGalleryLang]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [HotelGalleryID], [ImageTitle], [ImageAlt], [Lang]
				FROM [dbo].[tblHotelGalleryLang]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblHotelGalleryLang]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblHotelGalleryLang_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGalleryLang_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelGalleryLang_GetAdHoc]
GO

-- Gets records from the 'tblHotelGalleryLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblHotelGalleryLang_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [HotelGalleryID], [ImageTitle], [ImageAlt], [Lang]
		FROM [dbo].[tblHotelGalleryLang]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblHotelGalleryLang_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGalleryLang_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelGalleryLang_GetByPrimaryKey]
GO

-- Gets a record from the 'tblHotelGalleryLang' table using the primary key value.
CREATE PROCEDURE [tblHotelGalleryLang_GetByPrimaryKey]
	@HotelGalleryID Int,
	@Lang nvarchar(10)
AS
	SELECT [HotelGalleryID], [ImageTitle], [ImageAlt], [Lang] 
	FROM [dbo].[tblHotelGalleryLang] WHERE
		[HotelGalleryID] = @HotelGalleryID AND
		[Lang] = @Lang
GO

-- Drop the 'tblHotelGalleryLang_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGalleryLang_Insert') AND type='P')
	DROP PROCEDURE [tblHotelGalleryLang_Insert]
GO

-- Inserts a new record into the 'tblHotelGalleryLang' table.
CREATE PROCEDURE [tblHotelGalleryLang_Insert]
	@HotelGalleryID Int,
	@ImageTitle nvarchar(255),
	@ImageAlt nvarchar(255),
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblHotelGalleryLang]
	(
		[HotelGalleryID],
		[ImageTitle],
		[ImageAlt],
		[Lang]
	)
	VALUES
	(
		@HotelGalleryID,
		@ImageTitle,
		@ImageAlt,
		@Lang
	)
GO

-- Drop the 'tblHotelGalleryLang_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGalleryLang_Update') AND type='P')
	DROP PROCEDURE [tblHotelGalleryLang_Update]
GO

-- Updates a record in the 'tblHotelGalleryLang' table.
CREATE PROCEDURE [tblHotelGalleryLang_Update]
	-- The rest of writeable parameters
	@ImageTitle nvarchar(255),
	@ImageAlt nvarchar(255),
	-- Primary key parameters
	@HotelGalleryID Int,
	@Lang nvarchar(10)
AS
	UPDATE [dbo].[tblHotelGalleryLang] SET
		[ImageTitle] = @ImageTitle,
		[ImageAlt] = @ImageAlt
	WHERE
		[HotelGalleryID] = @HotelGalleryID AND
		[Lang] = @Lang
GO
-- Drop the 'tblHotelGalleryLang_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGalleryLang_Save') AND type='P')
	DROP PROCEDURE [tblHotelGalleryLang_Save]
GO

-- Insert or updates a new record in the 'tblHotelGalleryLang' table.
CREATE PROCEDURE [tblHotelGalleryLang_Save]
	-- The rest of writeable parameters
	@ImageTitle nvarchar(255),
	@ImageAlt nvarchar(255),
	-- Primary key parameters
	@HotelGalleryID Int,
	@Lang nvarchar(10)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblHotelGalleryLang] Where 
	[HotelGalleryID] = @HotelGalleryID 
 AND 
	[Lang] = @Lang 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblHotelGalleryLang]
		(
			[HotelGalleryID],
			[ImageTitle],
			[ImageAlt],
			[Lang]
		)
		VALUES
		(
			@HotelGalleryID,
			@ImageTitle,
			@ImageAlt,
			@Lang
		)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblHotelGalleryLang] SET
			[ImageTitle] = @ImageTitle,
			[ImageAlt] = @ImageAlt
		WHERE
			[HotelGalleryID] = @HotelGalleryID AND
			[Lang] = @Lang
	END
GO

-- Drop the 'tblHotelGalleryLang_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGalleryLang_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelGalleryLang_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblHotelGalleryLang' table using the primary key value.
CREATE PROCEDURE [tblHotelGalleryLang_DeleteByPrimaryKey]
	@HotelGalleryID Int,
	@Lang nvarchar(10)
AS
	DELETE FROM [dbo].[tblHotelGalleryLang] WHERE
		[HotelGalleryID] = @HotelGalleryID AND
		[Lang] = @Lang
GO

-- Drop the 'tblHotelGalleryLang_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGalleryLang_DeleteAll') AND type='P')
	DROP PROCEDURE [tblHotelGalleryLang_DeleteAll]
GO

-- Deletes all records from the 'tblHotelGalleryLang' table.
CREATE PROCEDURE [tblHotelGalleryLang_DeleteAll]
AS
	DELETE FROM [dbo].[tblHotelGalleryLang]
GO

-- Drop the 'tblHotelGalleryLang_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelGalleryLang_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelGalleryLang_DeleteAdHoc]
GO

-- Deletes records from the 'tblHotelGalleryLang' table that match the supplied where clause.
CREATE PROCEDURE [tblHotelGalleryLang_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblHotelGalleryLang]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblHotelLang' table.
----------------------------------------------------------

-- Drop the 'tblHotelLang_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelLang_GetAll') AND type='P')
	DROP PROCEDURE [tblHotelLang_GetAll]
GO

-- Gets all records from the 'tblHotelLang' table.
CREATE PROCEDURE [tblHotelLang_GetAll]
AS
	SELECT [HotelID], [HotelName], [City], [SubDomain], [Address], [SubDescription], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
	FROM [dbo].[tblHotelLang]
GO

-- Drop the 'tblHotelLang_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelLang_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelLang_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblHotelLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblHotelLang_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[HotelID] Int		,
					[HotelName] nvarchar(255)		,
					[City] nvarchar(255)		,
					[SubDomain] nvarchar(255)		,
					[Address] nvarchar(500)		,
					[SubDescription] ntext		,
					[Description] ntext		,
					[Tag] nvarchar(1000)		,
					[SeoTitle] nvarchar(1000)		,
					[SeoKeyword] nvarchar(1000)		,
					[SeoDescription] nvarchar(1000)		,
					[Lang] nvarchar(10)		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [HotelID], [HotelName], [City], [SubDomain], [Address], [SubDescription], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
		FROM [dbo].[tblHotelLang]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblHotelLang]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[HotelID], [HotelName], [City], [SubDomain], [Address], [SubDescription], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [HotelID], [HotelName], [City], [SubDomain], [Address], [SubDescription], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
				FROM [dbo].[tblHotelLang]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblHotelLang]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [HotelID], [HotelName], [City], [SubDomain], [Address], [SubDescription], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
				FROM [dbo].[tblHotelLang]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblHotelLang]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblHotelLang_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelLang_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelLang_GetAdHoc]
GO

-- Gets records from the 'tblHotelLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblHotelLang_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [HotelID], [HotelName], [City], [SubDomain], [Address], [SubDescription], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
		FROM [dbo].[tblHotelLang]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblHotelLang_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelLang_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelLang_GetByPrimaryKey]
GO

-- Gets a record from the 'tblHotelLang' table using the primary key value.
CREATE PROCEDURE [tblHotelLang_GetByPrimaryKey]
	@HotelID Int,
	@Lang nvarchar(10)
AS
	SELECT [HotelID], [HotelName], [City], [SubDomain], [Address], [SubDescription], [Description], [Tag], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang] 
	FROM [dbo].[tblHotelLang] WHERE
		[HotelID] = @HotelID AND
		[Lang] = @Lang
GO

-- Drop the 'tblHotelLang_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelLang_Insert') AND type='P')
	DROP PROCEDURE [tblHotelLang_Insert]
GO

-- Inserts a new record into the 'tblHotelLang' table.
CREATE PROCEDURE [tblHotelLang_Insert]
	@HotelID Int,
	@HotelName nvarchar(255),
	@City nvarchar(255),
	@SubDomain nvarchar(255),
	@Address nvarchar(500),
	@SubDescription ntext,
	@Description ntext,
	@Tag nvarchar(1000),
	@SeoTitle nvarchar(1000),
	@SeoKeyword nvarchar(1000),
	@SeoDescription nvarchar(1000),
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblHotelLang]
	(
		[HotelID],
		[HotelName],
		[City],
		[SubDomain],
		[Address],
		[SubDescription],
		[Description],
		[Tag],
		[SeoTitle],
		[SeoKeyword],
		[SeoDescription],
		[Lang]
	)
	VALUES
	(
		@HotelID,
		@HotelName,
		@City,
		@SubDomain,
		@Address,
		@SubDescription,
		@Description,
		@Tag,
		@SeoTitle,
		@SeoKeyword,
		@SeoDescription,
		@Lang
	)
GO

-- Drop the 'tblHotelLang_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelLang_Update') AND type='P')
	DROP PROCEDURE [tblHotelLang_Update]
GO

-- Updates a record in the 'tblHotelLang' table.
CREATE PROCEDURE [tblHotelLang_Update]
	-- The rest of writeable parameters
	@HotelName nvarchar(255),
	@City nvarchar(255),
	@SubDomain nvarchar(255),
	@Address nvarchar(500),
	@SubDescription ntext,
	@Description ntext,
	@Tag nvarchar(1000),
	@SeoTitle nvarchar(1000),
	@SeoKeyword nvarchar(1000),
	@SeoDescription nvarchar(1000),
	-- Primary key parameters
	@HotelID Int,
	@Lang nvarchar(10)
AS
	UPDATE [dbo].[tblHotelLang] SET
		[HotelName] = @HotelName,
		[City] = @City,
		[SubDomain] = @SubDomain,
		[Address] = @Address,
		[SubDescription] = @SubDescription,
		[Description] = @Description,
		[Tag] = @Tag,
		[SeoTitle] = @SeoTitle,
		[SeoKeyword] = @SeoKeyword,
		[SeoDescription] = @SeoDescription
	WHERE
		[HotelID] = @HotelID AND
		[Lang] = @Lang
GO
-- Drop the 'tblHotelLang_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelLang_Save') AND type='P')
	DROP PROCEDURE [tblHotelLang_Save]
GO

-- Insert or updates a new record in the 'tblHotelLang' table.
CREATE PROCEDURE [tblHotelLang_Save]
	-- The rest of writeable parameters
	@HotelName nvarchar(255),
	@City nvarchar(255),
	@SubDomain nvarchar(255),
	@Address nvarchar(500),
	@SubDescription ntext,
	@Description ntext,
	@Tag nvarchar(1000),
	@SeoTitle nvarchar(1000),
	@SeoKeyword nvarchar(1000),
	@SeoDescription nvarchar(1000),
	-- Primary key parameters
	@HotelID Int,
	@Lang nvarchar(10)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblHotelLang] Where 
	[HotelID] = @HotelID 
 AND 
	[Lang] = @Lang 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblHotelLang]
		(
			[HotelID],
			[HotelName],
			[City],
			[SubDomain],
			[Address],
			[SubDescription],
			[Description],
			[Tag],
			[SeoTitle],
			[SeoKeyword],
			[SeoDescription],
			[Lang]
		)
		VALUES
		(
			@HotelID,
			@HotelName,
			@City,
			@SubDomain,
			@Address,
			@SubDescription,
			@Description,
			@Tag,
			@SeoTitle,
			@SeoKeyword,
			@SeoDescription,
			@Lang
		)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblHotelLang] SET
			[HotelName] = @HotelName,
			[City] = @City,
			[SubDomain] = @SubDomain,
			[Address] = @Address,
			[SubDescription] = @SubDescription,
			[Description] = @Description,
			[Tag] = @Tag,
			[SeoTitle] = @SeoTitle,
			[SeoKeyword] = @SeoKeyword,
			[SeoDescription] = @SeoDescription
		WHERE
			[HotelID] = @HotelID AND
			[Lang] = @Lang
	END
GO

-- Drop the 'tblHotelLang_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelLang_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelLang_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblHotelLang' table using the primary key value.
CREATE PROCEDURE [tblHotelLang_DeleteByPrimaryKey]
	@HotelID Int,
	@Lang nvarchar(10)
AS
	DELETE FROM [dbo].[tblHotelLang] WHERE
		[HotelID] = @HotelID AND
		[Lang] = @Lang
GO

-- Drop the 'tblHotelLang_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelLang_DeleteAll') AND type='P')
	DROP PROCEDURE [tblHotelLang_DeleteAll]
GO

-- Deletes all records from the 'tblHotelLang' table.
CREATE PROCEDURE [tblHotelLang_DeleteAll]
AS
	DELETE FROM [dbo].[tblHotelLang]
GO

-- Drop the 'tblHotelLang_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelLang_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelLang_DeleteAdHoc]
GO

-- Deletes records from the 'tblHotelLang' table that match the supplied where clause.
CREATE PROCEDURE [tblHotelLang_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblHotelLang]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblHotelService' table.
----------------------------------------------------------

-- Drop the 'tblHotelService_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelService_GetAll') AND type='P')
	DROP PROCEDURE [tblHotelService_GetAll]
GO

-- Gets all records from the 'tblHotelService' table.
CREATE PROCEDURE [tblHotelService_GetAll]
AS
	SELECT [ID], [Status]
	FROM [dbo].[tblHotelService]
GO

-- Drop the 'tblHotelService_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelService_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelService_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblHotelService' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblHotelService_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[ID] Int		,
					[Status] Int		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [ID], [Status]
		FROM [dbo].[tblHotelService]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblHotelService]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [Status] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [ID], [Status]
				FROM [dbo].[tblHotelService]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblHotelService]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [Status]
				FROM [dbo].[tblHotelService]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblHotelService]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblHotelService_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelService_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelService_GetAdHoc]
GO

-- Gets records from the 'tblHotelService' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblHotelService_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [Status]
		FROM [dbo].[tblHotelService]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblHotelService_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelService_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelService_GetByPrimaryKey]
GO

-- Gets a record from the 'tblHotelService' table using the primary key value.
CREATE PROCEDURE [tblHotelService_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [Status] 
	FROM [dbo].[tblHotelService] WHERE
		[ID] = @ID
GO

-- Drop the 'tblHotelService_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelService_Insert') AND type='P')
	DROP PROCEDURE [tblHotelService_Insert]
GO

-- Inserts a new record into the 'tblHotelService' table.
CREATE PROCEDURE [tblHotelService_Insert]
	@Status Int
AS
	INSERT INTO [dbo].[tblHotelService]
	(
		[Status]
	)
	VALUES
	(
		@Status
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblHotelService_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelService_Update') AND type='P')
	DROP PROCEDURE [tblHotelService_Update]
GO

-- Updates a record in the 'tblHotelService' table.
CREATE PROCEDURE [tblHotelService_Update]
	-- The rest of writeable parameters
	@Status Int,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblHotelService] SET
		[Status] = @Status
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblHotelService_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelService_Save') AND type='P')
	DROP PROCEDURE [tblHotelService_Save]
GO

-- Insert or updates a new record in the 'tblHotelService' table.
CREATE PROCEDURE [tblHotelService_Save]
	-- The rest of writeable parameters
	@Status Int,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblHotelService] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblHotelService]
		(
			[Status]
		)
		VALUES
		(
			@Status
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblHotelService] SET
			[Status] = @Status
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblHotelService_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelService_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelService_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblHotelService' table using the primary key value.
CREATE PROCEDURE [tblHotelService_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblHotelService] WHERE
		[ID] = @ID
GO

-- Drop the 'tblHotelService_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelService_DeleteAll') AND type='P')
	DROP PROCEDURE [tblHotelService_DeleteAll]
GO

-- Deletes all records from the 'tblHotelService' table.
CREATE PROCEDURE [tblHotelService_DeleteAll]
AS
	DELETE FROM [dbo].[tblHotelService]
GO

-- Drop the 'tblHotelService_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelService_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelService_DeleteAdHoc]
GO

-- Deletes records from the 'tblHotelService' table that match the supplied where clause.
CREATE PROCEDURE [tblHotelService_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblHotelService]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblHotelServiceLang' table.
----------------------------------------------------------

-- Drop the 'tblHotelServiceLang_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelServiceLang_GetAll') AND type='P')
	DROP PROCEDURE [tblHotelServiceLang_GetAll]
GO

-- Gets all records from the 'tblHotelServiceLang' table.
CREATE PROCEDURE [tblHotelServiceLang_GetAll]
AS
	SELECT [HotelServiceID], [Title], [Lang]
	FROM [dbo].[tblHotelServiceLang]
GO

-- Drop the 'tblHotelServiceLang_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelServiceLang_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelServiceLang_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblHotelServiceLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblHotelServiceLang_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[HotelServiceID] Int		,
					[Title] nvarchar(255)		,
					[Lang] nvarchar(10)		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [HotelServiceID], [Title], [Lang]
		FROM [dbo].[tblHotelServiceLang]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblHotelServiceLang]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[HotelServiceID], [Title], [Lang] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [HotelServiceID], [Title], [Lang]
				FROM [dbo].[tblHotelServiceLang]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblHotelServiceLang]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [HotelServiceID], [Title], [Lang]
				FROM [dbo].[tblHotelServiceLang]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblHotelServiceLang]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblHotelServiceLang_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelServiceLang_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelServiceLang_GetAdHoc]
GO

-- Gets records from the 'tblHotelServiceLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblHotelServiceLang_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [HotelServiceID], [Title], [Lang]
		FROM [dbo].[tblHotelServiceLang]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblHotelServiceLang_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelServiceLang_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelServiceLang_GetByPrimaryKey]
GO

-- Gets a record from the 'tblHotelServiceLang' table using the primary key value.
CREATE PROCEDURE [tblHotelServiceLang_GetByPrimaryKey]
	@HotelServiceID Int,
	@Lang nvarchar(10)
AS
	SELECT [HotelServiceID], [Title], [Lang] 
	FROM [dbo].[tblHotelServiceLang] WHERE
		[HotelServiceID] = @HotelServiceID AND
		[Lang] = @Lang
GO

-- Drop the 'tblHotelServiceLang_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelServiceLang_Insert') AND type='P')
	DROP PROCEDURE [tblHotelServiceLang_Insert]
GO

-- Inserts a new record into the 'tblHotelServiceLang' table.
CREATE PROCEDURE [tblHotelServiceLang_Insert]
	@HotelServiceID Int,
	@Title nvarchar(255),
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblHotelServiceLang]
	(
		[HotelServiceID],
		[Title],
		[Lang]
	)
	VALUES
	(
		@HotelServiceID,
		@Title,
		@Lang
	)
GO

-- Drop the 'tblHotelServiceLang_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelServiceLang_Update') AND type='P')
	DROP PROCEDURE [tblHotelServiceLang_Update]
GO

-- Updates a record in the 'tblHotelServiceLang' table.
CREATE PROCEDURE [tblHotelServiceLang_Update]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	-- Primary key parameters
	@HotelServiceID Int,
	@Lang nvarchar(10)
AS
	UPDATE [dbo].[tblHotelServiceLang] SET
		[Title] = @Title
	WHERE
		[HotelServiceID] = @HotelServiceID AND
		[Lang] = @Lang
GO
-- Drop the 'tblHotelServiceLang_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelServiceLang_Save') AND type='P')
	DROP PROCEDURE [tblHotelServiceLang_Save]
GO

-- Insert or updates a new record in the 'tblHotelServiceLang' table.
CREATE PROCEDURE [tblHotelServiceLang_Save]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	-- Primary key parameters
	@HotelServiceID Int,
	@Lang nvarchar(10)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblHotelServiceLang] Where 
	[HotelServiceID] = @HotelServiceID 
 AND 
	[Lang] = @Lang 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblHotelServiceLang]
		(
			[HotelServiceID],
			[Title],
			[Lang]
		)
		VALUES
		(
			@HotelServiceID,
			@Title,
			@Lang
		)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblHotelServiceLang] SET
			[Title] = @Title
		WHERE
			[HotelServiceID] = @HotelServiceID AND
			[Lang] = @Lang
	END
GO

-- Drop the 'tblHotelServiceLang_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelServiceLang_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelServiceLang_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblHotelServiceLang' table using the primary key value.
CREATE PROCEDURE [tblHotelServiceLang_DeleteByPrimaryKey]
	@HotelServiceID Int,
	@Lang nvarchar(10)
AS
	DELETE FROM [dbo].[tblHotelServiceLang] WHERE
		[HotelServiceID] = @HotelServiceID AND
		[Lang] = @Lang
GO

-- Drop the 'tblHotelServiceLang_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelServiceLang_DeleteAll') AND type='P')
	DROP PROCEDURE [tblHotelServiceLang_DeleteAll]
GO

-- Deletes all records from the 'tblHotelServiceLang' table.
CREATE PROCEDURE [tblHotelServiceLang_DeleteAll]
AS
	DELETE FROM [dbo].[tblHotelServiceLang]
GO

-- Drop the 'tblHotelServiceLang_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelServiceLang_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelServiceLang_DeleteAdHoc]
GO

-- Deletes records from the 'tblHotelServiceLang' table that match the supplied where clause.
CREATE PROCEDURE [tblHotelServiceLang_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblHotelServiceLang]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblHotelStyle' table.
----------------------------------------------------------

-- Drop the 'tblHotelStyle_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyle_GetAll') AND type='P')
	DROP PROCEDURE [tblHotelStyle_GetAll]
GO

-- Gets all records from the 'tblHotelStyle' table.
CREATE PROCEDURE [tblHotelStyle_GetAll]
AS
	SELECT [ID], [Status]
	FROM [dbo].[tblHotelStyle]
GO

-- Drop the 'tblHotelStyle_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyle_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelStyle_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblHotelStyle' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblHotelStyle_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[ID] Int		,
					[Status] Int		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [ID], [Status]
		FROM [dbo].[tblHotelStyle]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblHotelStyle]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [Status] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [ID], [Status]
				FROM [dbo].[tblHotelStyle]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblHotelStyle]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [Status]
				FROM [dbo].[tblHotelStyle]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblHotelStyle]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblHotelStyle_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyle_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelStyle_GetAdHoc]
GO

-- Gets records from the 'tblHotelStyle' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblHotelStyle_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [Status]
		FROM [dbo].[tblHotelStyle]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblHotelStyle_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyle_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelStyle_GetByPrimaryKey]
GO

-- Gets a record from the 'tblHotelStyle' table using the primary key value.
CREATE PROCEDURE [tblHotelStyle_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [Status] 
	FROM [dbo].[tblHotelStyle] WHERE
		[ID] = @ID
GO

-- Drop the 'tblHotelStyle_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyle_Insert') AND type='P')
	DROP PROCEDURE [tblHotelStyle_Insert]
GO

-- Inserts a new record into the 'tblHotelStyle' table.
CREATE PROCEDURE [tblHotelStyle_Insert]
	@Status Int
AS
	INSERT INTO [dbo].[tblHotelStyle]
	(
		[Status]
	)
	VALUES
	(
		@Status
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblHotelStyle_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyle_Update') AND type='P')
	DROP PROCEDURE [tblHotelStyle_Update]
GO

-- Updates a record in the 'tblHotelStyle' table.
CREATE PROCEDURE [tblHotelStyle_Update]
	-- The rest of writeable parameters
	@Status Int,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblHotelStyle] SET
		[Status] = @Status
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblHotelStyle_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyle_Save') AND type='P')
	DROP PROCEDURE [tblHotelStyle_Save]
GO

-- Insert or updates a new record in the 'tblHotelStyle' table.
CREATE PROCEDURE [tblHotelStyle_Save]
	-- The rest of writeable parameters
	@Status Int,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblHotelStyle] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblHotelStyle]
		(
			[Status]
		)
		VALUES
		(
			@Status
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblHotelStyle] SET
			[Status] = @Status
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblHotelStyle_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyle_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelStyle_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblHotelStyle' table using the primary key value.
CREATE PROCEDURE [tblHotelStyle_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblHotelStyle] WHERE
		[ID] = @ID
GO

-- Drop the 'tblHotelStyle_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyle_DeleteAll') AND type='P')
	DROP PROCEDURE [tblHotelStyle_DeleteAll]
GO

-- Deletes all records from the 'tblHotelStyle' table.
CREATE PROCEDURE [tblHotelStyle_DeleteAll]
AS
	DELETE FROM [dbo].[tblHotelStyle]
GO

-- Drop the 'tblHotelStyle_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyle_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelStyle_DeleteAdHoc]
GO

-- Deletes records from the 'tblHotelStyle' table that match the supplied where clause.
CREATE PROCEDURE [tblHotelStyle_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblHotelStyle]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblHotelStyleLang' table.
----------------------------------------------------------

-- Drop the 'tblHotelStyleLang_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyleLang_GetAll') AND type='P')
	DROP PROCEDURE [tblHotelStyleLang_GetAll]
GO

-- Gets all records from the 'tblHotelStyleLang' table.
CREATE PROCEDURE [tblHotelStyleLang_GetAll]
AS
	SELECT [HotelStyleID], [Title], [Lang]
	FROM [dbo].[tblHotelStyleLang]
GO

-- Drop the 'tblHotelStyleLang_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyleLang_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelStyleLang_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblHotelStyleLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblHotelStyleLang_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[HotelStyleID] Int		,
					[Title] nvarchar(255)		,
					[Lang] nvarchar(10)		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [HotelStyleID], [Title], [Lang]
		FROM [dbo].[tblHotelStyleLang]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblHotelStyleLang]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[HotelStyleID], [Title], [Lang] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [HotelStyleID], [Title], [Lang]
				FROM [dbo].[tblHotelStyleLang]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblHotelStyleLang]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [HotelStyleID], [Title], [Lang]
				FROM [dbo].[tblHotelStyleLang]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblHotelStyleLang]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblHotelStyleLang_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyleLang_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelStyleLang_GetAdHoc]
GO

-- Gets records from the 'tblHotelStyleLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblHotelStyleLang_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [HotelStyleID], [Title], [Lang]
		FROM [dbo].[tblHotelStyleLang]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblHotelStyleLang_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyleLang_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelStyleLang_GetByPrimaryKey]
GO

-- Gets a record from the 'tblHotelStyleLang' table using the primary key value.
CREATE PROCEDURE [tblHotelStyleLang_GetByPrimaryKey]
	@HotelStyleID Int,
	@Lang nvarchar(10)
AS
	SELECT [HotelStyleID], [Title], [Lang] 
	FROM [dbo].[tblHotelStyleLang] WHERE
		[HotelStyleID] = @HotelStyleID AND
		[Lang] = @Lang
GO

-- Drop the 'tblHotelStyleLang_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyleLang_Insert') AND type='P')
	DROP PROCEDURE [tblHotelStyleLang_Insert]
GO

-- Inserts a new record into the 'tblHotelStyleLang' table.
CREATE PROCEDURE [tblHotelStyleLang_Insert]
	@HotelStyleID Int,
	@Title nvarchar(255),
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblHotelStyleLang]
	(
		[HotelStyleID],
		[Title],
		[Lang]
	)
	VALUES
	(
		@HotelStyleID,
		@Title,
		@Lang
	)
GO

-- Drop the 'tblHotelStyleLang_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyleLang_Update') AND type='P')
	DROP PROCEDURE [tblHotelStyleLang_Update]
GO

-- Updates a record in the 'tblHotelStyleLang' table.
CREATE PROCEDURE [tblHotelStyleLang_Update]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	-- Primary key parameters
	@HotelStyleID Int,
	@Lang nvarchar(10)
AS
	UPDATE [dbo].[tblHotelStyleLang] SET
		[Title] = @Title
	WHERE
		[HotelStyleID] = @HotelStyleID AND
		[Lang] = @Lang
GO
-- Drop the 'tblHotelStyleLang_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyleLang_Save') AND type='P')
	DROP PROCEDURE [tblHotelStyleLang_Save]
GO

-- Insert or updates a new record in the 'tblHotelStyleLang' table.
CREATE PROCEDURE [tblHotelStyleLang_Save]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	-- Primary key parameters
	@HotelStyleID Int,
	@Lang nvarchar(10)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblHotelStyleLang] Where 
	[HotelStyleID] = @HotelStyleID 
 AND 
	[Lang] = @Lang 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblHotelStyleLang]
		(
			[HotelStyleID],
			[Title],
			[Lang]
		)
		VALUES
		(
			@HotelStyleID,
			@Title,
			@Lang
		)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblHotelStyleLang] SET
			[Title] = @Title
		WHERE
			[HotelStyleID] = @HotelStyleID AND
			[Lang] = @Lang
	END
GO

-- Drop the 'tblHotelStyleLang_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyleLang_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotelStyleLang_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblHotelStyleLang' table using the primary key value.
CREATE PROCEDURE [tblHotelStyleLang_DeleteByPrimaryKey]
	@HotelStyleID Int,
	@Lang nvarchar(10)
AS
	DELETE FROM [dbo].[tblHotelStyleLang] WHERE
		[HotelStyleID] = @HotelStyleID AND
		[Lang] = @Lang
GO

-- Drop the 'tblHotelStyleLang_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyleLang_DeleteAll') AND type='P')
	DROP PROCEDURE [tblHotelStyleLang_DeleteAll]
GO

-- Deletes all records from the 'tblHotelStyleLang' table.
CREATE PROCEDURE [tblHotelStyleLang_DeleteAll]
AS
	DELETE FROM [dbo].[tblHotelStyleLang]
GO

-- Drop the 'tblHotelStyleLang_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotelStyleLang_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblHotelStyleLang_DeleteAdHoc]
GO

-- Deletes records from the 'tblHotelStyleLang' table that match the supplied where clause.
CREATE PROCEDURE [tblHotelStyleLang_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblHotelStyleLang]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblLibProgrameGallery' table.
----------------------------------------------------------

-- Drop the 'tblLibProgrameGallery_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblLibProgrameGallery_GetAll') AND type='P')
	DROP PROCEDURE [tblLibProgrameGallery_GetAll]
GO

-- Gets all records from the 'tblLibProgrameGallery' table.
CREATE PROCEDURE [tblLibProgrameGallery_GetAll]
AS
	SELECT [ID], [AttractionsID], [ImageFile], [ImageTitle], [ImageAlt], [Status]
	FROM [dbo].[tblLibProgrameGallery]
GO

-- Drop the 'tblLibProgrameGallery_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblLibProgrameGallery_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblLibProgrameGallery_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblLibProgrameGallery' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblLibProgrameGallery_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[ID] Int		,
					[AttractionsID] Int		,
					[ImageFile] nvarchar(255)		,
					[ImageTitle] nvarchar(255)		,
					[ImageAlt] nvarchar(255)		,
					[Status] Int		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [ID], [AttractionsID], [ImageFile], [ImageTitle], [ImageAlt], [Status]
		FROM [dbo].[tblLibProgrameGallery]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblLibProgrameGallery]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [AttractionsID], [ImageFile], [ImageTitle], [ImageAlt], [Status] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [ID], [AttractionsID], [ImageFile], [ImageTitle], [ImageAlt], [Status]
				FROM [dbo].[tblLibProgrameGallery]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblLibProgrameGallery]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [AttractionsID], [ImageFile], [ImageTitle], [ImageAlt], [Status]
				FROM [dbo].[tblLibProgrameGallery]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblLibProgrameGallery]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblLibProgrameGallery_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblLibProgrameGallery_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblLibProgrameGallery_GetAdHoc]
GO

-- Gets records from the 'tblLibProgrameGallery' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblLibProgrameGallery_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [AttractionsID], [ImageFile], [ImageTitle], [ImageAlt], [Status]
		FROM [dbo].[tblLibProgrameGallery]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblLibProgrameGallery_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblLibProgrameGallery_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblLibProgrameGallery_GetByPrimaryKey]
GO

-- Gets a record from the 'tblLibProgrameGallery' table using the primary key value.
CREATE PROCEDURE [tblLibProgrameGallery_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [AttractionsID], [ImageFile], [ImageTitle], [ImageAlt], [Status] 
	FROM [dbo].[tblLibProgrameGallery] WHERE
		[ID] = @ID
GO

-- Drop the 'tblLibProgrameGallery_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblLibProgrameGallery_Insert') AND type='P')
	DROP PROCEDURE [tblLibProgrameGallery_Insert]
GO

-- Inserts a new record into the 'tblLibProgrameGallery' table.
CREATE PROCEDURE [tblLibProgrameGallery_Insert]
	@AttractionsID Int,
	@ImageFile nvarchar(255),
	@ImageTitle nvarchar(255),
	@ImageAlt nvarchar(255),
	@Status Int
AS
	INSERT INTO [dbo].[tblLibProgrameGallery]
	(
		[AttractionsID],
		[ImageFile],
		[ImageTitle],
		[ImageAlt],
		[Status]
	)
	VALUES
	(
		@AttractionsID,
		@ImageFile,
		@ImageTitle,
		@ImageAlt,
		@Status
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblLibProgrameGallery_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblLibProgrameGallery_Update') AND type='P')
	DROP PROCEDURE [tblLibProgrameGallery_Update]
GO

-- Updates a record in the 'tblLibProgrameGallery' table.
CREATE PROCEDURE [tblLibProgrameGallery_Update]
	-- The rest of writeable parameters
	@AttractionsID Int,
	@ImageFile nvarchar(255),
	@ImageTitle nvarchar(255),
	@ImageAlt nvarchar(255),
	@Status Int,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblLibProgrameGallery] SET
		[AttractionsID] = @AttractionsID,
		[ImageFile] = @ImageFile,
		[ImageTitle] = @ImageTitle,
		[ImageAlt] = @ImageAlt,
		[Status] = @Status
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblLibProgrameGallery_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblLibProgrameGallery_Save') AND type='P')
	DROP PROCEDURE [tblLibProgrameGallery_Save]
GO

-- Insert or updates a new record in the 'tblLibProgrameGallery' table.
CREATE PROCEDURE [tblLibProgrameGallery_Save]
	-- The rest of writeable parameters
	@AttractionsID Int,
	@ImageFile nvarchar(255),
	@ImageTitle nvarchar(255),
	@ImageAlt nvarchar(255),
	@Status Int,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblLibProgrameGallery] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblLibProgrameGallery]
		(
			[AttractionsID],
			[ImageFile],
			[ImageTitle],
			[ImageAlt],
			[Status]
		)
		VALUES
		(
			@AttractionsID,
			@ImageFile,
			@ImageTitle,
			@ImageAlt,
			@Status
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblLibProgrameGallery] SET
			[AttractionsID] = @AttractionsID,
			[ImageFile] = @ImageFile,
			[ImageTitle] = @ImageTitle,
			[ImageAlt] = @ImageAlt,
			[Status] = @Status
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblLibProgrameGallery_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblLibProgrameGallery_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblLibProgrameGallery_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblLibProgrameGallery' table using the primary key value.
CREATE PROCEDURE [tblLibProgrameGallery_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblLibProgrameGallery] WHERE
		[ID] = @ID
GO

-- Drop the 'tblLibProgrameGallery_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblLibProgrameGallery_DeleteAll') AND type='P')
	DROP PROCEDURE [tblLibProgrameGallery_DeleteAll]
GO

-- Deletes all records from the 'tblLibProgrameGallery' table.
CREATE PROCEDURE [tblLibProgrameGallery_DeleteAll]
AS
	DELETE FROM [dbo].[tblLibProgrameGallery]
GO

-- Drop the 'tblLibProgrameGallery_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblLibProgrameGallery_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblLibProgrameGallery_DeleteAdHoc]
GO

-- Deletes records from the 'tblLibProgrameGallery' table that match the supplied where clause.
CREATE PROCEDURE [tblLibProgrameGallery_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblLibProgrameGallery]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblNationality' table.
----------------------------------------------------------

-- Drop the 'tblNationality_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNationality_GetAll') AND type='P')
	DROP PROCEDURE [tblNationality_GetAll]
GO

-- Gets all records from the 'tblNationality' table.
CREATE PROCEDURE [tblNationality_GetAll]
AS
	SELECT [ID], [NationalityName], [Status], [OrderBy], [Lang]
	FROM [dbo].[tblNationality]
GO

-- Drop the 'tblNationality_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNationality_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblNationality_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblNationality' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblNationality_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[ID] Int		,
					[NationalityName] nvarchar(255)		,
					[Status] Int		,
					[OrderBy] Int		,
					[Lang] nvarchar(255)		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [ID], [NationalityName], [Status], [OrderBy], [Lang]
		FROM [dbo].[tblNationality]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblNationality]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [NationalityName], [Status], [OrderBy], [Lang] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [ID], [NationalityName], [Status], [OrderBy], [Lang]
				FROM [dbo].[tblNationality]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblNationality]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [NationalityName], [Status], [OrderBy], [Lang]
				FROM [dbo].[tblNationality]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblNationality]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblNationality_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNationality_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblNationality_GetAdHoc]
GO

-- Gets records from the 'tblNationality' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblNationality_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [NationalityName], [Status], [OrderBy], [Lang]
		FROM [dbo].[tblNationality]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblNationality_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNationality_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblNationality_GetByPrimaryKey]
GO

-- Gets a record from the 'tblNationality' table using the primary key value.
CREATE PROCEDURE [tblNationality_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [NationalityName], [Status], [OrderBy], [Lang] 
	FROM [dbo].[tblNationality] WHERE
		[ID] = @ID
GO

-- Drop the 'tblNationality_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNationality_Insert') AND type='P')
	DROP PROCEDURE [tblNationality_Insert]
GO

-- Inserts a new record into the 'tblNationality' table.
CREATE PROCEDURE [tblNationality_Insert]
	@NationalityName nvarchar(255),
	@Status Int,
	@OrderBy Int,
	@Lang nvarchar(255)
AS
	INSERT INTO [dbo].[tblNationality]
	(
		[NationalityName],
		[Status],
		[OrderBy],
		[Lang]
	)
	VALUES
	(
		@NationalityName,
		@Status,
		@OrderBy,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblNationality_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNationality_Update') AND type='P')
	DROP PROCEDURE [tblNationality_Update]
GO

-- Updates a record in the 'tblNationality' table.
CREATE PROCEDURE [tblNationality_Update]
	-- The rest of writeable parameters
	@NationalityName nvarchar(255),
	@Status Int,
	@OrderBy Int,
	@Lang nvarchar(255),
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblNationality] SET
		[NationalityName] = @NationalityName,
		[Status] = @Status,
		[OrderBy] = @OrderBy,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblNationality_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNationality_Save') AND type='P')
	DROP PROCEDURE [tblNationality_Save]
GO

-- Insert or updates a new record in the 'tblNationality' table.
CREATE PROCEDURE [tblNationality_Save]
	-- The rest of writeable parameters
	@NationalityName nvarchar(255),
	@Status Int,
	@OrderBy Int,
	@Lang nvarchar(255),
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblNationality] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblNationality]
		(
			[NationalityName],
			[Status],
			[OrderBy],
			[Lang]
		)
		VALUES
		(
			@NationalityName,
			@Status,
			@OrderBy,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblNationality] SET
			[NationalityName] = @NationalityName,
			[Status] = @Status,
			[OrderBy] = @OrderBy,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblNationality_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNationality_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblNationality_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblNationality' table using the primary key value.
CREATE PROCEDURE [tblNationality_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblNationality] WHERE
		[ID] = @ID
GO

-- Drop the 'tblNationality_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNationality_DeleteAll') AND type='P')
	DROP PROCEDURE [tblNationality_DeleteAll]
GO

-- Deletes all records from the 'tblNationality' table.
CREATE PROCEDURE [tblNationality_DeleteAll]
AS
	DELETE FROM [dbo].[tblNationality]
GO

-- Drop the 'tblNationality_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNationality_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblNationality_DeleteAdHoc]
GO

-- Deletes records from the 'tblNationality' table that match the supplied where clause.
CREATE PROCEDURE [tblNationality_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblNationality]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblPermissionRole' table.
----------------------------------------------------------

-- Drop the 'tblPermissionRole_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPermissionRole_GetAll') AND type='P')
	DROP PROCEDURE [tblPermissionRole_GetAll]
GO

-- Gets all records from the 'tblPermissionRole' table.
CREATE PROCEDURE [tblPermissionRole_GetAll]
AS
	SELECT [RoleID], [FunctionID], [PermissionFlg]
	FROM [dbo].[tblPermissionRole]
GO

-- Drop the 'tblPermissionRole_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPermissionRole_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblPermissionRole_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblPermissionRole' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblPermissionRole_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[RoleID] Int		,
					[FunctionID] Int		,
					[PermissionFlg] Int		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [RoleID], [FunctionID], [PermissionFlg]
		FROM [dbo].[tblPermissionRole]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblPermissionRole]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[RoleID], [FunctionID], [PermissionFlg] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [RoleID], [FunctionID], [PermissionFlg]
				FROM [dbo].[tblPermissionRole]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblPermissionRole]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [RoleID], [FunctionID], [PermissionFlg]
				FROM [dbo].[tblPermissionRole]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblPermissionRole]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblPermissionRole_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPermissionRole_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblPermissionRole_GetAdHoc]
GO

-- Gets records from the 'tblPermissionRole' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblPermissionRole_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [RoleID], [FunctionID], [PermissionFlg]
		FROM [dbo].[tblPermissionRole]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblPermissionRole_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPermissionRole_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblPermissionRole_GetByPrimaryKey]
GO

-- Gets a record from the 'tblPermissionRole' table using the primary key value.
CREATE PROCEDURE [tblPermissionRole_GetByPrimaryKey]
	@RoleID Int,
	@FunctionID Int
AS
	SELECT [RoleID], [FunctionID], [PermissionFlg] 
	FROM [dbo].[tblPermissionRole] WHERE
		[RoleID] = @RoleID AND
		[FunctionID] = @FunctionID
GO

-- Drop the 'tblPermissionRole_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPermissionRole_Insert') AND type='P')
	DROP PROCEDURE [tblPermissionRole_Insert]
GO

-- Inserts a new record into the 'tblPermissionRole' table.
CREATE PROCEDURE [tblPermissionRole_Insert]
	@RoleID Int,
	@FunctionID Int,
	@PermissionFlg Int
AS
	INSERT INTO [dbo].[tblPermissionRole]
	(
		[RoleID],
		[FunctionID],
		[PermissionFlg]
	)
	VALUES
	(
		@RoleID,
		@FunctionID,
		@PermissionFlg
	)
GO

-- Drop the 'tblPermissionRole_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPermissionRole_Update') AND type='P')
	DROP PROCEDURE [tblPermissionRole_Update]
GO

-- Updates a record in the 'tblPermissionRole' table.
CREATE PROCEDURE [tblPermissionRole_Update]
	-- The rest of writeable parameters
	@PermissionFlg Int,
	-- Primary key parameters
	@RoleID Int,
	@FunctionID Int
AS
	UPDATE [dbo].[tblPermissionRole] SET
		[PermissionFlg] = @PermissionFlg
	WHERE
		[RoleID] = @RoleID AND
		[FunctionID] = @FunctionID
GO
-- Drop the 'tblPermissionRole_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPermissionRole_Save') AND type='P')
	DROP PROCEDURE [tblPermissionRole_Save]
GO

-- Insert or updates a new record in the 'tblPermissionRole' table.
CREATE PROCEDURE [tblPermissionRole_Save]
	-- The rest of writeable parameters
	@PermissionFlg Int,
	-- Primary key parameters
	@RoleID Int,
	@FunctionID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblPermissionRole] Where 
	[RoleID] = @RoleID 
 AND 
	[FunctionID] = @FunctionID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblPermissionRole]
		(
			[RoleID],
			[FunctionID],
			[PermissionFlg]
		)
		VALUES
		(
			@RoleID,
			@FunctionID,
			@PermissionFlg
		)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblPermissionRole] SET
			[PermissionFlg] = @PermissionFlg
		WHERE
			[RoleID] = @RoleID AND
			[FunctionID] = @FunctionID
	END
GO

-- Drop the 'tblPermissionRole_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPermissionRole_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblPermissionRole_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblPermissionRole' table using the primary key value.
CREATE PROCEDURE [tblPermissionRole_DeleteByPrimaryKey]
	@RoleID Int,
	@FunctionID Int
AS
	DELETE FROM [dbo].[tblPermissionRole] WHERE
		[RoleID] = @RoleID AND
		[FunctionID] = @FunctionID
GO

-- Drop the 'tblPermissionRole_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPermissionRole_DeleteAll') AND type='P')
	DROP PROCEDURE [tblPermissionRole_DeleteAll]
GO

-- Deletes all records from the 'tblPermissionRole' table.
CREATE PROCEDURE [tblPermissionRole_DeleteAll]
AS
	DELETE FROM [dbo].[tblPermissionRole]
GO

-- Drop the 'tblPermissionRole_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPermissionRole_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblPermissionRole_DeleteAdHoc]
GO

-- Deletes records from the 'tblPermissionRole' table that match the supplied where clause.
CREATE PROCEDURE [tblPermissionRole_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblPermissionRole]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblPriceRequest' table.
----------------------------------------------------------

-- Drop the 'tblPriceRequest_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPriceRequest_GetAll') AND type='P')
	DROP PROCEDURE [tblPriceRequest_GetAll]
GO

-- Gets all records from the 'tblPriceRequest' table.
CREATE PROCEDURE [tblPriceRequest_GetAll]
AS
	SELECT [ID], [CustomerID], [TourID], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [TravelMonth], [TravelYear], [SendDate], [Status], [Lang]
	FROM [dbo].[tblPriceRequest]
GO

-- Drop the 'tblPriceRequest_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPriceRequest_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblPriceRequest_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblPriceRequest' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblPriceRequest_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[ID] decimal(18,0)		,
					[CustomerID] decimal(18,0)		,
					[TourID] Int		,
					[AdultNumber] Int		,
					[ChildNumber] Int		,
					[IsPlan] Int		,
					[TravelDate] datetime		,
					[TravelMonth] Int		,
					[TravelYear] Int		,
					[SendDate] datetime		,
					[Status] Int		,
					[Lang] nvarchar(10)		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [ID], [CustomerID], [TourID], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [TravelMonth], [TravelYear], [SendDate], [Status], [Lang]
		FROM [dbo].[tblPriceRequest]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblPriceRequest]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [CustomerID], [TourID], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [TravelMonth], [TravelYear], [SendDate], [Status], [Lang] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [ID], [CustomerID], [TourID], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [TravelMonth], [TravelYear], [SendDate], [Status], [Lang]
				FROM [dbo].[tblPriceRequest]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblPriceRequest]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [CustomerID], [TourID], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [TravelMonth], [TravelYear], [SendDate], [Status], [Lang]
				FROM [dbo].[tblPriceRequest]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblPriceRequest]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblPriceRequest_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPriceRequest_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblPriceRequest_GetAdHoc]
GO

-- Gets records from the 'tblPriceRequest' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblPriceRequest_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [CustomerID], [TourID], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [TravelMonth], [TravelYear], [SendDate], [Status], [Lang]
		FROM [dbo].[tblPriceRequest]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblPriceRequest_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPriceRequest_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblPriceRequest_GetByPrimaryKey]
GO

-- Gets a record from the 'tblPriceRequest' table using the primary key value.
CREATE PROCEDURE [tblPriceRequest_GetByPrimaryKey]
	@ID decimal(18,0)
AS
	SELECT [ID], [CustomerID], [TourID], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [TravelMonth], [TravelYear], [SendDate], [Status], [Lang] 
	FROM [dbo].[tblPriceRequest] WHERE
		[ID] = @ID
GO

-- Drop the 'tblPriceRequest_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPriceRequest_Insert') AND type='P')
	DROP PROCEDURE [tblPriceRequest_Insert]
GO

-- Inserts a new record into the 'tblPriceRequest' table.
CREATE PROCEDURE [tblPriceRequest_Insert]
	@CustomerID decimal(18,0),
	@TourID Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan Int,
	@TravelDate datetime,
	@TravelMonth Int,
	@TravelYear Int,
	@SendDate datetime,
	@Status Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblPriceRequest]
	(
		[CustomerID],
		[TourID],
		[AdultNumber],
		[ChildNumber],
		[IsPlan],
		[TravelDate],
		[TravelMonth],
		[TravelYear],
		[SendDate],
		[Status],
		[Lang]
	)
	VALUES
	(
		@CustomerID,
		@TourID,
		@AdultNumber,
		@ChildNumber,
		@IsPlan,
		@TravelDate,
		@TravelMonth,
		@TravelYear,
		@SendDate,
		@Status,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblPriceRequest_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPriceRequest_Update') AND type='P')
	DROP PROCEDURE [tblPriceRequest_Update]
GO

-- Updates a record in the 'tblPriceRequest' table.
CREATE PROCEDURE [tblPriceRequest_Update]
	-- The rest of writeable parameters
	@CustomerID decimal(18,0),
	@TourID Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan Int,
	@TravelDate datetime,
	@TravelMonth Int,
	@TravelYear Int,
	@SendDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	UPDATE [dbo].[tblPriceRequest] SET
		[CustomerID] = @CustomerID,
		[TourID] = @TourID,
		[AdultNumber] = @AdultNumber,
		[ChildNumber] = @ChildNumber,
		[IsPlan] = @IsPlan,
		[TravelDate] = @TravelDate,
		[TravelMonth] = @TravelMonth,
		[TravelYear] = @TravelYear,
		[SendDate] = @SendDate,
		[Status] = @Status,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblPriceRequest_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPriceRequest_Save') AND type='P')
	DROP PROCEDURE [tblPriceRequest_Save]
GO

-- Insert or updates a new record in the 'tblPriceRequest' table.
CREATE PROCEDURE [tblPriceRequest_Save]
	-- The rest of writeable parameters
	@CustomerID decimal(18,0),
	@TourID Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan Int,
	@TravelDate datetime,
	@TravelMonth Int,
	@TravelYear Int,
	@SendDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblPriceRequest] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblPriceRequest]
		(
			[CustomerID],
			[TourID],
			[AdultNumber],
			[ChildNumber],
			[IsPlan],
			[TravelDate],
			[TravelMonth],
			[TravelYear],
			[SendDate],
			[Status],
			[Lang]
		)
		VALUES
		(
			@CustomerID,
			@TourID,
			@AdultNumber,
			@ChildNumber,
			@IsPlan,
			@TravelDate,
			@TravelMonth,
			@TravelYear,
			@SendDate,
			@Status,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblPriceRequest] SET
			[CustomerID] = @CustomerID,
			[TourID] = @TourID,
			[AdultNumber] = @AdultNumber,
			[ChildNumber] = @ChildNumber,
			[IsPlan] = @IsPlan,
			[TravelDate] = @TravelDate,
			[TravelMonth] = @TravelMonth,
			[TravelYear] = @TravelYear,
			[SendDate] = @SendDate,
			[Status] = @Status,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblPriceRequest_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPriceRequest_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblPriceRequest_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblPriceRequest' table using the primary key value.
CREATE PROCEDURE [tblPriceRequest_DeleteByPrimaryKey]
	@ID decimal(18,0)
AS
	DELETE FROM [dbo].[tblPriceRequest] WHERE
		[ID] = @ID
GO

-- Drop the 'tblPriceRequest_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPriceRequest_DeleteAll') AND type='P')
	DROP PROCEDURE [tblPriceRequest_DeleteAll]
GO

-- Deletes all records from the 'tblPriceRequest' table.
CREATE PROCEDURE [tblPriceRequest_DeleteAll]
AS
	DELETE FROM [dbo].[tblPriceRequest]
GO

-- Drop the 'tblPriceRequest_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPriceRequest_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblPriceRequest_DeleteAdHoc]
GO

-- Deletes records from the 'tblPriceRequest' table that match the supplied where clause.
CREATE PROCEDURE [tblPriceRequest_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblPriceRequest]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblRole' table.
----------------------------------------------------------

-- Drop the 'tblRole_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblRole_GetAll') AND type='P')
	DROP PROCEDURE [tblRole_GetAll]
GO

-- Gets all records from the 'tblRole' table.
CREATE PROCEDURE [tblRole_GetAll]
AS
	SELECT [ID], [RoleName], [OrderBy], [RegDate]
	FROM [dbo].[tblRole]
GO

-- Drop the 'tblRole_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblRole_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblRole_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblRole' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblRole_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[ID] Int		,
					[RoleName] nvarchar(255)		,
					[OrderBy] Int		,
					[RegDate] datetime		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [ID], [RoleName], [OrderBy], [RegDate]
		FROM [dbo].[tblRole]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblRole]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [RoleName], [OrderBy], [RegDate] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [ID], [RoleName], [OrderBy], [RegDate]
				FROM [dbo].[tblRole]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblRole]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [RoleName], [OrderBy], [RegDate]
				FROM [dbo].[tblRole]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblRole]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblRole_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblRole_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblRole_GetAdHoc]
GO

-- Gets records from the 'tblRole' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblRole_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [RoleName], [OrderBy], [RegDate]
		FROM [dbo].[tblRole]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblRole_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblRole_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblRole_GetByPrimaryKey]
GO

-- Gets a record from the 'tblRole' table using the primary key value.
CREATE PROCEDURE [tblRole_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [RoleName], [OrderBy], [RegDate] 
	FROM [dbo].[tblRole] WHERE
		[ID] = @ID
GO

-- Drop the 'tblRole_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblRole_Insert') AND type='P')
	DROP PROCEDURE [tblRole_Insert]
GO

-- Inserts a new record into the 'tblRole' table.
CREATE PROCEDURE [tblRole_Insert]
	@RoleName nvarchar(255),
	@OrderBy Int,
	@RegDate datetime
AS
	INSERT INTO [dbo].[tblRole]
	(
		[RoleName],
		[OrderBy],
		[RegDate]
	)
	VALUES
	(
		@RoleName,
		@OrderBy,
		@RegDate
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblRole_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblRole_Update') AND type='P')
	DROP PROCEDURE [tblRole_Update]
GO

-- Updates a record in the 'tblRole' table.
CREATE PROCEDURE [tblRole_Update]
	-- The rest of writeable parameters
	@RoleName nvarchar(255),
	@OrderBy Int,
	@RegDate datetime,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblRole] SET
		[RoleName] = @RoleName,
		[OrderBy] = @OrderBy,
		[RegDate] = @RegDate
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblRole_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblRole_Save') AND type='P')
	DROP PROCEDURE [tblRole_Save]
GO

-- Insert or updates a new record in the 'tblRole' table.
CREATE PROCEDURE [tblRole_Save]
	-- The rest of writeable parameters
	@RoleName nvarchar(255),
	@OrderBy Int,
	@RegDate datetime,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblRole] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblRole]
		(
			[RoleName],
			[OrderBy],
			[RegDate]
		)
		VALUES
		(
			@RoleName,
			@OrderBy,
			@RegDate
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblRole] SET
			[RoleName] = @RoleName,
			[OrderBy] = @OrderBy,
			[RegDate] = @RegDate
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblRole_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblRole_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblRole_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblRole' table using the primary key value.
CREATE PROCEDURE [tblRole_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblRole] WHERE
		[ID] = @ID
GO

-- Drop the 'tblRole_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblRole_DeleteAll') AND type='P')
	DROP PROCEDURE [tblRole_DeleteAll]
GO

-- Deletes all records from the 'tblRole' table.
CREATE PROCEDURE [tblRole_DeleteAll]
AS
	DELETE FROM [dbo].[tblRole]
GO

-- Drop the 'tblRole_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblRole_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblRole_DeleteAdHoc]
GO

-- Deletes records from the 'tblRole' table that match the supplied where clause.
CREATE PROCEDURE [tblRole_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblRole]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblStaff' table.
----------------------------------------------------------

-- Drop the 'tblStaff_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblStaff_GetAll') AND type='P')
	DROP PROCEDURE [tblStaff_GetAll]
GO

-- Gets all records from the 'tblStaff' table.
CREATE PROCEDURE [tblStaff_GetAll]
AS
	SELECT [ID], [ObjectID], [FullName], [Avatar], [Email], [SkypeID], [Facebook], [Telephone], [Summary], [Description], [Video], [FlgIndex], [Status], [Lang]
	FROM [dbo].[tblStaff]
GO

-- Drop the 'tblStaff_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblStaff_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblStaff_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblStaff' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblStaff_GetPageAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = '',
	@startIndex int,
	@length int,
	@rows int output
AS

	IF @where <> ''
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	IF @startIndex > 1
	BEGIN /* not starting from top so need to insert into a temp table to offset properly */		
		DECLARE @Start int, @End int

		BEGIN TRANSACTION GetDataSet

		SET @Start = @startIndex

		SET @End = (@Start + @length - 1)
		IF @@ERROR <> 0
		GOTO ErrorHandler
	
		CREATE TABLE #TemporaryTable
		(
			Row int IDENTITY(1,1) PRIMARY KEY,
						[ID] Int		,
					[ObjectID] Int		,
					[FullName] nvarchar(255)		,
					[Avatar] nvarchar(255)		,
					[Email] nvarchar(255)		,
					[SkypeID] nvarchar(255)		,
					[Facebook] nvarchar(500)		,
					[Telephone] nvarchar(50)		,
					[Summary] ntext		,
					[Description] ntext		,
					[Video] ntext		,
					[FlgIndex] Int		,
					[Status] Int		,
					[Lang] nvarchar(10)		
		)
		IF @@ERROR <> 0
			GOTO ErrorHandler

		/* Special case if getting the first row.
		   This performance optimization uses the TOP operator to limit the number of rows we add to the temp table.
		   It assumes that users often page through the grid without filtering.
		   There's no point in adding all the rows to the temp table if we're only getting the, say 20th to 30th of 10,000.
		   We can just add the first 30 and grab from that. */
		DECLARE @total varchar(10)
		SET @total = convert(varchar, @startIndex + @length)
		EXECUTE('INSERT INTO #TemporaryTable
			SELECT TOP ' + @total + ' [ID], [ObjectID], [FullName], [Avatar], [Email], [SkypeID], [Facebook], [Telephone], [Summary], [Description], [Video], [FlgIndex], [Status], [Lang]
		FROM [dbo].[tblStaff]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblStaff]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [ObjectID], [FullName], [Avatar], [Email], [SkypeID], [Facebook], [Telephone], [Summary], [Description], [Video], [FlgIndex], [Status], [Lang] 
		FROM #TemporaryTable
		WHERE (Row >= @Start) AND (Row <= @End)	

		IF @@ERROR <> 0
			GOTO ErrorHandler


		DROP TABLE #TemporaryTable

		COMMIT TRANSACTION GetDataSet
	END /* startindex > 1  */
	ELSE
	BEGIN
		IF @where <> '' 
		BEGIN
			/* Special case if getting the first row with a filter.
			   This performance optimization uses the TOP operator but must use a temp table hack to get the row count */		
			EXECUTE('SELECT TOP ' + @length + ' [ID], [ObjectID], [FullName], [Avatar], [Email], [SkypeID], [Facebook], [Telephone], [Summary], [Description], [Video], [FlgIndex], [Status], [Lang]
				FROM [dbo].[tblStaff]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblStaff]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [ObjectID], [FullName], [Avatar], [Email], [SkypeID], [Facebook], [Telephone], [Summary], [Description], [Video], [FlgIndex], [Status], [Lang]
				FROM [dbo].[tblStaff]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblStaff]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblStaff_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblStaff_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblStaff_GetAdHoc]
GO

-- Gets records from the 'tblStaff' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblStaff_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [ObjectID], [FullName], [Avatar], [Email], [SkypeID], [Facebook], [Telephone], [Summary], [Description], [Video], [FlgIndex], [Status], [Lang]
		FROM [dbo].[tblStaff]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblStaff_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblStaff_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblStaff_GetByPrimaryKey]
GO

-- Gets a record from the 'tblStaff' table using the primary key value.
CREATE PROCEDURE [tblStaff_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [ObjectID], [FullName], [Avatar], [Email], [SkypeID], [Facebook], [Telephone], [Summary], [Description], [Video], [FlgIndex], [Status], [Lang] 
	FROM [dbo].[tblStaff] WHERE
		[ID] = @ID
GO

-- Drop the 'tblStaff_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblStaff_Insert') AND type='P')
	DROP PROCEDURE [tblStaff_Insert]
GO

-- Inserts a new record into the 'tblStaff' table.
CREATE PROCEDURE [tblStaff_Insert]
	@ObjectID Int,
	@FullName nvarchar(255),
	@Avatar nvarchar(255),
	@Email nvarchar(255),
	@SkypeID nvarchar(255),
	@Facebook nvarchar(500),
	@Telephone nvarchar(50),
	@Summary ntext,
	@Description ntext,
	@Video ntext,
	@FlgIndex Int,
	@Status Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblStaff]
	(
		[ObjectID],
		[FullName],
		[Avatar],
		[Email],
		[SkypeID],
		[Facebook],
		[Telephone],
		[Summary],
		[Description],
		[Video],
		[FlgIndex],
		[Status],
		[Lang]
	)
	VALUES
	(
		@ObjectID,
		@FullName,
		@Avatar,
		@Email,
		@SkypeID,
		@Facebook,
		@Telephone,
		@Summary,
		@Description,
		@Video,
		@FlgIndex,
		@Status,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblStaff_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblStaff_Update') AND type='P')
	DROP PROCEDURE [tblStaff_Update]
GO

-- Updates a record in the 'tblStaff' table.
CREATE PROCEDURE [tblStaff_Update]
	-- The rest of writeable parameters
	@ObjectID Int,
	@FullName nvarchar(255),
	@Avatar nvarchar(255),
	@Email nvarchar(255),
	@SkypeID nvarchar(255),
	@Facebook nvarchar(500),
	@Telephone nvarchar(50),
	@Summary ntext,
	@Description ntext,
	@Video ntext,
	@FlgIndex Int,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblStaff] SET
		[ObjectID] = @ObjectID,
		[FullName] = @FullName,
		[Avatar] = @Avatar,
		[Email] = @Email,
		[SkypeID] = @SkypeID,
		[Facebook] = @Facebook,
		[Telephone] = @Telephone,
		[Summary] = @Summary,
		[Description] = @Description,
		[Video] = @Video,
		[FlgIndex] = @FlgIndex,
		[Status] = @Status,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblStaff_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblStaff_Save') AND type='P')
	DROP PROCEDURE [tblStaff_Save]
GO

-- Insert or updates a new record in the 'tblStaff' table.
CREATE PROCEDURE [tblStaff_Save]
	-- The rest of writeable parameters
	@ObjectID Int,
	@FullName nvarchar(255),
	@Avatar nvarchar(255),
	@Email nvarchar(255),
	@SkypeID nvarchar(255),
	@Facebook nvarchar(500),
	@Telephone nvarchar(50),
	@Summary ntext,
	@Description ntext,
	@Video ntext,
	@FlgIndex Int,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblStaff] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblStaff]
		(
			[ObjectID],
			[FullName],
			[Avatar],
			[Email],
			[SkypeID],
			[Facebook],
			[Telephone],
			[Summary],
			[Description],
			[Video],
			[FlgIndex],
			[Status],
			[Lang]
		)
		VALUES
		(
			@ObjectID,
			@FullName,
			@Avatar,
			@Email,
			@SkypeID,
			@Facebook,
			@Telephone,
			@Summary,
			@Description,
			@Video,
			@FlgIndex,
			@Status,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblStaff] SET
			[ObjectID] = @ObjectID,
			[FullName] = @FullName,
			[Avatar] = @Avatar,
			[Email] = @Email,
			[SkypeID] = @SkypeID,
			[Facebook] = @Facebook,
			[Telephone] = @Telephone,
			[Summary] = @Summary,
			[Description] = @Description,
			[Video] = @Video,
			[FlgIndex] = @FlgIndex,
			[Status] = @Status,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblStaff_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblStaff_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblStaff_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblStaff' table using the primary key value.
CREATE PROCEDURE [tblStaff_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblStaff] WHERE
		[ID] = @ID
GO

-- Drop the 'tblStaff_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblStaff_DeleteAll') AND type='P')
	DROP PROCEDURE [tblStaff_DeleteAll]
GO

-- Deletes all records from the 'tblStaff' table.
CREATE PROCEDURE [tblStaff_DeleteAll]
AS
	DELETE FROM [dbo].[tblStaff]
GO

-- Drop the 'tblStaff_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblStaff_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblStaff_DeleteAdHoc]
GO

-- Deletes records from the 'tblStaff' table that match the supplied where clause.
CREATE PROCEDURE [tblStaff_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblStaff]' +	
		@where)	
GO

