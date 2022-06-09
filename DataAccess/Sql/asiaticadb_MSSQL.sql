
---	CuongLM Create 2008.11.14

----------------------------------------------------------
-- All rights reserved.
----------------------------------------------------------

USE [asiaticadb]
GO

----------------------------------------------------------
-- Stored procedures for the 'tblAbout' table.
----------------------------------------------------------

-- Drop the 'tblAbout_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAbout_GetAll') AND type='P')
	DROP PROCEDURE [tblAbout_GetAll]
GO

-- Gets all records from the 'tblAbout' table.
CREATE PROCEDURE [tblAbout_GetAll]
AS
	SELECT [ID], [ParentID], [CountryID], [Title], [SubDomain], [Description], [BannerFile], [OrderBy], [FlgHome], [Status], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
	FROM [dbo].[tblAbout]
GO

-- Drop the 'tblAbout_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAbout_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblAbout_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblAbout' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblAbout_GetPageAdHoc]
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
					[ParentID] Int		,
					[CountryID] Int		,
					[Title] nvarchar(255)		,
					[SubDomain] nvarchar(255)		,
					[Description] ntext		,
					[BannerFile] nvarchar(255)		,
					[OrderBy] Int		,
					[FlgHome] Int		,
					[Status] Int		,
					[RegDate] datetime		,
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
			SELECT TOP ' + @total + ' [ID], [ParentID], [CountryID], [Title], [SubDomain], [Description], [BannerFile], [OrderBy], [FlgHome], [Status], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
		FROM [dbo].[tblAbout]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblAbout]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [ParentID], [CountryID], [Title], [SubDomain], [Description], [BannerFile], [OrderBy], [FlgHome], [Status], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [ParentID], [CountryID], [Title], [SubDomain], [Description], [BannerFile], [OrderBy], [FlgHome], [Status], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
				FROM [dbo].[tblAbout]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblAbout]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [ParentID], [CountryID], [Title], [SubDomain], [Description], [BannerFile], [OrderBy], [FlgHome], [Status], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
				FROM [dbo].[tblAbout]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblAbout]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblAbout_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAbout_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblAbout_GetAdHoc]
GO

-- Gets records from the 'tblAbout' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblAbout_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [ParentID], [CountryID], [Title], [SubDomain], [Description], [BannerFile], [OrderBy], [FlgHome], [Status], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang]
		FROM [dbo].[tblAbout]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblAbout_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAbout_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAbout_GetByPrimaryKey]
GO

-- Gets a record from the 'tblAbout' table using the primary key value.
CREATE PROCEDURE [tblAbout_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [ParentID], [CountryID], [Title], [SubDomain], [Description], [BannerFile], [OrderBy], [FlgHome], [Status], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Lang] 
	FROM [dbo].[tblAbout] WHERE
		[ID] = @ID
GO

-- Drop the 'tblAbout_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAbout_Insert') AND type='P')
	DROP PROCEDURE [tblAbout_Insert]
GO

-- Inserts a new record into the 'tblAbout' table.
CREATE PROCEDURE [tblAbout_Insert]
	@ParentID Int,
	@CountryID Int,
	@Title nvarchar(255),
	@SubDomain nvarchar(255),
	@Description ntext,
	@BannerFile nvarchar(255),
	@OrderBy Int,
	@FlgHome Int,
	@Status Int,
	@RegDate datetime,
	@SeoTitle nvarchar(1000),
	@SeoKeyword nvarchar(1000),
	@SeoDescription nvarchar(1000),
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblAbout]
	(
		[ParentID],
		[CountryID],
		[Title],
		[SubDomain],
		[Description],
		[BannerFile],
		[OrderBy],
		[FlgHome],
		[Status],
		[RegDate],
		[SeoTitle],
		[SeoKeyword],
		[SeoDescription],
		[Lang]
	)
	VALUES
	(
		@ParentID,
		@CountryID,
		@Title,
		@SubDomain,
		@Description,
		@BannerFile,
		@OrderBy,
		@FlgHome,
		@Status,
		@RegDate,
		@SeoTitle,
		@SeoKeyword,
		@SeoDescription,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblAbout_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAbout_Update') AND type='P')
	DROP PROCEDURE [tblAbout_Update]
GO

-- Updates a record in the 'tblAbout' table.
CREATE PROCEDURE [tblAbout_Update]
	-- The rest of writeable parameters
	@ParentID Int,
	@CountryID Int,
	@Title nvarchar(255),
	@SubDomain nvarchar(255),
	@Description ntext,
	@BannerFile nvarchar(255),
	@OrderBy Int,
	@FlgHome Int,
	@Status Int,
	@RegDate datetime,
	@SeoTitle nvarchar(1000),
	@SeoKeyword nvarchar(1000),
	@SeoDescription nvarchar(1000),
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblAbout] SET
		[ParentID] = @ParentID,
		[CountryID] = @CountryID,
		[Title] = @Title,
		[SubDomain] = @SubDomain,
		[Description] = @Description,
		[BannerFile] = @BannerFile,
		[OrderBy] = @OrderBy,
		[FlgHome] = @FlgHome,
		[Status] = @Status,
		[RegDate] = @RegDate,
		[SeoTitle] = @SeoTitle,
		[SeoKeyword] = @SeoKeyword,
		[SeoDescription] = @SeoDescription,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblAbout_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAbout_Save') AND type='P')
	DROP PROCEDURE [tblAbout_Save]
GO

-- Insert or updates a new record in the 'tblAbout' table.
CREATE PROCEDURE [tblAbout_Save]
	-- The rest of writeable parameters
	@ParentID Int,
	@CountryID Int,
	@Title nvarchar(255),
	@SubDomain nvarchar(255),
	@Description ntext,
	@BannerFile nvarchar(255),
	@OrderBy Int,
	@FlgHome Int,
	@Status Int,
	@RegDate datetime,
	@SeoTitle nvarchar(1000),
	@SeoKeyword nvarchar(1000),
	@SeoDescription nvarchar(1000),
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblAbout] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblAbout]
		(
			[ParentID],
			[CountryID],
			[Title],
			[SubDomain],
			[Description],
			[BannerFile],
			[OrderBy],
			[FlgHome],
			[Status],
			[RegDate],
			[SeoTitle],
			[SeoKeyword],
			[SeoDescription],
			[Lang]
		)
		VALUES
		(
			@ParentID,
			@CountryID,
			@Title,
			@SubDomain,
			@Description,
			@BannerFile,
			@OrderBy,
			@FlgHome,
			@Status,
			@RegDate,
			@SeoTitle,
			@SeoKeyword,
			@SeoDescription,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblAbout] SET
			[ParentID] = @ParentID,
			[CountryID] = @CountryID,
			[Title] = @Title,
			[SubDomain] = @SubDomain,
			[Description] = @Description,
			[BannerFile] = @BannerFile,
			[OrderBy] = @OrderBy,
			[FlgHome] = @FlgHome,
			[Status] = @Status,
			[RegDate] = @RegDate,
			[SeoTitle] = @SeoTitle,
			[SeoKeyword] = @SeoKeyword,
			[SeoDescription] = @SeoDescription,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblAbout_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAbout_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAbout_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblAbout' table using the primary key value.
CREATE PROCEDURE [tblAbout_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblAbout] WHERE
		[ID] = @ID
GO

-- Drop the 'tblAbout_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAbout_DeleteAll') AND type='P')
	DROP PROCEDURE [tblAbout_DeleteAll]
GO

-- Deletes all records from the 'tblAbout' table.
CREATE PROCEDURE [tblAbout_DeleteAll]
AS
	DELETE FROM [dbo].[tblAbout]
GO

-- Drop the 'tblAbout_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAbout_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblAbout_DeleteAdHoc]
GO

-- Deletes records from the 'tblAbout' table that match the supplied where clause.
CREATE PROCEDURE [tblAbout_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblAbout]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblAgeAdultLang' table.
----------------------------------------------------------

-- Drop the 'tblAgeAdultLang_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeAdultLang_GetAll') AND type='P')
	DROP PROCEDURE [tblAgeAdultLang_GetAll]
GO

-- Gets all records from the 'tblAgeAdultLang' table.
CREATE PROCEDURE [tblAgeAdultLang_GetAll]
AS
	SELECT [ID], [Title], [OrderBy], [Lang]
	FROM [dbo].[tblAgeAdultLang]
GO

-- Drop the 'tblAgeAdultLang_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeAdultLang_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblAgeAdultLang_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblAgeAdultLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblAgeAdultLang_GetPageAdHoc]
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
					[Title] nvarchar(255)		,
					[OrderBy] Int		,
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
			SELECT TOP ' + @total + ' [ID], [Title], [OrderBy], [Lang]
		FROM [dbo].[tblAgeAdultLang]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblAgeAdultLang]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [Title], [OrderBy], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [Title], [OrderBy], [Lang]
				FROM [dbo].[tblAgeAdultLang]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblAgeAdultLang]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [Title], [OrderBy], [Lang]
				FROM [dbo].[tblAgeAdultLang]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblAgeAdultLang]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblAgeAdultLang_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeAdultLang_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblAgeAdultLang_GetAdHoc]
GO

-- Gets records from the 'tblAgeAdultLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblAgeAdultLang_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [Title], [OrderBy], [Lang]
		FROM [dbo].[tblAgeAdultLang]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblAgeAdultLang_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeAdultLang_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAgeAdultLang_GetByPrimaryKey]
GO

-- Gets a record from the 'tblAgeAdultLang' table using the primary key value.
CREATE PROCEDURE [tblAgeAdultLang_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [Title], [OrderBy], [Lang] 
	FROM [dbo].[tblAgeAdultLang] WHERE
		[ID] = @ID
GO

-- Drop the 'tblAgeAdultLang_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeAdultLang_Insert') AND type='P')
	DROP PROCEDURE [tblAgeAdultLang_Insert]
GO

-- Inserts a new record into the 'tblAgeAdultLang' table.
CREATE PROCEDURE [tblAgeAdultLang_Insert]
	@Title nvarchar(255),
	@OrderBy Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblAgeAdultLang]
	(
		[Title],
		[OrderBy],
		[Lang]
	)
	VALUES
	(
		@Title,
		@OrderBy,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblAgeAdultLang_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeAdultLang_Update') AND type='P')
	DROP PROCEDURE [tblAgeAdultLang_Update]
GO

-- Updates a record in the 'tblAgeAdultLang' table.
CREATE PROCEDURE [tblAgeAdultLang_Update]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	@OrderBy Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblAgeAdultLang] SET
		[Title] = @Title,
		[OrderBy] = @OrderBy,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblAgeAdultLang_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeAdultLang_Save') AND type='P')
	DROP PROCEDURE [tblAgeAdultLang_Save]
GO

-- Insert or updates a new record in the 'tblAgeAdultLang' table.
CREATE PROCEDURE [tblAgeAdultLang_Save]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	@OrderBy Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblAgeAdultLang] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblAgeAdultLang]
		(
			[Title],
			[OrderBy],
			[Lang]
		)
		VALUES
		(
			@Title,
			@OrderBy,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblAgeAdultLang] SET
			[Title] = @Title,
			[OrderBy] = @OrderBy,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblAgeAdultLang_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeAdultLang_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAgeAdultLang_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblAgeAdultLang' table using the primary key value.
CREATE PROCEDURE [tblAgeAdultLang_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblAgeAdultLang] WHERE
		[ID] = @ID
GO

-- Drop the 'tblAgeAdultLang_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeAdultLang_DeleteAll') AND type='P')
	DROP PROCEDURE [tblAgeAdultLang_DeleteAll]
GO

-- Deletes all records from the 'tblAgeAdultLang' table.
CREATE PROCEDURE [tblAgeAdultLang_DeleteAll]
AS
	DELETE FROM [dbo].[tblAgeAdultLang]
GO

-- Drop the 'tblAgeAdultLang_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeAdultLang_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblAgeAdultLang_DeleteAdHoc]
GO

-- Deletes records from the 'tblAgeAdultLang' table that match the supplied where clause.
CREATE PROCEDURE [tblAgeAdultLang_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblAgeAdultLang]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblAgeChildLang' table.
----------------------------------------------------------

-- Drop the 'tblAgeChildLang_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeChildLang_GetAll') AND type='P')
	DROP PROCEDURE [tblAgeChildLang_GetAll]
GO

-- Gets all records from the 'tblAgeChildLang' table.
CREATE PROCEDURE [tblAgeChildLang_GetAll]
AS
	SELECT [ID], [Title], [OrderBy]
	FROM [dbo].[tblAgeChildLang]
GO

-- Drop the 'tblAgeChildLang_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeChildLang_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblAgeChildLang_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblAgeChildLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblAgeChildLang_GetPageAdHoc]
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
					[Title] nvarchar(255)		,
					[OrderBy] Int		
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
			SELECT TOP ' + @total + ' [ID], [Title], [OrderBy]
		FROM [dbo].[tblAgeChildLang]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblAgeChildLang]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [Title], [OrderBy] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [Title], [OrderBy]
				FROM [dbo].[tblAgeChildLang]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblAgeChildLang]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [Title], [OrderBy]
				FROM [dbo].[tblAgeChildLang]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblAgeChildLang]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblAgeChildLang_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeChildLang_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblAgeChildLang_GetAdHoc]
GO

-- Gets records from the 'tblAgeChildLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblAgeChildLang_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [Title], [OrderBy]
		FROM [dbo].[tblAgeChildLang]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblAgeChildLang_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeChildLang_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAgeChildLang_GetByPrimaryKey]
GO

-- Gets a record from the 'tblAgeChildLang' table using the primary key value.
CREATE PROCEDURE [tblAgeChildLang_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [Title], [OrderBy] 
	FROM [dbo].[tblAgeChildLang] WHERE
		[ID] = @ID
GO

-- Drop the 'tblAgeChildLang_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeChildLang_Insert') AND type='P')
	DROP PROCEDURE [tblAgeChildLang_Insert]
GO

-- Inserts a new record into the 'tblAgeChildLang' table.
CREATE PROCEDURE [tblAgeChildLang_Insert]
	@Title nvarchar(255),
	@OrderBy Int
AS
	INSERT INTO [dbo].[tblAgeChildLang]
	(
		[Title],
		[OrderBy]
	)
	VALUES
	(
		@Title,
		@OrderBy
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblAgeChildLang_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeChildLang_Update') AND type='P')
	DROP PROCEDURE [tblAgeChildLang_Update]
GO

-- Updates a record in the 'tblAgeChildLang' table.
CREATE PROCEDURE [tblAgeChildLang_Update]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	@OrderBy Int,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblAgeChildLang] SET
		[Title] = @Title,
		[OrderBy] = @OrderBy
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblAgeChildLang_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeChildLang_Save') AND type='P')
	DROP PROCEDURE [tblAgeChildLang_Save]
GO

-- Insert or updates a new record in the 'tblAgeChildLang' table.
CREATE PROCEDURE [tblAgeChildLang_Save]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	@OrderBy Int,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblAgeChildLang] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblAgeChildLang]
		(
			[Title],
			[OrderBy]
		)
		VALUES
		(
			@Title,
			@OrderBy
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblAgeChildLang] SET
			[Title] = @Title,
			[OrderBy] = @OrderBy
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblAgeChildLang_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeChildLang_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAgeChildLang_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblAgeChildLang' table using the primary key value.
CREATE PROCEDURE [tblAgeChildLang_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblAgeChildLang] WHERE
		[ID] = @ID
GO

-- Drop the 'tblAgeChildLang_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeChildLang_DeleteAll') AND type='P')
	DROP PROCEDURE [tblAgeChildLang_DeleteAll]
GO

-- Deletes all records from the 'tblAgeChildLang' table.
CREATE PROCEDURE [tblAgeChildLang_DeleteAll]
AS
	DELETE FROM [dbo].[tblAgeChildLang]
GO

-- Drop the 'tblAgeChildLang_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAgeChildLang_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblAgeChildLang_DeleteAdHoc]
GO

-- Deletes records from the 'tblAgeChildLang' table that match the supplied where clause.
CREATE PROCEDURE [tblAgeChildLang_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblAgeChildLang]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblAttractions' table.
----------------------------------------------------------

-- Drop the 'tblAttractions_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_GetAll') AND type='P')
	DROP PROCEDURE [tblAttractions_GetAll]
GO

-- Gets all records from the 'tblAttractions' table.
CREATE PROCEDURE [tblAttractions_GetAll]
AS
	SELECT [ID], [CountryID], [ParentID], [Levels], [OrderBy], [FlgActivities], [FlgIndex], [FlgHome], [FlgSite], [FlgHotel], [Status], [RegDate]
	FROM [dbo].[tblAttractions]
GO

-- Drop the 'tblAttractions_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractions_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblAttractions' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblAttractions_GetPageAdHoc]
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
					[ParentID] Int		,
					[Levels] Int		,
					[OrderBy] Int		,
					[FlgActivities] Int		,
					[FlgIndex] Int		,
					[FlgHome] Int		,
					[FlgSite] Int		,
					[FlgHotel] Int		,
					[Status] Int		,
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
			SELECT TOP ' + @total + ' [ID], [CountryID], [ParentID], [Levels], [OrderBy], [FlgActivities], [FlgIndex], [FlgHome], [FlgSite], [FlgHotel], [Status], [RegDate]
		FROM [dbo].[tblAttractions]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblAttractions]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [CountryID], [ParentID], [Levels], [OrderBy], [FlgActivities], [FlgIndex], [FlgHome], [FlgSite], [FlgHotel], [Status], [RegDate] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [CountryID], [ParentID], [Levels], [OrderBy], [FlgActivities], [FlgIndex], [FlgHome], [FlgSite], [FlgHotel], [Status], [RegDate]
				FROM [dbo].[tblAttractions]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblAttractions]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [CountryID], [ParentID], [Levels], [OrderBy], [FlgActivities], [FlgIndex], [FlgHome], [FlgSite], [FlgHotel], [Status], [RegDate]
				FROM [dbo].[tblAttractions]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblAttractions]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblAttractions_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractions_GetAdHoc]
GO

-- Gets records from the 'tblAttractions' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblAttractions_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [CountryID], [ParentID], [Levels], [OrderBy], [FlgActivities], [FlgIndex], [FlgHome], [FlgSite], [FlgHotel], [Status], [RegDate]
		FROM [dbo].[tblAttractions]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblAttractions_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAttractions_GetByPrimaryKey]
GO

-- Gets a record from the 'tblAttractions' table using the primary key value.
CREATE PROCEDURE [tblAttractions_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [CountryID], [ParentID], [Levels], [OrderBy], [FlgActivities], [FlgIndex], [FlgHome], [FlgSite], [FlgHotel], [Status], [RegDate] 
	FROM [dbo].[tblAttractions] WHERE
		[ID] = @ID
GO

-- Drop the 'tblAttractions_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_Insert') AND type='P')
	DROP PROCEDURE [tblAttractions_Insert]
GO

-- Inserts a new record into the 'tblAttractions' table.
CREATE PROCEDURE [tblAttractions_Insert]
	@CountryID Int,
	@ParentID Int,
	@Levels Int,
	@OrderBy Int,
	@FlgActivities Int,
	@FlgIndex Int,
	@FlgHome Int,
	@FlgSite Int,
	@FlgHotel Int,
	@Status Int,
	@RegDate datetime
AS
	INSERT INTO [dbo].[tblAttractions]
	(
		[CountryID],
		[ParentID],
		[Levels],
		[OrderBy],
		[FlgActivities],
		[FlgIndex],
		[FlgHome],
		[FlgSite],
		[FlgHotel],
		[Status],
		[RegDate]
	)
	VALUES
	(
		@CountryID,
		@ParentID,
		@Levels,
		@OrderBy,
		@FlgActivities,
		@FlgIndex,
		@FlgHome,
		@FlgSite,
		@FlgHotel,
		@Status,
		@RegDate
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblAttractions_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_Update') AND type='P')
	DROP PROCEDURE [tblAttractions_Update]
GO

-- Updates a record in the 'tblAttractions' table.
CREATE PROCEDURE [tblAttractions_Update]
	-- The rest of writeable parameters
	@CountryID Int,
	@ParentID Int,
	@Levels Int,
	@OrderBy Int,
	@FlgActivities Int,
	@FlgIndex Int,
	@FlgHome Int,
	@FlgSite Int,
	@FlgHotel Int,
	@Status Int,
	@RegDate datetime,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblAttractions] SET
		[CountryID] = @CountryID,
		[ParentID] = @ParentID,
		[Levels] = @Levels,
		[OrderBy] = @OrderBy,
		[FlgActivities] = @FlgActivities,
		[FlgIndex] = @FlgIndex,
		[FlgHome] = @FlgHome,
		[FlgSite] = @FlgSite,
		[FlgHotel] = @FlgHotel,
		[Status] = @Status,
		[RegDate] = @RegDate
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblAttractions_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_Save') AND type='P')
	DROP PROCEDURE [tblAttractions_Save]
GO

-- Insert or updates a new record in the 'tblAttractions' table.
CREATE PROCEDURE [tblAttractions_Save]
	-- The rest of writeable parameters
	@CountryID Int,
	@ParentID Int,
	@Levels Int,
	@OrderBy Int,
	@FlgActivities Int,
	@FlgIndex Int,
	@FlgHome Int,
	@FlgSite Int,
	@FlgHotel Int,
	@Status Int,
	@RegDate datetime,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblAttractions] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblAttractions]
		(
			[CountryID],
			[ParentID],
			[Levels],
			[OrderBy],
			[FlgActivities],
			[FlgIndex],
			[FlgHome],
			[FlgSite],
			[FlgHotel],
			[Status],
			[RegDate]
		)
		VALUES
		(
			@CountryID,
			@ParentID,
			@Levels,
			@OrderBy,
			@FlgActivities,
			@FlgIndex,
			@FlgHome,
			@FlgSite,
			@FlgHotel,
			@Status,
			@RegDate
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblAttractions] SET
			[CountryID] = @CountryID,
			[ParentID] = @ParentID,
			[Levels] = @Levels,
			[OrderBy] = @OrderBy,
			[FlgActivities] = @FlgActivities,
			[FlgIndex] = @FlgIndex,
			[FlgHome] = @FlgHome,
			[FlgSite] = @FlgSite,
			[FlgHotel] = @FlgHotel,
			[Status] = @Status,
			[RegDate] = @RegDate
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblAttractions_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAttractions_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblAttractions' table using the primary key value.
CREATE PROCEDURE [tblAttractions_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblAttractions] WHERE
		[ID] = @ID
GO

-- Drop the 'tblAttractions_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_DeleteAll') AND type='P')
	DROP PROCEDURE [tblAttractions_DeleteAll]
GO

-- Deletes all records from the 'tblAttractions' table.
CREATE PROCEDURE [tblAttractions_DeleteAll]
AS
	DELETE FROM [dbo].[tblAttractions]
GO

-- Drop the 'tblAttractions_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractions_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractions_DeleteAdHoc]
GO

-- Deletes records from the 'tblAttractions' table that match the supplied where clause.
CREATE PROCEDURE [tblAttractions_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblAttractions]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblAttractionsGallery' table.
----------------------------------------------------------

-- Drop the 'tblAttractionsGallery_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_GetAll') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_GetAll]
GO

-- Gets all records from the 'tblAttractionsGallery' table.
CREATE PROCEDURE [tblAttractionsGallery_GetAll]
AS
	SELECT [ID], [AttractionsID], [ImageFile], [Status], [IsList], [IsDetail], [IsBanner]
	FROM [dbo].[tblAttractionsGallery]
GO

-- Drop the 'tblAttractionsGallery_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblAttractionsGallery' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblAttractionsGallery_GetPageAdHoc]
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
					[Status] Int		,
					[IsList] Int		,
					[IsDetail] Int		,
					[IsBanner] Int		
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
			SELECT TOP ' + @total + ' [ID], [AttractionsID], [ImageFile], [Status], [IsList], [IsDetail], [IsBanner]
		FROM [dbo].[tblAttractionsGallery]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblAttractionsGallery]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [AttractionsID], [ImageFile], [Status], [IsList], [IsDetail], [IsBanner] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [AttractionsID], [ImageFile], [Status], [IsList], [IsDetail], [IsBanner]
				FROM [dbo].[tblAttractionsGallery]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblAttractionsGallery]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [AttractionsID], [ImageFile], [Status], [IsList], [IsDetail], [IsBanner]
				FROM [dbo].[tblAttractionsGallery]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblAttractionsGallery]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblAttractionsGallery_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_GetAdHoc]
GO

-- Gets records from the 'tblAttractionsGallery' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblAttractionsGallery_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [AttractionsID], [ImageFile], [Status], [IsList], [IsDetail], [IsBanner]
		FROM [dbo].[tblAttractionsGallery]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblAttractionsGallery_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_GetByPrimaryKey]
GO

-- Gets a record from the 'tblAttractionsGallery' table using the primary key value.
CREATE PROCEDURE [tblAttractionsGallery_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [AttractionsID], [ImageFile], [Status], [IsList], [IsDetail], [IsBanner] 
	FROM [dbo].[tblAttractionsGallery] WHERE
		[ID] = @ID
GO

-- Drop the 'tblAttractionsGallery_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_Insert') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_Insert]
GO

-- Inserts a new record into the 'tblAttractionsGallery' table.
CREATE PROCEDURE [tblAttractionsGallery_Insert]
	@AttractionsID Int,
	@ImageFile nvarchar(255),
	@Status Int,
	@IsList Int,
	@IsDetail Int,
	@IsBanner Int
AS
	INSERT INTO [dbo].[tblAttractionsGallery]
	(
		[AttractionsID],
		[ImageFile],
		[Status],
		[IsList],
		[IsDetail],
		[IsBanner]
	)
	VALUES
	(
		@AttractionsID,
		@ImageFile,
		@Status,
		@IsList,
		@IsDetail,
		@IsBanner
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblAttractionsGallery_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_Update') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_Update]
GO

-- Updates a record in the 'tblAttractionsGallery' table.
CREATE PROCEDURE [tblAttractionsGallery_Update]
	-- The rest of writeable parameters
	@AttractionsID Int,
	@ImageFile nvarchar(255),
	@Status Int,
	@IsList Int,
	@IsDetail Int,
	@IsBanner Int,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblAttractionsGallery] SET
		[AttractionsID] = @AttractionsID,
		[ImageFile] = @ImageFile,
		[Status] = @Status,
		[IsList] = @IsList,
		[IsDetail] = @IsDetail,
		[IsBanner] = @IsBanner
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblAttractionsGallery_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_Save') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_Save]
GO

-- Insert or updates a new record in the 'tblAttractionsGallery' table.
CREATE PROCEDURE [tblAttractionsGallery_Save]
	-- The rest of writeable parameters
	@AttractionsID Int,
	@ImageFile nvarchar(255),
	@Status Int,
	@IsList Int,
	@IsDetail Int,
	@IsBanner Int,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblAttractionsGallery] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblAttractionsGallery]
		(
			[AttractionsID],
			[ImageFile],
			[Status],
			[IsList],
			[IsDetail],
			[IsBanner]
		)
		VALUES
		(
			@AttractionsID,
			@ImageFile,
			@Status,
			@IsList,
			@IsDetail,
			@IsBanner
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblAttractionsGallery] SET
			[AttractionsID] = @AttractionsID,
			[ImageFile] = @ImageFile,
			[Status] = @Status,
			[IsList] = @IsList,
			[IsDetail] = @IsDetail,
			[IsBanner] = @IsBanner
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblAttractionsGallery_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblAttractionsGallery' table using the primary key value.
CREATE PROCEDURE [tblAttractionsGallery_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblAttractionsGallery] WHERE
		[ID] = @ID
GO

-- Drop the 'tblAttractionsGallery_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_DeleteAll') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_DeleteAll]
GO

-- Deletes all records from the 'tblAttractionsGallery' table.
CREATE PROCEDURE [tblAttractionsGallery_DeleteAll]
AS
	DELETE FROM [dbo].[tblAttractionsGallery]
GO

-- Drop the 'tblAttractionsGallery_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGallery_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractionsGallery_DeleteAdHoc]
GO

-- Deletes records from the 'tblAttractionsGallery' table that match the supplied where clause.
CREATE PROCEDURE [tblAttractionsGallery_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblAttractionsGallery]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblAttractionsGalleryLang' table.
----------------------------------------------------------

-- Drop the 'tblAttractionsGalleryLang_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGalleryLang_GetAll') AND type='P')
	DROP PROCEDURE [tblAttractionsGalleryLang_GetAll]
GO

-- Gets all records from the 'tblAttractionsGalleryLang' table.
CREATE PROCEDURE [tblAttractionsGalleryLang_GetAll]
AS
	SELECT [AttractionsGalleryID], [ImageTitle], [ImageAlt], [Lang]
	FROM [dbo].[tblAttractionsGalleryLang]
GO

-- Drop the 'tblAttractionsGalleryLang_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGalleryLang_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractionsGalleryLang_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblAttractionsGalleryLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblAttractionsGalleryLang_GetPageAdHoc]
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
						[AttractionsGalleryID] Int		,
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
			SELECT TOP ' + @total + ' [AttractionsGalleryID], [ImageTitle], [ImageAlt], [Lang]
		FROM [dbo].[tblAttractionsGalleryLang]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblAttractionsGalleryLang]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[AttractionsGalleryID], [ImageTitle], [ImageAlt], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [AttractionsGalleryID], [ImageTitle], [ImageAlt], [Lang]
				FROM [dbo].[tblAttractionsGalleryLang]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblAttractionsGalleryLang]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [AttractionsGalleryID], [ImageTitle], [ImageAlt], [Lang]
				FROM [dbo].[tblAttractionsGalleryLang]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblAttractionsGalleryLang]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblAttractionsGalleryLang_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGalleryLang_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractionsGalleryLang_GetAdHoc]
GO

-- Gets records from the 'tblAttractionsGalleryLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblAttractionsGalleryLang_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [AttractionsGalleryID], [ImageTitle], [ImageAlt], [Lang]
		FROM [dbo].[tblAttractionsGalleryLang]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblAttractionsGalleryLang_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGalleryLang_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAttractionsGalleryLang_GetByPrimaryKey]
GO

-- Gets a record from the 'tblAttractionsGalleryLang' table using the primary key value.
CREATE PROCEDURE [tblAttractionsGalleryLang_GetByPrimaryKey]
	@AttractionsGalleryID Int,
	@Lang nvarchar(10)
AS
	SELECT [AttractionsGalleryID], [ImageTitle], [ImageAlt], [Lang] 
	FROM [dbo].[tblAttractionsGalleryLang] WHERE
		[AttractionsGalleryID] = @AttractionsGalleryID AND
		[Lang] = @Lang
GO

-- Drop the 'tblAttractionsGalleryLang_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGalleryLang_Insert') AND type='P')
	DROP PROCEDURE [tblAttractionsGalleryLang_Insert]
GO

-- Inserts a new record into the 'tblAttractionsGalleryLang' table.
CREATE PROCEDURE [tblAttractionsGalleryLang_Insert]
	@AttractionsGalleryID Int,
	@ImageTitle nvarchar(255),
	@ImageAlt nvarchar(255),
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblAttractionsGalleryLang]
	(
		[AttractionsGalleryID],
		[ImageTitle],
		[ImageAlt],
		[Lang]
	)
	VALUES
	(
		@AttractionsGalleryID,
		@ImageTitle,
		@ImageAlt,
		@Lang
	)
GO

-- Drop the 'tblAttractionsGalleryLang_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGalleryLang_Update') AND type='P')
	DROP PROCEDURE [tblAttractionsGalleryLang_Update]
GO

-- Updates a record in the 'tblAttractionsGalleryLang' table.
CREATE PROCEDURE [tblAttractionsGalleryLang_Update]
	-- The rest of writeable parameters
	@ImageTitle nvarchar(255),
	@ImageAlt nvarchar(255),
	-- Primary key parameters
	@AttractionsGalleryID Int,
	@Lang nvarchar(10)
AS
	UPDATE [dbo].[tblAttractionsGalleryLang] SET
		[ImageTitle] = @ImageTitle,
		[ImageAlt] = @ImageAlt
	WHERE
		[AttractionsGalleryID] = @AttractionsGalleryID AND
		[Lang] = @Lang
GO
-- Drop the 'tblAttractionsGalleryLang_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGalleryLang_Save') AND type='P')
	DROP PROCEDURE [tblAttractionsGalleryLang_Save]
GO

-- Insert or updates a new record in the 'tblAttractionsGalleryLang' table.
CREATE PROCEDURE [tblAttractionsGalleryLang_Save]
	-- The rest of writeable parameters
	@ImageTitle nvarchar(255),
	@ImageAlt nvarchar(255),
	-- Primary key parameters
	@AttractionsGalleryID Int,
	@Lang nvarchar(10)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblAttractionsGalleryLang] Where 
	[AttractionsGalleryID] = @AttractionsGalleryID 
 AND 
	[Lang] = @Lang 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblAttractionsGalleryLang]
		(
			[AttractionsGalleryID],
			[ImageTitle],
			[ImageAlt],
			[Lang]
		)
		VALUES
		(
			@AttractionsGalleryID,
			@ImageTitle,
			@ImageAlt,
			@Lang
		)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblAttractionsGalleryLang] SET
			[ImageTitle] = @ImageTitle,
			[ImageAlt] = @ImageAlt
		WHERE
			[AttractionsGalleryID] = @AttractionsGalleryID AND
			[Lang] = @Lang
	END
GO

-- Drop the 'tblAttractionsGalleryLang_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGalleryLang_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAttractionsGalleryLang_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblAttractionsGalleryLang' table using the primary key value.
CREATE PROCEDURE [tblAttractionsGalleryLang_DeleteByPrimaryKey]
	@AttractionsGalleryID Int,
	@Lang nvarchar(10)
AS
	DELETE FROM [dbo].[tblAttractionsGalleryLang] WHERE
		[AttractionsGalleryID] = @AttractionsGalleryID AND
		[Lang] = @Lang
GO

-- Drop the 'tblAttractionsGalleryLang_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGalleryLang_DeleteAll') AND type='P')
	DROP PROCEDURE [tblAttractionsGalleryLang_DeleteAll]
GO

-- Deletes all records from the 'tblAttractionsGalleryLang' table.
CREATE PROCEDURE [tblAttractionsGalleryLang_DeleteAll]
AS
	DELETE FROM [dbo].[tblAttractionsGalleryLang]
GO

-- Drop the 'tblAttractionsGalleryLang_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsGalleryLang_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractionsGalleryLang_DeleteAdHoc]
GO

-- Deletes records from the 'tblAttractionsGalleryLang' table that match the supplied where clause.
CREATE PROCEDURE [tblAttractionsGalleryLang_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblAttractionsGalleryLang]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblAttractionsLang' table.
----------------------------------------------------------

-- Drop the 'tblAttractionsLang_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsLang_GetAll') AND type='P')
	DROP PROCEDURE [tblAttractionsLang_GetAll]
GO

-- Gets all records from the 'tblAttractionsLang' table.
CREATE PROCEDURE [tblAttractionsLang_GetAll]
AS
	SELECT [AttractionsID], [AttractionsName], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [Description], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang]
	FROM [dbo].[tblAttractionsLang]
GO

-- Drop the 'tblAttractionsLang_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsLang_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractionsLang_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblAttractionsLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblAttractionsLang_GetPageAdHoc]
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
						[AttractionsID] Int		,
					[AttractionsName] nvarchar(255)		,
					[SubDomainTour] nvarchar(255)		,
					[SubDomainSite] nvarchar(255)		,
					[SubDomainHotel] nvarchar(255)		,
					[SubDescriptionTour] ntext		,
					[SubDescriptionSite] ntext		,
					[SubDescriptionHotel] ntext		,
					[Description] ntext		,
					[SeoTitleTour] nvarchar(1500)		,
					[SeoKeywordTour] nvarchar(1500)		,
					[SeoDescriptionTour] nvarchar(1500)		,
					[SeoTitleSite] nvarchar(1000)		,
					[SeoKeywordSite] nvarchar(1000)		,
					[SeoDescriptionSite] nvarchar(1000)		,
					[SeoTitleHotel] nvarchar(1500)		,
					[SeoKeywordHotel] nvarchar(1500)		,
					[SeoDescriptionHotel] nvarchar(1500)		,
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
			SELECT TOP ' + @total + ' [AttractionsID], [AttractionsName], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [Description], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang]
		FROM [dbo].[tblAttractionsLang]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblAttractionsLang]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[AttractionsID], [AttractionsName], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [Description], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [AttractionsID], [AttractionsName], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [Description], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang]
				FROM [dbo].[tblAttractionsLang]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblAttractionsLang]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [AttractionsID], [AttractionsName], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [Description], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang]
				FROM [dbo].[tblAttractionsLang]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblAttractionsLang]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblAttractionsLang_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsLang_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractionsLang_GetAdHoc]
GO

-- Gets records from the 'tblAttractionsLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblAttractionsLang_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [AttractionsID], [AttractionsName], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [Description], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang]
		FROM [dbo].[tblAttractionsLang]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblAttractionsLang_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsLang_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAttractionsLang_GetByPrimaryKey]
GO

-- Gets a record from the 'tblAttractionsLang' table using the primary key value.
CREATE PROCEDURE [tblAttractionsLang_GetByPrimaryKey]
	@AttractionsID Int,
	@Lang nvarchar(10)
AS
	SELECT [AttractionsID], [AttractionsName], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [Description], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang] 
	FROM [dbo].[tblAttractionsLang] WHERE
		[AttractionsID] = @AttractionsID AND
		[Lang] = @Lang
GO

-- Drop the 'tblAttractionsLang_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsLang_Insert') AND type='P')
	DROP PROCEDURE [tblAttractionsLang_Insert]
GO

-- Inserts a new record into the 'tblAttractionsLang' table.
CREATE PROCEDURE [tblAttractionsLang_Insert]
	@AttractionsID Int,
	@AttractionsName nvarchar(255),
	@SubDomainTour nvarchar(255),
	@SubDomainSite nvarchar(255),
	@SubDomainHotel nvarchar(255),
	@SubDescriptionTour ntext,
	@SubDescriptionSite ntext,
	@SubDescriptionHotel ntext,
	@Description ntext,
	@SeoTitleTour nvarchar(1500),
	@SeoKeywordTour nvarchar(1500),
	@SeoDescriptionTour nvarchar(1500),
	@SeoTitleSite nvarchar(1000),
	@SeoKeywordSite nvarchar(1000),
	@SeoDescriptionSite nvarchar(1000),
	@SeoTitleHotel nvarchar(1500),
	@SeoKeywordHotel nvarchar(1500),
	@SeoDescriptionHotel nvarchar(1500),
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblAttractionsLang]
	(
		[AttractionsID],
		[AttractionsName],
		[SubDomainTour],
		[SubDomainSite],
		[SubDomainHotel],
		[SubDescriptionTour],
		[SubDescriptionSite],
		[SubDescriptionHotel],
		[Description],
		[SeoTitleTour],
		[SeoKeywordTour],
		[SeoDescriptionTour],
		[SeoTitleSite],
		[SeoKeywordSite],
		[SeoDescriptionSite],
		[SeoTitleHotel],
		[SeoKeywordHotel],
		[SeoDescriptionHotel],
		[Lang]
	)
	VALUES
	(
		@AttractionsID,
		@AttractionsName,
		@SubDomainTour,
		@SubDomainSite,
		@SubDomainHotel,
		@SubDescriptionTour,
		@SubDescriptionSite,
		@SubDescriptionHotel,
		@Description,
		@SeoTitleTour,
		@SeoKeywordTour,
		@SeoDescriptionTour,
		@SeoTitleSite,
		@SeoKeywordSite,
		@SeoDescriptionSite,
		@SeoTitleHotel,
		@SeoKeywordHotel,
		@SeoDescriptionHotel,
		@Lang
	)
GO

-- Drop the 'tblAttractionsLang_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsLang_Update') AND type='P')
	DROP PROCEDURE [tblAttractionsLang_Update]
GO

-- Updates a record in the 'tblAttractionsLang' table.
CREATE PROCEDURE [tblAttractionsLang_Update]
	-- The rest of writeable parameters
	@AttractionsName nvarchar(255),
	@SubDomainTour nvarchar(255),
	@SubDomainSite nvarchar(255),
	@SubDomainHotel nvarchar(255),
	@SubDescriptionTour ntext,
	@SubDescriptionSite ntext,
	@SubDescriptionHotel ntext,
	@Description ntext,
	@SeoTitleTour nvarchar(1500),
	@SeoKeywordTour nvarchar(1500),
	@SeoDescriptionTour nvarchar(1500),
	@SeoTitleSite nvarchar(1000),
	@SeoKeywordSite nvarchar(1000),
	@SeoDescriptionSite nvarchar(1000),
	@SeoTitleHotel nvarchar(1500),
	@SeoKeywordHotel nvarchar(1500),
	@SeoDescriptionHotel nvarchar(1500),
	-- Primary key parameters
	@AttractionsID Int,
	@Lang nvarchar(10)
AS
	UPDATE [dbo].[tblAttractionsLang] SET
		[AttractionsName] = @AttractionsName,
		[SubDomainTour] = @SubDomainTour,
		[SubDomainSite] = @SubDomainSite,
		[SubDomainHotel] = @SubDomainHotel,
		[SubDescriptionTour] = @SubDescriptionTour,
		[SubDescriptionSite] = @SubDescriptionSite,
		[SubDescriptionHotel] = @SubDescriptionHotel,
		[Description] = @Description,
		[SeoTitleTour] = @SeoTitleTour,
		[SeoKeywordTour] = @SeoKeywordTour,
		[SeoDescriptionTour] = @SeoDescriptionTour,
		[SeoTitleSite] = @SeoTitleSite,
		[SeoKeywordSite] = @SeoKeywordSite,
		[SeoDescriptionSite] = @SeoDescriptionSite,
		[SeoTitleHotel] = @SeoTitleHotel,
		[SeoKeywordHotel] = @SeoKeywordHotel,
		[SeoDescriptionHotel] = @SeoDescriptionHotel
	WHERE
		[AttractionsID] = @AttractionsID AND
		[Lang] = @Lang
GO
-- Drop the 'tblAttractionsLang_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsLang_Save') AND type='P')
	DROP PROCEDURE [tblAttractionsLang_Save]
GO

-- Insert or updates a new record in the 'tblAttractionsLang' table.
CREATE PROCEDURE [tblAttractionsLang_Save]
	-- The rest of writeable parameters
	@AttractionsName nvarchar(255),
	@SubDomainTour nvarchar(255),
	@SubDomainSite nvarchar(255),
	@SubDomainHotel nvarchar(255),
	@SubDescriptionTour ntext,
	@SubDescriptionSite ntext,
	@SubDescriptionHotel ntext,
	@Description ntext,
	@SeoTitleTour nvarchar(1500),
	@SeoKeywordTour nvarchar(1500),
	@SeoDescriptionTour nvarchar(1500),
	@SeoTitleSite nvarchar(1000),
	@SeoKeywordSite nvarchar(1000),
	@SeoDescriptionSite nvarchar(1000),
	@SeoTitleHotel nvarchar(1500),
	@SeoKeywordHotel nvarchar(1500),
	@SeoDescriptionHotel nvarchar(1500),
	-- Primary key parameters
	@AttractionsID Int,
	@Lang nvarchar(10)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblAttractionsLang] Where 
	[AttractionsID] = @AttractionsID 
 AND 
	[Lang] = @Lang 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblAttractionsLang]
		(
			[AttractionsID],
			[AttractionsName],
			[SubDomainTour],
			[SubDomainSite],
			[SubDomainHotel],
			[SubDescriptionTour],
			[SubDescriptionSite],
			[SubDescriptionHotel],
			[Description],
			[SeoTitleTour],
			[SeoKeywordTour],
			[SeoDescriptionTour],
			[SeoTitleSite],
			[SeoKeywordSite],
			[SeoDescriptionSite],
			[SeoTitleHotel],
			[SeoKeywordHotel],
			[SeoDescriptionHotel],
			[Lang]
		)
		VALUES
		(
			@AttractionsID,
			@AttractionsName,
			@SubDomainTour,
			@SubDomainSite,
			@SubDomainHotel,
			@SubDescriptionTour,
			@SubDescriptionSite,
			@SubDescriptionHotel,
			@Description,
			@SeoTitleTour,
			@SeoKeywordTour,
			@SeoDescriptionTour,
			@SeoTitleSite,
			@SeoKeywordSite,
			@SeoDescriptionSite,
			@SeoTitleHotel,
			@SeoKeywordHotel,
			@SeoDescriptionHotel,
			@Lang
		)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblAttractionsLang] SET
			[AttractionsName] = @AttractionsName,
			[SubDomainTour] = @SubDomainTour,
			[SubDomainSite] = @SubDomainSite,
			[SubDomainHotel] = @SubDomainHotel,
			[SubDescriptionTour] = @SubDescriptionTour,
			[SubDescriptionSite] = @SubDescriptionSite,
			[SubDescriptionHotel] = @SubDescriptionHotel,
			[Description] = @Description,
			[SeoTitleTour] = @SeoTitleTour,
			[SeoKeywordTour] = @SeoKeywordTour,
			[SeoDescriptionTour] = @SeoDescriptionTour,
			[SeoTitleSite] = @SeoTitleSite,
			[SeoKeywordSite] = @SeoKeywordSite,
			[SeoDescriptionSite] = @SeoDescriptionSite,
			[SeoTitleHotel] = @SeoTitleHotel,
			[SeoKeywordHotel] = @SeoKeywordHotel,
			[SeoDescriptionHotel] = @SeoDescriptionHotel
		WHERE
			[AttractionsID] = @AttractionsID AND
			[Lang] = @Lang
	END
GO

-- Drop the 'tblAttractionsLang_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsLang_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblAttractionsLang_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblAttractionsLang' table using the primary key value.
CREATE PROCEDURE [tblAttractionsLang_DeleteByPrimaryKey]
	@AttractionsID Int,
	@Lang nvarchar(10)
AS
	DELETE FROM [dbo].[tblAttractionsLang] WHERE
		[AttractionsID] = @AttractionsID AND
		[Lang] = @Lang
GO

-- Drop the 'tblAttractionsLang_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsLang_DeleteAll') AND type='P')
	DROP PROCEDURE [tblAttractionsLang_DeleteAll]
GO

-- Deletes all records from the 'tblAttractionsLang' table.
CREATE PROCEDURE [tblAttractionsLang_DeleteAll]
AS
	DELETE FROM [dbo].[tblAttractionsLang]
GO

-- Drop the 'tblAttractionsLang_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblAttractionsLang_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblAttractionsLang_DeleteAdHoc]
GO

-- Deletes records from the 'tblAttractionsLang' table that match the supplied where clause.
CREATE PROCEDURE [tblAttractionsLang_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblAttractionsLang]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblBannerHome' table.
----------------------------------------------------------

-- Drop the 'tblBannerHome_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblBannerHome_GetAll') AND type='P')
	DROP PROCEDURE [tblBannerHome_GetAll]
GO

-- Gets all records from the 'tblBannerHome' table.
CREATE PROCEDURE [tblBannerHome_GetAll]
AS
	SELECT [ID], [ObjectID], [CountryID], [Title], [ImageFile], [UrlLink], [Description], [Status], [Lang]
	FROM [dbo].[tblBannerHome]
GO

-- Drop the 'tblBannerHome_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblBannerHome_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblBannerHome_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblBannerHome' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblBannerHome_GetPageAdHoc]
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
					[CountryID] Int		,
					[Title] nvarchar(255)		,
					[ImageFile] nvarchar(255)		,
					[UrlLink] nvarchar(255)		,
					[Description] nvarchar(500)		,
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
			SELECT TOP ' + @total + ' [ID], [ObjectID], [CountryID], [Title], [ImageFile], [UrlLink], [Description], [Status], [Lang]
		FROM [dbo].[tblBannerHome]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblBannerHome]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [ObjectID], [CountryID], [Title], [ImageFile], [UrlLink], [Description], [Status], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [ObjectID], [CountryID], [Title], [ImageFile], [UrlLink], [Description], [Status], [Lang]
				FROM [dbo].[tblBannerHome]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblBannerHome]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [ObjectID], [CountryID], [Title], [ImageFile], [UrlLink], [Description], [Status], [Lang]
				FROM [dbo].[tblBannerHome]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblBannerHome]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblBannerHome_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblBannerHome_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblBannerHome_GetAdHoc]
GO

-- Gets records from the 'tblBannerHome' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblBannerHome_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [ObjectID], [CountryID], [Title], [ImageFile], [UrlLink], [Description], [Status], [Lang]
		FROM [dbo].[tblBannerHome]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblBannerHome_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblBannerHome_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblBannerHome_GetByPrimaryKey]
GO

-- Gets a record from the 'tblBannerHome' table using the primary key value.
CREATE PROCEDURE [tblBannerHome_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [ObjectID], [CountryID], [Title], [ImageFile], [UrlLink], [Description], [Status], [Lang] 
	FROM [dbo].[tblBannerHome] WHERE
		[ID] = @ID
GO

-- Drop the 'tblBannerHome_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblBannerHome_Insert') AND type='P')
	DROP PROCEDURE [tblBannerHome_Insert]
GO

-- Inserts a new record into the 'tblBannerHome' table.
CREATE PROCEDURE [tblBannerHome_Insert]
	@ObjectID Int,
	@CountryID Int,
	@Title nvarchar(255),
	@ImageFile nvarchar(255),
	@UrlLink nvarchar(255),
	@Description nvarchar(500),
	@Status Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblBannerHome]
	(
		[ObjectID],
		[CountryID],
		[Title],
		[ImageFile],
		[UrlLink],
		[Description],
		[Status],
		[Lang]
	)
	VALUES
	(
		@ObjectID,
		@CountryID,
		@Title,
		@ImageFile,
		@UrlLink,
		@Description,
		@Status,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblBannerHome_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblBannerHome_Update') AND type='P')
	DROP PROCEDURE [tblBannerHome_Update]
GO

-- Updates a record in the 'tblBannerHome' table.
CREATE PROCEDURE [tblBannerHome_Update]
	-- The rest of writeable parameters
	@ObjectID Int,
	@CountryID Int,
	@Title nvarchar(255),
	@ImageFile nvarchar(255),
	@UrlLink nvarchar(255),
	@Description nvarchar(500),
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblBannerHome] SET
		[ObjectID] = @ObjectID,
		[CountryID] = @CountryID,
		[Title] = @Title,
		[ImageFile] = @ImageFile,
		[UrlLink] = @UrlLink,
		[Description] = @Description,
		[Status] = @Status,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblBannerHome_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblBannerHome_Save') AND type='P')
	DROP PROCEDURE [tblBannerHome_Save]
GO

-- Insert or updates a new record in the 'tblBannerHome' table.
CREATE PROCEDURE [tblBannerHome_Save]
	-- The rest of writeable parameters
	@ObjectID Int,
	@CountryID Int,
	@Title nvarchar(255),
	@ImageFile nvarchar(255),
	@UrlLink nvarchar(255),
	@Description nvarchar(500),
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblBannerHome] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblBannerHome]
		(
			[ObjectID],
			[CountryID],
			[Title],
			[ImageFile],
			[UrlLink],
			[Description],
			[Status],
			[Lang]
		)
		VALUES
		(
			@ObjectID,
			@CountryID,
			@Title,
			@ImageFile,
			@UrlLink,
			@Description,
			@Status,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblBannerHome] SET
			[ObjectID] = @ObjectID,
			[CountryID] = @CountryID,
			[Title] = @Title,
			[ImageFile] = @ImageFile,
			[UrlLink] = @UrlLink,
			[Description] = @Description,
			[Status] = @Status,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblBannerHome_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblBannerHome_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblBannerHome_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblBannerHome' table using the primary key value.
CREATE PROCEDURE [tblBannerHome_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblBannerHome] WHERE
		[ID] = @ID
GO

-- Drop the 'tblBannerHome_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblBannerHome_DeleteAll') AND type='P')
	DROP PROCEDURE [tblBannerHome_DeleteAll]
GO

-- Deletes all records from the 'tblBannerHome' table.
CREATE PROCEDURE [tblBannerHome_DeleteAll]
AS
	DELETE FROM [dbo].[tblBannerHome]
GO

-- Drop the 'tblBannerHome_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblBannerHome_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblBannerHome_DeleteAdHoc]
GO

-- Deletes records from the 'tblBannerHome' table that match the supplied where clause.
CREATE PROCEDURE [tblBannerHome_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblBannerHome]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCompany' table.
----------------------------------------------------------

-- Drop the 'tblCompany_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCompany_GetAll') AND type='P')
	DROP PROCEDURE [tblCompany_GetAll]
GO

-- Gets all records from the 'tblCompany' table.
CREATE PROCEDURE [tblCompany_GetAll]
AS
	SELECT [ID], [Name], [OrderBy]
	FROM [dbo].[tblCompany]
GO

-- Drop the 'tblCompany_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCompany_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCompany_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCompany' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCompany_GetPageAdHoc]
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
					[Name] nvarchar(255)		,
					[OrderBy] Int		
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
			SELECT TOP ' + @total + ' [ID], [Name], [OrderBy]
		FROM [dbo].[tblCompany]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCompany]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [Name], [OrderBy] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [Name], [OrderBy]
				FROM [dbo].[tblCompany]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCompany]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [Name], [OrderBy]
				FROM [dbo].[tblCompany]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCompany]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCompany_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCompany_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCompany_GetAdHoc]
GO

-- Gets records from the 'tblCompany' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCompany_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [Name], [OrderBy]
		FROM [dbo].[tblCompany]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCompany_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCompany_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCompany_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCompany' table using the primary key value.
CREATE PROCEDURE [tblCompany_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [Name], [OrderBy] 
	FROM [dbo].[tblCompany] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCompany_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCompany_Insert') AND type='P')
	DROP PROCEDURE [tblCompany_Insert]
GO

-- Inserts a new record into the 'tblCompany' table.
CREATE PROCEDURE [tblCompany_Insert]
	@Name nvarchar(255),
	@OrderBy Int
AS
	INSERT INTO [dbo].[tblCompany]
	(
		[Name],
		[OrderBy]
	)
	VALUES
	(
		@Name,
		@OrderBy
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblCompany_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCompany_Update') AND type='P')
	DROP PROCEDURE [tblCompany_Update]
GO

-- Updates a record in the 'tblCompany' table.
CREATE PROCEDURE [tblCompany_Update]
	-- The rest of writeable parameters
	@Name nvarchar(255),
	@OrderBy Int,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblCompany] SET
		[Name] = @Name,
		[OrderBy] = @OrderBy
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblCompany_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCompany_Save') AND type='P')
	DROP PROCEDURE [tblCompany_Save]
GO

-- Insert or updates a new record in the 'tblCompany' table.
CREATE PROCEDURE [tblCompany_Save]
	-- The rest of writeable parameters
	@Name nvarchar(255),
	@OrderBy Int,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblCompany] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblCompany]
		(
			[Name],
			[OrderBy]
		)
		VALUES
		(
			@Name,
			@OrderBy
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblCompany] SET
			[Name] = @Name,
			[OrderBy] = @OrderBy
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblCompany_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCompany_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCompany_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCompany' table using the primary key value.
CREATE PROCEDURE [tblCompany_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblCompany] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCompany_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCompany_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCompany_DeleteAll]
GO

-- Deletes all records from the 'tblCompany' table.
CREATE PROCEDURE [tblCompany_DeleteAll]
AS
	DELETE FROM [dbo].[tblCompany]
GO

-- Drop the 'tblCompany_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCompany_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCompany_DeleteAdHoc]
GO

-- Deletes records from the 'tblCompany' table that match the supplied where clause.
CREATE PROCEDURE [tblCompany_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCompany]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblConfig' table.
----------------------------------------------------------

-- Drop the 'tblConfig_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblConfig_GetAll') AND type='P')
	DROP PROCEDURE [tblConfig_GetAll]
GO

-- Gets all records from the 'tblConfig' table.
CREATE PROCEDURE [tblConfig_GetAll]
AS
	SELECT [ID], [CompanyName], [Title], [Keyword], [Description], [Facebook], [Twitter], [Youtube], [DisplayName], [EmailAddress], [Password], [SMTPServer], [SMTPPort], [IsSSL], [MailServer], [ServerPort], [Lang]
	FROM [dbo].[tblConfig]
GO

-- Drop the 'tblConfig_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblConfig_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblConfig_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblConfig' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblConfig_GetPageAdHoc]
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
					[CompanyName] nvarchar(255)		,
					[Title] nvarchar(1000)		,
					[Keyword] nvarchar(1000)		,
					[Description] nvarchar(1000)		,
					[Facebook] nvarchar(500)		,
					[Twitter] nvarchar(500)		,
					[Youtube] nvarchar(500)		,
					[DisplayName] nvarchar(255)		,
					[EmailAddress] varchar(100)		,
					[Password] nvarchar(50)		,
					[SMTPServer] nvarchar(255)		,
					[SMTPPort] Int		,
					[IsSSL] bit		,
					[MailServer] nvarchar(255)		,
					[ServerPort] Int		,
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
			SELECT TOP ' + @total + ' [ID], [CompanyName], [Title], [Keyword], [Description], [Facebook], [Twitter], [Youtube], [DisplayName], [EmailAddress], [Password], [SMTPServer], [SMTPPort], [IsSSL], [MailServer], [ServerPort], [Lang]
		FROM [dbo].[tblConfig]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblConfig]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [CompanyName], [Title], [Keyword], [Description], [Facebook], [Twitter], [Youtube], [DisplayName], [EmailAddress], [Password], [SMTPServer], [SMTPPort], [IsSSL], [MailServer], [ServerPort], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [CompanyName], [Title], [Keyword], [Description], [Facebook], [Twitter], [Youtube], [DisplayName], [EmailAddress], [Password], [SMTPServer], [SMTPPort], [IsSSL], [MailServer], [ServerPort], [Lang]
				FROM [dbo].[tblConfig]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblConfig]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [CompanyName], [Title], [Keyword], [Description], [Facebook], [Twitter], [Youtube], [DisplayName], [EmailAddress], [Password], [SMTPServer], [SMTPPort], [IsSSL], [MailServer], [ServerPort], [Lang]
				FROM [dbo].[tblConfig]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblConfig]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblConfig_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblConfig_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblConfig_GetAdHoc]
GO

-- Gets records from the 'tblConfig' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblConfig_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [CompanyName], [Title], [Keyword], [Description], [Facebook], [Twitter], [Youtube], [DisplayName], [EmailAddress], [Password], [SMTPServer], [SMTPPort], [IsSSL], [MailServer], [ServerPort], [Lang]
		FROM [dbo].[tblConfig]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblConfig_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblConfig_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblConfig_GetByPrimaryKey]
GO

-- Gets a record from the 'tblConfig' table using the primary key value.
CREATE PROCEDURE [tblConfig_GetByPrimaryKey]
	@ID Int,
	@Lang nvarchar(10)
AS
	SELECT [ID], [CompanyName], [Title], [Keyword], [Description], [Facebook], [Twitter], [Youtube], [DisplayName], [EmailAddress], [Password], [SMTPServer], [SMTPPort], [IsSSL], [MailServer], [ServerPort], [Lang] 
	FROM [dbo].[tblConfig] WHERE
		[ID] = @ID AND
		[Lang] = @Lang
GO

-- Drop the 'tblConfig_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblConfig_Insert') AND type='P')
	DROP PROCEDURE [tblConfig_Insert]
GO

-- Inserts a new record into the 'tblConfig' table.
CREATE PROCEDURE [tblConfig_Insert]
	@ID Int,
	@CompanyName nvarchar(255),
	@Title nvarchar(1000),
	@Keyword nvarchar(1000),
	@Description nvarchar(1000),
	@Facebook nvarchar(500),
	@Twitter nvarchar(500),
	@Youtube nvarchar(500),
	@DisplayName nvarchar(255),
	@EmailAddress varchar(100),
	@Password nvarchar(50),
	@SMTPServer nvarchar(255),
	@SMTPPort Int,
	@IsSSL bit,
	@MailServer nvarchar(255),
	@ServerPort Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblConfig]
	(
		[ID],
		[CompanyName],
		[Title],
		[Keyword],
		[Description],
		[Facebook],
		[Twitter],
		[Youtube],
		[DisplayName],
		[EmailAddress],
		[Password],
		[SMTPServer],
		[SMTPPort],
		[IsSSL],
		[MailServer],
		[ServerPort],
		[Lang]
	)
	VALUES
	(
		@ID,
		@CompanyName,
		@Title,
		@Keyword,
		@Description,
		@Facebook,
		@Twitter,
		@Youtube,
		@DisplayName,
		@EmailAddress,
		@Password,
		@SMTPServer,
		@SMTPPort,
		@IsSSL,
		@MailServer,
		@ServerPort,
		@Lang
	)
GO

-- Drop the 'tblConfig_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblConfig_Update') AND type='P')
	DROP PROCEDURE [tblConfig_Update]
GO

-- Updates a record in the 'tblConfig' table.
CREATE PROCEDURE [tblConfig_Update]
	-- The rest of writeable parameters
	@CompanyName nvarchar(255),
	@Title nvarchar(1000),
	@Keyword nvarchar(1000),
	@Description nvarchar(1000),
	@Facebook nvarchar(500),
	@Twitter nvarchar(500),
	@Youtube nvarchar(500),
	@DisplayName nvarchar(255),
	@EmailAddress varchar(100),
	@Password nvarchar(50),
	@SMTPServer nvarchar(255),
	@SMTPPort Int,
	@IsSSL bit,
	@MailServer nvarchar(255),
	@ServerPort Int,
	-- Primary key parameters
	@ID Int,
	@Lang nvarchar(10)
AS
	UPDATE [dbo].[tblConfig] SET
		[CompanyName] = @CompanyName,
		[Title] = @Title,
		[Keyword] = @Keyword,
		[Description] = @Description,
		[Facebook] = @Facebook,
		[Twitter] = @Twitter,
		[Youtube] = @Youtube,
		[DisplayName] = @DisplayName,
		[EmailAddress] = @EmailAddress,
		[Password] = @Password,
		[SMTPServer] = @SMTPServer,
		[SMTPPort] = @SMTPPort,
		[IsSSL] = @IsSSL,
		[MailServer] = @MailServer,
		[ServerPort] = @ServerPort
	WHERE
		[ID] = @ID AND
		[Lang] = @Lang
GO
-- Drop the 'tblConfig_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblConfig_Save') AND type='P')
	DROP PROCEDURE [tblConfig_Save]
GO

-- Insert or updates a new record in the 'tblConfig' table.
CREATE PROCEDURE [tblConfig_Save]
	-- The rest of writeable parameters
	@CompanyName nvarchar(255),
	@Title nvarchar(1000),
	@Keyword nvarchar(1000),
	@Description nvarchar(1000),
	@Facebook nvarchar(500),
	@Twitter nvarchar(500),
	@Youtube nvarchar(500),
	@DisplayName nvarchar(255),
	@EmailAddress varchar(100),
	@Password nvarchar(50),
	@SMTPServer nvarchar(255),
	@SMTPPort Int,
	@IsSSL bit,
	@MailServer nvarchar(255),
	@ServerPort Int,
	-- Primary key parameters
	@ID Int,
	@Lang nvarchar(10)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblConfig] Where 
	[ID] = @ID 
 AND 
	[Lang] = @Lang 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblConfig]
		(
			[ID],
			[CompanyName],
			[Title],
			[Keyword],
			[Description],
			[Facebook],
			[Twitter],
			[Youtube],
			[DisplayName],
			[EmailAddress],
			[Password],
			[SMTPServer],
			[SMTPPort],
			[IsSSL],
			[MailServer],
			[ServerPort],
			[Lang]
		)
		VALUES
		(
			@ID,
			@CompanyName,
			@Title,
			@Keyword,
			@Description,
			@Facebook,
			@Twitter,
			@Youtube,
			@DisplayName,
			@EmailAddress,
			@Password,
			@SMTPServer,
			@SMTPPort,
			@IsSSL,
			@MailServer,
			@ServerPort,
			@Lang
		)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblConfig] SET
			[CompanyName] = @CompanyName,
			[Title] = @Title,
			[Keyword] = @Keyword,
			[Description] = @Description,
			[Facebook] = @Facebook,
			[Twitter] = @Twitter,
			[Youtube] = @Youtube,
			[DisplayName] = @DisplayName,
			[EmailAddress] = @EmailAddress,
			[Password] = @Password,
			[SMTPServer] = @SMTPServer,
			[SMTPPort] = @SMTPPort,
			[IsSSL] = @IsSSL,
			[MailServer] = @MailServer,
			[ServerPort] = @ServerPort
		WHERE
			[ID] = @ID AND
			[Lang] = @Lang
	END
GO

-- Drop the 'tblConfig_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblConfig_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblConfig_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblConfig' table using the primary key value.
CREATE PROCEDURE [tblConfig_DeleteByPrimaryKey]
	@ID Int,
	@Lang nvarchar(10)
AS
	DELETE FROM [dbo].[tblConfig] WHERE
		[ID] = @ID AND
		[Lang] = @Lang
GO

-- Drop the 'tblConfig_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblConfig_DeleteAll') AND type='P')
	DROP PROCEDURE [tblConfig_DeleteAll]
GO

-- Deletes all records from the 'tblConfig' table.
CREATE PROCEDURE [tblConfig_DeleteAll]
AS
	DELETE FROM [dbo].[tblConfig]
GO

-- Drop the 'tblConfig_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblConfig_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblConfig_DeleteAdHoc]
GO

-- Deletes records from the 'tblConfig' table that match the supplied where clause.
CREATE PROCEDURE [tblConfig_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblConfig]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblContact' table.
----------------------------------------------------------

-- Drop the 'tblContact_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblContact_GetAll') AND type='P')
	DROP PROCEDURE [tblContact_GetAll]
GO

-- Gets all records from the 'tblContact' table.
CREATE PROCEDURE [tblContact_GetAll]
AS
	SELECT [ID], [Gender], [FirstName], [LastName], [NationalityID], [Address], [ZipCode], [City], [CountryName], [Telephone], [Email], [Subject], [Request], [PostedDate], [Status], [Lang]
	FROM [dbo].[tblContact]
GO

-- Drop the 'tblContact_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblContact_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblContact_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblContact' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblContact_GetPageAdHoc]
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
					[Gender] nvarchar(50)		,
					[FirstName] nvarchar(255)		,
					[LastName] nvarchar(255)		,
					[NationalityID] Int		,
					[Address] nvarchar(500)		,
					[ZipCode] nvarchar(50)		,
					[City] nvarchar(255)		,
					[CountryName] nvarchar(255)		,
					[Telephone] nvarchar(50)		,
					[Email] nvarchar(255)		,
					[Subject] nvarchar(500)		,
					[Request] nvarchar(2000)		,
					[PostedDate] datetime		,
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
			SELECT TOP ' + @total + ' [ID], [Gender], [FirstName], [LastName], [NationalityID], [Address], [ZipCode], [City], [CountryName], [Telephone], [Email], [Subject], [Request], [PostedDate], [Status], [Lang]
		FROM [dbo].[tblContact]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblContact]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [Gender], [FirstName], [LastName], [NationalityID], [Address], [ZipCode], [City], [CountryName], [Telephone], [Email], [Subject], [Request], [PostedDate], [Status], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [Gender], [FirstName], [LastName], [NationalityID], [Address], [ZipCode], [City], [CountryName], [Telephone], [Email], [Subject], [Request], [PostedDate], [Status], [Lang]
				FROM [dbo].[tblContact]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblContact]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [Gender], [FirstName], [LastName], [NationalityID], [Address], [ZipCode], [City], [CountryName], [Telephone], [Email], [Subject], [Request], [PostedDate], [Status], [Lang]
				FROM [dbo].[tblContact]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblContact]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblContact_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblContact_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblContact_GetAdHoc]
GO

-- Gets records from the 'tblContact' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblContact_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [Gender], [FirstName], [LastName], [NationalityID], [Address], [ZipCode], [City], [CountryName], [Telephone], [Email], [Subject], [Request], [PostedDate], [Status], [Lang]
		FROM [dbo].[tblContact]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblContact_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblContact_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblContact_GetByPrimaryKey]
GO

-- Gets a record from the 'tblContact' table using the primary key value.
CREATE PROCEDURE [tblContact_GetByPrimaryKey]
	@ID decimal(18,0)
AS
	SELECT [ID], [Gender], [FirstName], [LastName], [NationalityID], [Address], [ZipCode], [City], [CountryName], [Telephone], [Email], [Subject], [Request], [PostedDate], [Status], [Lang] 
	FROM [dbo].[tblContact] WHERE
		[ID] = @ID
GO

-- Drop the 'tblContact_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblContact_Insert') AND type='P')
	DROP PROCEDURE [tblContact_Insert]
GO

-- Inserts a new record into the 'tblContact' table.
CREATE PROCEDURE [tblContact_Insert]
	@Gender nvarchar(50),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@NationalityID Int,
	@Address nvarchar(500),
	@ZipCode nvarchar(50),
	@City nvarchar(255),
	@CountryName nvarchar(255),
	@Telephone nvarchar(50),
	@Email nvarchar(255),
	@Subject nvarchar(500),
	@Request nvarchar(2000),
	@PostedDate datetime,
	@Status Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblContact]
	(
		[Gender],
		[FirstName],
		[LastName],
		[NationalityID],
		[Address],
		[ZipCode],
		[City],
		[CountryName],
		[Telephone],
		[Email],
		[Subject],
		[Request],
		[PostedDate],
		[Status],
		[Lang]
	)
	VALUES
	(
		@Gender,
		@FirstName,
		@LastName,
		@NationalityID,
		@Address,
		@ZipCode,
		@City,
		@CountryName,
		@Telephone,
		@Email,
		@Subject,
		@Request,
		@PostedDate,
		@Status,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblContact_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblContact_Update') AND type='P')
	DROP PROCEDURE [tblContact_Update]
GO

-- Updates a record in the 'tblContact' table.
CREATE PROCEDURE [tblContact_Update]
	-- The rest of writeable parameters
	@Gender nvarchar(50),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@NationalityID Int,
	@Address nvarchar(500),
	@ZipCode nvarchar(50),
	@City nvarchar(255),
	@CountryName nvarchar(255),
	@Telephone nvarchar(50),
	@Email nvarchar(255),
	@Subject nvarchar(500),
	@Request nvarchar(2000),
	@PostedDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	UPDATE [dbo].[tblContact] SET
		[Gender] = @Gender,
		[FirstName] = @FirstName,
		[LastName] = @LastName,
		[NationalityID] = @NationalityID,
		[Address] = @Address,
		[ZipCode] = @ZipCode,
		[City] = @City,
		[CountryName] = @CountryName,
		[Telephone] = @Telephone,
		[Email] = @Email,
		[Subject] = @Subject,
		[Request] = @Request,
		[PostedDate] = @PostedDate,
		[Status] = @Status,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblContact_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblContact_Save') AND type='P')
	DROP PROCEDURE [tblContact_Save]
GO

-- Insert or updates a new record in the 'tblContact' table.
CREATE PROCEDURE [tblContact_Save]
	-- The rest of writeable parameters
	@Gender nvarchar(50),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@NationalityID Int,
	@Address nvarchar(500),
	@ZipCode nvarchar(50),
	@City nvarchar(255),
	@CountryName nvarchar(255),
	@Telephone nvarchar(50),
	@Email nvarchar(255),
	@Subject nvarchar(500),
	@Request nvarchar(2000),
	@PostedDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblContact] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblContact]
		(
			[Gender],
			[FirstName],
			[LastName],
			[NationalityID],
			[Address],
			[ZipCode],
			[City],
			[CountryName],
			[Telephone],
			[Email],
			[Subject],
			[Request],
			[PostedDate],
			[Status],
			[Lang]
		)
		VALUES
		(
			@Gender,
			@FirstName,
			@LastName,
			@NationalityID,
			@Address,
			@ZipCode,
			@City,
			@CountryName,
			@Telephone,
			@Email,
			@Subject,
			@Request,
			@PostedDate,
			@Status,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblContact] SET
			[Gender] = @Gender,
			[FirstName] = @FirstName,
			[LastName] = @LastName,
			[NationalityID] = @NationalityID,
			[Address] = @Address,
			[ZipCode] = @ZipCode,
			[City] = @City,
			[CountryName] = @CountryName,
			[Telephone] = @Telephone,
			[Email] = @Email,
			[Subject] = @Subject,
			[Request] = @Request,
			[PostedDate] = @PostedDate,
			[Status] = @Status,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblContact_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblContact_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblContact_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblContact' table using the primary key value.
CREATE PROCEDURE [tblContact_DeleteByPrimaryKey]
	@ID decimal(18,0)
AS
	DELETE FROM [dbo].[tblContact] WHERE
		[ID] = @ID
GO

-- Drop the 'tblContact_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblContact_DeleteAll') AND type='P')
	DROP PROCEDURE [tblContact_DeleteAll]
GO

-- Deletes all records from the 'tblContact' table.
CREATE PROCEDURE [tblContact_DeleteAll]
AS
	DELETE FROM [dbo].[tblContact]
GO

-- Drop the 'tblContact_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblContact_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblContact_DeleteAdHoc]
GO

-- Deletes records from the 'tblContact' table that match the supplied where clause.
CREATE PROCEDURE [tblContact_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblContact]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCountry' table.
----------------------------------------------------------

-- Drop the 'tblCountry_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountry_GetAll') AND type='P')
	DROP PROCEDURE [tblCountry_GetAll]
GO

-- Gets all records from the 'tblCountry' table.
CREATE PROCEDURE [tblCountry_GetAll]
AS
	SELECT [ID], [OrderBy], [IsCombine], [ImageFile], [Status], [RegDate]
	FROM [dbo].[tblCountry]
GO

-- Drop the 'tblCountry_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountry_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCountry_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCountry' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCountry_GetPageAdHoc]
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
					[OrderBy] Int		,
					[IsCombine] Int		,
					[ImageFile] nvarchar(255)		,
					[Status] Int		,
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
			SELECT TOP ' + @total + ' [ID], [OrderBy], [IsCombine], [ImageFile], [Status], [RegDate]
		FROM [dbo].[tblCountry]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCountry]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [OrderBy], [IsCombine], [ImageFile], [Status], [RegDate] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [OrderBy], [IsCombine], [ImageFile], [Status], [RegDate]
				FROM [dbo].[tblCountry]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCountry]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [OrderBy], [IsCombine], [ImageFile], [Status], [RegDate]
				FROM [dbo].[tblCountry]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCountry]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCountry_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountry_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCountry_GetAdHoc]
GO

-- Gets records from the 'tblCountry' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCountry_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [OrderBy], [IsCombine], [ImageFile], [Status], [RegDate]
		FROM [dbo].[tblCountry]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCountry_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountry_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCountry_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCountry' table using the primary key value.
CREATE PROCEDURE [tblCountry_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [OrderBy], [IsCombine], [ImageFile], [Status], [RegDate] 
	FROM [dbo].[tblCountry] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCountry_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountry_Insert') AND type='P')
	DROP PROCEDURE [tblCountry_Insert]
GO

-- Inserts a new record into the 'tblCountry' table.
CREATE PROCEDURE [tblCountry_Insert]
	@OrderBy Int,
	@IsCombine Int,
	@ImageFile nvarchar(255),
	@Status Int,
	@RegDate datetime
AS
	INSERT INTO [dbo].[tblCountry]
	(
		[OrderBy],
		[IsCombine],
		[ImageFile],
		[Status],
		[RegDate]
	)
	VALUES
	(
		@OrderBy,
		@IsCombine,
		@ImageFile,
		@Status,
		@RegDate
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblCountry_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountry_Update') AND type='P')
	DROP PROCEDURE [tblCountry_Update]
GO

-- Updates a record in the 'tblCountry' table.
CREATE PROCEDURE [tblCountry_Update]
	-- The rest of writeable parameters
	@OrderBy Int,
	@IsCombine Int,
	@ImageFile nvarchar(255),
	@Status Int,
	@RegDate datetime,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblCountry] SET
		[OrderBy] = @OrderBy,
		[IsCombine] = @IsCombine,
		[ImageFile] = @ImageFile,
		[Status] = @Status,
		[RegDate] = @RegDate
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblCountry_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountry_Save') AND type='P')
	DROP PROCEDURE [tblCountry_Save]
GO

-- Insert or updates a new record in the 'tblCountry' table.
CREATE PROCEDURE [tblCountry_Save]
	-- The rest of writeable parameters
	@OrderBy Int,
	@IsCombine Int,
	@ImageFile nvarchar(255),
	@Status Int,
	@RegDate datetime,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblCountry] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblCountry]
		(
			[OrderBy],
			[IsCombine],
			[ImageFile],
			[Status],
			[RegDate]
		)
		VALUES
		(
			@OrderBy,
			@IsCombine,
			@ImageFile,
			@Status,
			@RegDate
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblCountry] SET
			[OrderBy] = @OrderBy,
			[IsCombine] = @IsCombine,
			[ImageFile] = @ImageFile,
			[Status] = @Status,
			[RegDate] = @RegDate
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblCountry_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountry_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCountry_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCountry' table using the primary key value.
CREATE PROCEDURE [tblCountry_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblCountry] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCountry_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountry_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCountry_DeleteAll]
GO

-- Deletes all records from the 'tblCountry' table.
CREATE PROCEDURE [tblCountry_DeleteAll]
AS
	DELETE FROM [dbo].[tblCountry]
GO

-- Drop the 'tblCountry_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountry_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCountry_DeleteAdHoc]
GO

-- Deletes records from the 'tblCountry' table that match the supplied where clause.
CREATE PROCEDURE [tblCountry_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCountry]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCountryLang' table.
----------------------------------------------------------

-- Drop the 'tblCountryLang_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountryLang_GetAll') AND type='P')
	DROP PROCEDURE [tblCountryLang_GetAll]
GO

-- Gets all records from the 'tblCountryLang' table.
CREATE PROCEDURE [tblCountryLang_GetAll]
AS
	SELECT [CountryID], [CountryName], [SubDomain], [Description], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [SeoTitle], [SeoKeyword], [SeoDescription], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang]
	FROM [dbo].[tblCountryLang]
GO

-- Drop the 'tblCountryLang_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountryLang_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCountryLang_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCountryLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCountryLang_GetPageAdHoc]
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
						[CountryID] Int		,
					[CountryName] nvarchar(255)		,
					[SubDomain] nvarchar(255)		,
					[Description] ntext		,
					[SubDomainTour] nvarchar(255)		,
					[SubDomainSite] nvarchar(255)		,
					[SubDomainHotel] nvarchar(255)		,
					[SubDescriptionTour] ntext		,
					[SubDescriptionSite] ntext		,
					[SubDescriptionHotel] ntext		,
					[SeoTitle] nvarchar(1500)		,
					[SeoKeyword] nvarchar(1500)		,
					[SeoDescription] nvarchar(1500)		,
					[SeoTitleTour] nvarchar(1500)		,
					[SeoKeywordTour] nvarchar(1500)		,
					[SeoDescriptionTour] nvarchar(1500)		,
					[SeoTitleSite] nvarchar(1500)		,
					[SeoKeywordSite] nvarchar(1500)		,
					[SeoDescriptionSite] nvarchar(1500)		,
					[SeoTitleHotel] nvarchar(1500)		,
					[SeoKeywordHotel] nvarchar(1500)		,
					[SeoDescriptionHotel] nvarchar(1500)		,
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
			SELECT TOP ' + @total + ' [CountryID], [CountryName], [SubDomain], [Description], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [SeoTitle], [SeoKeyword], [SeoDescription], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang]
		FROM [dbo].[tblCountryLang]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCountryLang]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[CountryID], [CountryName], [SubDomain], [Description], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [SeoTitle], [SeoKeyword], [SeoDescription], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [CountryID], [CountryName], [SubDomain], [Description], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [SeoTitle], [SeoKeyword], [SeoDescription], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang]
				FROM [dbo].[tblCountryLang]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCountryLang]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [CountryID], [CountryName], [SubDomain], [Description], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [SeoTitle], [SeoKeyword], [SeoDescription], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang]
				FROM [dbo].[tblCountryLang]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCountryLang]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCountryLang_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountryLang_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCountryLang_GetAdHoc]
GO

-- Gets records from the 'tblCountryLang' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCountryLang_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [CountryID], [CountryName], [SubDomain], [Description], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [SeoTitle], [SeoKeyword], [SeoDescription], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang]
		FROM [dbo].[tblCountryLang]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCountryLang_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountryLang_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCountryLang_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCountryLang' table using the primary key value.
CREATE PROCEDURE [tblCountryLang_GetByPrimaryKey]
	@CountryID Int,
	@Lang nvarchar(10)
AS
	SELECT [CountryID], [CountryName], [SubDomain], [Description], [SubDomainTour], [SubDomainSite], [SubDomainHotel], [SubDescriptionTour], [SubDescriptionSite], [SubDescriptionHotel], [SeoTitle], [SeoKeyword], [SeoDescription], [SeoTitleTour], [SeoKeywordTour], [SeoDescriptionTour], [SeoTitleSite], [SeoKeywordSite], [SeoDescriptionSite], [SeoTitleHotel], [SeoKeywordHotel], [SeoDescriptionHotel], [Lang] 
	FROM [dbo].[tblCountryLang] WHERE
		[CountryID] = @CountryID AND
		[Lang] = @Lang
GO

-- Drop the 'tblCountryLang_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountryLang_Insert') AND type='P')
	DROP PROCEDURE [tblCountryLang_Insert]
GO

-- Inserts a new record into the 'tblCountryLang' table.
CREATE PROCEDURE [tblCountryLang_Insert]
	@CountryID Int,
	@CountryName nvarchar(255),
	@SubDomain nvarchar(255),
	@Description ntext,
	@SubDomainTour nvarchar(255),
	@SubDomainSite nvarchar(255),
	@SubDomainHotel nvarchar(255),
	@SubDescriptionTour ntext,
	@SubDescriptionSite ntext,
	@SubDescriptionHotel ntext,
	@SeoTitle nvarchar(1500),
	@SeoKeyword nvarchar(1500),
	@SeoDescription nvarchar(1500),
	@SeoTitleTour nvarchar(1500),
	@SeoKeywordTour nvarchar(1500),
	@SeoDescriptionTour nvarchar(1500),
	@SeoTitleSite nvarchar(1500),
	@SeoKeywordSite nvarchar(1500),
	@SeoDescriptionSite nvarchar(1500),
	@SeoTitleHotel nvarchar(1500),
	@SeoKeywordHotel nvarchar(1500),
	@SeoDescriptionHotel nvarchar(1500),
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblCountryLang]
	(
		[CountryID],
		[CountryName],
		[SubDomain],
		[Description],
		[SubDomainTour],
		[SubDomainSite],
		[SubDomainHotel],
		[SubDescriptionTour],
		[SubDescriptionSite],
		[SubDescriptionHotel],
		[SeoTitle],
		[SeoKeyword],
		[SeoDescription],
		[SeoTitleTour],
		[SeoKeywordTour],
		[SeoDescriptionTour],
		[SeoTitleSite],
		[SeoKeywordSite],
		[SeoDescriptionSite],
		[SeoTitleHotel],
		[SeoKeywordHotel],
		[SeoDescriptionHotel],
		[Lang]
	)
	VALUES
	(
		@CountryID,
		@CountryName,
		@SubDomain,
		@Description,
		@SubDomainTour,
		@SubDomainSite,
		@SubDomainHotel,
		@SubDescriptionTour,
		@SubDescriptionSite,
		@SubDescriptionHotel,
		@SeoTitle,
		@SeoKeyword,
		@SeoDescription,
		@SeoTitleTour,
		@SeoKeywordTour,
		@SeoDescriptionTour,
		@SeoTitleSite,
		@SeoKeywordSite,
		@SeoDescriptionSite,
		@SeoTitleHotel,
		@SeoKeywordHotel,
		@SeoDescriptionHotel,
		@Lang
	)
GO

-- Drop the 'tblCountryLang_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountryLang_Update') AND type='P')
	DROP PROCEDURE [tblCountryLang_Update]
GO

-- Updates a record in the 'tblCountryLang' table.
CREATE PROCEDURE [tblCountryLang_Update]
	-- The rest of writeable parameters
	@CountryName nvarchar(255),
	@SubDomain nvarchar(255),
	@Description ntext,
	@SubDomainTour nvarchar(255),
	@SubDomainSite nvarchar(255),
	@SubDomainHotel nvarchar(255),
	@SubDescriptionTour ntext,
	@SubDescriptionSite ntext,
	@SubDescriptionHotel ntext,
	@SeoTitle nvarchar(1500),
	@SeoKeyword nvarchar(1500),
	@SeoDescription nvarchar(1500),
	@SeoTitleTour nvarchar(1500),
	@SeoKeywordTour nvarchar(1500),
	@SeoDescriptionTour nvarchar(1500),
	@SeoTitleSite nvarchar(1500),
	@SeoKeywordSite nvarchar(1500),
	@SeoDescriptionSite nvarchar(1500),
	@SeoTitleHotel nvarchar(1500),
	@SeoKeywordHotel nvarchar(1500),
	@SeoDescriptionHotel nvarchar(1500),
	-- Primary key parameters
	@CountryID Int,
	@Lang nvarchar(10)
AS
	UPDATE [dbo].[tblCountryLang] SET
		[CountryName] = @CountryName,
		[SubDomain] = @SubDomain,
		[Description] = @Description,
		[SubDomainTour] = @SubDomainTour,
		[SubDomainSite] = @SubDomainSite,
		[SubDomainHotel] = @SubDomainHotel,
		[SubDescriptionTour] = @SubDescriptionTour,
		[SubDescriptionSite] = @SubDescriptionSite,
		[SubDescriptionHotel] = @SubDescriptionHotel,
		[SeoTitle] = @SeoTitle,
		[SeoKeyword] = @SeoKeyword,
		[SeoDescription] = @SeoDescription,
		[SeoTitleTour] = @SeoTitleTour,
		[SeoKeywordTour] = @SeoKeywordTour,
		[SeoDescriptionTour] = @SeoDescriptionTour,
		[SeoTitleSite] = @SeoTitleSite,
		[SeoKeywordSite] = @SeoKeywordSite,
		[SeoDescriptionSite] = @SeoDescriptionSite,
		[SeoTitleHotel] = @SeoTitleHotel,
		[SeoKeywordHotel] = @SeoKeywordHotel,
		[SeoDescriptionHotel] = @SeoDescriptionHotel
	WHERE
		[CountryID] = @CountryID AND
		[Lang] = @Lang
GO
-- Drop the 'tblCountryLang_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountryLang_Save') AND type='P')
	DROP PROCEDURE [tblCountryLang_Save]
GO

-- Insert or updates a new record in the 'tblCountryLang' table.
CREATE PROCEDURE [tblCountryLang_Save]
	-- The rest of writeable parameters
	@CountryName nvarchar(255),
	@SubDomain nvarchar(255),
	@Description ntext,
	@SubDomainTour nvarchar(255),
	@SubDomainSite nvarchar(255),
	@SubDomainHotel nvarchar(255),
	@SubDescriptionTour ntext,
	@SubDescriptionSite ntext,
	@SubDescriptionHotel ntext,
	@SeoTitle nvarchar(1500),
	@SeoKeyword nvarchar(1500),
	@SeoDescription nvarchar(1500),
	@SeoTitleTour nvarchar(1500),
	@SeoKeywordTour nvarchar(1500),
	@SeoDescriptionTour nvarchar(1500),
	@SeoTitleSite nvarchar(1500),
	@SeoKeywordSite nvarchar(1500),
	@SeoDescriptionSite nvarchar(1500),
	@SeoTitleHotel nvarchar(1500),
	@SeoKeywordHotel nvarchar(1500),
	@SeoDescriptionHotel nvarchar(1500),
	-- Primary key parameters
	@CountryID Int,
	@Lang nvarchar(10)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblCountryLang] Where 
	[CountryID] = @CountryID 
 AND 
	[Lang] = @Lang 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblCountryLang]
		(
			[CountryID],
			[CountryName],
			[SubDomain],
			[Description],
			[SubDomainTour],
			[SubDomainSite],
			[SubDomainHotel],
			[SubDescriptionTour],
			[SubDescriptionSite],
			[SubDescriptionHotel],
			[SeoTitle],
			[SeoKeyword],
			[SeoDescription],
			[SeoTitleTour],
			[SeoKeywordTour],
			[SeoDescriptionTour],
			[SeoTitleSite],
			[SeoKeywordSite],
			[SeoDescriptionSite],
			[SeoTitleHotel],
			[SeoKeywordHotel],
			[SeoDescriptionHotel],
			[Lang]
		)
		VALUES
		(
			@CountryID,
			@CountryName,
			@SubDomain,
			@Description,
			@SubDomainTour,
			@SubDomainSite,
			@SubDomainHotel,
			@SubDescriptionTour,
			@SubDescriptionSite,
			@SubDescriptionHotel,
			@SeoTitle,
			@SeoKeyword,
			@SeoDescription,
			@SeoTitleTour,
			@SeoKeywordTour,
			@SeoDescriptionTour,
			@SeoTitleSite,
			@SeoKeywordSite,
			@SeoDescriptionSite,
			@SeoTitleHotel,
			@SeoKeywordHotel,
			@SeoDescriptionHotel,
			@Lang
		)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblCountryLang] SET
			[CountryName] = @CountryName,
			[SubDomain] = @SubDomain,
			[Description] = @Description,
			[SubDomainTour] = @SubDomainTour,
			[SubDomainSite] = @SubDomainSite,
			[SubDomainHotel] = @SubDomainHotel,
			[SubDescriptionTour] = @SubDescriptionTour,
			[SubDescriptionSite] = @SubDescriptionSite,
			[SubDescriptionHotel] = @SubDescriptionHotel,
			[SeoTitle] = @SeoTitle,
			[SeoKeyword] = @SeoKeyword,
			[SeoDescription] = @SeoDescription,
			[SeoTitleTour] = @SeoTitleTour,
			[SeoKeywordTour] = @SeoKeywordTour,
			[SeoDescriptionTour] = @SeoDescriptionTour,
			[SeoTitleSite] = @SeoTitleSite,
			[SeoKeywordSite] = @SeoKeywordSite,
			[SeoDescriptionSite] = @SeoDescriptionSite,
			[SeoTitleHotel] = @SeoTitleHotel,
			[SeoKeywordHotel] = @SeoKeywordHotel,
			[SeoDescriptionHotel] = @SeoDescriptionHotel
		WHERE
			[CountryID] = @CountryID AND
			[Lang] = @Lang
	END
GO

-- Drop the 'tblCountryLang_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountryLang_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCountryLang_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCountryLang' table using the primary key value.
CREATE PROCEDURE [tblCountryLang_DeleteByPrimaryKey]
	@CountryID Int,
	@Lang nvarchar(10)
AS
	DELETE FROM [dbo].[tblCountryLang] WHERE
		[CountryID] = @CountryID AND
		[Lang] = @Lang
GO

-- Drop the 'tblCountryLang_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountryLang_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCountryLang_DeleteAll]
GO

-- Deletes all records from the 'tblCountryLang' table.
CREATE PROCEDURE [tblCountryLang_DeleteAll]
AS
	DELETE FROM [dbo].[tblCountryLang]
GO

-- Drop the 'tblCountryLang_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCountryLang_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCountryLang_DeleteAdHoc]
GO

-- Deletes records from the 'tblCountryLang' table that match the supplied where clause.
CREATE PROCEDURE [tblCountryLang_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCountryLang]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomer' table.
----------------------------------------------------------

-- Drop the 'tblCustomer_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomer_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomer_GetAll]
GO

-- Gets all records from the 'tblCustomer' table.
CREATE PROCEDURE [tblCustomer_GetAll]
AS
	SELECT [ID], [CustomerType], [Email], [FirstName], [LastName], [Gender], [NationalityID], [Address], [ZipCode], [City], [CountryID], [Telephone], [Status], [RegDate], [Lang]
	FROM [dbo].[tblCustomer]
GO

-- Drop the 'tblCustomer_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomer_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomer_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomer' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomer_GetPageAdHoc]
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
					[CustomerType] Int		,
					[Email] nvarchar(255)		,
					[FirstName] nvarchar(255)		,
					[LastName] nvarchar(255)		,
					[Gender] bit		,
					[NationalityID] Int		,
					[Address] nvarchar(500)		,
					[ZipCode] nvarchar(50)		,
					[City] nvarchar(255)		,
					[CountryID] nvarchar(255)		,
					[Telephone] nvarchar(50)		,
					[Status] Int		,
					[RegDate] datetime		,
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
			SELECT TOP ' + @total + ' [ID], [CustomerType], [Email], [FirstName], [LastName], [Gender], [NationalityID], [Address], [ZipCode], [City], [CountryID], [Telephone], [Status], [RegDate], [Lang]
		FROM [dbo].[tblCustomer]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomer]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [CustomerType], [Email], [FirstName], [LastName], [Gender], [NationalityID], [Address], [ZipCode], [City], [CountryID], [Telephone], [Status], [RegDate], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [CustomerType], [Email], [FirstName], [LastName], [Gender], [NationalityID], [Address], [ZipCode], [City], [CountryID], [Telephone], [Status], [RegDate], [Lang]
				FROM [dbo].[tblCustomer]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomer]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [CustomerType], [Email], [FirstName], [LastName], [Gender], [NationalityID], [Address], [ZipCode], [City], [CountryID], [Telephone], [Status], [RegDate], [Lang]
				FROM [dbo].[tblCustomer]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomer]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomer_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomer_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomer_GetAdHoc]
GO

-- Gets records from the 'tblCustomer' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomer_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [CustomerType], [Email], [FirstName], [LastName], [Gender], [NationalityID], [Address], [ZipCode], [City], [CountryID], [Telephone], [Status], [RegDate], [Lang]
		FROM [dbo].[tblCustomer]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomer_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomer_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomer_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomer' table using the primary key value.
CREATE PROCEDURE [tblCustomer_GetByPrimaryKey]
	@ID decimal(18,0)
AS
	SELECT [ID], [CustomerType], [Email], [FirstName], [LastName], [Gender], [NationalityID], [Address], [ZipCode], [City], [CountryID], [Telephone], [Status], [RegDate], [Lang] 
	FROM [dbo].[tblCustomer] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomer_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomer_Insert') AND type='P')
	DROP PROCEDURE [tblCustomer_Insert]
GO

-- Inserts a new record into the 'tblCustomer' table.
CREATE PROCEDURE [tblCustomer_Insert]
	@CustomerType Int,
	@Email nvarchar(255),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@Gender bit,
	@NationalityID Int,
	@Address nvarchar(500),
	@ZipCode nvarchar(50),
	@City nvarchar(255),
	@CountryID nvarchar(255),
	@Telephone nvarchar(50),
	@Status Int,
	@RegDate datetime,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblCustomer]
	(
		[CustomerType],
		[Email],
		[FirstName],
		[LastName],
		[Gender],
		[NationalityID],
		[Address],
		[ZipCode],
		[City],
		[CountryID],
		[Telephone],
		[Status],
		[RegDate],
		[Lang]
	)
	VALUES
	(
		@CustomerType,
		@Email,
		@FirstName,
		@LastName,
		@Gender,
		@NationalityID,
		@Address,
		@ZipCode,
		@City,
		@CountryID,
		@Telephone,
		@Status,
		@RegDate,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblCustomer_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomer_Update') AND type='P')
	DROP PROCEDURE [tblCustomer_Update]
GO

-- Updates a record in the 'tblCustomer' table.
CREATE PROCEDURE [tblCustomer_Update]
	-- The rest of writeable parameters
	@CustomerType Int,
	@Email nvarchar(255),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@Gender bit,
	@NationalityID Int,
	@Address nvarchar(500),
	@ZipCode nvarchar(50),
	@City nvarchar(255),
	@CountryID nvarchar(255),
	@Telephone nvarchar(50),
	@Status Int,
	@RegDate datetime,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	UPDATE [dbo].[tblCustomer] SET
		[CustomerType] = @CustomerType,
		[Email] = @Email,
		[FirstName] = @FirstName,
		[LastName] = @LastName,
		[Gender] = @Gender,
		[NationalityID] = @NationalityID,
		[Address] = @Address,
		[ZipCode] = @ZipCode,
		[City] = @City,
		[CountryID] = @CountryID,
		[Telephone] = @Telephone,
		[Status] = @Status,
		[RegDate] = @RegDate,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblCustomer_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomer_Save') AND type='P')
	DROP PROCEDURE [tblCustomer_Save]
GO

-- Insert or updates a new record in the 'tblCustomer' table.
CREATE PROCEDURE [tblCustomer_Save]
	-- The rest of writeable parameters
	@CustomerType Int,
	@Email nvarchar(255),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@Gender bit,
	@NationalityID Int,
	@Address nvarchar(500),
	@ZipCode nvarchar(50),
	@City nvarchar(255),
	@CountryID nvarchar(255),
	@Telephone nvarchar(50),
	@Status Int,
	@RegDate datetime,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblCustomer] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblCustomer]
		(
			[CustomerType],
			[Email],
			[FirstName],
			[LastName],
			[Gender],
			[NationalityID],
			[Address],
			[ZipCode],
			[City],
			[CountryID],
			[Telephone],
			[Status],
			[RegDate],
			[Lang]
		)
		VALUES
		(
			@CustomerType,
			@Email,
			@FirstName,
			@LastName,
			@Gender,
			@NationalityID,
			@Address,
			@ZipCode,
			@City,
			@CountryID,
			@Telephone,
			@Status,
			@RegDate,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblCustomer] SET
			[CustomerType] = @CustomerType,
			[Email] = @Email,
			[FirstName] = @FirstName,
			[LastName] = @LastName,
			[Gender] = @Gender,
			[NationalityID] = @NationalityID,
			[Address] = @Address,
			[ZipCode] = @ZipCode,
			[City] = @City,
			[CountryID] = @CountryID,
			[Telephone] = @Telephone,
			[Status] = @Status,
			[RegDate] = @RegDate,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblCustomer_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomer_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomer_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomer' table using the primary key value.
CREATE PROCEDURE [tblCustomer_DeleteByPrimaryKey]
	@ID decimal(18,0)
AS
	DELETE FROM [dbo].[tblCustomer] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomer_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomer_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomer_DeleteAll]
GO

-- Deletes all records from the 'tblCustomer' table.
CREATE PROCEDURE [tblCustomer_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomer]
GO

-- Drop the 'tblCustomer_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomer_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomer_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomer' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomer_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomer]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeBase' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeBase_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBase_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeBase_GetAll]
GO

-- Gets all records from the 'tblCustomizeBase' table.
CREATE PROCEDURE [tblCustomizeBase_GetAll]
AS
	SELECT [ID], [TourID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [MoreInfoRequest], [RequestDate], [Status], [Lang]
	FROM [dbo].[tblCustomizeBase]
GO

-- Drop the 'tblCustomizeBase_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBase_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBase_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeBase' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeBase_GetPageAdHoc]
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
					[TourID] Int		,
					[RequestCode] nvarchar(50)		,
					[CustomerID] decimal(18,0)		,
					[YouAre] Int		,
					[AdultNumber] Int		,
					[ChildNumber] Int		,
					[IsPlan] bit		,
					[TravelDate] datetime		,
					[MonthPlan] Int		,
					[YearPlan] Int		,
					[MoreInfoRequest] ntext		,
					[RequestDate] datetime		,
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
			SELECT TOP ' + @total + ' [ID], [TourID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [MoreInfoRequest], [RequestDate], [Status], [Lang]
		FROM [dbo].[tblCustomizeBase]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeBase]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [TourID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [MoreInfoRequest], [RequestDate], [Status], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [TourID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [MoreInfoRequest], [RequestDate], [Status], [Lang]
				FROM [dbo].[tblCustomizeBase]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeBase]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [TourID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [MoreInfoRequest], [RequestDate], [Status], [Lang]
				FROM [dbo].[tblCustomizeBase]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeBase]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeBase_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBase_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBase_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeBase' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeBase_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [TourID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [MoreInfoRequest], [RequestDate], [Status], [Lang]
		FROM [dbo].[tblCustomizeBase]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeBase_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBase_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeBase_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeBase' table using the primary key value.
CREATE PROCEDURE [tblCustomizeBase_GetByPrimaryKey]
	@ID decimal(18,0)
AS
	SELECT [ID], [TourID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [MoreInfoRequest], [RequestDate], [Status], [Lang] 
	FROM [dbo].[tblCustomizeBase] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomizeBase_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBase_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeBase_Insert]
GO

-- Inserts a new record into the 'tblCustomizeBase' table.
CREATE PROCEDURE [tblCustomizeBase_Insert]
	@TourID Int,
	@RequestCode nvarchar(50),
	@CustomerID decimal(18,0),
	@YouAre Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan bit,
	@TravelDate datetime,
	@MonthPlan Int,
	@YearPlan Int,
	@MoreInfoRequest ntext,
	@RequestDate datetime,
	@Status Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblCustomizeBase]
	(
		[TourID],
		[RequestCode],
		[CustomerID],
		[YouAre],
		[AdultNumber],
		[ChildNumber],
		[IsPlan],
		[TravelDate],
		[MonthPlan],
		[YearPlan],
		[MoreInfoRequest],
		[RequestDate],
		[Status],
		[Lang]
	)
	VALUES
	(
		@TourID,
		@RequestCode,
		@CustomerID,
		@YouAre,
		@AdultNumber,
		@ChildNumber,
		@IsPlan,
		@TravelDate,
		@MonthPlan,
		@YearPlan,
		@MoreInfoRequest,
		@RequestDate,
		@Status,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblCustomizeBase_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBase_Update') AND type='P')
	DROP PROCEDURE [tblCustomizeBase_Update]
GO

-- Updates a record in the 'tblCustomizeBase' table.
CREATE PROCEDURE [tblCustomizeBase_Update]
	-- The rest of writeable parameters
	@TourID Int,
	@RequestCode nvarchar(50),
	@CustomerID decimal(18,0),
	@YouAre Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan bit,
	@TravelDate datetime,
	@MonthPlan Int,
	@YearPlan Int,
	@MoreInfoRequest ntext,
	@RequestDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	UPDATE [dbo].[tblCustomizeBase] SET
		[TourID] = @TourID,
		[RequestCode] = @RequestCode,
		[CustomerID] = @CustomerID,
		[YouAre] = @YouAre,
		[AdultNumber] = @AdultNumber,
		[ChildNumber] = @ChildNumber,
		[IsPlan] = @IsPlan,
		[TravelDate] = @TravelDate,
		[MonthPlan] = @MonthPlan,
		[YearPlan] = @YearPlan,
		[MoreInfoRequest] = @MoreInfoRequest,
		[RequestDate] = @RequestDate,
		[Status] = @Status,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblCustomizeBase_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBase_Save') AND type='P')
	DROP PROCEDURE [tblCustomizeBase_Save]
GO

-- Insert or updates a new record in the 'tblCustomizeBase' table.
CREATE PROCEDURE [tblCustomizeBase_Save]
	-- The rest of writeable parameters
	@TourID Int,
	@RequestCode nvarchar(50),
	@CustomerID decimal(18,0),
	@YouAre Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan bit,
	@TravelDate datetime,
	@MonthPlan Int,
	@YearPlan Int,
	@MoreInfoRequest ntext,
	@RequestDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblCustomizeBase] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblCustomizeBase]
		(
			[TourID],
			[RequestCode],
			[CustomerID],
			[YouAre],
			[AdultNumber],
			[ChildNumber],
			[IsPlan],
			[TravelDate],
			[MonthPlan],
			[YearPlan],
			[MoreInfoRequest],
			[RequestDate],
			[Status],
			[Lang]
		)
		VALUES
		(
			@TourID,
			@RequestCode,
			@CustomerID,
			@YouAre,
			@AdultNumber,
			@ChildNumber,
			@IsPlan,
			@TravelDate,
			@MonthPlan,
			@YearPlan,
			@MoreInfoRequest,
			@RequestDate,
			@Status,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblCustomizeBase] SET
			[TourID] = @TourID,
			[RequestCode] = @RequestCode,
			[CustomerID] = @CustomerID,
			[YouAre] = @YouAre,
			[AdultNumber] = @AdultNumber,
			[ChildNumber] = @ChildNumber,
			[IsPlan] = @IsPlan,
			[TravelDate] = @TravelDate,
			[MonthPlan] = @MonthPlan,
			[YearPlan] = @YearPlan,
			[MoreInfoRequest] = @MoreInfoRequest,
			[RequestDate] = @RequestDate,
			[Status] = @Status,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblCustomizeBase_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBase_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeBase_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeBase' table using the primary key value.
CREATE PROCEDURE [tblCustomizeBase_DeleteByPrimaryKey]
	@ID decimal(18,0)
AS
	DELETE FROM [dbo].[tblCustomizeBase] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomizeBase_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBase_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeBase_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeBase' table.
CREATE PROCEDURE [tblCustomizeBase_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeBase]
GO

-- Drop the 'tblCustomizeBase_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBase_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBase_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeBase' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeBase_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeBase]' +	
		@where)	
GO

