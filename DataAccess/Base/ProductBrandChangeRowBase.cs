
// <fileinfo name="Base\ProductBrandChangeRowBase.cs">
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
/// The base class for <see cref="ProductBrandChangeRow"/> that 
/// represents a record in the <c>ProductBrandChange</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductBrandChangeRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductBrandChangeRowBase
{
	/// _productBrandChange_ID
	private int _productBrandChange_ID;
	private bool _productBrandChange_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _language_ID
	private int _language_ID;
	private bool _language_IDNull = true;
	/// _location_ID
	private int _location_ID;
	private bool _location_IDNull = true;
	/// _district_ID
	private int _district_ID;
	private bool _district_IDNull = true;
	/// _ward_ID
	private int _ward_ID;
	private bool _ward_IDNull = true;
	/// _departmentMan_ID
	private int _departmentMan_ID;
	private bool _departmentMan_IDNull = true;
	/// _productBrandType_ID
	private int _productBrandType_ID;
	private bool _productBrandType_IDNull = true;
	/// _code
	private string _code;
	private bool _codeNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _tradingName
	private string _tradingName;
	private bool _tradingNameNull = true;
	/// _brandName
	private string _brandName;
	private bool _brandNameNull = true;
	/// _taxCode
	private string _taxCode;
	private bool _taxCodeNull = true;
	/// _registrationNumber
	private string _registrationNumber;
	private bool _registrationNumberNull = true;
	/// _issuedDate
	private System.DateTime _issuedDate;
	private bool _issuedDateNull = true;
	/// _businessArea
	private string _businessArea;
	private bool _businessAreaNull = true;
	/// _address
	private string _address;
	private bool _addressNull = true;
	/// _telephone
	private string _telephone;
	private bool _telephoneNull = true;
	/// _fax
	private string _fax;
	private bool _faxNull = true;
	/// _mobile
	private string _mobile;
	private bool _mobileNull = true;
	/// _email
	private string _email;
	private bool _emailNull = true;
	/// _website
	private string _website;
	private bool _websiteNull = true;
	/// _facebook
	private string _facebook;
	private bool _facebookNull = true;
	/// _zalo
	private string _zalo;
	private bool _zaloNull = true;
	/// _hotline
	private string _hotline;
	private bool _hotlineNull = true;
	/// _skype
	private string _skype;
	private bool _skypeNull = true;
	/// _pRInfo
	private string _pRInfo;
	private bool _pRInfoNull = true;
	/// _agency
	private string _agency;
	private bool _agencyNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _image
	private string _image;
	private bool _imageNull = true;
	/// _personName
	private string _personName;
	private bool _personNameNull = true;
	/// _personAddress
	private string _personAddress;
	private bool _personAddressNull = true;
	/// _personMobile
	private string _personMobile;
	private bool _personMobileNull = true;
	/// _personEmail
	private string _personEmail;
	private bool _personEmailNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;
	/// _url
	private string _url;
	private bool _urlNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
	/// _hasQRCode
	private bool _hasQRCode;
	private bool _hasQRCodeNull = true;
	/// _viewCount
	private int _viewCount;
	private bool _viewCountNull = true;
	/// _sellCount
	private int _sellCount;
	private bool _sellCountNull = true;
	/// _accountUserName
	private string _accountUserName;
	private bool _accountUserNameNull = true;
	/// _accountEmail
	private string _accountEmail;
	private bool _accountEmailNull = true;
	/// _directorName
	private string _directorName;
	private bool _directorNameNull = true;
	/// _directorBirthday
	private System.DateTime _directorBirthday;
	private bool _directorBirthdayNull = true;
	/// _directorAddress
	private string _directorAddress;
	private bool _directorAddressNull = true;
	/// _directorMobile
	private string _directorMobile;
	private bool _directorMobileNull = true;
	/// _directorEmail
	private string _directorEmail;
	private bool _directorEmailNull = true;
	/// _directorPosition
	private string _directorPosition;
	private bool _directorPositionNull = true;
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
	/// _verifyApproveBy
	private System.Guid _verifyApproveBy;
	private bool _verifyApproveByNull = true;
	/// _verifyApproveDate
	private System.DateTime _verifyApproveDate;
	private bool _verifyApproveDateNull = true;
	/// _checkApproveBy
	private System.Guid _checkApproveBy;
	private bool _checkApproveByNull = true;
	/// _checkApproveDate
	private System.DateTime _checkApproveDate;
	private bool _checkApproveDateNull = true;
	/// _adminApproveBy
	private System.Guid _adminApproveBy;
	private bool _adminApproveByNull = true;
	/// _adminApproveDate
	private System.DateTime _adminApproveDate;
	private bool _adminApproveDateNull = true;
	/// _qRCodePublicContent
	private string _qRCodePublicContent;
	private bool _qRCodePublicContentNull = true;
	/// _checkDomain
	private string _checkDomain;
	private bool _checkDomainNull = true;
	/// _checkServer_ID
	private int _checkServer_ID;
	private bool _checkServer_IDNull = true;
	/// _gcp
	private string _gcp;
	private bool _gcpNull = true;
	/// _gln
	private string _gln;
	private bool _glnNull = true;
	/// _productBrandType_ID_List
	private string _productBrandType_ID_List;
	private bool _productBrandType_ID_ListNull = true;
	/// _branch_ID
	private int _branch_ID;
	private bool _branch_IDNull = true;
	/// _productionUnitCode
	private string _productionUnitCode;
	private bool _productionUnitCodeNull = true;
	/// _checkProductBrand_ID
	private int _checkProductBrand_ID;
	private bool _checkProductBrand_IDNull = true;
	/// _chainLink_ID
	private int _chainLink_ID;
	private bool _chainLink_IDNull = true;
	/// _story
	private string _story;
	private bool _storyNull = true;
	/// _functionGroup_ID
	private int _functionGroup_ID;
	private bool _functionGroup_IDNull = true;
	/// _businessType_ID
	private int _businessType_ID;
	private bool _businessType_IDNull = true;
	/// _productBrandChange_Note
	private string _productBrandChange_Note;
	private bool _productBrandChange_NoteNull = true;
	/// _productBrandChange_By
	private System.Guid _productBrandChange_By;
	private bool _productBrandChange_ByNull = true;
	/// _productBrandChange_Approved
	private System.Guid _productBrandChange_Approved;
	private bool _productBrandChange_ApprovedNull = true;
	/// _productBrandChange_Date
	private System.DateTime _productBrandChange_Date;
	private bool _productBrandChange_DateNull = true;
	/// _productBrandChange_DateApproved
	private System.DateTime _productBrandChange_DateApproved;
	private bool _productBrandChange_DateApprovedNull = true;
	/// _productBrandChange_Status
	private int _productBrandChange_Status;
	private bool _productBrandChange_StatusNull = true;
	/// _productBrandChange_ApprovedNote
	private string _productBrandChange_ApprovedNote;
	private bool _productBrandChange_ApprovedNoteNull = true;
	/// _youTube
	private string _youTube;
	private bool _youTubeNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductBrandChangeRowBase"/> class.
	/// </summary>
	public ProductBrandChangeRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrandChange_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductBrandChange_ID</c> column value.</value>
	public int ProductBrandChange_ID
	{
		get
		{
			if(IsProductBrandChange_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandChange_ID;
		}
		set
		{
			_productBrandChange_IDNull = false;
			_productBrandChange_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandChange_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandChange_IDNull
	{
		get
		{
			return _productBrandChange_IDNull;
		}
		set
		{
			_productBrandChange_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrand_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductBrand_ID</c> column value.</value>
	public int ProductBrand_ID
	{
		get
		{
			if(IsProductBrand_IDNull)
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
		/// Gets or sets the <c>Language_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Language_ID</c> column value.</value>
	public int Language_ID
	{
		get
		{
			if (IsLanguage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _language_ID;
		}
		set
		{
			_language_IDNull = false;
			_language_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Language_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLanguage_IDNull
	{
		get
		{
			return _language_IDNull;
		}
		set
		{
			_language_IDNull = value;
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
		/// Gets or sets the <c>DepartmentMan_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DepartmentMan_ID</c> column value.</value>
	public int DepartmentMan_ID
	{
		get
		{
			if (IsDepartmentMan_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _departmentMan_ID;
		}
		set
		{
			_departmentMan_IDNull = false;
			_departmentMan_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DepartmentMan_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDepartmentMan_IDNull
	{
		get
		{
			return _departmentMan_IDNull;
		}
		set
		{
			_departmentMan_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrandType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrandType_ID</c> column value.</value>
	public int ProductBrandType_ID
	{
		get
		{
			if (IsProductBrandType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandType_ID;
		}
		set
		{
			_productBrandType_IDNull = false;
			_productBrandType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandType_IDNull
	{
		get
		{
			return _productBrandType_IDNull;
		}
		set
		{
			_productBrandType_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Code</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Code</c> column value.</value>
	public string Code
	{
		get
		{
			if(IsCodeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _code;
		}
		set
		{
			_codeNull = false;
			_code = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Code"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCodeNull
	{
		get
		{
			return _codeNull;
		}
		set
		{
			_codeNull = value;
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
		/// Gets or sets the <c>TradingName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TradingName</c> column value.</value>
	public string TradingName
	{
		get
		{
			if(IsTradingNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _tradingName;
		}
		set
		{
			_tradingNameNull = false;
			_tradingName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TradingName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTradingNameNull
	{
		get
		{
			return _tradingNameNull;
		}
		set
		{
			_tradingNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>BrandName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BrandName</c> column value.</value>
	public string BrandName
	{
		get
		{
			if(IsBrandNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _brandName;
		}
		set
		{
			_brandNameNull = false;
			_brandName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="BrandName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBrandNameNull
	{
		get
		{
			return _brandNameNull;
		}
		set
		{
			_brandNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TaxCode</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TaxCode</c> column value.</value>
	public string TaxCode
	{
		get
		{
			if(IsTaxCodeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _taxCode;
		}
		set
		{
			_taxCodeNull = false;
			_taxCode = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TaxCode"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTaxCodeNull
	{
		get
		{
			return _taxCodeNull;
		}
		set
		{
			_taxCodeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>RegistrationNumber</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>RegistrationNumber</c> column value.</value>
	public string RegistrationNumber
	{
		get
		{
			if(IsRegistrationNumberNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _registrationNumber;
		}
		set
		{
			_registrationNumberNull = false;
			_registrationNumber = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="RegistrationNumber"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsRegistrationNumberNull
	{
		get
		{
			return _registrationNumberNull;
		}
		set
		{
			_registrationNumberNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>IssuedDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IssuedDate</c> column value.</value>
	public System.DateTime IssuedDate
	{
		get
		{
			if (IsIssuedDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _issuedDate;
		}
		set
		{
			_issuedDateNull = false;
			_issuedDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="IssuedDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIssuedDateNull
	{
		get
		{
			return _issuedDateNull;
		}
		set
		{
			_issuedDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>BusinessArea</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BusinessArea</c> column value.</value>
	public string BusinessArea
	{
		get
		{
			if(IsBusinessAreaNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _businessArea;
		}
		set
		{
			_businessAreaNull = false;
			_businessArea = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="BusinessArea"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBusinessAreaNull
	{
		get
		{
			return _businessAreaNull;
		}
		set
		{
			_businessAreaNull = value;
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
		/// Gets or sets the <c>Telephone</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Telephone</c> column value.</value>
	public string Telephone
	{
		get
		{
			if(IsTelephoneNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _telephone;
		}
		set
		{
			_telephoneNull = false;
			_telephone = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Telephone"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTelephoneNull
	{
		get
		{
			return _telephoneNull;
		}
		set
		{
			_telephoneNull = value;
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
		/// Gets or sets the <c>Mobile</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Mobile</c> column value.</value>
	public string Mobile
	{
		get
		{
			if(IsMobileNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _mobile;
		}
		set
		{
			_mobileNull = false;
			_mobile = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Mobile"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMobileNull
	{
		get
		{
			return _mobileNull;
		}
		set
		{
			_mobileNull = value;
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
		/// Gets or sets the <c>Facebook</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Facebook</c> column value.</value>
	public string Facebook
	{
		get
		{
			if(IsFacebookNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _facebook;
		}
		set
		{
			_facebookNull = false;
			_facebook = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Facebook"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFacebookNull
	{
		get
		{
			return _facebookNull;
		}
		set
		{
			_facebookNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Zalo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Zalo</c> column value.</value>
	public string Zalo
	{
		get
		{
			if(IsZaloNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _zalo;
		}
		set
		{
			_zaloNull = false;
			_zalo = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Zalo"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsZaloNull
	{
		get
		{
			return _zaloNull;
		}
		set
		{
			_zaloNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Hotline</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Hotline</c> column value.</value>
	public string Hotline
	{
		get
		{
			if(IsHotlineNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _hotline;
		}
		set
		{
			_hotlineNull = false;
			_hotline = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Hotline"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsHotlineNull
	{
		get
		{
			return _hotlineNull;
		}
		set
		{
			_hotlineNull = value;
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
		/// Gets or sets the <c>PRInfo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PRInfo</c> column value.</value>
	public string PRInfo
	{
		get
		{
			if(IsPRInfoNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _pRInfo;
		}
		set
		{
			_pRInfoNull = false;
			_pRInfo = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PRInfo"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPRInfoNull
	{
		get
		{
			return _pRInfoNull;
		}
		set
		{
			_pRInfoNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Agency</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Agency</c> column value.</value>
	public string Agency
	{
		get
		{
			if(IsAgencyNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _agency;
		}
		set
		{
			_agencyNull = false;
			_agency = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Agency"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAgencyNull
	{
		get
		{
			return _agencyNull;
		}
		set
		{
			_agencyNull = value;
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
		/// Gets or sets the <c>Image</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Image</c> column value.</value>
	public string Image
	{
		get
		{
			if(IsImageNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _image;
		}
		set
		{
			_imageNull = false;
			_image = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Image"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsImageNull
	{
		get
		{
			return _imageNull;
		}
		set
		{
			_imageNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>PersonName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PersonName</c> column value.</value>
	public string PersonName
	{
		get
		{
			if(IsPersonNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _personName;
		}
		set
		{
			_personNameNull = false;
			_personName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PersonName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPersonNameNull
	{
		get
		{
			return _personNameNull;
		}
		set
		{
			_personNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>PersonAddress</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PersonAddress</c> column value.</value>
	public string PersonAddress
	{
		get
		{
			if(IsPersonAddressNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _personAddress;
		}
		set
		{
			_personAddressNull = false;
			_personAddress = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PersonAddress"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPersonAddressNull
	{
		get
		{
			return _personAddressNull;
		}
		set
		{
			_personAddressNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>PersonMobile</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PersonMobile</c> column value.</value>
	public string PersonMobile
	{
		get
		{
			if(IsPersonMobileNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _personMobile;
		}
		set
		{
			_personMobileNull = false;
			_personMobile = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PersonMobile"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPersonMobileNull
	{
		get
		{
			return _personMobileNull;
		}
		set
		{
			_personMobileNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>PersonEmail</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PersonEmail</c> column value.</value>
	public string PersonEmail
	{
		get
		{
			if(IsPersonEmailNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _personEmail;
		}
		set
		{
			_personEmailNull = false;
			_personEmail = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PersonEmail"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPersonEmailNull
	{
		get
		{
			return _personEmailNull;
		}
		set
		{
			_personEmailNull = value;
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
		/// Gets or sets the <c>Active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
	public bool Active
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
		/// Gets or sets the <c>HasQRCode</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>HasQRCode</c> column value.</value>
	public bool HasQRCode
	{
		get
		{
			if (IsHasQRCodeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _hasQRCode;
		}
		set
		{
			_hasQRCodeNull = false;
			_hasQRCode = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="HasQRCode"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsHasQRCodeNull
	{
		get
		{
			return _hasQRCodeNull;
		}
		set
		{
			_hasQRCodeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ViewCount</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ViewCount</c> column value.</value>
	public int ViewCount
	{
		get
		{
			if (IsViewCountNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _viewCount;
		}
		set
		{
			_viewCountNull = false;
			_viewCount = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ViewCount"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsViewCountNull
	{
		get
		{
			return _viewCountNull;
		}
		set
		{
			_viewCountNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SellCount</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SellCount</c> column value.</value>
	public int SellCount
	{
		get
		{
			if (IsSellCountNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sellCount;
		}
		set
		{
			_sellCountNull = false;
			_sellCount = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SellCount"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSellCountNull
	{
		get
		{
			return _sellCountNull;
		}
		set
		{
			_sellCountNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AccountUserName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AccountUserName</c> column value.</value>
	public string AccountUserName
	{
		get
		{
			if(IsAccountUserNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _accountUserName;
		}
		set
		{
			_accountUserNameNull = false;
			_accountUserName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AccountUserName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAccountUserNameNull
	{
		get
		{
			return _accountUserNameNull;
		}
		set
		{
			_accountUserNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AccountEmail</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AccountEmail</c> column value.</value>
	public string AccountEmail
	{
		get
		{
			if(IsAccountEmailNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _accountEmail;
		}
		set
		{
			_accountEmailNull = false;
			_accountEmail = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AccountEmail"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAccountEmailNull
	{
		get
		{
			return _accountEmailNull;
		}
		set
		{
			_accountEmailNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DirectorName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DirectorName</c> column value.</value>
	public string DirectorName
	{
		get
		{
			if(IsDirectorNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _directorName;
		}
		set
		{
			_directorNameNull = false;
			_directorName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DirectorName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDirectorNameNull
	{
		get
		{
			return _directorNameNull;
		}
		set
		{
			_directorNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DirectorBirthday</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DirectorBirthday</c> column value.</value>
	public System.DateTime DirectorBirthday
	{
		get
		{
			if (IsDirectorBirthdayNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _directorBirthday;
		}
		set
		{
			_directorBirthdayNull = false;
			_directorBirthday = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DirectorBirthday"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDirectorBirthdayNull
	{
		get
		{
			return _directorBirthdayNull;
		}
		set
		{
			_directorBirthdayNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DirectorAddress</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DirectorAddress</c> column value.</value>
	public string DirectorAddress
	{
		get
		{
			if(IsDirectorAddressNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _directorAddress;
		}
		set
		{
			_directorAddressNull = false;
			_directorAddress = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DirectorAddress"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDirectorAddressNull
	{
		get
		{
			return _directorAddressNull;
		}
		set
		{
			_directorAddressNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DirectorMobile</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DirectorMobile</c> column value.</value>
	public string DirectorMobile
	{
		get
		{
			if(IsDirectorMobileNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _directorMobile;
		}
		set
		{
			_directorMobileNull = false;
			_directorMobile = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DirectorMobile"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDirectorMobileNull
	{
		get
		{
			return _directorMobileNull;
		}
		set
		{
			_directorMobileNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DirectorEmail</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DirectorEmail</c> column value.</value>
	public string DirectorEmail
	{
		get
		{
			if(IsDirectorEmailNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _directorEmail;
		}
		set
		{
			_directorEmailNull = false;
			_directorEmail = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DirectorEmail"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDirectorEmailNull
	{
		get
		{
			return _directorEmailNull;
		}
		set
		{
			_directorEmailNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DirectorPosition</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DirectorPosition</c> column value.</value>
	public string DirectorPosition
	{
		get
		{
			if(IsDirectorPositionNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _directorPosition;
		}
		set
		{
			_directorPositionNull = false;
			_directorPosition = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DirectorPosition"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDirectorPositionNull
	{
		get
		{
			return _directorPositionNull;
		}
		set
		{
			_directorPositionNull = value;
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
		/// Gets or sets the <c>VerifyApproveBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>VerifyApproveBy</c> column value.</value>
	public System.Guid VerifyApproveBy
	{
		get
		{
			if (IsVerifyApproveByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _verifyApproveBy;
		}
		set
		{
			_verifyApproveByNull = false;
			_verifyApproveBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="VerifyApproveBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsVerifyApproveByNull
	{
		get
		{
			return _verifyApproveByNull;
		}
		set
		{
			_verifyApproveByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>VerifyApproveDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>VerifyApproveDate</c> column value.</value>
	public System.DateTime VerifyApproveDate
	{
		get
		{
			if (IsVerifyApproveDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _verifyApproveDate;
		}
		set
		{
			_verifyApproveDateNull = false;
			_verifyApproveDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="VerifyApproveDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsVerifyApproveDateNull
	{
		get
		{
			return _verifyApproveDateNull;
		}
		set
		{
			_verifyApproveDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CheckApproveBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CheckApproveBy</c> column value.</value>
	public System.Guid CheckApproveBy
	{
		get
		{
			if (IsCheckApproveByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _checkApproveBy;
		}
		set
		{
			_checkApproveByNull = false;
			_checkApproveBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CheckApproveBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCheckApproveByNull
	{
		get
		{
			return _checkApproveByNull;
		}
		set
		{
			_checkApproveByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CheckApproveDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CheckApproveDate</c> column value.</value>
	public System.DateTime CheckApproveDate
	{
		get
		{
			if (IsCheckApproveDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _checkApproveDate;
		}
		set
		{
			_checkApproveDateNull = false;
			_checkApproveDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CheckApproveDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCheckApproveDateNull
	{
		get
		{
			return _checkApproveDateNull;
		}
		set
		{
			_checkApproveDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AdminApproveBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AdminApproveBy</c> column value.</value>
	public System.Guid AdminApproveBy
	{
		get
		{
			if (IsAdminApproveByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _adminApproveBy;
		}
		set
		{
			_adminApproveByNull = false;
			_adminApproveBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AdminApproveBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAdminApproveByNull
	{
		get
		{
			return _adminApproveByNull;
		}
		set
		{
			_adminApproveByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AdminApproveDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AdminApproveDate</c> column value.</value>
	public System.DateTime AdminApproveDate
	{
		get
		{
			if (IsAdminApproveDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _adminApproveDate;
		}
		set
		{
			_adminApproveDateNull = false;
			_adminApproveDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AdminApproveDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAdminApproveDateNull
	{
		get
		{
			return _adminApproveDateNull;
		}
		set
		{
			_adminApproveDateNull = value;
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
		/// Gets or sets the <c>CheckDomain</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CheckDomain</c> column value.</value>
	public string CheckDomain
	{
		get
		{
			if(IsCheckDomainNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _checkDomain;
		}
		set
		{
			_checkDomainNull = false;
			_checkDomain = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CheckDomain"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCheckDomainNull
	{
		get
		{
			return _checkDomainNull;
		}
		set
		{
			_checkDomainNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CheckServer_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CheckServer_ID</c> column value.</value>
	public int CheckServer_ID
	{
		get
		{
			if (IsCheckServer_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _checkServer_ID;
		}
		set
		{
			_checkServer_IDNull = false;
			_checkServer_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CheckServer_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCheckServer_IDNull
	{
		get
		{
			return _checkServer_IDNull;
		}
		set
		{
			_checkServer_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>GCP</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GCP</c> column value.</value>
	public string GCP
	{
		get
		{
			if(IsGCPNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _gcp;
		}
		set
		{
			_gcpNull = false;
			_gcp = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GCP"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGCPNull
	{
		get
		{
			return _gcpNull;
		}
		set
		{
			_gcpNull = value;
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
		/// Gets or sets the <c>ProductBrandType_ID_List</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrandType_ID_List</c> column value.</value>
	public string ProductBrandType_ID_List
	{
		get
		{
			if(IsProductBrandType_ID_ListNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandType_ID_List;
		}
		set
		{
			_productBrandType_ID_ListNull = false;
			_productBrandType_ID_List = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandType_ID_List"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandType_ID_ListNull
	{
		get
		{
			return _productBrandType_ID_ListNull;
		}
		set
		{
			_productBrandType_ID_ListNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Branch_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Branch_ID</c> column value.</value>
	public int Branch_ID
	{
		get
		{
			if (IsBranch_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _branch_ID;
		}
		set
		{
			_branch_IDNull = false;
			_branch_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Branch_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBranch_IDNull
	{
		get
		{
			return _branch_IDNull;
		}
		set
		{
			_branch_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductionUnitCode</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductionUnitCode</c> column value.</value>
	public string ProductionUnitCode
	{
		get
		{
			if(IsProductionUnitCodeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productionUnitCode;
		}
		set
		{
			_productionUnitCodeNull = false;
			_productionUnitCode = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductionUnitCode"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductionUnitCodeNull
	{
		get
		{
			return _productionUnitCodeNull;
		}
		set
		{
			_productionUnitCodeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CheckProductBrand_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CheckProductBrand_ID</c> column value.</value>
	public int CheckProductBrand_ID
	{
		get
		{
			if (IsCheckProductBrand_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _checkProductBrand_ID;
		}
		set
		{
			_checkProductBrand_IDNull = false;
			_checkProductBrand_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CheckProductBrand_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCheckProductBrand_IDNull
	{
		get
		{
			return _checkProductBrand_IDNull;
		}
		set
		{
			_checkProductBrand_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ChainLink_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ChainLink_ID</c> column value.</value>
	public int ChainLink_ID
	{
		get
		{
			if (IsChainLink_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _chainLink_ID;
		}
		set
		{
			_chainLink_IDNull = false;
			_chainLink_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ChainLink_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsChainLink_IDNull
	{
		get
		{
			return _chainLink_IDNull;
		}
		set
		{
			_chainLink_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Story</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Story</c> column value.</value>
	public string Story
	{
		get
		{
			if(IsStoryNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _story;
		}
		set
		{
			_storyNull = false;
			_story = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Story"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStoryNull
	{
		get
		{
			return _storyNull;
		}
		set
		{
			_storyNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FunctionGroup_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FunctionGroup_ID</c> column value.</value>
	public int FunctionGroup_ID
	{
		get
		{
			if (IsFunctionGroup_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _functionGroup_ID;
		}
		set
		{
			_functionGroup_IDNull = false;
			_functionGroup_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FunctionGroup_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFunctionGroup_IDNull
	{
		get
		{
			return _functionGroup_IDNull;
		}
		set
		{
			_functionGroup_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>BusinessType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BusinessType_ID</c> column value.</value>
	public int BusinessType_ID
	{
		get
		{
			if (IsBusinessType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _businessType_ID;
		}
		set
		{
			_businessType_IDNull = false;
			_businessType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="BusinessType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBusinessType_IDNull
	{
		get
		{
			return _businessType_IDNull;
		}
		set
		{
			_businessType_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrandChange_Note</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrandChange_Note</c> column value.</value>
	public string ProductBrandChange_Note
	{
		get
		{
			if(IsProductBrandChange_NoteNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandChange_Note;
		}
		set
		{
			_productBrandChange_NoteNull = false;
			_productBrandChange_Note = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandChange_Note"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandChange_NoteNull
	{
		get
		{
			return _productBrandChange_NoteNull;
		}
		set
		{
			_productBrandChange_NoteNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrandChange_By</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrandChange_By</c> column value.</value>
	public System.Guid ProductBrandChange_By
	{
		get
		{
			if (IsProductBrandChange_ByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandChange_By;
		}
		set
		{
			_productBrandChange_ByNull = false;
			_productBrandChange_By = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandChange_By"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandChange_ByNull
	{
		get
		{
			return _productBrandChange_ByNull;
		}
		set
		{
			_productBrandChange_ByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrandChange_Approved</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrandChange_Approved</c> column value.</value>
	public System.Guid ProductBrandChange_Approved
	{
		get
		{
			if (IsProductBrandChange_ApprovedNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandChange_Approved;
		}
		set
		{
			_productBrandChange_ApprovedNull = false;
			_productBrandChange_Approved = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandChange_Approved"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandChange_ApprovedNull
	{
		get
		{
			return _productBrandChange_ApprovedNull;
		}
		set
		{
			_productBrandChange_ApprovedNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrandChange_Date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrandChange_Date</c> column value.</value>
	public System.DateTime ProductBrandChange_Date
	{
		get
		{
			if (IsProductBrandChange_DateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandChange_Date;
		}
		set
		{
			_productBrandChange_DateNull = false;
			_productBrandChange_Date = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandChange_Date"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandChange_DateNull
	{
		get
		{
			return _productBrandChange_DateNull;
		}
		set
		{
			_productBrandChange_DateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrandChange_DateApproved</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrandChange_DateApproved</c> column value.</value>
	public System.DateTime ProductBrandChange_DateApproved
	{
		get
		{
			if (IsProductBrandChange_DateApprovedNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandChange_DateApproved;
		}
		set
		{
			_productBrandChange_DateApprovedNull = false;
			_productBrandChange_DateApproved = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandChange_DateApproved"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandChange_DateApprovedNull
	{
		get
		{
			return _productBrandChange_DateApprovedNull;
		}
		set
		{
			_productBrandChange_DateApprovedNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrandChange_Status</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrandChange_Status</c> column value.</value>
	public int ProductBrandChange_Status
	{
		get
		{
			if (IsProductBrandChange_StatusNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandChange_Status;
		}
		set
		{
			_productBrandChange_StatusNull = false;
			_productBrandChange_Status = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandChange_Status"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandChange_StatusNull
	{
		get
		{
			return _productBrandChange_StatusNull;
		}
		set
		{
			_productBrandChange_StatusNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrandChange_ApprovedNote</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrandChange_ApprovedNote</c> column value.</value>
	public string ProductBrandChange_ApprovedNote
	{
		get
		{
			if(IsProductBrandChange_ApprovedNoteNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandChange_ApprovedNote;
		}
		set
		{
			_productBrandChange_ApprovedNoteNull = false;
			_productBrandChange_ApprovedNote = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandChange_ApprovedNote"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandChange_ApprovedNoteNull
	{
		get
		{
			return _productBrandChange_ApprovedNoteNull;
		}
		set
		{
			_productBrandChange_ApprovedNoteNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>YouTube</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>YouTube</c> column value.</value>
	public string YouTube
	{
		get
		{
			if(IsYouTubeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _youTube;
		}
		set
		{
			_youTubeNull = false;
			_youTube = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="YouTube"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsYouTubeNull
	{
		get
		{
			return _youTubeNull;
		}
		set
		{
			_youTubeNull = value;
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
		// ProductBrandChange_ID
		dynStr.Append("  ProductBrandChange_ID=");
		if( IsProductBrandChange_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductBrandChange_ID);
		

		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductBrand_ID);
		

		// Language_ID
		dynStr.Append("  Language_ID=");
		if( IsLanguage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Language_ID);
		// Location_ID
		dynStr.Append("  Location_ID=");
		if( IsLocation_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Location_ID);
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
		// DepartmentMan_ID
		dynStr.Append("  DepartmentMan_ID=");
		if( IsDepartmentMan_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.DepartmentMan_ID);
		// ProductBrandType_ID
		dynStr.Append("  ProductBrandType_ID=");
		if( IsProductBrandType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrandType_ID);
		// Code
		dynStr.Append("  Code=");
		if( IsCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Code);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// TradingName
		dynStr.Append("  TradingName=");
		if( IsTradingNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TradingName);
		

		// BrandName
		dynStr.Append("  BrandName=");
		if( IsBrandNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.BrandName);
		

		// TaxCode
		dynStr.Append("  TaxCode=");
		if( IsTaxCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TaxCode);
		

		// RegistrationNumber
		dynStr.Append("  RegistrationNumber=");
		if( IsRegistrationNumberNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.RegistrationNumber);
		

		// IssuedDate
		dynStr.Append("  IssuedDate=");
		if( IsIssuedDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.IssuedDate);
		// BusinessArea
		dynStr.Append("  BusinessArea=");
		if( IsBusinessAreaNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.BusinessArea);
		

		// Address
		dynStr.Append("  Address=");
		if( IsAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Address);
		

		// Telephone
		dynStr.Append("  Telephone=");
		if( IsTelephoneNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Telephone);
		

		// Fax
		dynStr.Append("  Fax=");
		if( IsFaxNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Fax);
		

		// Mobile
		dynStr.Append("  Mobile=");
		if( IsMobileNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Mobile);
		

		// Email
		dynStr.Append("  Email=");
		if( IsEmailNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Email);
		

		// Website
		dynStr.Append("  Website=");
		if( IsWebsiteNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Website);
		

		// Facebook
		dynStr.Append("  Facebook=");
		if( IsFacebookNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Facebook);
		

		// Zalo
		dynStr.Append("  Zalo=");
		if( IsZaloNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Zalo);
		

		// Hotline
		dynStr.Append("  Hotline=");
		if( IsHotlineNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Hotline);
		

		// Skype
		dynStr.Append("  Skype=");
		if( IsSkypeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Skype);
		

		// PRInfo
		dynStr.Append("  PRInfo=");
		if( IsPRInfoNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PRInfo);
		

		// Agency
		dynStr.Append("  Agency=");
		if( IsAgencyNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Agency);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// Image
		dynStr.Append("  Image=");
		if( IsImageNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Image);
		

		// PersonName
		dynStr.Append("  PersonName=");
		if( IsPersonNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PersonName);
		

		// PersonAddress
		dynStr.Append("  PersonAddress=");
		if( IsPersonAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PersonAddress);
		

		// PersonMobile
		dynStr.Append("  PersonMobile=");
		if( IsPersonMobileNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PersonMobile);
		

		// PersonEmail
		dynStr.Append("  PersonEmail=");
		if( IsPersonEmailNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PersonEmail);
		

		// Sort
		dynStr.Append("  Sort=");
		if( IsSortNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Sort);
		// URL
		dynStr.Append("  URL=");
		if( IsURLNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.URL);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// HasQRCode
		dynStr.Append("  HasQRCode=");
		if( IsHasQRCodeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.HasQRCode);
		// ViewCount
		dynStr.Append("  ViewCount=");
		if( IsViewCountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ViewCount);
		// SellCount
		dynStr.Append("  SellCount=");
		if( IsSellCountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.SellCount);
		// AccountUserName
		dynStr.Append("  AccountUserName=");
		if( IsAccountUserNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.AccountUserName);
		

		// AccountEmail
		dynStr.Append("  AccountEmail=");
		if( IsAccountEmailNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.AccountEmail);
		

		// DirectorName
		dynStr.Append("  DirectorName=");
		if( IsDirectorNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DirectorName);
		

		// DirectorBirthday
		dynStr.Append("  DirectorBirthday=");
		if( IsDirectorBirthdayNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.DirectorBirthday);
		// DirectorAddress
		dynStr.Append("  DirectorAddress=");
		if( IsDirectorAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DirectorAddress);
		

		// DirectorMobile
		dynStr.Append("  DirectorMobile=");
		if( IsDirectorMobileNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DirectorMobile);
		

		// DirectorEmail
		dynStr.Append("  DirectorEmail=");
		if( IsDirectorEmailNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DirectorEmail);
		

		// DirectorPosition
		dynStr.Append("  DirectorPosition=");
		if( IsDirectorPositionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DirectorPosition);
		

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
		// VerifyApproveBy
		dynStr.Append("  VerifyApproveBy=");
		if( IsVerifyApproveByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.VerifyApproveBy);
		// VerifyApproveDate
		dynStr.Append("  VerifyApproveDate=");
		if( IsVerifyApproveDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.VerifyApproveDate);
		// CheckApproveBy
		dynStr.Append("  CheckApproveBy=");
		if( IsCheckApproveByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CheckApproveBy);
		// CheckApproveDate
		dynStr.Append("  CheckApproveDate=");
		if( IsCheckApproveDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CheckApproveDate);
		// AdminApproveBy
		dynStr.Append("  AdminApproveBy=");
		if( IsAdminApproveByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AdminApproveBy);
		// AdminApproveDate
		dynStr.Append("  AdminApproveDate=");
		if( IsAdminApproveDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AdminApproveDate);
		// QRCodePublicContent
		dynStr.Append("  QRCodePublicContent=");
		if( IsQRCodePublicContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodePublicContent);
		

		// CheckDomain
		dynStr.Append("  CheckDomain=");
		if( IsCheckDomainNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CheckDomain);
		

		// CheckServer_ID
		dynStr.Append("  CheckServer_ID=");
		if( IsCheckServer_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CheckServer_ID);
		// GCP
		dynStr.Append("  GCP=");
		if( IsGCPNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GCP);
		

		// GLN
		dynStr.Append("  GLN=");
		if( IsGLNNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GLN);
		

		// ProductBrandType_ID_List
		dynStr.Append("  ProductBrandType_ID_List=");
		if( IsProductBrandType_ID_ListNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductBrandType_ID_List);
		

		// Branch_ID
		dynStr.Append("  Branch_ID=");
		if( IsBranch_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Branch_ID);
		// ProductionUnitCode
		dynStr.Append("  ProductionUnitCode=");
		if( IsProductionUnitCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductionUnitCode);
		

		// CheckProductBrand_ID
		dynStr.Append("  CheckProductBrand_ID=");
		if( IsCheckProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CheckProductBrand_ID);
		// ChainLink_ID
		dynStr.Append("  ChainLink_ID=");
		if( IsChainLink_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ChainLink_ID);
		// Story
		dynStr.Append("  Story=");
		if( IsStoryNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Story);
		

		// FunctionGroup_ID
		dynStr.Append("  FunctionGroup_ID=");
		if( IsFunctionGroup_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.FunctionGroup_ID);
		// BusinessType_ID
		dynStr.Append("  BusinessType_ID=");
		if( IsBusinessType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.BusinessType_ID);
		// ProductBrandChange_Note
		dynStr.Append("  ProductBrandChange_Note=");
		if( IsProductBrandChange_NoteNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductBrandChange_Note);
		

		// ProductBrandChange_By
		dynStr.Append("  ProductBrandChange_By=");
		if( IsProductBrandChange_ByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrandChange_By);
		// ProductBrandChange_Approved
		dynStr.Append("  ProductBrandChange_Approved=");
		if( IsProductBrandChange_ApprovedNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrandChange_Approved);
		// ProductBrandChange_Date
		dynStr.Append("  ProductBrandChange_Date=");
		if( IsProductBrandChange_DateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrandChange_Date);
		// ProductBrandChange_DateApproved
		dynStr.Append("  ProductBrandChange_DateApproved=");
		if( IsProductBrandChange_DateApprovedNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrandChange_DateApproved);
		// ProductBrandChange_Status
		dynStr.Append("  ProductBrandChange_Status=");
		if( IsProductBrandChange_StatusNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrandChange_Status);
		// ProductBrandChange_ApprovedNote
		dynStr.Append("  ProductBrandChange_ApprovedNote=");
		if( IsProductBrandChange_ApprovedNoteNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductBrandChange_ApprovedNote);
		

		// YouTube
		dynStr.Append("  YouTube=");
		if( IsYouTubeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.YouTube);
		

		return dynStr.ToString();
	}
}
}




