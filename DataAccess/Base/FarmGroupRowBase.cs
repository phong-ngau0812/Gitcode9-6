
// <fileinfo name="Base\FarmGroupRowBase.cs">
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
/// The base class for <see cref="FarmGroupRow"/> that 
/// represents a record in the <c>FarmGroup</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="FarmGroupRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class FarmGroupRowBase
{
	/// _farmGroup_ID
	private int _farmGroup_ID;
	private bool _farmGroup_IDNull = true;
	/// _farmGroupInter_ID
	private int _farmGroupInter_ID;
	private bool _farmGroupInter_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _location_ID
	private int _location_ID;
	private bool _location_IDNull = true;
	/// _code
	private string _code;
	private bool _codeNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _address
	private string _address;
	private bool _addressNull = true;
	/// _mobile
	private string _mobile;
	private bool _mobileNull = true;
	/// _email
	private string _email;
	private bool _emailNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
	/// _checkDomain
	private string _checkDomain;
	private bool _checkDomainNull = true;
	/// _checkServer_ID
	private int _checkServer_ID;
	private bool _checkServer_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="FarmGroupRowBase"/> class.
	/// </summary>
	public FarmGroupRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>FarmGroup_ID</c> column value.
		/// </summary>
		/// <value>The <c>FarmGroup_ID</c> column value.</value>
	public int FarmGroup_ID
	{
		get
		{
			if(IsFarmGroup_IDNull)
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
		/// Gets or sets the <c>Mobile</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Mobile</c> column value.</value>
	public string Mobile
	{
		get
		{
			if(IsMobileNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _mobile;
		}
		set
		{
			_mobileNull = false;
			_mobile = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Mobile"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMobileNull
	{
		get
		{
			return _mobileNull;
		}
		set
		{
			_mobileNull = value;
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
		/// Gets or sets the <c>CheckDomain</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CheckDomain</c> column value.</value>
	public string CheckDomain
	{
		get
		{
			if(IsCheckDomainNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _checkDomain;
		}
		set
		{
			_checkDomainNull = false;
			_checkDomain = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CheckDomain"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCheckDomainNull
	{
		get
		{
			return _checkDomainNull;
		}
		set
		{
			_checkDomainNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CheckServer_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CheckServer_ID</c> column value.</value>
	public int CheckServer_ID
	{
		get
		{
			if (IsCheckServer_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _checkServer_ID;
		}
		set
		{
			_checkServer_IDNull = false;
			_checkServer_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CheckServer_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCheckServer_IDNull
	{
		get
		{
			return _checkServer_IDNull;
		}
		set
		{
			_checkServer_IDNull = value;
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
		// FarmGroup_ID
		dynStr.Append("  FarmGroup_ID=");
		if( IsFarmGroup_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FarmGroup_ID);
		

		// FarmGroupInter_ID
		dynStr.Append("  FarmGroupInter_ID=");
		if( IsFarmGroupInter_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.FarmGroupInter_ID);
		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// Location_ID
		dynStr.Append("  Location_ID=");
		if( IsLocation_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Location_ID);
		// Code
		dynStr.Append("  Code=");
		if( IsCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Code);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Address
		dynStr.Append("  Address=");
		if( IsAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Address);
		

		// Mobile
		dynStr.Append("  Mobile=");
		if( IsMobileNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Mobile);
		

		// Email
		dynStr.Append("  Email=");
		if( IsEmailNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Email);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// CheckDomain
		dynStr.Append("  CheckDomain=");
		if( IsCheckDomainNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CheckDomain);
		

		// CheckServer_ID
		dynStr.Append("  CheckServer_ID=");
		if( IsCheckServer_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CheckServer_ID);
		return dynStr.ToString();
	}
}
}




