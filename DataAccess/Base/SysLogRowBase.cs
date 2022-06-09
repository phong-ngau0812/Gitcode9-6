
// <fileinfo name="Base\SysLogRowBase.cs">
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
/// The base class for <see cref="SysLogRow"/> that 
/// represents a record in the <c>SysLog</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="SysLogRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SysLogRowBase
{
	/// _sysLog_ID
	private System.Guid _sysLog_ID;
	private bool _sysLog_IDNull = true;
	/// _sysLogType_ID
	private int _sysLogType_ID;
	private bool _sysLogType_IDNull = true;
	/// _content
	private string _content;
	private bool _contentNull = true;
	/// _qRCodeSecretContent
	private string _qRCodeSecretContent;
	private bool _qRCodeSecretContentNull = true;
	/// _qRCodePublicContent
	private string _qRCodePublicContent;
	private bool _qRCodePublicContentNull = true;
	/// _serialNumber
	private string _serialNumber;
	private bool _serialNumberNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _location_ID
	private int _location_ID;
	private bool _location_IDNull = true;
	/// _departmentMan_ID
	private int _departmentMan_ID;
	private bool _departmentMan_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _productName
	private string _productName;
	private bool _productNameNull = true;
	/// _productBrandName
	private string _productBrandName;
	private bool _productBrandNameNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _usedDate
	private System.DateTime _usedDate;
	private bool _usedDateNull = true;
	/// _usedApplication
	private string _usedApplication;
	private bool _usedApplicationNull = true;
	/// _usedLocation
	private string _usedLocation;
	private bool _usedLocationNull = true;
	/// _usedName
	private string _usedName;
	private bool _usedNameNull = true;
	/// _usedAddress
	private string _usedAddress;
	private bool _usedAddressNull = true;
	/// _usedPhone
	private string _usedPhone;
	private bool _usedPhoneNull = true;
	/// _usedIdentityCard
	private string _usedIdentityCard;
	private bool _usedIdentityCardNull = true;
	/// _storeName
	private string _storeName;
	private bool _storeNameNull = true;
	/// _storeAddress
	private string _storeAddress;
	private bool _storeAddressNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="SysLogRowBase"/> class.
	/// </summary>
	public SysLogRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>SysLog_ID</c> column value.
		/// </summary>
		/// <value>The <c>SysLog_ID</c> column value.</value>
	public System.Guid SysLog_ID
	{
		get
		{
			if(IsSysLog_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sysLog_ID;
		}
		set
		{
			_sysLog_IDNull = false;
			_sysLog_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SysLog_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSysLog_IDNull
	{
		get
		{
			return _sysLog_IDNull;
		}
		set
		{
			_sysLog_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SysLogType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SysLogType_ID</c> column value.</value>
	public int SysLogType_ID
	{
		get
		{
			if (IsSysLogType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sysLogType_ID;
		}
		set
		{
			_sysLogType_IDNull = false;
			_sysLogType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SysLogType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSysLogType_IDNull
	{
		get
		{
			return _sysLogType_IDNull;
		}
		set
		{
			_sysLogType_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Content</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Content</c> column value.</value>
	public string Content
	{
		get
		{
			if(IsContentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _content;
		}
		set
		{
			_contentNull = false;
			_content = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Content"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsContentNull
	{
		get
		{
			return _contentNull;
		}
		set
		{
			_contentNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeSecretContent</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodeSecretContent</c> column value.</value>
	public string QRCodeSecretContent
	{
		get
		{
			if(IsQRCodeSecretContentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeSecretContent;
		}
		set
		{
			_qRCodeSecretContentNull = false;
			_qRCodeSecretContent = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeSecretContent"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeSecretContentNull
	{
		get
		{
			return _qRCodeSecretContentNull;
		}
		set
		{
			_qRCodeSecretContentNull = value;
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
		/// Gets or sets the <c>SerialNumber</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SerialNumber</c> column value.</value>
	public string SerialNumber
	{
		get
		{
			if(IsSerialNumberNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _serialNumber;
		}
		set
		{
			_serialNumberNull = false;
			_serialNumber = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SerialNumber"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSerialNumberNull
	{
		get
		{
			return _serialNumberNull;
		}
		set
		{
			_serialNumberNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Product_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Product_ID</c> column value.</value>
	public int Product_ID
	{
		get
		{
			if (IsProduct_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _product_ID;
		}
		set
		{
			_product_IDNull = false;
			_product_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Product_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProduct_IDNull
	{
		get
		{
			return _product_IDNull;
		}
		set
		{
			_product_IDNull = value;
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
		/// Gets or sets the <c>ProductName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductName</c> column value.</value>
	public string ProductName
	{
		get
		{
			if(IsProductNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productName;
		}
		set
		{
			_productNameNull = false;
			_productName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductNameNull
	{
		get
		{
			return _productNameNull;
		}
		set
		{
			_productNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrandName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrandName</c> column value.</value>
	public string ProductBrandName
	{
		get
		{
			if(IsProductBrandNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrandName;
		}
		set
		{
			_productBrandNameNull = false;
			_productBrandName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrandName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrandNameNull
	{
		get
		{
			return _productBrandNameNull;
		}
		set
		{
			_productBrandNameNull = value;
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
		/// Gets or sets the <c>UsedDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UsedDate</c> column value.</value>
	public System.DateTime UsedDate
	{
		get
		{
			if (IsUsedDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _usedDate;
		}
		set
		{
			_usedDateNull = false;
			_usedDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UsedDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUsedDateNull
	{
		get
		{
			return _usedDateNull;
		}
		set
		{
			_usedDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UsedApplication</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UsedApplication</c> column value.</value>
	public string UsedApplication
	{
		get
		{
			if(IsUsedApplicationNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _usedApplication;
		}
		set
		{
			_usedApplicationNull = false;
			_usedApplication = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UsedApplication"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUsedApplicationNull
	{
		get
		{
			return _usedApplicationNull;
		}
		set
		{
			_usedApplicationNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UsedLocation</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UsedLocation</c> column value.</value>
	public string UsedLocation
	{
		get
		{
			if(IsUsedLocationNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _usedLocation;
		}
		set
		{
			_usedLocationNull = false;
			_usedLocation = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UsedLocation"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUsedLocationNull
	{
		get
		{
			return _usedLocationNull;
		}
		set
		{
			_usedLocationNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UsedName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UsedName</c> column value.</value>
	public string UsedName
	{
		get
		{
			if(IsUsedNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _usedName;
		}
		set
		{
			_usedNameNull = false;
			_usedName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UsedName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUsedNameNull
	{
		get
		{
			return _usedNameNull;
		}
		set
		{
			_usedNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UsedAddress</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UsedAddress</c> column value.</value>
	public string UsedAddress
	{
		get
		{
			if(IsUsedAddressNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _usedAddress;
		}
		set
		{
			_usedAddressNull = false;
			_usedAddress = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UsedAddress"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUsedAddressNull
	{
		get
		{
			return _usedAddressNull;
		}
		set
		{
			_usedAddressNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UsedPhone</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UsedPhone</c> column value.</value>
	public string UsedPhone
	{
		get
		{
			if(IsUsedPhoneNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _usedPhone;
		}
		set
		{
			_usedPhoneNull = false;
			_usedPhone = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UsedPhone"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUsedPhoneNull
	{
		get
		{
			return _usedPhoneNull;
		}
		set
		{
			_usedPhoneNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UsedIdentityCard</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UsedIdentityCard</c> column value.</value>
	public string UsedIdentityCard
	{
		get
		{
			if(IsUsedIdentityCardNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _usedIdentityCard;
		}
		set
		{
			_usedIdentityCardNull = false;
			_usedIdentityCard = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UsedIdentityCard"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUsedIdentityCardNull
	{
		get
		{
			return _usedIdentityCardNull;
		}
		set
		{
			_usedIdentityCardNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StoreName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StoreName</c> column value.</value>
	public string StoreName
	{
		get
		{
			if(IsStoreNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _storeName;
		}
		set
		{
			_storeNameNull = false;
			_storeName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StoreName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStoreNameNull
	{
		get
		{
			return _storeNameNull;
		}
		set
		{
			_storeNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StoreAddress</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StoreAddress</c> column value.</value>
	public string StoreAddress
	{
		get
		{
			if(IsStoreAddressNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _storeAddress;
		}
		set
		{
			_storeAddressNull = false;
			_storeAddress = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StoreAddress"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStoreAddressNull
	{
		get
		{
			return _storeAddressNull;
		}
		set
		{
			_storeAddressNull = value;
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
		// SysLog_ID
		dynStr.Append("  SysLog_ID=");
		if( IsSysLog_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SysLog_ID);
		

		// SysLogType_ID
		dynStr.Append("  SysLogType_ID=");
		if( IsSysLogType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.SysLogType_ID);
		// Content
		dynStr.Append("  Content=");
		if( IsContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Content);
		

		// QRCodeSecretContent
		dynStr.Append("  QRCodeSecretContent=");
		if( IsQRCodeSecretContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodeSecretContent);
		

		// QRCodePublicContent
		dynStr.Append("  QRCodePublicContent=");
		if( IsQRCodePublicContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodePublicContent);
		

		// SerialNumber
		dynStr.Append("  SerialNumber=");
		if( IsSerialNumberNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SerialNumber);
		

		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID);
		// Location_ID
		dynStr.Append("  Location_ID=");
		if( IsLocation_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Location_ID);
		// DepartmentMan_ID
		dynStr.Append("  DepartmentMan_ID=");
		if( IsDepartmentMan_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.DepartmentMan_ID);
		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// ProductName
		dynStr.Append("  ProductName=");
		if( IsProductNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductName);
		

		// ProductBrandName
		dynStr.Append("  ProductBrandName=");
		if( IsProductBrandNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductBrandName);
		

		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		// CreateBy
		dynStr.Append("  CreateBy=");
		if( IsCreateByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateBy);
		// UsedDate
		dynStr.Append("  UsedDate=");
		if( IsUsedDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.UsedDate);
		// UsedApplication
		dynStr.Append("  UsedApplication=");
		if( IsUsedApplicationNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UsedApplication);
		

		// UsedLocation
		dynStr.Append("  UsedLocation=");
		if( IsUsedLocationNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UsedLocation);
		

		// UsedName
		dynStr.Append("  UsedName=");
		if( IsUsedNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UsedName);
		

		// UsedAddress
		dynStr.Append("  UsedAddress=");
		if( IsUsedAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UsedAddress);
		

		// UsedPhone
		dynStr.Append("  UsedPhone=");
		if( IsUsedPhoneNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UsedPhone);
		

		// UsedIdentityCard
		dynStr.Append("  UsedIdentityCard=");
		if( IsUsedIdentityCardNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UsedIdentityCard);
		

		// StoreName
		dynStr.Append("  StoreName=");
		if( IsStoreNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.StoreName);
		

		// StoreAddress
		dynStr.Append("  StoreAddress=");
		if( IsStoreAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.StoreAddress);
		

		return dynStr.ToString();
	}
}
}




