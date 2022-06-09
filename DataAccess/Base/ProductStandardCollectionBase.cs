
// <fileinfo name="Base\ProductStandardCollectionBase.cs">
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
/// The base class for <see cref="ProductStandardCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductStandardCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductStandardCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string ProductStandard_IDColumnName  = "ProductStandard_ID";
	public const string Product_IDColumnName  = "Product_ID";
	public const string NameColumnName  = "Name";
	public const string CreatedDateColumnName  = "CreatedDate";
	public const string CreatedByColumnName  = "CreatedBy";
	public const string Other1ColumnName  = "other1";
	public const string Other2ColumnName  = "other2";
	public const string Other3ColumnName  = "other3";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public ProductStandardCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "ProductStandard";
	}

	public ProductStandardCollectionBase() : base()
	{
		this.TABLENAME = "ProductStandard";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>ProductStandard</c> table.
	/// </summary>
	/// <returns>An array of <see cref="ProductStandardRow"/> objects.</returns>
	public virtual ProductStandardRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>ProductStandard</c> table.
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
	/// to retrieve all records from the <c>ProductStandard</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("ProductStandard_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="ProductStandardRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="ProductStandardRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public ProductStandardRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			ProductStandardRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="ProductStandardRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="ProductStandardRow"/> objects.</returns>
	public ProductStandardRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="ProductStandardRow"/> objects that 
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
	/// <returns>An array of <see cref="ProductStandardRow"/> objects.</returns>
	public virtual ProductStandardRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			ProductStandardRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("ProductStandard_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("ProductStandard_GetPageAdHoc", CommandType.StoredProcedure);
				
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
		/// Gets <see cref="WarehouseImportRow"/> by the primary key.
		/// </summary>
		/// <param name="productStandard_ID">The <c>productStandard_ID</c> column value.</param>
		/// <returns>An instance of <see cref="WarehouseImportRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual ProductStandardRow GetByPrimaryKey(int productStandard_ID)
		{
			string LOCATION = "GetByPrimaryKey(int ProductStandard_ID)";
			try
			{
				IDbCommand cmd = _db.CreateCommand("ProductStandard_GetByPrimaryKey", CommandType.StoredProcedure);
				AddParameter(cmd, "ProductStandard_ID", productStandard_ID);
				ProductStandardRow[] tempArray = MapRecords(cmd);
				if (0 == tempArray.Length)
					return null;

				return tempArray[0];
			}
			catch (Exception ex)
			{
				throw new Exceptions.DatabaseException(LOCATION, ex);
			}
		}
		/// <summary>
		/// Adds a new record into the <c>ProductStandard</c> table.
		/// </summary>
		/// <param name="value">The <see cref="ProductStandardRow"/> object to be inserted.</param>
		public virtual void Update(ProductStandardRow value)
		{
			string LOCATION = "Update(ProductStandardRow value)";
			try
			{
				IDbCommand cmd = _db.CreateCommand("ProductStandard_Update", CommandType.StoredProcedure);
				// ProductStandard_ID
				if (value.IsProductStandard_IDNull)
					AddParameter(cmd, "ProductStandard_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductStandard_ID", value.ProductStandard_ID);

				// Product_ID
				if (value.IsProduct_IDNull)
					AddParameter(cmd, "Product_ID", DBNull.Value);
				else
					AddParameter(cmd, "Product_ID", value.Product_ID);

				// Name
				if (value.IsNameNull)
					AddParameter(cmd, "Name", DBNull.Value);
				else
					AddParameter(cmd, "Name", value.Name);

				// CreatedDate
				if (value.IsCreatedDateNull)
					AddParameter(cmd, "CreatedDate", DBNull.Value);
				else
					AddParameter(cmd, "CreatedDate", value.CreatedDate);

				// CreatedBy
				if (value.IsCreatedByNull)
					AddParameter(cmd, "CreatedBy", DBNull.Value);
				else
					AddParameter(cmd, "CreatedBy", value.CreatedBy);

				// Other1
				if (value.IsOther1Null)
					AddParameter(cmd, "Other1", DBNull.Value);
				else
					AddParameter(cmd, "Other1", value.Other1);

				// Other2
				if (value.IsOther2Null)
					AddParameter(cmd, "Other2", DBNull.Value);
				else
					AddParameter(cmd, "Other2", value.Other2);

				// Other3
				if (value.IsOther3Null)
					AddParameter(cmd, "Other3", DBNull.Value);
				else
					AddParameter(cmd, "Other3", value.Other3);

				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw new Exceptions.DatabaseException(LOCATION, ex);
			}
			finally
			{
				_db.Dispose();
			}
		}
		/// <summary>
		/// Adds a new record into the <c>ProductStandard</c> table.
		/// </summary>
		/// <param name="value">The <see cref="ProductStandardRow"/> object to be inserted.</param>
		public virtual void Insert(ProductStandardRow value)
	{
		string LOCATION = "Insert(ProductStandardRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductStandard_Insert", CommandType.StoredProcedure);
					// ProductStandard_ID
			if (value.IsProductStandard_IDNull)
				AddParameter(cmd, "ProductStandard_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductStandard_ID", value.ProductStandard_ID);
			
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// Name
			if (value.IsNameNull )
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
			
				// CreatedDate
			if (value.IsCreatedDateNull)
				AddParameter(cmd, "CreatedDate", DBNull.Value);
			else
				AddParameter(cmd, "CreatedDate", value.CreatedDate);
			
				// CreatedBy
			if (value.IsCreatedByNull )
				AddParameter(cmd, "CreatedBy", DBNull.Value);
			else
				AddParameter(cmd, "CreatedBy", value.CreatedBy);
			
				// Other1
			if (value.IsOther1Null )
				AddParameter(cmd, "Other1", DBNull.Value);
			else
				AddParameter(cmd, "Other1", value.Other1);
			
				// Other2
			if (value.IsOther2Null )
				AddParameter(cmd, "Other2", DBNull.Value);
			else
				AddParameter(cmd, "Other2", value.Other2);
			
				// Other3
			if (value.IsOther3Null )
				AddParameter(cmd, "Other3", DBNull.Value);
			else
				AddParameter(cmd, "Other3", value.Other3);
			
					cmd.ExecuteNonQuery();
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
	/// Deletes <c>ProductStandard</c> records that match the specified criteria.
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
	/// to delete <c>ProductStandard</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("ProductStandard_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>ProductStandard</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("ProductStandard_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="ProductStandardRow"/> objects.</returns>
	protected ProductStandardRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="ProductStandardRow"/> objects.</returns>
	protected ProductStandardRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="ProductStandardRow"/> objects.</returns>
	protected virtual ProductStandardRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// ProductStandard_ID
		int productStandard_IDColumnIndex = reader.GetOrdinal("ProductStandard_ID");
		// Product_ID
		int product_IDColumnIndex = reader.GetOrdinal("Product_ID");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// CreatedDate
		int createdDateColumnIndex = reader.GetOrdinal("CreatedDate");
		// CreatedBy
		int createdByColumnIndex = reader.GetOrdinal("CreatedBy");
		// Other1
		int other1ColumnIndex = reader.GetOrdinal("other1");
		// Other2
		int other2ColumnIndex = reader.GetOrdinal("other2");
		// Other3
		int other3ColumnIndex = reader.GetOrdinal("other3");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				ProductStandardRow record = new ProductStandardRow();
				recordList.Add(record);

					if(!reader.IsDBNull(productStandard_IDColumnIndex))
						record.ProductStandard_ID = Convert.ToInt32(reader.GetValue(productStandard_IDColumnIndex));
					if(!reader.IsDBNull(product_IDColumnIndex))
						record.Product_ID = Convert.ToInt32(reader.GetValue(product_IDColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(createdDateColumnIndex))
						record.CreatedDate = Convert.ToDateTime(reader.GetValue(createdDateColumnIndex));
					if(!reader.IsDBNull(createdByColumnIndex))
						record.CreatedBy = Convert.ToString(reader.GetValue(createdByColumnIndex));
					if(!reader.IsDBNull(other1ColumnIndex))
						record.Other1 = Convert.ToString(reader.GetValue(other1ColumnIndex));
					if(!reader.IsDBNull(other2ColumnIndex))
						record.Other2 = Convert.ToString(reader.GetValue(other2ColumnIndex));
					if(!reader.IsDBNull(other3ColumnIndex))
						record.Other3 = Convert.ToString(reader.GetValue(other3ColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (ProductStandardRow[])(recordList.ToArray(typeof(ProductStandardRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="ProductStandardRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="ProductStandardRow"/> object.</returns>
	protected virtual ProductStandardRow MapRow(DataRow row)
	{
		string LOCATION = "ProductStandardRow MapRow(DataRow row)";
		ProductStandardRow mappedObject = new ProductStandardRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "ProductStandard_ID"
		dataColumn = dataTable.Columns["ProductStandard_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductStandard_ID = (int)(row[dataColumn]);
		// Column "Product_ID"
		dataColumn = dataTable.Columns["Product_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Product_ID = (int)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "CreatedDate"
		dataColumn = dataTable.Columns["CreatedDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreatedDate = (System.DateTime)(row[dataColumn]);
		// Column "CreatedBy"
		dataColumn = dataTable.Columns["CreatedBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreatedBy = (string)(row[dataColumn]);
		// Column "Other1"
		dataColumn = dataTable.Columns["Other1"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Other1 = (string)(row[dataColumn]);
		// Column "Other2"
		dataColumn = dataTable.Columns["Other2"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Other2 = (string)(row[dataColumn]);
		// Column "Other3"
		dataColumn = dataTable.Columns["Other3"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Other3 = (string)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>ProductStandard</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "ProductStandard";
		DataColumn dataColumn;
		// Create the "ProductStandard_ID" column
		dataColumn = dataTable.Columns.Add("ProductStandard_ID", typeof(int));
		// Create the "Product_ID" column
		dataColumn = dataTable.Columns.Add("Product_ID", typeof(int));
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "CreatedDate" column
		dataColumn = dataTable.Columns.Add("CreatedDate", typeof(System.DateTime));
		// Create the "CreatedBy" column
		dataColumn = dataTable.Columns.Add("CreatedBy", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Other1" column
		dataColumn = dataTable.Columns.Add("Other1", typeof(string));
		dataColumn.Caption = "other1";
		dataColumn.MaxLength = 100;
		// Create the "Other2" column
		dataColumn = dataTable.Columns.Add("Other2", typeof(string));
		dataColumn.Caption = "other2";
		dataColumn.MaxLength = 100;
		// Create the "Other3" column
		dataColumn = dataTable.Columns.Add("Other3", typeof(string));
		dataColumn.Caption = "other3";
		dataColumn.MaxLength = 100;
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
			case "ProductStandard_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Product_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CreatedDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "CreatedBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Other1":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Other2":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Other3":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="ProductStandardRow"/> by the primary key.
	/// </summary>
	/// <returns>An instance of <see cref="ProductStandardRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist()
	{
		string LOCATION = "Exist()";
		IDbCommand cmd = _db.CreateCommand("ProductStandard_GetByPrimaryKey", CommandType.StoredProcedure);
		ProductStandardRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




