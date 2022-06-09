
// <fileinfo name="Base\WarehouseSlotActionCollectionBase.cs">
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
/// The base class for <see cref="WarehouseSlotActionCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WarehouseSlotActionCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WarehouseSlotActionCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string WarehouseSlotAction_IDColumnName  = "WarehouseSlotAction_ID";
	public const string ActionTypeColumnName  = "ActionType";
	public const string Slot_IDColumnName  = "Slot_ID";
	public const string SlotInfor_IDColumnName  = "SlotInfor_ID";
	public const string Product_IDColumnName  = "Product_ID";
	public const string SerialColumnName  = "Serial";
	public const string AmountColumnName  = "Amount";
	public const string Pallet_IDColumnName  = "Pallet_ID";
	public const string ImportNoteCodeColumnName  = "ImportNoteCode";
	public const string ProductPackage_IDColumnName  = "ProductPackage_ID";
	public const string CreatedDateColumnName  = "CreatedDate";
	public const string EditDateColumnName  = "EditDate";
	public const string Other1ColumnName  = "Other1";
	public const string Other2ColumnName  = "Other2";
	public const string Other3ColumnName  = "Other3";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public WarehouseSlotActionCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "WarehouseSlotAction";
	}

	public WarehouseSlotActionCollectionBase() : base()
	{
		this.TABLENAME = "WarehouseSlotAction";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>WarehouseSlotAction</c> table.
	/// </summary>
	/// <returns>An array of <see cref="WarehouseSlotActionRow"/> objects.</returns>
	public virtual WarehouseSlotActionRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>WarehouseSlotAction</c> table.
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
	/// to retrieve all records from the <c>WarehouseSlotAction</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("WarehouseSlotAction_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="WarehouseSlotActionRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="WarehouseSlotActionRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public WarehouseSlotActionRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			WarehouseSlotActionRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="WarehouseSlotActionRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="WarehouseSlotActionRow"/> objects.</returns>
	public WarehouseSlotActionRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="WarehouseSlotActionRow"/> objects that 
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
	/// <returns>An array of <see cref="WarehouseSlotActionRow"/> objects.</returns>
	public virtual WarehouseSlotActionRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			WarehouseSlotActionRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("WarehouseSlotAction_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("WarehouseSlotAction_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="WarehouseSlotActionRow"/> by the primary key.
	/// </summary>
	/// <param name="warehouseSlotAction_ID">The <c>WarehouseSlotAction_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WarehouseSlotActionRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual WarehouseSlotActionRow GetByPrimaryKey(int warehouseSlotAction_ID)
	{
		string LOCATION = "GetByPrimaryKey(int warehouseSlotAction_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("WarehouseSlotAction_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "WarehouseSlotAction_ID", warehouseSlotAction_ID);
			WarehouseSlotActionRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>WarehouseSlotAction</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WarehouseSlotActionRow"/> object to be inserted.</param>
	public virtual void Insert(WarehouseSlotActionRow value)
	{
		string LOCATION = "Insert(WarehouseSlotActionRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WarehouseSlotAction_Insert", CommandType.StoredProcedure);
					// ActionType
			if (value.IsActionTypeNull)
				AddParameter(cmd, "ActionType", DBNull.Value);
			else
				AddParameter(cmd, "ActionType", value.ActionType);
			
				// Slot_ID
			if (value.IsSlot_IDNull)
				AddParameter(cmd, "Slot_ID", DBNull.Value);
			else
				AddParameter(cmd, "Slot_ID", value.Slot_ID);
			
				// SlotInfor_ID
			if (value.IsSlotInfor_IDNull)
				AddParameter(cmd, "SlotInfor_ID", DBNull.Value);
			else
				AddParameter(cmd, "SlotInfor_ID", value.SlotInfor_ID);
			
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// Serial
			if (value.IsSerialNull )
				AddParameter(cmd, "Serial", DBNull.Value);
			else
				AddParameter(cmd, "Serial", value.Serial);
			
				// Amount
			if (value.IsAmountNull)
				AddParameter(cmd, "Amount", DBNull.Value);
			else
				AddParameter(cmd, "Amount", value.Amount);
			
				// Pallet_ID
			if (value.IsPallet_IDNull )
				AddParameter(cmd, "Pallet_ID", DBNull.Value);
			else
				AddParameter(cmd, "Pallet_ID", value.Pallet_ID);
			
				// ImportNoteCode
			if (value.IsImportNoteCodeNull )
				AddParameter(cmd, "ImportNoteCode", DBNull.Value);
			else
				AddParameter(cmd, "ImportNoteCode", value.ImportNoteCode);
			
				// ProductPackage_ID
			if (value.IsProductPackage_IDNull )
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
			
				// CreatedDate
			if (value.IsCreatedDateNull)
				AddParameter(cmd, "CreatedDate", DBNull.Value);
			else
				AddParameter(cmd, "CreatedDate", value.CreatedDate);
			
				// EditDate
			if (value.IsEditDateNull)
				AddParameter(cmd, "EditDate", DBNull.Value);
			else
				AddParameter(cmd, "EditDate", value.EditDate);
			
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
			
						value.WarehouseSlotAction_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>WarehouseSlotAction</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WarehouseSlotActionRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(WarehouseSlotActionRow value)
	{	
		string LOCATION = "Update(WarehouseSlotActionRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WarehouseSlotAction_Update", CommandType.StoredProcedure);
					// ActionType
			if (value.IsActionTypeNull)
				AddParameter(cmd, "ActionType", DBNull.Value);
			else
				AddParameter(cmd, "ActionType", value.ActionType);
			
				// Slot_ID
			if (value.IsSlot_IDNull)
				AddParameter(cmd, "Slot_ID", DBNull.Value);
			else
				AddParameter(cmd, "Slot_ID", value.Slot_ID);
			
				// SlotInfor_ID
			if (value.IsSlotInfor_IDNull)
				AddParameter(cmd, "SlotInfor_ID", DBNull.Value);
			else
				AddParameter(cmd, "SlotInfor_ID", value.SlotInfor_ID);
			
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// Serial
			if (value.IsSerialNull)
				AddParameter(cmd, "Serial", DBNull.Value);
			else
				AddParameter(cmd, "Serial", value.Serial);
				// Amount
			if (value.IsAmountNull)
				AddParameter(cmd, "Amount", DBNull.Value);
			else
				AddParameter(cmd, "Amount", value.Amount);
			
				// Pallet_ID
			if (value.IsPallet_IDNull)
				AddParameter(cmd, "Pallet_ID", DBNull.Value);
			else
				AddParameter(cmd, "Pallet_ID", value.Pallet_ID);
				// ImportNoteCode
			if (value.IsImportNoteCodeNull)
				AddParameter(cmd, "ImportNoteCode", DBNull.Value);
			else
				AddParameter(cmd, "ImportNoteCode", value.ImportNoteCode);
				// ProductPackage_ID
			if (value.IsProductPackage_IDNull)
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
				// CreatedDate
			if (value.IsCreatedDateNull)
				AddParameter(cmd, "CreatedDate", DBNull.Value);
			else
				AddParameter(cmd, "CreatedDate", value.CreatedDate);
			
				// EditDate
			if (value.IsEditDateNull)
				AddParameter(cmd, "EditDate", DBNull.Value);
			else
				AddParameter(cmd, "EditDate", value.EditDate);
			
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
					AddParameter(cmd, "WarehouseSlotAction_ID", value.WarehouseSlotAction_ID);
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
		/// Inserts or Updates a record in the <c>WarehouseSlotAction</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="WarehouseSlotActionRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(WarehouseSlotActionRow value)
		{
			string LOCATION = "Save(WarehouseSlotActionRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("WarehouseSlotAction_Save",CommandType.StoredProcedure);
					// ActionType
				if (value.IsActionTypeNull)
					AddParameter(cmd, "ActionType", DBNull.Value);
				else
					AddParameter(cmd, "ActionType", (object)(value.ActionType));
				
					// Slot_ID
				if (value.IsSlot_IDNull)
					AddParameter(cmd, "Slot_ID", DBNull.Value);
				else
					AddParameter(cmd, "Slot_ID", (object)(value.Slot_ID));
				
					// SlotInfor_ID
				if (value.IsSlotInfor_IDNull)
					AddParameter(cmd, "SlotInfor_ID", DBNull.Value);
				else
					AddParameter(cmd, "SlotInfor_ID", (object)(value.SlotInfor_ID));
				
					// Product_ID
				if (value.IsProduct_IDNull)
					AddParameter(cmd, "Product_ID", DBNull.Value);
				else
					AddParameter(cmd, "Product_ID", (object)(value.Product_ID));
				
					// Serial
				if (value.IsSerialNull)
					AddParameter(cmd, "Serial", DBNull.Value);
				else
					AddParameter(cmd, "Serial", (object)(value.Serial));
				
					// Amount
				if (value.IsAmountNull)
					AddParameter(cmd, "Amount", DBNull.Value);
				else
					AddParameter(cmd, "Amount", (object)(value.Amount));
				
					// Pallet_ID
				if (value.IsPallet_IDNull)
					AddParameter(cmd, "Pallet_ID", DBNull.Value);
				else
					AddParameter(cmd, "Pallet_ID", (object)(value.Pallet_ID));
				
					// ImportNoteCode
				if (value.IsImportNoteCodeNull)
					AddParameter(cmd, "ImportNoteCode", DBNull.Value);
				else
					AddParameter(cmd, "ImportNoteCode", (object)(value.ImportNoteCode));
				
					// ProductPackage_ID
				if (value.IsProductPackage_IDNull)
					AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductPackage_ID", (object)(value.ProductPackage_ID));
				
					// CreatedDate
				if (value.IsCreatedDateNull)
					AddParameter(cmd, "CreatedDate", DBNull.Value);
				else
					AddParameter(cmd, "CreatedDate", (object)(value.CreatedDate));
				
					// EditDate
				if (value.IsEditDateNull)
					AddParameter(cmd, "EditDate", DBNull.Value);
				else
					AddParameter(cmd, "EditDate", (object)(value.EditDate));
				
					// Other1
				if (value.IsOther1Null)
					AddParameter(cmd, "Other1", DBNull.Value);
				else
					AddParameter(cmd, "Other1", (object)(value.Other1));
				
					// Other2
				if (value.IsOther2Null)
					AddParameter(cmd, "Other2", DBNull.Value);
				else
					AddParameter(cmd, "Other2", (object)(value.Other2));
				
					// Other3
				if (value.IsOther3Null)
					AddParameter(cmd, "Other3", DBNull.Value);
				else
					AddParameter(cmd, "Other3", (object)(value.Other3));
				
						AddParameter(cmd, "WarehouseSlotAction_ID", value.WarehouseSlotAction_ID);
						value.WarehouseSlotAction_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["WarehouseSlotAction_ID"]);
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
	/// Deletes the specified object from the <c>WarehouseSlotAction</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WarehouseSlotActionRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(WarehouseSlotActionRow value)
	{
		return DeleteByPrimaryKey(value.WarehouseSlotAction_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>WarehouseSlotAction</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="warehouseSlotAction_ID">The <c>WarehouseSlotAction_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int warehouseSlotAction_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int warehouseSlotAction_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WarehouseSlotAction_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "WarehouseSlotAction_ID", warehouseSlotAction_ID);
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
	/// Deletes <c>WarehouseSlotAction</c> records that match the specified criteria.
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
	/// to delete <c>WarehouseSlotAction</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("WarehouseSlotAction_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>WarehouseSlotAction</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("WarehouseSlotAction_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="WarehouseSlotActionRow"/> objects.</returns>
	protected WarehouseSlotActionRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="WarehouseSlotActionRow"/> objects.</returns>
	protected WarehouseSlotActionRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="WarehouseSlotActionRow"/> objects.</returns>
	protected virtual WarehouseSlotActionRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// WarehouseSlotAction_ID
		int warehouseSlotAction_IDColumnIndex = reader.GetOrdinal("WarehouseSlotAction_ID");
		// ActionType
		int actionTypeColumnIndex = reader.GetOrdinal("ActionType");
		// Slot_ID
		int slot_IDColumnIndex = reader.GetOrdinal("Slot_ID");
		// SlotInfor_ID
		int slotInfor_IDColumnIndex = reader.GetOrdinal("SlotInfor_ID");
		// Product_ID
		int product_IDColumnIndex = reader.GetOrdinal("Product_ID");
		// Serial
		int serialColumnIndex = reader.GetOrdinal("Serial");
		// Amount
		int amountColumnIndex = reader.GetOrdinal("Amount");
		// Pallet_ID
		int pallet_IDColumnIndex = reader.GetOrdinal("Pallet_ID");
		// ImportNoteCode
		int importNoteCodeColumnIndex = reader.GetOrdinal("ImportNoteCode");
		// ProductPackage_ID
		int productPackage_IDColumnIndex = reader.GetOrdinal("ProductPackage_ID");
		// CreatedDate
		int createdDateColumnIndex = reader.GetOrdinal("CreatedDate");
		// EditDate
		int editDateColumnIndex = reader.GetOrdinal("EditDate");
		// Other1
		int other1ColumnIndex = reader.GetOrdinal("Other1");
		// Other2
		int other2ColumnIndex = reader.GetOrdinal("Other2");
		// Other3
		int other3ColumnIndex = reader.GetOrdinal("Other3");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				WarehouseSlotActionRow record = new WarehouseSlotActionRow();
				recordList.Add(record);

					record.WarehouseSlotAction_ID = Convert.ToInt32(reader.GetValue(warehouseSlotAction_IDColumnIndex));
					if(!reader.IsDBNull(actionTypeColumnIndex))
						record.ActionType = Convert.ToInt32(reader.GetValue(actionTypeColumnIndex));
					if(!reader.IsDBNull(slot_IDColumnIndex))
						record.Slot_ID = Convert.ToInt32(reader.GetValue(slot_IDColumnIndex));
					if(!reader.IsDBNull(slotInfor_IDColumnIndex))
						record.SlotInfor_ID = Convert.ToInt32(reader.GetValue(slotInfor_IDColumnIndex));
					if(!reader.IsDBNull(product_IDColumnIndex))
						record.Product_ID = Convert.ToInt32(reader.GetValue(product_IDColumnIndex));
					if(!reader.IsDBNull(serialColumnIndex))
						record.Serial = Convert.ToString(reader.GetValue(serialColumnIndex));
					if(!reader.IsDBNull(amountColumnIndex))
						record.Amount = Convert.ToInt32(reader.GetValue(amountColumnIndex));
					if(!reader.IsDBNull(pallet_IDColumnIndex))
						record.Pallet_ID = Convert.ToString(reader.GetValue(pallet_IDColumnIndex));
					if(!reader.IsDBNull(importNoteCodeColumnIndex))
						record.ImportNoteCode = Convert.ToString(reader.GetValue(importNoteCodeColumnIndex));
					if(!reader.IsDBNull(productPackage_IDColumnIndex))
						record.ProductPackage_ID = Convert.ToString(reader.GetValue(productPackage_IDColumnIndex));
					if(!reader.IsDBNull(createdDateColumnIndex))
						record.CreatedDate = Convert.ToDateTime(reader.GetValue(createdDateColumnIndex));
					if(!reader.IsDBNull(editDateColumnIndex))
						record.EditDate = Convert.ToDateTime(reader.GetValue(editDateColumnIndex));
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

		return (WarehouseSlotActionRow[])(recordList.ToArray(typeof(WarehouseSlotActionRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="WarehouseSlotActionRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="WarehouseSlotActionRow"/> object.</returns>
	protected virtual WarehouseSlotActionRow MapRow(DataRow row)
	{
		string LOCATION = "WarehouseSlotActionRow MapRow(DataRow row)";
		WarehouseSlotActionRow mappedObject = new WarehouseSlotActionRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "WarehouseSlotAction_ID"
		dataColumn = dataTable.Columns["WarehouseSlotAction_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WarehouseSlotAction_ID = (int)(row[dataColumn]);
		// Column "ActionType"
		dataColumn = dataTable.Columns["ActionType"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ActionType = (int)(row[dataColumn]);
		// Column "Slot_ID"
		dataColumn = dataTable.Columns["Slot_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Slot_ID = (int)(row[dataColumn]);
		// Column "SlotInfor_ID"
		dataColumn = dataTable.Columns["SlotInfor_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SlotInfor_ID = (int)(row[dataColumn]);
		// Column "Product_ID"
		dataColumn = dataTable.Columns["Product_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Product_ID = (int)(row[dataColumn]);
		// Column "Serial"
		dataColumn = dataTable.Columns["Serial"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Serial = (string)(row[dataColumn]);
		// Column "Amount"
		dataColumn = dataTable.Columns["Amount"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Amount = (int)(row[dataColumn]);
		// Column "Pallet_ID"
		dataColumn = dataTable.Columns["Pallet_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Pallet_ID = (string)(row[dataColumn]);
		// Column "ImportNoteCode"
		dataColumn = dataTable.Columns["ImportNoteCode"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ImportNoteCode = (string)(row[dataColumn]);
		// Column "ProductPackage_ID"
		dataColumn = dataTable.Columns["ProductPackage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackage_ID = (string)(row[dataColumn]);
		// Column "CreatedDate"
		dataColumn = dataTable.Columns["CreatedDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreatedDate = (System.DateTime)(row[dataColumn]);
		// Column "EditDate"
		dataColumn = dataTable.Columns["EditDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EditDate = (System.DateTime)(row[dataColumn]);
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
	/// the <c>WarehouseSlotAction</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "WarehouseSlotAction";
		DataColumn dataColumn;
		// Create the "WarehouseSlotAction_ID" column
		dataColumn = dataTable.Columns.Add("WarehouseSlotAction_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "ActionType" column
		dataColumn = dataTable.Columns.Add("ActionType", typeof(int));
		// Create the "Slot_ID" column
		dataColumn = dataTable.Columns.Add("Slot_ID", typeof(int));
		// Create the "SlotInfor_ID" column
		dataColumn = dataTable.Columns.Add("SlotInfor_ID", typeof(int));
		// Create the "Product_ID" column
		dataColumn = dataTable.Columns.Add("Product_ID", typeof(int));
		// Create the "Serial" column
		dataColumn = dataTable.Columns.Add("Serial", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Amount" column
		dataColumn = dataTable.Columns.Add("Amount", typeof(int));
		// Create the "Pallet_ID" column
		dataColumn = dataTable.Columns.Add("Pallet_ID", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "ImportNoteCode" column
		dataColumn = dataTable.Columns.Add("ImportNoteCode", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "ProductPackage_ID" column
		dataColumn = dataTable.Columns.Add("ProductPackage_ID", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "CreatedDate" column
		dataColumn = dataTable.Columns.Add("CreatedDate", typeof(System.DateTime));
		// Create the "EditDate" column
		dataColumn = dataTable.Columns.Add("EditDate", typeof(System.DateTime));
		// Create the "Other1" column
		dataColumn = dataTable.Columns.Add("Other1", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Other2" column
		dataColumn = dataTable.Columns.Add("Other2", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Other3" column
		dataColumn = dataTable.Columns.Add("Other3", typeof(string));
		dataColumn.MaxLength = 50;
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
			case "WarehouseSlotAction_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ActionType":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Slot_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "SlotInfor_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Product_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Serial":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "Amount":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Pallet_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "ImportNoteCode":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "ProductPackage_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "CreatedDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "EditDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "Other1":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "Other2":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "Other3":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="WarehouseSlotActionRow"/> by the primary key.
	/// </summary>
	/// <param name="warehouseSlotAction_ID">The <c>WarehouseSlotAction_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WarehouseSlotActionRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int warehouseSlotAction_ID)
	{
		string LOCATION = "Exist(int warehouseSlotAction_ID)";
		IDbCommand cmd = _db.CreateCommand("WarehouseSlotAction_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "WarehouseSlotAction_ID", warehouseSlotAction_ID);
		WarehouseSlotActionRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




