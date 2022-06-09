
// <fileinfo name="Base\WH_DeliveryNoteRowBase.cs">
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
/// The base class for <see cref="WH_DeliveryNoteRow"/> that 
/// represents a record in the <c>WH_DeliveryNote</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WH_DeliveryNoteRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_DeliveryNoteRowBase
{
	/// _wH_DeliveryNote_ID
	private int _wH_DeliveryNote_ID;
	private bool _wH_DeliveryNote_IDNull = true;
	/// _code
	private string _code;
	private bool _codeNull = true;
	/// _supplier_ID
	private int _supplier_ID;
	private bool _supplier_IDNull = true;
	/// _delivery_Date
	private System.DateTime _delivery_Date;
	private bool _delivery_DateNull = true;
	/// _status
	private bool _status;
	private bool _statusNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WH_DeliveryNoteRowBase"/> class.
	/// </summary>
	public WH_DeliveryNoteRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WH_DeliveryNote_ID</c> column value.
		/// </summary>
		/// <value>The <c>WH_DeliveryNote_ID</c> column value.</value>
	public int WH_DeliveryNote_ID
	{
		get
		{
			if(IsWH_DeliveryNote_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_DeliveryNote_ID;
		}
		set
		{
			_wH_DeliveryNote_IDNull = false;
			_wH_DeliveryNote_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_DeliveryNote_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_DeliveryNote_IDNull
	{
		get
		{
			return _wH_DeliveryNote_IDNull;
		}
		set
		{
			_wH_DeliveryNote_IDNull = value;
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
		/// Gets or sets the <c>Delivery_Date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Delivery_Date</c> column value.</value>
	public System.DateTime Delivery_Date
	{
		get
		{
			if (IsDelivery_DateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _delivery_Date;
		}
		set
		{
			_delivery_DateNull = false;
			_delivery_Date = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Delivery_Date"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDelivery_DateNull
	{
		get
		{
			return _delivery_DateNull;
		}
		set
		{
			_delivery_DateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Status</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Status</c> column value.</value>
	public bool Status
	{
		get
		{
			if (IsStatusNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _status;
		}
		set
		{
			_statusNull = false;
			_status = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Status"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStatusNull
	{
		get
		{
			return _statusNull;
		}
		set
		{
			_statusNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// WH_DeliveryNote_ID
		dynStr.Append("  WH_DeliveryNote_ID=");
		if( IsWH_DeliveryNote_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WH_DeliveryNote_ID);
		

		// Code
		dynStr.Append("  Code=");
		if( IsCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Code);
		

		// Supplier_ID
		dynStr.Append("  Supplier_ID=");
		if( IsSupplier_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Supplier_ID);
		// Delivery_Date
		dynStr.Append("  Delivery_Date=");
		if( IsDelivery_DateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Delivery_Date);
		// Status
		dynStr.Append("  Status=");
		if( IsStatusNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Status);
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
		// LastEditDate
		dynStr.Append("  LastEditDate=");
		if( IsLastEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditDate);
		// LastEditBy
		dynStr.Append("  LastEditBy=");
		if( IsLastEditByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditBy);
		return dynStr.ToString();
	}
}
}




