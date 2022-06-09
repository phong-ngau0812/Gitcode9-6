
// <fileinfo name="Base\QRCodePackageRowBase.cs">
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
/// The base class for <see cref="QRCodePackageRow"/> that 
/// represents a record in the <c>QRCodePackage</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="QRCodePackageRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodePackageRowBase
{
	/// _qRCodePackage_ID
	private int _qRCodePackage_ID;
	private bool _qRCodePackage_IDNull = true;
	/// _qRCodePackageType_ID
	private int _qRCodePackageType_ID;
	private bool _qRCodePackageType_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _store_ID
	private int _store_ID;
	private bool _store_IDNull = true;
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;
	/// _factory_ID
	private int _factory_ID;
	private bool _factory_IDNull = true;
	/// _supplier_ID
	private int _supplier_ID;
	private bool _supplier_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _productName
	private string _productName;
	private bool _productNameNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _profileQRCode
	private string _profileQRCode;
	private bool _profileQRCodeNull = true;
	/// _soundEnable
	private bool _soundEnable;
	private bool _soundEnableNull = true;
	/// _sms
	private bool _sms;
	private bool _smsNull = true;
	/// _prefix
	private string _prefix;
	private bool _prefixNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
	/// _qRCodeStatus_ID
	private int _qRCodeStatus_ID;
	private bool _qRCodeStatus_IDNull = true;
	/// _viewCount
	private int _viewCount;
	private bool _viewCountNull = true;
	/// _sellCount
	private int _sellCount;
	private bool _sellCountNull = true;
	/// _qRCodeNumber
	private int _qRCodeNumber;
	private bool _qRCodeNumberNull = true;
	/// _qRCodeUsed
	private int _qRCodeUsed;
	private bool _qRCodeUsedNull = true;
	/// _qRCodeAvailable
	private int _qRCodeAvailable;
	private bool _qRCodeAvailableNull = true;
	/// _serialNumberStart
	private string _serialNumberStart;
	private bool _serialNumberStartNull = true;
	/// _serialNumberEnd
	private string _serialNumberEnd;
	private bool _serialNumberEndNull = true;
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
	/// _agencyAssign
	private System.Guid _agencyAssign;
	private bool _agencyAssignNull = true;
	/// _manufactureDate
	private System.DateTime _manufactureDate;
	private bool _manufactureDateNull = true;
	/// _expiryDate
	private System.DateTime _expiryDate;
	private bool _expiryDateNull = true;
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
	/// _usedName
	private string _usedName;
	private bool _usedNameNull = true;
	/// _usedAddress
	private string _usedAddress;
	private bool _usedAddressNull = true;
	/// _usedPhone
	private string _usedPhone;
	private bool _usedPhoneNull = true;
	/// _activeDate
	private System.DateTime _activeDate;
	private bool _activeDateNull = true;
	/// _pendingActive
	private bool _pendingActive;
	private bool _pendingActiveNull = true;
	/// _pendingActiveDate
	private System.DateTime _pendingActiveDate;
	private bool _pendingActiveDateNull = true;
	/// _produceInfoStaff
	private string _produceInfoStaff;
	private bool _produceInfoStaffNull = true;
	/// _produceInfo
	private string _produceInfo;
	private bool _produceInfoNull = true;
	/// _produceInfoDisplay
	private bool _produceInfoDisplay;
	private bool _produceInfoDisplayNull = true;
	/// _produceInfoEditDate
	private System.DateTime _produceInfoEditDate;
	private bool _produceInfoEditDateNull = true;
	/// _qualityInfo
	private string _qualityInfo;
	private bool _qualityInfoNull = true;
	/// _qualityInfoDisplay
	private bool _qualityInfoDisplay;
	private bool _qualityInfoDisplayNull = true;
	/// _qualityInfoEditDate
	private System.DateTime _qualityInfoEditDate;
	private bool _qualityInfoEditDateNull = true;
	/// _deliveryInfo
	private string _deliveryInfo;
	private bool _deliveryInfoNull = true;
	/// _deliveryInfoEditDate
	private System.DateTime _deliveryInfoEditDate;
	private bool _deliveryInfoEditDateNull = true;
	/// _storeInfo
	private string _storeInfo;
	private bool _storeInfoNull = true;
	/// _storeInfoDisplay
	private bool _storeInfoDisplay;
	private bool _storeInfoDisplayNull = true;
	/// _storeInfoEditDate
	private System.DateTime _storeInfoEditDate;
	private bool _storeInfoEditDateNull = true;
	/// _warehouse_ID
	private int _warehouse_ID;
	private bool _warehouse_IDNull = true;
	/// _customerInfo
	private string _customerInfo;
	private bool _customerInfoNull = true;
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
	/// _stampDate
	private System.DateTime _stampDate;
	private bool _stampDateNull = true;
	/// _shippingDate
	private System.DateTime _shippingDate;
	private bool _shippingDateNull = true;
	/// _shippingNote
	private string _shippingNote;
	private bool _shippingNoteNull = true;
	/// _productName_En
	private string _productName_En;
	private bool _productName_EnNull = true;
	/// _description_En
	private string _description_En;
	private bool _description_EnNull = true;
	/// _profileQRCode_En
	private string _profileQRCode_En;
	private bool _profileQRCode_EnNull = true;
	/// _produceInfo_En
	private string _produceInfo_En;
	private bool _produceInfo_EnNull = true;
	/// _qualityInfo_En
	private string _qualityInfo_En;
	private bool _qualityInfo_EnNull = true;
	/// _deliveryInfo_En
	private string _deliveryInfo_En;
	private bool _deliveryInfo_EnNull = true;
	/// _storeInfo_En
	private string _storeInfo_En;
	private bool _storeInfo_EnNull = true;
	/// _customerInfo_En
	private string _customerInfo_En;
	private bool _customerInfo_EnNull = true;
	/// _shippingNote_En
	private string _shippingNote_En;
	private bool _shippingNote_EnNull = true;
	/// _productName_Cn
	private string _productName_Cn;
	private bool _productName_CnNull = true;
	/// _description_Cn
	private string _description_Cn;
	private bool _description_CnNull = true;
	/// _profileQRCode_Cn
	private string _profileQRCode_Cn;
	private bool _profileQRCode_CnNull = true;
	/// _produceInfo_Cn
	private string _produceInfo_Cn;
	private bool _produceInfo_CnNull = true;
	/// _qualityInfo_Cn
	private string _qualityInfo_Cn;
	private bool _qualityInfo_CnNull = true;
	/// _deliveryInfo_Cn
	private string _deliveryInfo_Cn;
	private bool _deliveryInfo_CnNull = true;
	/// _storeInfo_Cn
	private string _storeInfo_Cn;
	private bool _storeInfo_CnNull = true;
	/// _customerInfo_Cn
	private string _customerInfo_Cn;
	private bool _customerInfo_CnNull = true;
	/// _shippingNote_Cn
	private string _shippingNote_Cn;
	private bool _shippingNote_CnNull = true;
	/// _amount
	private long _amount;
	private bool _amountNull = true;
	/// _amountUnit
	private string _amountUnit;
	private bool _amountUnitNull = true;
	/// _amountSum
	private long _amountSum;
	private bool _amountSumNull = true;
	/// _harvestDate
	private System.DateTime _harvestDate;
	private bool _harvestDateNull = true;
	/// _expiryByDate
	private int _expiryByDate;
	private bool _expiryByDateNull = true;
	/// _farmCreateBy
	private System.Guid _farmCreateBy;
	private bool _farmCreateByNull = true;
	/// _farmWorkshop_ID
	private int _farmWorkshop_ID;
	private bool _farmWorkshop_IDNull = true;
	/// _farmWorkshopName
	private string _farmWorkshopName;
	private bool _farmWorkshopNameNull = true;
	/// _farmProducerName
	private string _farmProducerName;
	private bool _farmProducerNameNull = true;
	/// _farmGroupInter_ID
	private int _farmGroupInter_ID;
	private bool _farmGroupInter_IDNull = true;
	/// _farmGroupInterName
	private string _farmGroupInterName;
	private bool _farmGroupInterNameNull = true;
	/// _farmGroup_ID
	private int _farmGroup_ID;
	private bool _farmGroup_IDNull = true;
	/// _farmGroupName
	private string _farmGroupName;
	private bool _farmGroupNameNull = true;
	/// _wEB_UserID_Create
	private int _wEB_UserID_Create;
	private bool _wEB_UserID_CreateNull = true;
	/// _wEB_UserID_Edit
	private int _wEB_UserID_Edit;
	private bool _wEB_UserID_EditNull = true;
	/// _ngaySX
	private System.DateTime _ngaySX;
	private bool _ngaySXNull = true;
	/// _nguoiDan
	private string _nguoiDan;
	private bool _nguoiDanNull = true;
	/// _phanXuongSX
	private string _phanXuongSX;
	private bool _phanXuongSXNull = true;
	/// _department_ID
	private int _department_ID;
	private bool _department_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="QRCodePackageRowBase"/> class.
	/// </summary>
	public QRCodePackageRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>QRCodePackage_ID</c> column value.
		/// </summary>
		/// <value>The <c>QRCodePackage_ID</c> column value.</value>
	public int QRCodePackage_ID
	{
		get
		{
			if(IsQRCodePackage_IDNull)
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
		/// Gets or sets the <c>QRCodePackageType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodePackageType_ID</c> column value.</value>
	public int QRCodePackageType_ID
	{
		get
		{
			if (IsQRCodePackageType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodePackageType_ID;
		}
		set
		{
			_qRCodePackageType_IDNull = false;
			_qRCodePackageType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodePackageType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodePackageType_IDNull
	{
		get
		{
			return _qRCodePackageType_IDNull;
		}
		set
		{
			_qRCodePackageType_IDNull = value;
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
		/// Gets or sets the <c>Store_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Store_ID</c> column value.</value>
	public int Store_ID
	{
		get
		{
			if (IsStore_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _store_ID;
		}
		set
		{
			_store_IDNull = false;
			_store_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Store_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStore_IDNull
	{
		get
		{
			return _store_IDNull;
		}
		set
		{
			_store_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackage_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackage_ID</c> column value.</value>
	public int ProductPackage_ID
	{
		get
		{
			if (IsProductPackage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackage_ID;
		}
		set
		{
			_productPackage_IDNull = false;
			_productPackage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackage_IDNull
	{
		get
		{
			return _productPackage_IDNull;
		}
		set
		{
			_productPackage_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Factory_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Factory_ID</c> column value.</value>
	public int Factory_ID
	{
		get
		{
			if (IsFactory_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _factory_ID;
		}
		set
		{
			_factory_IDNull = false;
			_factory_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Factory_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFactory_IDNull
	{
		get
		{
			return _factory_IDNull;
		}
		set
		{
			_factory_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Supplier_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Supplier_ID</c> column value.</value>
	public int Supplier_ID
	{
		get
		{
			if (IsSupplier_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _supplier_ID;
		}
		set
		{
			_supplier_IDNull = false;
			_supplier_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Supplier_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSupplier_IDNull
	{
		get
		{
			return _supplier_IDNull;
		}
		set
		{
			_supplier_IDNull = value;
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
		/// Gets or sets the <c>ProfileQRCode</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProfileQRCode</c> column value.</value>
	public string ProfileQRCode
	{
		get
		{
			if(IsProfileQRCodeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _profileQRCode;
		}
		set
		{
			_profileQRCodeNull = false;
			_profileQRCode = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProfileQRCode"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProfileQRCodeNull
	{
		get
		{
			return _profileQRCodeNull;
		}
		set
		{
			_profileQRCodeNull = value;
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
		/// Gets or sets the <c>SMS</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SMS</c> column value.</value>
	public bool SMS
	{
		get
		{
			if (IsSMSNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sms;
		}
		set
		{
			_smsNull = false;
			_sms = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SMS"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSMSNull
	{
		get
		{
			return _smsNull;
		}
		set
		{
			_smsNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Prefix</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Prefix</c> column value.</value>
	public string Prefix
	{
		get
		{
			if(IsPrefixNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _prefix;
		}
		set
		{
			_prefixNull = false;
			_prefix = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Prefix"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPrefixNull
	{
		get
		{
			return _prefixNull;
		}
		set
		{
			_prefixNull = value;
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
		/// Gets or sets the <c>QRCodeNumber</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodeNumber</c> column value.</value>
	public int QRCodeNumber
	{
		get
		{
			if (IsQRCodeNumberNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeNumber;
		}
		set
		{
			_qRCodeNumberNull = false;
			_qRCodeNumber = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeNumber"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeNumberNull
	{
		get
		{
			return _qRCodeNumberNull;
		}
		set
		{
			_qRCodeNumberNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeUsed</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodeUsed</c> column value.</value>
	public int QRCodeUsed
	{
		get
		{
			if (IsQRCodeUsedNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeUsed;
		}
		set
		{
			_qRCodeUsedNull = false;
			_qRCodeUsed = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeUsed"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeUsedNull
	{
		get
		{
			return _qRCodeUsedNull;
		}
		set
		{
			_qRCodeUsedNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeAvailable</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodeAvailable</c> column value.</value>
	public int QRCodeAvailable
	{
		get
		{
			if (IsQRCodeAvailableNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeAvailable;
		}
		set
		{
			_qRCodeAvailableNull = false;
			_qRCodeAvailable = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeAvailable"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeAvailableNull
	{
		get
		{
			return _qRCodeAvailableNull;
		}
		set
		{
			_qRCodeAvailableNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SerialNumberStart</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SerialNumberStart</c> column value.</value>
	public string SerialNumberStart
	{
		get
		{
			if(IsSerialNumberStartNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _serialNumberStart;
		}
		set
		{
			_serialNumberStartNull = false;
			_serialNumberStart = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SerialNumberStart"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSerialNumberStartNull
	{
		get
		{
			return _serialNumberStartNull;
		}
		set
		{
			_serialNumberStartNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SerialNumberEnd</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SerialNumberEnd</c> column value.</value>
	public string SerialNumberEnd
	{
		get
		{
			if(IsSerialNumberEndNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _serialNumberEnd;
		}
		set
		{
			_serialNumberEndNull = false;
			_serialNumberEnd = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SerialNumberEnd"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSerialNumberEndNull
	{
		get
		{
			return _serialNumberEndNull;
		}
		set
		{
			_serialNumberEndNull = value;
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
		/// Gets or sets the <c>AgencyAssign</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AgencyAssign</c> column value.</value>
	public System.Guid AgencyAssign
	{
		get
		{
			if (IsAgencyAssignNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _agencyAssign;
		}
		set
		{
			_agencyAssignNull = false;
			_agencyAssign = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AgencyAssign"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAgencyAssignNull
	{
		get
		{
			return _agencyAssignNull;
		}
		set
		{
			_agencyAssignNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ManufactureDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ManufactureDate</c> column value.</value>
	public System.DateTime ManufactureDate
	{
		get
		{
			if (IsManufactureDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _manufactureDate;
		}
		set
		{
			_manufactureDateNull = false;
			_manufactureDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ManufactureDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsManufactureDateNull
	{
		get
		{
			return _manufactureDateNull;
		}
		set
		{
			_manufactureDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ExpiryDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ExpiryDate</c> column value.</value>
	public System.DateTime ExpiryDate
	{
		get
		{
			if (IsExpiryDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _expiryDate;
		}
		set
		{
			_expiryDateNull = false;
			_expiryDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ExpiryDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsExpiryDateNull
	{
		get
		{
			return _expiryDateNull;
		}
		set
		{
			_expiryDateNull = value;
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
		/// Gets or sets the <c>PendingActive</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PendingActive</c> column value.</value>
	public bool PendingActive
	{
		get
		{
			if (IsPendingActiveNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _pendingActive;
		}
		set
		{
			_pendingActiveNull = false;
			_pendingActive = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PendingActive"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPendingActiveNull
	{
		get
		{
			return _pendingActiveNull;
		}
		set
		{
			_pendingActiveNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>PendingActiveDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PendingActiveDate</c> column value.</value>
	public System.DateTime PendingActiveDate
	{
		get
		{
			if (IsPendingActiveDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _pendingActiveDate;
		}
		set
		{
			_pendingActiveDateNull = false;
			_pendingActiveDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PendingActiveDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPendingActiveDateNull
	{
		get
		{
			return _pendingActiveDateNull;
		}
		set
		{
			_pendingActiveDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProduceInfoStaff</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProduceInfoStaff</c> column value.</value>
	public string ProduceInfoStaff
	{
		get
		{
			if(IsProduceInfoStaffNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _produceInfoStaff;
		}
		set
		{
			_produceInfoStaffNull = false;
			_produceInfoStaff = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProduceInfoStaff"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProduceInfoStaffNull
	{
		get
		{
			return _produceInfoStaffNull;
		}
		set
		{
			_produceInfoStaffNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProduceInfo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProduceInfo</c> column value.</value>
	public string ProduceInfo
	{
		get
		{
			if(IsProduceInfoNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _produceInfo;
		}
		set
		{
			_produceInfoNull = false;
			_produceInfo = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProduceInfo"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProduceInfoNull
	{
		get
		{
			return _produceInfoNull;
		}
		set
		{
			_produceInfoNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProduceInfoDisplay</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProduceInfoDisplay</c> column value.</value>
	public bool ProduceInfoDisplay
	{
		get
		{
			if (IsProduceInfoDisplayNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _produceInfoDisplay;
		}
		set
		{
			_produceInfoDisplayNull = false;
			_produceInfoDisplay = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProduceInfoDisplay"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProduceInfoDisplayNull
	{
		get
		{
			return _produceInfoDisplayNull;
		}
		set
		{
			_produceInfoDisplayNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProduceInfoEditDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProduceInfoEditDate</c> column value.</value>
	public System.DateTime ProduceInfoEditDate
	{
		get
		{
			if (IsProduceInfoEditDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _produceInfoEditDate;
		}
		set
		{
			_produceInfoEditDateNull = false;
			_produceInfoEditDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProduceInfoEditDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProduceInfoEditDateNull
	{
		get
		{
			return _produceInfoEditDateNull;
		}
		set
		{
			_produceInfoEditDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QualityInfo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QualityInfo</c> column value.</value>
	public string QualityInfo
	{
		get
		{
			if(IsQualityInfoNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qualityInfo;
		}
		set
		{
			_qualityInfoNull = false;
			_qualityInfo = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QualityInfo"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQualityInfoNull
	{
		get
		{
			return _qualityInfoNull;
		}
		set
		{
			_qualityInfoNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QualityInfoDisplay</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QualityInfoDisplay</c> column value.</value>
	public bool QualityInfoDisplay
	{
		get
		{
			if (IsQualityInfoDisplayNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qualityInfoDisplay;
		}
		set
		{
			_qualityInfoDisplayNull = false;
			_qualityInfoDisplay = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QualityInfoDisplay"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQualityInfoDisplayNull
	{
		get
		{
			return _qualityInfoDisplayNull;
		}
		set
		{
			_qualityInfoDisplayNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QualityInfoEditDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QualityInfoEditDate</c> column value.</value>
	public System.DateTime QualityInfoEditDate
	{
		get
		{
			if (IsQualityInfoEditDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qualityInfoEditDate;
		}
		set
		{
			_qualityInfoEditDateNull = false;
			_qualityInfoEditDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QualityInfoEditDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQualityInfoEditDateNull
	{
		get
		{
			return _qualityInfoEditDateNull;
		}
		set
		{
			_qualityInfoEditDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DeliveryInfo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DeliveryInfo</c> column value.</value>
	public string DeliveryInfo
	{
		get
		{
			if(IsDeliveryInfoNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _deliveryInfo;
		}
		set
		{
			_deliveryInfoNull = false;
			_deliveryInfo = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DeliveryInfo"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDeliveryInfoNull
	{
		get
		{
			return _deliveryInfoNull;
		}
		set
		{
			_deliveryInfoNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DeliveryInfoEditDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DeliveryInfoEditDate</c> column value.</value>
	public System.DateTime DeliveryInfoEditDate
	{
		get
		{
			if (IsDeliveryInfoEditDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _deliveryInfoEditDate;
		}
		set
		{
			_deliveryInfoEditDateNull = false;
			_deliveryInfoEditDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DeliveryInfoEditDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDeliveryInfoEditDateNull
	{
		get
		{
			return _deliveryInfoEditDateNull;
		}
		set
		{
			_deliveryInfoEditDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StoreInfo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StoreInfo</c> column value.</value>
	public string StoreInfo
	{
		get
		{
			if(IsStoreInfoNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _storeInfo;
		}
		set
		{
			_storeInfoNull = false;
			_storeInfo = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StoreInfo"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStoreInfoNull
	{
		get
		{
			return _storeInfoNull;
		}
		set
		{
			_storeInfoNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StoreInfoDisplay</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StoreInfoDisplay</c> column value.</value>
	public bool StoreInfoDisplay
	{
		get
		{
			if (IsStoreInfoDisplayNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _storeInfoDisplay;
		}
		set
		{
			_storeInfoDisplayNull = false;
			_storeInfoDisplay = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StoreInfoDisplay"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStoreInfoDisplayNull
	{
		get
		{
			return _storeInfoDisplayNull;
		}
		set
		{
			_storeInfoDisplayNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StoreInfoEditDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StoreInfoEditDate</c> column value.</value>
	public System.DateTime StoreInfoEditDate
	{
		get
		{
			if (IsStoreInfoEditDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _storeInfoEditDate;
		}
		set
		{
			_storeInfoEditDateNull = false;
			_storeInfoEditDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StoreInfoEditDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStoreInfoEditDateNull
	{
		get
		{
			return _storeInfoEditDateNull;
		}
		set
		{
			_storeInfoEditDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Warehouse_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Warehouse_ID</c> column value.</value>
	public int Warehouse_ID
	{
		get
		{
			if (IsWarehouse_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warehouse_ID;
		}
		set
		{
			_warehouse_IDNull = false;
			_warehouse_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Warehouse_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarehouse_IDNull
	{
		get
		{
			return _warehouse_IDNull;
		}
		set
		{
			_warehouse_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CustomerInfo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CustomerInfo</c> column value.</value>
	public string CustomerInfo
	{
		get
		{
			if(IsCustomerInfoNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _customerInfo;
		}
		set
		{
			_customerInfoNull = false;
			_customerInfo = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CustomerInfo"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCustomerInfoNull
	{
		get
		{
			return _customerInfoNull;
		}
		set
		{
			_customerInfoNull = value;
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
		/// Gets or sets the <c>StampDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StampDate</c> column value.</value>
	public System.DateTime StampDate
	{
		get
		{
			if (IsStampDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _stampDate;
		}
		set
		{
			_stampDateNull = false;
			_stampDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StampDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStampDateNull
	{
		get
		{
			return _stampDateNull;
		}
		set
		{
			_stampDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ShippingDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ShippingDate</c> column value.</value>
	public System.DateTime ShippingDate
	{
		get
		{
			if (IsShippingDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _shippingDate;
		}
		set
		{
			_shippingDateNull = false;
			_shippingDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ShippingDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsShippingDateNull
	{
		get
		{
			return _shippingDateNull;
		}
		set
		{
			_shippingDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ShippingNote</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ShippingNote</c> column value.</value>
	public string ShippingNote
	{
		get
		{
			if(IsShippingNoteNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _shippingNote;
		}
		set
		{
			_shippingNoteNull = false;
			_shippingNote = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ShippingNote"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsShippingNoteNull
	{
		get
		{
			return _shippingNoteNull;
		}
		set
		{
			_shippingNoteNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductName_En</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductName_En</c> column value.</value>
	public string ProductName_En
	{
		get
		{
			if(IsProductName_EnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productName_En;
		}
		set
		{
			_productName_EnNull = false;
			_productName_En = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductName_En"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductName_EnNull
	{
		get
		{
			return _productName_EnNull;
		}
		set
		{
			_productName_EnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Description_En</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Description_En</c> column value.</value>
	public string Description_En
	{
		get
		{
			if(IsDescription_EnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _description_En;
		}
		set
		{
			_description_EnNull = false;
			_description_En = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Description_En"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDescription_EnNull
	{
		get
		{
			return _description_EnNull;
		}
		set
		{
			_description_EnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProfileQRCode_En</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProfileQRCode_En</c> column value.</value>
	public string ProfileQRCode_En
	{
		get
		{
			if(IsProfileQRCode_EnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _profileQRCode_En;
		}
		set
		{
			_profileQRCode_EnNull = false;
			_profileQRCode_En = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProfileQRCode_En"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProfileQRCode_EnNull
	{
		get
		{
			return _profileQRCode_EnNull;
		}
		set
		{
			_profileQRCode_EnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProduceInfo_En</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProduceInfo_En</c> column value.</value>
	public string ProduceInfo_En
	{
		get
		{
			if(IsProduceInfo_EnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _produceInfo_En;
		}
		set
		{
			_produceInfo_EnNull = false;
			_produceInfo_En = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProduceInfo_En"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProduceInfo_EnNull
	{
		get
		{
			return _produceInfo_EnNull;
		}
		set
		{
			_produceInfo_EnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QualityInfo_En</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QualityInfo_En</c> column value.</value>
	public string QualityInfo_En
	{
		get
		{
			if(IsQualityInfo_EnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qualityInfo_En;
		}
		set
		{
			_qualityInfo_EnNull = false;
			_qualityInfo_En = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QualityInfo_En"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQualityInfo_EnNull
	{
		get
		{
			return _qualityInfo_EnNull;
		}
		set
		{
			_qualityInfo_EnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DeliveryInfo_En</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DeliveryInfo_En</c> column value.</value>
	public string DeliveryInfo_En
	{
		get
		{
			if(IsDeliveryInfo_EnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _deliveryInfo_En;
		}
		set
		{
			_deliveryInfo_EnNull = false;
			_deliveryInfo_En = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DeliveryInfo_En"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDeliveryInfo_EnNull
	{
		get
		{
			return _deliveryInfo_EnNull;
		}
		set
		{
			_deliveryInfo_EnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StoreInfo_En</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StoreInfo_En</c> column value.</value>
	public string StoreInfo_En
	{
		get
		{
			if(IsStoreInfo_EnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _storeInfo_En;
		}
		set
		{
			_storeInfo_EnNull = false;
			_storeInfo_En = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StoreInfo_En"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStoreInfo_EnNull
	{
		get
		{
			return _storeInfo_EnNull;
		}
		set
		{
			_storeInfo_EnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CustomerInfo_En</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CustomerInfo_En</c> column value.</value>
	public string CustomerInfo_En
	{
		get
		{
			if(IsCustomerInfo_EnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _customerInfo_En;
		}
		set
		{
			_customerInfo_EnNull = false;
			_customerInfo_En = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CustomerInfo_En"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCustomerInfo_EnNull
	{
		get
		{
			return _customerInfo_EnNull;
		}
		set
		{
			_customerInfo_EnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ShippingNote_En</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ShippingNote_En</c> column value.</value>
	public string ShippingNote_En
	{
		get
		{
			if(IsShippingNote_EnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _shippingNote_En;
		}
		set
		{
			_shippingNote_EnNull = false;
			_shippingNote_En = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ShippingNote_En"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsShippingNote_EnNull
	{
		get
		{
			return _shippingNote_EnNull;
		}
		set
		{
			_shippingNote_EnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductName_Cn</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductName_Cn</c> column value.</value>
	public string ProductName_Cn
	{
		get
		{
			if(IsProductName_CnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productName_Cn;
		}
		set
		{
			_productName_CnNull = false;
			_productName_Cn = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductName_Cn"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductName_CnNull
	{
		get
		{
			return _productName_CnNull;
		}
		set
		{
			_productName_CnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Description_Cn</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Description_Cn</c> column value.</value>
	public string Description_Cn
	{
		get
		{
			if(IsDescription_CnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _description_Cn;
		}
		set
		{
			_description_CnNull = false;
			_description_Cn = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Description_Cn"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDescription_CnNull
	{
		get
		{
			return _description_CnNull;
		}
		set
		{
			_description_CnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProfileQRCode_Cn</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProfileQRCode_Cn</c> column value.</value>
	public string ProfileQRCode_Cn
	{
		get
		{
			if(IsProfileQRCode_CnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _profileQRCode_Cn;
		}
		set
		{
			_profileQRCode_CnNull = false;
			_profileQRCode_Cn = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProfileQRCode_Cn"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProfileQRCode_CnNull
	{
		get
		{
			return _profileQRCode_CnNull;
		}
		set
		{
			_profileQRCode_CnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProduceInfo_Cn</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProduceInfo_Cn</c> column value.</value>
	public string ProduceInfo_Cn
	{
		get
		{
			if(IsProduceInfo_CnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _produceInfo_Cn;
		}
		set
		{
			_produceInfo_CnNull = false;
			_produceInfo_Cn = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProduceInfo_Cn"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProduceInfo_CnNull
	{
		get
		{
			return _produceInfo_CnNull;
		}
		set
		{
			_produceInfo_CnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QualityInfo_Cn</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QualityInfo_Cn</c> column value.</value>
	public string QualityInfo_Cn
	{
		get
		{
			if(IsQualityInfo_CnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qualityInfo_Cn;
		}
		set
		{
			_qualityInfo_CnNull = false;
			_qualityInfo_Cn = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QualityInfo_Cn"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQualityInfo_CnNull
	{
		get
		{
			return _qualityInfo_CnNull;
		}
		set
		{
			_qualityInfo_CnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DeliveryInfo_Cn</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DeliveryInfo_Cn</c> column value.</value>
	public string DeliveryInfo_Cn
	{
		get
		{
			if(IsDeliveryInfo_CnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _deliveryInfo_Cn;
		}
		set
		{
			_deliveryInfo_CnNull = false;
			_deliveryInfo_Cn = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DeliveryInfo_Cn"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDeliveryInfo_CnNull
	{
		get
		{
			return _deliveryInfo_CnNull;
		}
		set
		{
			_deliveryInfo_CnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StoreInfo_Cn</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StoreInfo_Cn</c> column value.</value>
	public string StoreInfo_Cn
	{
		get
		{
			if(IsStoreInfo_CnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _storeInfo_Cn;
		}
		set
		{
			_storeInfo_CnNull = false;
			_storeInfo_Cn = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StoreInfo_Cn"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStoreInfo_CnNull
	{
		get
		{
			return _storeInfo_CnNull;
		}
		set
		{
			_storeInfo_CnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CustomerInfo_Cn</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CustomerInfo_Cn</c> column value.</value>
	public string CustomerInfo_Cn
	{
		get
		{
			if(IsCustomerInfo_CnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _customerInfo_Cn;
		}
		set
		{
			_customerInfo_CnNull = false;
			_customerInfo_Cn = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CustomerInfo_Cn"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCustomerInfo_CnNull
	{
		get
		{
			return _customerInfo_CnNull;
		}
		set
		{
			_customerInfo_CnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ShippingNote_Cn</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ShippingNote_Cn</c> column value.</value>
	public string ShippingNote_Cn
	{
		get
		{
			if(IsShippingNote_CnNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _shippingNote_Cn;
		}
		set
		{
			_shippingNote_CnNull = false;
			_shippingNote_Cn = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ShippingNote_Cn"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsShippingNote_CnNull
	{
		get
		{
			return _shippingNote_CnNull;
		}
		set
		{
			_shippingNote_CnNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Amount</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Amount</c> column value.</value>
	public long Amount
	{
		get
		{
			if (IsAmountNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _amount;
		}
		set
		{
			_amountNull = false;
			_amount = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Amount"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAmountNull
	{
		get
		{
			return _amountNull;
		}
		set
		{
			_amountNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AmountUnit</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AmountUnit</c> column value.</value>
	public string AmountUnit
	{
		get
		{
			if(IsAmountUnitNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _amountUnit;
		}
		set
		{
			_amountUnitNull = false;
			_amountUnit = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AmountUnit"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAmountUnitNull
	{
		get
		{
			return _amountUnitNull;
		}
		set
		{
			_amountUnitNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AmountSum</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AmountSum</c> column value.</value>
	public long AmountSum
	{
		get
		{
			if (IsAmountSumNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _amountSum;
		}
		set
		{
			_amountSumNull = false;
			_amountSum = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AmountSum"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAmountSumNull
	{
		get
		{
			return _amountSumNull;
		}
		set
		{
			_amountSumNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>HarvestDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>HarvestDate</c> column value.</value>
	public System.DateTime HarvestDate
	{
		get
		{
			if (IsHarvestDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _harvestDate;
		}
		set
		{
			_harvestDateNull = false;
			_harvestDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="HarvestDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsHarvestDateNull
	{
		get
		{
			return _harvestDateNull;
		}
		set
		{
			_harvestDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ExpiryByDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ExpiryByDate</c> column value.</value>
	public int ExpiryByDate
	{
		get
		{
			if (IsExpiryByDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _expiryByDate;
		}
		set
		{
			_expiryByDateNull = false;
			_expiryByDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ExpiryByDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsExpiryByDateNull
	{
		get
		{
			return _expiryByDateNull;
		}
		set
		{
			_expiryByDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FarmCreateBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FarmCreateBy</c> column value.</value>
	public System.Guid FarmCreateBy
	{
		get
		{
			if (IsFarmCreateByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farmCreateBy;
		}
		set
		{
			_farmCreateByNull = false;
			_farmCreateBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FarmCreateBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarmCreateByNull
	{
		get
		{
			return _farmCreateByNull;
		}
		set
		{
			_farmCreateByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FarmWorkshop_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FarmWorkshop_ID</c> column value.</value>
	public int FarmWorkshop_ID
	{
		get
		{
			if (IsFarmWorkshop_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farmWorkshop_ID;
		}
		set
		{
			_farmWorkshop_IDNull = false;
			_farmWorkshop_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FarmWorkshop_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarmWorkshop_IDNull
	{
		get
		{
			return _farmWorkshop_IDNull;
		}
		set
		{
			_farmWorkshop_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FarmWorkshopName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FarmWorkshopName</c> column value.</value>
	public string FarmWorkshopName
	{
		get
		{
			if(IsFarmWorkshopNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farmWorkshopName;
		}
		set
		{
			_farmWorkshopNameNull = false;
			_farmWorkshopName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FarmWorkshopName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarmWorkshopNameNull
	{
		get
		{
			return _farmWorkshopNameNull;
		}
		set
		{
			_farmWorkshopNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FarmProducerName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FarmProducerName</c> column value.</value>
	public string FarmProducerName
	{
		get
		{
			if(IsFarmProducerNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farmProducerName;
		}
		set
		{
			_farmProducerNameNull = false;
			_farmProducerName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FarmProducerName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarmProducerNameNull
	{
		get
		{
			return _farmProducerNameNull;
		}
		set
		{
			_farmProducerNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FarmGroupInter_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FarmGroupInter_ID</c> column value.</value>
	public int FarmGroupInter_ID
	{
		get
		{
			if (IsFarmGroupInter_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farmGroupInter_ID;
		}
		set
		{
			_farmGroupInter_IDNull = false;
			_farmGroupInter_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FarmGroupInter_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarmGroupInter_IDNull
	{
		get
		{
			return _farmGroupInter_IDNull;
		}
		set
		{
			_farmGroupInter_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FarmGroupInterName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FarmGroupInterName</c> column value.</value>
	public string FarmGroupInterName
	{
		get
		{
			if(IsFarmGroupInterNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farmGroupInterName;
		}
		set
		{
			_farmGroupInterNameNull = false;
			_farmGroupInterName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FarmGroupInterName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarmGroupInterNameNull
	{
		get
		{
			return _farmGroupInterNameNull;
		}
		set
		{
			_farmGroupInterNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FarmGroup_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FarmGroup_ID</c> column value.</value>
	public int FarmGroup_ID
	{
		get
		{
			if (IsFarmGroup_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farmGroup_ID;
		}
		set
		{
			_farmGroup_IDNull = false;
			_farmGroup_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FarmGroup_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarmGroup_IDNull
	{
		get
		{
			return _farmGroup_IDNull;
		}
		set
		{
			_farmGroup_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FarmGroupName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FarmGroupName</c> column value.</value>
	public string FarmGroupName
	{
		get
		{
			if(IsFarmGroupNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farmGroupName;
		}
		set
		{
			_farmGroupNameNull = false;
			_farmGroupName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FarmGroupName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarmGroupNameNull
	{
		get
		{
			return _farmGroupNameNull;
		}
		set
		{
			_farmGroupNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WEB_UserID_Create</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WEB_UserID_Create</c> column value.</value>
	public int WEB_UserID_Create
	{
		get
		{
			if (IsWEB_UserID_CreateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wEB_UserID_Create;
		}
		set
		{
			_wEB_UserID_CreateNull = false;
			_wEB_UserID_Create = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WEB_UserID_Create"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWEB_UserID_CreateNull
	{
		get
		{
			return _wEB_UserID_CreateNull;
		}
		set
		{
			_wEB_UserID_CreateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WEB_UserID_Edit</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WEB_UserID_Edit</c> column value.</value>
	public int WEB_UserID_Edit
	{
		get
		{
			if (IsWEB_UserID_EditNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wEB_UserID_Edit;
		}
		set
		{
			_wEB_UserID_EditNull = false;
			_wEB_UserID_Edit = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WEB_UserID_Edit"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWEB_UserID_EditNull
	{
		get
		{
			return _wEB_UserID_EditNull;
		}
		set
		{
			_wEB_UserID_EditNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>NgaySX</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>NgaySX</c> column value.</value>
	public System.DateTime NgaySX
	{
		get
		{
			if (IsNgaySXNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _ngaySX;
		}
		set
		{
			_ngaySXNull = false;
			_ngaySX = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="NgaySX"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNgaySXNull
	{
		get
		{
			return _ngaySXNull;
		}
		set
		{
			_ngaySXNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>NguoiDan</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>NguoiDan</c> column value.</value>
	public string NguoiDan
	{
		get
		{
			if(IsNguoiDanNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _nguoiDan;
		}
		set
		{
			_nguoiDanNull = false;
			_nguoiDan = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="NguoiDan"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNguoiDanNull
	{
		get
		{
			return _nguoiDanNull;
		}
		set
		{
			_nguoiDanNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>PhanXuongSX</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PhanXuongSX</c> column value.</value>
	public string PhanXuongSX
	{
		get
		{
			if(IsPhanXuongSXNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _phanXuongSX;
		}
		set
		{
			_phanXuongSXNull = false;
			_phanXuongSX = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PhanXuongSX"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPhanXuongSXNull
	{
		get
		{
			return _phanXuongSXNull;
		}
		set
		{
			_phanXuongSXNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Department_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Department_ID</c> column value.</value>
	public int Department_ID
	{
		get
		{
			if (IsDepartment_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _department_ID;
		}
		set
		{
			_department_IDNull = false;
			_department_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Department_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDepartment_IDNull
	{
		get
		{
			return _department_IDNull;
		}
		set
		{
			_department_IDNull = value;
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
		// QRCodePackage_ID
		dynStr.Append("  QRCodePackage_ID=");
		if( IsQRCodePackage_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodePackage_ID);
		

		// QRCodePackageType_ID
		dynStr.Append("  QRCodePackageType_ID=");
		if( IsQRCodePackageType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodePackageType_ID);
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
		// Store_ID
		dynStr.Append("  Store_ID=");
		if( IsStore_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Store_ID);
		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackage_ID);
		// Factory_ID
		dynStr.Append("  Factory_ID=");
		if( IsFactory_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Factory_ID);
		// Supplier_ID
		dynStr.Append("  Supplier_ID=");
		if( IsSupplier_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Supplier_ID);
		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// ProductName
		dynStr.Append("  ProductName=");
		if( IsProductNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductName);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// ProfileQRCode
		dynStr.Append("  ProfileQRCode=");
		if( IsProfileQRCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProfileQRCode);
		

		// SoundEnable
		dynStr.Append("  SoundEnable=");
		if( IsSoundEnableNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.SoundEnable);
		// SMS
		dynStr.Append("  SMS=");
		if( IsSMSNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.SMS);
		// Prefix
		dynStr.Append("  Prefix=");
		if( IsPrefixNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Prefix);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// QRCodeStatus_ID
		dynStr.Append("  QRCodeStatus_ID=");
		if( IsQRCodeStatus_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodeStatus_ID);
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
		// QRCodeNumber
		dynStr.Append("  QRCodeNumber=");
		if( IsQRCodeNumberNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodeNumber);
		// QRCodeUsed
		dynStr.Append("  QRCodeUsed=");
		if( IsQRCodeUsedNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodeUsed);
		// QRCodeAvailable
		dynStr.Append("  QRCodeAvailable=");
		if( IsQRCodeAvailableNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodeAvailable);
		// SerialNumberStart
		dynStr.Append("  SerialNumberStart=");
		if( IsSerialNumberStartNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SerialNumberStart);
		

		// SerialNumberEnd
		dynStr.Append("  SerialNumberEnd=");
		if( IsSerialNumberEndNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SerialNumberEnd);
		

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
		// AgencyAssign
		dynStr.Append("  AgencyAssign=");
		if( IsAgencyAssignNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AgencyAssign);
		// ManufactureDate
		dynStr.Append("  ManufactureDate=");
		if( IsManufactureDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ManufactureDate);
		// ExpiryDate
		dynStr.Append("  ExpiryDate=");
		if( IsExpiryDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ExpiryDate);
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
		

		// ActiveDate
		dynStr.Append("  ActiveDate=");
		if( IsActiveDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ActiveDate);
		// PendingActive
		dynStr.Append("  PendingActive=");
		if( IsPendingActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.PendingActive);
		// PendingActiveDate
		dynStr.Append("  PendingActiveDate=");
		if( IsPendingActiveDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.PendingActiveDate);
		// ProduceInfoStaff
		dynStr.Append("  ProduceInfoStaff=");
		if( IsProduceInfoStaffNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProduceInfoStaff);
		

		// ProduceInfo
		dynStr.Append("  ProduceInfo=");
		if( IsProduceInfoNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProduceInfo);
		

		// ProduceInfoDisplay
		dynStr.Append("  ProduceInfoDisplay=");
		if( IsProduceInfoDisplayNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProduceInfoDisplay);
		// ProduceInfoEditDate
		dynStr.Append("  ProduceInfoEditDate=");
		if( IsProduceInfoEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProduceInfoEditDate);
		// QualityInfo
		dynStr.Append("  QualityInfo=");
		if( IsQualityInfoNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QualityInfo);
		

		// QualityInfoDisplay
		dynStr.Append("  QualityInfoDisplay=");
		if( IsQualityInfoDisplayNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QualityInfoDisplay);
		// QualityInfoEditDate
		dynStr.Append("  QualityInfoEditDate=");
		if( IsQualityInfoEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QualityInfoEditDate);
		// DeliveryInfo
		dynStr.Append("  DeliveryInfo=");
		if( IsDeliveryInfoNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DeliveryInfo);
		

		// DeliveryInfoEditDate
		dynStr.Append("  DeliveryInfoEditDate=");
		if( IsDeliveryInfoEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.DeliveryInfoEditDate);
		// StoreInfo
		dynStr.Append("  StoreInfo=");
		if( IsStoreInfoNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.StoreInfo);
		

		// StoreInfoDisplay
		dynStr.Append("  StoreInfoDisplay=");
		if( IsStoreInfoDisplayNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.StoreInfoDisplay);
		// StoreInfoEditDate
		dynStr.Append("  StoreInfoEditDate=");
		if( IsStoreInfoEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.StoreInfoEditDate);
		// Warehouse_ID
		dynStr.Append("  Warehouse_ID=");
		if( IsWarehouse_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Warehouse_ID);
		// CustomerInfo
		dynStr.Append("  CustomerInfo=");
		if( IsCustomerInfoNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CustomerInfo);
		

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
		// StampDate
		dynStr.Append("  StampDate=");
		if( IsStampDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.StampDate);
		// ShippingDate
		dynStr.Append("  ShippingDate=");
		if( IsShippingDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ShippingDate);
		// ShippingNote
		dynStr.Append("  ShippingNote=");
		if( IsShippingNoteNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ShippingNote);
		

		// ProductName_En
		dynStr.Append("  ProductName_En=");
		if( IsProductName_EnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductName_En);
		

		// Description_En
		dynStr.Append("  Description_En=");
		if( IsDescription_EnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description_En);
		

		// ProfileQRCode_En
		dynStr.Append("  ProfileQRCode_En=");
		if( IsProfileQRCode_EnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProfileQRCode_En);
		

		// ProduceInfo_En
		dynStr.Append("  ProduceInfo_En=");
		if( IsProduceInfo_EnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProduceInfo_En);
		

		// QualityInfo_En
		dynStr.Append("  QualityInfo_En=");
		if( IsQualityInfo_EnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QualityInfo_En);
		

		// DeliveryInfo_En
		dynStr.Append("  DeliveryInfo_En=");
		if( IsDeliveryInfo_EnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DeliveryInfo_En);
		

		// StoreInfo_En
		dynStr.Append("  StoreInfo_En=");
		if( IsStoreInfo_EnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.StoreInfo_En);
		

		// CustomerInfo_En
		dynStr.Append("  CustomerInfo_En=");
		if( IsCustomerInfo_EnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CustomerInfo_En);
		

		// ShippingNote_En
		dynStr.Append("  ShippingNote_En=");
		if( IsShippingNote_EnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ShippingNote_En);
		

		// ProductName_Cn
		dynStr.Append("  ProductName_Cn=");
		if( IsProductName_CnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductName_Cn);
		

		// Description_Cn
		dynStr.Append("  Description_Cn=");
		if( IsDescription_CnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description_Cn);
		

		// ProfileQRCode_Cn
		dynStr.Append("  ProfileQRCode_Cn=");
		if( IsProfileQRCode_CnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProfileQRCode_Cn);
		

		// ProduceInfo_Cn
		dynStr.Append("  ProduceInfo_Cn=");
		if( IsProduceInfo_CnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProduceInfo_Cn);
		

		// QualityInfo_Cn
		dynStr.Append("  QualityInfo_Cn=");
		if( IsQualityInfo_CnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QualityInfo_Cn);
		

		// DeliveryInfo_Cn
		dynStr.Append("  DeliveryInfo_Cn=");
		if( IsDeliveryInfo_CnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DeliveryInfo_Cn);
		

		// StoreInfo_Cn
		dynStr.Append("  StoreInfo_Cn=");
		if( IsStoreInfo_CnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.StoreInfo_Cn);
		

		// CustomerInfo_Cn
		dynStr.Append("  CustomerInfo_Cn=");
		if( IsCustomerInfo_CnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CustomerInfo_Cn);
		

		// ShippingNote_Cn
		dynStr.Append("  ShippingNote_Cn=");
		if( IsShippingNote_CnNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ShippingNote_Cn);
		

		// Amount
		dynStr.Append("  Amount=");
		if( IsAmountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Amount);
		// AmountUnit
		dynStr.Append("  AmountUnit=");
		if( IsAmountUnitNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.AmountUnit);
		

		// AmountSum
		dynStr.Append("  AmountSum=");
		if( IsAmountSumNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AmountSum);
		// HarvestDate
		dynStr.Append("  HarvestDate=");
		if( IsHarvestDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.HarvestDate);
		// ExpiryByDate
		dynStr.Append("  ExpiryByDate=");
		if( IsExpiryByDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ExpiryByDate);
		// FarmCreateBy
		dynStr.Append("  FarmCreateBy=");
		if( IsFarmCreateByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.FarmCreateBy);
		// FarmWorkshop_ID
		dynStr.Append("  FarmWorkshop_ID=");
		if( IsFarmWorkshop_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.FarmWorkshop_ID);
		// FarmWorkshopName
		dynStr.Append("  FarmWorkshopName=");
		if( IsFarmWorkshopNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FarmWorkshopName);
		

		// FarmProducerName
		dynStr.Append("  FarmProducerName=");
		if( IsFarmProducerNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FarmProducerName);
		

		// FarmGroupInter_ID
		dynStr.Append("  FarmGroupInter_ID=");
		if( IsFarmGroupInter_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.FarmGroupInter_ID);
		// FarmGroupInterName
		dynStr.Append("  FarmGroupInterName=");
		if( IsFarmGroupInterNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FarmGroupInterName);
		

		// FarmGroup_ID
		dynStr.Append("  FarmGroup_ID=");
		if( IsFarmGroup_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.FarmGroup_ID);
		// FarmGroupName
		dynStr.Append("  FarmGroupName=");
		if( IsFarmGroupNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FarmGroupName);
		

		// WEB_UserID_Create
		dynStr.Append("  WEB_UserID_Create=");
		if( IsWEB_UserID_CreateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WEB_UserID_Create);
		// WEB_UserID_Edit
		dynStr.Append("  WEB_UserID_Edit=");
		if( IsWEB_UserID_EditNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WEB_UserID_Edit);
		// NgaySX
		dynStr.Append("  NgaySX=");
		if( IsNgaySXNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.NgaySX);
		// NguoiDan
		dynStr.Append("  NguoiDan=");
		if( IsNguoiDanNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.NguoiDan);
		

		// PhanXuongSX
		dynStr.Append("  PhanXuongSX=");
		if( IsPhanXuongSXNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PhanXuongSX);
		

		// Department_ID
		dynStr.Append("  Department_ID=");
		if( IsDepartment_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Department_ID);
		return dynStr.ToString();
	}
}
}




