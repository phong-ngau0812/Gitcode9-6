
// <fileinfo name="Base\QRCodeWarehouseRegister_ESRowBase.cs">
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
/// The base class for <see cref="QRCodeWarehouseRegister_ESRow"/> that 
/// represents a record in the <c>QRCodeWarehouseRegister_ES</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="QRCodeWarehouseRegister_ESRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodeWarehouseRegister_ESRowBase
{
	/// _qRCodeWarehouseRegister_ID
	private int _qRCodeWarehouseRegister_ID;
	private bool _qRCodeWarehouseRegister_IDNull = true;
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
	/// _warehouse_ID
	private int _warehouse_ID;
	private bool _warehouse_IDNull = true;
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
	/// Initializes a new instance of the <see cref="QRCodeWarehouseRegister_ESRowBase"/> class.
	/// </summary>
	public QRCodeWarehouseRegister_ESRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeWarehouseRegister_ID</c> column value.
		/// </summary>
		/// <value>The <c>QRCodeWarehouseRegister_ID</c> column value.</value>
	public int QRCodeWarehouseRegister_ID
	{
		get
		{
			if(IsQRCodeWarehouseRegister_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeWarehouseRegister_ID;
		}
		set
		{
			_qRCodeWarehouseRegister_IDNull = false;
			_qRCodeWarehouseRegister_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeWarehouseRegister_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeWarehouseRegister_IDNull
	{
		get
		{
			return _qRCodeWarehouseRegister_IDNull;
		}
		set
		{
			_qRCodeWarehouseRegister_IDNull = value;
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
		// QRCodeWarehouseRegister_ID
		dynStr.Append("  QRCodeWarehouseRegister_ID=");
		if( IsQRCodeWarehouseRegister_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodeWarehouseRegister_ID);
		

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
		// Warehouse_ID
		dynStr.Append("  Warehouse_ID=");
		if( IsWarehouse_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Warehouse_ID);
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




