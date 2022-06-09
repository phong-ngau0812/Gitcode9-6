
// <fileinfo name="Base\QRCodePackageFragment_ESCollectionBase.cs">
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
/// The base class for <see cref="QRCodePackageFragment_ESCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodePackageFragment_ESCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodePackageFragment_ESCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string QRCodePackageFragment_IDColumnName  = "QRCodePackageFragment_ID";
	public const string QRCodePackage_IDColumnName  = "QRCodePackage_ID";
	public const string SerialNumberStartColumnName  = "SerialNumberStart";
	public const string SerialNumberEndColumnName  = "SerialNumberEnd";
	public const string QRCodeNumberColumnName  = "QRCodeNumber";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public QRCodePackageFragment_ESCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "QRCodePackageFragment_ES";
	}

	public QRCodePackageFragment_ESCollectionBase() : base()
	{
		this.TABLENAME = "QRCodePackageFragment_ES";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>QRCodePackageFragment_ES</c> table.
	/// </summary>
	/// <returns>An array of <see cref="QRCodePackageFragment_ESRow"/> objects.</returns>
	public virtual QRCodePackageFragment_ESRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>QRCodePackageFragment_ES</c> table.
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
	/// to retrieve all records from the <c>QRCodePackageFragment_ES</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("QRCodePackageFragment_ES_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="QRCodePackageFragment_ESRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="QRCodePackageFragment_ESRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public QRCodePackageFragment_ESRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			QRCodePackageFragment_ESRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="QRCodePackageFragment_ESRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="QRCodePackageFragment_ESRow"/> objects.</returns>
	public QRCodePackageFragment_ESRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="QRCodePackageFragment_ESRow"/> objects that 
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
	/// <returns>An array of <see cref="QRCodePackageFragment_ESRow"/> objects.</returns>
	public virtual QRCodePackageFragment_ESRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			QRCodePackageFragment_ESRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("QRCodePackageFragment_ES_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("QRCodePackageFragment_ES_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="QRCodePackageFragment_ESRow"/> by the primary key.
	/// </summary>
	/// <param name="qRCodePackageFragment_ID">The <c>QRCodePackageFragment_ID</c> column value.</param>
	/// <returns>An instance of <see cref="QRCodePackageFragment_ESRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual QRCodePackageFragment_ESRow GetByPrimaryKey(int qRCodePackageFragment_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodePackageFragment_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("QRCodePackageFragment_ES_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "QRCodePackageFragment_ID", qRCodePackageFragment_ID);
			QRCodePackageFragment_ESRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>QRCodePackageFragment_ES</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodePackageFragment_ESRow"/> object to be inserted.</param>
	public virtual void Insert(QRCodePackageFragment_ESRow value)
	{
		string LOCATION = "Insert(QRCodePackageFragment_ESRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodePackageFragment_ES_Insert", CommandType.StoredProcedure);
					// QRCodePackage_ID
			if (value.IsQRCodePackage_IDNull)
				AddParameter(cmd, "QRCodePackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePackage_ID", value.QRCodePackage_ID);
			
				// SerialNumberStart
			if (value.IsSerialNumberStartNull )
				AddParameter(cmd, "SerialNumberStart", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumberStart", value.SerialNumberStart);
			
				// SerialNumberEnd
			if (value.IsSerialNumberEndNull )
				AddParameter(cmd, "SerialNumberEnd", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumberEnd", value.SerialNumberEnd);
			
				// QRCodeNumber
			if (value.IsQRCodeNumberNull)
				AddParameter(cmd, "QRCodeNumber", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeNumber", value.QRCodeNumber);
			
						value.QRCodePackageFragment_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>QRCodePackageFragment_ES</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodePackageFragment_ESRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(QRCodePackageFragment_ESRow value)
	{	
		string LOCATION = "Update(QRCodePackageFragment_ESRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodePackageFragment_ES_Update", CommandType.StoredProcedure);
					// QRCodePackage_ID
			if (value.IsQRCodePackage_IDNull)
				AddParameter(cmd, "QRCodePackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePackage_ID", value.QRCodePackage_ID);
			
				// SerialNumberStart
			if (value.IsSerialNumberStartNull)
				AddParameter(cmd, "SerialNumberStart", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumberStart", value.SerialNumberStart);
				// SerialNumberEnd
			if (value.IsSerialNumberEndNull)
				AddParameter(cmd, "SerialNumberEnd", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumberEnd", value.SerialNumberEnd);
				// QRCodeNumber
			if (value.IsQRCodeNumberNull)
				AddParameter(cmd, "QRCodeNumber", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeNumber", value.QRCodeNumber);
			
					AddParameter(cmd, "QRCodePackageFragment_ID", value.QRCodePackageFragment_ID);
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
		/// Inserts or Updates a record in the <c>QRCodePackageFragment_ES</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="QRCodePackageFragment_ESRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(QRCodePackageFragment_ESRow value)
		{
			string LOCATION = "Save(QRCodePackageFragment_ESRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("QRCodePackageFragment_ES_Save",CommandType.StoredProcedure);
					// QRCodePackage_ID
				if (value.IsQRCodePackage_IDNull)
					AddParameter(cmd, "QRCodePackage_ID", DBNull.Value);
				else
					AddParameter(cmd, "QRCodePackage_ID", (object)(value.QRCodePackage_ID));
				
					// SerialNumberStart
				if (value.IsSerialNumberStartNull)
					AddParameter(cmd, "SerialNumberStart", DBNull.Value);
				else
					AddParameter(cmd, "SerialNumberStart", (object)(value.SerialNumberStart));
				
					// SerialNumberEnd
				if (value.IsSerialNumberEndNull)
					AddParameter(cmd, "SerialNumberEnd", DBNull.Value);
				else
					AddParameter(cmd, "SerialNumberEnd", (object)(value.SerialNumberEnd));
				
					// QRCodeNumber
				if (value.IsQRCodeNumberNull)
					AddParameter(cmd, "QRCodeNumber", DBNull.Value);
				else
					AddParameter(cmd, "QRCodeNumber", (object)(value.QRCodeNumber));
				
						AddParameter(cmd, "QRCodePackageFragment_ID", value.QRCodePackageFragment_ID);
						value.QRCodePackageFragment_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["QRCodePackageFragment_ID"]);
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
	/// Deletes the specified object from the <c>QRCodePackageFragment_ES</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodePackageFragment_ESRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(QRCodePackageFragment_ESRow value)
	{
		return DeleteByPrimaryKey(value.QRCodePackageFragment_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>QRCodePackageFragment_ES</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="qRCodePackageFragment_ID">The <c>QRCodePackageFragment_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int qRCodePackageFragment_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int qRCodePackageFragment_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodePackageFragment_ES_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "QRCodePackageFragment_ID", qRCodePackageFragment_ID);
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
	/// Deletes <c>QRCodePackageFragment_ES</c> records that match the specified criteria.
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
	/// to delete <c>QRCodePackageFragment_ES</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("QRCodePackageFragment_ES_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>QRCodePackageFragment_ES</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("QRCodePackageFragment_ES_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="QRCodePackageFragment_ESRow"/> objects.</returns>
	protected QRCodePackageFragment_ESRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="QRCodePackageFragment_ESRow"/> objects.</returns>
	protected QRCodePackageFragment_ESRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="QRCodePackageFragment_ESRow"/> objects.</returns>
	protected virtual QRCodePackageFragment_ESRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// QRCodePackageFragment_ID
		int qRCodePackageFragment_IDColumnIndex = reader.GetOrdinal("QRCodePackageFragment_ID");
		// QRCodePackage_ID
		int qRCodePackage_IDColumnIndex = reader.GetOrdinal("QRCodePackage_ID");
		// SerialNumberStart
		int serialNumberStartColumnIndex = reader.GetOrdinal("SerialNumberStart");
		// SerialNumberEnd
		int serialNumberEndColumnIndex = reader.GetOrdinal("SerialNumberEnd");
		// QRCodeNumber
		int qRCodeNumberColumnIndex = reader.GetOrdinal("QRCodeNumber");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				QRCodePackageFragment_ESRow record = new QRCodePackageFragment_ESRow();
				recordList.Add(record);

					record.QRCodePackageFragment_ID = Convert.ToInt32(reader.GetValue(qRCodePackageFragment_IDColumnIndex));
					if(!reader.IsDBNull(qRCodePackage_IDColumnIndex))
						record.QRCodePackage_ID = Convert.ToInt32(reader.GetValue(qRCodePackage_IDColumnIndex));
					if(!reader.IsDBNull(serialNumberStartColumnIndex))
						record.SerialNumberStart = Convert.ToString(reader.GetValue(serialNumberStartColumnIndex));
					if(!reader.IsDBNull(serialNumberEndColumnIndex))
						record.SerialNumberEnd = Convert.ToString(reader.GetValue(serialNumberEndColumnIndex));
					if(!reader.IsDBNull(qRCodeNumberColumnIndex))
						record.QRCodeNumber = Convert.ToInt32(reader.GetValue(qRCodeNumberColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (QRCodePackageFragment_ESRow[])(recordList.ToArray(typeof(QRCodePackageFragment_ESRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="QRCodePackageFragment_ESRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="QRCodePackageFragment_ESRow"/> object.</returns>
	protected virtual QRCodePackageFragment_ESRow MapRow(DataRow row)
	{
		string LOCATION = "QRCodePackageFragment_ESRow MapRow(DataRow row)";
		QRCodePackageFragment_ESRow mappedObject = new QRCodePackageFragment_ESRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "QRCodePackageFragment_ID"
		dataColumn = dataTable.Columns["QRCodePackageFragment_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodePackageFragment_ID = (int)(row[dataColumn]);
		// Column "QRCodePackage_ID"
		dataColumn = dataTable.Columns["QRCodePackage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodePackage_ID = (int)(row[dataColumn]);
		// Column "SerialNumberStart"
		dataColumn = dataTable.Columns["SerialNumberStart"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SerialNumberStart = (string)(row[dataColumn]);
		// Column "SerialNumberEnd"
		dataColumn = dataTable.Columns["SerialNumberEnd"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SerialNumberEnd = (string)(row[dataColumn]);
		// Column "QRCodeNumber"
		dataColumn = dataTable.Columns["QRCodeNumber"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeNumber = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>QRCodePackageFragment_ES</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "QRCodePackageFragment_ES";
		DataColumn dataColumn;
		// Create the "QRCodePackageFragment_ID" column
		dataColumn = dataTable.Columns.Add("QRCodePackageFragment_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "QRCodePackage_ID" column
		dataColumn = dataTable.Columns.Add("QRCodePackage_ID", typeof(int));
		// Create the "SerialNumberStart" column
		dataColumn = dataTable.Columns.Add("SerialNumberStart", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "SerialNumberEnd" column
		dataColumn = dataTable.Columns.Add("SerialNumberEnd", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "QRCodeNumber" column
		dataColumn = dataTable.Columns.Add("QRCodeNumber", typeof(int));
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
			case "QRCodePackageFragment_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "QRCodePackage_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "SerialNumberStart":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SerialNumberEnd":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QRCodeNumber":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="QRCodePackageFragment_ESRow"/> by the primary key.
	/// </summary>
	/// <param name="qRCodePackageFragment_ID">The <c>QRCodePackageFragment_ID</c> column value.</param>
	/// <returns>An instance of <see cref="QRCodePackageFragment_ESRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int qRCodePackageFragment_ID)
	{
		string LOCATION = "Exist(int qRCodePackageFragment_ID)";
		IDbCommand cmd = _db.CreateCommand("QRCodePackageFragment_ES_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "QRCodePackageFragment_ID", qRCodePackageFragment_ID);
		QRCodePackageFragment_ESRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




