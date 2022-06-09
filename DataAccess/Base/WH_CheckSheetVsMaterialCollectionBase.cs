
// <fileinfo name="Base\WH_CheckSheetVsMaterialCollectionBase.cs">
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
/// The base class for <see cref="WH_CheckSheetVsMaterialCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WH_CheckSheetVsMaterialCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_CheckSheetVsMaterialCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string WH_CheckSheetVsMaterial_IDColumnName  = "WH_CheckSheetVsMaterial_ID";
	public const string WH_CheckSheet_IDColumnName  = "WH_CheckSheet_ID";
	public const string Material_IDColumnName  = "Material_ID";
	public const string AmountColumnName  = "Amount";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public WH_CheckSheetVsMaterialCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "WH_CheckSheetVsMaterial";
	}

	public WH_CheckSheetVsMaterialCollectionBase() : base()
	{
		this.TABLENAME = "WH_CheckSheetVsMaterial";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>WH_CheckSheetVsMaterial</c> table.
	/// </summary>
	/// <returns>An array of <see cref="WH_CheckSheetVsMaterialRow"/> objects.</returns>
	public virtual WH_CheckSheetVsMaterialRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>WH_CheckSheetVsMaterial</c> table.
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
	/// to retrieve all records from the <c>WH_CheckSheetVsMaterial</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("WH_CheckSheetVsMaterial_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="WH_CheckSheetVsMaterialRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="WH_CheckSheetVsMaterialRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public WH_CheckSheetVsMaterialRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			WH_CheckSheetVsMaterialRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="WH_CheckSheetVsMaterialRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="WH_CheckSheetVsMaterialRow"/> objects.</returns>
	public WH_CheckSheetVsMaterialRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="WH_CheckSheetVsMaterialRow"/> objects that 
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
	/// <returns>An array of <see cref="WH_CheckSheetVsMaterialRow"/> objects.</returns>
	public virtual WH_CheckSheetVsMaterialRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			WH_CheckSheetVsMaterialRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheetVsMaterial_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheetVsMaterial_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="WH_CheckSheetVsMaterialRow"/> by the primary key.
	/// </summary>
	/// <param name="wH_CheckSheetVsMaterial_ID">The <c>WH_CheckSheetVsMaterial_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WH_CheckSheetVsMaterialRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual WH_CheckSheetVsMaterialRow GetByPrimaryKey(int wH_CheckSheetVsMaterial_ID)
	{
		string LOCATION = "GetByPrimaryKey(int wH_CheckSheetVsMaterial_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheetVsMaterial_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "WH_CheckSheetVsMaterial_ID", wH_CheckSheetVsMaterial_ID);
			WH_CheckSheetVsMaterialRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>WH_CheckSheetVsMaterial</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_CheckSheetVsMaterialRow"/> object to be inserted.</param>
	public virtual void Insert(WH_CheckSheetVsMaterialRow value)
	{
		string LOCATION = "Insert(WH_CheckSheetVsMaterialRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_CheckSheetVsMaterial_Insert", CommandType.StoredProcedure);
					// WH_CheckSheet_ID
			if (value.IsWH_CheckSheet_IDNull)
				AddParameter(cmd, "WH_CheckSheet_ID", DBNull.Value);
			else
				AddParameter(cmd, "WH_CheckSheet_ID", value.WH_CheckSheet_ID);
			
				// Material_ID
			if (value.IsMaterial_IDNull)
				AddParameter(cmd, "Material_ID", DBNull.Value);
			else
				AddParameter(cmd, "Material_ID", value.Material_ID);
			
				// Amount
			if (value.IsAmountNull)
				AddParameter(cmd, "Amount", DBNull.Value);
			else
				AddParameter(cmd, "Amount", value.Amount);
			
						value.WH_CheckSheetVsMaterial_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>WH_CheckSheetVsMaterial</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_CheckSheetVsMaterialRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(WH_CheckSheetVsMaterialRow value)
	{	
		string LOCATION = "Update(WH_CheckSheetVsMaterialRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_CheckSheetVsMaterial_Update", CommandType.StoredProcedure);
					// WH_CheckSheet_ID
			if (value.IsWH_CheckSheet_IDNull)
				AddParameter(cmd, "WH_CheckSheet_ID", DBNull.Value);
			else
				AddParameter(cmd, "WH_CheckSheet_ID", value.WH_CheckSheet_ID);
			
				// Material_ID
			if (value.IsMaterial_IDNull)
				AddParameter(cmd, "Material_ID", DBNull.Value);
			else
				AddParameter(cmd, "Material_ID", value.Material_ID);
			
				// Amount
			if (value.IsAmountNull)
				AddParameter(cmd, "Amount", DBNull.Value);
			else
				AddParameter(cmd, "Amount", value.Amount);
			
					AddParameter(cmd, "WH_CheckSheetVsMaterial_ID", value.WH_CheckSheetVsMaterial_ID);
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
		/// Inserts or Updates a record in the <c>WH_CheckSheetVsMaterial</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="WH_CheckSheetVsMaterialRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(WH_CheckSheetVsMaterialRow value)
		{
			string LOCATION = "Save(WH_CheckSheetVsMaterialRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("WH_CheckSheetVsMaterial_Save",CommandType.StoredProcedure);
					// WH_CheckSheet_ID
				if (value.IsWH_CheckSheet_IDNull)
					AddParameter(cmd, "WH_CheckSheet_ID", DBNull.Value);
				else
					AddParameter(cmd, "WH_CheckSheet_ID", (object)(value.WH_CheckSheet_ID));
				
					// Material_ID
				if (value.IsMaterial_IDNull)
					AddParameter(cmd, "Material_ID", DBNull.Value);
				else
					AddParameter(cmd, "Material_ID", (object)(value.Material_ID));
				
					// Amount
				if (value.IsAmountNull)
					AddParameter(cmd, "Amount", DBNull.Value);
				else
					AddParameter(cmd, "Amount", (object)(value.Amount));
				
						AddParameter(cmd, "WH_CheckSheetVsMaterial_ID", value.WH_CheckSheetVsMaterial_ID);
						value.WH_CheckSheetVsMaterial_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["WH_CheckSheetVsMaterial_ID"]);
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
	/// Deletes the specified object from the <c>WH_CheckSheetVsMaterial</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_CheckSheetVsMaterialRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(WH_CheckSheetVsMaterialRow value)
	{
		return DeleteByPrimaryKey(value.WH_CheckSheetVsMaterial_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>WH_CheckSheetVsMaterial</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="wH_CheckSheetVsMaterial_ID">The <c>WH_CheckSheetVsMaterial_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int wH_CheckSheetVsMaterial_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int wH_CheckSheetVsMaterial_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_CheckSheetVsMaterial_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "WH_CheckSheetVsMaterial_ID", wH_CheckSheetVsMaterial_ID);
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
	/// Deletes <c>WH_CheckSheetVsMaterial</c> records that match the specified criteria.
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
	/// to delete <c>WH_CheckSheetVsMaterial</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheetVsMaterial_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>WH_CheckSheetVsMaterial</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("WH_CheckSheetVsMaterial_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="WH_CheckSheetVsMaterialRow"/> objects.</returns>
	protected WH_CheckSheetVsMaterialRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="WH_CheckSheetVsMaterialRow"/> objects.</returns>
	protected WH_CheckSheetVsMaterialRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="WH_CheckSheetVsMaterialRow"/> objects.</returns>
	protected virtual WH_CheckSheetVsMaterialRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// WH_CheckSheetVsMaterial_ID
		int wH_CheckSheetVsMaterial_IDColumnIndex = reader.GetOrdinal("WH_CheckSheetVsMaterial_ID");
		// WH_CheckSheet_ID
		int wH_CheckSheet_IDColumnIndex = reader.GetOrdinal("WH_CheckSheet_ID");
		// Material_ID
		int material_IDColumnIndex = reader.GetOrdinal("Material_ID");
		// Amount
		int amountColumnIndex = reader.GetOrdinal("Amount");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				WH_CheckSheetVsMaterialRow record = new WH_CheckSheetVsMaterialRow();
				recordList.Add(record);

					record.WH_CheckSheetVsMaterial_ID = Convert.ToInt32(reader.GetValue(wH_CheckSheetVsMaterial_IDColumnIndex));
					if(!reader.IsDBNull(wH_CheckSheet_IDColumnIndex))
						record.WH_CheckSheet_ID = Convert.ToInt32(reader.GetValue(wH_CheckSheet_IDColumnIndex));
					if(!reader.IsDBNull(material_IDColumnIndex))
						record.Material_ID = Convert.ToInt32(reader.GetValue(material_IDColumnIndex));
					if(!reader.IsDBNull(amountColumnIndex))
						record.Amount = Convert.ToInt32(reader.GetValue(amountColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (WH_CheckSheetVsMaterialRow[])(recordList.ToArray(typeof(WH_CheckSheetVsMaterialRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="WH_CheckSheetVsMaterialRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="WH_CheckSheetVsMaterialRow"/> object.</returns>
	protected virtual WH_CheckSheetVsMaterialRow MapRow(DataRow row)
	{
		string LOCATION = "WH_CheckSheetVsMaterialRow MapRow(DataRow row)";
		WH_CheckSheetVsMaterialRow mappedObject = new WH_CheckSheetVsMaterialRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "WH_CheckSheetVsMaterial_ID"
		dataColumn = dataTable.Columns["WH_CheckSheetVsMaterial_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WH_CheckSheetVsMaterial_ID = (int)(row[dataColumn]);
		// Column "WH_CheckSheet_ID"
		dataColumn = dataTable.Columns["WH_CheckSheet_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WH_CheckSheet_ID = (int)(row[dataColumn]);
		// Column "Material_ID"
		dataColumn = dataTable.Columns["Material_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Material_ID = (int)(row[dataColumn]);
		// Column "Amount"
		dataColumn = dataTable.Columns["Amount"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Amount = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>WH_CheckSheetVsMaterial</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "WH_CheckSheetVsMaterial";
		DataColumn dataColumn;
		// Create the "WH_CheckSheetVsMaterial_ID" column
		dataColumn = dataTable.Columns.Add("WH_CheckSheetVsMaterial_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "WH_CheckSheet_ID" column
		dataColumn = dataTable.Columns.Add("WH_CheckSheet_ID", typeof(int));
		// Create the "Material_ID" column
		dataColumn = dataTable.Columns.Add("Material_ID", typeof(int));
		// Create the "Amount" column
		dataColumn = dataTable.Columns.Add("Amount", typeof(int));
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
			case "WH_CheckSheetVsMaterial_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "WH_CheckSheet_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Material_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Amount":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="WH_CheckSheetVsMaterialRow"/> by the primary key.
	/// </summary>
	/// <param name="wH_CheckSheetVsMaterial_ID">The <c>WH_CheckSheetVsMaterial_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WH_CheckSheetVsMaterialRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int wH_CheckSheetVsMaterial_ID)
	{
		string LOCATION = "Exist(int wH_CheckSheetVsMaterial_ID)";
		IDbCommand cmd = _db.CreateCommand("WH_CheckSheetVsMaterial_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "WH_CheckSheetVsMaterial_ID", wH_CheckSheetVsMaterial_ID);
		WH_CheckSheetVsMaterialRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




