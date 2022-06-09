
// <fileinfo name="Base\QRCodePublic_ESRowBase.cs">
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
/// The base class for <see cref="QRCodePublic_ESRow"/> that 
/// represents a record in the <c>QRCodePublic_ES</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="QRCodePublic_ESRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodePublic_ESRowBase
{
	/// _qRCodePublicContent
	private string _qRCodePublicContent;
	private bool _qRCodePublicContentNull = true;
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
	/// _viewCount
	private int _viewCount;
	private bool _viewCountNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _activeDate
	private System.DateTime _activeDate;
	private bool _activeDateNull = true;
	/// _workshop_ID
	private int _workshop_ID;
	private bool _workshop_IDNull = true;
	/// _productItemNumber
	private int _productItemNumber;
	private bool _productItemNumberNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="QRCodePublic_ESRowBase"/> class.
	/// </summary>
	public QRCodePublic_ESRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>QRCodePublicContent</c> column value.
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
		/// Gets or sets the <c>ProductItemNumber</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductItemNumber</c> column value.</value>
	public int ProductItemNumber
	{
		get
		{
			if (IsProductItemNumberNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productItemNumber;
		}
		set
		{
			_productItemNumberNull = false;
			_productItemNumber = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductItemNumber"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductItemNumberNull
	{
		get
		{
			return _productItemNumberNull;
		}
		set
		{
			_productItemNumberNull = value;
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
		// ViewCount
		dynStr.Append("  ViewCount=");
		if( IsViewCountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ViewCount);
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
		// Workshop_ID
		dynStr.Append("  Workshop_ID=");
		if( IsWorkshop_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Workshop_ID);
		// ProductItemNumber
		dynStr.Append("  ProductItemNumber=");
		if( IsProductItemNumberNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductItemNumber);
		return dynStr.ToString();
	}
}
}




