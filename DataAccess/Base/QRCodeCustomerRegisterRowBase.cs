
// <fileinfo name="Base\QRCodeCustomerRegisterRowBase.cs">
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
/// The base class for <see cref="QRCodeCustomerRegisterRow"/> that 
/// represents a record in the <c>QRCodeCustomerRegister</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="QRCodeCustomerRegisterRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodeCustomerRegisterRowBase
{
	/// _qRCodeCustomerRegister_ID
	private int _qRCodeCustomerRegister_ID;
	private bool _qRCodeCustomerRegister_IDNull = true;
	/// _qRCodePackage_ID
	private int _qRCodePackage_ID;
	private bool _qRCodePackage_IDNull = true;
	/// _customer_ID
	private int _customer_ID;
	private bool _customer_IDNull = true;
	/// _customerName
	private string _customerName;
	private bool _customerNameNull = true;
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
	/// Initializes a new instance of the <see cref="QRCodeCustomerRegisterRowBase"/> class.
	/// </summary>
	public QRCodeCustomerRegisterRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeCustomerRegister_ID</c> column value.
		/// </summary>
		/// <value>The <c>QRCodeCustomerRegister_ID</c> column value.</value>
	public int QRCodeCustomerRegister_ID
	{
		get
		{
			if(IsQRCodeCustomerRegister_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeCustomerRegister_ID;
		}
		set
		{
			_qRCodeCustomerRegister_IDNull = false;
			_qRCodeCustomerRegister_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeCustomerRegister_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeCustomerRegister_IDNull
	{
		get
		{
			return _qRCodeCustomerRegister_IDNull;
		}
		set
		{
			_qRCodeCustomerRegister_IDNull = value;
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
		/// Gets or sets the <c>Customer_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Customer_ID</c> column value.</value>
	public int Customer_ID
	{
		get
		{
			if (IsCustomer_IDNull)
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
		/// Gets or sets the <c>CustomerName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CustomerName</c> column value.</value>
	public string CustomerName
	{
		get
		{
			if(IsCustomerNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _customerName;
		}
		set
		{
			_customerNameNull = false;
			_customerName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CustomerName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCustomerNameNull
	{
		get
		{
			return _customerNameNull;
		}
		set
		{
			_customerNameNull = value;
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
		// QRCodeCustomerRegister_ID
		dynStr.Append("  QRCodeCustomerRegister_ID=");
		if( IsQRCodeCustomerRegister_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodeCustomerRegister_ID);
		

		// QRCodePackage_ID
		dynStr.Append("  QRCodePackage_ID=");
		if( IsQRCodePackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodePackage_ID);
		// Customer_ID
		dynStr.Append("  Customer_ID=");
		if( IsCustomer_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Customer_ID);
		// CustomerName
		dynStr.Append("  CustomerName=");
		if( IsCustomerNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CustomerName);
		

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




