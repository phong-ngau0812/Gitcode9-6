
// <fileinfo name="Base\BaoHiemRowBase.cs">
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

namespace Base
{

/// <summary>
/// The base class for <see cref="BaoHiemRow"/> that 
/// represents a record in the <c>BaoHiem</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="BaoHiemRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BaoHiemRowBase
{
	/// _baoHiem_ID
	private int _baoHiem_ID;
	private bool _baoHiem_IDNull = true;
	/// _hoTen
	private string _hoTen;
	private bool _hoTenNull = true;
	/// _sdt
	private string _sdt;
	private bool _sdtNull = true;
	/// _diaChi
	private string _diaChi;
	private bool _diaChiNull = true;
	/// _bienXe
	private string _bienXe;
	private bool _bienXeNull = true;
	/// _soKhung
	private string _soKhung;
	private bool _soKhungNull = true;
	/// _soMay
	private string _soMay;
	private bool _soMayNull = true;
	/// _loaiXe
	private string _loaiXe;
	private bool _loaiXeNull = true;
	/// _trongTai
	private string _trongTai;
	private bool _trongTaiNull = true;
	/// _soChoNgoi
	private string _soChoNgoi;
	private bool _soChoNgoiNull = true;
	/// _mucDichSuDung
	private string _mucDichSuDung;
	private bool _mucDichSuDungNull = true;
	/// _tenDNBaoHiem
	private string _tenDNBaoHiem;
	private bool _tenDNBaoHiemNull = true;
	/// _diaChiDNBaoHiem
	private string _diaChiDNBaoHiem;
	private bool _diaChiDNBaoHiemNull = true;
	/// _sDTDNBaoHiem
	private string _sDTDNBaoHiem;
	private bool _sDTDNBaoHiemNull = true;
	/// _mucTrachNhiem
	private string _mucTrachNhiem;
	private bool _mucTrachNhiemNull = true;
	/// _trachNhiemChuXe
	private string _trachNhiemChuXe;
	private bool _trachNhiemChuXeNull = true;
	/// _thoiHanBaoHiem
	private string _thoiHanBaoHiem;
	private bool _thoiHanBaoHiemNull = true;
	/// _phiBaoHiem
	private string _phiBaoHiem;
	private bool _phiBaoHiemNull = true;
	/// _thoiHanThanhToan
	private string _thoiHanThanhToan;
	private bool _thoiHanThanhToanNull = true;
	/// _ngayCap
	private System.DateTime _ngayCap;
	private bool _ngayCapNull = true;
	/// _ghiChu
	private string _ghiChu;
	private bool _ghiChuNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditedBy
	private System.Guid _lastEditedBy;
	private bool _lastEditedByNull = true;
	/// _lastEditedDate
	private System.DateTime _lastEditedDate;
	private bool _lastEditedDateNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="BaoHiemRowBase"/> class.
	/// </summary>
	public BaoHiemRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>BaoHiem_ID</c> column value.
		/// </summary>
		/// <value>The <c>BaoHiem_ID</c> column value.</value>
	public int BaoHiem_ID
	{
		get
		{
			if(IsBaoHiem_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _baoHiem_ID;
		}
		set
		{
			_baoHiem_IDNull = false;
			_baoHiem_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="BaoHiem_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBaoHiem_IDNull
	{
		get
		{
			return _baoHiem_IDNull;
		}
		set
		{
			_baoHiem_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>HoTen</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>HoTen</c> column value.</value>
	public string HoTen
	{
		get
		{
			if(IsHoTenNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _hoTen;
		}
		set
		{
			_hoTenNull = false;
			_hoTen = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="HoTen"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsHoTenNull
	{
		get
		{
			return _hoTenNull;
		}
		set
		{
			_hoTenNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SDT</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SDT</c> column value.</value>
	public string SDT
	{
		get
		{
			if(IsSDTNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sdt;
		}
		set
		{
			_sdtNull = false;
			_sdt = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SDT"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSDTNull
	{
		get
		{
			return _sdtNull;
		}
		set
		{
			_sdtNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DiaChi</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DiaChi</c> column value.</value>
	public string DiaChi
	{
		get
		{
			if(IsDiaChiNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _diaChi;
		}
		set
		{
			_diaChiNull = false;
			_diaChi = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DiaChi"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDiaChiNull
	{
		get
		{
			return _diaChiNull;
		}
		set
		{
			_diaChiNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>BienXe</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BienXe</c> column value.</value>
	public string BienXe
	{
		get
		{
			if(IsBienXeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _bienXe;
		}
		set
		{
			_bienXeNull = false;
			_bienXe = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="BienXe"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBienXeNull
	{
		get
		{
			return _bienXeNull;
		}
		set
		{
			_bienXeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SoKhung</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SoKhung</c> column value.</value>
	public string SoKhung
	{
		get
		{
			if(IsSoKhungNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _soKhung;
		}
		set
		{
			_soKhungNull = false;
			_soKhung = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SoKhung"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSoKhungNull
	{
		get
		{
			return _soKhungNull;
		}
		set
		{
			_soKhungNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SoMay</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SoMay</c> column value.</value>
	public string SoMay
	{
		get
		{
			if(IsSoMayNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _soMay;
		}
		set
		{
			_soMayNull = false;
			_soMay = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SoMay"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSoMayNull
	{
		get
		{
			return _soMayNull;
		}
		set
		{
			_soMayNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LoaiXe</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LoaiXe</c> column value.</value>
	public string LoaiXe
	{
		get
		{
			if(IsLoaiXeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _loaiXe;
		}
		set
		{
			_loaiXeNull = false;
			_loaiXe = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LoaiXe"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLoaiXeNull
	{
		get
		{
			return _loaiXeNull;
		}
		set
		{
			_loaiXeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TrongTai</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TrongTai</c> column value.</value>
	public string TrongTai
	{
		get
		{
			if(IsTrongTaiNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _trongTai;
		}
		set
		{
			_trongTaiNull = false;
			_trongTai = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TrongTai"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTrongTaiNull
	{
		get
		{
			return _trongTaiNull;
		}
		set
		{
			_trongTaiNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SoChoNgoi</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SoChoNgoi</c> column value.</value>
	public string SoChoNgoi
	{
		get
		{
			if(IsSoChoNgoiNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _soChoNgoi;
		}
		set
		{
			_soChoNgoiNull = false;
			_soChoNgoi = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SoChoNgoi"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSoChoNgoiNull
	{
		get
		{
			return _soChoNgoiNull;
		}
		set
		{
			_soChoNgoiNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>MucDichSuDung</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MucDichSuDung</c> column value.</value>
	public string MucDichSuDung
	{
		get
		{
			if(IsMucDichSuDungNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _mucDichSuDung;
		}
		set
		{
			_mucDichSuDungNull = false;
			_mucDichSuDung = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MucDichSuDung"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMucDichSuDungNull
	{
		get
		{
			return _mucDichSuDungNull;
		}
		set
		{
			_mucDichSuDungNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TenDNBaoHiem</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TenDNBaoHiem</c> column value.</value>
	public string TenDNBaoHiem
	{
		get
		{
			if(IsTenDNBaoHiemNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _tenDNBaoHiem;
		}
		set
		{
			_tenDNBaoHiemNull = false;
			_tenDNBaoHiem = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TenDNBaoHiem"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTenDNBaoHiemNull
	{
		get
		{
			return _tenDNBaoHiemNull;
		}
		set
		{
			_tenDNBaoHiemNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DiaChiDNBaoHiem</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DiaChiDNBaoHiem</c> column value.</value>
	public string DiaChiDNBaoHiem
	{
		get
		{
			if(IsDiaChiDNBaoHiemNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _diaChiDNBaoHiem;
		}
		set
		{
			_diaChiDNBaoHiemNull = false;
			_diaChiDNBaoHiem = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DiaChiDNBaoHiem"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDiaChiDNBaoHiemNull
	{
		get
		{
			return _diaChiDNBaoHiemNull;
		}
		set
		{
			_diaChiDNBaoHiemNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SDTDNBaoHiem</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SDTDNBaoHiem</c> column value.</value>
	public string SDTDNBaoHiem
	{
		get
		{
			if(IsSDTDNBaoHiemNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sDTDNBaoHiem;
		}
		set
		{
			_sDTDNBaoHiemNull = false;
			_sDTDNBaoHiem = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SDTDNBaoHiem"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSDTDNBaoHiemNull
	{
		get
		{
			return _sDTDNBaoHiemNull;
		}
		set
		{
			_sDTDNBaoHiemNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>MucTrachNhiem</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MucTrachNhiem</c> column value.</value>
	public string MucTrachNhiem
	{
		get
		{
			if(IsMucTrachNhiemNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _mucTrachNhiem;
		}
		set
		{
			_mucTrachNhiemNull = false;
			_mucTrachNhiem = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MucTrachNhiem"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMucTrachNhiemNull
	{
		get
		{
			return _mucTrachNhiemNull;
		}
		set
		{
			_mucTrachNhiemNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TrachNhiemChuXe</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TrachNhiemChuXe</c> column value.</value>
	public string TrachNhiemChuXe
	{
		get
		{
			if(IsTrachNhiemChuXeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _trachNhiemChuXe;
		}
		set
		{
			_trachNhiemChuXeNull = false;
			_trachNhiemChuXe = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TrachNhiemChuXe"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTrachNhiemChuXeNull
	{
		get
		{
			return _trachNhiemChuXeNull;
		}
		set
		{
			_trachNhiemChuXeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ThoiHanBaoHiem</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ThoiHanBaoHiem</c> column value.</value>
	public string ThoiHanBaoHiem
	{
		get
		{
			if(IsThoiHanBaoHiemNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _thoiHanBaoHiem;
		}
		set
		{
			_thoiHanBaoHiemNull = false;
			_thoiHanBaoHiem = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ThoiHanBaoHiem"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsThoiHanBaoHiemNull
	{
		get
		{
			return _thoiHanBaoHiemNull;
		}
		set
		{
			_thoiHanBaoHiemNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>PhiBaoHiem</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PhiBaoHiem</c> column value.</value>
	public string PhiBaoHiem
	{
		get
		{
			if(IsPhiBaoHiemNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _phiBaoHiem;
		}
		set
		{
			_phiBaoHiemNull = false;
			_phiBaoHiem = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PhiBaoHiem"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPhiBaoHiemNull
	{
		get
		{
			return _phiBaoHiemNull;
		}
		set
		{
			_phiBaoHiemNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ThoiHanThanhToan</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ThoiHanThanhToan</c> column value.</value>
	public string ThoiHanThanhToan
	{
		get
		{
			if(IsThoiHanThanhToanNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _thoiHanThanhToan;
		}
		set
		{
			_thoiHanThanhToanNull = false;
			_thoiHanThanhToan = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ThoiHanThanhToan"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsThoiHanThanhToanNull
	{
		get
		{
			return _thoiHanThanhToanNull;
		}
		set
		{
			_thoiHanThanhToanNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>NgayCap</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>NgayCap</c> column value.</value>
	public System.DateTime NgayCap
	{
		get
		{
			if (IsNgayCapNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _ngayCap;
		}
		set
		{
			_ngayCapNull = false;
			_ngayCap = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="NgayCap"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNgayCapNull
	{
		get
		{
			return _ngayCapNull;
		}
		set
		{
			_ngayCapNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>GhiChu</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GhiChu</c> column value.</value>
	public string GhiChu
	{
		get
		{
			if(IsGhiChuNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _ghiChu;
		}
		set
		{
			_ghiChuNull = false;
			_ghiChu = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GhiChu"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGhiChuNull
	{
		get
		{
			return _ghiChuNull;
		}
		set
		{
			_ghiChuNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CreateDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CreateDate</c> column value.</value>
	public System.DateTime CreateDate
	{
		get
		{
			if (IsCreateDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _createDate;
		}
		set
		{
			_createDateNull = false;
			_createDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CreateDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCreateDateNull
	{
		get
		{
			return _createDateNull;
		}
		set
		{
			_createDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LastEditedBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditedBy</c> column value.</value>
	public System.Guid LastEditedBy
	{
		get
		{
			if (IsLastEditedByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditedBy;
		}
		set
		{
			_lastEditedByNull = false;
			_lastEditedBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditedBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditedByNull
	{
		get
		{
			return _lastEditedByNull;
		}
		set
		{
			_lastEditedByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LastEditedDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditedDate</c> column value.</value>
	public System.DateTime LastEditedDate
	{
		get
		{
			if (IsLastEditedDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditedDate;
		}
		set
		{
			_lastEditedDateNull = false;
			_lastEditedDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditedDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditedDateNull
	{
		get
		{
			return _lastEditedDateNull;
		}
		set
		{
			_lastEditedDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
	public int Active
	{
		get
		{
			if (IsActiveNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _active;
		}
		set
		{
			_activeNull = false;
			_active = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Active"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsActiveNull
	{
		get
		{
			return _activeNull;
		}
		set
		{
			_activeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Sort</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Sort</c> column value.</value>
	public int Sort
	{
		get
		{
			if (IsSortNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sort;
		}
		set
		{
			_sortNull = false;
			_sort = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Sort"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSortNull
	{
		get
		{
			return _sortNull;
		}
		set
		{
			_sortNull = value;
		}	
	}

	/// <summary>
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// BaoHiem_ID
		dynStr.Append("  BaoHiem_ID=");
		if( IsBaoHiem_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.BaoHiem_ID);
		

		// HoTen
		dynStr.Append("  HoTen=");
		if( IsHoTenNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.HoTen);
		

		// SDT
		dynStr.Append("  SDT=");
		if( IsSDTNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SDT);
		

		// DiaChi
		dynStr.Append("  DiaChi=");
		if( IsDiaChiNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DiaChi);
		

		// BienXe
		dynStr.Append("  BienXe=");
		if( IsBienXeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.BienXe);
		

		// SoKhung
		dynStr.Append("  SoKhung=");
		if( IsSoKhungNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SoKhung);
		

		// SoMay
		dynStr.Append("  SoMay=");
		if( IsSoMayNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SoMay);
		

		// LoaiXe
		dynStr.Append("  LoaiXe=");
		if( IsLoaiXeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.LoaiXe);
		

		// TrongTai
		dynStr.Append("  TrongTai=");
		if( IsTrongTaiNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TrongTai);
		

		// SoChoNgoi
		dynStr.Append("  SoChoNgoi=");
		if( IsSoChoNgoiNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SoChoNgoi);
		

		// MucDichSuDung
		dynStr.Append("  MucDichSuDung=");
		if( IsMucDichSuDungNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.MucDichSuDung);
		

		// TenDNBaoHiem
		dynStr.Append("  TenDNBaoHiem=");
		if( IsTenDNBaoHiemNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TenDNBaoHiem);
		

		// DiaChiDNBaoHiem
		dynStr.Append("  DiaChiDNBaoHiem=");
		if( IsDiaChiDNBaoHiemNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DiaChiDNBaoHiem);
		

		// SDTDNBaoHiem
		dynStr.Append("  SDTDNBaoHiem=");
		if( IsSDTDNBaoHiemNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SDTDNBaoHiem);
		

		// MucTrachNhiem
		dynStr.Append("  MucTrachNhiem=");
		if( IsMucTrachNhiemNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.MucTrachNhiem);
		

		// TrachNhiemChuXe
		dynStr.Append("  TrachNhiemChuXe=");
		if( IsTrachNhiemChuXeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TrachNhiemChuXe);
		

		// ThoiHanBaoHiem
		dynStr.Append("  ThoiHanBaoHiem=");
		if( IsThoiHanBaoHiemNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ThoiHanBaoHiem);
		

		// PhiBaoHiem
		dynStr.Append("  PhiBaoHiem=");
		if( IsPhiBaoHiemNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PhiBaoHiem);
		

		// ThoiHanThanhToan
		dynStr.Append("  ThoiHanThanhToan=");
		if( IsThoiHanThanhToanNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ThoiHanThanhToan);
		

		// NgayCap
		dynStr.Append("  NgayCap=");
		if( IsNgayCapNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.NgayCap);
		// GhiChu
		dynStr.Append("  GhiChu=");
		if( IsGhiChuNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GhiChu);
		

		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		// LastEditedBy
		dynStr.Append("  LastEditedBy=");
		if( IsLastEditedByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditedBy);
		// LastEditedDate
		dynStr.Append("  LastEditedDate=");
		if( IsLastEditedDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditedDate);
		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// Sort
		dynStr.Append("  Sort=");
		if( IsSortNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Sort);
		return dynStr.ToString();
	}
}
}




