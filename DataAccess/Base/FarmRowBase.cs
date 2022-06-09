
// <fileinfo name="Base\FarmRowBase.cs">
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
/// The base class for <see cref="FarmRow"/> that 
/// represents a record in the <c>Farm</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="FarmRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class FarmRowBase
{
	/// _farm_ID
	private int _farm_ID;
	private bool _farm_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _zone_ID
	private int _zone_ID;
	private bool _zone_IDNull = true;
	/// _area_ID
	private int _area_ID;
	private bool _area_IDNull = true;
	/// _workshop_ID
	private int _workshop_ID;
	private bool _workshop_IDNull = true;
	/// _farmStatus_ID
	private int _farmStatus_ID;
	private bool _farmStatus_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _historyFarm
	private string _historyFarm;
	private bool _historyFarmNull = true;
	/// _location_ID
	private int _location_ID;
	private bool _location_IDNull = true;
	/// _aboutUs
	private string _aboutUs;
	private bool _aboutUsNull = true;
	/// _address
	private string _address;
	private bool _addressNull = true;
	/// _acreage
	private int _acreage;
	private bool _acreageNull = true;
	/// _map
	private string _map;
	private bool _mapNull = true;
	/// _phone
	private string _phone;
	private bool _phoneNull = true;
	/// _fax
	private string _fax;
	private bool _faxNull = true;
	/// _email
	private string _email;
	private bool _emailNull = true;
	/// _contact
	private string _contact;
	private bool _contactNull = true;
	/// _url
	private string _url;
	private bool _urlNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;
	/// _qRCodePublicContent
	private string _qRCodePublicContent;
	private bool _qRCodePublicContentNull = true;
	/// _isolationDay
	private int _isolationDay;
	private bool _isolationDayNull = true;
	/// _gln
	private string _gln;
	private bool _glnNull = true;
	/// _district_ID
	private int _district_ID;
	private bool _district_IDNull = true;
	/// _ward_ID
	private int _ward_ID;
	private bool _ward_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="FarmRowBase"/> class.
	/// </summary>
	public FarmRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Farm_ID</c> column value.
		/// </summary>
		/// <value>The <c>Farm_ID</c> column value.</value>
	public int Farm_ID
	{
		get
		{
			if(IsFarm_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farm_ID;
		}
		set
		{
			_farm_IDNull = false;
			_farm_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Farm_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarm_IDNull
	{
		get
		{
			return _farm_IDNull;
		}
		set
		{
			_farm_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrand_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrand_ID</c> column value.</value>
	public int ProductBrand_ID
	{
		get
		{
			if (IsProductBrand_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrand_ID;
		}
		set
		{
			_productBrand_IDNull = false;
			_productBrand_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrand_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrand_IDNull
	{
		get
		{
			return _productBrand_IDNull;
		}
		set
		{
			_productBrand_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Zone_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Zone_ID</c> column value.</value>
	public int Zone_ID
	{
		get
		{
			if (IsZone_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _zone_ID;
		}
		set
		{
			_zone_IDNull = false;
			_zone_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Zone_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsZone_IDNull
	{
		get
		{
			return _zone_IDNull;
		}
		set
		{
			_zone_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Area_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Area_ID</c> column value.</value>
	public int Area_ID
	{
		get
		{
			if (IsArea_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _area_ID;
		}
		set
		{
			_area_IDNull = false;
			_area_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Area_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsArea_IDNull
	{
		get
		{
			return _area_IDNull;
		}
		set
		{
			_area_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Workshop_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Workshop_ID</c> column value.</value>
	public int Workshop_ID
	{
		get
		{
			if (IsWorkshop_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _workshop_ID;
		}
		set
		{
			_workshop_IDNull = false;
			_workshop_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Workshop_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWorkshop_IDNull
	{
		get
		{
			return _workshop_IDNull;
		}
		set
		{
			_workshop_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FarmStatus_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FarmStatus_ID</c> column value.</value>
	public int FarmStatus_ID
	{
		get
		{
			if (IsFarmStatus_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farmStatus_ID;
		}
		set
		{
			_farmStatus_IDNull = false;
			_farmStatus_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FarmStatus_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarmStatus_IDNull
	{
		get
		{
			return _farmStatus_IDNull;
		}
		set
		{
			_farmStatus_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Name</c> column value.</value>
	public string Name
	{
		get
		{
			if(IsNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _name;
		}
		set
		{
			_nameNull = false;
			_name = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Name"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNameNull
	{
		get
		{
			return _nameNull;
		}
		set
		{
			_nameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Description</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Description</c> column value.</value>
	public string Description
	{
		get
		{
			if(IsDescriptionNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _description;
		}
		set
		{
			_descriptionNull = false;
			_description = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Description"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDescriptionNull
	{
		get
		{
			return _descriptionNull;
		}
		set
		{
			_descriptionNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>HistoryFarm</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>HistoryFarm</c> column value.</value>
	public string HistoryFarm
	{
		get
		{
			if(IsHistoryFarmNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _historyFarm;
		}
		set
		{
			_historyFarmNull = false;
			_historyFarm = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="HistoryFarm"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsHistoryFarmNull
	{
		get
		{
			return _historyFarmNull;
		}
		set
		{
			_historyFarmNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Location_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Location_ID</c> column value.</value>
	public int Location_ID
	{
		get
		{
			if (IsLocation_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _location_ID;
		}
		set
		{
			_location_IDNull = false;
			_location_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Location_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocation_IDNull
	{
		get
		{
			return _location_IDNull;
		}
		set
		{
			_location_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AboutUs</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AboutUs</c> column value.</value>
	public string AboutUs
	{
		get
		{
			if(IsAboutUsNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _aboutUs;
		}
		set
		{
			_aboutUsNull = false;
			_aboutUs = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AboutUs"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAboutUsNull
	{
		get
		{
			return _aboutUsNull;
		}
		set
		{
			_aboutUsNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Address</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Address</c> column value.</value>
	public string Address
	{
		get
		{
			if(IsAddressNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _address;
		}
		set
		{
			_addressNull = false;
			_address = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Address"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAddressNull
	{
		get
		{
			return _addressNull;
		}
		set
		{
			_addressNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Acreage</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Acreage</c> column value.</value>
	public int Acreage
	{
		get
		{
			if (IsAcreageNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _acreage;
		}
		set
		{
			_acreageNull = false;
			_acreage = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Acreage"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAcreageNull
	{
		get
		{
			return _acreageNull;
		}
		set
		{
			_acreageNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Map</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Map</c> column value.</value>
	public string Map
	{
		get
		{
			if(IsMapNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _map;
		}
		set
		{
			_mapNull = false;
			_map = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Map"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMapNull
	{
		get
		{
			return _mapNull;
		}
		set
		{
			_mapNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Phone</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Phone</c> column value.</value>
	public string Phone
	{
		get
		{
			if(IsPhoneNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _phone;
		}
		set
		{
			_phoneNull = false;
			_phone = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Phone"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPhoneNull
	{
		get
		{
			return _phoneNull;
		}
		set
		{
			_phoneNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Fax</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Fax</c> column value.</value>
	public string Fax
	{
		get
		{
			if(IsFaxNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _fax;
		}
		set
		{
			_faxNull = false;
			_fax = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Fax"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFaxNull
	{
		get
		{
			return _faxNull;
		}
		set
		{
			_faxNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Email</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Email</c> column value.</value>
	public string Email
	{
		get
		{
			if(IsEmailNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _email;
		}
		set
		{
			_emailNull = false;
			_email = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Email"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailNull
	{
		get
		{
			return _emailNull;
		}
		set
		{
			_emailNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Contact</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Contact</c> column value.</value>
	public string Contact
	{
		get
		{
			if(IsContactNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _contact;
		}
		set
		{
			_contactNull = false;
			_contact = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Contact"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsContactNull
	{
		get
		{
			return _contactNull;
		}
		set
		{
			_contactNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>URL</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>URL</c> column value.</value>
	public string URL
	{
		get
		{
			if(IsURLNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _url;
		}
		set
		{
			_urlNull = false;
			_url = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="URL"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsURLNull
	{
		get
		{
			return _urlNull;
		}
		set
		{
			_urlNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CreateBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CreateBy</c> column value.</value>
	public System.Guid CreateBy
	{
		get
		{
			if (IsCreateByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _createBy;
		}
		set
		{
			_createByNull = false;
			_createBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CreateBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCreateByNull
	{
		get
		{
			return _createByNull;
		}
		set
		{
			_createByNull = value;
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
		/// Gets or sets the <c>LastEditBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditBy</c> column value.</value>
	public System.Guid LastEditBy
	{
		get
		{
			if (IsLastEditByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditBy;
		}
		set
		{
			_lastEditByNull = false;
			_lastEditBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditByNull
	{
		get
		{
			return _lastEditByNull;
		}
		set
		{
			_lastEditByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LastEditDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditDate</c> column value.</value>
	public System.DateTime LastEditDate
	{
		get
		{
			if (IsLastEditDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditDate;
		}
		set
		{
			_lastEditDateNull = false;
			_lastEditDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditDateNull
	{
		get
		{
			return _lastEditDateNull;
		}
		set
		{
			_lastEditDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCodePublicContent</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodePublicContent</c> column value.</value>
	public string QRCodePublicContent
	{
		get
		{
			if(IsQRCodePublicContentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodePublicContent;
		}
		set
		{
			_qRCodePublicContentNull = false;
			_qRCodePublicContent = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodePublicContent"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodePublicContentNull
	{
		get
		{
			return _qRCodePublicContentNull;
		}
		set
		{
			_qRCodePublicContentNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>IsolationDay</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IsolationDay</c> column value.</value>
	public int IsolationDay
	{
		get
		{
			if (IsIsolationDayNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _isolationDay;
		}
		set
		{
			_isolationDayNull = false;
			_isolationDay = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="IsolationDay"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIsolationDayNull
	{
		get
		{
			return _isolationDayNull;
		}
		set
		{
			_isolationDayNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>GLN</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GLN</c> column value.</value>
	public string GLN
	{
		get
		{
			if(IsGLNNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _gln;
		}
		set
		{
			_glnNull = false;
			_gln = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GLN"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGLNNull
	{
		get
		{
			return _glnNull;
		}
		set
		{
			_glnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>District_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>District_ID</c> column value.</value>
	public int District_ID
	{
		get
		{
			if (IsDistrict_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _district_ID;
		}
		set
		{
			_district_IDNull = false;
			_district_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="District_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDistrict_IDNull
	{
		get
		{
			return _district_IDNull;
		}
		set
		{
			_district_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Ward_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Ward_ID</c> column value.</value>
	public int Ward_ID
	{
		get
		{
			if (IsWard_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _ward_ID;
		}
		set
		{
			_ward_IDNull = false;
			_ward_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Ward_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWard_IDNull
	{
		get
		{
			return _ward_IDNull;
		}
		set
		{
			_ward_IDNull = value;
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
		// Farm_ID
		dynStr.Append("  Farm_ID=");
		if( IsFarm_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Farm_ID);
		

		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// Zone_ID
		dynStr.Append("  Zone_ID=");
		if( IsZone_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Zone_ID);
		// Area_ID
		dynStr.Append("  Area_ID=");
		if( IsArea_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Area_ID);
		// Workshop_ID
		dynStr.Append("  Workshop_ID=");
		if( IsWorkshop_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Workshop_ID);
		// FarmStatus_ID
		dynStr.Append("  FarmStatus_ID=");
		if( IsFarmStatus_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.FarmStatus_ID);
		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// HistoryFarm
		dynStr.Append("  HistoryFarm=");
		if( IsHistoryFarmNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.HistoryFarm);
		

		// Location_ID
		dynStr.Append("  Location_ID=");
		if( IsLocation_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Location_ID);
		// AboutUs
		dynStr.Append("  AboutUs=");
		if( IsAboutUsNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.AboutUs);
		

		// Address
		dynStr.Append("  Address=");
		if( IsAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Address);
		

		// Acreage
		dynStr.Append("  Acreage=");
		if( IsAcreageNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Acreage);
		// Map
		dynStr.Append("  Map=");
		if( IsMapNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Map);
		

		// Phone
		dynStr.Append("  Phone=");
		if( IsPhoneNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Phone);
		

		// Fax
		dynStr.Append("  Fax=");
		if( IsFaxNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Fax);
		

		// Email
		dynStr.Append("  Email=");
		if( IsEmailNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Email);
		

		// Contact
		dynStr.Append("  Contact=");
		if( IsContactNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Contact);
		

		// URL
		dynStr.Append("  URL=");
		if( IsURLNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.URL);
		

		// CreateBy
		dynStr.Append("  CreateBy=");
		if( IsCreateByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateBy);
		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		// LastEditBy
		dynStr.Append("  LastEditBy=");
		if( IsLastEditByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditBy);
		// LastEditDate
		dynStr.Append("  LastEditDate=");
		if( IsLastEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditDate);
		// QRCodePublicContent
		dynStr.Append("  QRCodePublicContent=");
		if( IsQRCodePublicContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodePublicContent);
		

		// IsolationDay
		dynStr.Append("  IsolationDay=");
		if( IsIsolationDayNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.IsolationDay);
		// GLN
		dynStr.Append("  GLN=");
		if( IsGLNNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GLN);
		

		// District_ID
		dynStr.Append("  District_ID=");
		if( IsDistrict_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.District_ID);
		// Ward_ID
		dynStr.Append("  Ward_ID=");
		if( IsWard_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Ward_ID);
		return dynStr.ToString();
	}
}
}




