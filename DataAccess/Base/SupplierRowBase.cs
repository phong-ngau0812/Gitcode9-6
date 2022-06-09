
// <fileinfo name="Base\SupplierRowBase.cs">
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
/// The base class for <see cref="SupplierRow"/> that 
/// represents a record in the <c>Supplier</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="SupplierRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SupplierRowBase
{
	/// _supplier_ID
	private int _supplier_ID;
	private bool _supplier_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _website
	private string _website;
	private bool _websiteNull = true;
	/// _address
	private string _address;
	private bool _addressNull = true;
	/// _avatarUrl
	private string _avatarUrl;
	private bool _avatarUrlNull = true;
	/// _email
	private string _email;
	private bool _emailNull = true;
	/// _phone
	private string _phone;
	private bool _phoneNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditedBy
	private System.Guid _lastEditedBy;
	private bool _lastEditedByNull = true;
	/// _lastEditedDate
	private System.DateTime _lastEditedDate;
	private bool _lastEditedDateNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _gdti
	private string _gdti;
	private bool _gdtiNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="SupplierRowBase"/> class.
	/// </summary>
	public SupplierRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Supplier_ID</c> column value.
		/// </summary>
		/// <value>The <c>Supplier_ID</c> column value.</value>
	public int Supplier_ID
	{
		get
		{
			if(IsSupplier_IDNull)
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
		/// Gets or sets the <c>Website</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Website</c> column value.</value>
	public string Website
	{
		get
		{
			if(IsWebsiteNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _website;
		}
		set
		{
			_websiteNull = false;
			_website = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Website"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWebsiteNull
	{
		get
		{
			return _websiteNull;
		}
		set
		{
			_websiteNull = value;
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
		/// Gets or sets the <c>AvatarUrl</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AvatarUrl</c> column value.</value>
	public string AvatarUrl
	{
		get
		{
			if(IsAvatarUrlNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _avatarUrl;
		}
		set
		{
			_avatarUrlNull = false;
			_avatarUrl = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AvatarUrl"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAvatarUrlNull
	{
		get
		{
			return _avatarUrlNull;
		}
		set
		{
			_avatarUrlNull = value;
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
		/// Gets or sets the <c>LastEditedBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditedBy</c> column value.</value>
	public System.Guid LastEditedBy
	{
		get
		{
			if (IsLastEditedByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditedBy;
		}
		set
		{
			_lastEditedByNull = false;
			_lastEditedBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditedBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditedByNull
	{
		get
		{
			return _lastEditedByNull;
		}
		set
		{
			_lastEditedByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LastEditedDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditedDate</c> column value.</value>
	public System.DateTime LastEditedDate
	{
		get
		{
			if (IsLastEditedDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditedDate;
		}
		set
		{
			_lastEditedDateNull = false;
			_lastEditedDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditedDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditedDateNull
	{
		get
		{
			return _lastEditedDateNull;
		}
		set
		{
			_lastEditedDateNull = value;
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
		/// Gets or sets the <c>Sort</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Sort</c> column value.</value>
	public int Sort
	{
		get
		{
			if (IsSortNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sort;
		}
		set
		{
			_sortNull = false;
			_sort = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Sort"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSortNull
	{
		get
		{
			return _sortNull;
		}
		set
		{
			_sortNull = value;
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
		/// Gets or sets the <c>GDTI</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GDTI</c> column value.</value>
	public string GDTI
	{
		get
		{
			if(IsGDTINull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _gdti;
		}
		set
		{
			_gdtiNull = false;
			_gdti = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GDTI"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGDTINull
	{
		get
		{
			return _gdtiNull;
		}
		set
		{
			_gdtiNull = value;
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
		// Supplier_ID
		dynStr.Append("  Supplier_ID=");
		if( IsSupplier_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Supplier_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Website
		dynStr.Append("  Website=");
		if( IsWebsiteNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Website);
		

		// Address
		dynStr.Append("  Address=");
		if( IsAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Address);
		

		// AvatarUrl
		dynStr.Append("  AvatarUrl=");
		if( IsAvatarUrlNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.AvatarUrl);
		

		// Email
		dynStr.Append("  Email=");
		if( IsEmailNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Email);
		

		// Phone
		dynStr.Append("  Phone=");
		if( IsPhoneNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Phone);
		

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
		// LastEditedBy
		dynStr.Append("  LastEditedBy=");
		if( IsLastEditedByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditedBy);
		// LastEditedDate
		dynStr.Append("  LastEditedDate=");
		if( IsLastEditedDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditedDate);
		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// Sort
		dynStr.Append("  Sort=");
		if( IsSortNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Sort);
		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// GDTI
		dynStr.Append("  GDTI=");
		if( IsGDTINull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GDTI);
		

		return dynStr.ToString();
	}
}
}




