
// <fileinfo name="Base\BNN_ConfigCollectionBase.cs">
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
/// The base class for <see cref="BNN_ConfigCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BNN_ConfigCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_ConfigCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Config_IDColumnName  = "Config_ID";
	public const string LogoColumnName  = "Logo";
	public const string CompanyNameColumnName  = "CompanyName";
	public const string TitleColumnName  = "Title";
	public const string MapColumnName  = "Map";
	public const string KeywordColumnName  = "Keyword";
	public const string DescriptionColumnName  = "Description";
	public const string FacebookColumnName  = "Facebook";
	public const string TwitterColumnName  = "Twitter";
	public const string YoutubeColumnName  = "Youtube";
	public const string GoogleColumnName  = "Google";
	public const string FooterColumnName  = "Footer";
	public const string DisplayNameColumnName  = "DisplayName";
	public const string EmailAddressColumnName  = "EmailAddress";
	public const string PasswordColumnName  = "Password";
	public const string SMTPServerColumnName  = "SMTPServer";
	public const string SMTPPortColumnName  = "SMTPPort";
	public const string IsSSLColumnName  = "IsSSL";
	public const string MailServerColumnName  = "MailServer";
	public const string ServerPortColumnName  = "ServerPort";
	public const string IntroductionColumnName  = "Introduction";
	public const string GuideColumnName  = "Guide";
	public const string Location_IDColumnName  = "Location_ID";
	public const string District_IDColumnName  = "District_ID";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public BNN_ConfigCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "BNN_Config";
	}

	public BNN_ConfigCollectionBase() : base()
	{
		this.TABLENAME = "BNN_Config";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>BNN_Config</c> table.
	/// </summary>
	/// <returns>An array of <see cref="BNN_ConfigRow"/> objects.</returns>
	public virtual BNN_ConfigRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>BNN_Config</c> table.
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
	/// to retrieve all records from the <c>BNN_Config</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("BNN_Config_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="BNN_ConfigRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="BNN_ConfigRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public BNN_ConfigRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			BNN_ConfigRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="BNN_ConfigRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="BNN_ConfigRow"/> objects.</returns>
	public BNN_ConfigRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="BNN_ConfigRow"/> objects that 
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
	/// <returns>An array of <see cref="BNN_ConfigRow"/> objects.</returns>
	public virtual BNN_ConfigRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			BNN_ConfigRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("BNN_Config_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("BNN_Config_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="BNN_ConfigRow"/> by the primary key.
	/// </summary>
	/// <param name="config_ID">The <c>Config_ID</c> column value.</param>
	/// <returns>An instance of <see cref="BNN_ConfigRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual BNN_ConfigRow GetByPrimaryKey(int config_ID)
	{
		string LOCATION = "GetByPrimaryKey(int config_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("BNN_Config_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Config_ID", config_ID);
			BNN_ConfigRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>BNN_Config</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BNN_ConfigRow"/> object to be inserted.</param>
	public virtual void Insert(BNN_ConfigRow value)
	{
		string LOCATION = "Insert(BNN_ConfigRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BNN_Config_Insert", CommandType.StoredProcedure);
					// Logo
			if (value.IsLogoNull )
				AddParameter(cmd, "Logo", DBNull.Value);
			else
				AddParameter(cmd, "Logo", value.Logo);
			
				// CompanyName
			if (value.IsCompanyNameNull )
				AddParameter(cmd, "CompanyName", DBNull.Value);
			else
				AddParameter(cmd, "CompanyName", value.CompanyName);
			
				// Title
			if (value.IsTitleNull )
				AddParameter(cmd, "Title", DBNull.Value);
			else
				AddParameter(cmd, "Title", value.Title);
			
				// Map
			if (value.IsMapNull )
				AddParameter(cmd, "Map", DBNull.Value);
			else
				AddParameter(cmd, "Map", value.Map);
			
				// Keyword
			if (value.IsKeywordNull )
				AddParameter(cmd, "Keyword", DBNull.Value);
			else
				AddParameter(cmd, "Keyword", value.Keyword);
			
				// Description
			if (value.IsDescriptionNull )
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
			
				// Facebook
			if (value.IsFacebookNull )
				AddParameter(cmd, "Facebook", DBNull.Value);
			else
				AddParameter(cmd, "Facebook", value.Facebook);
			
				// Twitter
			if (value.IsTwitterNull )
				AddParameter(cmd, "Twitter", DBNull.Value);
			else
				AddParameter(cmd, "Twitter", value.Twitter);
			
				// Youtube
			if (value.IsYoutubeNull )
				AddParameter(cmd, "Youtube", DBNull.Value);
			else
				AddParameter(cmd, "Youtube", value.Youtube);
			
				// Google
			if (value.IsGoogleNull )
				AddParameter(cmd, "Google", DBNull.Value);
			else
				AddParameter(cmd, "Google", value.Google);
			
				// Footer
			if (value.IsFooterNull )
				AddParameter(cmd, "Footer", DBNull.Value);
			else
				AddParameter(cmd, "Footer", value.Footer);
			
				// DisplayName
			if (value.IsDisplayNameNull )
				AddParameter(cmd, "DisplayName", DBNull.Value);
			else
				AddParameter(cmd, "DisplayName", value.DisplayName);
			
				// EmailAddress
			if (value.IsEmailAddressNull )
				AddParameter(cmd, "EmailAddress", DBNull.Value);
			else
				AddParameter(cmd, "EmailAddress", value.EmailAddress);
			
				// Password
			if (value.IsPasswordNull )
				AddParameter(cmd, "Password", DBNull.Value);
			else
				AddParameter(cmd, "Password", value.Password);
			
				// SMTPServer
			if (value.IsSMTPServerNull )
				AddParameter(cmd, "SMTPServer", DBNull.Value);
			else
				AddParameter(cmd, "SMTPServer", value.SMTPServer);
			
				// SMTPPort
			if (value.IsSMTPPortNull)
				AddParameter(cmd, "SMTPPort", DBNull.Value);
			else
				AddParameter(cmd, "SMTPPort", value.SMTPPort);
			
				// IsSSL
			if (value.IsIsSSLNull)
				AddParameter(cmd, "IsSSL", DBNull.Value);
			else
				AddParameter(cmd, "IsSSL", value.IsSSL);
			
				// MailServer
			if (value.IsMailServerNull )
				AddParameter(cmd, "MailServer", DBNull.Value);
			else
				AddParameter(cmd, "MailServer", value.MailServer);
			
				// ServerPort
			if (value.IsServerPortNull)
				AddParameter(cmd, "ServerPort", DBNull.Value);
			else
				AddParameter(cmd, "ServerPort", value.ServerPort);
			
				// Introduction
			if (value.IsIntroductionNull )
				AddParameter(cmd, "Introduction", DBNull.Value);
			else
				AddParameter(cmd, "Introduction", value.Introduction);
			
				// Guide
			if (value.IsGuideNull )
				AddParameter(cmd, "Guide", DBNull.Value);
			else
				AddParameter(cmd, "Guide", value.Guide);
			
				// Location_ID
			if (value.IsLocation_IDNull)
				AddParameter(cmd, "Location_ID", DBNull.Value);
			else
				AddParameter(cmd, "Location_ID", value.Location_ID);
			
				// District_ID
			if (value.IsDistrict_IDNull)
				AddParameter(cmd, "District_ID", DBNull.Value);
			else
				AddParameter(cmd, "District_ID", value.District_ID);
			
						value.Config_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>BNN_Config</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BNN_ConfigRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(BNN_ConfigRow value)
	{	
		string LOCATION = "Update(BNN_ConfigRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BNN_Config_Update", CommandType.StoredProcedure);
					// Logo
			if (value.IsLogoNull)
				AddParameter(cmd, "Logo", DBNull.Value);
			else
				AddParameter(cmd, "Logo", value.Logo);
				// CompanyName
			if (value.IsCompanyNameNull)
				AddParameter(cmd, "CompanyName", DBNull.Value);
			else
				AddParameter(cmd, "CompanyName", value.CompanyName);
				// Title
			if (value.IsTitleNull)
				AddParameter(cmd, "Title", DBNull.Value);
			else
				AddParameter(cmd, "Title", value.Title);
				// Map
			if (value.IsMapNull)
				AddParameter(cmd, "Map", DBNull.Value);
			else
				AddParameter(cmd, "Map", value.Map);
				// Keyword
			if (value.IsKeywordNull)
				AddParameter(cmd, "Keyword", DBNull.Value);
			else
				AddParameter(cmd, "Keyword", value.Keyword);
				// Description
			if (value.IsDescriptionNull)
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
				// Facebook
			if (value.IsFacebookNull)
				AddParameter(cmd, "Facebook", DBNull.Value);
			else
				AddParameter(cmd, "Facebook", value.Facebook);
				// Twitter
			if (value.IsTwitterNull)
				AddParameter(cmd, "Twitter", DBNull.Value);
			else
				AddParameter(cmd, "Twitter", value.Twitter);
				// Youtube
			if (value.IsYoutubeNull)
				AddParameter(cmd, "Youtube", DBNull.Value);
			else
				AddParameter(cmd, "Youtube", value.Youtube);
				// Google
			if (value.IsGoogleNull)
				AddParameter(cmd, "Google", DBNull.Value);
			else
				AddParameter(cmd, "Google", value.Google);
				// Footer
			if (value.IsFooterNull)
				AddParameter(cmd, "Footer", DBNull.Value);
			else
				AddParameter(cmd, "Footer", value.Footer);
				// DisplayName
			if (value.IsDisplayNameNull)
				AddParameter(cmd, "DisplayName", DBNull.Value);
			else
				AddParameter(cmd, "DisplayName", value.DisplayName);
				// EmailAddress
			if (value.IsEmailAddressNull)
				AddParameter(cmd, "EmailAddress", DBNull.Value);
			else
				AddParameter(cmd, "EmailAddress", value.EmailAddress);
				// Password
			if (value.IsPasswordNull)
				AddParameter(cmd, "Password", DBNull.Value);
			else
				AddParameter(cmd, "Password", value.Password);
				// SMTPServer
			if (value.IsSMTPServerNull)
				AddParameter(cmd, "SMTPServer", DBNull.Value);
			else
				AddParameter(cmd, "SMTPServer", value.SMTPServer);
				// SMTPPort
			if (value.IsSMTPPortNull)
				AddParameter(cmd, "SMTPPort", DBNull.Value);
			else
				AddParameter(cmd, "SMTPPort", value.SMTPPort);
			
				// IsSSL
			if (value.IsIsSSLNull)
				AddParameter(cmd, "IsSSL", DBNull.Value);
			else
				AddParameter(cmd, "IsSSL", value.IsSSL);
			
				// MailServer
			if (value.IsMailServerNull)
				AddParameter(cmd, "MailServer", DBNull.Value);
			else
				AddParameter(cmd, "MailServer", value.MailServer);
				// ServerPort
			if (value.IsServerPortNull)
				AddParameter(cmd, "ServerPort", DBNull.Value);
			else
				AddParameter(cmd, "ServerPort", value.ServerPort);
			
				// Introduction
			if (value.IsIntroductionNull)
				AddParameter(cmd, "Introduction", DBNull.Value);
			else
				AddParameter(cmd, "Introduction", value.Introduction);
				// Guide
			if (value.IsGuideNull)
				AddParameter(cmd, "Guide", DBNull.Value);
			else
				AddParameter(cmd, "Guide", value.Guide);
				// Location_ID
			if (value.IsLocation_IDNull)
				AddParameter(cmd, "Location_ID", DBNull.Value);
			else
				AddParameter(cmd, "Location_ID", value.Location_ID);
			
				// District_ID
			if (value.IsDistrict_IDNull)
				AddParameter(cmd, "District_ID", DBNull.Value);
			else
				AddParameter(cmd, "District_ID", value.District_ID);
			
					AddParameter(cmd, "Config_ID", value.Config_ID);
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
		/// Inserts or Updates a record in the <c>BNN_Config</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="BNN_ConfigRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(BNN_ConfigRow value)
		{
			string LOCATION = "Save(BNN_ConfigRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("BNN_Config_Save",CommandType.StoredProcedure);
					// Logo
				if (value.IsLogoNull)
					AddParameter(cmd, "Logo", DBNull.Value);
				else
					AddParameter(cmd, "Logo", (object)(value.Logo));
				
					// CompanyName
				if (value.IsCompanyNameNull)
					AddParameter(cmd, "CompanyName", DBNull.Value);
				else
					AddParameter(cmd, "CompanyName", (object)(value.CompanyName));
				
					// Title
				if (value.IsTitleNull)
					AddParameter(cmd, "Title", DBNull.Value);
				else
					AddParameter(cmd, "Title", (object)(value.Title));
				
					// Map
				if (value.IsMapNull)
					AddParameter(cmd, "Map", DBNull.Value);
				else
					AddParameter(cmd, "Map", (object)(value.Map));
				
					// Keyword
				if (value.IsKeywordNull)
					AddParameter(cmd, "Keyword", DBNull.Value);
				else
					AddParameter(cmd, "Keyword", (object)(value.Keyword));
				
					// Description
				if (value.IsDescriptionNull)
					AddParameter(cmd, "Description", DBNull.Value);
				else
					AddParameter(cmd, "Description", (object)(value.Description));
				
					// Facebook
				if (value.IsFacebookNull)
					AddParameter(cmd, "Facebook", DBNull.Value);
				else
					AddParameter(cmd, "Facebook", (object)(value.Facebook));
				
					// Twitter
				if (value.IsTwitterNull)
					AddParameter(cmd, "Twitter", DBNull.Value);
				else
					AddParameter(cmd, "Twitter", (object)(value.Twitter));
				
					// Youtube
				if (value.IsYoutubeNull)
					AddParameter(cmd, "Youtube", DBNull.Value);
				else
					AddParameter(cmd, "Youtube", (object)(value.Youtube));
				
					// Google
				if (value.IsGoogleNull)
					AddParameter(cmd, "Google", DBNull.Value);
				else
					AddParameter(cmd, "Google", (object)(value.Google));
				
					// Footer
				if (value.IsFooterNull)
					AddParameter(cmd, "Footer", DBNull.Value);
				else
					AddParameter(cmd, "Footer", (object)(value.Footer));
				
					// DisplayName
				if (value.IsDisplayNameNull)
					AddParameter(cmd, "DisplayName", DBNull.Value);
				else
					AddParameter(cmd, "DisplayName", (object)(value.DisplayName));
				
					// EmailAddress
				if (value.IsEmailAddressNull)
					AddParameter(cmd, "EmailAddress", DBNull.Value);
				else
					AddParameter(cmd, "EmailAddress", (object)(value.EmailAddress));
				
					// Password
				if (value.IsPasswordNull)
					AddParameter(cmd, "Password", DBNull.Value);
				else
					AddParameter(cmd, "Password", (object)(value.Password));
				
					// SMTPServer
				if (value.IsSMTPServerNull)
					AddParameter(cmd, "SMTPServer", DBNull.Value);
				else
					AddParameter(cmd, "SMTPServer", (object)(value.SMTPServer));
				
					// SMTPPort
				if (value.IsSMTPPortNull)
					AddParameter(cmd, "SMTPPort", DBNull.Value);
				else
					AddParameter(cmd, "SMTPPort", (object)(value.SMTPPort));
				
					// IsSSL
				if (value.IsIsSSLNull)
					AddParameter(cmd, "IsSSL", DBNull.Value);
				else
					AddParameter(cmd, "IsSSL", (object)(value.IsSSL));
				
					// MailServer
				if (value.IsMailServerNull)
					AddParameter(cmd, "MailServer", DBNull.Value);
				else
					AddParameter(cmd, "MailServer", (object)(value.MailServer));
				
					// ServerPort
				if (value.IsServerPortNull)
					AddParameter(cmd, "ServerPort", DBNull.Value);
				else
					AddParameter(cmd, "ServerPort", (object)(value.ServerPort));
				
					// Introduction
				if (value.IsIntroductionNull)
					AddParameter(cmd, "Introduction", DBNull.Value);
				else
					AddParameter(cmd, "Introduction", (object)(value.Introduction));
				
					// Guide
				if (value.IsGuideNull)
					AddParameter(cmd, "Guide", DBNull.Value);
				else
					AddParameter(cmd, "Guide", (object)(value.Guide));
				
					// Location_ID
				if (value.IsLocation_IDNull)
					AddParameter(cmd, "Location_ID", DBNull.Value);
				else
					AddParameter(cmd, "Location_ID", (object)(value.Location_ID));
				
					// District_ID
				if (value.IsDistrict_IDNull)
					AddParameter(cmd, "District_ID", DBNull.Value);
				else
					AddParameter(cmd, "District_ID", (object)(value.District_ID));
				
						AddParameter(cmd, "Config_ID", value.Config_ID);
						value.Config_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["Config_ID"]);
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
	/// Deletes the specified object from the <c>BNN_Config</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BNN_ConfigRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(BNN_ConfigRow value)
	{
		return DeleteByPrimaryKey(value.Config_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>BNN_Config</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="config_ID">The <c>Config_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int config_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int config_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BNN_Config_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Config_ID", config_ID);
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
	/// Deletes <c>BNN_Config</c> records that match the specified criteria.
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
	/// to delete <c>BNN_Config</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("BNN_Config_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>BNN_Config</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("BNN_Config_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="BNN_ConfigRow"/> objects.</returns>
	protected BNN_ConfigRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="BNN_ConfigRow"/> objects.</returns>
	protected BNN_ConfigRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="BNN_ConfigRow"/> objects.</returns>
	protected virtual BNN_ConfigRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Config_ID
		int config_IDColumnIndex = reader.GetOrdinal("Config_ID");
		// Logo
		int logoColumnIndex = reader.GetOrdinal("Logo");
		// CompanyName
		int companyNameColumnIndex = reader.GetOrdinal("CompanyName");
		// Title
		int titleColumnIndex = reader.GetOrdinal("Title");
		// Map
		int mapColumnIndex = reader.GetOrdinal("Map");
		// Keyword
		int keywordColumnIndex = reader.GetOrdinal("Keyword");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// Facebook
		int facebookColumnIndex = reader.GetOrdinal("Facebook");
		// Twitter
		int twitterColumnIndex = reader.GetOrdinal("Twitter");
		// Youtube
		int youtubeColumnIndex = reader.GetOrdinal("Youtube");
		// Google
		int googleColumnIndex = reader.GetOrdinal("Google");
		// Footer
		int footerColumnIndex = reader.GetOrdinal("Footer");
		// DisplayName
		int displayNameColumnIndex = reader.GetOrdinal("DisplayName");
		// EmailAddress
		int emailAddressColumnIndex = reader.GetOrdinal("EmailAddress");
		// Password
		int passwordColumnIndex = reader.GetOrdinal("Password");
		// SMTPServer
		int sMTPServerColumnIndex = reader.GetOrdinal("SMTPServer");
		// SMTPPort
		int sMTPPortColumnIndex = reader.GetOrdinal("SMTPPort");
		// IsSSL
		int isSSLColumnIndex = reader.GetOrdinal("IsSSL");
		// MailServer
		int mailServerColumnIndex = reader.GetOrdinal("MailServer");
		// ServerPort
		int serverPortColumnIndex = reader.GetOrdinal("ServerPort");
		// Introduction
		int introductionColumnIndex = reader.GetOrdinal("Introduction");
		// Guide
		int guideColumnIndex = reader.GetOrdinal("Guide");
		// Location_ID
		int location_IDColumnIndex = reader.GetOrdinal("Location_ID");
		// District_ID
		int district_IDColumnIndex = reader.GetOrdinal("District_ID");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				BNN_ConfigRow record = new BNN_ConfigRow();
				recordList.Add(record);

					record.Config_ID = Convert.ToInt32(reader.GetValue(config_IDColumnIndex));
					if(!reader.IsDBNull(logoColumnIndex))
						record.Logo = Convert.ToString(reader.GetValue(logoColumnIndex));
					if(!reader.IsDBNull(companyNameColumnIndex))
						record.CompanyName = Convert.ToString(reader.GetValue(companyNameColumnIndex));
					if(!reader.IsDBNull(titleColumnIndex))
						record.Title = Convert.ToString(reader.GetValue(titleColumnIndex));
					if(!reader.IsDBNull(mapColumnIndex))
						record.Map = Convert.ToString(reader.GetValue(mapColumnIndex));
					if(!reader.IsDBNull(keywordColumnIndex))
						record.Keyword = Convert.ToString(reader.GetValue(keywordColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(facebookColumnIndex))
						record.Facebook = Convert.ToString(reader.GetValue(facebookColumnIndex));
					if(!reader.IsDBNull(twitterColumnIndex))
						record.Twitter = Convert.ToString(reader.GetValue(twitterColumnIndex));
					if(!reader.IsDBNull(youtubeColumnIndex))
						record.Youtube = Convert.ToString(reader.GetValue(youtubeColumnIndex));
					if(!reader.IsDBNull(googleColumnIndex))
						record.Google = Convert.ToString(reader.GetValue(googleColumnIndex));
					if(!reader.IsDBNull(footerColumnIndex))
						record.Footer = Convert.ToString(reader.GetValue(footerColumnIndex));
					if(!reader.IsDBNull(displayNameColumnIndex))
						record.DisplayName = Convert.ToString(reader.GetValue(displayNameColumnIndex));
					if(!reader.IsDBNull(emailAddressColumnIndex))
						record.EmailAddress = Convert.ToString(reader.GetValue(emailAddressColumnIndex));
					if(!reader.IsDBNull(passwordColumnIndex))
						record.Password = Convert.ToString(reader.GetValue(passwordColumnIndex));
					if(!reader.IsDBNull(sMTPServerColumnIndex))
						record.SMTPServer = Convert.ToString(reader.GetValue(sMTPServerColumnIndex));
					if(!reader.IsDBNull(sMTPPortColumnIndex))
						record.SMTPPort = Convert.ToInt32(reader.GetValue(sMTPPortColumnIndex));
					if(!reader.IsDBNull(isSSLColumnIndex))
						record.IsSSL = Convert.ToBoolean(reader.GetValue(isSSLColumnIndex));
					if(!reader.IsDBNull(mailServerColumnIndex))
						record.MailServer = Convert.ToString(reader.GetValue(mailServerColumnIndex));
					if(!reader.IsDBNull(serverPortColumnIndex))
						record.ServerPort = Convert.ToInt32(reader.GetValue(serverPortColumnIndex));
					if(!reader.IsDBNull(introductionColumnIndex))
						record.Introduction = Convert.ToString(reader.GetValue(introductionColumnIndex));
					if(!reader.IsDBNull(guideColumnIndex))
						record.Guide = Convert.ToString(reader.GetValue(guideColumnIndex));
					if(!reader.IsDBNull(location_IDColumnIndex))
						record.Location_ID = Convert.ToInt32(reader.GetValue(location_IDColumnIndex));
					if(!reader.IsDBNull(district_IDColumnIndex))
						record.District_ID = Convert.ToInt32(reader.GetValue(district_IDColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (BNN_ConfigRow[])(recordList.ToArray(typeof(BNN_ConfigRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="BNN_ConfigRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="BNN_ConfigRow"/> object.</returns>
	protected virtual BNN_ConfigRow MapRow(DataRow row)
	{
		string LOCATION = "BNN_ConfigRow MapRow(DataRow row)";
		BNN_ConfigRow mappedObject = new BNN_ConfigRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Config_ID"
		dataColumn = dataTable.Columns["Config_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Config_ID = (int)(row[dataColumn]);
		// Column "Logo"
		dataColumn = dataTable.Columns["Logo"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Logo = (string)(row[dataColumn]);
		// Column "CompanyName"
		dataColumn = dataTable.Columns["CompanyName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CompanyName = (string)(row[dataColumn]);
		// Column "Title"
		dataColumn = dataTable.Columns["Title"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Title = (string)(row[dataColumn]);
		// Column "Map"
		dataColumn = dataTable.Columns["Map"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Map = (string)(row[dataColumn]);
		// Column "Keyword"
		dataColumn = dataTable.Columns["Keyword"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Keyword = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "Facebook"
		dataColumn = dataTable.Columns["Facebook"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Facebook = (string)(row[dataColumn]);
		// Column "Twitter"
		dataColumn = dataTable.Columns["Twitter"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Twitter = (string)(row[dataColumn]);
		// Column "Youtube"
		dataColumn = dataTable.Columns["Youtube"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Youtube = (string)(row[dataColumn]);
		// Column "Google"
		dataColumn = dataTable.Columns["Google"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Google = (string)(row[dataColumn]);
		// Column "Footer"
		dataColumn = dataTable.Columns["Footer"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Footer = (string)(row[dataColumn]);
		// Column "DisplayName"
		dataColumn = dataTable.Columns["DisplayName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DisplayName = (string)(row[dataColumn]);
		// Column "EmailAddress"
		dataColumn = dataTable.Columns["EmailAddress"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EmailAddress = (string)(row[dataColumn]);
		// Column "Password"
		dataColumn = dataTable.Columns["Password"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Password = (string)(row[dataColumn]);
		// Column "SMTPServer"
		dataColumn = dataTable.Columns["SMTPServer"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SMTPServer = (string)(row[dataColumn]);
		// Column "SMTPPort"
		dataColumn = dataTable.Columns["SMTPPort"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SMTPPort = (int)(row[dataColumn]);
		// Column "IsSSL"
		dataColumn = dataTable.Columns["IsSSL"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IsSSL = (bool)(row[dataColumn]);
		// Column "MailServer"
		dataColumn = dataTable.Columns["MailServer"];
		if (! row.IsNull(dataColumn) )
			mappedObject.MailServer = (string)(row[dataColumn]);
		// Column "ServerPort"
		dataColumn = dataTable.Columns["ServerPort"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ServerPort = (int)(row[dataColumn]);
		// Column "Introduction"
		dataColumn = dataTable.Columns["Introduction"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Introduction = (string)(row[dataColumn]);
		// Column "Guide"
		dataColumn = dataTable.Columns["Guide"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Guide = (string)(row[dataColumn]);
		// Column "Location_ID"
		dataColumn = dataTable.Columns["Location_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location_ID = (int)(row[dataColumn]);
		// Column "District_ID"
		dataColumn = dataTable.Columns["District_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.District_ID = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>BNN_Config</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "BNN_Config";
		DataColumn dataColumn;
		// Create the "Config_ID" column
		dataColumn = dataTable.Columns.Add("Config_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "Logo" column
		dataColumn = dataTable.Columns.Add("Logo", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "CompanyName" column
		dataColumn = dataTable.Columns.Add("CompanyName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Title" column
		dataColumn = dataTable.Columns.Add("Title", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Map" column
		dataColumn = dataTable.Columns.Add("Map", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Keyword" column
		dataColumn = dataTable.Columns.Add("Keyword", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "Facebook" column
		dataColumn = dataTable.Columns.Add("Facebook", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Twitter" column
		dataColumn = dataTable.Columns.Add("Twitter", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Youtube" column
		dataColumn = dataTable.Columns.Add("Youtube", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Google" column
		dataColumn = dataTable.Columns.Add("Google", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Footer" column
		dataColumn = dataTable.Columns.Add("Footer", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "DisplayName" column
		dataColumn = dataTable.Columns.Add("DisplayName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "EmailAddress" column
		dataColumn = dataTable.Columns.Add("EmailAddress", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Password" column
		dataColumn = dataTable.Columns.Add("Password", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "SMTPServer" column
		dataColumn = dataTable.Columns.Add("SMTPServer", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "SMTPPort" column
		dataColumn = dataTable.Columns.Add("SMTPPort", typeof(int));
		// Create the "IsSSL" column
		dataColumn = dataTable.Columns.Add("IsSSL", typeof(bool));
		// Create the "MailServer" column
		dataColumn = dataTable.Columns.Add("MailServer", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ServerPort" column
		dataColumn = dataTable.Columns.Add("ServerPort", typeof(int));
		// Create the "Introduction" column
		dataColumn = dataTable.Columns.Add("Introduction", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Guide" column
		dataColumn = dataTable.Columns.Add("Guide", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Location_ID" column
		dataColumn = dataTable.Columns.Add("Location_ID", typeof(int));
		// Create the "District_ID" column
		dataColumn = dataTable.Columns.Add("District_ID", typeof(int));
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
			case "Config_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Logo":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CompanyName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Title":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Map":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Keyword":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Facebook":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Twitter":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Youtube":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Google":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Footer":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DisplayName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "EmailAddress":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Password":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SMTPServer":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SMTPPort":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "IsSSL":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "MailServer":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ServerPort":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Introduction":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Guide":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Location_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "District_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="BNN_ConfigRow"/> by the primary key.
	/// </summary>
	/// <param name="config_ID">The <c>Config_ID</c> column value.</param>
	/// <returns>An instance of <see cref="BNN_ConfigRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int config_ID)
	{
		string LOCATION = "Exist(int config_ID)";
		IDbCommand cmd = _db.CreateCommand("BNN_Config_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Config_ID", config_ID);
		BNN_ConfigRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




