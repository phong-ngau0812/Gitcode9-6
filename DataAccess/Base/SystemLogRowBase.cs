
// <fileinfo name="Base\SystemLogRowBase.cs">
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
/// The base class for <see cref="SystemLogRow"/> that 
/// represents a record in the <c>SystemLog</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="SystemLogRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SystemLogRowBase
{
	/// _systemLog_ID
	private int _systemLog_ID;
	private bool _systemLog_IDNull = true;
	/// _systemLogType_ID
	private int _systemLogType_ID;
	private bool _systemLogType_IDNull = true;
	/// _iD_Object
	private int _iD_Object;
	private bool _iD_ObjectNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _url
	private string _url;
	private bool _urlNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _departmentProductBrand_ID
	private int _departmentProductBrand_ID;
	private bool _departmentProductBrand_IDNull = true;
	/// _userName
	private string _userName;
	private bool _userNameNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="SystemLogRowBase"/> class.
	/// </summary>
	public SystemLogRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>SystemLog_ID</c> column value.
		/// </summary>
		/// <value>The <c>SystemLog_ID</c> column value.</value>
	public int SystemLog_ID
	{
		get
		{
			if(IsSystemLog_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _systemLog_ID;
		}
		set
		{
			_systemLog_IDNull = false;
			_systemLog_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SystemLog_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSystemLog_IDNull
	{
		get
		{
			return _systemLog_IDNull;
		}
		set
		{
			_systemLog_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SystemLogType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SystemLogType_ID</c> column value.</value>
	public int SystemLogType_ID
	{
		get
		{
			if (IsSystemLogType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _systemLogType_ID;
		}
		set
		{
			_systemLogType_IDNull = false;
			_systemLogType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SystemLogType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSystemLogType_IDNull
	{
		get
		{
			return _systemLogType_IDNull;
		}
		set
		{
			_systemLogType_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ID_Object</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ID_Object</c> column value.</value>
	public int ID_Object
	{
		get
		{
			if (IsID_ObjectNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _iD_Object;
		}
		set
		{
			_iD_ObjectNull = false;
			_iD_Object = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ID_Object"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsID_ObjectNull
	{
		get
		{
			return _iD_ObjectNull;
		}
		set
		{
			_iD_ObjectNull = value;
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
		/// Gets or sets the <c>URL</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>URL</c> column value.</value>
	public string URL
	{
		get
		{
			if(IsURLNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _url;
		}
		set
		{
			_urlNull = false;
			_url = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="URL"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsURLNull
	{
		get
		{
			return _urlNull;
		}
		set
		{
			_urlNull = value;
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
		/// Gets or sets the <c>DepartmentProductBrand_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DepartmentProductBrand_ID</c> column value.</value>
	public int DepartmentProductBrand_ID
	{
		get
		{
			if (IsDepartmentProductBrand_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _departmentProductBrand_ID;
		}
		set
		{
			_departmentProductBrand_IDNull = false;
			_departmentProductBrand_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DepartmentProductBrand_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDepartmentProductBrand_IDNull
	{
		get
		{
			return _departmentProductBrand_IDNull;
		}
		set
		{
			_departmentProductBrand_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UserName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UserName</c> column value.</value>
	public string UserName
	{
		get
		{
			if(IsUserNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _userName;
		}
		set
		{
			_userNameNull = false;
			_userName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UserName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUserNameNull
	{
		get
		{
			return _userNameNull;
		}
		set
		{
			_userNameNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// SystemLog_ID
		dynStr.Append("  SystemLog_ID=");
		if( IsSystemLog_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SystemLog_ID);
		

		// SystemLogType_ID
		dynStr.Append("  SystemLogType_ID=");
		if( IsSystemLogType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.SystemLogType_ID);
		// ID_Object
		dynStr.Append("  ID_Object=");
		if( IsID_ObjectNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ID_Object);
		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// URL
		dynStr.Append("  URL=");
		if( IsURLNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.URL);
		

		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// DepartmentProductBrand_ID
		dynStr.Append("  DepartmentProductBrand_ID=");
		if( IsDepartmentProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.DepartmentProductBrand_ID);
		// UserName
		dynStr.Append("  UserName=");
		if( IsUserNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UserName);
		

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
		return dynStr.ToString();
	}
}
}




