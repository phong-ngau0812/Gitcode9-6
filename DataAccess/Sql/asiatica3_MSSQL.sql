
---	CuongLM Create 2008.11.14

----------------------------------------------------------
-- All rights reserved.
----------------------------------------------------------

USE [asiaticadb]
GO

----------------------------------------------------------
-- Stored procedures for the 'tblNews' table.
----------------------------------------------------------

-- Drop the 'tblNews_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNews_GetAll') AND type='P')
	DROP PROCEDURE [tblNews_GetAll]
GO

-- Gets all records from the 'tblNews' table.
CREATE PROCEDURE [tblNews_GetAll]
AS
	SELECT [ID], [CateID], [Title], [ImageFile], [BannerFile], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang]
	FROM [dbo].[tblNews]
GO

-- Drop the 'tblNews_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNews_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblNews_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblNews' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblNews_GetPageAdHoc]
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
					[CateID] Int		,
					[Title] nvarchar(255)		,
					[ImageFile] nvarchar(255)		,
					[BannerFile] nvarchar(255)		,
					[Summary] ntext		,
					[Description] ntext		,
					[RegDate] datetime		,
					[SeoTitle] nvarchar(1500)		,
					[SeoKeyword] nvarchar(1500)		,
					[SeoDescription] nvarchar(1500)		,
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
			SELECT TOP ' + @total + ' [ID], [CateID], [Title], [ImageFile], [BannerFile], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang]
		FROM [dbo].[tblNews]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblNews]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [CateID], [Title], [ImageFile], [BannerFile], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [CateID], [Title], [ImageFile], [BannerFile], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang]
				FROM [dbo].[tblNews]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblNews]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [CateID], [Title], [ImageFile], [BannerFile], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang]
				FROM [dbo].[tblNews]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblNews]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblNews_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNews_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblNews_GetAdHoc]
GO

-- Gets records from the 'tblNews' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblNews_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [CateID], [Title], [ImageFile], [BannerFile], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang]
		FROM [dbo].[tblNews]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblNews_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNews_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblNews_GetByPrimaryKey]
GO

-- Gets a record from the 'tblNews' table using the primary key value.
CREATE PROCEDURE [tblNews_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [CateID], [Title], [ImageFile], [BannerFile], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang] 
	FROM [dbo].[tblNews] WHERE
		[ID] = @ID
GO

-- Drop the 'tblNews_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNews_Insert') AND type='P')
	DROP PROCEDURE [tblNews_Insert]
GO

-- Inserts a new record into the 'tblNews' table.
CREATE PROCEDURE [tblNews_Insert]
	@CateID Int,
	@Title nvarchar(255),
	@ImageFile nvarchar(255),
	@BannerFile nvarchar(255),
	@Summary ntext,
	@Description ntext,
	@RegDate datetime,
	@SeoTitle nvarchar(1500),
	@SeoKeyword nvarchar(1500),
	@SeoDescription nvarchar(1500),
	@Status Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblNews]
	(
		[CateID],
		[Title],
		[ImageFile],
		[BannerFile],
		[Summary],
		[Description],
		[RegDate],
		[SeoTitle],
		[SeoKeyword],
		[SeoDescription],
		[Status],
		[Lang]
	)
	VALUES
	(
		@CateID,
		@Title,
		@ImageFile,
		@BannerFile,
		@Summary,
		@Description,
		@RegDate,
		@SeoTitle,
		@SeoKeyword,
		@SeoDescription,
		@Status,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblNews_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNews_Update') AND type='P')
	DROP PROCEDURE [tblNews_Update]
GO

-- Updates a record in the 'tblNews' table.
CREATE PROCEDURE [tblNews_Update]
	-- The rest of writeable parameters
	@CateID Int,
	@Title nvarchar(255),
	@ImageFile nvarchar(255),
	@BannerFile nvarchar(255),
	@Summary ntext,
	@Description ntext,
	@RegDate datetime,
	@SeoTitle nvarchar(1500),
	@SeoKeyword nvarchar(1500),
	@SeoDescription nvarchar(1500),
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblNews] SET
		[CateID] = @CateID,
		[Title] = @Title,
		[ImageFile] = @ImageFile,
		[BannerFile] = @BannerFile,
		[Summary] = @Summary,
		[Description] = @Description,
		[RegDate] = @RegDate,
		[SeoTitle] = @SeoTitle,
		[SeoKeyword] = @SeoKeyword,
		[SeoDescription] = @SeoDescription,
		[Status] = @Status,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblNews_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNews_Save') AND type='P')
	DROP PROCEDURE [tblNews_Save]
GO

-- Insert or updates a new record in the 'tblNews' table.
CREATE PROCEDURE [tblNews_Save]
	-- The rest of writeable parameters
	@CateID Int,
	@Title nvarchar(255),
	@ImageFile nvarchar(255),
	@BannerFile nvarchar(255),
	@Summary ntext,
	@Description ntext,
	@RegDate datetime,
	@SeoTitle nvarchar(1500),
	@SeoKeyword nvarchar(1500),
	@SeoDescription nvarchar(1500),
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblNews] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblNews]
		(
			[CateID],
			[Title],
			[ImageFile],
			[BannerFile],
			[Summary],
			[Description],
			[RegDate],
			[SeoTitle],
			[SeoKeyword],
			[SeoDescription],
			[Status],
			[Lang]
		)
		VALUES
		(
			@CateID,
			@Title,
			@ImageFile,
			@BannerFile,
			@Summary,
			@Description,
			@RegDate,
			@SeoTitle,
			@SeoKeyword,
			@SeoDescription,
			@Status,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblNews] SET
			[CateID] = @CateID,
			[Title] = @Title,
			[ImageFile] = @ImageFile,
			[BannerFile] = @BannerFile,
			[Summary] = @Summary,
			[Description] = @Description,
			[RegDate] = @RegDate,
			[SeoTitle] = @SeoTitle,
			[SeoKeyword] = @SeoKeyword,
			[SeoDescription] = @SeoDescription,
			[Status] = @Status,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblNews_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNews_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblNews_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblNews' table using the primary key value.
CREATE PROCEDURE [tblNews_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblNews] WHERE
		[ID] = @ID
GO

-- Drop the 'tblNews_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNews_DeleteAll') AND type='P')
	DROP PROCEDURE [tblNews_DeleteAll]
GO

-- Deletes all records from the 'tblNews' table.
CREATE PROCEDURE [tblNews_DeleteAll]
AS
	DELETE FROM [dbo].[tblNews]
GO

-- Drop the 'tblNews_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblNews_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblNews_DeleteAdHoc]
GO

-- Deletes records from the 'tblNews' table that match the supplied where clause.
CREATE PROCEDURE [tblNews_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblNews]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblPaxToPax' table.
----------------------------------------------------------

-- Drop the 'tblPaxToPax_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToPax_GetAll') AND type='P')
	DROP PROCEDURE [tblPaxToPax_GetAll]
GO

-- Gets all records from the 'tblPaxToPax' table.
CREATE PROCEDURE [tblPaxToPax_GetAll]
AS
	SELECT [ID], [Gender], [FirstName], [LastName], [EmailFrom], [EmailTo], [Subject], [Request], [PostedDate], [Status], [Lang]
	FROM [dbo].[tblPaxToPax]
GO

-- Drop the 'tblPaxToPax_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToPax_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblPaxToPax_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblPaxToPax' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblPaxToPax_GetPageAdHoc]
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
					[EmailFrom] nvarchar(255)		,
					[EmailTo] nvarchar(255)		,
					[Subject] nvarchar(255)		,
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
			SELECT TOP ' + @total + ' [ID], [Gender], [FirstName], [LastName], [EmailFrom], [EmailTo], [Subject], [Request], [PostedDate], [Status], [Lang]
		FROM [dbo].[tblPaxToPax]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblPaxToPax]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [Gender], [FirstName], [LastName], [EmailFrom], [EmailTo], [Subject], [Request], [PostedDate], [Status], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [Gender], [FirstName], [LastName], [EmailFrom], [EmailTo], [Subject], [Request], [PostedDate], [Status], [Lang]
				FROM [dbo].[tblPaxToPax]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblPaxToPax]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [Gender], [FirstName], [LastName], [EmailFrom], [EmailTo], [Subject], [Request], [PostedDate], [Status], [Lang]
				FROM [dbo].[tblPaxToPax]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblPaxToPax]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblPaxToPax_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToPax_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblPaxToPax_GetAdHoc]
GO

-- Gets records from the 'tblPaxToPax' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblPaxToPax_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [Gender], [FirstName], [LastName], [EmailFrom], [EmailTo], [Subject], [Request], [PostedDate], [Status], [Lang]
		FROM [dbo].[tblPaxToPax]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblPaxToPax_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToPax_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblPaxToPax_GetByPrimaryKey]
GO

-- Gets a record from the 'tblPaxToPax' table using the primary key value.
CREATE PROCEDURE [tblPaxToPax_GetByPrimaryKey]
	@ID decimal(18,0)
AS
	SELECT [ID], [Gender], [FirstName], [LastName], [EmailFrom], [EmailTo], [Subject], [Request], [PostedDate], [Status], [Lang] 
	FROM [dbo].[tblPaxToPax] WHERE
		[ID] = @ID
GO

-- Drop the 'tblPaxToPax_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToPax_Insert') AND type='P')
	DROP PROCEDURE [tblPaxToPax_Insert]
GO

-- Inserts a new record into the 'tblPaxToPax' table.
CREATE PROCEDURE [tblPaxToPax_Insert]
	@Gender nvarchar(50),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@EmailFrom nvarchar(255),
	@EmailTo nvarchar(255),
	@Subject nvarchar(255),
	@Request nvarchar(2000),
	@PostedDate datetime,
	@Status Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblPaxToPax]
	(
		[Gender],
		[FirstName],
		[LastName],
		[EmailFrom],
		[EmailTo],
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
		@EmailFrom,
		@EmailTo,
		@Subject,
		@Request,
		@PostedDate,
		@Status,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblPaxToPax_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToPax_Update') AND type='P')
	DROP PROCEDURE [tblPaxToPax_Update]
GO

-- Updates a record in the 'tblPaxToPax' table.
CREATE PROCEDURE [tblPaxToPax_Update]
	-- The rest of writeable parameters
	@Gender nvarchar(50),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@EmailFrom nvarchar(255),
	@EmailTo nvarchar(255),
	@Subject nvarchar(255),
	@Request nvarchar(2000),
	@PostedDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	UPDATE [dbo].[tblPaxToPax] SET
		[Gender] = @Gender,
		[FirstName] = @FirstName,
		[LastName] = @LastName,
		[EmailFrom] = @EmailFrom,
		[EmailTo] = @EmailTo,
		[Subject] = @Subject,
		[Request] = @Request,
		[PostedDate] = @PostedDate,
		[Status] = @Status,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblPaxToPax_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToPax_Save') AND type='P')
	DROP PROCEDURE [tblPaxToPax_Save]
GO

-- Insert or updates a new record in the 'tblPaxToPax' table.
CREATE PROCEDURE [tblPaxToPax_Save]
	-- The rest of writeable parameters
	@Gender nvarchar(50),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@EmailFrom nvarchar(255),
	@EmailTo nvarchar(255),
	@Subject nvarchar(255),
	@Request nvarchar(2000),
	@PostedDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblPaxToPax] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblPaxToPax]
		(
			[Gender],
			[FirstName],
			[LastName],
			[EmailFrom],
			[EmailTo],
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
			@EmailFrom,
			@EmailTo,
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
		UPDATE [dbo].[tblPaxToPax] SET
			[Gender] = @Gender,
			[FirstName] = @FirstName,
			[LastName] = @LastName,
			[EmailFrom] = @EmailFrom,
			[EmailTo] = @EmailTo,
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

-- Drop the 'tblPaxToPax_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToPax_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblPaxToPax_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblPaxToPax' table using the primary key value.
CREATE PROCEDURE [tblPaxToPax_DeleteByPrimaryKey]
	@ID decimal(18,0)
AS
	DELETE FROM [dbo].[tblPaxToPax] WHERE
		[ID] = @ID
GO

-- Drop the 'tblPaxToPax_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToPax_DeleteAll') AND type='P')
	DROP PROCEDURE [tblPaxToPax_DeleteAll]
GO

-- Deletes all records from the 'tblPaxToPax' table.
CREATE PROCEDURE [tblPaxToPax_DeleteAll]
AS
	DELETE FROM [dbo].[tblPaxToPax]
GO

-- Drop the 'tblPaxToPax_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToPax_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblPaxToPax_DeleteAdHoc]
GO

-- Deletes records from the 'tblPaxToPax' table that match the supplied where clause.
CREATE PROCEDURE [tblPaxToPax_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblPaxToPax]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblPaxToSales' table.
----------------------------------------------------------

-- Drop the 'tblPaxToSales_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToSales_GetAll') AND type='P')
	DROP PROCEDURE [tblPaxToSales_GetAll]
GO

-- Gets all records from the 'tblPaxToSales' table.
CREATE PROCEDURE [tblPaxToSales_GetAll]
AS
	SELECT [ID], [Gender], [FirstName], [LastName], [EmailPax], [EmailSales], [Subject], [Request], [PostedDate], [Status], [Lang]
	FROM [dbo].[tblPaxToSales]
GO

-- Drop the 'tblPaxToSales_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToSales_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblPaxToSales_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblPaxToSales' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblPaxToSales_GetPageAdHoc]
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
					[EmailPax] nvarchar(255)		,
					[EmailSales] nvarchar(255)		,
					[Subject] nvarchar(255)		,
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
			SELECT TOP ' + @total + ' [ID], [Gender], [FirstName], [LastName], [EmailPax], [EmailSales], [Subject], [Request], [PostedDate], [Status], [Lang]
		FROM [dbo].[tblPaxToSales]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblPaxToSales]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [Gender], [FirstName], [LastName], [EmailPax], [EmailSales], [Subject], [Request], [PostedDate], [Status], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [Gender], [FirstName], [LastName], [EmailPax], [EmailSales], [Subject], [Request], [PostedDate], [Status], [Lang]
				FROM [dbo].[tblPaxToSales]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblPaxToSales]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [Gender], [FirstName], [LastName], [EmailPax], [EmailSales], [Subject], [Request], [PostedDate], [Status], [Lang]
				FROM [dbo].[tblPaxToSales]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblPaxToSales]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblPaxToSales_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToSales_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblPaxToSales_GetAdHoc]
GO

-- Gets records from the 'tblPaxToSales' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblPaxToSales_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [Gender], [FirstName], [LastName], [EmailPax], [EmailSales], [Subject], [Request], [PostedDate], [Status], [Lang]
		FROM [dbo].[tblPaxToSales]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblPaxToSales_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToSales_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblPaxToSales_GetByPrimaryKey]
GO

-- Gets a record from the 'tblPaxToSales' table using the primary key value.
CREATE PROCEDURE [tblPaxToSales_GetByPrimaryKey]
	@ID decimal(18,0)
AS
	SELECT [ID], [Gender], [FirstName], [LastName], [EmailPax], [EmailSales], [Subject], [Request], [PostedDate], [Status], [Lang] 
	FROM [dbo].[tblPaxToSales] WHERE
		[ID] = @ID
GO

-- Drop the 'tblPaxToSales_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToSales_Insert') AND type='P')
	DROP PROCEDURE [tblPaxToSales_Insert]
GO

-- Inserts a new record into the 'tblPaxToSales' table.
CREATE PROCEDURE [tblPaxToSales_Insert]
	@Gender nvarchar(50),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@EmailPax nvarchar(255),
	@EmailSales nvarchar(255),
	@Subject nvarchar(255),
	@Request nvarchar(2000),
	@PostedDate datetime,
	@Status Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblPaxToSales]
	(
		[Gender],
		[FirstName],
		[LastName],
		[EmailPax],
		[EmailSales],
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
		@EmailPax,
		@EmailSales,
		@Subject,
		@Request,
		@PostedDate,
		@Status,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblPaxToSales_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToSales_Update') AND type='P')
	DROP PROCEDURE [tblPaxToSales_Update]
GO

-- Updates a record in the 'tblPaxToSales' table.
CREATE PROCEDURE [tblPaxToSales_Update]
	-- The rest of writeable parameters
	@Gender nvarchar(50),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@EmailPax nvarchar(255),
	@EmailSales nvarchar(255),
	@Subject nvarchar(255),
	@Request nvarchar(2000),
	@PostedDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	UPDATE [dbo].[tblPaxToSales] SET
		[Gender] = @Gender,
		[FirstName] = @FirstName,
		[LastName] = @LastName,
		[EmailPax] = @EmailPax,
		[EmailSales] = @EmailSales,
		[Subject] = @Subject,
		[Request] = @Request,
		[PostedDate] = @PostedDate,
		[Status] = @Status,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblPaxToSales_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToSales_Save') AND type='P')
	DROP PROCEDURE [tblPaxToSales_Save]
GO

-- Insert or updates a new record in the 'tblPaxToSales' table.
CREATE PROCEDURE [tblPaxToSales_Save]
	-- The rest of writeable parameters
	@Gender nvarchar(50),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@EmailPax nvarchar(255),
	@EmailSales nvarchar(255),
	@Subject nvarchar(255),
	@Request nvarchar(2000),
	@PostedDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblPaxToSales] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblPaxToSales]
		(
			[Gender],
			[FirstName],
			[LastName],
			[EmailPax],
			[EmailSales],
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
			@EmailPax,
			@EmailSales,
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
		UPDATE [dbo].[tblPaxToSales] SET
			[Gender] = @Gender,
			[FirstName] = @FirstName,
			[LastName] = @LastName,
			[EmailPax] = @EmailPax,
			[EmailSales] = @EmailSales,
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

-- Drop the 'tblPaxToSales_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToSales_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblPaxToSales_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblPaxToSales' table using the primary key value.
CREATE PROCEDURE [tblPaxToSales_DeleteByPrimaryKey]
	@ID decimal(18,0)
AS
	DELETE FROM [dbo].[tblPaxToSales] WHERE
		[ID] = @ID
GO

-- Drop the 'tblPaxToSales_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToSales_DeleteAll') AND type='P')
	DROP PROCEDURE [tblPaxToSales_DeleteAll]
GO

-- Deletes all records from the 'tblPaxToSales' table.
CREATE PROCEDURE [tblPaxToSales_DeleteAll]
AS
	DELETE FROM [dbo].[tblPaxToSales]
GO

-- Drop the 'tblPaxToSales_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPaxToSales_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblPaxToSales_DeleteAdHoc]
GO

-- Deletes records from the 'tblPaxToSales' table that match the supplied where clause.
CREATE PROCEDURE [tblPaxToSales_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblPaxToSales]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblPromotion' table.
----------------------------------------------------------

-- Drop the 'tblPromotion_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPromotion_GetAll') AND type='P')
	DROP PROCEDURE [tblPromotion_GetAll]
GO

-- Gets all records from the 'tblPromotion' table.
CREATE PROCEDURE [tblPromotion_GetAll]
AS
	SELECT [ID], [Title], [ImageFile], [BannerFile], [StartDate], [EndDate], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang]
	FROM [dbo].[tblPromotion]
GO

-- Drop the 'tblPromotion_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPromotion_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblPromotion_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblPromotion' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblPromotion_GetPageAdHoc]
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
					[ImageFile] nvarchar(255)		,
					[BannerFile] nvarchar(255)		,
					[StartDate] datetime		,
					[EndDate] datetime		,
					[Summary] ntext		,
					[Description] ntext		,
					[RegDate] datetime		,
					[SeoTitle] nvarchar(1500)		,
					[SeoKeyword] nvarchar(1500)		,
					[SeoDescription] nvarchar(1500)		,
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
			SELECT TOP ' + @total + ' [ID], [Title], [ImageFile], [BannerFile], [StartDate], [EndDate], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang]
		FROM [dbo].[tblPromotion]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblPromotion]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [Title], [ImageFile], [BannerFile], [StartDate], [EndDate], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [Title], [ImageFile], [BannerFile], [StartDate], [EndDate], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang]
				FROM [dbo].[tblPromotion]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblPromotion]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [Title], [ImageFile], [BannerFile], [StartDate], [EndDate], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang]
				FROM [dbo].[tblPromotion]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblPromotion]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblPromotion_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPromotion_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblPromotion_GetAdHoc]
GO

-- Gets records from the 'tblPromotion' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblPromotion_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [Title], [ImageFile], [BannerFile], [StartDate], [EndDate], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang]
		FROM [dbo].[tblPromotion]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblPromotion_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPromotion_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblPromotion_GetByPrimaryKey]
GO

-- Gets a record from the 'tblPromotion' table using the primary key value.
CREATE PROCEDURE [tblPromotion_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [Title], [ImageFile], [BannerFile], [StartDate], [EndDate], [Summary], [Description], [RegDate], [SeoTitle], [SeoKeyword], [SeoDescription], [Status], [Lang] 
	FROM [dbo].[tblPromotion] WHERE
		[ID] = @ID
GO

-- Drop the 'tblPromotion_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPromotion_Insert') AND type='P')
	DROP PROCEDURE [tblPromotion_Insert]
GO

-- Inserts a new record into the 'tblPromotion' table.
CREATE PROCEDURE [tblPromotion_Insert]
	@Title nvarchar(255),
	@ImageFile nvarchar(255),
	@BannerFile nvarchar(255),
	@StartDate datetime,
	@EndDate datetime,
	@Summary ntext,
	@Description ntext,
	@RegDate datetime,
	@SeoTitle nvarchar(1500),
	@SeoKeyword nvarchar(1500),
	@SeoDescription nvarchar(1500),
	@Status Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblPromotion]
	(
		[Title],
		[ImageFile],
		[BannerFile],
		[StartDate],
		[EndDate],
		[Summary],
		[Description],
		[RegDate],
		[SeoTitle],
		[SeoKeyword],
		[SeoDescription],
		[Status],
		[Lang]
	)
	VALUES
	(
		@Title,
		@ImageFile,
		@BannerFile,
		@StartDate,
		@EndDate,
		@Summary,
		@Description,
		@RegDate,
		@SeoTitle,
		@SeoKeyword,
		@SeoDescription,
		@Status,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblPromotion_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPromotion_Update') AND type='P')
	DROP PROCEDURE [tblPromotion_Update]
GO

-- Updates a record in the 'tblPromotion' table.
CREATE PROCEDURE [tblPromotion_Update]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	@ImageFile nvarchar(255),
	@BannerFile nvarchar(255),
	@StartDate datetime,
	@EndDate datetime,
	@Summary ntext,
	@Description ntext,
	@RegDate datetime,
	@SeoTitle nvarchar(1500),
	@SeoKeyword nvarchar(1500),
	@SeoDescription nvarchar(1500),
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblPromotion] SET
		[Title] = @Title,
		[ImageFile] = @ImageFile,
		[BannerFile] = @BannerFile,
		[StartDate] = @StartDate,
		[EndDate] = @EndDate,
		[Summary] = @Summary,
		[Description] = @Description,
		[RegDate] = @RegDate,
		[SeoTitle] = @SeoTitle,
		[SeoKeyword] = @SeoKeyword,
		[SeoDescription] = @SeoDescription,
		[Status] = @Status,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblPromotion_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPromotion_Save') AND type='P')
	DROP PROCEDURE [tblPromotion_Save]
GO

-- Insert or updates a new record in the 'tblPromotion' table.
CREATE PROCEDURE [tblPromotion_Save]
	-- The rest of writeable parameters
	@Title nvarchar(255),
	@ImageFile nvarchar(255),
	@BannerFile nvarchar(255),
	@StartDate datetime,
	@EndDate datetime,
	@Summary ntext,
	@Description ntext,
	@RegDate datetime,
	@SeoTitle nvarchar(1500),
	@SeoKeyword nvarchar(1500),
	@SeoDescription nvarchar(1500),
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblPromotion] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblPromotion]
		(
			[Title],
			[ImageFile],
			[BannerFile],
			[StartDate],
			[EndDate],
			[Summary],
			[Description],
			[RegDate],
			[SeoTitle],
			[SeoKeyword],
			[SeoDescription],
			[Status],
			[Lang]
		)
		VALUES
		(
			@Title,
			@ImageFile,
			@BannerFile,
			@StartDate,
			@EndDate,
			@Summary,
			@Description,
			@RegDate,
			@SeoTitle,
			@SeoKeyword,
			@SeoDescription,
			@Status,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblPromotion] SET
			[Title] = @Title,
			[ImageFile] = @ImageFile,
			[BannerFile] = @BannerFile,
			[StartDate] = @StartDate,
			[EndDate] = @EndDate,
			[Summary] = @Summary,
			[Description] = @Description,
			[RegDate] = @RegDate,
			[SeoTitle] = @SeoTitle,
			[SeoKeyword] = @SeoKeyword,
			[SeoDescription] = @SeoDescription,
			[Status] = @Status,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblPromotion_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPromotion_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblPromotion_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblPromotion' table using the primary key value.
CREATE PROCEDURE [tblPromotion_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblPromotion] WHERE
		[ID] = @ID
GO

-- Drop the 'tblPromotion_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPromotion_DeleteAll') AND type='P')
	DROP PROCEDURE [tblPromotion_DeleteAll]
GO

-- Deletes all records from the 'tblPromotion' table.
CREATE PROCEDURE [tblPromotion_DeleteAll]
AS
	DELETE FROM [dbo].[tblPromotion]
GO

-- Drop the 'tblPromotion_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblPromotion_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblPromotion_DeleteAdHoc]
GO

-- Deletes records from the 'tblPromotion' table that match the supplied where clause.
CREATE PROCEDURE [tblPromotion_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblPromotion]' +	
		@where)	
GO

