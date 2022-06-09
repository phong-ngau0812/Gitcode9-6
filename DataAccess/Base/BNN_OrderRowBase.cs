
// <fileinfo name="Base\BNN_OrderRowBase.cs">
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
/// The base class for <see cref="BNN_OrderRow"/> that 
/// represents a record in the <c>BNN_Order</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="BNN_OrderRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_OrderRowBase
{
	/// _order_ID
	private int _order_ID;
	private bool _order_IDNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _totalPrice
	private decimal _totalPrice;
	private bool _totalPriceNull = true;
	/// _status
	private int _status;
	private bool _statusNull = true;
	/// _member_ID
	private int _member_ID;
	private bool _member_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _phone
	private string _phone;
	private bool _phoneNull = true;
	/// _email
	private string _email;
	private bool _emailNull = true;
	/// _address
	private string _address;
	private bool _addressNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="BNN_OrderRowBase"/> class.
	/// </summary>
	public BNN_OrderRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Order_ID</c> column value.
		/// </summary>
		/// <value>The <c>Order_ID</c> column value.</value>
	public int Order_ID
	{
		get
		{
			if(IsOrder_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _order_ID;
		}
		set
		{
			_order_IDNull = false;
			_order_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Order_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOrder_IDNull
	{
		get
		{
			return _order_IDNull;
		}
		set
		{
			_order_IDNull = value;
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
		/// Gets or sets the <c>TotalPrice</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TotalPrice</c> column value.</value>
	public decimal TotalPrice
	{
		get
		{
			if (IsTotalPriceNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _totalPrice;
		}
		set
		{
			_totalPriceNull = false;
			_totalPrice = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TotalPrice"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTotalPriceNull
	{
		get
		{
			return _totalPriceNull;
		}
		set
		{
			_totalPriceNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Status</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Status</c> column value.</value>
	public int Status
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
		/// Gets or sets the <c>Member_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Member_ID</c> column value.</value>
	public int Member_ID
	{
		get
		{
			if (IsMember_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _member_ID;
		}
		set
		{
			_member_IDNull = false;
			_member_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Member_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMember_IDNull
	{
		get
		{
			return _member_IDNull;
		}
		set
		{
			_member_IDNull = value;
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
		/// Gets or sets the <c>Phone</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Phone</c> column value.</value>
	public string Phone
	{
		get
		{
			if(IsPhoneNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _phone;
		}
		set
		{
			_phoneNull = false;
			_phone = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Phone"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPhoneNull
	{
		get
		{
			return _phoneNull;
		}
		set
		{
			_phoneNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Email</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Email</c> column value.</value>
	public string Email
	{
		get
		{
			if(IsEmailNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _email;
		}
		set
		{
			_emailNull = false;
			_email = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Email"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailNull
	{
		get
		{
			return _emailNull;
		}
		set
		{
			_emailNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Address</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Address</c> column value.</value>
	public string Address
	{
		get
		{
			if(IsAddressNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _address;
		}
		set
		{
			_addressNull = false;
			_address = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Address"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAddressNull
	{
		get
		{
			return _addressNull;
		}
		set
		{
			_addressNull = value;
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
		// Order_ID
		dynStr.Append("  Order_ID=");
		if( IsOrder_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Order_ID);
		

		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		// TotalPrice
		dynStr.Append("  TotalPrice=");
		if( IsTotalPriceNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.TotalPrice);
		// Status
		dynStr.Append("  Status=");
		if( IsStatusNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Status);
		// Member_ID
		dynStr.Append("  Member_ID=");
		if( IsMember_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Member_ID);
		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Phone
		dynStr.Append("  Phone=");
		if( IsPhoneNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Phone);
		

		// Email
		dynStr.Append("  Email=");
		if( IsEmailNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Email);
		

		// Address
		dynStr.Append("  Address=");
		if( IsAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Address);
		

		return dynStr.ToString();
	}
}
}




