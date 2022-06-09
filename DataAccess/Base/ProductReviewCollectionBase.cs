
// <fileinfo name="Base\ProductReviewCollectionBase.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" >Smc SaleFrame1.0</generator>
// </fileinfo>


using System;
using System.Data;
using DbObj;


namespace Base
{

/// <summary>
/// The base class for <see cref="ProductReviewCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductReviewCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductReviewCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string ProductReview_IDColumnName  = "ProductReview_ID";
	public const string ProductInfo_IDColumnName  = "ProductInfo_ID";
	public const string FullNameColumnName  = "FullName";
	public const string TitleColumnName  = "Title";
	public const string DescriptionColumnName  = "Description";
	public const string StarColumnName  = "Star";
	public const string StatusColumnName  = "Status";
	public const string ApprovedColumnName  = "Approved";
	public const string ApprovedUserColumnName  = "ApprovedUser";
	public const string ApprovedDateColumnName  = "ApprovedDate";
	public const string CreateDateColumnName  = "CreateDate";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public ProductReviewCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "ProductReview";
	}

	public ProductReviewCollectionBase() : base()
	{
		this.TABLENAME = "ProductReview";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>ProductReview</c> table.
	/// </summary>
	/// <returns>An array of <see cref="ProductReviewRow"/> objects.</returns>
	public virtual ProductReviewRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>ProductReview</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	public virtual DataTable GetAllAsDataTable()
	{	
		string LOCATION = "GetAllAsDataTable()";
		try
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		}
	}

	/// <summary>
	/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
	/// to retrieve all records from the <c>ProductReview</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("ProductReview_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="ProductReviewRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="ProductReviewRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public ProductReviewRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			ProductReviewRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			if (0 == rows.Length)
				return null;
			return rows[0];
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets an array of <see cref="ProductReviewRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="ProductReviewRow"/> objects.</returns>
	public ProductReviewRow[] GetAsArray(string whereSql, string orderBySql)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql)";
		IDataReader reader = null;
		try
		{
			reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql));
			return MapRecords(reader);
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			if(reader != null)
				reader.Dispose();
            		_db.Dispose();
		}
	}

	/// <summary>
	/// Gets an array of <see cref="ProductReviewRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example:
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <param name="startIndex">The index of the first record to return.</param>
	/// <param name="length">The number of records to return.</param>
	/// <param name="totalRecordCount">A reference parameter that returns the total number 
	/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
	/// <returns>An array of <see cref="ProductReviewRow"/> objects.</returns>
	public virtual ProductReviewRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			ProductReviewRow[] rows = MapRecords(reader);
			reader.Close();
			System.Data.SqlClient.SqlParameter p = (System.Data.SqlClient.SqlParameter)(cmd.Parameters["@rows"]);
			totalRecordCount = (int)p.Value;
			return rows;
		}
		catch(Exception ex)
		{
			throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			reader.Dispose();
			cmd.Dispose();
			_db.Dispose();
		}
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	public DataTable GetAsDataTable(string whereSql, string orderBySql)
	{
		string LOCATION = "GetAsDataTable(string whereSql, string orderBySql)";
		IDataReader reader = null;
		try
		{
			reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql));
			return MapRecordsToDataTable(reader);
		}
		catch(Exception ex)
		{
			throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			reader.Dispose();
            		_db.Dispose();
		}
		
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
	/// <param name="startIndex">The index of the first record to return.</param>
	/// <param name="length">The number of records to return.</param>
	/// <param name="totalRecordCount">A reference parameter that returns the total number 
	/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	public virtual DataTable GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			DataTable table = MapRecordsToDataTable(reader);
			reader.Close();
			System.Data.SqlClient.SqlParameter p = (System.Data.SqlClient.SqlParameter)(cmd.Parameters["@rows"]);
			totalRecordCount = (int)p.Value;
			return table;
		}
		catch(Exception ex)
		{

		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			reader.Dispose();
			cmd.Dispose();
			_db.Dispose();
		}
	}

	/// <summary>
	/// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
	{
		string LOCATION = "CreateGetCommand(string whereSql, string orderBySql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("ProductReview_GetAdHoc", CommandType.StoredProcedure);
			_db.AddParameter(cmd, "where", DbType.String, whereSql);
			_db.AddParameter(cmd, "orderby", DbType.String, orderBySql);
			return cmd;
		}
        	catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
	/// <param name="startIndex">The index of the first record to return.</param>
	/// <param name="length">The number of records to return.</param>		
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql, int startIndex, int length)
	{
		string LOCATION = "CreateGetCommand(string whereSql, string orderBySql, int startIndex, int length)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("ProductReview_GetPageAdHoc", CommandType.StoredProcedure);
				
			_db.AddParameter(cmd, "where", DbType.String, whereSql);
			_db.AddParameter(cmd, "orderby", DbType.String, orderBySql);
			_db.AddParameter(cmd, "startIndex", DbType.Int32, startIndex + 1);
			_db.AddParameter(cmd, "length", DbType.Int32, length);

			IDbDataParameter parameter = _db.AddParameter(cmd, "rows", DbType.Int32, -1);
			parameter.Direction = ParameterDirection.InputOutput;
						
			return cmd;
		}
        	catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}
		

	/// <summary>
	/// Gets <see cref="ProductReviewRow"/> by the primary key.
	/// </summary>
	/// <param name="productReview_ID">The <c>ProductReview_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductReviewRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual ProductReviewRow GetByPrimaryKey(int productReview_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productReview_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("ProductReview_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "ProductReview_ID", productReview_ID);
			ProductReviewRow[] tempArray = MapRecords(cmd);
			if( 0 == tempArray.Length)
				return null;
		
			return tempArray[0];
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}



	/// <summary>
	/// Adds a new record into the <c>ProductReview</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductReviewRow"/> object to be inserted.</param>
	public virtual void Insert(ProductReviewRow value)
	{
		string LOCATION = "Insert(ProductReviewRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductReview_Insert", CommandType.StoredProcedure);
					// ProductInfo_ID
			if (value.IsProductInfo_IDNull)
				AddParameter(cmd, "ProductInfo_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductInfo_ID", value.ProductInfo_ID);
			
				// FullName
			if (value.IsFullNameNull )
				AddParameter(cmd, "FullName", DBNull.Value);
			else
				AddParameter(cmd, "FullName", value.FullName);
			
				// Title
			if (value.IsTitleNull )
				AddParameter(cmd, "Title", DBNull.Value);
			else
				AddParameter(cmd, "Title", value.Title);
			
				// Description
			if (value.IsDescriptionNull )
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
			
				// Star
			if (value.IsStarNull)
				AddParameter(cmd, "Star", DBNull.Value);
			else
				AddParameter(cmd, "Star", value.Star);
			
				// Status
			if (value.IsStatusNull)
				AddParameter(cmd, "Status", DBNull.Value);
			else
				AddParameter(cmd, "Status", value.Status);
			
				// Approved
			if (value.IsApprovedNull)
				AddParameter(cmd, "Approved", DBNull.Value);
			else
				AddParameter(cmd, "Approved", value.Approved);
			
				// ApprovedUser
			if (value.IsApprovedUserNull)
				AddParameter(cmd, "ApprovedUser", DBNull.Value);
			else
				AddParameter(cmd, "ApprovedUser", value.ApprovedUser);
			
				// ApprovedDate
			if (value.IsApprovedDateNull)
				AddParameter(cmd, "ApprovedDate", DBNull.Value);
			else
				AddParameter(cmd, "ApprovedDate", value.ApprovedDate);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
						value.ProductReview_ID = Convert.ToInt32(cmd.ExecuteScalar());
			}
		catch(Exception ex)
		{
			throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
        	{
            		_db.Dispose();
        	}
	}

	/// <summary>
	/// Updates a record in the <c>ProductReview</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductReviewRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(ProductReviewRow value)
	{	
		string LOCATION = "Update(ProductReviewRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductReview_Update", CommandType.StoredProcedure);
					// ProductInfo_ID
			if (value.IsProductInfo_IDNull)
				AddParameter(cmd, "ProductInfo_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductInfo_ID", value.ProductInfo_ID);
			
				// FullName
			if (value.IsFullNameNull)
				AddParameter(cmd, "FullName", DBNull.Value);
			else
				AddParameter(cmd, "FullName", value.FullName);
				// Title
			if (value.IsTitleNull)
				AddParameter(cmd, "Title", DBNull.Value);
			else
				AddParameter(cmd, "Title", value.Title);
				// Description
			if (value.IsDescriptionNull)
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
				// Star
			if (value.IsStarNull)
				AddParameter(cmd, "Star", DBNull.Value);
			else
				AddParameter(cmd, "Star", value.Star);
			
				// Status
			if (value.IsStatusNull)
				AddParameter(cmd, "Status", DBNull.Value);
			else
				AddParameter(cmd, "Status", value.Status);
			
				// Approved
			if (value.IsApprovedNull)
				AddParameter(cmd, "Approved", DBNull.Value);
			else
				AddParameter(cmd, "Approved", value.Approved);
			
				// ApprovedUser
			if (value.IsApprovedUserNull)
				AddParameter(cmd, "ApprovedUser", DBNull.Value);
			else
				AddParameter(cmd, "ApprovedUser", value.ApprovedUser);
			
				// ApprovedDate
			if (value.IsApprovedDateNull)
				AddParameter(cmd, "ApprovedDate", DBNull.Value);
			else
				AddParameter(cmd, "ApprovedDate", value.ApprovedDate);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
					AddParameter(cmd, "ProductReview_ID", value.ProductReview_ID);
				return 0 != cmd.ExecuteNonQuery();
	}
        catch(Exception ex)
	{
            throw new Exceptions.DatabaseException(LOCATION, ex);
        }		
	finally
        {
            _db.Dispose();
        }
	}

		/// <summary>
		/// Inserts or Updates a record in the <c>ProductReview</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="ProductReviewRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(ProductReviewRow value)
		{
			string LOCATION = "Save(ProductReviewRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("ProductReview_Save",CommandType.StoredProcedure);
					// ProductInfo_ID
				if (value.IsProductInfo_IDNull)
					AddParameter(cmd, "ProductInfo_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductInfo_ID", (object)(value.ProductInfo_ID));
				
					// FullName
				if (value.IsFullNameNull)
					AddParameter(cmd, "FullName", DBNull.Value);
				else
					AddParameter(cmd, "FullName", (object)(value.FullName));
				
					// Title
				if (value.IsTitleNull)
					AddParameter(cmd, "Title", DBNull.Value);
				else
					AddParameter(cmd, "Title", (object)(value.Title));
				
					// Description
				if (value.IsDescriptionNull)
					AddParameter(cmd, "Description", DBNull.Value);
				else
					AddParameter(cmd, "Description", (object)(value.Description));
				
					// Star
				if (value.IsStarNull)
					AddParameter(cmd, "Star", DBNull.Value);
				else
					AddParameter(cmd, "Star", (object)(value.Star));
				
					// Status
				if (value.IsStatusNull)
					AddParameter(cmd, "Status", DBNull.Value);
				else
					AddParameter(cmd, "Status", (object)(value.Status));
				
					// Approved
				if (value.IsApprovedNull)
					AddParameter(cmd, "Approved", DBNull.Value);
				else
					AddParameter(cmd, "Approved", (object)(value.Approved));
				
					// ApprovedUser
				if (value.IsApprovedUserNull)
					AddParameter(cmd, "ApprovedUser", DBNull.Value);
				else
					AddParameter(cmd, "ApprovedUser", (object)(value.ApprovedUser));
				
					// ApprovedDate
				if (value.IsApprovedDateNull)
					AddParameter(cmd, "ApprovedDate", DBNull.Value);
				else
					AddParameter(cmd, "ApprovedDate", (object)(value.ApprovedDate));
				
					// CreateDate
				if (value.IsCreateDateNull)
					AddParameter(cmd, "CreateDate", DBNull.Value);
				else
					AddParameter(cmd, "CreateDate", (object)(value.CreateDate));
				
						AddParameter(cmd, "ProductReview_ID", value.ProductReview_ID);
						value.ProductReview_ID = Convert.ToInt32(cmd.ExecuteScalar());
			}
            	catch(Exception ex)
		{
	                throw new Exceptions.DatabaseException(LOCATION, ex);
            	}
		finally
        	{
            		_db.Dispose();
        	}
	}

	
	public virtual void Update(DataTable table, bool acceptChanges)
	{
		string LOCATION = "Update(DataTable table, bool acceptChanges)";
		try
		{
			DataRowCollection rows = table.Rows;
			for(int i = rows.Count - 1; i >= 0; i--)
			{
				DataRow row = rows[i];
				switch(row.RowState)
				{
					case DataRowState.Added:
						Insert(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;

					case DataRowState.Deleted:
						// Temporary reject changes to be able to access to the PK column(s)
						row.RejectChanges();
						try
						{
							DeleteByPrimaryKey((int)row["ProductReview_ID"]);
						}
						finally
						{
							row.Delete();
						}
						if(acceptChanges)
							row.AcceptChanges();
						break;
						
					case DataRowState.Modified:
						Update(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;
				}
			}
		}
        	catch(Exception ex)
		{
            		throw new Exceptions.DatabaseException(LOCATION, ex);
		}
        }

	/// <summary>
	/// Deletes the specified object from the <c>ProductReview</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductReviewRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(ProductReviewRow value)
	{
		return DeleteByPrimaryKey(value.ProductReview_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>ProductReview</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="productReview_ID">The <c>ProductReview_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int productReview_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productReview_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductReview_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "ProductReview_ID", productReview_ID);
				return (0 < cmd.ExecuteNonQuery());
	}
        catch(Exception ex)
	{
            throw new Exceptions.DatabaseException(LOCATION, ex);
        }	
	finally
        {
            _db.Dispose();
        }	
}

	/// <summary>
	/// Deletes <c>ProductReview</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>The number of deleted records.</returns>
	public int Delete(string whereSql)
	{
		string LOCATION = "Delete(string whereSql)";
		try
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}
		catch(Exception ex)
		{
			throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
        	{
            		_db.Dispose();
        	}
	}

	/// <summary>
	/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used 
	/// to delete <c>ProductReview</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("ProductReview_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>ProductReview</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("ProductReview_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
			}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 
		finally
        	{
            		_db.Dispose();
        	}
        }

	/// <summary>
	/// Reads data using the specified command and returns 
	/// an array of mapped objects.
	/// </summary>
	/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
	/// <returns>An array of <see cref="ProductReviewRow"/> objects.</returns>
	protected ProductReviewRow[] MapRecords(IDbCommand command)
	{
		string LOCATION = "MapRecords(IDbCommand command)";
		IDataReader reader = _db.ExecuteReader(command);
		try
		{
			return MapRecords(reader);
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			reader.Dispose();
		        _db.Dispose();
        		
		}
	}

	/// <summary>
	/// Reads data from the provided data reader and returns 
	/// an array of mapped objects.
	/// </summary>
	/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
	/// <returns>An array of <see cref="ProductReviewRow"/> objects.</returns>
	protected ProductReviewRow[] MapRecords(IDataReader reader)
	{
		int totalRecordCount = -1;
		return MapRecords(reader, 0, int.MaxValue,ref totalRecordCount);
	}

	/// <summary>
	/// Reads data from the provided data reader and returns 
	/// an array of mapped objects.
	/// </summary>
	/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
	/// <param name="startIndex">The index of the first record to map.</param>
	/// <param name="length">The number of records to map.</param>
	/// <param name="totalRecordCount">A reference parameter that returns the total number 
	/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
	/// <returns>An array of <see cref="ProductReviewRow"/> objects.</returns>
	protected virtual ProductReviewRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// ProductReview_ID
		int productReview_IDColumnIndex = reader.GetOrdinal("ProductReview_ID");
		// ProductInfo_ID
		int productInfo_IDColumnIndex = reader.GetOrdinal("ProductInfo_ID");
		// FullName
		int fullNameColumnIndex = reader.GetOrdinal("FullName");
		// Title
		int titleColumnIndex = reader.GetOrdinal("Title");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// Star
		int starColumnIndex = reader.GetOrdinal("Star");
		// Status
		int statusColumnIndex = reader.GetOrdinal("Status");
		// Approved
		int approvedColumnIndex = reader.GetOrdinal("Approved");
		// ApprovedUser
		int approvedUserColumnIndex = reader.GetOrdinal("ApprovedUser");
		// ApprovedDate
		int approvedDateColumnIndex = reader.GetOrdinal("ApprovedDate");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				ProductReviewRow record = new ProductReviewRow();
				recordList.Add(record);

					record.ProductReview_ID = Convert.ToInt32(reader.GetValue(productReview_IDColumnIndex));
					if(!reader.IsDBNull(productInfo_IDColumnIndex))
						record.ProductInfo_ID = Convert.ToInt32(reader.GetValue(productInfo_IDColumnIndex));
					if(!reader.IsDBNull(fullNameColumnIndex))
						record.FullName = Convert.ToString(reader.GetValue(fullNameColumnIndex));
					if(!reader.IsDBNull(titleColumnIndex))
						record.Title = Convert.ToString(reader.GetValue(titleColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(starColumnIndex))
						record.Star = Convert.ToInt32(reader.GetValue(starColumnIndex));
					if(!reader.IsDBNull(statusColumnIndex))
						record.Status = Convert.ToInt32(reader.GetValue(statusColumnIndex));
					if(!reader.IsDBNull(approvedColumnIndex))
						record.Approved = Convert.ToInt32(reader.GetValue(approvedColumnIndex));
					if(!reader.IsDBNull(approvedUserColumnIndex))
						record.ApprovedUser = reader.GetGuid(approvedUserColumnIndex);
					if(!reader.IsDBNull(approvedDateColumnIndex))
						record.ApprovedDate = Convert.ToDateTime(reader.GetValue(approvedDateColumnIndex));
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (ProductReviewRow[])(recordList.ToArray(typeof(ProductReviewRow)));
	}

	/// <summary>
	/// Reads data using the specified command and returns 
	/// a filled <see cref="System.Data.DataTable"/> object.
	/// </summary>
	/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected DataTable MapRecordsToDataTable(IDbCommand command)
	{
		string LOCATION = "MapRecordsToDataTable(IDbCommand command)";
		IDataReader reader = _db.ExecuteReader(command);
		try
		{
			return MapRecordsToDataTable(reader);
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			reader.Dispose();
			_db.Dispose();
		}
	}
	
	/// <summary>
	/// Reads data from the provided data reader and returns 
	/// a filled <see cref="System.Data.DataTable"/> object.
	/// </summary>
	/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected DataTable MapRecordsToDataTable(IDataReader reader)
	{
		int totalRecordCount = 0;
		return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
	}
	
	/// <summary>
	/// Reads data from the provided data reader and returns 
	/// a filled <see cref="System.Data.DataTable"/> object.
	/// </summary>
	/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
	/// <param name="startIndex">The index of the first record to read.</param>
	/// <param name="length">The number of records to read.</param>
	/// <param name="totalRecordCount">A reference parameter that returns the total number 
	/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable MapRecordsToDataTable(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "MapRecordsToDataTable(reader,startIndex,length,ref totalRecordCount)";
		if(0 > startIndex)
			throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
		if(0 > length)
			throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");
		int columnCount = reader.FieldCount;
		int ri = -startIndex;
		
		DataTable dataTable = CreateDataTable();
		dataTable.BeginLoadData();
		object[] values = new object[columnCount];
		
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				reader.GetValues(values);
				dataTable.LoadDataRow(values, true);
				if(ri == length && 0 != totalRecordCount)
					break;
			}
		}
		dataTable.EndLoadData();

		if( 0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return dataTable;
	}

	/// <summary>
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="ProductReviewRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="ProductReviewRow"/> object.</returns>
	protected virtual ProductReviewRow MapRow(DataRow row)
	{
		string LOCATION = "ProductReviewRow MapRow(DataRow row)";
		ProductReviewRow mappedObject = new ProductReviewRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "ProductReview_ID"
		dataColumn = dataTable.Columns["ProductReview_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductReview_ID = (int)(row[dataColumn]);
		// Column "ProductInfo_ID"
		dataColumn = dataTable.Columns["ProductInfo_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductInfo_ID = (int)(row[dataColumn]);
		// Column "FullName"
		dataColumn = dataTable.Columns["FullName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FullName = (string)(row[dataColumn]);
		// Column "Title"
		dataColumn = dataTable.Columns["Title"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Title = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "Star"
		dataColumn = dataTable.Columns["Star"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Star = (int)(row[dataColumn]);
		// Column "Status"
		dataColumn = dataTable.Columns["Status"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Status = (int)(row[dataColumn]);
		// Column "Approved"
		dataColumn = dataTable.Columns["Approved"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Approved = (int)(row[dataColumn]);
		// Column "ApprovedUser"
		dataColumn = dataTable.Columns["ApprovedUser"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ApprovedUser = (System.Guid)(row[dataColumn]);
		// Column "ApprovedDate"
		dataColumn = dataTable.Columns["ApprovedDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ApprovedDate = (System.DateTime)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>ProductReview</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "ProductReview";
		DataColumn dataColumn;
		// Create the "ProductReview_ID" column
		dataColumn = dataTable.Columns.Add("ProductReview_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "ProductInfo_ID" column
		dataColumn = dataTable.Columns.Add("ProductInfo_ID", typeof(int));
		// Create the "FullName" column
		dataColumn = dataTable.Columns.Add("FullName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Title" column
		dataColumn = dataTable.Columns.Add("Title", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Star" column
		dataColumn = dataTable.Columns.Add("Star", typeof(int));
		// Create the "Status" column
		dataColumn = dataTable.Columns.Add("Status", typeof(int));
		// Create the "Approved" column
		dataColumn = dataTable.Columns.Add("Approved", typeof(int));
		// Create the "ApprovedUser" column
		dataColumn = dataTable.Columns.Add("ApprovedUser", typeof(System.Guid));
		// Create the "ApprovedDate" column
		dataColumn = dataTable.Columns.Add("ApprovedDate", typeof(System.DateTime));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		return dataTable;
	}
	
	/// <summary>
	/// Adds a new parameter to the specified command.
	/// </summary>
	/// <param name="cmd">The <see cref="System.Data.IDbCommand"/> object to add the parameter to.</param>
	/// <param name="paramName">The name of the parameter.</param>
	/// <param name="value">The value of the parameter.</param>
	/// <returns>A reference to the added parameter.</returns>
	protected virtual IDbDataParameter AddParameter(IDbCommand cmd, String paramName, object value)
	{
		string LOCATION = "AddParameter(IDbCommand cmd, String paramName, object value)";
		IDbDataParameter parameter;
		switch(paramName)
		{
			case "ProductReview_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductInfo_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "FullName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Title":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Star":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Status":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Approved":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ApprovedUser":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "ApprovedDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="ProductReviewRow"/> by the primary key.
	/// </summary>
	/// <param name="productReview_ID">The <c>ProductReview_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductReviewRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int productReview_ID)
	{
		string LOCATION = "Exist(int productReview_ID)";
		IDbCommand cmd = _db.CreateCommand("ProductReview_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "ProductReview_ID", productReview_ID);
		ProductReviewRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




