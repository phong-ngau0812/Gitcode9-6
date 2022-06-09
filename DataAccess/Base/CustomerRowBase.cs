
// <fileinfo name="Base\CustomerRowBase.cs">
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
/// The base class for <see cref="CustomerRow"/> that 
/// represents a record in the <c>Customer</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="CustomerRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class CustomerRowBase
{
	/// _customer_ID
	private int _customer_ID;
	private bool _customer_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _aboutUs
	private string _aboutUs;
	private bool _aboutUsNull = true;
	/// _keyword
	private string _keyword;
	private bool _keywordNull = true;
	/// _logo
	private string _logo;
	private bool _logoNull = true;
	/// _address
	private string _address;
	private bool _addressNull = true;
	/// _location_ID
	private int _location_ID;
	private bool _location_IDNull = true;
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
	/// _ym
	private string _ym;
	private bool _ymNull = true;
	/// _skype
	private string _skype;
	private bool _skypeNull = true;
	/// _website
	private string _website;
	private bool _websiteNull = true;
	/// _contact
	private string _contact;
	private bool _contactNull = true;
	/// _rank
	private int _rank;
	private bool _rankNull = true;
	/// _counter
	private int _counter;
	private bool _counterNull = true;
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
	/// _url
	private string _url;
	private bool _urlNull = true;
	/// _tag
	private string _tag;
	private bool _tagNull = true;
	/// _customerType_ID
	private int _customerType_ID;
	private bool _customerType_IDNull = true;
	/// _gsrn
	private string _gsrn;
	private bool _gsrnNull = true;
	/// _productBrandList_ID
	private string _productBrandList_ID;
	private bool _productBrandList_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="CustomerRowBase"/> class.
	/// </summary>
	public CustomerRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Customer_ID</c> column value.
		/// </summary>
		/// <value>The <c>Customer_ID</c> column value.</value>
	public int Customer_ID
	{
		get
		{
			if(IsCustomer_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _customer_ID;
		}
		set
		{
			_customer_IDNull = false;
			_customer_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Customer_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCustomer_IDNull
	{
		get
		{
			return _customer_IDNull;
		}
		set
		{
			_customer_IDNull = value;
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
		/// Gets or sets the <c>Keyword</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Keyword</c> column value.</value>
	public string Keyword
	{
		get
		{
			if(IsKeywordNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _keyword;
		}
		set
		{
			_keywordNull = false;
			_keyword = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Keyword"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsKeywordNull
	{
		get
		{
			return _keywordNull;
		}
		set
		{
			_keywordNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Logo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Logo</c> column value.</value>
	public string Logo
	{
		get
		{
			if(IsLogoNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _logo;
		}
		set
		{
			_logoNull = false;
			_logo = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Logo"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLogoNull
	{
		get
		{
			return _logoNull;
		}
		set
		{
			_logoNull = value;
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
		/// Gets or sets the <c>YM</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>YM</c> column value.</value>
	public string YM
	{
		get
		{
			if(IsYMNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _ym;
		}
		set
		{
			_ymNull = false;
			_ym = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="YM"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsYMNull
	{
		get
		{
			return _ymNull;
		}
		set
		{
			_ymNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Skype</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Skype</c> column value.</value>
	public string Skype
	{
		get
		{
			if(IsSkypeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _skype;
		}
		set
		{
			_skypeNull = false;
			_skype = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Skype"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSkypeNull
	{
		get
		{
			return _skypeNull;
		}
		set
		{
			_skypeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Website</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Website</c> column value.</value>
	public string Website
	{
		get
		{
			if(IsWebsiteNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _website;
		}
		set
		{
			_websiteNull = false;
			_website = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Website"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWebsiteNull
	{
		get
		{
			return _websiteNull;
		}
		set
		{
			_websiteNull = value;
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
		/// Gets or sets the <c>Rank</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Rank</c> column value.</value>
	public int Rank
	{
		get
		{
			if (IsRankNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _rank;
		}
		set
		{
			_rankNull = false;
			_rank = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Rank"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsRankNull
	{
		get
		{
			return _rankNull;
		}
		set
		{
			_rankNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Counter</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Counter</c> column value.</value>
	public int Counter
	{
		get
		{
			if (IsCounterNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _counter;
		}
		set
		{
			_counterNull = false;
			_counter = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Counter"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCounterNull
	{
		get
		{
			return _counterNull;
		}
		set
		{
			_counterNull = value;
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
		/// Gets or sets the <c>Tag</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Tag</c> column value.</value>
	public string Tag
	{
		get
		{
			if(IsTagNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _tag;
		}
		set
		{
			_tagNull = false;
			_tag = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Tag"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTagNull
	{
		get
		{
			return _tagNull;
		}
		set
		{
			_tagNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CustomerType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CustomerType_ID</c> column value.</value>
	public int CustomerType_ID
	{
		get
		{
			if (IsCustomerType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _customerType_ID;
		}
		set
		{
			_customerType_IDNull = false;
			_customerType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CustomerType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCustomerType_IDNull
	{
		get
		{
			return _customerType_IDNull;
		}
		set
		{
			_customerType_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>GSRN</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GSRN</c> column value.</value>
	public string GSRN
	{
		get
		{
			if(IsGSRNNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _gsrn;
		}
		set
		{
			_gsrnNull = false;
			_gsrn = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GSRN"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGSRNNull
	{
		get
		{
			return _gsrnNull;
		}
		set
		{
			_gsrnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrandList_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrandList_ID</c> column value.</value>
	public string ProductBrandList_ID
	{
		get
		{
			if(IsProductBrandList_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandList_ID;
		}
		set
		{
			_productBrandList_IDNull = false;
			_productBrandList_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandList_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandList_IDNull
	{
		get
		{
			return _productBrandList_IDNull;
		}
		set
		{
			_productBrandList_IDNull = value;
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
		// Customer_ID
		dynStr.Append("  Customer_ID=");
		if( IsCustomer_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Customer_ID);
		

		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
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
		

		// AboutUs
		dynStr.Append("  AboutUs=");
		if( IsAboutUsNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.AboutUs);
		

		// Keyword
		dynStr.Append("  Keyword=");
		if( IsKeywordNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Keyword);
		

		// Logo
		dynStr.Append("  Logo=");
		if( IsLogoNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Logo);
		

		// Address
		dynStr.Append("  Address=");
		if( IsAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Address);
		

		// Location_ID
		dynStr.Append("  Location_ID=");
		if( IsLocation_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Location_ID);
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
		

		// YM
		dynStr.Append("  YM=");
		if( IsYMNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.YM);
		

		// Skype
		dynStr.Append("  Skype=");
		if( IsSkypeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Skype);
		

		// Website
		dynStr.Append("  Website=");
		if( IsWebsiteNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Website);
		

		// Contact
		dynStr.Append("  Contact=");
		if( IsContactNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Contact);
		

		// Rank
		dynStr.Append("  Rank=");
		if( IsRankNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Rank);
		// Counter
		dynStr.Append("  Counter=");
		if( IsCounterNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Counter);
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
		// URL
		dynStr.Append("  URL=");
		if( IsURLNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.URL);
		

		// Tag
		dynStr.Append("  Tag=");
		if( IsTagNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Tag);
		

		// CustomerType_ID
		dynStr.Append("  CustomerType_ID=");
		if( IsCustomerType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CustomerType_ID);
		// GSRN
		dynStr.Append("  GSRN=");
		if( IsGSRNNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GSRN);
		

		// ProductBrandList_ID
		dynStr.Append("  ProductBrandList_ID=");
		if( IsProductBrandList_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductBrandList_ID);
		

		return dynStr.ToString();
	}
}
}




