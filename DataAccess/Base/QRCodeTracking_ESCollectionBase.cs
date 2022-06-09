
// <fileinfo name="Base\QRCodeTracking_ESCollectionBase.cs">
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
/// The base class for <see cref="QRCodeTracking_ESCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeTracking_ESCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodeTracking_ESCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string QRCodeTracking_IDColumnName  = "QRCodeTracking_ID";
	public const string QRCodeSerialColumnName  = "QRCodeSerial";
	public const string QRCodeContentColumnName  = "QRCodeContent";
	public const string TypeColumnName  = "Type";
	public const string Product_IDColumnName  = "Product_ID";
	public const string IPColumnName  = "IP";
	public const string LocationColumnName  = "Location";
	public const string TrackingDateColumnName  = "TrackingDate";
	public const string StatusColumnName  = "Status";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public QRCodeTracking_ESCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "QRCodeTracking_ES";
	}

	public QRCodeTracking_ESCollectionBase() : base()
	{
		this.TABLENAME = "QRCodeTracking_ES";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>QRCodeTracking_ES</c> table.
	/// </summary>
	/// <returns>An array of <see cref="QRCodeTracking_ESRow"/> objects.</returns>
	public virtual QRCodeTracking_ESRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>QRCodeTracking_ES</c> table.
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
	/// to retrieve all records from the <c>QRCodeTracking_ES</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("QRCodeTracking_ES_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="QRCodeTracking_ESRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="QRCodeTracking_ESRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public QRCodeTracking_ESRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			QRCodeTracking_ESRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="QRCodeTracking_ESRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="QRCodeTracking_ESRow"/> objects.</returns>
	public QRCodeTracking_ESRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="QRCodeTracking_ESRow"/> objects that 
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
	/// <returns>An array of <see cref="QRCodeTracking_ESRow"/> objects.</returns>
	public virtual QRCodeTracking_ESRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			QRCodeTracking_ESRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("QRCodeTracking_ES_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("QRCodeTracking_ES_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="QRCodeTracking_ESRow"/> by the primary key.
	/// </summary>
	/// <param name="qRCodeTracking_ID">The <c>QRCodeTracking_ID</c> column value.</param>
	/// <returns>An instance of <see cref="QRCodeTracking_ESRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual QRCodeTracking_ESRow GetByPrimaryKey(decimal qRCodeTracking_ID)
	{
		string LOCATION = "GetByPrimaryKey(decimal qRCodeTracking_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("QRCodeTracking_ES_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "QRCodeTracking_ID", qRCodeTracking_ID);
			QRCodeTracking_ESRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>QRCodeTracking_ES</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodeTracking_ESRow"/> object to be inserted.</param>
	public virtual void Insert(QRCodeTracking_ESRow value)
	{
		string LOCATION = "Insert(QRCodeTracking_ESRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodeTracking_ES_Insert", CommandType.StoredProcedure);
					// QRCodeSerial
			if (value.IsQRCodeSerialNull )
				AddParameter(cmd, "QRCodeSerial", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeSerial", value.QRCodeSerial);
			
				// QRCodeContent
			if (value.IsQRCodeContentNull )
				AddParameter(cmd, "QRCodeContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeContent", value.QRCodeContent);
			
				// Type
			if (value.IsTypeNull )
				AddParameter(cmd, "Type", DBNull.Value);
			else
				AddParameter(cmd, "Type", value.Type);
			
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// IP
			if (value.IsIPNull )
				AddParameter(cmd, "IP", DBNull.Value);
			else
				AddParameter(cmd, "IP", value.IP);
			
				// Location
			if (value.IsLocationNull )
				AddParameter(cmd, "Location", DBNull.Value);
			else
				AddParameter(cmd, "Location", value.Location);
			
				// TrackingDate
			if (value.IsTrackingDateNull)
				AddParameter(cmd, "TrackingDate", DBNull.Value);
			else
				AddParameter(cmd, "TrackingDate", value.TrackingDate);
			
				// Status
			if (value.IsStatusNull)
				AddParameter(cmd, "Status", DBNull.Value);
			else
				AddParameter(cmd, "Status", value.Status);
			
						value.QRCodeTracking_ID = Convert.ToDecimal(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>QRCodeTracking_ES</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodeTracking_ESRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(QRCodeTracking_ESRow value)
	{	
		string LOCATION = "Update(QRCodeTracking_ESRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodeTracking_ES_Update", CommandType.StoredProcedure);
					// QRCodeSerial
			if (value.IsQRCodeSerialNull)
				AddParameter(cmd, "QRCodeSerial", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeSerial", value.QRCodeSerial);
				// QRCodeContent
			if (value.IsQRCodeContentNull)
				AddParameter(cmd, "QRCodeContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeContent", value.QRCodeContent);
				// Type
			if (value.IsTypeNull)
				AddParameter(cmd, "Type", DBNull.Value);
			else
				AddParameter(cmd, "Type", value.Type);
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// IP
			if (value.IsIPNull)
				AddParameter(cmd, "IP", DBNull.Value);
			else
				AddParameter(cmd, "IP", value.IP);
				// Location
			if (value.IsLocationNull)
				AddParameter(cmd, "Location", DBNull.Value);
			else
				AddParameter(cmd, "Location", value.Location);
				// TrackingDate
			if (value.IsTrackingDateNull)
				AddParameter(cmd, "TrackingDate", DBNull.Value);
			else
				AddParameter(cmd, "TrackingDate", value.TrackingDate);
			
				// Status
			if (value.IsStatusNull)
				AddParameter(cmd, "Status", DBNull.Value);
			else
				AddParameter(cmd, "Status", value.Status);
			
					AddParameter(cmd, "QRCodeTracking_ID", value.QRCodeTracking_ID);
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
		/// Inserts or Updates a record in the <c>QRCodeTracking_ES</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="QRCodeTracking_ESRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(QRCodeTracking_ESRow value)
		{
			string LOCATION = "Save(QRCodeTracking_ESRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("QRCodeTracking_ES_Save",CommandType.StoredProcedure);
					// QRCodeSerial
				if (value.IsQRCodeSerialNull)
					AddParameter(cmd, "QRCodeSerial", DBNull.Value);
				else
					AddParameter(cmd, "QRCodeSerial", (object)(value.QRCodeSerial));
				
					// QRCodeContent
				if (value.IsQRCodeContentNull)
					AddParameter(cmd, "QRCodeContent", DBNull.Value);
				else
					AddParameter(cmd, "QRCodeContent", (object)(value.QRCodeContent));
				
					// Type
				if (value.IsTypeNull)
					AddParameter(cmd, "Type", DBNull.Value);
				else
					AddParameter(cmd, "Type", (object)(value.Type));
				
					// Product_ID
				if (value.IsProduct_IDNull)
					AddParameter(cmd, "Product_ID", DBNull.Value);
				else
					AddParameter(cmd, "Product_ID", (object)(value.Product_ID));
				
					// IP
				if (value.IsIPNull)
					AddParameter(cmd, "IP", DBNull.Value);
				else
					AddParameter(cmd, "IP", (object)(value.IP));
				
					// Location
				if (value.IsLocationNull)
					AddParameter(cmd, "Location", DBNull.Value);
				else
					AddParameter(cmd, "Location", (object)(value.Location));
				
					// TrackingDate
				if (value.IsTrackingDateNull)
					AddParameter(cmd, "TrackingDate", DBNull.Value);
				else
					AddParameter(cmd, "TrackingDate", (object)(value.TrackingDate));
				
					// Status
				if (value.IsStatusNull)
					AddParameter(cmd, "Status", DBNull.Value);
				else
					AddParameter(cmd, "Status", (object)(value.Status));
				
						AddParameter(cmd, "QRCodeTracking_ID", value.QRCodeTracking_ID);
						value.QRCodeTracking_ID = Convert.ToDecimal(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((decimal)row["QRCodeTracking_ID"]);
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
	/// Deletes the specified object from the <c>QRCodeTracking_ES</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodeTracking_ESRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(QRCodeTracking_ESRow value)
	{
		return DeleteByPrimaryKey(value.QRCodeTracking_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>QRCodeTracking_ES</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="qRCodeTracking_ID">The <c>QRCodeTracking_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(decimal qRCodeTracking_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(decimal qRCodeTracking_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodeTracking_ES_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "QRCodeTracking_ID", qRCodeTracking_ID);
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
	/// Deletes <c>QRCodeTracking_ES</c> records that match the specified criteria.
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
	/// to delete <c>QRCodeTracking_ES</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("QRCodeTracking_ES_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>QRCodeTracking_ES</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("QRCodeTracking_ES_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="QRCodeTracking_ESRow"/> objects.</returns>
	protected QRCodeTracking_ESRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="QRCodeTracking_ESRow"/> objects.</returns>
	protected QRCodeTracking_ESRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="QRCodeTracking_ESRow"/> objects.</returns>
	protected virtual QRCodeTracking_ESRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// QRCodeTracking_ID
		int qRCodeTracking_IDColumnIndex = reader.GetOrdinal("QRCodeTracking_ID");
		// QRCodeSerial
		int qRCodeSerialColumnIndex = reader.GetOrdinal("QRCodeSerial");
		// QRCodeContent
		int qRCodeContentColumnIndex = reader.GetOrdinal("QRCodeContent");
		// Type
		int typeColumnIndex = reader.GetOrdinal("Type");
		// Product_ID
		int product_IDColumnIndex = reader.GetOrdinal("Product_ID");
		// IP
		int ipColumnIndex = reader.GetOrdinal("IP");
		// Location
		int locationColumnIndex = reader.GetOrdinal("Location");
		// TrackingDate
		int trackingDateColumnIndex = reader.GetOrdinal("TrackingDate");
		// Status
		int statusColumnIndex = reader.GetOrdinal("Status");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				QRCodeTracking_ESRow record = new QRCodeTracking_ESRow();
				recordList.Add(record);

					record.QRCodeTracking_ID = Convert.ToDecimal(reader.GetValue(qRCodeTracking_IDColumnIndex));
					if(!reader.IsDBNull(qRCodeSerialColumnIndex))
						record.QRCodeSerial = Convert.ToString(reader.GetValue(qRCodeSerialColumnIndex));
					if(!reader.IsDBNull(qRCodeContentColumnIndex))
						record.QRCodeContent = Convert.ToString(reader.GetValue(qRCodeContentColumnIndex));
					if(!reader.IsDBNull(typeColumnIndex))
						record.Type = Convert.ToString(reader.GetValue(typeColumnIndex));
					if(!reader.IsDBNull(product_IDColumnIndex))
						record.Product_ID = Convert.ToInt32(reader.GetValue(product_IDColumnIndex));
					if(!reader.IsDBNull(ipColumnIndex))
						record.IP = Convert.ToString(reader.GetValue(ipColumnIndex));
					if(!reader.IsDBNull(locationColumnIndex))
						record.Location = Convert.ToString(reader.GetValue(locationColumnIndex));
					if(!reader.IsDBNull(trackingDateColumnIndex))
						record.TrackingDate = Convert.ToDateTime(reader.GetValue(trackingDateColumnIndex));
					if(!reader.IsDBNull(statusColumnIndex))
						record.Status = Convert.ToInt32(reader.GetValue(statusColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (QRCodeTracking_ESRow[])(recordList.ToArray(typeof(QRCodeTracking_ESRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="QRCodeTracking_ESRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="QRCodeTracking_ESRow"/> object.</returns>
	protected virtual QRCodeTracking_ESRow MapRow(DataRow row)
	{
		string LOCATION = "QRCodeTracking_ESRow MapRow(DataRow row)";
		QRCodeTracking_ESRow mappedObject = new QRCodeTracking_ESRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "QRCodeTracking_ID"
		dataColumn = dataTable.Columns["QRCodeTracking_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeTracking_ID = (decimal)(row[dataColumn]);
		// Column "QRCodeSerial"
		dataColumn = dataTable.Columns["QRCodeSerial"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeSerial = (string)(row[dataColumn]);
		// Column "QRCodeContent"
		dataColumn = dataTable.Columns["QRCodeContent"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeContent = (string)(row[dataColumn]);
		// Column "Type"
		dataColumn = dataTable.Columns["Type"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Type = (string)(row[dataColumn]);
		// Column "Product_ID"
		dataColumn = dataTable.Columns["Product_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Product_ID = (int)(row[dataColumn]);
		// Column "IP"
		dataColumn = dataTable.Columns["IP"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IP = (string)(row[dataColumn]);
		// Column "Location"
		dataColumn = dataTable.Columns["Location"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location = (string)(row[dataColumn]);
		// Column "TrackingDate"
		dataColumn = dataTable.Columns["TrackingDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TrackingDate = (System.DateTime)(row[dataColumn]);
		// Column "Status"
		dataColumn = dataTable.Columns["Status"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Status = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>QRCodeTracking_ES</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "QRCodeTracking_ES";
		DataColumn dataColumn;
		// Create the "QRCodeTracking_ID" column
		dataColumn = dataTable.Columns.Add("QRCodeTracking_ID", typeof(decimal));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "QRCodeSerial" column
		dataColumn = dataTable.Columns.Add("QRCodeSerial", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "QRCodeContent" column
		dataColumn = dataTable.Columns.Add("QRCodeContent", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Type" column
		dataColumn = dataTable.Columns.Add("Type", typeof(string));
		dataColumn.MaxLength = 10;
		// Create the "Product_ID" column
		dataColumn = dataTable.Columns.Add("Product_ID", typeof(int));
		// Create the "IP" column
		dataColumn = dataTable.Columns.Add("IP", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Location" column
		dataColumn = dataTable.Columns.Add("Location", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "TrackingDate" column
		dataColumn = dataTable.Columns.Add("TrackingDate", typeof(System.DateTime));
		// Create the "Status" column
		dataColumn = dataTable.Columns.Add("Status", typeof(int));
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
			case "QRCodeTracking_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Decimal, value);
				break;

			case "QRCodeSerial":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QRCodeContent":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Type":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "Product_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "IP":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "Location":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "TrackingDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "Status":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="QRCodeTracking_ESRow"/> by the primary key.
	/// </summary>
	/// <param name="qRCodeTracking_ID">The <c>QRCodeTracking_ID</c> column value.</param>
	/// <returns>An instance of <see cref="QRCodeTracking_ESRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(decimal qRCodeTracking_ID)
	{
		string LOCATION = "Exist(decimal qRCodeTracking_ID)";
		IDbCommand cmd = _db.CreateCommand("QRCodeTracking_ES_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "QRCodeTracking_ID", qRCodeTracking_ID);
		QRCodeTracking_ESRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




