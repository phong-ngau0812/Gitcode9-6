
// <fileinfo name="Base\BaoHiemCollectionBase.cs">
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
/// The base class for <see cref="BaoHiemCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BaoHiemCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BaoHiemCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string BaoHiem_IDColumnName  = "BaoHiem_ID";
	public const string HoTenColumnName  = "HoTen";
	public const string SDTColumnName  = "SDT";
	public const string DiaChiColumnName  = "DiaChi";
	public const string BienXeColumnName  = "BienXe";
	public const string SoKhungColumnName  = "SoKhung";
	public const string SoMayColumnName  = "SoMay";
	public const string LoaiXeColumnName  = "LoaiXe";
	public const string TrongTaiColumnName  = "TrongTai";
	public const string SoChoNgoiColumnName  = "SoChoNgoi";
	public const string MucDichSuDungColumnName  = "MucDichSuDung";
	public const string TenDNBaoHiemColumnName  = "TenDNBaoHiem";
	public const string DiaChiDNBaoHiemColumnName  = "DiaChiDNBaoHiem";
	public const string SDTDNBaoHiemColumnName  = "SDTDNBaoHiem";
	public const string MucTrachNhiemColumnName  = "MucTrachNhiem";
	public const string TrachNhiemChuXeColumnName  = "TrachNhiemChuXe";
	public const string ThoiHanBaoHiemColumnName  = "ThoiHanBaoHiem";
	public const string PhiBaoHiemColumnName  = "PhiBaoHiem";
	public const string ThoiHanThanhToanColumnName  = "ThoiHanThanhToan";
	public const string NgayCapColumnName  = "NgayCap";
	public const string GhiChuColumnName  = "GhiChu";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditedByColumnName  = "LastEditedBy";
	public const string LastEditedDateColumnName  = "LastEditedDate";
	public const string ActiveColumnName  = "Active";
	public const string SortColumnName  = "Sort";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public BaoHiemCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "BaoHiem";
	}

	public BaoHiemCollectionBase() : base()
	{
		this.TABLENAME = "BaoHiem";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>BaoHiem</c> table.
	/// </summary>
	/// <returns>An array of <see cref="BaoHiemRow"/> objects.</returns>
	public virtual BaoHiemRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>BaoHiem</c> table.
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
	/// to retrieve all records from the <c>BaoHiem</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("BaoHiem_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="BaoHiemRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="BaoHiemRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public BaoHiemRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			BaoHiemRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="BaoHiemRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="BaoHiemRow"/> objects.</returns>
	public BaoHiemRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="BaoHiemRow"/> objects that 
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
	/// <returns>An array of <see cref="BaoHiemRow"/> objects.</returns>
	public virtual BaoHiemRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			BaoHiemRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("BaoHiem_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("BaoHiem_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="BaoHiemRow"/> by the primary key.
	/// </summary>
	/// <param name="baoHiem_ID">The <c>BaoHiem_ID</c> column value.</param>
	/// <returns>An instance of <see cref="BaoHiemRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual BaoHiemRow GetByPrimaryKey(int baoHiem_ID)
	{
		string LOCATION = "GetByPrimaryKey(int baoHiem_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("BaoHiem_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "BaoHiem_ID", baoHiem_ID);
			BaoHiemRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>BaoHiem</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BaoHiemRow"/> object to be inserted.</param>
	public virtual void Insert(BaoHiemRow value)
	{
		string LOCATION = "Insert(BaoHiemRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BaoHiem_Insert", CommandType.StoredProcedure);
					// HoTen
			if (value.IsHoTenNull )
				AddParameter(cmd, "HoTen", DBNull.Value);
			else
				AddParameter(cmd, "HoTen", value.HoTen);
			
				// SDT
			if (value.IsSDTNull )
				AddParameter(cmd, "SDT", DBNull.Value);
			else
				AddParameter(cmd, "SDT", value.SDT);
			
				// DiaChi
			if (value.IsDiaChiNull )
				AddParameter(cmd, "DiaChi", DBNull.Value);
			else
				AddParameter(cmd, "DiaChi", value.DiaChi);
			
				// BienXe
			if (value.IsBienXeNull )
				AddParameter(cmd, "BienXe", DBNull.Value);
			else
				AddParameter(cmd, "BienXe", value.BienXe);
			
				// SoKhung
			if (value.IsSoKhungNull )
				AddParameter(cmd, "SoKhung", DBNull.Value);
			else
				AddParameter(cmd, "SoKhung", value.SoKhung);
			
				// SoMay
			if (value.IsSoMayNull )
				AddParameter(cmd, "SoMay", DBNull.Value);
			else
				AddParameter(cmd, "SoMay", value.SoMay);
			
				// LoaiXe
			if (value.IsLoaiXeNull )
				AddParameter(cmd, "LoaiXe", DBNull.Value);
			else
				AddParameter(cmd, "LoaiXe", value.LoaiXe);
			
				// TrongTai
			if (value.IsTrongTaiNull )
				AddParameter(cmd, "TrongTai", DBNull.Value);
			else
				AddParameter(cmd, "TrongTai", value.TrongTai);
			
				// SoChoNgoi
			if (value.IsSoChoNgoiNull )
				AddParameter(cmd, "SoChoNgoi", DBNull.Value);
			else
				AddParameter(cmd, "SoChoNgoi", value.SoChoNgoi);
			
				// MucDichSuDung
			if (value.IsMucDichSuDungNull )
				AddParameter(cmd, "MucDichSuDung", DBNull.Value);
			else
				AddParameter(cmd, "MucDichSuDung", value.MucDichSuDung);
			
				// TenDNBaoHiem
			if (value.IsTenDNBaoHiemNull )
				AddParameter(cmd, "TenDNBaoHiem", DBNull.Value);
			else
				AddParameter(cmd, "TenDNBaoHiem", value.TenDNBaoHiem);
			
				// DiaChiDNBaoHiem
			if (value.IsDiaChiDNBaoHiemNull )
				AddParameter(cmd, "DiaChiDNBaoHiem", DBNull.Value);
			else
				AddParameter(cmd, "DiaChiDNBaoHiem", value.DiaChiDNBaoHiem);
			
				// SDTDNBaoHiem
			if (value.IsSDTDNBaoHiemNull )
				AddParameter(cmd, "SDTDNBaoHiem", DBNull.Value);
			else
				AddParameter(cmd, "SDTDNBaoHiem", value.SDTDNBaoHiem);
			
				// MucTrachNhiem
			if (value.IsMucTrachNhiemNull )
				AddParameter(cmd, "MucTrachNhiem", DBNull.Value);
			else
				AddParameter(cmd, "MucTrachNhiem", value.MucTrachNhiem);
			
				// TrachNhiemChuXe
			if (value.IsTrachNhiemChuXeNull )
				AddParameter(cmd, "TrachNhiemChuXe", DBNull.Value);
			else
				AddParameter(cmd, "TrachNhiemChuXe", value.TrachNhiemChuXe);
			
				// ThoiHanBaoHiem
			if (value.IsThoiHanBaoHiemNull )
				AddParameter(cmd, "ThoiHanBaoHiem", DBNull.Value);
			else
				AddParameter(cmd, "ThoiHanBaoHiem", value.ThoiHanBaoHiem);
			
				// PhiBaoHiem
			if (value.IsPhiBaoHiemNull )
				AddParameter(cmd, "PhiBaoHiem", DBNull.Value);
			else
				AddParameter(cmd, "PhiBaoHiem", value.PhiBaoHiem);
			
				// ThoiHanThanhToan
			if (value.IsThoiHanThanhToanNull )
				AddParameter(cmd, "ThoiHanThanhToan", DBNull.Value);
			else
				AddParameter(cmd, "ThoiHanThanhToan", value.ThoiHanThanhToan);
			
				// NgayCap
			if (value.IsNgayCapNull)
				AddParameter(cmd, "NgayCap", DBNull.Value);
			else
				AddParameter(cmd, "NgayCap", value.NgayCap);
			
				// GhiChu
			if (value.IsGhiChuNull )
				AddParameter(cmd, "GhiChu", DBNull.Value);
			else
				AddParameter(cmd, "GhiChu", value.GhiChu);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// LastEditedBy
			if (value.IsLastEditedByNull)
				AddParameter(cmd, "LastEditedBy", DBNull.Value);
			else
				AddParameter(cmd, "LastEditedBy", value.LastEditedBy);
			
				// LastEditedDate
			if (value.IsLastEditedDateNull)
				AddParameter(cmd, "LastEditedDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditedDate", value.LastEditedDate);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// Sort
			if (value.IsSortNull)
				AddParameter(cmd, "Sort", DBNull.Value);
			else
				AddParameter(cmd, "Sort", value.Sort);
			
						value.BaoHiem_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>BaoHiem</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BaoHiemRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(BaoHiemRow value)
	{	
		string LOCATION = "Update(BaoHiemRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BaoHiem_Update", CommandType.StoredProcedure);
					// HoTen
			if (value.IsHoTenNull)
				AddParameter(cmd, "HoTen", DBNull.Value);
			else
				AddParameter(cmd, "HoTen", value.HoTen);
				// SDT
			if (value.IsSDTNull)
				AddParameter(cmd, "SDT", DBNull.Value);
			else
				AddParameter(cmd, "SDT", value.SDT);
				// DiaChi
			if (value.IsDiaChiNull)
				AddParameter(cmd, "DiaChi", DBNull.Value);
			else
				AddParameter(cmd, "DiaChi", value.DiaChi);
				// BienXe
			if (value.IsBienXeNull)
				AddParameter(cmd, "BienXe", DBNull.Value);
			else
				AddParameter(cmd, "BienXe", value.BienXe);
				// SoKhung
			if (value.IsSoKhungNull)
				AddParameter(cmd, "SoKhung", DBNull.Value);
			else
				AddParameter(cmd, "SoKhung", value.SoKhung);
				// SoMay
			if (value.IsSoMayNull)
				AddParameter(cmd, "SoMay", DBNull.Value);
			else
				AddParameter(cmd, "SoMay", value.SoMay);
				// LoaiXe
			if (value.IsLoaiXeNull)
				AddParameter(cmd, "LoaiXe", DBNull.Value);
			else
				AddParameter(cmd, "LoaiXe", value.LoaiXe);
				// TrongTai
			if (value.IsTrongTaiNull)
				AddParameter(cmd, "TrongTai", DBNull.Value);
			else
				AddParameter(cmd, "TrongTai", value.TrongTai);
				// SoChoNgoi
			if (value.IsSoChoNgoiNull)
				AddParameter(cmd, "SoChoNgoi", DBNull.Value);
			else
				AddParameter(cmd, "SoChoNgoi", value.SoChoNgoi);
				// MucDichSuDung
			if (value.IsMucDichSuDungNull)
				AddParameter(cmd, "MucDichSuDung", DBNull.Value);
			else
				AddParameter(cmd, "MucDichSuDung", value.MucDichSuDung);
				// TenDNBaoHiem
			if (value.IsTenDNBaoHiemNull)
				AddParameter(cmd, "TenDNBaoHiem", DBNull.Value);
			else
				AddParameter(cmd, "TenDNBaoHiem", value.TenDNBaoHiem);
				// DiaChiDNBaoHiem
			if (value.IsDiaChiDNBaoHiemNull)
				AddParameter(cmd, "DiaChiDNBaoHiem", DBNull.Value);
			else
				AddParameter(cmd, "DiaChiDNBaoHiem", value.DiaChiDNBaoHiem);
				// SDTDNBaoHiem
			if (value.IsSDTDNBaoHiemNull)
				AddParameter(cmd, "SDTDNBaoHiem", DBNull.Value);
			else
				AddParameter(cmd, "SDTDNBaoHiem", value.SDTDNBaoHiem);
				// MucTrachNhiem
			if (value.IsMucTrachNhiemNull)
				AddParameter(cmd, "MucTrachNhiem", DBNull.Value);
			else
				AddParameter(cmd, "MucTrachNhiem", value.MucTrachNhiem);
				// TrachNhiemChuXe
			if (value.IsTrachNhiemChuXeNull)
				AddParameter(cmd, "TrachNhiemChuXe", DBNull.Value);
			else
				AddParameter(cmd, "TrachNhiemChuXe", value.TrachNhiemChuXe);
				// ThoiHanBaoHiem
			if (value.IsThoiHanBaoHiemNull)
				AddParameter(cmd, "ThoiHanBaoHiem", DBNull.Value);
			else
				AddParameter(cmd, "ThoiHanBaoHiem", value.ThoiHanBaoHiem);
				// PhiBaoHiem
			if (value.IsPhiBaoHiemNull)
				AddParameter(cmd, "PhiBaoHiem", DBNull.Value);
			else
				AddParameter(cmd, "PhiBaoHiem", value.PhiBaoHiem);
				// ThoiHanThanhToan
			if (value.IsThoiHanThanhToanNull)
				AddParameter(cmd, "ThoiHanThanhToan", DBNull.Value);
			else
				AddParameter(cmd, "ThoiHanThanhToan", value.ThoiHanThanhToan);
				// NgayCap
			if (value.IsNgayCapNull)
				AddParameter(cmd, "NgayCap", DBNull.Value);
			else
				AddParameter(cmd, "NgayCap", value.NgayCap);
			
				// GhiChu
			if (value.IsGhiChuNull)
				AddParameter(cmd, "GhiChu", DBNull.Value);
			else
				AddParameter(cmd, "GhiChu", value.GhiChu);
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// LastEditedBy
			if (value.IsLastEditedByNull)
				AddParameter(cmd, "LastEditedBy", DBNull.Value);
			else
				AddParameter(cmd, "LastEditedBy", value.LastEditedBy);
			
				// LastEditedDate
			if (value.IsLastEditedDateNull)
				AddParameter(cmd, "LastEditedDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditedDate", value.LastEditedDate);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// Sort
			if (value.IsSortNull)
				AddParameter(cmd, "Sort", DBNull.Value);
			else
				AddParameter(cmd, "Sort", value.Sort);
			
					AddParameter(cmd, "BaoHiem_ID", value.BaoHiem_ID);
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
		/// Inserts or Updates a record in the <c>BaoHiem</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="BaoHiemRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(BaoHiemRow value)
		{
			string LOCATION = "Save(BaoHiemRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("BaoHiem_Save",CommandType.StoredProcedure);
					// HoTen
				if (value.IsHoTenNull)
					AddParameter(cmd, "HoTen", DBNull.Value);
				else
					AddParameter(cmd, "HoTen", (object)(value.HoTen));
				
					// SDT
				if (value.IsSDTNull)
					AddParameter(cmd, "SDT", DBNull.Value);
				else
					AddParameter(cmd, "SDT", (object)(value.SDT));
				
					// DiaChi
				if (value.IsDiaChiNull)
					AddParameter(cmd, "DiaChi", DBNull.Value);
				else
					AddParameter(cmd, "DiaChi", (object)(value.DiaChi));
				
					// BienXe
				if (value.IsBienXeNull)
					AddParameter(cmd, "BienXe", DBNull.Value);
				else
					AddParameter(cmd, "BienXe", (object)(value.BienXe));
				
					// SoKhung
				if (value.IsSoKhungNull)
					AddParameter(cmd, "SoKhung", DBNull.Value);
				else
					AddParameter(cmd, "SoKhung", (object)(value.SoKhung));
				
					// SoMay
				if (value.IsSoMayNull)
					AddParameter(cmd, "SoMay", DBNull.Value);
				else
					AddParameter(cmd, "SoMay", (object)(value.SoMay));
				
					// LoaiXe
				if (value.IsLoaiXeNull)
					AddParameter(cmd, "LoaiXe", DBNull.Value);
				else
					AddParameter(cmd, "LoaiXe", (object)(value.LoaiXe));
				
					// TrongTai
				if (value.IsTrongTaiNull)
					AddParameter(cmd, "TrongTai", DBNull.Value);
				else
					AddParameter(cmd, "TrongTai", (object)(value.TrongTai));
				
					// SoChoNgoi
				if (value.IsSoChoNgoiNull)
					AddParameter(cmd, "SoChoNgoi", DBNull.Value);
				else
					AddParameter(cmd, "SoChoNgoi", (object)(value.SoChoNgoi));
				
					// MucDichSuDung
				if (value.IsMucDichSuDungNull)
					AddParameter(cmd, "MucDichSuDung", DBNull.Value);
				else
					AddParameter(cmd, "MucDichSuDung", (object)(value.MucDichSuDung));
				
					// TenDNBaoHiem
				if (value.IsTenDNBaoHiemNull)
					AddParameter(cmd, "TenDNBaoHiem", DBNull.Value);
				else
					AddParameter(cmd, "TenDNBaoHiem", (object)(value.TenDNBaoHiem));
				
					// DiaChiDNBaoHiem
				if (value.IsDiaChiDNBaoHiemNull)
					AddParameter(cmd, "DiaChiDNBaoHiem", DBNull.Value);
				else
					AddParameter(cmd, "DiaChiDNBaoHiem", (object)(value.DiaChiDNBaoHiem));
				
					// SDTDNBaoHiem
				if (value.IsSDTDNBaoHiemNull)
					AddParameter(cmd, "SDTDNBaoHiem", DBNull.Value);
				else
					AddParameter(cmd, "SDTDNBaoHiem", (object)(value.SDTDNBaoHiem));
				
					// MucTrachNhiem
				if (value.IsMucTrachNhiemNull)
					AddParameter(cmd, "MucTrachNhiem", DBNull.Value);
				else
					AddParameter(cmd, "MucTrachNhiem", (object)(value.MucTrachNhiem));
				
					// TrachNhiemChuXe
				if (value.IsTrachNhiemChuXeNull)
					AddParameter(cmd, "TrachNhiemChuXe", DBNull.Value);
				else
					AddParameter(cmd, "TrachNhiemChuXe", (object)(value.TrachNhiemChuXe));
				
					// ThoiHanBaoHiem
				if (value.IsThoiHanBaoHiemNull)
					AddParameter(cmd, "ThoiHanBaoHiem", DBNull.Value);
				else
					AddParameter(cmd, "ThoiHanBaoHiem", (object)(value.ThoiHanBaoHiem));
				
					// PhiBaoHiem
				if (value.IsPhiBaoHiemNull)
					AddParameter(cmd, "PhiBaoHiem", DBNull.Value);
				else
					AddParameter(cmd, "PhiBaoHiem", (object)(value.PhiBaoHiem));
				
					// ThoiHanThanhToan
				if (value.IsThoiHanThanhToanNull)
					AddParameter(cmd, "ThoiHanThanhToan", DBNull.Value);
				else
					AddParameter(cmd, "ThoiHanThanhToan", (object)(value.ThoiHanThanhToan));
				
					// NgayCap
				if (value.IsNgayCapNull)
					AddParameter(cmd, "NgayCap", DBNull.Value);
				else
					AddParameter(cmd, "NgayCap", (object)(value.NgayCap));
				
					// GhiChu
				if (value.IsGhiChuNull)
					AddParameter(cmd, "GhiChu", DBNull.Value);
				else
					AddParameter(cmd, "GhiChu", (object)(value.GhiChu));
				
					// CreateDate
				if (value.IsCreateDateNull)
					AddParameter(cmd, "CreateDate", DBNull.Value);
				else
					AddParameter(cmd, "CreateDate", (object)(value.CreateDate));
				
					// LastEditedBy
				if (value.IsLastEditedByNull)
					AddParameter(cmd, "LastEditedBy", DBNull.Value);
				else
					AddParameter(cmd, "LastEditedBy", (object)(value.LastEditedBy));
				
					// LastEditedDate
				if (value.IsLastEditedDateNull)
					AddParameter(cmd, "LastEditedDate", DBNull.Value);
				else
					AddParameter(cmd, "LastEditedDate", (object)(value.LastEditedDate));
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
					// Sort
				if (value.IsSortNull)
					AddParameter(cmd, "Sort", DBNull.Value);
				else
					AddParameter(cmd, "Sort", (object)(value.Sort));
				
						AddParameter(cmd, "BaoHiem_ID", value.BaoHiem_ID);
						value.BaoHiem_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["BaoHiem_ID"]);
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
	/// Deletes the specified object from the <c>BaoHiem</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BaoHiemRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(BaoHiemRow value)
	{
		return DeleteByPrimaryKey(value.BaoHiem_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>BaoHiem</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="baoHiem_ID">The <c>BaoHiem_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int baoHiem_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int baoHiem_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BaoHiem_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "BaoHiem_ID", baoHiem_ID);
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
	/// Deletes <c>BaoHiem</c> records that match the specified criteria.
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
	/// to delete <c>BaoHiem</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("BaoHiem_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>BaoHiem</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("BaoHiem_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="BaoHiemRow"/> objects.</returns>
	protected BaoHiemRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="BaoHiemRow"/> objects.</returns>
	protected BaoHiemRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="BaoHiemRow"/> objects.</returns>
	protected virtual BaoHiemRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// BaoHiem_ID
		int baoHiem_IDColumnIndex = reader.GetOrdinal("BaoHiem_ID");
		// HoTen
		int hoTenColumnIndex = reader.GetOrdinal("HoTen");
		// SDT
		int sdtColumnIndex = reader.GetOrdinal("SDT");
		// DiaChi
		int diaChiColumnIndex = reader.GetOrdinal("DiaChi");
		// BienXe
		int bienXeColumnIndex = reader.GetOrdinal("BienXe");
		// SoKhung
		int soKhungColumnIndex = reader.GetOrdinal("SoKhung");
		// SoMay
		int soMayColumnIndex = reader.GetOrdinal("SoMay");
		// LoaiXe
		int loaiXeColumnIndex = reader.GetOrdinal("LoaiXe");
		// TrongTai
		int trongTaiColumnIndex = reader.GetOrdinal("TrongTai");
		// SoChoNgoi
		int soChoNgoiColumnIndex = reader.GetOrdinal("SoChoNgoi");
		// MucDichSuDung
		int mucDichSuDungColumnIndex = reader.GetOrdinal("MucDichSuDung");
		// TenDNBaoHiem
		int tenDNBaoHiemColumnIndex = reader.GetOrdinal("TenDNBaoHiem");
		// DiaChiDNBaoHiem
		int diaChiDNBaoHiemColumnIndex = reader.GetOrdinal("DiaChiDNBaoHiem");
		// SDTDNBaoHiem
		int sDTDNBaoHiemColumnIndex = reader.GetOrdinal("SDTDNBaoHiem");
		// MucTrachNhiem
		int mucTrachNhiemColumnIndex = reader.GetOrdinal("MucTrachNhiem");
		// TrachNhiemChuXe
		int trachNhiemChuXeColumnIndex = reader.GetOrdinal("TrachNhiemChuXe");
		// ThoiHanBaoHiem
		int thoiHanBaoHiemColumnIndex = reader.GetOrdinal("ThoiHanBaoHiem");
		// PhiBaoHiem
		int phiBaoHiemColumnIndex = reader.GetOrdinal("PhiBaoHiem");
		// ThoiHanThanhToan
		int thoiHanThanhToanColumnIndex = reader.GetOrdinal("ThoiHanThanhToan");
		// NgayCap
		int ngayCapColumnIndex = reader.GetOrdinal("NgayCap");
		// GhiChu
		int ghiChuColumnIndex = reader.GetOrdinal("GhiChu");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditedBy
		int lastEditedByColumnIndex = reader.GetOrdinal("LastEditedBy");
		// LastEditedDate
		int lastEditedDateColumnIndex = reader.GetOrdinal("LastEditedDate");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
		// Sort
		int sortColumnIndex = reader.GetOrdinal("Sort");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				BaoHiemRow record = new BaoHiemRow();
				recordList.Add(record);

					record.BaoHiem_ID = Convert.ToInt32(reader.GetValue(baoHiem_IDColumnIndex));
					if(!reader.IsDBNull(hoTenColumnIndex))
						record.HoTen = Convert.ToString(reader.GetValue(hoTenColumnIndex));
					if(!reader.IsDBNull(sdtColumnIndex))
						record.SDT = Convert.ToString(reader.GetValue(sdtColumnIndex));
					if(!reader.IsDBNull(diaChiColumnIndex))
						record.DiaChi = Convert.ToString(reader.GetValue(diaChiColumnIndex));
					if(!reader.IsDBNull(bienXeColumnIndex))
						record.BienXe = Convert.ToString(reader.GetValue(bienXeColumnIndex));
					if(!reader.IsDBNull(soKhungColumnIndex))
						record.SoKhung = Convert.ToString(reader.GetValue(soKhungColumnIndex));
					if(!reader.IsDBNull(soMayColumnIndex))
						record.SoMay = Convert.ToString(reader.GetValue(soMayColumnIndex));
					if(!reader.IsDBNull(loaiXeColumnIndex))
						record.LoaiXe = Convert.ToString(reader.GetValue(loaiXeColumnIndex));
					if(!reader.IsDBNull(trongTaiColumnIndex))
						record.TrongTai = Convert.ToString(reader.GetValue(trongTaiColumnIndex));
					if(!reader.IsDBNull(soChoNgoiColumnIndex))
						record.SoChoNgoi = Convert.ToString(reader.GetValue(soChoNgoiColumnIndex));
					if(!reader.IsDBNull(mucDichSuDungColumnIndex))
						record.MucDichSuDung = Convert.ToString(reader.GetValue(mucDichSuDungColumnIndex));
					if(!reader.IsDBNull(tenDNBaoHiemColumnIndex))
						record.TenDNBaoHiem = Convert.ToString(reader.GetValue(tenDNBaoHiemColumnIndex));
					if(!reader.IsDBNull(diaChiDNBaoHiemColumnIndex))
						record.DiaChiDNBaoHiem = Convert.ToString(reader.GetValue(diaChiDNBaoHiemColumnIndex));
					if(!reader.IsDBNull(sDTDNBaoHiemColumnIndex))
						record.SDTDNBaoHiem = Convert.ToString(reader.GetValue(sDTDNBaoHiemColumnIndex));
					if(!reader.IsDBNull(mucTrachNhiemColumnIndex))
						record.MucTrachNhiem = Convert.ToString(reader.GetValue(mucTrachNhiemColumnIndex));
					if(!reader.IsDBNull(trachNhiemChuXeColumnIndex))
						record.TrachNhiemChuXe = Convert.ToString(reader.GetValue(trachNhiemChuXeColumnIndex));
					if(!reader.IsDBNull(thoiHanBaoHiemColumnIndex))
						record.ThoiHanBaoHiem = Convert.ToString(reader.GetValue(thoiHanBaoHiemColumnIndex));
					if(!reader.IsDBNull(phiBaoHiemColumnIndex))
						record.PhiBaoHiem = Convert.ToString(reader.GetValue(phiBaoHiemColumnIndex));
					if(!reader.IsDBNull(thoiHanThanhToanColumnIndex))
						record.ThoiHanThanhToan = Convert.ToString(reader.GetValue(thoiHanThanhToanColumnIndex));
					if(!reader.IsDBNull(ngayCapColumnIndex))
						record.NgayCap = Convert.ToDateTime(reader.GetValue(ngayCapColumnIndex));
					if(!reader.IsDBNull(ghiChuColumnIndex))
						record.GhiChu = Convert.ToString(reader.GetValue(ghiChuColumnIndex));
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditedByColumnIndex))
						record.LastEditedBy = reader.GetGuid(lastEditedByColumnIndex);
					if(!reader.IsDBNull(lastEditedDateColumnIndex))
						record.LastEditedDate = Convert.ToDateTime(reader.GetValue(lastEditedDateColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToInt32(reader.GetValue(activeColumnIndex));
					if(!reader.IsDBNull(sortColumnIndex))
						record.Sort = Convert.ToInt32(reader.GetValue(sortColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (BaoHiemRow[])(recordList.ToArray(typeof(BaoHiemRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="BaoHiemRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="BaoHiemRow"/> object.</returns>
	protected virtual BaoHiemRow MapRow(DataRow row)
	{
		string LOCATION = "BaoHiemRow MapRow(DataRow row)";
		BaoHiemRow mappedObject = new BaoHiemRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "BaoHiem_ID"
		dataColumn = dataTable.Columns["BaoHiem_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.BaoHiem_ID = (int)(row[dataColumn]);
		// Column "HoTen"
		dataColumn = dataTable.Columns["HoTen"];
		if (! row.IsNull(dataColumn) )
			mappedObject.HoTen = (string)(row[dataColumn]);
		// Column "SDT"
		dataColumn = dataTable.Columns["SDT"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SDT = (string)(row[dataColumn]);
		// Column "DiaChi"
		dataColumn = dataTable.Columns["DiaChi"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DiaChi = (string)(row[dataColumn]);
		// Column "BienXe"
		dataColumn = dataTable.Columns["BienXe"];
		if (! row.IsNull(dataColumn) )
			mappedObject.BienXe = (string)(row[dataColumn]);
		// Column "SoKhung"
		dataColumn = dataTable.Columns["SoKhung"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SoKhung = (string)(row[dataColumn]);
		// Column "SoMay"
		dataColumn = dataTable.Columns["SoMay"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SoMay = (string)(row[dataColumn]);
		// Column "LoaiXe"
		dataColumn = dataTable.Columns["LoaiXe"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LoaiXe = (string)(row[dataColumn]);
		// Column "TrongTai"
		dataColumn = dataTable.Columns["TrongTai"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TrongTai = (string)(row[dataColumn]);
		// Column "SoChoNgoi"
		dataColumn = dataTable.Columns["SoChoNgoi"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SoChoNgoi = (string)(row[dataColumn]);
		// Column "MucDichSuDung"
		dataColumn = dataTable.Columns["MucDichSuDung"];
		if (! row.IsNull(dataColumn) )
			mappedObject.MucDichSuDung = (string)(row[dataColumn]);
		// Column "TenDNBaoHiem"
		dataColumn = dataTable.Columns["TenDNBaoHiem"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TenDNBaoHiem = (string)(row[dataColumn]);
		// Column "DiaChiDNBaoHiem"
		dataColumn = dataTable.Columns["DiaChiDNBaoHiem"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DiaChiDNBaoHiem = (string)(row[dataColumn]);
		// Column "SDTDNBaoHiem"
		dataColumn = dataTable.Columns["SDTDNBaoHiem"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SDTDNBaoHiem = (string)(row[dataColumn]);
		// Column "MucTrachNhiem"
		dataColumn = dataTable.Columns["MucTrachNhiem"];
		if (! row.IsNull(dataColumn) )
			mappedObject.MucTrachNhiem = (string)(row[dataColumn]);
		// Column "TrachNhiemChuXe"
		dataColumn = dataTable.Columns["TrachNhiemChuXe"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TrachNhiemChuXe = (string)(row[dataColumn]);
		// Column "ThoiHanBaoHiem"
		dataColumn = dataTable.Columns["ThoiHanBaoHiem"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ThoiHanBaoHiem = (string)(row[dataColumn]);
		// Column "PhiBaoHiem"
		dataColumn = dataTable.Columns["PhiBaoHiem"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PhiBaoHiem = (string)(row[dataColumn]);
		// Column "ThoiHanThanhToan"
		dataColumn = dataTable.Columns["ThoiHanThanhToan"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ThoiHanThanhToan = (string)(row[dataColumn]);
		// Column "NgayCap"
		dataColumn = dataTable.Columns["NgayCap"];
		if (! row.IsNull(dataColumn) )
			mappedObject.NgayCap = (System.DateTime)(row[dataColumn]);
		// Column "GhiChu"
		dataColumn = dataTable.Columns["GhiChu"];
		if (! row.IsNull(dataColumn) )
			mappedObject.GhiChu = (string)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "LastEditedBy"
		dataColumn = dataTable.Columns["LastEditedBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditedBy = (System.Guid)(row[dataColumn]);
		// Column "LastEditedDate"
		dataColumn = dataTable.Columns["LastEditedDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditedDate = (System.DateTime)(row[dataColumn]);
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (int)(row[dataColumn]);
		// Column "Sort"
		dataColumn = dataTable.Columns["Sort"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Sort = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>BaoHiem</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "BaoHiem";
		DataColumn dataColumn;
		// Create the "BaoHiem_ID" column
		dataColumn = dataTable.Columns.Add("BaoHiem_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "HoTen" column
		dataColumn = dataTable.Columns.Add("HoTen", typeof(string));
		dataColumn.MaxLength = 250;
		// Create the "SDT" column
		dataColumn = dataTable.Columns.Add("SDT", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "DiaChi" column
		dataColumn = dataTable.Columns.Add("DiaChi", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "BienXe" column
		dataColumn = dataTable.Columns.Add("BienXe", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "SoKhung" column
		dataColumn = dataTable.Columns.Add("SoKhung", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "SoMay" column
		dataColumn = dataTable.Columns.Add("SoMay", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "LoaiXe" column
		dataColumn = dataTable.Columns.Add("LoaiXe", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "TrongTai" column
		dataColumn = dataTable.Columns.Add("TrongTai", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "SoChoNgoi" column
		dataColumn = dataTable.Columns.Add("SoChoNgoi", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "MucDichSuDung" column
		dataColumn = dataTable.Columns.Add("MucDichSuDung", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "TenDNBaoHiem" column
		dataColumn = dataTable.Columns.Add("TenDNBaoHiem", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "DiaChiDNBaoHiem" column
		dataColumn = dataTable.Columns.Add("DiaChiDNBaoHiem", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "SDTDNBaoHiem" column
		dataColumn = dataTable.Columns.Add("SDTDNBaoHiem", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "MucTrachNhiem" column
		dataColumn = dataTable.Columns.Add("MucTrachNhiem", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "TrachNhiemChuXe" column
		dataColumn = dataTable.Columns.Add("TrachNhiemChuXe", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ThoiHanBaoHiem" column
		dataColumn = dataTable.Columns.Add("ThoiHanBaoHiem", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "PhiBaoHiem" column
		dataColumn = dataTable.Columns.Add("PhiBaoHiem", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ThoiHanThanhToan" column
		dataColumn = dataTable.Columns.Add("ThoiHanThanhToan", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "NgayCap" column
		dataColumn = dataTable.Columns.Add("NgayCap", typeof(System.DateTime));
		// Create the "GhiChu" column
		dataColumn = dataTable.Columns.Add("GhiChu", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditedBy" column
		dataColumn = dataTable.Columns.Add("LastEditedBy", typeof(System.Guid));
		// Create the "LastEditedDate" column
		dataColumn = dataTable.Columns.Add("LastEditedDate", typeof(System.DateTime));
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(int));
		// Create the "Sort" column
		dataColumn = dataTable.Columns.Add("Sort", typeof(int));
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
			case "BaoHiem_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "HoTen":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SDT":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DiaChi":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "BienXe":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SoKhung":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SoMay":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "LoaiXe":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "TrongTai":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SoChoNgoi":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "MucDichSuDung":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "TenDNBaoHiem":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DiaChiDNBaoHiem":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SDTDNBaoHiem":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "MucTrachNhiem":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "TrachNhiemChuXe":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ThoiHanBaoHiem":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "PhiBaoHiem":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ThoiHanThanhToan":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "NgayCap":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "GhiChu":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "LastEditedBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "LastEditedDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Sort":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="BaoHiemRow"/> by the primary key.
	/// </summary>
	/// <param name="baoHiem_ID">The <c>BaoHiem_ID</c> column value.</param>
	/// <returns>An instance of <see cref="BaoHiemRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int baoHiem_ID)
	{
		string LOCATION = "Exist(int baoHiem_ID)";
		IDbCommand cmd = _db.CreateCommand("BaoHiem_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "BaoHiem_ID", baoHiem_ID);
		BaoHiemRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




