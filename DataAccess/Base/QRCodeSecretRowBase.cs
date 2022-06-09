
// <fileinfo name="Base\QRCodeSecretRowBase.cs">
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
/// The base class for <see cref="QRCodeSecretRow"/> that 
/// represents a record in the <c>QRCodeSecret</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="QRCodeSecretRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodeSecretRowBase
{
	/// _qRCodeSecretContent
	private string _qRCodeSecretContent;
	private bool _qRCodeSecretContentNull = true;
	/// _qRCodePublicContent
	private string _qRCodePublicContent;
	private bool _qRCodePublicContentNull = true;
	/// _sMSContent
	private string _sMSContent;
	private bool _sMSContentNull = true;
	/// _serialNumber
	private string _serialNumber;
	private bool _serialNumberNull = true;
	/// _qRCodePackage_ID
	private int _qRCodePackage_ID;
	private bool _qRCodePackage_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _soundEnable
	private bool _soundEnable;
	private bool _soundEnableNull = true;
	/// _qRCodeStatus_ID
	private int _qRCodeStatus_ID;
	private bool _qRCodeStatus_IDNull = true;
	/// _locationRegister
	private string _locationRegister;
	private bool _locationRegisterNull = true;
	/// _locationFailedWarning
	private bool _locationFailedWarning;
	private bool _locationFailedWarningNull = true;
	/// _locationFailed
	private bool _locationFailed;
	private bool _locationFailedNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _activeDate
	private System.DateTime _activeDate;
	private bool _activeDateNull = true;
	/// _warrantySerial
	private string _warrantySerial;
	private bool _warrantySerialNull = true;
	/// _warrantyMonth
	private int _warrantyMonth;
	private bool _warrantyMonthNull = true;
	/// _warrantyStartDate
	private System.DateTime _warrantyStartDate;
	private bool _warrantyStartDateNull = true;
	/// _warrantyEndDate
	private System.DateTime _warrantyEndDate;
	private bool _warrantyEndDateNull = true;
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
	/// _workshop_ID
	private int _workshop_ID;
	private bool _workshop_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="QRCodeSecretRowBase"/> class.
	/// </summary>
	public QRCodeSecretRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeSecretContent</c> column value.
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
		/// Gets or sets the <c>SMSContent</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SMSContent</c> column value.</value>
	public string SMSContent
	{
		get
		{
			if(IsSMSContentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sMSContent;
		}
		set
		{
			_sMSContentNull = false;
			_sMSContent = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SMSContent"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSMSContentNull
	{
		get
		{
			return _sMSContentNull;
		}
		set
		{
			_sMSContentNull = value;
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
		/// Gets or sets the <c>QRCodePackage_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodePackage_ID</c> column value.</value>
	public int QRCodePackage_ID
	{
		get
		{
			if (IsQRCodePackage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodePackage_ID;
		}
		set
		{
			_qRCodePackage_IDNull = false;
			_qRCodePackage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodePackage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodePackage_IDNull
	{
		get
		{
			return _qRCodePackage_IDNull;
		}
		set
		{
			_qRCodePackage_IDNull = value;
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
		/// Gets or sets the <c>SoundEnable</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SoundEnable</c> column value.</value>
	public bool SoundEnable
	{
		get
		{
			if (IsSoundEnableNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _soundEnable;
		}
		set
		{
			_soundEnableNull = false;
			_soundEnable = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SoundEnable"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSoundEnableNull
	{
		get
		{
			return _soundEnableNull;
		}
		set
		{
			_soundEnableNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeStatus_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodeStatus_ID</c> column value.</value>
	public int QRCodeStatus_ID
	{
		get
		{
			if (IsQRCodeStatus_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeStatus_ID;
		}
		set
		{
			_qRCodeStatus_IDNull = false;
			_qRCodeStatus_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeStatus_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeStatus_IDNull
	{
		get
		{
			return _qRCodeStatus_IDNull;
		}
		set
		{
			_qRCodeStatus_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LocationRegister</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LocationRegister</c> column value.</value>
	public string LocationRegister
	{
		get
		{
			if(IsLocationRegisterNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _locationRegister;
		}
		set
		{
			_locationRegisterNull = false;
			_locationRegister = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LocationRegister"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocationRegisterNull
	{
		get
		{
			return _locationRegisterNull;
		}
		set
		{
			_locationRegisterNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LocationFailedWarning</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LocationFailedWarning</c> column value.</value>
	public bool LocationFailedWarning
	{
		get
		{
			if (IsLocationFailedWarningNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _locationFailedWarning;
		}
		set
		{
			_locationFailedWarningNull = false;
			_locationFailedWarning = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LocationFailedWarning"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocationFailedWarningNull
	{
		get
		{
			return _locationFailedWarningNull;
		}
		set
		{
			_locationFailedWarningNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LocationFailed</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LocationFailed</c> column value.</value>
	public bool LocationFailed
	{
		get
		{
			if (IsLocationFailedNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _locationFailed;
		}
		set
		{
			_locationFailedNull = false;
			_locationFailed = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LocationFailed"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocationFailedNull
	{
		get
		{
			return _locationFailedNull;
		}
		set
		{
			_locationFailedNull = value;
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
		/// Gets or sets the <c>ActiveDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ActiveDate</c> column value.</value>
	public System.DateTime ActiveDate
	{
		get
		{
			if (IsActiveDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _activeDate;
		}
		set
		{
			_activeDateNull = false;
			_activeDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ActiveDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsActiveDateNull
	{
		get
		{
			return _activeDateNull;
		}
		set
		{
			_activeDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WarrantySerial</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WarrantySerial</c> column value.</value>
	public string WarrantySerial
	{
		get
		{
			if(IsWarrantySerialNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warrantySerial;
		}
		set
		{
			_warrantySerialNull = false;
			_warrantySerial = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarrantySerial"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarrantySerialNull
	{
		get
		{
			return _warrantySerialNull;
		}
		set
		{
			_warrantySerialNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WarrantyMonth</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WarrantyMonth</c> column value.</value>
	public int WarrantyMonth
	{
		get
		{
			if (IsWarrantyMonthNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warrantyMonth;
		}
		set
		{
			_warrantyMonthNull = false;
			_warrantyMonth = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarrantyMonth"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarrantyMonthNull
	{
		get
		{
			return _warrantyMonthNull;
		}
		set
		{
			_warrantyMonthNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WarrantyStartDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WarrantyStartDate</c> column value.</value>
	public System.DateTime WarrantyStartDate
	{
		get
		{
			if (IsWarrantyStartDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warrantyStartDate;
		}
		set
		{
			_warrantyStartDateNull = false;
			_warrantyStartDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarrantyStartDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarrantyStartDateNull
	{
		get
		{
			return _warrantyStartDateNull;
		}
		set
		{
			_warrantyStartDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WarrantyEndDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WarrantyEndDate</c> column value.</value>
	public System.DateTime WarrantyEndDate
	{
		get
		{
			if (IsWarrantyEndDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warrantyEndDate;
		}
		set
		{
			_warrantyEndDateNull = false;
			_warrantyEndDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarrantyEndDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarrantyEndDateNull
	{
		get
		{
			return _warrantyEndDateNull;
		}
		set
		{
			_warrantyEndDateNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
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
		

		// SMSContent
		dynStr.Append("  SMSContent=");
		if( IsSMSContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SMSContent);
		

		// SerialNumber
		dynStr.Append("  SerialNumber=");
		if( IsSerialNumberNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SerialNumber);
		

		// QRCodePackage_ID
		dynStr.Append("  QRCodePackage_ID=");
		if( IsQRCodePackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodePackage_ID);
		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID);
		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// SoundEnable
		dynStr.Append("  SoundEnable=");
		if( IsSoundEnableNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.SoundEnable);
		// QRCodeStatus_ID
		dynStr.Append("  QRCodeStatus_ID=");
		if( IsQRCodeStatus_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodeStatus_ID);
		// LocationRegister
		dynStr.Append("  LocationRegister=");
		if( IsLocationRegisterNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.LocationRegister);
		

		// LocationFailedWarning
		dynStr.Append("  LocationFailedWarning=");
		if( IsLocationFailedWarningNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LocationFailedWarning);
		// LocationFailed
		dynStr.Append("  LocationFailed=");
		if( IsLocationFailedNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LocationFailed);
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
		// ActiveDate
		dynStr.Append("  ActiveDate=");
		if( IsActiveDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ActiveDate);
		// WarrantySerial
		dynStr.Append("  WarrantySerial=");
		if( IsWarrantySerialNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WarrantySerial);
		

		// WarrantyMonth
		dynStr.Append("  WarrantyMonth=");
		if( IsWarrantyMonthNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WarrantyMonth);
		// WarrantyStartDate
		dynStr.Append("  WarrantyStartDate=");
		if( IsWarrantyStartDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WarrantyStartDate);
		// WarrantyEndDate
		dynStr.Append("  WarrantyEndDate=");
		if( IsWarrantyEndDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WarrantyEndDate);
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
		

		// Workshop_ID
		dynStr.Append("  Workshop_ID=");
		if( IsWorkshop_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Workshop_ID);
		return dynStr.ToString();
	}
}
}




