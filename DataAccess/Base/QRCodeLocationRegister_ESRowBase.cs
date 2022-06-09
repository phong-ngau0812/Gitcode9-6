
// <fileinfo name="Base\QRCodeLocationRegister_ESRowBase.cs">
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
/// The base class for <see cref="QRCodeLocationRegister_ESRow"/> that 
/// represents a record in the <c>QRCodeLocationRegister_ES</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="QRCodeLocationRegister_ESRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodeLocationRegister_ESRowBase
{
	/// _qRCodeLocationRegister_ID
	private int _qRCodeLocationRegister_ID;
	private bool _qRCodeLocationRegister_IDNull = true;
	/// _qRCodePackage_ID
	private int _qRCodePackage_ID;
	private bool _qRCodePackage_IDNull = true;
	/// _qRCodeSplitType_ID
	private int _qRCodeSplitType_ID;
	private bool _qRCodeSplitType_IDNull = true;
	/// _serialNumberStart
	private string _serialNumberStart;
	private bool _serialNumberStartNull = true;
	/// _serialNumberEnd
	private string _serialNumberEnd;
	private bool _serialNumberEndNull = true;
	/// _serialNumberList
	private string _serialNumberList;
	private bool _serialNumberListNull = true;
	/// _qRCodeNumber
	private int _qRCodeNumber;
	private bool _qRCodeNumberNull = true;
	/// _locationRegister
	private string _locationRegister;
	private bool _locationRegisterNull = true;
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
	/// _locationFailedWarning
	private bool _locationFailedWarning;
	private bool _locationFailedWarningNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="QRCodeLocationRegister_ESRowBase"/> class.
	/// </summary>
	public QRCodeLocationRegister_ESRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeLocationRegister_ID</c> column value.
		/// </summary>
		/// <value>The <c>QRCodeLocationRegister_ID</c> column value.</value>
	public int QRCodeLocationRegister_ID
	{
		get
		{
			if(IsQRCodeLocationRegister_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeLocationRegister_ID;
		}
		set
		{
			_qRCodeLocationRegister_IDNull = false;
			_qRCodeLocationRegister_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeLocationRegister_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeLocationRegister_IDNull
	{
		get
		{
			return _qRCodeLocationRegister_IDNull;
		}
		set
		{
			_qRCodeLocationRegister_IDNull = value;
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
		/// Gets or sets the <c>QRCodeSplitType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodeSplitType_ID</c> column value.</value>
	public int QRCodeSplitType_ID
	{
		get
		{
			if (IsQRCodeSplitType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeSplitType_ID;
		}
		set
		{
			_qRCodeSplitType_IDNull = false;
			_qRCodeSplitType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeSplitType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeSplitType_IDNull
	{
		get
		{
			return _qRCodeSplitType_IDNull;
		}
		set
		{
			_qRCodeSplitType_IDNull = value;
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
		/// Gets or sets the <c>SerialNumberList</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SerialNumberList</c> column value.</value>
	public string SerialNumberList
	{
		get
		{
			if(IsSerialNumberListNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _serialNumberList;
		}
		set
		{
			_serialNumberListNull = false;
			_serialNumberList = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SerialNumberList"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSerialNumberListNull
	{
		get
		{
			return _serialNumberListNull;
		}
		set
		{
			_serialNumberListNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// QRCodeLocationRegister_ID
		dynStr.Append("  QRCodeLocationRegister_ID=");
		if( IsQRCodeLocationRegister_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodeLocationRegister_ID);
		

		// QRCodePackage_ID
		dynStr.Append("  QRCodePackage_ID=");
		if( IsQRCodePackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodePackage_ID);
		// QRCodeSplitType_ID
		dynStr.Append("  QRCodeSplitType_ID=");
		if( IsQRCodeSplitType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodeSplitType_ID);
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
		

		// SerialNumberList
		dynStr.Append("  SerialNumberList=");
		if( IsSerialNumberListNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SerialNumberList);
		

		// QRCodeNumber
		dynStr.Append("  QRCodeNumber=");
		if( IsQRCodeNumberNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodeNumber);
		// LocationRegister
		dynStr.Append("  LocationRegister=");
		if( IsLocationRegisterNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.LocationRegister);
		

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
		// LocationFailedWarning
		dynStr.Append("  LocationFailedWarning=");
		if( IsLocationFailedWarningNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LocationFailedWarning);
		return dynStr.ToString();
	}
}
}




