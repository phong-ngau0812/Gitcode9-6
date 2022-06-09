
// <fileinfo name="Base\ProductItemRowBase.cs">
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
/// The base class for <see cref="ProductItemRow"/> that 
/// represents a record in the <c>ProductItem</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductItemRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductItemRowBase
{
	/// _productItem_ID
	private int _productItem_ID;
	private bool _productItem_IDNull = true;
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;
	/// _qRCodePublicContent
	private string _qRCodePublicContent;
	private bool _qRCodePublicContentNull = true;
	/// _serialNumber
	private string _serialNumber;
	private bool _serialNumberNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
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


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductItemRowBase"/> class.
	/// </summary>
	public ProductItemRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductItem_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductItem_ID</c> column value.</value>
	public int ProductItem_ID
	{
		get
		{
			if(IsProductItem_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productItem_ID;
		}
		set
		{
			_productItem_IDNull = false;
			_productItem_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductItem_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductItem_IDNull
	{
		get
		{
			return _productItem_IDNull;
		}
		set
		{
			_productItem_IDNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// ProductItem_ID
		dynStr.Append("  ProductItem_ID=");
		if( IsProductItem_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductItem_ID);
		

		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackage_ID);
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
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

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
		return dynStr.ToString();
	}
}
}




