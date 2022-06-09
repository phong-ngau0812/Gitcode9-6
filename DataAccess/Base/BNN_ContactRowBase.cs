
// <fileinfo name="Base\BNN_ContactRowBase.cs">
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
/// The base class for <see cref="BNN_ContactRow"/> that 
/// represents a record in the <c>BNN_Contact</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="BNN_ContactRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_ContactRowBase
{
	/// _contact_ID
	private int _contact_ID;
	private bool _contact_IDNull = true;
	/// _fullName
	private string _fullName;
	private bool _fullNameNull = true;
	/// _workUnit
	private string _workUnit;
	private bool _workUnitNull = true;
	/// _address
	private string _address;
	private bool _addressNull = true;
	/// _phone
	private string _phone;
	private bool _phoneNull = true;
	/// _email
	private string _email;
	private bool _emailNull = true;
	/// _iPAddress
	private string _iPAddress;
	private bool _iPAddressNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _modifyDate
	private System.DateTime _modifyDate;
	private bool _modifyDateNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _location_ID
	private int _location_ID;
	private bool _location_IDNull = true;
	/// _district_ID
	private int _district_ID;
	private bool _district_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="BNN_ContactRowBase"/> class.
	/// </summary>
	public BNN_ContactRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Contact_ID</c> column value.
		/// </summary>
		/// <value>The <c>Contact_ID</c> column value.</value>
	public int Contact_ID
	{
		get
		{
			if(IsContact_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _contact_ID;
		}
		set
		{
			_contact_IDNull = false;
			_contact_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Contact_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsContact_IDNull
	{
		get
		{
			return _contact_IDNull;
		}
		set
		{
			_contact_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FullName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FullName</c> column value.</value>
	public string FullName
	{
		get
		{
			if(IsFullNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _fullName;
		}
		set
		{
			_fullNameNull = false;
			_fullName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FullName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFullNameNull
	{
		get
		{
			return _fullNameNull;
		}
		set
		{
			_fullNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WorkUnit</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WorkUnit</c> column value.</value>
	public string WorkUnit
	{
		get
		{
			if(IsWorkUnitNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _workUnit;
		}
		set
		{
			_workUnitNull = false;
			_workUnit = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WorkUnit"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWorkUnitNull
	{
		get
		{
			return _workUnitNull;
		}
		set
		{
			_workUnitNull = value;
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
		/// Gets or sets the <c>IPAddress</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IPAddress</c> column value.</value>
	public string IPAddress
	{
		get
		{
			if(IsIPAddressNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _iPAddress;
		}
		set
		{
			_iPAddressNull = false;
			_iPAddress = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="IPAddress"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIPAddressNull
	{
		get
		{
			return _iPAddressNull;
		}
		set
		{
			_iPAddressNull = value;
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
		/// Gets or sets the <c>ModifyDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ModifyDate</c> column value.</value>
	public System.DateTime ModifyDate
	{
		get
		{
			if (IsModifyDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _modifyDate;
		}
		set
		{
			_modifyDateNull = false;
			_modifyDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ModifyDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsModifyDateNull
	{
		get
		{
			return _modifyDateNull;
		}
		set
		{
			_modifyDateNull = value;
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
		/// Gets or sets the <c>Active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
	public int Active
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
		/// Gets or sets the <c>Location_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Location_ID</c> column value.</value>
	public int Location_ID
	{
		get
		{
			if (IsLocation_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _location_ID;
		}
		set
		{
			_location_IDNull = false;
			_location_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Location_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocation_IDNull
	{
		get
		{
			return _location_IDNull;
		}
		set
		{
			_location_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>District_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>District_ID</c> column value.</value>
	public int District_ID
	{
		get
		{
			if (IsDistrict_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _district_ID;
		}
		set
		{
			_district_IDNull = false;
			_district_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="District_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDistrict_IDNull
	{
		get
		{
			return _district_IDNull;
		}
		set
		{
			_district_IDNull = value;
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
		// Contact_ID
		dynStr.Append("  Contact_ID=");
		if( IsContact_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Contact_ID);
		

		// FullName
		dynStr.Append("  FullName=");
		if( IsFullNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FullName);
		

		// WorkUnit
		dynStr.Append("  WorkUnit=");
		if( IsWorkUnitNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WorkUnit);
		

		// Address
		dynStr.Append("  Address=");
		if( IsAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Address);
		

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
		

		// IPAddress
		dynStr.Append("  IPAddress=");
		if( IsIPAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.IPAddress);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		// ModifyDate
		dynStr.Append("  ModifyDate=");
		if( IsModifyDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ModifyDate);
		// CreateBy
		dynStr.Append("  CreateBy=");
		if( IsCreateByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateBy);
		// LastEditBy
		dynStr.Append("  LastEditBy=");
		if( IsLastEditByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditBy);
		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// Location_ID
		dynStr.Append("  Location_ID=");
		if( IsLocation_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Location_ID);
		// District_ID
		dynStr.Append("  District_ID=");
		if( IsDistrict_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.District_ID);
		return dynStr.ToString();
	}
}
}




