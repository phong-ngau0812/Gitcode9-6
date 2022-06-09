
---	CuongLM Create 2008.11.14

----------------------------------------------------------
-- All rights reserved.
----------------------------------------------------------

USE [asiaticadb]
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeBaseAgeAdult' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeBaseAgeAdult_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeAdult_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeAdult_GetAll]
GO

-- Gets all records from the 'tblCustomizeBaseAgeAdult' table.
CREATE PROCEDURE [tblCustomizeBaseAgeAdult_GetAll]
AS
	SELECT [CustomizeBaseID], [AgeAdultID]
	FROM [dbo].[tblCustomizeBaseAgeAdult]
GO

-- Drop the 'tblCustomizeBaseAgeAdult_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeAdult_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeAdult_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeBaseAgeAdult' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeBaseAgeAdult_GetPageAdHoc]
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
						[CustomizeBaseID] decimal(18,0)		,
					[AgeAdultID] Int		
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
			SELECT TOP ' + @total + ' [CustomizeBaseID], [AgeAdultID]
		FROM [dbo].[tblCustomizeBaseAgeAdult]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeBaseAgeAdult]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[CustomizeBaseID], [AgeAdultID] 
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
			EXECUTE('SELECT TOP ' + @length + ' [CustomizeBaseID], [AgeAdultID]
				FROM [dbo].[tblCustomizeBaseAgeAdult]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeBaseAgeAdult]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [CustomizeBaseID], [AgeAdultID]
				FROM [dbo].[tblCustomizeBaseAgeAdult]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeBaseAgeAdult]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeBaseAgeAdult_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeAdult_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeAdult_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeBaseAgeAdult' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeBaseAgeAdult_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [CustomizeBaseID], [AgeAdultID]
		FROM [dbo].[tblCustomizeBaseAgeAdult]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeBaseAgeAdult_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeAdult_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeAdult_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeBaseAgeAdult' table using the primary key value.
CREATE PROCEDURE [tblCustomizeBaseAgeAdult_GetByPrimaryKey]
	@CustomizeBaseID decimal(18,0),
	@AgeAdultID Int
AS
	SELECT [CustomizeBaseID], [AgeAdultID] 
	FROM [dbo].[tblCustomizeBaseAgeAdult] WHERE
		[CustomizeBaseID] = @CustomizeBaseID AND
		[AgeAdultID] = @AgeAdultID
GO

-- Drop the 'tblCustomizeBaseAgeAdult_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeAdult_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeAdult_Insert]
GO

-- Inserts a new record into the 'tblCustomizeBaseAgeAdult' table.
CREATE PROCEDURE [tblCustomizeBaseAgeAdult_Insert]
	@CustomizeBaseID decimal(18,0),
	@AgeAdultID Int
AS
	INSERT INTO [dbo].[tblCustomizeBaseAgeAdult]
	(
		[CustomizeBaseID],
		[AgeAdultID]
	)
	VALUES
	(
		@CustomizeBaseID,
		@AgeAdultID
	)
GO

-- Drop the 'tblCustomizeBaseAgeAdult_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeAdult_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeAdult_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeBaseAgeAdult' table using the primary key value.
CREATE PROCEDURE [tblCustomizeBaseAgeAdult_DeleteByPrimaryKey]
	@CustomizeBaseID decimal(18,0),
	@AgeAdultID Int
AS
	DELETE FROM [dbo].[tblCustomizeBaseAgeAdult] WHERE
		[CustomizeBaseID] = @CustomizeBaseID AND
		[AgeAdultID] = @AgeAdultID
GO

-- Drop the 'tblCustomizeBaseAgeAdult_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeAdult_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeAdult_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeBaseAgeAdult' table.
CREATE PROCEDURE [tblCustomizeBaseAgeAdult_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeBaseAgeAdult]
GO

-- Drop the 'tblCustomizeBaseAgeAdult_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeAdult_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeAdult_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeBaseAgeAdult' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeBaseAgeAdult_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeBaseAgeAdult]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeBaseAgeChild' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeBaseAgeChild_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeChild_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeChild_GetAll]
GO

-- Gets all records from the 'tblCustomizeBaseAgeChild' table.
CREATE PROCEDURE [tblCustomizeBaseAgeChild_GetAll]
AS
	SELECT [CustomizeBaseID], [AgeChildID]
	FROM [dbo].[tblCustomizeBaseAgeChild]
GO

-- Drop the 'tblCustomizeBaseAgeChild_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeChild_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeChild_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeBaseAgeChild' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeBaseAgeChild_GetPageAdHoc]
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
						[CustomizeBaseID] decimal(18,0)		,
					[AgeChildID] Int		
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
			SELECT TOP ' + @total + ' [CustomizeBaseID], [AgeChildID]
		FROM [dbo].[tblCustomizeBaseAgeChild]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeBaseAgeChild]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[CustomizeBaseID], [AgeChildID] 
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
			EXECUTE('SELECT TOP ' + @length + ' [CustomizeBaseID], [AgeChildID]
				FROM [dbo].[tblCustomizeBaseAgeChild]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeBaseAgeChild]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [CustomizeBaseID], [AgeChildID]
				FROM [dbo].[tblCustomizeBaseAgeChild]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeBaseAgeChild]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeBaseAgeChild_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeChild_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeChild_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeBaseAgeChild' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeBaseAgeChild_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [CustomizeBaseID], [AgeChildID]
		FROM [dbo].[tblCustomizeBaseAgeChild]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeBaseAgeChild_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeChild_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeChild_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeBaseAgeChild' table using the primary key value.
CREATE PROCEDURE [tblCustomizeBaseAgeChild_GetByPrimaryKey]
	@CustomizeBaseID decimal(18,0),
	@AgeChildID Int
AS
	SELECT [CustomizeBaseID], [AgeChildID] 
	FROM [dbo].[tblCustomizeBaseAgeChild] WHERE
		[CustomizeBaseID] = @CustomizeBaseID AND
		[AgeChildID] = @AgeChildID
GO

-- Drop the 'tblCustomizeBaseAgeChild_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeChild_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeChild_Insert]
GO

-- Inserts a new record into the 'tblCustomizeBaseAgeChild' table.
CREATE PROCEDURE [tblCustomizeBaseAgeChild_Insert]
	@CustomizeBaseID decimal(18,0),
	@AgeChildID Int
AS
	INSERT INTO [dbo].[tblCustomizeBaseAgeChild]
	(
		[CustomizeBaseID],
		[AgeChildID]
	)
	VALUES
	(
		@CustomizeBaseID,
		@AgeChildID
	)
GO

-- Drop the 'tblCustomizeBaseAgeChild_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeChild_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeChild_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeBaseAgeChild' table using the primary key value.
CREATE PROCEDURE [tblCustomizeBaseAgeChild_DeleteByPrimaryKey]
	@CustomizeBaseID decimal(18,0),
	@AgeChildID Int
AS
	DELETE FROM [dbo].[tblCustomizeBaseAgeChild] WHERE
		[CustomizeBaseID] = @CustomizeBaseID AND
		[AgeChildID] = @AgeChildID
GO

-- Drop the 'tblCustomizeBaseAgeChild_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeChild_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeChild_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeBaseAgeChild' table.
CREATE PROCEDURE [tblCustomizeBaseAgeChild_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeBaseAgeChild]
GO

-- Drop the 'tblCustomizeBaseAgeChild_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseAgeChild_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseAgeChild_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeBaseAgeChild' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeBaseAgeChild_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeBaseAgeChild]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeBaseTourPrograme' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeBaseTourPrograme_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseTourPrograme_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseTourPrograme_GetAll]
GO

-- Gets all records from the 'tblCustomizeBaseTourPrograme' table.
CREATE PROCEDURE [tblCustomizeBaseTourPrograme_GetAll]
AS
	SELECT [ID], [CustomizeBaseID], [DayNumber], [Title], [Request]
	FROM [dbo].[tblCustomizeBaseTourPrograme]
GO

-- Drop the 'tblCustomizeBaseTourPrograme_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseTourPrograme_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseTourPrograme_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeBaseTourPrograme' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeBaseTourPrograme_GetPageAdHoc]
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
					[CustomizeBaseID] decimal(18,0)		,
					[DayNumber] Int		,
					[Title] nvarchar(500)		,
					[Request] nvarchar(2000)		
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
			SELECT TOP ' + @total + ' [ID], [CustomizeBaseID], [DayNumber], [Title], [Request]
		FROM [dbo].[tblCustomizeBaseTourPrograme]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeBaseTourPrograme]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [CustomizeBaseID], [DayNumber], [Title], [Request] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [CustomizeBaseID], [DayNumber], [Title], [Request]
				FROM [dbo].[tblCustomizeBaseTourPrograme]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeBaseTourPrograme]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [CustomizeBaseID], [DayNumber], [Title], [Request]
				FROM [dbo].[tblCustomizeBaseTourPrograme]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeBaseTourPrograme]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeBaseTourPrograme_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseTourPrograme_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseTourPrograme_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeBaseTourPrograme' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeBaseTourPrograme_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [CustomizeBaseID], [DayNumber], [Title], [Request]
		FROM [dbo].[tblCustomizeBaseTourPrograme]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeBaseTourPrograme_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseTourPrograme_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseTourPrograme_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeBaseTourPrograme' table using the primary key value.
CREATE PROCEDURE [tblCustomizeBaseTourPrograme_GetByPrimaryKey]
	@ID decimal(18,0)
AS
	SELECT [ID], [CustomizeBaseID], [DayNumber], [Title], [Request] 
	FROM [dbo].[tblCustomizeBaseTourPrograme] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomizeBaseTourPrograme_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseTourPrograme_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseTourPrograme_Insert]
GO

-- Inserts a new record into the 'tblCustomizeBaseTourPrograme' table.
CREATE PROCEDURE [tblCustomizeBaseTourPrograme_Insert]
	@CustomizeBaseID decimal(18,0),
	@DayNumber Int,
	@Title nvarchar(500),
	@Request nvarchar(2000)
AS
	INSERT INTO [dbo].[tblCustomizeBaseTourPrograme]
	(
		[CustomizeBaseID],
		[DayNumber],
		[Title],
		[Request]
	)
	VALUES
	(
		@CustomizeBaseID,
		@DayNumber,
		@Title,
		@Request
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblCustomizeBaseTourPrograme_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseTourPrograme_Update') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseTourPrograme_Update]
GO

-- Updates a record in the 'tblCustomizeBaseTourPrograme' table.
CREATE PROCEDURE [tblCustomizeBaseTourPrograme_Update]
	-- The rest of writeable parameters
	@CustomizeBaseID decimal(18,0),
	@DayNumber Int,
	@Title nvarchar(500),
	@Request nvarchar(2000),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	UPDATE [dbo].[tblCustomizeBaseTourPrograme] SET
		[CustomizeBaseID] = @CustomizeBaseID,
		[DayNumber] = @DayNumber,
		[Title] = @Title,
		[Request] = @Request
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblCustomizeBaseTourPrograme_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseTourPrograme_Save') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseTourPrograme_Save]
GO

-- Insert or updates a new record in the 'tblCustomizeBaseTourPrograme' table.
CREATE PROCEDURE [tblCustomizeBaseTourPrograme_Save]
	-- The rest of writeable parameters
	@CustomizeBaseID decimal(18,0),
	@DayNumber Int,
	@Title nvarchar(500),
	@Request nvarchar(2000),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblCustomizeBaseTourPrograme] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblCustomizeBaseTourPrograme]
		(
			[CustomizeBaseID],
			[DayNumber],
			[Title],
			[Request]
		)
		VALUES
		(
			@CustomizeBaseID,
			@DayNumber,
			@Title,
			@Request
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblCustomizeBaseTourPrograme] SET
			[CustomizeBaseID] = @CustomizeBaseID,
			[DayNumber] = @DayNumber,
			[Title] = @Title,
			[Request] = @Request
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblCustomizeBaseTourPrograme_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseTourPrograme_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseTourPrograme_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeBaseTourPrograme' table using the primary key value.
CREATE PROCEDURE [tblCustomizeBaseTourPrograme_DeleteByPrimaryKey]
	@ID decimal(18,0)
AS
	DELETE FROM [dbo].[tblCustomizeBaseTourPrograme] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomizeBaseTourPrograme_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseTourPrograme_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseTourPrograme_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeBaseTourPrograme' table.
CREATE PROCEDURE [tblCustomizeBaseTourPrograme_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeBaseTourPrograme]
GO

-- Drop the 'tblCustomizeBaseTourPrograme_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeBaseTourPrograme_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeBaseTourPrograme_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeBaseTourPrograme' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeBaseTourPrograme_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeBaseTourPrograme]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeRequest' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeRequest_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequest_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeRequest_GetAll]
GO

-- Gets all records from the 'tblCustomizeRequest' table.
CREATE PROCEDURE [tblCustomizeRequest_GetAll]
AS
	SELECT [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [RequestForDestination], [TypeOfTransport], [TypeOfTrip], [TypeOfSport], [LikeNight], [LikeFinish], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang]
	FROM [dbo].[tblCustomizeRequest]
GO

-- Drop the 'tblCustomizeRequest_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequest_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequest_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeRequest' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeRequest_GetPageAdHoc]
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
					[RequestCode] nvarchar(50)		,
					[CustomerID] decimal(18,0)		,
					[YouAre] Int		,
					[AdultNumber] Int		,
					[ChildNumber] Int		,
					[IsPlan] bit		,
					[TravelDate] datetime		,
					[MonthPlan] Int		,
					[YearPlan] Int		,
					[DayNumber] Int		,
					[BudgetForPerson] money		,
					[RequestForDestination] ntext		,
					[TypeOfTransport] nvarchar(50)		,
					[TypeOfTrip] nvarchar(50)		,
					[TypeOfSport] nvarchar(50)		,
					[LikeNight] bit		,
					[LikeFinish] bit		,
					[TypeOfHotel] nvarchar(50)		,
					[TypeOfMean] nvarchar(255)		,
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
			SELECT TOP ' + @total + ' [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [RequestForDestination], [TypeOfTransport], [TypeOfTrip], [TypeOfSport], [LikeNight], [LikeFinish], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang]
		FROM [dbo].[tblCustomizeRequest]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeRequest]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [RequestForDestination], [TypeOfTransport], [TypeOfTrip], [TypeOfSport], [LikeNight], [LikeFinish], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [RequestForDestination], [TypeOfTransport], [TypeOfTrip], [TypeOfSport], [LikeNight], [LikeFinish], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang]
				FROM [dbo].[tblCustomizeRequest]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeRequest]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [RequestForDestination], [TypeOfTransport], [TypeOfTrip], [TypeOfSport], [LikeNight], [LikeFinish], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang]
				FROM [dbo].[tblCustomizeRequest]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeRequest]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeRequest_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequest_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequest_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeRequest' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeRequest_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [RequestForDestination], [TypeOfTransport], [TypeOfTrip], [TypeOfSport], [LikeNight], [LikeFinish], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang]
		FROM [dbo].[tblCustomizeRequest]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeRequest_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequest_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeRequest_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeRequest' table using the primary key value.
CREATE PROCEDURE [tblCustomizeRequest_GetByPrimaryKey]
	@ID decimal(18,0)
AS
	SELECT [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [RequestForDestination], [TypeOfTransport], [TypeOfTrip], [TypeOfSport], [LikeNight], [LikeFinish], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang] 
	FROM [dbo].[tblCustomizeRequest] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomizeRequest_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequest_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeRequest_Insert]
GO

-- Inserts a new record into the 'tblCustomizeRequest' table.
CREATE PROCEDURE [tblCustomizeRequest_Insert]
	@RequestCode nvarchar(50),
	@CustomerID decimal(18,0),
	@YouAre Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan bit,
	@TravelDate datetime,
	@MonthPlan Int,
	@YearPlan Int,
	@DayNumber Int,
	@BudgetForPerson money,
	@RequestForDestination ntext,
	@TypeOfTransport nvarchar(50),
	@TypeOfTrip nvarchar(50),
	@TypeOfSport nvarchar(50),
	@LikeNight bit,
	@LikeFinish bit,
	@TypeOfHotel nvarchar(50),
	@TypeOfMean nvarchar(255),
	@MoreInfoRequest ntext,
	@RequestDate datetime,
	@Status Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblCustomizeRequest]
	(
		[RequestCode],
		[CustomerID],
		[YouAre],
		[AdultNumber],
		[ChildNumber],
		[IsPlan],
		[TravelDate],
		[MonthPlan],
		[YearPlan],
		[DayNumber],
		[BudgetForPerson],
		[RequestForDestination],
		[TypeOfTransport],
		[TypeOfTrip],
		[TypeOfSport],
		[LikeNight],
		[LikeFinish],
		[TypeOfHotel],
		[TypeOfMean],
		[MoreInfoRequest],
		[RequestDate],
		[Status],
		[Lang]
	)
	VALUES
	(
		@RequestCode,
		@CustomerID,
		@YouAre,
		@AdultNumber,
		@ChildNumber,
		@IsPlan,
		@TravelDate,
		@MonthPlan,
		@YearPlan,
		@DayNumber,
		@BudgetForPerson,
		@RequestForDestination,
		@TypeOfTransport,
		@TypeOfTrip,
		@TypeOfSport,
		@LikeNight,
		@LikeFinish,
		@TypeOfHotel,
		@TypeOfMean,
		@MoreInfoRequest,
		@RequestDate,
		@Status,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblCustomizeRequest_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequest_Update') AND type='P')
	DROP PROCEDURE [tblCustomizeRequest_Update]
GO

-- Updates a record in the 'tblCustomizeRequest' table.
CREATE PROCEDURE [tblCustomizeRequest_Update]
	-- The rest of writeable parameters
	@RequestCode nvarchar(50),
	@CustomerID decimal(18,0),
	@YouAre Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan bit,
	@TravelDate datetime,
	@MonthPlan Int,
	@YearPlan Int,
	@DayNumber Int,
	@BudgetForPerson money,
	@RequestForDestination ntext,
	@TypeOfTransport nvarchar(50),
	@TypeOfTrip nvarchar(50),
	@TypeOfSport nvarchar(50),
	@LikeNight bit,
	@LikeFinish bit,
	@TypeOfHotel nvarchar(50),
	@TypeOfMean nvarchar(255),
	@MoreInfoRequest ntext,
	@RequestDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	UPDATE [dbo].[tblCustomizeRequest] SET
		[RequestCode] = @RequestCode,
		[CustomerID] = @CustomerID,
		[YouAre] = @YouAre,
		[AdultNumber] = @AdultNumber,
		[ChildNumber] = @ChildNumber,
		[IsPlan] = @IsPlan,
		[TravelDate] = @TravelDate,
		[MonthPlan] = @MonthPlan,
		[YearPlan] = @YearPlan,
		[DayNumber] = @DayNumber,
		[BudgetForPerson] = @BudgetForPerson,
		[RequestForDestination] = @RequestForDestination,
		[TypeOfTransport] = @TypeOfTransport,
		[TypeOfTrip] = @TypeOfTrip,
		[TypeOfSport] = @TypeOfSport,
		[LikeNight] = @LikeNight,
		[LikeFinish] = @LikeFinish,
		[TypeOfHotel] = @TypeOfHotel,
		[TypeOfMean] = @TypeOfMean,
		[MoreInfoRequest] = @MoreInfoRequest,
		[RequestDate] = @RequestDate,
		[Status] = @Status,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblCustomizeRequest_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequest_Save') AND type='P')
	DROP PROCEDURE [tblCustomizeRequest_Save]
GO

-- Insert or updates a new record in the 'tblCustomizeRequest' table.
CREATE PROCEDURE [tblCustomizeRequest_Save]
	-- The rest of writeable parameters
	@RequestCode nvarchar(50),
	@CustomerID decimal(18,0),
	@YouAre Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan bit,
	@TravelDate datetime,
	@MonthPlan Int,
	@YearPlan Int,
	@DayNumber Int,
	@BudgetForPerson money,
	@RequestForDestination ntext,
	@TypeOfTransport nvarchar(50),
	@TypeOfTrip nvarchar(50),
	@TypeOfSport nvarchar(50),
	@LikeNight bit,
	@LikeFinish bit,
	@TypeOfHotel nvarchar(50),
	@TypeOfMean nvarchar(255),
	@MoreInfoRequest ntext,
	@RequestDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblCustomizeRequest] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblCustomizeRequest]
		(
			[RequestCode],
			[CustomerID],
			[YouAre],
			[AdultNumber],
			[ChildNumber],
			[IsPlan],
			[TravelDate],
			[MonthPlan],
			[YearPlan],
			[DayNumber],
			[BudgetForPerson],
			[RequestForDestination],
			[TypeOfTransport],
			[TypeOfTrip],
			[TypeOfSport],
			[LikeNight],
			[LikeFinish],
			[TypeOfHotel],
			[TypeOfMean],
			[MoreInfoRequest],
			[RequestDate],
			[Status],
			[Lang]
		)
		VALUES
		(
			@RequestCode,
			@CustomerID,
			@YouAre,
			@AdultNumber,
			@ChildNumber,
			@IsPlan,
			@TravelDate,
			@MonthPlan,
			@YearPlan,
			@DayNumber,
			@BudgetForPerson,
			@RequestForDestination,
			@TypeOfTransport,
			@TypeOfTrip,
			@TypeOfSport,
			@LikeNight,
			@LikeFinish,
			@TypeOfHotel,
			@TypeOfMean,
			@MoreInfoRequest,
			@RequestDate,
			@Status,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblCustomizeRequest] SET
			[RequestCode] = @RequestCode,
			[CustomerID] = @CustomerID,
			[YouAre] = @YouAre,
			[AdultNumber] = @AdultNumber,
			[ChildNumber] = @ChildNumber,
			[IsPlan] = @IsPlan,
			[TravelDate] = @TravelDate,
			[MonthPlan] = @MonthPlan,
			[YearPlan] = @YearPlan,
			[DayNumber] = @DayNumber,
			[BudgetForPerson] = @BudgetForPerson,
			[RequestForDestination] = @RequestForDestination,
			[TypeOfTransport] = @TypeOfTransport,
			[TypeOfTrip] = @TypeOfTrip,
			[TypeOfSport] = @TypeOfSport,
			[LikeNight] = @LikeNight,
			[LikeFinish] = @LikeFinish,
			[TypeOfHotel] = @TypeOfHotel,
			[TypeOfMean] = @TypeOfMean,
			[MoreInfoRequest] = @MoreInfoRequest,
			[RequestDate] = @RequestDate,
			[Status] = @Status,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblCustomizeRequest_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequest_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeRequest_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeRequest' table using the primary key value.
CREATE PROCEDURE [tblCustomizeRequest_DeleteByPrimaryKey]
	@ID decimal(18,0)
AS
	DELETE FROM [dbo].[tblCustomizeRequest] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomizeRequest_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequest_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeRequest_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeRequest' table.
CREATE PROCEDURE [tblCustomizeRequest_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeRequest]
GO

-- Drop the 'tblCustomizeRequest_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequest_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequest_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeRequest' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeRequest_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeRequest]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeRequestAgeAdult' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeRequestAgeAdult_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeAdult_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeAdult_GetAll]
GO

-- Gets all records from the 'tblCustomizeRequestAgeAdult' table.
CREATE PROCEDURE [tblCustomizeRequestAgeAdult_GetAll]
AS
	SELECT [CustomizeRequestID], [AgeAdultID]
	FROM [dbo].[tblCustomizeRequestAgeAdult]
GO

-- Drop the 'tblCustomizeRequestAgeAdult_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeAdult_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeAdult_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeRequestAgeAdult' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeRequestAgeAdult_GetPageAdHoc]
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
						[CustomizeRequestID] decimal(18,0)		,
					[AgeAdultID] Int		
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
			SELECT TOP ' + @total + ' [CustomizeRequestID], [AgeAdultID]
		FROM [dbo].[tblCustomizeRequestAgeAdult]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeRequestAgeAdult]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[CustomizeRequestID], [AgeAdultID] 
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
			EXECUTE('SELECT TOP ' + @length + ' [CustomizeRequestID], [AgeAdultID]
				FROM [dbo].[tblCustomizeRequestAgeAdult]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeRequestAgeAdult]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [CustomizeRequestID], [AgeAdultID]
				FROM [dbo].[tblCustomizeRequestAgeAdult]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeRequestAgeAdult]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeRequestAgeAdult_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeAdult_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeAdult_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeRequestAgeAdult' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeRequestAgeAdult_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [CustomizeRequestID], [AgeAdultID]
		FROM [dbo].[tblCustomizeRequestAgeAdult]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeRequestAgeAdult_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeAdult_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeAdult_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeRequestAgeAdult' table using the primary key value.
CREATE PROCEDURE [tblCustomizeRequestAgeAdult_GetByPrimaryKey]
	@CustomizeRequestID decimal(18,0),
	@AgeAdultID Int
AS
	SELECT [CustomizeRequestID], [AgeAdultID] 
	FROM [dbo].[tblCustomizeRequestAgeAdult] WHERE
		[CustomizeRequestID] = @CustomizeRequestID AND
		[AgeAdultID] = @AgeAdultID
GO

-- Drop the 'tblCustomizeRequestAgeAdult_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeAdult_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeAdult_Insert]
GO

-- Inserts a new record into the 'tblCustomizeRequestAgeAdult' table.
CREATE PROCEDURE [tblCustomizeRequestAgeAdult_Insert]
	@CustomizeRequestID decimal(18,0),
	@AgeAdultID Int
AS
	INSERT INTO [dbo].[tblCustomizeRequestAgeAdult]
	(
		[CustomizeRequestID],
		[AgeAdultID]
	)
	VALUES
	(
		@CustomizeRequestID,
		@AgeAdultID
	)
GO

-- Drop the 'tblCustomizeRequestAgeAdult_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeAdult_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeAdult_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeRequestAgeAdult' table using the primary key value.
CREATE PROCEDURE [tblCustomizeRequestAgeAdult_DeleteByPrimaryKey]
	@CustomizeRequestID decimal(18,0),
	@AgeAdultID Int
AS
	DELETE FROM [dbo].[tblCustomizeRequestAgeAdult] WHERE
		[CustomizeRequestID] = @CustomizeRequestID AND
		[AgeAdultID] = @AgeAdultID
GO

-- Drop the 'tblCustomizeRequestAgeAdult_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeAdult_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeAdult_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeRequestAgeAdult' table.
CREATE PROCEDURE [tblCustomizeRequestAgeAdult_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeRequestAgeAdult]
GO

-- Drop the 'tblCustomizeRequestAgeAdult_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeAdult_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeAdult_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeRequestAgeAdult' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeRequestAgeAdult_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeRequestAgeAdult]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeRequestAgeChild' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeRequestAgeChild_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeChild_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeChild_GetAll]
GO

-- Gets all records from the 'tblCustomizeRequestAgeChild' table.
CREATE PROCEDURE [tblCustomizeRequestAgeChild_GetAll]
AS
	SELECT [CustomizeRequestID], [AgeChildID]
	FROM [dbo].[tblCustomizeRequestAgeChild]
GO

-- Drop the 'tblCustomizeRequestAgeChild_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeChild_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeChild_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeRequestAgeChild' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeRequestAgeChild_GetPageAdHoc]
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
						[CustomizeRequestID] decimal(18,0)		,
					[AgeChildID] Int		
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
			SELECT TOP ' + @total + ' [CustomizeRequestID], [AgeChildID]
		FROM [dbo].[tblCustomizeRequestAgeChild]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeRequestAgeChild]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[CustomizeRequestID], [AgeChildID] 
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
			EXECUTE('SELECT TOP ' + @length + ' [CustomizeRequestID], [AgeChildID]
				FROM [dbo].[tblCustomizeRequestAgeChild]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeRequestAgeChild]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [CustomizeRequestID], [AgeChildID]
				FROM [dbo].[tblCustomizeRequestAgeChild]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeRequestAgeChild]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeRequestAgeChild_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeChild_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeChild_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeRequestAgeChild' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeRequestAgeChild_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [CustomizeRequestID], [AgeChildID]
		FROM [dbo].[tblCustomizeRequestAgeChild]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeRequestAgeChild_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeChild_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeChild_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeRequestAgeChild' table using the primary key value.
CREATE PROCEDURE [tblCustomizeRequestAgeChild_GetByPrimaryKey]
	@CustomizeRequestID decimal(18,0),
	@AgeChildID Int
AS
	SELECT [CustomizeRequestID], [AgeChildID] 
	FROM [dbo].[tblCustomizeRequestAgeChild] WHERE
		[CustomizeRequestID] = @CustomizeRequestID AND
		[AgeChildID] = @AgeChildID
GO

-- Drop the 'tblCustomizeRequestAgeChild_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeChild_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeChild_Insert]
GO

-- Inserts a new record into the 'tblCustomizeRequestAgeChild' table.
CREATE PROCEDURE [tblCustomizeRequestAgeChild_Insert]
	@CustomizeRequestID decimal(18,0),
	@AgeChildID Int
AS
	INSERT INTO [dbo].[tblCustomizeRequestAgeChild]
	(
		[CustomizeRequestID],
		[AgeChildID]
	)
	VALUES
	(
		@CustomizeRequestID,
		@AgeChildID
	)
GO

-- Drop the 'tblCustomizeRequestAgeChild_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeChild_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeChild_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeRequestAgeChild' table using the primary key value.
CREATE PROCEDURE [tblCustomizeRequestAgeChild_DeleteByPrimaryKey]
	@CustomizeRequestID decimal(18,0),
	@AgeChildID Int
AS
	DELETE FROM [dbo].[tblCustomizeRequestAgeChild] WHERE
		[CustomizeRequestID] = @CustomizeRequestID AND
		[AgeChildID] = @AgeChildID
GO

-- Drop the 'tblCustomizeRequestAgeChild_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeChild_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeChild_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeRequestAgeChild' table.
CREATE PROCEDURE [tblCustomizeRequestAgeChild_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeRequestAgeChild]
GO

-- Drop the 'tblCustomizeRequestAgeChild_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestAgeChild_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestAgeChild_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeRequestAgeChild' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeRequestAgeChild_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeRequestAgeChild]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeRequestThingsToDo' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeRequestThingsToDo_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestThingsToDo_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestThingsToDo_GetAll]
GO

-- Gets all records from the 'tblCustomizeRequestThingsToDo' table.
CREATE PROCEDURE [tblCustomizeRequestThingsToDo_GetAll]
AS
	SELECT [ID], [CustomizeRequestID], [CountryID], [ThingsToDoName]
	FROM [dbo].[tblCustomizeRequestThingsToDo]
GO

-- Drop the 'tblCustomizeRequestThingsToDo_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestThingsToDo_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestThingsToDo_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeRequestThingsToDo' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeRequestThingsToDo_GetPageAdHoc]
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
					[CustomizeRequestID] decimal(18,0)		,
					[CountryID] Int		,
					[ThingsToDoName] nvarchar(255)		
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
			SELECT TOP ' + @total + ' [ID], [CustomizeRequestID], [CountryID], [ThingsToDoName]
		FROM [dbo].[tblCustomizeRequestThingsToDo]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeRequestThingsToDo]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [CustomizeRequestID], [CountryID], [ThingsToDoName] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [CustomizeRequestID], [CountryID], [ThingsToDoName]
				FROM [dbo].[tblCustomizeRequestThingsToDo]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeRequestThingsToDo]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [CustomizeRequestID], [CountryID], [ThingsToDoName]
				FROM [dbo].[tblCustomizeRequestThingsToDo]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeRequestThingsToDo]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeRequestThingsToDo_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestThingsToDo_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestThingsToDo_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeRequestThingsToDo' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeRequestThingsToDo_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [CustomizeRequestID], [CountryID], [ThingsToDoName]
		FROM [dbo].[tblCustomizeRequestThingsToDo]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeRequestThingsToDo_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestThingsToDo_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestThingsToDo_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeRequestThingsToDo' table using the primary key value.
CREATE PROCEDURE [tblCustomizeRequestThingsToDo_GetByPrimaryKey]
	@ID decimal(18,0)
AS
	SELECT [ID], [CustomizeRequestID], [CountryID], [ThingsToDoName] 
	FROM [dbo].[tblCustomizeRequestThingsToDo] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomizeRequestThingsToDo_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestThingsToDo_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestThingsToDo_Insert]
GO

-- Inserts a new record into the 'tblCustomizeRequestThingsToDo' table.
CREATE PROCEDURE [tblCustomizeRequestThingsToDo_Insert]
	@CustomizeRequestID decimal(18,0),
	@CountryID Int,
	@ThingsToDoName nvarchar(255)
AS
	INSERT INTO [dbo].[tblCustomizeRequestThingsToDo]
	(
		[CustomizeRequestID],
		[CountryID],
		[ThingsToDoName]
	)
	VALUES
	(
		@CustomizeRequestID,
		@CountryID,
		@ThingsToDoName
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblCustomizeRequestThingsToDo_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestThingsToDo_Update') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestThingsToDo_Update]
GO

-- Updates a record in the 'tblCustomizeRequestThingsToDo' table.
CREATE PROCEDURE [tblCustomizeRequestThingsToDo_Update]
	-- The rest of writeable parameters
	@CustomizeRequestID decimal(18,0),
	@CountryID Int,
	@ThingsToDoName nvarchar(255),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	UPDATE [dbo].[tblCustomizeRequestThingsToDo] SET
		[CustomizeRequestID] = @CustomizeRequestID,
		[CountryID] = @CountryID,
		[ThingsToDoName] = @ThingsToDoName
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblCustomizeRequestThingsToDo_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestThingsToDo_Save') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestThingsToDo_Save]
GO

-- Insert or updates a new record in the 'tblCustomizeRequestThingsToDo' table.
CREATE PROCEDURE [tblCustomizeRequestThingsToDo_Save]
	-- The rest of writeable parameters
	@CustomizeRequestID decimal(18,0),
	@CountryID Int,
	@ThingsToDoName nvarchar(255),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblCustomizeRequestThingsToDo] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblCustomizeRequestThingsToDo]
		(
			[CustomizeRequestID],
			[CountryID],
			[ThingsToDoName]
		)
		VALUES
		(
			@CustomizeRequestID,
			@CountryID,
			@ThingsToDoName
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblCustomizeRequestThingsToDo] SET
			[CustomizeRequestID] = @CustomizeRequestID,
			[CountryID] = @CountryID,
			[ThingsToDoName] = @ThingsToDoName
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblCustomizeRequestThingsToDo_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestThingsToDo_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestThingsToDo_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeRequestThingsToDo' table using the primary key value.
CREATE PROCEDURE [tblCustomizeRequestThingsToDo_DeleteByPrimaryKey]
	@ID decimal(18,0)
AS
	DELETE FROM [dbo].[tblCustomizeRequestThingsToDo] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomizeRequestThingsToDo_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestThingsToDo_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestThingsToDo_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeRequestThingsToDo' table.
CREATE PROCEDURE [tblCustomizeRequestThingsToDo_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeRequestThingsToDo]
GO

-- Drop the 'tblCustomizeRequestThingsToDo_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeRequestThingsToDo_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeRequestThingsToDo_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeRequestThingsToDo' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeRequestThingsToDo_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeRequestThingsToDo]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeWishlist' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeWishlist_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlist_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlist_GetAll]
GO

-- Gets all records from the 'tblCustomizeWishlist' table.
CREATE PROCEDURE [tblCustomizeWishlist_GetAll]
AS
	SELECT [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [TypeOfTransport], [TypeOfTrip], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang]
	FROM [dbo].[tblCustomizeWishlist]
GO

-- Drop the 'tblCustomizeWishlist_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlist_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlist_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeWishlist' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeWishlist_GetPageAdHoc]
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
					[RequestCode] nvarchar(50)		,
					[CustomerID] decimal(18,0)		,
					[YouAre] Int		,
					[AdultNumber] Int		,
					[ChildNumber] Int		,
					[IsPlan] bit		,
					[TravelDate] datetime		,
					[MonthPlan] Int		,
					[YearPlan] Int		,
					[DayNumber] Int		,
					[BudgetForPerson] money		,
					[TypeOfTransport] nvarchar(50)		,
					[TypeOfTrip] nvarchar(50)		,
					[TypeOfHotel] nvarchar(50)		,
					[TypeOfMean] nvarchar(255)		,
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
			SELECT TOP ' + @total + ' [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [TypeOfTransport], [TypeOfTrip], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang]
		FROM [dbo].[tblCustomizeWishlist]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeWishlist]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [TypeOfTransport], [TypeOfTrip], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [TypeOfTransport], [TypeOfTrip], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang]
				FROM [dbo].[tblCustomizeWishlist]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeWishlist]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [TypeOfTransport], [TypeOfTrip], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang]
				FROM [dbo].[tblCustomizeWishlist]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeWishlist]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeWishlist_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlist_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlist_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeWishlist' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeWishlist_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [TypeOfTransport], [TypeOfTrip], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang]
		FROM [dbo].[tblCustomizeWishlist]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeWishlist_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlist_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlist_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeWishlist' table using the primary key value.
CREATE PROCEDURE [tblCustomizeWishlist_GetByPrimaryKey]
	@ID decimal(18,0)
AS
	SELECT [ID], [RequestCode], [CustomerID], [YouAre], [AdultNumber], [ChildNumber], [IsPlan], [TravelDate], [MonthPlan], [YearPlan], [DayNumber], [BudgetForPerson], [TypeOfTransport], [TypeOfTrip], [TypeOfHotel], [TypeOfMean], [MoreInfoRequest], [RequestDate], [Status], [Lang] 
	FROM [dbo].[tblCustomizeWishlist] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomizeWishlist_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlist_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlist_Insert]
GO

-- Inserts a new record into the 'tblCustomizeWishlist' table.
CREATE PROCEDURE [tblCustomizeWishlist_Insert]
	@RequestCode nvarchar(50),
	@CustomerID decimal(18,0),
	@YouAre Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan bit,
	@TravelDate datetime,
	@MonthPlan Int,
	@YearPlan Int,
	@DayNumber Int,
	@BudgetForPerson money,
	@TypeOfTransport nvarchar(50),
	@TypeOfTrip nvarchar(50),
	@TypeOfHotel nvarchar(50),
	@TypeOfMean nvarchar(255),
	@MoreInfoRequest ntext,
	@RequestDate datetime,
	@Status Int,
	@Lang nvarchar(10)
AS
	INSERT INTO [dbo].[tblCustomizeWishlist]
	(
		[RequestCode],
		[CustomerID],
		[YouAre],
		[AdultNumber],
		[ChildNumber],
		[IsPlan],
		[TravelDate],
		[MonthPlan],
		[YearPlan],
		[DayNumber],
		[BudgetForPerson],
		[TypeOfTransport],
		[TypeOfTrip],
		[TypeOfHotel],
		[TypeOfMean],
		[MoreInfoRequest],
		[RequestDate],
		[Status],
		[Lang]
	)
	VALUES
	(
		@RequestCode,
		@CustomerID,
		@YouAre,
		@AdultNumber,
		@ChildNumber,
		@IsPlan,
		@TravelDate,
		@MonthPlan,
		@YearPlan,
		@DayNumber,
		@BudgetForPerson,
		@TypeOfTransport,
		@TypeOfTrip,
		@TypeOfHotel,
		@TypeOfMean,
		@MoreInfoRequest,
		@RequestDate,
		@Status,
		@Lang
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblCustomizeWishlist_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlist_Update') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlist_Update]
GO

-- Updates a record in the 'tblCustomizeWishlist' table.
CREATE PROCEDURE [tblCustomizeWishlist_Update]
	-- The rest of writeable parameters
	@RequestCode nvarchar(50),
	@CustomerID decimal(18,0),
	@YouAre Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan bit,
	@TravelDate datetime,
	@MonthPlan Int,
	@YearPlan Int,
	@DayNumber Int,
	@BudgetForPerson money,
	@TypeOfTransport nvarchar(50),
	@TypeOfTrip nvarchar(50),
	@TypeOfHotel nvarchar(50),
	@TypeOfMean nvarchar(255),
	@MoreInfoRequest ntext,
	@RequestDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	UPDATE [dbo].[tblCustomizeWishlist] SET
		[RequestCode] = @RequestCode,
		[CustomerID] = @CustomerID,
		[YouAre] = @YouAre,
		[AdultNumber] = @AdultNumber,
		[ChildNumber] = @ChildNumber,
		[IsPlan] = @IsPlan,
		[TravelDate] = @TravelDate,
		[MonthPlan] = @MonthPlan,
		[YearPlan] = @YearPlan,
		[DayNumber] = @DayNumber,
		[BudgetForPerson] = @BudgetForPerson,
		[TypeOfTransport] = @TypeOfTransport,
		[TypeOfTrip] = @TypeOfTrip,
		[TypeOfHotel] = @TypeOfHotel,
		[TypeOfMean] = @TypeOfMean,
		[MoreInfoRequest] = @MoreInfoRequest,
		[RequestDate] = @RequestDate,
		[Status] = @Status,
		[Lang] = @Lang
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblCustomizeWishlist_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlist_Save') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlist_Save]
GO

-- Insert or updates a new record in the 'tblCustomizeWishlist' table.
CREATE PROCEDURE [tblCustomizeWishlist_Save]
	-- The rest of writeable parameters
	@RequestCode nvarchar(50),
	@CustomerID decimal(18,0),
	@YouAre Int,
	@AdultNumber Int,
	@ChildNumber Int,
	@IsPlan bit,
	@TravelDate datetime,
	@MonthPlan Int,
	@YearPlan Int,
	@DayNumber Int,
	@BudgetForPerson money,
	@TypeOfTransport nvarchar(50),
	@TypeOfTrip nvarchar(50),
	@TypeOfHotel nvarchar(50),
	@TypeOfMean nvarchar(255),
	@MoreInfoRequest ntext,
	@RequestDate datetime,
	@Status Int,
	@Lang nvarchar(10),
	-- Primary key parameters
	@ID decimal(18,0)
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblCustomizeWishlist] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblCustomizeWishlist]
		(
			[RequestCode],
			[CustomerID],
			[YouAre],
			[AdultNumber],
			[ChildNumber],
			[IsPlan],
			[TravelDate],
			[MonthPlan],
			[YearPlan],
			[DayNumber],
			[BudgetForPerson],
			[TypeOfTransport],
			[TypeOfTrip],
			[TypeOfHotel],
			[TypeOfMean],
			[MoreInfoRequest],
			[RequestDate],
			[Status],
			[Lang]
		)
		VALUES
		(
			@RequestCode,
			@CustomerID,
			@YouAre,
			@AdultNumber,
			@ChildNumber,
			@IsPlan,
			@TravelDate,
			@MonthPlan,
			@YearPlan,
			@DayNumber,
			@BudgetForPerson,
			@TypeOfTransport,
			@TypeOfTrip,
			@TypeOfHotel,
			@TypeOfMean,
			@MoreInfoRequest,
			@RequestDate,
			@Status,
			@Lang
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblCustomizeWishlist] SET
			[RequestCode] = @RequestCode,
			[CustomerID] = @CustomerID,
			[YouAre] = @YouAre,
			[AdultNumber] = @AdultNumber,
			[ChildNumber] = @ChildNumber,
			[IsPlan] = @IsPlan,
			[TravelDate] = @TravelDate,
			[MonthPlan] = @MonthPlan,
			[YearPlan] = @YearPlan,
			[DayNumber] = @DayNumber,
			[BudgetForPerson] = @BudgetForPerson,
			[TypeOfTransport] = @TypeOfTransport,
			[TypeOfTrip] = @TypeOfTrip,
			[TypeOfHotel] = @TypeOfHotel,
			[TypeOfMean] = @TypeOfMean,
			[MoreInfoRequest] = @MoreInfoRequest,
			[RequestDate] = @RequestDate,
			[Status] = @Status,
			[Lang] = @Lang
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblCustomizeWishlist_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlist_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlist_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeWishlist' table using the primary key value.
CREATE PROCEDURE [tblCustomizeWishlist_DeleteByPrimaryKey]
	@ID decimal(18,0)
AS
	DELETE FROM [dbo].[tblCustomizeWishlist] WHERE
		[ID] = @ID
GO

-- Drop the 'tblCustomizeWishlist_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlist_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlist_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeWishlist' table.
CREATE PROCEDURE [tblCustomizeWishlist_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeWishlist]
GO

-- Drop the 'tblCustomizeWishlist_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlist_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlist_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeWishlist' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeWishlist_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeWishlist]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeWishlistAgeAdult' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeWishlistAgeAdult_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeAdult_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeAdult_GetAll]
GO

-- Gets all records from the 'tblCustomizeWishlistAgeAdult' table.
CREATE PROCEDURE [tblCustomizeWishlistAgeAdult_GetAll]
AS
	SELECT [CustomizeWishlistID], [AgeAdultID]
	FROM [dbo].[tblCustomizeWishlistAgeAdult]
GO

-- Drop the 'tblCustomizeWishlistAgeAdult_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeAdult_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeAdult_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeWishlistAgeAdult' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeWishlistAgeAdult_GetPageAdHoc]
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
						[CustomizeWishlistID] decimal(18,0)		,
					[AgeAdultID] Int		
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
			SELECT TOP ' + @total + ' [CustomizeWishlistID], [AgeAdultID]
		FROM [dbo].[tblCustomizeWishlistAgeAdult]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeWishlistAgeAdult]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[CustomizeWishlistID], [AgeAdultID] 
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
			EXECUTE('SELECT TOP ' + @length + ' [CustomizeWishlistID], [AgeAdultID]
				FROM [dbo].[tblCustomizeWishlistAgeAdult]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeWishlistAgeAdult]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [CustomizeWishlistID], [AgeAdultID]
				FROM [dbo].[tblCustomizeWishlistAgeAdult]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeWishlistAgeAdult]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeWishlistAgeAdult_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeAdult_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeAdult_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeWishlistAgeAdult' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeWishlistAgeAdult_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [CustomizeWishlistID], [AgeAdultID]
		FROM [dbo].[tblCustomizeWishlistAgeAdult]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeWishlistAgeAdult_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeAdult_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeAdult_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeWishlistAgeAdult' table using the primary key value.
CREATE PROCEDURE [tblCustomizeWishlistAgeAdult_GetByPrimaryKey]
	@CustomizeWishlistID decimal(18,0),
	@AgeAdultID Int
AS
	SELECT [CustomizeWishlistID], [AgeAdultID] 
	FROM [dbo].[tblCustomizeWishlistAgeAdult] WHERE
		[CustomizeWishlistID] = @CustomizeWishlistID AND
		[AgeAdultID] = @AgeAdultID
GO

-- Drop the 'tblCustomizeWishlistAgeAdult_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeAdult_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeAdult_Insert]
GO

-- Inserts a new record into the 'tblCustomizeWishlistAgeAdult' table.
CREATE PROCEDURE [tblCustomizeWishlistAgeAdult_Insert]
	@CustomizeWishlistID decimal(18,0),
	@AgeAdultID Int
AS
	INSERT INTO [dbo].[tblCustomizeWishlistAgeAdult]
	(
		[CustomizeWishlistID],
		[AgeAdultID]
	)
	VALUES
	(
		@CustomizeWishlistID,
		@AgeAdultID
	)
GO

-- Drop the 'tblCustomizeWishlistAgeAdult_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeAdult_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeAdult_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeWishlistAgeAdult' table using the primary key value.
CREATE PROCEDURE [tblCustomizeWishlistAgeAdult_DeleteByPrimaryKey]
	@CustomizeWishlistID decimal(18,0),
	@AgeAdultID Int
AS
	DELETE FROM [dbo].[tblCustomizeWishlistAgeAdult] WHERE
		[CustomizeWishlistID] = @CustomizeWishlistID AND
		[AgeAdultID] = @AgeAdultID
GO

-- Drop the 'tblCustomizeWishlistAgeAdult_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeAdult_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeAdult_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeWishlistAgeAdult' table.
CREATE PROCEDURE [tblCustomizeWishlistAgeAdult_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeWishlistAgeAdult]
GO

-- Drop the 'tblCustomizeWishlistAgeAdult_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeAdult_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeAdult_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeWishlistAgeAdult' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeWishlistAgeAdult_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeWishlistAgeAdult]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeWishlistAgeChild' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeWishlistAgeChild_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeChild_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeChild_GetAll]
GO

-- Gets all records from the 'tblCustomizeWishlistAgeChild' table.
CREATE PROCEDURE [tblCustomizeWishlistAgeChild_GetAll]
AS
	SELECT [CustomizeWishlistID], [AgeChildID]
	FROM [dbo].[tblCustomizeWishlistAgeChild]
GO

-- Drop the 'tblCustomizeWishlistAgeChild_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeChild_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeChild_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeWishlistAgeChild' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeWishlistAgeChild_GetPageAdHoc]
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
						[CustomizeWishlistID] decimal(18,0)		,
					[AgeChildID] Int		
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
			SELECT TOP ' + @total + ' [CustomizeWishlistID], [AgeChildID]
		FROM [dbo].[tblCustomizeWishlistAgeChild]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeWishlistAgeChild]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[CustomizeWishlistID], [AgeChildID] 
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
			EXECUTE('SELECT TOP ' + @length + ' [CustomizeWishlistID], [AgeChildID]
				FROM [dbo].[tblCustomizeWishlistAgeChild]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeWishlistAgeChild]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [CustomizeWishlistID], [AgeChildID]
				FROM [dbo].[tblCustomizeWishlistAgeChild]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeWishlistAgeChild]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeWishlistAgeChild_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeChild_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeChild_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeWishlistAgeChild' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeWishlistAgeChild_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [CustomizeWishlistID], [AgeChildID]
		FROM [dbo].[tblCustomizeWishlistAgeChild]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeWishlistAgeChild_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeChild_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeChild_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeWishlistAgeChild' table using the primary key value.
CREATE PROCEDURE [tblCustomizeWishlistAgeChild_GetByPrimaryKey]
	@CustomizeWishlistID decimal(18,0),
	@AgeChildID Int
AS
	SELECT [CustomizeWishlistID], [AgeChildID] 
	FROM [dbo].[tblCustomizeWishlistAgeChild] WHERE
		[CustomizeWishlistID] = @CustomizeWishlistID AND
		[AgeChildID] = @AgeChildID
GO

-- Drop the 'tblCustomizeWishlistAgeChild_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeChild_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeChild_Insert]
GO

-- Inserts a new record into the 'tblCustomizeWishlistAgeChild' table.
CREATE PROCEDURE [tblCustomizeWishlistAgeChild_Insert]
	@CustomizeWishlistID decimal(18,0),
	@AgeChildID Int
AS
	INSERT INTO [dbo].[tblCustomizeWishlistAgeChild]
	(
		[CustomizeWishlistID],
		[AgeChildID]
	)
	VALUES
	(
		@CustomizeWishlistID,
		@AgeChildID
	)
GO

-- Drop the 'tblCustomizeWishlistAgeChild_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeChild_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeChild_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeWishlistAgeChild' table using the primary key value.
CREATE PROCEDURE [tblCustomizeWishlistAgeChild_DeleteByPrimaryKey]
	@CustomizeWishlistID decimal(18,0),
	@AgeChildID Int
AS
	DELETE FROM [dbo].[tblCustomizeWishlistAgeChild] WHERE
		[CustomizeWishlistID] = @CustomizeWishlistID AND
		[AgeChildID] = @AgeChildID
GO

-- Drop the 'tblCustomizeWishlistAgeChild_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeChild_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeChild_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeWishlistAgeChild' table.
CREATE PROCEDURE [tblCustomizeWishlistAgeChild_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeWishlistAgeChild]
GO

-- Drop the 'tblCustomizeWishlistAgeChild_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistAgeChild_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistAgeChild_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeWishlistAgeChild' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeWishlistAgeChild_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeWishlistAgeChild]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeWishlistHotel' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeWishlistHotel_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistHotel_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistHotel_GetAll]
GO

-- Gets all records from the 'tblCustomizeWishlistHotel' table.
CREATE PROCEDURE [tblCustomizeWishlistHotel_GetAll]
AS
	SELECT [CustomizeWishlistID], [HotelID]
	FROM [dbo].[tblCustomizeWishlistHotel]
GO

-- Drop the 'tblCustomizeWishlistHotel_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistHotel_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistHotel_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeWishlistHotel' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeWishlistHotel_GetPageAdHoc]
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
						[CustomizeWishlistID] decimal(18,0)		,
					[HotelID] Int		
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
			SELECT TOP ' + @total + ' [CustomizeWishlistID], [HotelID]
		FROM [dbo].[tblCustomizeWishlistHotel]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeWishlistHotel]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[CustomizeWishlistID], [HotelID] 
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
			EXECUTE('SELECT TOP ' + @length + ' [CustomizeWishlistID], [HotelID]
				FROM [dbo].[tblCustomizeWishlistHotel]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeWishlistHotel]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [CustomizeWishlistID], [HotelID]
				FROM [dbo].[tblCustomizeWishlistHotel]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeWishlistHotel]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeWishlistHotel_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistHotel_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistHotel_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeWishlistHotel' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeWishlistHotel_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [CustomizeWishlistID], [HotelID]
		FROM [dbo].[tblCustomizeWishlistHotel]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeWishlistHotel_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistHotel_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistHotel_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeWishlistHotel' table using the primary key value.
CREATE PROCEDURE [tblCustomizeWishlistHotel_GetByPrimaryKey]
	@CustomizeWishlistID decimal(18,0),
	@HotelID Int
AS
	SELECT [CustomizeWishlistID], [HotelID] 
	FROM [dbo].[tblCustomizeWishlistHotel] WHERE
		[CustomizeWishlistID] = @CustomizeWishlistID AND
		[HotelID] = @HotelID
GO

-- Drop the 'tblCustomizeWishlistHotel_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistHotel_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistHotel_Insert]
GO

-- Inserts a new record into the 'tblCustomizeWishlistHotel' table.
CREATE PROCEDURE [tblCustomizeWishlistHotel_Insert]
	@CustomizeWishlistID decimal(18,0),
	@HotelID Int
AS
	INSERT INTO [dbo].[tblCustomizeWishlistHotel]
	(
		[CustomizeWishlistID],
		[HotelID]
	)
	VALUES
	(
		@CustomizeWishlistID,
		@HotelID
	)
GO

-- Drop the 'tblCustomizeWishlistHotel_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistHotel_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistHotel_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeWishlistHotel' table using the primary key value.
CREATE PROCEDURE [tblCustomizeWishlistHotel_DeleteByPrimaryKey]
	@CustomizeWishlistID decimal(18,0),
	@HotelID Int
AS
	DELETE FROM [dbo].[tblCustomizeWishlistHotel] WHERE
		[CustomizeWishlistID] = @CustomizeWishlistID AND
		[HotelID] = @HotelID
GO

-- Drop the 'tblCustomizeWishlistHotel_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistHotel_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistHotel_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeWishlistHotel' table.
CREATE PROCEDURE [tblCustomizeWishlistHotel_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeWishlistHotel]
GO

-- Drop the 'tblCustomizeWishlistHotel_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistHotel_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistHotel_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeWishlistHotel' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeWishlistHotel_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeWishlistHotel]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblCustomizeWishlistThingsToDo' table.
----------------------------------------------------------

-- Drop the 'tblCustomizeWishlistThingsToDo_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistThingsToDo_GetAll') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistThingsToDo_GetAll]
GO

-- Gets all records from the 'tblCustomizeWishlistThingsToDo' table.
CREATE PROCEDURE [tblCustomizeWishlistThingsToDo_GetAll]
AS
	SELECT [CustomizeWishlistID], [ThingsToDoID]
	FROM [dbo].[tblCustomizeWishlistThingsToDo]
GO

-- Drop the 'tblCustomizeWishlistThingsToDo_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistThingsToDo_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistThingsToDo_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblCustomizeWishlistThingsToDo' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblCustomizeWishlistThingsToDo_GetPageAdHoc]
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
						[CustomizeWishlistID] decimal(18,0)		,
					[ThingsToDoID] Int		
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
			SELECT TOP ' + @total + ' [CustomizeWishlistID], [ThingsToDoID]
		FROM [dbo].[tblCustomizeWishlistThingsToDo]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblCustomizeWishlistThingsToDo]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[CustomizeWishlistID], [ThingsToDoID] 
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
			EXECUTE('SELECT TOP ' + @length + ' [CustomizeWishlistID], [ThingsToDoID]
				FROM [dbo].[tblCustomizeWishlistThingsToDo]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblCustomizeWishlistThingsToDo]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [CustomizeWishlistID], [ThingsToDoID]
				FROM [dbo].[tblCustomizeWishlistThingsToDo]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblCustomizeWishlistThingsToDo]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblCustomizeWishlistThingsToDo_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistThingsToDo_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistThingsToDo_GetAdHoc]
GO

-- Gets records from the 'tblCustomizeWishlistThingsToDo' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblCustomizeWishlistThingsToDo_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [CustomizeWishlistID], [ThingsToDoID]
		FROM [dbo].[tblCustomizeWishlistThingsToDo]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblCustomizeWishlistThingsToDo_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistThingsToDo_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistThingsToDo_GetByPrimaryKey]
GO

-- Gets a record from the 'tblCustomizeWishlistThingsToDo' table using the primary key value.
CREATE PROCEDURE [tblCustomizeWishlistThingsToDo_GetByPrimaryKey]
	@CustomizeWishlistID decimal(18,0),
	@ThingsToDoID Int
AS
	SELECT [CustomizeWishlistID], [ThingsToDoID] 
	FROM [dbo].[tblCustomizeWishlistThingsToDo] WHERE
		[CustomizeWishlistID] = @CustomizeWishlistID AND
		[ThingsToDoID] = @ThingsToDoID
GO

-- Drop the 'tblCustomizeWishlistThingsToDo_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistThingsToDo_Insert') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistThingsToDo_Insert]
GO

-- Inserts a new record into the 'tblCustomizeWishlistThingsToDo' table.
CREATE PROCEDURE [tblCustomizeWishlistThingsToDo_Insert]
	@CustomizeWishlistID decimal(18,0),
	@ThingsToDoID Int
AS
	INSERT INTO [dbo].[tblCustomizeWishlistThingsToDo]
	(
		[CustomizeWishlistID],
		[ThingsToDoID]
	)
	VALUES
	(
		@CustomizeWishlistID,
		@ThingsToDoID
	)
GO

-- Drop the 'tblCustomizeWishlistThingsToDo_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistThingsToDo_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistThingsToDo_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblCustomizeWishlistThingsToDo' table using the primary key value.
CREATE PROCEDURE [tblCustomizeWishlistThingsToDo_DeleteByPrimaryKey]
	@CustomizeWishlistID decimal(18,0),
	@ThingsToDoID Int
AS
	DELETE FROM [dbo].[tblCustomizeWishlistThingsToDo] WHERE
		[CustomizeWishlistID] = @CustomizeWishlistID AND
		[ThingsToDoID] = @ThingsToDoID
GO

-- Drop the 'tblCustomizeWishlistThingsToDo_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistThingsToDo_DeleteAll') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistThingsToDo_DeleteAll]
GO

-- Deletes all records from the 'tblCustomizeWishlistThingsToDo' table.
CREATE PROCEDURE [tblCustomizeWishlistThingsToDo_DeleteAll]
AS
	DELETE FROM [dbo].[tblCustomizeWishlistThingsToDo]
GO

-- Drop the 'tblCustomizeWishlistThingsToDo_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblCustomizeWishlistThingsToDo_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblCustomizeWishlistThingsToDo_DeleteAdHoc]
GO

-- Deletes records from the 'tblCustomizeWishlistThingsToDo' table that match the supplied where clause.
CREATE PROCEDURE [tblCustomizeWishlistThingsToDo_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblCustomizeWishlistThingsToDo]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblDepartment' table.
----------------------------------------------------------

-- Drop the 'tblDepartment_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblDepartment_GetAll') AND type='P')
	DROP PROCEDURE [tblDepartment_GetAll]
GO

-- Gets all records from the 'tblDepartment' table.
CREATE PROCEDURE [tblDepartment_GetAll]
AS
	SELECT [ID], [CompanyID], [Name], [OrderBy]
	FROM [dbo].[tblDepartment]
GO

-- Drop the 'tblDepartment_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblDepartment_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblDepartment_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblDepartment' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblDepartment_GetPageAdHoc]
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
					[CompanyID] Int		,
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
			SELECT TOP ' + @total + ' [ID], [CompanyID], [Name], [OrderBy]
		FROM [dbo].[tblDepartment]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblDepartment]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [CompanyID], [Name], [OrderBy] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [CompanyID], [Name], [OrderBy]
				FROM [dbo].[tblDepartment]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblDepartment]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [CompanyID], [Name], [OrderBy]
				FROM [dbo].[tblDepartment]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblDepartment]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblDepartment_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblDepartment_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblDepartment_GetAdHoc]
GO

-- Gets records from the 'tblDepartment' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblDepartment_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [CompanyID], [Name], [OrderBy]
		FROM [dbo].[tblDepartment]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblDepartment_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblDepartment_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblDepartment_GetByPrimaryKey]
GO

-- Gets a record from the 'tblDepartment' table using the primary key value.
CREATE PROCEDURE [tblDepartment_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [CompanyID], [Name], [OrderBy] 
	FROM [dbo].[tblDepartment] WHERE
		[ID] = @ID
GO

-- Drop the 'tblDepartment_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblDepartment_Insert') AND type='P')
	DROP PROCEDURE [tblDepartment_Insert]
GO

-- Inserts a new record into the 'tblDepartment' table.
CREATE PROCEDURE [tblDepartment_Insert]
	@CompanyID Int,
	@Name nvarchar(255),
	@OrderBy Int
AS
	INSERT INTO [dbo].[tblDepartment]
	(
		[CompanyID],
		[Name],
		[OrderBy]
	)
	VALUES
	(
		@CompanyID,
		@Name,
		@OrderBy
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblDepartment_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblDepartment_Update') AND type='P')
	DROP PROCEDURE [tblDepartment_Update]
GO

-- Updates a record in the 'tblDepartment' table.
CREATE PROCEDURE [tblDepartment_Update]
	-- The rest of writeable parameters
	@CompanyID Int,
	@Name nvarchar(255),
	@OrderBy Int,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblDepartment] SET
		[CompanyID] = @CompanyID,
		[Name] = @Name,
		[OrderBy] = @OrderBy
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblDepartment_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblDepartment_Save') AND type='P')
	DROP PROCEDURE [tblDepartment_Save]
GO

-- Insert or updates a new record in the 'tblDepartment' table.
CREATE PROCEDURE [tblDepartment_Save]
	-- The rest of writeable parameters
	@CompanyID Int,
	@Name nvarchar(255),
	@OrderBy Int,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblDepartment] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblDepartment]
		(
			[CompanyID],
			[Name],
			[OrderBy]
		)
		VALUES
		(
			@CompanyID,
			@Name,
			@OrderBy
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblDepartment] SET
			[CompanyID] = @CompanyID,
			[Name] = @Name,
			[OrderBy] = @OrderBy
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblDepartment_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblDepartment_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblDepartment_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblDepartment' table using the primary key value.
CREATE PROCEDURE [tblDepartment_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblDepartment] WHERE
		[ID] = @ID
GO

-- Drop the 'tblDepartment_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblDepartment_DeleteAll') AND type='P')
	DROP PROCEDURE [tblDepartment_DeleteAll]
GO

-- Deletes all records from the 'tblDepartment' table.
CREATE PROCEDURE [tblDepartment_DeleteAll]
AS
	DELETE FROM [dbo].[tblDepartment]
GO

-- Drop the 'tblDepartment_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblDepartment_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblDepartment_DeleteAdHoc]
GO

-- Deletes records from the 'tblDepartment' table that match the supplied where clause.
CREATE PROCEDURE [tblDepartment_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblDepartment]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblFunction' table.
----------------------------------------------------------

-- Drop the 'tblFunction_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblFunction_GetAll') AND type='P')
	DROP PROCEDURE [tblFunction_GetAll]
GO

-- Gets all records from the 'tblFunction' table.
CREATE PROCEDURE [tblFunction_GetAll]
AS
	SELECT [ID], [FunctionName], [OrderBy]
	FROM [dbo].[tblFunction]
GO

-- Drop the 'tblFunction_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblFunction_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblFunction_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblFunction' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblFunction_GetPageAdHoc]
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
					[FunctionName] nvarchar(255)		,
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
			SELECT TOP ' + @total + ' [ID], [FunctionName], [OrderBy]
		FROM [dbo].[tblFunction]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblFunction]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [FunctionName], [OrderBy] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [FunctionName], [OrderBy]
				FROM [dbo].[tblFunction]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblFunction]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [FunctionName], [OrderBy]
				FROM [dbo].[tblFunction]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblFunction]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblFunction_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblFunction_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblFunction_GetAdHoc]
GO

-- Gets records from the 'tblFunction' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblFunction_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [FunctionName], [OrderBy]
		FROM [dbo].[tblFunction]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblFunction_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblFunction_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblFunction_GetByPrimaryKey]
GO

-- Gets a record from the 'tblFunction' table using the primary key value.
CREATE PROCEDURE [tblFunction_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [FunctionName], [OrderBy] 
	FROM [dbo].[tblFunction] WHERE
		[ID] = @ID
GO

-- Drop the 'tblFunction_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblFunction_Insert') AND type='P')
	DROP PROCEDURE [tblFunction_Insert]
GO

-- Inserts a new record into the 'tblFunction' table.
CREATE PROCEDURE [tblFunction_Insert]
	@FunctionName nvarchar(255),
	@OrderBy Int
AS
	INSERT INTO [dbo].[tblFunction]
	(
		[FunctionName],
		[OrderBy]
	)
	VALUES
	(
		@FunctionName,
		@OrderBy
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblFunction_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblFunction_Update') AND type='P')
	DROP PROCEDURE [tblFunction_Update]
GO

-- Updates a record in the 'tblFunction' table.
CREATE PROCEDURE [tblFunction_Update]
	-- The rest of writeable parameters
	@FunctionName nvarchar(255),
	@OrderBy Int,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblFunction] SET
		[FunctionName] = @FunctionName,
		[OrderBy] = @OrderBy
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblFunction_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblFunction_Save') AND type='P')
	DROP PROCEDURE [tblFunction_Save]
GO

-- Insert or updates a new record in the 'tblFunction' table.
CREATE PROCEDURE [tblFunction_Save]
	-- The rest of writeable parameters
	@FunctionName nvarchar(255),
	@OrderBy Int,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblFunction] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblFunction]
		(
			[FunctionName],
			[OrderBy]
		)
		VALUES
		(
			@FunctionName,
			@OrderBy
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblFunction] SET
			[FunctionName] = @FunctionName,
			[OrderBy] = @OrderBy
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblFunction_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblFunction_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblFunction_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblFunction' table using the primary key value.
CREATE PROCEDURE [tblFunction_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblFunction] WHERE
		[ID] = @ID
GO

-- Drop the 'tblFunction_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblFunction_DeleteAll') AND type='P')
	DROP PROCEDURE [tblFunction_DeleteAll]
GO

-- Deletes all records from the 'tblFunction' table.
CREATE PROCEDURE [tblFunction_DeleteAll]
AS
	DELETE FROM [dbo].[tblFunction]
GO

-- Drop the 'tblFunction_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblFunction_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblFunction_DeleteAdHoc]
GO

-- Deletes records from the 'tblFunction' table that match the supplied where clause.
CREATE PROCEDURE [tblFunction_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblFunction]' +	
		@where)	
GO

----------------------------------------------------------
-- Stored procedures for the 'tblHotel' table.
----------------------------------------------------------

-- Drop the 'tblHotel_GetAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_GetAll') AND type='P')
	DROP PROCEDURE [tblHotel_GetAll]
GO

-- Gets all records from the 'tblHotel' table.
CREATE PROCEDURE [tblHotel_GetAll]
AS
	SELECT [ID], [CateID], [AttractionsID], [HotelStyleID], [ServiceID], [Star], [Rating], [RoomNum], [FlgIndex], [FlgHome], [Status], [RegDate]
	FROM [dbo].[tblHotel]
GO

-- Drop the 'tblHotel_GetPageAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_GetPageAdHoc') AND type='P')
	DROP PROCEDURE [tblHotel_GetPageAdHoc]
GO

-- Gets a page of records from the 'tblHotel' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- Works by selecting the rows into a temp table with an identity column and then selecting the 
-- appropriate rows using the assigned identity values as row numbers.
-- Not the world's most efficient stored proc but very flexible and more efficient than pulling the entire table over the network
-- to the web server
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
-- @startIndex : the index of the first row desired, 1-based.  A value of 1 gives the first n rows (where n is defined by length).
-- @length : the number of rows per page (the number of rows to return).  
-- @rows : an output parameter that tells how many total rows were in the filtered resultset.  Useful to determining total number of pages.
CREATE PROCEDURE [tblHotel_GetPageAdHoc]
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
					[AttractionsID] Int		,
					[HotelStyleID] Int		,
					[ServiceID] nvarchar(255)		,
					[Star] Int		,
					[Rating] Int		,
					[RoomNum] Int		,
					[FlgIndex] Int		,
					[FlgHome] Int		,
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
			SELECT TOP ' + @total + ' [ID], [CateID], [AttractionsID], [HotelStyleID], [ServiceID], [Star], [Rating], [RoomNum], [FlgIndex], [FlgHome], [Status], [RegDate]
		FROM [dbo].[tblHotel]' +	
		@where +
		@orderby)
		
		CREATE TABLE #TempRows(rows int)
		
		EXECUTE('INSERT INTO #TempRows
			SELECT  count(*) FROM [dbo].[tblHotel]' + @where)

		SELECT @rows = rows FROM #TempRows

		DROP TABLE #TempRows	

		IF @@ERROR <> 0
			GOTO ErrorHandler

		SELECT 	[ID], [CateID], [AttractionsID], [HotelStyleID], [ServiceID], [Star], [Rating], [RoomNum], [FlgIndex], [FlgHome], [Status], [RegDate] 
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
			EXECUTE('SELECT TOP ' + @length + ' [ID], [CateID], [AttractionsID], [HotelStyleID], [ServiceID], [Star], [Rating], [RoomNum], [FlgIndex], [FlgHome], [Status], [RegDate]
				FROM [dbo].[tblHotel]' +	
				@where +
				@orderby)

			CREATE TABLE #TempRows2(rows int)

			EXECUTE('INSERT INTO #TempRows2
				SELECT  count(*) FROM [dbo].[tblHotel]' + @where)

			SELECT @rows = rows FROM #TempRows2

			DROP TABLE #TempRows2
		END /* @where not blank */
		ELSE
		BEGIN
			/* Special case if no where clause and getting from the first row. 
			   This performance optimization is useful because the default view in the datagrid is to show the rows unfiltered 
			   starting at the first row.  In this case there's no point in using a temp table at all since the TOP operator will do the
			    trick all by itself */
			execute('SELECT TOP ' + @length + ' [ID], [CateID], [AttractionsID], [HotelStyleID], [ServiceID], [Star], [Rating], [RoomNum], [FlgIndex], [FlgHome], [Status], [RegDate]
				FROM [dbo].[tblHotel]' +	
				@orderby)
			SELECT @rows = count(*) FROM [dbo].[tblHotel]
		END /* @where blank */
	END /* starting from top  */


	RETURN 0

	ErrorHandler:
	ROLLBACK TRANSACTION GetDataSet
	RETURN @@ERROR
GO


-- Drop the 'tblHotel_GetAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_GetAdHoc') AND type='P')
	DROP PROCEDURE [tblHotel_GetAdHoc]
GO

-- Gets records from the 'tblHotel' table, filtered by an ad-hoc where clause and ordered by an ad-hoc order by.	
-- @where : any valid where clause for the table (i.e. 'lastname like ''sm%''')
-- @orderby : any valid order by clause for the table (i.e. 'lastname Asc, firstname Asc')
CREATE PROCEDURE [tblHotel_GetAdHoc]
	@where nvarchar(4000) = '',
	@orderby nvarchar(255) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	IF @orderby <> '' 
		SET @orderby = ' ORDER BY ' + @orderby

	execute('SELECT [ID], [CateID], [AttractionsID], [HotelStyleID], [ServiceID], [Star], [Rating], [RoomNum], [FlgIndex], [FlgHome], [Status], [RegDate]
		FROM [dbo].[tblHotel]' +	
		@where +
		@orderby)
GO

-- Drop the 'tblHotel_GetByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_GetByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotel_GetByPrimaryKey]
GO

-- Gets a record from the 'tblHotel' table using the primary key value.
CREATE PROCEDURE [tblHotel_GetByPrimaryKey]
	@ID Int
AS
	SELECT [ID], [CateID], [AttractionsID], [HotelStyleID], [ServiceID], [Star], [Rating], [RoomNum], [FlgIndex], [FlgHome], [Status], [RegDate] 
	FROM [dbo].[tblHotel] WHERE
		[ID] = @ID
GO

-- Drop the 'tblHotel_Insert' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_Insert') AND type='P')
	DROP PROCEDURE [tblHotel_Insert]
GO

-- Inserts a new record into the 'tblHotel' table.
CREATE PROCEDURE [tblHotel_Insert]
	@CateID Int,
	@AttractionsID Int,
	@HotelStyleID Int,
	@ServiceID nvarchar(255),
	@Star Int,
	@Rating Int,
	@RoomNum Int,
	@FlgIndex Int,
	@FlgHome Int,
	@Status Int,
	@RegDate datetime
AS
	INSERT INTO [dbo].[tblHotel]
	(
		[CateID],
		[AttractionsID],
		[HotelStyleID],
		[ServiceID],
		[Star],
		[Rating],
		[RoomNum],
		[FlgIndex],
		[FlgHome],
		[Status],
		[RegDate]
	)
	VALUES
	(
		@CateID,
		@AttractionsID,
		@HotelStyleID,
		@ServiceID,
		@Star,
		@Rating,
		@RoomNum,
		@FlgIndex,
		@FlgHome,
		@Status,
		@RegDate
	)
	SELECT @@IDENTITY
GO

-- Drop the 'tblHotel_Update' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_Update') AND type='P')
	DROP PROCEDURE [tblHotel_Update]
GO

-- Updates a record in the 'tblHotel' table.
CREATE PROCEDURE [tblHotel_Update]
	-- The rest of writeable parameters
	@CateID Int,
	@AttractionsID Int,
	@HotelStyleID Int,
	@ServiceID nvarchar(255),
	@Star Int,
	@Rating Int,
	@RoomNum Int,
	@FlgIndex Int,
	@FlgHome Int,
	@Status Int,
	@RegDate datetime,
	-- Primary key parameters
	@ID Int
AS
	UPDATE [dbo].[tblHotel] SET
		[CateID] = @CateID,
		[AttractionsID] = @AttractionsID,
		[HotelStyleID] = @HotelStyleID,
		[ServiceID] = @ServiceID,
		[Star] = @Star,
		[Rating] = @Rating,
		[RoomNum] = @RoomNum,
		[FlgIndex] = @FlgIndex,
		[FlgHome] = @FlgHome,
		[Status] = @Status,
		[RegDate] = @RegDate
	WHERE
		[ID] = @ID
GO
-- Drop the 'tblHotel_Save' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_Save') AND type='P')
	DROP PROCEDURE [tblHotel_Save]
GO

-- Insert or updates a new record in the 'tblHotel' table.
CREATE PROCEDURE [tblHotel_Save]
	-- The rest of writeable parameters
	@CateID Int,
	@AttractionsID Int,
	@HotelStyleID Int,
	@ServiceID nvarchar(255),
	@Star Int,
	@Rating Int,
	@RoomNum Int,
	@FlgIndex Int,
	@FlgHome Int,
	@Status Int,
	@RegDate datetime,
	-- Primary key parameters
	@ID Int
AS
	declare @rowCount int

	SELECT @rowCount = count(*) FROM [dbo].[tblHotel] Where 
	[ID] = @ID 
	
		
	IF (@rowCount < 1)
	BEGIN
		INSERT INTO [dbo].[tblHotel]
		(
			[CateID],
			[AttractionsID],
			[HotelStyleID],
			[ServiceID],
			[Star],
			[Rating],
			[RoomNum],
			[FlgIndex],
			[FlgHome],
			[Status],
			[RegDate]
		)
		VALUES
		(
			@CateID,
			@AttractionsID,
			@HotelStyleID,
			@ServiceID,
			@Star,
			@Rating,
			@RoomNum,
			@FlgIndex,
			@FlgHome,
			@Status,
			@RegDate
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[tblHotel] SET
			[CateID] = @CateID,
			[AttractionsID] = @AttractionsID,
			[HotelStyleID] = @HotelStyleID,
			[ServiceID] = @ServiceID,
			[Star] = @Star,
			[Rating] = @Rating,
			[RoomNum] = @RoomNum,
			[FlgIndex] = @FlgIndex,
			[FlgHome] = @FlgHome,
			[Status] = @Status,
			[RegDate] = @RegDate
		WHERE
			[ID] = @ID
		SELECT @ID
	END
GO

-- Drop the 'tblHotel_DeleteByPrimaryKey' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_DeleteByPrimaryKey') AND type='P')
	DROP PROCEDURE [tblHotel_DeleteByPrimaryKey]
GO

-- Deletes a record from the 'tblHotel' table using the primary key value.
CREATE PROCEDURE [tblHotel_DeleteByPrimaryKey]
	@ID Int
AS
	DELETE FROM [dbo].[tblHotel] WHERE
		[ID] = @ID
GO

-- Drop the 'tblHotel_DeleteAll' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_DeleteAll') AND type='P')
	DROP PROCEDURE [tblHotel_DeleteAll]
GO

-- Deletes all records from the 'tblHotel' table.
CREATE PROCEDURE [tblHotel_DeleteAll]
AS
	DELETE FROM [dbo].[tblHotel]
GO

-- Drop the 'tblHotel_DeleteAdHoc' procedure if it already exists.
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'tblHotel_DeleteAdHoc') AND type='P')
	DROP PROCEDURE [tblHotel_DeleteAdHoc]
GO

-- Deletes records from the 'tblHotel' table that match the supplied where clause.
CREATE PROCEDURE [tblHotel_DeleteAdHoc]
	@where nvarchar(4000) = ''
AS
	IF @where <> '' 
		SET @where = ' WHERE ' + @where 

	execute('DELETE
		FROM [dbo].[tblHotel]' +	
		@where)	
GO

