
// <fileinfo name="Base\ProductPackageHistoryCollectionBase.cs">
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
/// The base class for <see cref="ProductPackageHistoryCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductPackageHistoryCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductPackageHistoryCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string ProductPackageHistory_IDColumnName  = "ProductPackageHistory_ID";
	public const string ProductPackage_IDColumnName  = "ProductPackage_ID";
	public const string SSCC_LogisticColumnName  = "SSCC_Logistic";
	public const string GLN_ReceiveColumnName  = "GLN_Receive";
	public const string GLN_FromColumnName  = "GLN_From";
	public const string GLN_ToColumnName  = "GLN_To";
	public const string DeliveryDateColumnName  = "DeliveryDate";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public ProductPackageHistoryCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "ProductPackageHistory";
	}

	public ProductPackageHistoryCollectionBase() : base()
	{
		this.TABLENAME = "ProductPackageHistory";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>ProductPackageHistory</c> table.
	/// </summary>
	/// <returns>An array of <see cref="ProductPackageHistoryRow"/> objects.</returns>
	public virtual ProductPackageHistoryRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>ProductPackageHistory</c> table.
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
	/// to retrieve all records from the <c>ProductPackageHistory</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("ProductPackageHistory_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="ProductPackageHistoryRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="ProductPackageHistoryRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public ProductPackageHistoryRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			ProductPackageHistoryRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="ProductPackageHistoryRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="ProductPackageHistoryRow"/> objects.</returns>
	public ProductPackageHistoryRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="ProductPackageHistoryRow"/> objects that 
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
	/// <returns>An array of <see cref="ProductPackageHistoryRow"/> objects.</returns>
	public virtual ProductPackageHistoryRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			ProductPackageHistoryRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("ProductPackageHistory_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("ProductPackageHistory_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="ProductPackageHistoryRow"/> by the primary key.
	/// </summary>
	/// <param name="productPackageHistory_ID">The <c>ProductPackageHistory_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductPackageHistoryRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual ProductPackageHistoryRow GetByPrimaryKey(int productPackageHistory_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productPackageHistory_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("ProductPackageHistory_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "ProductPackageHistory_ID", productPackageHistory_ID);
			ProductPackageHistoryRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>ProductPackageHistory</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductPackageHistoryRow"/> object to be inserted.</param>
	public virtual void Insert(ProductPackageHistoryRow value)
	{
		string LOCATION = "Insert(ProductPackageHistoryRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductPackageHistory_Insert", CommandType.StoredProcedure);
					// ProductPackage_ID
			if (value.IsProductPackage_IDNull)
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
			
				// SSCC_Logistic
			if (value.IsSSCC_LogisticNull )
				AddParameter(cmd, "SSCC_Logistic", DBNull.Value);
			else
				AddParameter(cmd, "SSCC_Logistic", value.SSCC_Logistic);
			
				// GLN_Receive
			if (value.IsGLN_ReceiveNull )
				AddParameter(cmd, "GLN_Receive", DBNull.Value);
			else
				AddParameter(cmd, "GLN_Receive", value.GLN_Receive);
			
				// GLN_From
			if (value.IsGLN_FromNull )
				AddParameter(cmd, "GLN_From", DBNull.Value);
			else
				AddParameter(cmd, "GLN_From", value.GLN_From);
			
				// GLN_To
			if (value.IsGLN_ToNull )
				AddParameter(cmd, "GLN_To", DBNull.Value);
			else
				AddParameter(cmd, "GLN_To", value.GLN_To);
			
				// DeliveryDate
			if (value.IsDeliveryDateNull)
				AddParameter(cmd, "DeliveryDate", DBNull.Value);
			else
				AddParameter(cmd, "DeliveryDate", value.DeliveryDate);
			
				// CreateBy
			if (value.IsCreateByNull)
				AddParameter(cmd, "CreateBy", DBNull.Value);
			else
				AddParameter(cmd, "CreateBy", value.CreateBy);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// LastEditBy
			if (value.IsLastEditByNull)
				AddParameter(cmd, "LastEditBy", DBNull.Value);
			else
				AddParameter(cmd, "LastEditBy", value.LastEditBy);
			
				// LastEditDate
			if (value.IsLastEditDateNull)
				AddParameter(cmd, "LastEditDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditDate", value.LastEditDate);
			
						value.ProductPackageHistory_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>ProductPackageHistory</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductPackageHistoryRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(ProductPackageHistoryRow value)
	{	
		string LOCATION = "Update(ProductPackageHistoryRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductPackageHistory_Update", CommandType.StoredProcedure);
					// ProductPackage_ID
			if (value.IsProductPackage_IDNull)
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
			
				// SSCC_Logistic
			if (value.IsSSCC_LogisticNull)
				AddParameter(cmd, "SSCC_Logistic", DBNull.Value);
			else
				AddParameter(cmd, "SSCC_Logistic", value.SSCC_Logistic);
				// GLN_Receive
			if (value.IsGLN_ReceiveNull)
				AddParameter(cmd, "GLN_Receive", DBNull.Value);
			else
				AddParameter(cmd, "GLN_Receive", value.GLN_Receive);
				// GLN_From
			if (value.IsGLN_FromNull)
				AddParameter(cmd, "GLN_From", DBNull.Value);
			else
				AddParameter(cmd, "GLN_From", value.GLN_From);
				// GLN_To
			if (value.IsGLN_ToNull)
				AddParameter(cmd, "GLN_To", DBNull.Value);
			else
				AddParameter(cmd, "GLN_To", value.GLN_To);
				// DeliveryDate
			if (value.IsDeliveryDateNull)
				AddParameter(cmd, "DeliveryDate", DBNull.Value);
			else
				AddParameter(cmd, "DeliveryDate", value.DeliveryDate);
			
				// CreateBy
			if (value.IsCreateByNull)
				AddParameter(cmd, "CreateBy", DBNull.Value);
			else
				AddParameter(cmd, "CreateBy", value.CreateBy);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// LastEditBy
			if (value.IsLastEditByNull)
				AddParameter(cmd, "LastEditBy", DBNull.Value);
			else
				AddParameter(cmd, "LastEditBy", value.LastEditBy);
			
				// LastEditDate
			if (value.IsLastEditDateNull)
				AddParameter(cmd, "LastEditDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditDate", value.LastEditDate);
			
					AddParameter(cmd, "ProductPackageHistory_ID", value.ProductPackageHistory_ID);
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
		/// Inserts or Updates a record in the <c>ProductPackageHistory</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="ProductPackageHistoryRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(ProductPackageHistoryRow value)
		{
			string LOCATION = "Save(ProductPackageHistoryRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("ProductPackageHistory_Save",CommandType.StoredProcedure);
					// ProductPackage_ID
				if (value.IsProductPackage_IDNull)
					AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductPackage_ID", (object)(value.ProductPackage_ID));
				
					// SSCC_Logistic
				if (value.IsSSCC_LogisticNull)
					AddParameter(cmd, "SSCC_Logistic", DBNull.Value);
				else
					AddParameter(cmd, "SSCC_Logistic", (object)(value.SSCC_Logistic));
				
					// GLN_Receive
				if (value.IsGLN_ReceiveNull)
					AddParameter(cmd, "GLN_Receive", DBNull.Value);
				else
					AddParameter(cmd, "GLN_Receive", (object)(value.GLN_Receive));
				
					// GLN_From
				if (value.IsGLN_FromNull)
					AddParameter(cmd, "GLN_From", DBNull.Value);
				else
					AddParameter(cmd, "GLN_From", (object)(value.GLN_From));
				
					// GLN_To
				if (value.IsGLN_ToNull)
					AddParameter(cmd, "GLN_To", DBNull.Value);
				else
					AddParameter(cmd, "GLN_To", (object)(value.GLN_To));
				
					// DeliveryDate
				if (value.IsDeliveryDateNull)
					AddParameter(cmd, "DeliveryDate", DBNull.Value);
				else
					AddParameter(cmd, "DeliveryDate", (object)(value.DeliveryDate));
				
					// CreateBy
				if (value.IsCreateByNull)
					AddParameter(cmd, "CreateBy", DBNull.Value);
				else
					AddParameter(cmd, "CreateBy", (object)(value.CreateBy));
				
					// CreateDate
				if (value.IsCreateDateNull)
					AddParameter(cmd, "CreateDate", DBNull.Value);
				else
					AddParameter(cmd, "CreateDate", (object)(value.CreateDate));
				
					// LastEditBy
				if (value.IsLastEditByNull)
					AddParameter(cmd, "LastEditBy", DBNull.Value);
				else
					AddParameter(cmd, "LastEditBy", (object)(value.LastEditBy));
				
					// LastEditDate
				if (value.IsLastEditDateNull)
					AddParameter(cmd, "LastEditDate", DBNull.Value);
				else
					AddParameter(cmd, "LastEditDate", (object)(value.LastEditDate));
				
						AddParameter(cmd, "ProductPackageHistory_ID", value.ProductPackageHistory_ID);
						value.ProductPackageHistory_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["ProductPackageHistory_ID"]);
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
	/// Deletes the specified object from the <c>ProductPackageHistory</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductPackageHistoryRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(ProductPackageHistoryRow value)
	{
		return DeleteByPrimaryKey(value.ProductPackageHistory_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>ProductPackageHistory</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="productPackageHistory_ID">The <c>ProductPackageHistory_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int productPackageHistory_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productPackageHistory_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductPackageHistory_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "ProductPackageHistory_ID", productPackageHistory_ID);
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
	/// Deletes <c>ProductPackageHistory</c> records that match the specified criteria.
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
	/// to delete <c>ProductPackageHistory</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("ProductPackageHistory_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>ProductPackageHistory</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("ProductPackageHistory_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="ProductPackageHistoryRow"/> objects.</returns>
	protected ProductPackageHistoryRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="ProductPackageHistoryRow"/> objects.</returns>
	protected ProductPackageHistoryRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="ProductPackageHistoryRow"/> objects.</returns>
	protected virtual ProductPackageHistoryRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// ProductPackageHistory_ID
		int productPackageHistory_IDColumnIndex = reader.GetOrdinal("ProductPackageHistory_ID");
		// ProductPackage_ID
		int productPackage_IDColumnIndex = reader.GetOrdinal("ProductPackage_ID");
		// SSCC_Logistic
		int sSCC_LogisticColumnIndex = reader.GetOrdinal("SSCC_Logistic");
		// GLN_Receive
		int gLN_ReceiveColumnIndex = reader.GetOrdinal("GLN_Receive");
		// GLN_From
		int gLN_FromColumnIndex = reader.GetOrdinal("GLN_From");
		// GLN_To
		int gLN_ToColumnIndex = reader.GetOrdinal("GLN_To");
		// DeliveryDate
		int deliveryDateColumnIndex = reader.GetOrdinal("DeliveryDate");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				ProductPackageHistoryRow record = new ProductPackageHistoryRow();
				recordList.Add(record);

					record.ProductPackageHistory_ID = Convert.ToInt32(reader.GetValue(productPackageHistory_IDColumnIndex));
					if(!reader.IsDBNull(productPackage_IDColumnIndex))
						record.ProductPackage_ID = Convert.ToInt32(reader.GetValue(productPackage_IDColumnIndex));
					if(!reader.IsDBNull(sSCC_LogisticColumnIndex))
						record.SSCC_Logistic = Convert.ToString(reader.GetValue(sSCC_LogisticColumnIndex));
					if(!reader.IsDBNull(gLN_ReceiveColumnIndex))
						record.GLN_Receive = Convert.ToString(reader.GetValue(gLN_ReceiveColumnIndex));
					if(!reader.IsDBNull(gLN_FromColumnIndex))
						record.GLN_From = Convert.ToString(reader.GetValue(gLN_FromColumnIndex));
					if(!reader.IsDBNull(gLN_ToColumnIndex))
						record.GLN_To = Convert.ToString(reader.GetValue(gLN_ToColumnIndex));
					if(!reader.IsDBNull(deliveryDateColumnIndex))
						record.DeliveryDate = Convert.ToDateTime(reader.GetValue(deliveryDateColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (ProductPackageHistoryRow[])(recordList.ToArray(typeof(ProductPackageHistoryRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="ProductPackageHistoryRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="ProductPackageHistoryRow"/> object.</returns>
	protected virtual ProductPackageHistoryRow MapRow(DataRow row)
	{
		string LOCATION = "ProductPackageHistoryRow MapRow(DataRow row)";
		ProductPackageHistoryRow mappedObject = new ProductPackageHistoryRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "ProductPackageHistory_ID"
		dataColumn = dataTable.Columns["ProductPackageHistory_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackageHistory_ID = (int)(row[dataColumn]);
		// Column "ProductPackage_ID"
		dataColumn = dataTable.Columns["ProductPackage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackage_ID = (int)(row[dataColumn]);
		// Column "SSCC_Logistic"
		dataColumn = dataTable.Columns["SSCC_Logistic"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SSCC_Logistic = (string)(row[dataColumn]);
		// Column "GLN_Receive"
		dataColumn = dataTable.Columns["GLN_Receive"];
		if (! row.IsNull(dataColumn) )
			mappedObject.GLN_Receive = (string)(row[dataColumn]);
		// Column "GLN_From"
		dataColumn = dataTable.Columns["GLN_From"];
		if (! row.IsNull(dataColumn) )
			mappedObject.GLN_From = (string)(row[dataColumn]);
		// Column "GLN_To"
		dataColumn = dataTable.Columns["GLN_To"];
		if (! row.IsNull(dataColumn) )
			mappedObject.GLN_To = (string)(row[dataColumn]);
		// Column "DeliveryDate"
		dataColumn = dataTable.Columns["DeliveryDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DeliveryDate = (System.DateTime)(row[dataColumn]);
		// Column "CreateBy"
		dataColumn = dataTable.Columns["CreateBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateBy = (System.Guid)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "LastEditBy"
		dataColumn = dataTable.Columns["LastEditBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditBy = (System.Guid)(row[dataColumn]);
		// Column "LastEditDate"
		dataColumn = dataTable.Columns["LastEditDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditDate = (System.DateTime)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>ProductPackageHistory</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "ProductPackageHistory";
		DataColumn dataColumn;
		// Create the "ProductPackageHistory_ID" column
		dataColumn = dataTable.Columns.Add("ProductPackageHistory_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "ProductPackage_ID" column
		dataColumn = dataTable.Columns.Add("ProductPackage_ID", typeof(int));
		// Create the "SSCC_Logistic" column
		dataColumn = dataTable.Columns.Add("SSCC_Logistic", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "GLN_Receive" column
		dataColumn = dataTable.Columns.Add("GLN_Receive", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "GLN_From" column
		dataColumn = dataTable.Columns.Add("GLN_From", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "GLN_To" column
		dataColumn = dataTable.Columns.Add("GLN_To", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "DeliveryDate" column
		dataColumn = dataTable.Columns.Add("DeliveryDate", typeof(System.DateTime));
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
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
			case "ProductPackageHistory_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductPackage_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "SSCC_Logistic":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "GLN_Receive":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "GLN_From":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "GLN_To":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DeliveryDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "CreateBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "LastEditBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "LastEditDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="ProductPackageHistoryRow"/> by the primary key.
	/// </summary>
	/// <param name="productPackageHistory_ID">The <c>ProductPackageHistory_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductPackageHistoryRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int productPackageHistory_ID)
	{
		string LOCATION = "Exist(int productPackageHistory_ID)";
		IDbCommand cmd = _db.CreateCommand("ProductPackageHistory_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "ProductPackageHistory_ID", productPackageHistory_ID);
		ProductPackageHistoryRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




