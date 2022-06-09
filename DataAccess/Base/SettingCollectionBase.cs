
// <fileinfo name="Base\SettingCollectionBase.cs">
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
/// The base class for <see cref="SettingCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="SettingCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SettingCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Setting_IDColumnName  = "Setting_ID";
	public const string AdminNameColumnName  = "AdminName";
	public const string EmailSupportColumnName  = "EmailSupport";
	public const string EmailOrderColumnName  = "EmailOrder";
	public const string EmailSenderSMTPColumnName  = "EmailSenderSMTP";
	public const string EmailSenderPortColumnName  = "EmailSenderPort";
	public const string EmailSenderSSLColumnName  = "EmailSenderSSL";
	public const string EmailSenderColumnName  = "EmailSender";
	public const string EmailSenderPasswordColumnName  = "EmailSenderPassword";
	public const string TelephoneColumnName  = "Telephone";
	public const string AppStatusColumnName  = "AppStatus";
	public const string CounterColumnName  = "Counter";
	public const string DefaultLanguage_IDColumnName  = "DefaultLanguage_ID";
	public const string DefaultSkin_IDColumnName  = "DefaultSkin_ID";
	public const string WebsiteNameColumnName  = "WebsiteName";
	public const string MetaDescriptionDefaultColumnName  = "MetaDescriptionDefault";
	public const string MetaKeywordsDefaultColumnName  = "MetaKeywordsDefault";
	public const string MetaTitleDefaultColumnName  = "MetaTitleDefault";
	public const string GoogleAnalyticsColumnName  = "GoogleAnalytics";
	public const string OtherCodeColumnName  = "OtherCode";
	public const string FacebookPageIDColumnName  = "FacebookPageID";
	public const string CodeCheckVNColumnName  = "CodeCheckVN";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public SettingCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "Setting";
	}

	public SettingCollectionBase() : base()
	{
		this.TABLENAME = "Setting";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>Setting</c> table.
	/// </summary>
	/// <returns>An array of <see cref="SettingRow"/> objects.</returns>
	public virtual SettingRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>Setting</c> table.
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
	/// to retrieve all records from the <c>Setting</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("Setting_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="SettingRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="SettingRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public SettingRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			SettingRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="SettingRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="SettingRow"/> objects.</returns>
	public SettingRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="SettingRow"/> objects that 
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
	/// <returns>An array of <see cref="SettingRow"/> objects.</returns>
	public virtual SettingRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			SettingRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("Setting_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("Setting_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="SettingRow"/> by the primary key.
	/// </summary>
	/// <param name="setting_ID">The <c>Setting_ID</c> column value.</param>
	/// <returns>An instance of <see cref="SettingRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual SettingRow GetByPrimaryKey(int setting_ID)
	{
		string LOCATION = "GetByPrimaryKey(int setting_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("Setting_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Setting_ID", setting_ID);
			SettingRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>Setting</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SettingRow"/> object to be inserted.</param>
	public virtual void Insert(SettingRow value)
	{
		string LOCATION = "Insert(SettingRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Setting_Insert", CommandType.StoredProcedure);
					// AdminName
			if (value.IsAdminNameNull )
				AddParameter(cmd, "AdminName", DBNull.Value);
			else
				AddParameter(cmd, "AdminName", value.AdminName);
			
				// EmailSupport
			if (value.IsEmailSupportNull )
				AddParameter(cmd, "EmailSupport", DBNull.Value);
			else
				AddParameter(cmd, "EmailSupport", value.EmailSupport);
			
				// EmailOrder
			if (value.IsEmailOrderNull )
				AddParameter(cmd, "EmailOrder", DBNull.Value);
			else
				AddParameter(cmd, "EmailOrder", value.EmailOrder);
			
				// EmailSenderSMTP
			if (value.IsEmailSenderSMTPNull )
				AddParameter(cmd, "EmailSenderSMTP", DBNull.Value);
			else
				AddParameter(cmd, "EmailSenderSMTP", value.EmailSenderSMTP);
			
				// EmailSenderPort
			if (value.IsEmailSenderPortNull )
				AddParameter(cmd, "EmailSenderPort", DBNull.Value);
			else
				AddParameter(cmd, "EmailSenderPort", value.EmailSenderPort);
			
				// EmailSenderSSL
			if (value.IsEmailSenderSSLNull)
				AddParameter(cmd, "EmailSenderSSL", DBNull.Value);
			else
				AddParameter(cmd, "EmailSenderSSL", value.EmailSenderSSL);
			
				// EmailSender
			if (value.IsEmailSenderNull )
				AddParameter(cmd, "EmailSender", DBNull.Value);
			else
				AddParameter(cmd, "EmailSender", value.EmailSender);
			
				// EmailSenderPassword
			if (value.IsEmailSenderPasswordNull )
				AddParameter(cmd, "EmailSenderPassword", DBNull.Value);
			else
				AddParameter(cmd, "EmailSenderPassword", value.EmailSenderPassword);
			
				// Telephone
			if (value.IsTelephoneNull )
				AddParameter(cmd, "Telephone", DBNull.Value);
			else
				AddParameter(cmd, "Telephone", value.Telephone);
			
				// AppStatus
			if (value.IsAppStatusNull )
				AddParameter(cmd, "AppStatus", DBNull.Value);
			else
				AddParameter(cmd, "AppStatus", value.AppStatus);
			
				// Counter
			if (value.IsCounterNull)
				AddParameter(cmd, "Counter", DBNull.Value);
			else
				AddParameter(cmd, "Counter", value.Counter);
			
				// DefaultLanguage_ID
			if (value.IsDefaultLanguage_IDNull )
				AddParameter(cmd, "DefaultLanguage_ID", DBNull.Value);
			else
				AddParameter(cmd, "DefaultLanguage_ID", value.DefaultLanguage_ID);
			
				// DefaultSkin_ID
			if (value.IsDefaultSkin_IDNull )
				AddParameter(cmd, "DefaultSkin_ID", DBNull.Value);
			else
				AddParameter(cmd, "DefaultSkin_ID", value.DefaultSkin_ID);
			
				// WebsiteName
			if (value.IsWebsiteNameNull )
				AddParameter(cmd, "WebsiteName", DBNull.Value);
			else
				AddParameter(cmd, "WebsiteName", value.WebsiteName);
			
				// MetaDescriptionDefault
			if (value.IsMetaDescriptionDefaultNull )
				AddParameter(cmd, "MetaDescriptionDefault", DBNull.Value);
			else
				AddParameter(cmd, "MetaDescriptionDefault", value.MetaDescriptionDefault);
			
				// MetaKeywordsDefault
			if (value.IsMetaKeywordsDefaultNull )
				AddParameter(cmd, "MetaKeywordsDefault", DBNull.Value);
			else
				AddParameter(cmd, "MetaKeywordsDefault", value.MetaKeywordsDefault);
			
				// MetaTitleDefault
			if (value.IsMetaTitleDefaultNull )
				AddParameter(cmd, "MetaTitleDefault", DBNull.Value);
			else
				AddParameter(cmd, "MetaTitleDefault", value.MetaTitleDefault);
			
				// GoogleAnalytics
			if (value.IsGoogleAnalyticsNull )
				AddParameter(cmd, "GoogleAnalytics", DBNull.Value);
			else
				AddParameter(cmd, "GoogleAnalytics", value.GoogleAnalytics);
			
				// OtherCode
			if (value.IsOtherCodeNull )
				AddParameter(cmd, "OtherCode", DBNull.Value);
			else
				AddParameter(cmd, "OtherCode", value.OtherCode);
			
				// FacebookPageID
			if (value.IsFacebookPageIDNull )
				AddParameter(cmd, "FacebookPageID", DBNull.Value);
			else
				AddParameter(cmd, "FacebookPageID", value.FacebookPageID);
			
				// CodeCheckVN
			if (value.IsCodeCheckVNNull )
				AddParameter(cmd, "CodeCheckVN", DBNull.Value);
			else
				AddParameter(cmd, "CodeCheckVN", value.CodeCheckVN);
			
						value.Setting_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>Setting</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SettingRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(SettingRow value)
	{	
		string LOCATION = "Update(SettingRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Setting_Update", CommandType.StoredProcedure);
					// AdminName
			if (value.IsAdminNameNull)
				AddParameter(cmd, "AdminName", DBNull.Value);
			else
				AddParameter(cmd, "AdminName", value.AdminName);
				// EmailSupport
			if (value.IsEmailSupportNull)
				AddParameter(cmd, "EmailSupport", DBNull.Value);
			else
				AddParameter(cmd, "EmailSupport", value.EmailSupport);
				// EmailOrder
			if (value.IsEmailOrderNull)
				AddParameter(cmd, "EmailOrder", DBNull.Value);
			else
				AddParameter(cmd, "EmailOrder", value.EmailOrder);
				// EmailSenderSMTP
			if (value.IsEmailSenderSMTPNull)
				AddParameter(cmd, "EmailSenderSMTP", DBNull.Value);
			else
				AddParameter(cmd, "EmailSenderSMTP", value.EmailSenderSMTP);
				// EmailSenderPort
			if (value.IsEmailSenderPortNull)
				AddParameter(cmd, "EmailSenderPort", DBNull.Value);
			else
				AddParameter(cmd, "EmailSenderPort", value.EmailSenderPort);
				// EmailSenderSSL
			if (value.IsEmailSenderSSLNull)
				AddParameter(cmd, "EmailSenderSSL", DBNull.Value);
			else
				AddParameter(cmd, "EmailSenderSSL", value.EmailSenderSSL);
			
				// EmailSender
			if (value.IsEmailSenderNull)
				AddParameter(cmd, "EmailSender", DBNull.Value);
			else
				AddParameter(cmd, "EmailSender", value.EmailSender);
				// EmailSenderPassword
			if (value.IsEmailSenderPasswordNull)
				AddParameter(cmd, "EmailSenderPassword", DBNull.Value);
			else
				AddParameter(cmd, "EmailSenderPassword", value.EmailSenderPassword);
				// Telephone
			if (value.IsTelephoneNull)
				AddParameter(cmd, "Telephone", DBNull.Value);
			else
				AddParameter(cmd, "Telephone", value.Telephone);
				// AppStatus
			if (value.IsAppStatusNull)
				AddParameter(cmd, "AppStatus", DBNull.Value);
			else
				AddParameter(cmd, "AppStatus", value.AppStatus);
				// Counter
			if (value.IsCounterNull)
				AddParameter(cmd, "Counter", DBNull.Value);
			else
				AddParameter(cmd, "Counter", value.Counter);
			
				// DefaultLanguage_ID
			if (value.IsDefaultLanguage_IDNull)
				AddParameter(cmd, "DefaultLanguage_ID", DBNull.Value);
			else
				AddParameter(cmd, "DefaultLanguage_ID", value.DefaultLanguage_ID);
				// DefaultSkin_ID
			if (value.IsDefaultSkin_IDNull)
				AddParameter(cmd, "DefaultSkin_ID", DBNull.Value);
			else
				AddParameter(cmd, "DefaultSkin_ID", value.DefaultSkin_ID);
				// WebsiteName
			if (value.IsWebsiteNameNull)
				AddParameter(cmd, "WebsiteName", DBNull.Value);
			else
				AddParameter(cmd, "WebsiteName", value.WebsiteName);
				// MetaDescriptionDefault
			if (value.IsMetaDescriptionDefaultNull)
				AddParameter(cmd, "MetaDescriptionDefault", DBNull.Value);
			else
				AddParameter(cmd, "MetaDescriptionDefault", value.MetaDescriptionDefault);
				// MetaKeywordsDefault
			if (value.IsMetaKeywordsDefaultNull)
				AddParameter(cmd, "MetaKeywordsDefault", DBNull.Value);
			else
				AddParameter(cmd, "MetaKeywordsDefault", value.MetaKeywordsDefault);
				// MetaTitleDefault
			if (value.IsMetaTitleDefaultNull)
				AddParameter(cmd, "MetaTitleDefault", DBNull.Value);
			else
				AddParameter(cmd, "MetaTitleDefault", value.MetaTitleDefault);
				// GoogleAnalytics
			if (value.IsGoogleAnalyticsNull)
				AddParameter(cmd, "GoogleAnalytics", DBNull.Value);
			else
				AddParameter(cmd, "GoogleAnalytics", value.GoogleAnalytics);
				// OtherCode
			if (value.IsOtherCodeNull)
				AddParameter(cmd, "OtherCode", DBNull.Value);
			else
				AddParameter(cmd, "OtherCode", value.OtherCode);
				// FacebookPageID
			if (value.IsFacebookPageIDNull)
				AddParameter(cmd, "FacebookPageID", DBNull.Value);
			else
				AddParameter(cmd, "FacebookPageID", value.FacebookPageID);
				// CodeCheckVN
			if (value.IsCodeCheckVNNull)
				AddParameter(cmd, "CodeCheckVN", DBNull.Value);
			else
				AddParameter(cmd, "CodeCheckVN", value.CodeCheckVN);
					AddParameter(cmd, "Setting_ID", value.Setting_ID);
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
		/// Inserts or Updates a record in the <c>Setting</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="SettingRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(SettingRow value)
		{
			string LOCATION = "Save(SettingRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("Setting_Save",CommandType.StoredProcedure);
					// AdminName
				if (value.IsAdminNameNull)
					AddParameter(cmd, "AdminName", DBNull.Value);
				else
					AddParameter(cmd, "AdminName", (object)(value.AdminName));
				
					// EmailSupport
				if (value.IsEmailSupportNull)
					AddParameter(cmd, "EmailSupport", DBNull.Value);
				else
					AddParameter(cmd, "EmailSupport", (object)(value.EmailSupport));
				
					// EmailOrder
				if (value.IsEmailOrderNull)
					AddParameter(cmd, "EmailOrder", DBNull.Value);
				else
					AddParameter(cmd, "EmailOrder", (object)(value.EmailOrder));
				
					// EmailSenderSMTP
				if (value.IsEmailSenderSMTPNull)
					AddParameter(cmd, "EmailSenderSMTP", DBNull.Value);
				else
					AddParameter(cmd, "EmailSenderSMTP", (object)(value.EmailSenderSMTP));
				
					// EmailSenderPort
				if (value.IsEmailSenderPortNull)
					AddParameter(cmd, "EmailSenderPort", DBNull.Value);
				else
					AddParameter(cmd, "EmailSenderPort", (object)(value.EmailSenderPort));
				
					// EmailSenderSSL
				if (value.IsEmailSenderSSLNull)
					AddParameter(cmd, "EmailSenderSSL", DBNull.Value);
				else
					AddParameter(cmd, "EmailSenderSSL", (object)(value.EmailSenderSSL));
				
					// EmailSender
				if (value.IsEmailSenderNull)
					AddParameter(cmd, "EmailSender", DBNull.Value);
				else
					AddParameter(cmd, "EmailSender", (object)(value.EmailSender));
				
					// EmailSenderPassword
				if (value.IsEmailSenderPasswordNull)
					AddParameter(cmd, "EmailSenderPassword", DBNull.Value);
				else
					AddParameter(cmd, "EmailSenderPassword", (object)(value.EmailSenderPassword));
				
					// Telephone
				if (value.IsTelephoneNull)
					AddParameter(cmd, "Telephone", DBNull.Value);
				else
					AddParameter(cmd, "Telephone", (object)(value.Telephone));
				
					// AppStatus
				if (value.IsAppStatusNull)
					AddParameter(cmd, "AppStatus", DBNull.Value);
				else
					AddParameter(cmd, "AppStatus", (object)(value.AppStatus));
				
					// Counter
				if (value.IsCounterNull)
					AddParameter(cmd, "Counter", DBNull.Value);
				else
					AddParameter(cmd, "Counter", (object)(value.Counter));
				
					// DefaultLanguage_ID
				if (value.IsDefaultLanguage_IDNull)
					AddParameter(cmd, "DefaultLanguage_ID", DBNull.Value);
				else
					AddParameter(cmd, "DefaultLanguage_ID", (object)(value.DefaultLanguage_ID));
				
					// DefaultSkin_ID
				if (value.IsDefaultSkin_IDNull)
					AddParameter(cmd, "DefaultSkin_ID", DBNull.Value);
				else
					AddParameter(cmd, "DefaultSkin_ID", (object)(value.DefaultSkin_ID));
				
					// WebsiteName
				if (value.IsWebsiteNameNull)
					AddParameter(cmd, "WebsiteName", DBNull.Value);
				else
					AddParameter(cmd, "WebsiteName", (object)(value.WebsiteName));
				
					// MetaDescriptionDefault
				if (value.IsMetaDescriptionDefaultNull)
					AddParameter(cmd, "MetaDescriptionDefault", DBNull.Value);
				else
					AddParameter(cmd, "MetaDescriptionDefault", (object)(value.MetaDescriptionDefault));
				
					// MetaKeywordsDefault
				if (value.IsMetaKeywordsDefaultNull)
					AddParameter(cmd, "MetaKeywordsDefault", DBNull.Value);
				else
					AddParameter(cmd, "MetaKeywordsDefault", (object)(value.MetaKeywordsDefault));
				
					// MetaTitleDefault
				if (value.IsMetaTitleDefaultNull)
					AddParameter(cmd, "MetaTitleDefault", DBNull.Value);
				else
					AddParameter(cmd, "MetaTitleDefault", (object)(value.MetaTitleDefault));
				
					// GoogleAnalytics
				if (value.IsGoogleAnalyticsNull)
					AddParameter(cmd, "GoogleAnalytics", DBNull.Value);
				else
					AddParameter(cmd, "GoogleAnalytics", (object)(value.GoogleAnalytics));
				
					// OtherCode
				if (value.IsOtherCodeNull)
					AddParameter(cmd, "OtherCode", DBNull.Value);
				else
					AddParameter(cmd, "OtherCode", (object)(value.OtherCode));
				
					// FacebookPageID
				if (value.IsFacebookPageIDNull)
					AddParameter(cmd, "FacebookPageID", DBNull.Value);
				else
					AddParameter(cmd, "FacebookPageID", (object)(value.FacebookPageID));
				
					// CodeCheckVN
				if (value.IsCodeCheckVNNull)
					AddParameter(cmd, "CodeCheckVN", DBNull.Value);
				else
					AddParameter(cmd, "CodeCheckVN", (object)(value.CodeCheckVN));
				
						AddParameter(cmd, "Setting_ID", value.Setting_ID);
						value.Setting_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["Setting_ID"]);
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
	/// Deletes the specified object from the <c>Setting</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SettingRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(SettingRow value)
	{
		return DeleteByPrimaryKey(value.Setting_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>Setting</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="setting_ID">The <c>Setting_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int setting_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int setting_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Setting_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Setting_ID", setting_ID);
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
	/// Deletes <c>Setting</c> records that match the specified criteria.
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
	/// to delete <c>Setting</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("Setting_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>Setting</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("Setting_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="SettingRow"/> objects.</returns>
	protected SettingRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="SettingRow"/> objects.</returns>
	protected SettingRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="SettingRow"/> objects.</returns>
	protected virtual SettingRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Setting_ID
		int setting_IDColumnIndex = reader.GetOrdinal("Setting_ID");
		// AdminName
		int adminNameColumnIndex = reader.GetOrdinal("AdminName");
		// EmailSupport
		int emailSupportColumnIndex = reader.GetOrdinal("EmailSupport");
		// EmailOrder
		int emailOrderColumnIndex = reader.GetOrdinal("EmailOrder");
		// EmailSenderSMTP
		int emailSenderSMTPColumnIndex = reader.GetOrdinal("EmailSenderSMTP");
		// EmailSenderPort
		int emailSenderPortColumnIndex = reader.GetOrdinal("EmailSenderPort");
		// EmailSenderSSL
		int emailSenderSSLColumnIndex = reader.GetOrdinal("EmailSenderSSL");
		// EmailSender
		int emailSenderColumnIndex = reader.GetOrdinal("EmailSender");
		// EmailSenderPassword
		int emailSenderPasswordColumnIndex = reader.GetOrdinal("EmailSenderPassword");
		// Telephone
		int telephoneColumnIndex = reader.GetOrdinal("Telephone");
		// AppStatus
		int appStatusColumnIndex = reader.GetOrdinal("AppStatus");
		// Counter
		int counterColumnIndex = reader.GetOrdinal("Counter");
		// DefaultLanguage_ID
		int defaultLanguage_IDColumnIndex = reader.GetOrdinal("DefaultLanguage_ID");
		// DefaultSkin_ID
		int defaultSkin_IDColumnIndex = reader.GetOrdinal("DefaultSkin_ID");
		// WebsiteName
		int websiteNameColumnIndex = reader.GetOrdinal("WebsiteName");
		// MetaDescriptionDefault
		int metaDescriptionDefaultColumnIndex = reader.GetOrdinal("MetaDescriptionDefault");
		// MetaKeywordsDefault
		int metaKeywordsDefaultColumnIndex = reader.GetOrdinal("MetaKeywordsDefault");
		// MetaTitleDefault
		int metaTitleDefaultColumnIndex = reader.GetOrdinal("MetaTitleDefault");
		// GoogleAnalytics
		int googleAnalyticsColumnIndex = reader.GetOrdinal("GoogleAnalytics");
		// OtherCode
		int otherCodeColumnIndex = reader.GetOrdinal("OtherCode");
		// FacebookPageID
		int facebookPageIDColumnIndex = reader.GetOrdinal("FacebookPageID");
		// CodeCheckVN
		int codeCheckVNColumnIndex = reader.GetOrdinal("CodeCheckVN");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				SettingRow record = new SettingRow();
				recordList.Add(record);

					record.Setting_ID = Convert.ToInt32(reader.GetValue(setting_IDColumnIndex));
					if(!reader.IsDBNull(adminNameColumnIndex))
						record.AdminName = Convert.ToString(reader.GetValue(adminNameColumnIndex));
					if(!reader.IsDBNull(emailSupportColumnIndex))
						record.EmailSupport = Convert.ToString(reader.GetValue(emailSupportColumnIndex));
					if(!reader.IsDBNull(emailOrderColumnIndex))
						record.EmailOrder = Convert.ToString(reader.GetValue(emailOrderColumnIndex));
					if(!reader.IsDBNull(emailSenderSMTPColumnIndex))
						record.EmailSenderSMTP = Convert.ToString(reader.GetValue(emailSenderSMTPColumnIndex));
					if(!reader.IsDBNull(emailSenderPortColumnIndex))
						record.EmailSenderPort = Convert.ToString(reader.GetValue(emailSenderPortColumnIndex));
					if(!reader.IsDBNull(emailSenderSSLColumnIndex))
						record.EmailSenderSSL = Convert.ToBoolean(reader.GetValue(emailSenderSSLColumnIndex));
					if(!reader.IsDBNull(emailSenderColumnIndex))
						record.EmailSender = Convert.ToString(reader.GetValue(emailSenderColumnIndex));
					if(!reader.IsDBNull(emailSenderPasswordColumnIndex))
						record.EmailSenderPassword = Convert.ToString(reader.GetValue(emailSenderPasswordColumnIndex));
					if(!reader.IsDBNull(telephoneColumnIndex))
						record.Telephone = Convert.ToString(reader.GetValue(telephoneColumnIndex));
					record.AppStatus = Convert.ToBoolean(reader.GetValue(appStatusColumnIndex));
					if(!reader.IsDBNull(counterColumnIndex))
						record.Counter = Convert.ToInt32(reader.GetValue(counterColumnIndex));
					record.DefaultLanguage_ID = Convert.ToInt32(reader.GetValue(defaultLanguage_IDColumnIndex));
					record.DefaultSkin_ID = Convert.ToInt32(reader.GetValue(defaultSkin_IDColumnIndex));
					if(!reader.IsDBNull(websiteNameColumnIndex))
						record.WebsiteName = Convert.ToString(reader.GetValue(websiteNameColumnIndex));
					if(!reader.IsDBNull(metaDescriptionDefaultColumnIndex))
						record.MetaDescriptionDefault = Convert.ToString(reader.GetValue(metaDescriptionDefaultColumnIndex));
					if(!reader.IsDBNull(metaKeywordsDefaultColumnIndex))
						record.MetaKeywordsDefault = Convert.ToString(reader.GetValue(metaKeywordsDefaultColumnIndex));
					if(!reader.IsDBNull(metaTitleDefaultColumnIndex))
						record.MetaTitleDefault = Convert.ToString(reader.GetValue(metaTitleDefaultColumnIndex));
					if(!reader.IsDBNull(googleAnalyticsColumnIndex))
						record.GoogleAnalytics = Convert.ToString(reader.GetValue(googleAnalyticsColumnIndex));
					if(!reader.IsDBNull(otherCodeColumnIndex))
						record.OtherCode = Convert.ToString(reader.GetValue(otherCodeColumnIndex));
					if(!reader.IsDBNull(facebookPageIDColumnIndex))
						record.FacebookPageID = Convert.ToString(reader.GetValue(facebookPageIDColumnIndex));
					if(!reader.IsDBNull(codeCheckVNColumnIndex))
						record.CodeCheckVN = Convert.ToString(reader.GetValue(codeCheckVNColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (SettingRow[])(recordList.ToArray(typeof(SettingRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="SettingRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="SettingRow"/> object.</returns>
	protected virtual SettingRow MapRow(DataRow row)
	{
		string LOCATION = "SettingRow MapRow(DataRow row)";
		SettingRow mappedObject = new SettingRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Setting_ID"
		dataColumn = dataTable.Columns["Setting_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Setting_ID = (int)(row[dataColumn]);
		// Column "AdminName"
		dataColumn = dataTable.Columns["AdminName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AdminName = (string)(row[dataColumn]);
		// Column "EmailSupport"
		dataColumn = dataTable.Columns["EmailSupport"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EmailSupport = (string)(row[dataColumn]);
		// Column "EmailOrder"
		dataColumn = dataTable.Columns["EmailOrder"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EmailOrder = (string)(row[dataColumn]);
		// Column "EmailSenderSMTP"
		dataColumn = dataTable.Columns["EmailSenderSMTP"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EmailSenderSMTP = (string)(row[dataColumn]);
		// Column "EmailSenderPort"
		dataColumn = dataTable.Columns["EmailSenderPort"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EmailSenderPort = (string)(row[dataColumn]);
		// Column "EmailSenderSSL"
		dataColumn = dataTable.Columns["EmailSenderSSL"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EmailSenderSSL = (bool)(row[dataColumn]);
		// Column "EmailSender"
		dataColumn = dataTable.Columns["EmailSender"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EmailSender = (string)(row[dataColumn]);
		// Column "EmailSenderPassword"
		dataColumn = dataTable.Columns["EmailSenderPassword"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EmailSenderPassword = (string)(row[dataColumn]);
		// Column "Telephone"
		dataColumn = dataTable.Columns["Telephone"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Telephone = (string)(row[dataColumn]);
		// Column "AppStatus"
		dataColumn = dataTable.Columns["AppStatus"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AppStatus = (bool)(row[dataColumn]);
		// Column "Counter"
		dataColumn = dataTable.Columns["Counter"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Counter = (int)(row[dataColumn]);
		// Column "DefaultLanguage_ID"
		dataColumn = dataTable.Columns["DefaultLanguage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DefaultLanguage_ID = (int)(row[dataColumn]);
		// Column "DefaultSkin_ID"
		dataColumn = dataTable.Columns["DefaultSkin_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DefaultSkin_ID = (int)(row[dataColumn]);
		// Column "WebsiteName"
		dataColumn = dataTable.Columns["WebsiteName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WebsiteName = (string)(row[dataColumn]);
		// Column "MetaDescriptionDefault"
		dataColumn = dataTable.Columns["MetaDescriptionDefault"];
		if (! row.IsNull(dataColumn) )
			mappedObject.MetaDescriptionDefault = (string)(row[dataColumn]);
		// Column "MetaKeywordsDefault"
		dataColumn = dataTable.Columns["MetaKeywordsDefault"];
		if (! row.IsNull(dataColumn) )
			mappedObject.MetaKeywordsDefault = (string)(row[dataColumn]);
		// Column "MetaTitleDefault"
		dataColumn = dataTable.Columns["MetaTitleDefault"];
		if (! row.IsNull(dataColumn) )
			mappedObject.MetaTitleDefault = (string)(row[dataColumn]);
		// Column "GoogleAnalytics"
		dataColumn = dataTable.Columns["GoogleAnalytics"];
		if (! row.IsNull(dataColumn) )
			mappedObject.GoogleAnalytics = (string)(row[dataColumn]);
		// Column "OtherCode"
		dataColumn = dataTable.Columns["OtherCode"];
		if (! row.IsNull(dataColumn) )
			mappedObject.OtherCode = (string)(row[dataColumn]);
		// Column "FacebookPageID"
		dataColumn = dataTable.Columns["FacebookPageID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FacebookPageID = (string)(row[dataColumn]);
		// Column "CodeCheckVN"
		dataColumn = dataTable.Columns["CodeCheckVN"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CodeCheckVN = (string)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>Setting</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "Setting";
		DataColumn dataColumn;
		// Create the "Setting_ID" column
		dataColumn = dataTable.Columns.Add("Setting_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "AdminName" column
		dataColumn = dataTable.Columns.Add("AdminName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "EmailSupport" column
		dataColumn = dataTable.Columns.Add("EmailSupport", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "EmailOrder" column
		dataColumn = dataTable.Columns.Add("EmailOrder", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "EmailSenderSMTP" column
		dataColumn = dataTable.Columns.Add("EmailSenderSMTP", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "EmailSenderPort" column
		dataColumn = dataTable.Columns.Add("EmailSenderPort", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "EmailSenderSSL" column
		dataColumn = dataTable.Columns.Add("EmailSenderSSL", typeof(bool));
		// Create the "EmailSender" column
		dataColumn = dataTable.Columns.Add("EmailSender", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "EmailSenderPassword" column
		dataColumn = dataTable.Columns.Add("EmailSenderPassword", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Telephone" column
		dataColumn = dataTable.Columns.Add("Telephone", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "AppStatus" column
		dataColumn = dataTable.Columns.Add("AppStatus", typeof(bool));
		dataColumn.AllowDBNull = false;
		// Create the "Counter" column
		dataColumn = dataTable.Columns.Add("Counter", typeof(int));
		// Create the "DefaultLanguage_ID" column
		dataColumn = dataTable.Columns.Add("DefaultLanguage_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		// Create the "DefaultSkin_ID" column
		dataColumn = dataTable.Columns.Add("DefaultSkin_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		// Create the "WebsiteName" column
		dataColumn = dataTable.Columns.Add("WebsiteName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "MetaDescriptionDefault" column
		dataColumn = dataTable.Columns.Add("MetaDescriptionDefault", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "MetaKeywordsDefault" column
		dataColumn = dataTable.Columns.Add("MetaKeywordsDefault", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "MetaTitleDefault" column
		dataColumn = dataTable.Columns.Add("MetaTitleDefault", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "GoogleAnalytics" column
		dataColumn = dataTable.Columns.Add("GoogleAnalytics", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "OtherCode" column
		dataColumn = dataTable.Columns.Add("OtherCode", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "FacebookPageID" column
		dataColumn = dataTable.Columns.Add("FacebookPageID", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "CodeCheckVN" column
		dataColumn = dataTable.Columns.Add("CodeCheckVN", typeof(string));
		dataColumn.MaxLength = 500;
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
			case "Setting_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "AdminName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "EmailSupport":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "EmailOrder":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "EmailSenderSMTP":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "EmailSenderPort":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "EmailSenderSSL":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "EmailSender":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "EmailSenderPassword":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Telephone":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "AppStatus":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "Counter":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "DefaultLanguage_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "DefaultSkin_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "WebsiteName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "MetaDescriptionDefault":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "MetaKeywordsDefault":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "MetaTitleDefault":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "GoogleAnalytics":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "OtherCode":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "FacebookPageID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CodeCheckVN":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="SettingRow"/> by the primary key.
	/// </summary>
	/// <param name="setting_ID">The <c>Setting_ID</c> column value.</param>
	/// <returns>An instance of <see cref="SettingRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int setting_ID)
	{
		string LOCATION = "Exist(int setting_ID)";
		IDbCommand cmd = _db.CreateCommand("Setting_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Setting_ID", setting_ID);
		SettingRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




