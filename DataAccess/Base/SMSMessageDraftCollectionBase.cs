
// <fileinfo name="Base\SMSMessageDraftCollectionBase.cs">
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
/// The base class for <see cref="SMSMessageDraftCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="SMSMessageDraftCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SMSMessageDraftCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string SMSMessageDraft_IDColumnName  = "SMSMessageDraft_ID";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string ActionTypeColumnName  = "ActionType";
	public const string ActionDescriptionColumnName  = "ActionDescription";
	public const string SMSMessage_IDColumnName  = "SMSMessage_ID";
	public const string NameColumnName  = "Name";
	public const string ContentColumnName  = "Content";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string CheckApproveColumnName  = "CheckApprove";
	public const string CheckApproveDateColumnName  = "CheckApproveDate";
	public const string AdminApproveColumnName  = "AdminApprove";
	public const string AdminApproveDateColumnName  = "AdminApproveDate";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public SMSMessageDraftCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "SMSMessageDraft";
	}

	public SMSMessageDraftCollectionBase() : base()
	{
		this.TABLENAME = "SMSMessageDraft";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>SMSMessageDraft</c> table.
	/// </summary>
	/// <returns>An array of <see cref="SMSMessageDraftRow"/> objects.</returns>
	public virtual SMSMessageDraftRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>SMSMessageDraft</c> table.
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
	/// to retrieve all records from the <c>SMSMessageDraft</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("SMSMessageDraft_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="SMSMessageDraftRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="SMSMessageDraftRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public SMSMessageDraftRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			SMSMessageDraftRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="SMSMessageDraftRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="SMSMessageDraftRow"/> objects.</returns>
	public SMSMessageDraftRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="SMSMessageDraftRow"/> objects that 
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
	/// <returns>An array of <see cref="SMSMessageDraftRow"/> objects.</returns>
	public virtual SMSMessageDraftRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			SMSMessageDraftRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("SMSMessageDraft_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("SMSMessageDraft_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="SMSMessageDraftRow"/> by the primary key.
	/// </summary>
	/// <param name="sMSMessageDraft_ID">The <c>SMSMessageDraft_ID</c> column value.</param>
	/// <returns>An instance of <see cref="SMSMessageDraftRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual SMSMessageDraftRow GetByPrimaryKey(int sMSMessageDraft_ID)
	{
		string LOCATION = "GetByPrimaryKey(int sMSMessageDraft_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("SMSMessageDraft_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "SMSMessageDraft_ID", sMSMessageDraft_ID);
			SMSMessageDraftRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>SMSMessageDraft</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SMSMessageDraftRow"/> object to be inserted.</param>
	public virtual void Insert(SMSMessageDraftRow value)
	{
		string LOCATION = "Insert(SMSMessageDraftRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("SMSMessageDraft_Insert", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// ActionType
			if (value.IsActionTypeNull )
				AddParameter(cmd, "ActionType", DBNull.Value);
			else
				AddParameter(cmd, "ActionType", value.ActionType);
			
				// ActionDescription
			if (value.IsActionDescriptionNull )
				AddParameter(cmd, "ActionDescription", DBNull.Value);
			else
				AddParameter(cmd, "ActionDescription", value.ActionDescription);
			
				// SMSMessage_ID
			if (value.IsSMSMessage_IDNull)
				AddParameter(cmd, "SMSMessage_ID", DBNull.Value);
			else
				AddParameter(cmd, "SMSMessage_ID", value.SMSMessage_ID);
			
				// Name
			if (value.IsNameNull )
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
			
				// Content
			if (value.IsContentNull )
				AddParameter(cmd, "Content", DBNull.Value);
			else
				AddParameter(cmd, "Content", value.Content);
			
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
			
				// CheckApprove
			if (value.IsCheckApproveNull)
				AddParameter(cmd, "CheckApprove", DBNull.Value);
			else
				AddParameter(cmd, "CheckApprove", value.CheckApprove);
			
				// CheckApproveDate
			if (value.IsCheckApproveDateNull)
				AddParameter(cmd, "CheckApproveDate", DBNull.Value);
			else
				AddParameter(cmd, "CheckApproveDate", value.CheckApproveDate);
			
				// AdminApprove
			if (value.IsAdminApproveNull)
				AddParameter(cmd, "AdminApprove", DBNull.Value);
			else
				AddParameter(cmd, "AdminApprove", value.AdminApprove);
			
				// AdminApproveDate
			if (value.IsAdminApproveDateNull)
				AddParameter(cmd, "AdminApproveDate", DBNull.Value);
			else
				AddParameter(cmd, "AdminApproveDate", value.AdminApproveDate);
			
						value.SMSMessageDraft_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>SMSMessageDraft</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SMSMessageDraftRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(SMSMessageDraftRow value)
	{	
		string LOCATION = "Update(SMSMessageDraftRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("SMSMessageDraft_Update", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// ActionType
			if (value.IsActionTypeNull)
				AddParameter(cmd, "ActionType", DBNull.Value);
			else
				AddParameter(cmd, "ActionType", value.ActionType);
				// ActionDescription
			if (value.IsActionDescriptionNull)
				AddParameter(cmd, "ActionDescription", DBNull.Value);
			else
				AddParameter(cmd, "ActionDescription", value.ActionDescription);
				// SMSMessage_ID
			if (value.IsSMSMessage_IDNull)
				AddParameter(cmd, "SMSMessage_ID", DBNull.Value);
			else
				AddParameter(cmd, "SMSMessage_ID", value.SMSMessage_ID);
			
				// Name
			if (value.IsNameNull)
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
				// Content
			if (value.IsContentNull)
				AddParameter(cmd, "Content", DBNull.Value);
			else
				AddParameter(cmd, "Content", value.Content);
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
			
				// CheckApprove
			if (value.IsCheckApproveNull)
				AddParameter(cmd, "CheckApprove", DBNull.Value);
			else
				AddParameter(cmd, "CheckApprove", value.CheckApprove);
			
				// CheckApproveDate
			if (value.IsCheckApproveDateNull)
				AddParameter(cmd, "CheckApproveDate", DBNull.Value);
			else
				AddParameter(cmd, "CheckApproveDate", value.CheckApproveDate);
			
				// AdminApprove
			if (value.IsAdminApproveNull)
				AddParameter(cmd, "AdminApprove", DBNull.Value);
			else
				AddParameter(cmd, "AdminApprove", value.AdminApprove);
			
				// AdminApproveDate
			if (value.IsAdminApproveDateNull)
				AddParameter(cmd, "AdminApproveDate", DBNull.Value);
			else
				AddParameter(cmd, "AdminApproveDate", value.AdminApproveDate);
			
					AddParameter(cmd, "SMSMessageDraft_ID", value.SMSMessageDraft_ID);
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
		/// Inserts or Updates a record in the <c>SMSMessageDraft</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="SMSMessageDraftRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(SMSMessageDraftRow value)
		{
			string LOCATION = "Save(SMSMessageDraftRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("SMSMessageDraft_Save",CommandType.StoredProcedure);
					// ProductBrand_ID
				if (value.IsProductBrand_IDNull)
					AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrand_ID", (object)(value.ProductBrand_ID));
				
					// ActionType
				if (value.IsActionTypeNull)
					AddParameter(cmd, "ActionType", DBNull.Value);
				else
					AddParameter(cmd, "ActionType", (object)(value.ActionType));
				
					// ActionDescription
				if (value.IsActionDescriptionNull)
					AddParameter(cmd, "ActionDescription", DBNull.Value);
				else
					AddParameter(cmd, "ActionDescription", (object)(value.ActionDescription));
				
					// SMSMessage_ID
				if (value.IsSMSMessage_IDNull)
					AddParameter(cmd, "SMSMessage_ID", DBNull.Value);
				else
					AddParameter(cmd, "SMSMessage_ID", (object)(value.SMSMessage_ID));
				
					// Name
				if (value.IsNameNull)
					AddParameter(cmd, "Name", DBNull.Value);
				else
					AddParameter(cmd, "Name", (object)(value.Name));
				
					// Content
				if (value.IsContentNull)
					AddParameter(cmd, "Content", DBNull.Value);
				else
					AddParameter(cmd, "Content", (object)(value.Content));
				
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
				
					// CheckApprove
				if (value.IsCheckApproveNull)
					AddParameter(cmd, "CheckApprove", DBNull.Value);
				else
					AddParameter(cmd, "CheckApprove", (object)(value.CheckApprove));
				
					// CheckApproveDate
				if (value.IsCheckApproveDateNull)
					AddParameter(cmd, "CheckApproveDate", DBNull.Value);
				else
					AddParameter(cmd, "CheckApproveDate", (object)(value.CheckApproveDate));
				
					// AdminApprove
				if (value.IsAdminApproveNull)
					AddParameter(cmd, "AdminApprove", DBNull.Value);
				else
					AddParameter(cmd, "AdminApprove", (object)(value.AdminApprove));
				
					// AdminApproveDate
				if (value.IsAdminApproveDateNull)
					AddParameter(cmd, "AdminApproveDate", DBNull.Value);
				else
					AddParameter(cmd, "AdminApproveDate", (object)(value.AdminApproveDate));
				
						AddParameter(cmd, "SMSMessageDraft_ID", value.SMSMessageDraft_ID);
						value.SMSMessageDraft_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["SMSMessageDraft_ID"]);
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
	/// Deletes the specified object from the <c>SMSMessageDraft</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SMSMessageDraftRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(SMSMessageDraftRow value)
	{
		return DeleteByPrimaryKey(value.SMSMessageDraft_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>SMSMessageDraft</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="sMSMessageDraft_ID">The <c>SMSMessageDraft_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int sMSMessageDraft_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int sMSMessageDraft_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("SMSMessageDraft_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "SMSMessageDraft_ID", sMSMessageDraft_ID);
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
	/// Deletes <c>SMSMessageDraft</c> records that match the specified criteria.
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
	/// to delete <c>SMSMessageDraft</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("SMSMessageDraft_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>SMSMessageDraft</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("SMSMessageDraft_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="SMSMessageDraftRow"/> objects.</returns>
	protected SMSMessageDraftRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="SMSMessageDraftRow"/> objects.</returns>
	protected SMSMessageDraftRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="SMSMessageDraftRow"/> objects.</returns>
	protected virtual SMSMessageDraftRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// SMSMessageDraft_ID
		int sMSMessageDraft_IDColumnIndex = reader.GetOrdinal("SMSMessageDraft_ID");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// ActionType
		int actionTypeColumnIndex = reader.GetOrdinal("ActionType");
		// ActionDescription
		int actionDescriptionColumnIndex = reader.GetOrdinal("ActionDescription");
		// SMSMessage_ID
		int sMSMessage_IDColumnIndex = reader.GetOrdinal("SMSMessage_ID");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// Content
		int contentColumnIndex = reader.GetOrdinal("Content");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// CheckApprove
		int checkApproveColumnIndex = reader.GetOrdinal("CheckApprove");
		// CheckApproveDate
		int checkApproveDateColumnIndex = reader.GetOrdinal("CheckApproveDate");
		// AdminApprove
		int adminApproveColumnIndex = reader.GetOrdinal("AdminApprove");
		// AdminApproveDate
		int adminApproveDateColumnIndex = reader.GetOrdinal("AdminApproveDate");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				SMSMessageDraftRow record = new SMSMessageDraftRow();
				recordList.Add(record);

					record.SMSMessageDraft_ID = Convert.ToInt32(reader.GetValue(sMSMessageDraft_IDColumnIndex));
					if(!reader.IsDBNull(productBrand_IDColumnIndex))
						record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(actionTypeColumnIndex))
						record.ActionType = Convert.ToString(reader.GetValue(actionTypeColumnIndex));
					if(!reader.IsDBNull(actionDescriptionColumnIndex))
						record.ActionDescription = Convert.ToString(reader.GetValue(actionDescriptionColumnIndex));
					if(!reader.IsDBNull(sMSMessage_IDColumnIndex))
						record.SMSMessage_ID = Convert.ToInt32(reader.GetValue(sMSMessage_IDColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(contentColumnIndex))
						record.Content = Convert.ToString(reader.GetValue(contentColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(checkApproveColumnIndex))
						record.CheckApprove = Convert.ToInt32(reader.GetValue(checkApproveColumnIndex));
					if(!reader.IsDBNull(checkApproveDateColumnIndex))
						record.CheckApproveDate = Convert.ToDateTime(reader.GetValue(checkApproveDateColumnIndex));
					if(!reader.IsDBNull(adminApproveColumnIndex))
						record.AdminApprove = Convert.ToInt32(reader.GetValue(adminApproveColumnIndex));
					if(!reader.IsDBNull(adminApproveDateColumnIndex))
						record.AdminApproveDate = Convert.ToDateTime(reader.GetValue(adminApproveDateColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (SMSMessageDraftRow[])(recordList.ToArray(typeof(SMSMessageDraftRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="SMSMessageDraftRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="SMSMessageDraftRow"/> object.</returns>
	protected virtual SMSMessageDraftRow MapRow(DataRow row)
	{
		string LOCATION = "SMSMessageDraftRow MapRow(DataRow row)";
		SMSMessageDraftRow mappedObject = new SMSMessageDraftRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "SMSMessageDraft_ID"
		dataColumn = dataTable.Columns["SMSMessageDraft_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SMSMessageDraft_ID = (int)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
		// Column "ActionType"
		dataColumn = dataTable.Columns["ActionType"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ActionType = (string)(row[dataColumn]);
		// Column "ActionDescription"
		dataColumn = dataTable.Columns["ActionDescription"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ActionDescription = (string)(row[dataColumn]);
		// Column "SMSMessage_ID"
		dataColumn = dataTable.Columns["SMSMessage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SMSMessage_ID = (int)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "Content"
		dataColumn = dataTable.Columns["Content"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Content = (string)(row[dataColumn]);
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
		// Column "CheckApprove"
		dataColumn = dataTable.Columns["CheckApprove"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CheckApprove = (int)(row[dataColumn]);
		// Column "CheckApproveDate"
		dataColumn = dataTable.Columns["CheckApproveDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CheckApproveDate = (System.DateTime)(row[dataColumn]);
		// Column "AdminApprove"
		dataColumn = dataTable.Columns["AdminApprove"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AdminApprove = (int)(row[dataColumn]);
		// Column "AdminApproveDate"
		dataColumn = dataTable.Columns["AdminApproveDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AdminApproveDate = (System.DateTime)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>SMSMessageDraft</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "SMSMessageDraft";
		DataColumn dataColumn;
		// Create the "SMSMessageDraft_ID" column
		dataColumn = dataTable.Columns.Add("SMSMessageDraft_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		// Create the "ActionType" column
		dataColumn = dataTable.Columns.Add("ActionType", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "ActionDescription" column
		dataColumn = dataTable.Columns.Add("ActionDescription", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "SMSMessage_ID" column
		dataColumn = dataTable.Columns.Add("SMSMessage_ID", typeof(int));
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Content" column
		dataColumn = dataTable.Columns.Add("Content", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "CheckApprove" column
		dataColumn = dataTable.Columns.Add("CheckApprove", typeof(int));
		// Create the "CheckApproveDate" column
		dataColumn = dataTable.Columns.Add("CheckApproveDate", typeof(System.DateTime));
		// Create the "AdminApprove" column
		dataColumn = dataTable.Columns.Add("AdminApprove", typeof(int));
		// Create the "AdminApproveDate" column
		dataColumn = dataTable.Columns.Add("AdminApproveDate", typeof(System.DateTime));
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
			case "SMSMessageDraft_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ActionType":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ActionDescription":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SMSMessage_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Content":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
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

			case "CheckApprove":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "CheckApproveDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "AdminApprove":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "AdminApproveDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="SMSMessageDraftRow"/> by the primary key.
	/// </summary>
	/// <param name="sMSMessageDraft_ID">The <c>SMSMessageDraft_ID</c> column value.</param>
	/// <returns>An instance of <see cref="SMSMessageDraftRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int sMSMessageDraft_ID)
	{
		string LOCATION = "Exist(int sMSMessageDraft_ID)";
		IDbCommand cmd = _db.CreateCommand("SMSMessageDraft_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "SMSMessageDraft_ID", sMSMessageDraft_ID);
		SMSMessageDraftRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




