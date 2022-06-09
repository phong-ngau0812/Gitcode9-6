
// <fileinfo name="Base\QRCodePackageRule_ESRowBase.cs">
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
/// The base class for <see cref="QRCodePackageRule_ESRow"/> that 
/// represents a record in the <c>QRCodePackageRule_ES</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="QRCodePackageRule_ESRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodePackageRule_ESRowBase
{
	/// _qRCodePackageRule_ID
	private int _qRCodePackageRule_ID;
	private bool _qRCodePackageRule_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _isCreate
	private bool _isCreate;
	private bool _isCreateNull = true;
	/// _isDownload
	private bool _isDownload;
	private bool _isDownloadNull = true;
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
	/// _number
	private int _number;
	private bool _numberNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="QRCodePackageRule_ESRowBase"/> class.
	/// </summary>
	public QRCodePackageRule_ESRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>QRCodePackageRule_ID</c> column value.
		/// </summary>
		/// <value>The <c>QRCodePackageRule_ID</c> column value.</value>
	public int QRCodePackageRule_ID
	{
		get
		{
			if(IsQRCodePackageRule_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodePackageRule_ID;
		}
		set
		{
			_qRCodePackageRule_IDNull = false;
			_qRCodePackageRule_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodePackageRule_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodePackageRule_IDNull
	{
		get
		{
			return _qRCodePackageRule_IDNull;
		}
		set
		{
			_qRCodePackageRule_IDNull = value;
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
		/// Gets or sets the <c>IsCreate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IsCreate</c> column value.</value>
	public bool IsCreate
	{
		get
		{
			if (IsIsCreateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _isCreate;
		}
		set
		{
			_isCreateNull = false;
			_isCreate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="IsCreate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIsCreateNull
	{
		get
		{
			return _isCreateNull;
		}
		set
		{
			_isCreateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>IsDownload</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IsDownload</c> column value.</value>
	public bool IsDownload
	{
		get
		{
			if (IsIsDownloadNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _isDownload;
		}
		set
		{
			_isDownloadNull = false;
			_isDownload = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="IsDownload"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIsDownloadNull
	{
		get
		{
			return _isDownloadNull;
		}
		set
		{
			_isDownloadNull = value;
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
		/// Gets or sets the <c>Number</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Number</c> column value.</value>
	public int Number
	{
		get
		{
			if (IsNumberNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _number;
		}
		set
		{
			_numberNull = false;
			_number = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Number"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNumberNull
	{
		get
		{
			return _numberNull;
		}
		set
		{
			_numberNull = value;
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
		// QRCodePackageRule_ID
		dynStr.Append("  QRCodePackageRule_ID=");
		if( IsQRCodePackageRule_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodePackageRule_ID);
		

		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// IsCreate
		dynStr.Append("  IsCreate=");
		if( IsIsCreateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.IsCreate);
		// IsDownload
		dynStr.Append("  IsDownload=");
		if( IsIsDownloadNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.IsDownload);
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
		// Number
		dynStr.Append("  Number=");
		if( IsNumberNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Number);
		return dynStr.ToString();
	}
}
}




