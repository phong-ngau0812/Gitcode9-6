
// <fileinfo name="Base\NotificationRowBase.cs">
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
/// The base class for <see cref="NotificationRow"/> that 
/// represents a record in the <c>Notification</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="NotificationRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class NotificationRowBase
{
	/// _notification_ID
	private int _notification_ID;
	private bool _notification_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _summary
	private string _summary;
	private bool _summaryNull = true;
	/// _body
	private string _body;
	private bool _bodyNull = true;
	/// _notificationType_ID
	private int _notificationType_ID;
	private bool _notificationType_IDNull = true;
	/// _userID
	private System.Guid _userID;
	private bool _userIDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _department_ID
	private int _department_ID;
	private bool _department_IDNull = true;
	/// _zone_ID
	private int _zone_ID;
	private bool _zone_IDNull = true;
	/// _area_ID
	private int _area_ID;
	private bool _area_IDNull = true;
	/// _farm_ID
	private int _farm_ID;
	private bool _farm_IDNull = true;
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;
	/// _productPackageOrder_ID
	private int _productPackageOrder_ID;
	private bool _productPackageOrder_IDNull = true;
	/// _url
	private string _url;
	private bool _urlNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;
	/// _alias
	private System.Guid _alias;
	private bool _aliasNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="NotificationRowBase"/> class.
	/// </summary>
	public NotificationRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Notification_ID</c> column value.
		/// </summary>
		/// <value>The <c>Notification_ID</c> column value.</value>
	public int Notification_ID
	{
		get
		{
			if(IsNotification_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _notification_ID;
		}
		set
		{
			_notification_IDNull = false;
			_notification_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Notification_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNotification_IDNull
	{
		get
		{
			return _notification_IDNull;
		}
		set
		{
			_notification_IDNull = value;
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
		/// Gets or sets the <c>Summary</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Summary</c> column value.</value>
	public string Summary
	{
		get
		{
			if(IsSummaryNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _summary;
		}
		set
		{
			_summaryNull = false;
			_summary = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Summary"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSummaryNull
	{
		get
		{
			return _summaryNull;
		}
		set
		{
			_summaryNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Body</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Body</c> column value.</value>
	public string Body
	{
		get
		{
			if(IsBodyNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _body;
		}
		set
		{
			_bodyNull = false;
			_body = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Body"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBodyNull
	{
		get
		{
			return _bodyNull;
		}
		set
		{
			_bodyNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>NotificationType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>NotificationType_ID</c> column value.</value>
	public int NotificationType_ID
	{
		get
		{
			if (IsNotificationType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _notificationType_ID;
		}
		set
		{
			_notificationType_IDNull = false;
			_notificationType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="NotificationType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNotificationType_IDNull
	{
		get
		{
			return _notificationType_IDNull;
		}
		set
		{
			_notificationType_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UserID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UserID</c> column value.</value>
	public System.Guid UserID
	{
		get
		{
			if (IsUserIDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _userID;
		}
		set
		{
			_userIDNull = false;
			_userID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UserID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUserIDNull
	{
		get
		{
			return _userIDNull;
		}
		set
		{
			_userIDNull = value;
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
		/// Gets or sets the <c>Department_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Department_ID</c> column value.</value>
	public int Department_ID
	{
		get
		{
			if (IsDepartment_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _department_ID;
		}
		set
		{
			_department_IDNull = false;
			_department_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Department_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDepartment_IDNull
	{
		get
		{
			return _department_IDNull;
		}
		set
		{
			_department_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Zone_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Zone_ID</c> column value.</value>
	public int Zone_ID
	{
		get
		{
			if (IsZone_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _zone_ID;
		}
		set
		{
			_zone_IDNull = false;
			_zone_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Zone_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsZone_IDNull
	{
		get
		{
			return _zone_IDNull;
		}
		set
		{
			_zone_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Area_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Area_ID</c> column value.</value>
	public int Area_ID
	{
		get
		{
			if (IsArea_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _area_ID;
		}
		set
		{
			_area_IDNull = false;
			_area_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Area_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsArea_IDNull
	{
		get
		{
			return _area_IDNull;
		}
		set
		{
			_area_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Farm_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Farm_ID</c> column value.</value>
	public int Farm_ID
	{
		get
		{
			if (IsFarm_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farm_ID;
		}
		set
		{
			_farm_IDNull = false;
			_farm_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Farm_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarm_IDNull
	{
		get
		{
			return _farm_IDNull;
		}
		set
		{
			_farm_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackage_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackage_ID</c> column value.</value>
	public int ProductPackage_ID
	{
		get
		{
			if (IsProductPackage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackage_ID;
		}
		set
		{
			_productPackage_IDNull = false;
			_productPackage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackage_IDNull
	{
		get
		{
			return _productPackage_IDNull;
		}
		set
		{
			_productPackage_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackageOrder_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackageOrder_ID</c> column value.</value>
	public int ProductPackageOrder_ID
	{
		get
		{
			if (IsProductPackageOrder_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackageOrder_ID;
		}
		set
		{
			_productPackageOrder_IDNull = false;
			_productPackageOrder_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackageOrder_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackageOrder_IDNull
	{
		get
		{
			return _productPackageOrder_IDNull;
		}
		set
		{
			_productPackageOrder_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Url</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Url</c> column value.</value>
	public string Url
	{
		get
		{
			if(IsUrlNull)
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
	/// Indicates whether the <see cref="Url"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUrlNull
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
		/// Gets or sets the <c>Alias</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Alias</c> column value.</value>
	public System.Guid Alias
	{
		get
		{
			if (IsAliasNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _alias;
		}
		set
		{
			_aliasNull = false;
			_alias = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Alias"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAliasNull
	{
		get
		{
			return _aliasNull;
		}
		set
		{
			_aliasNull = value;
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
		// Notification_ID
		dynStr.Append("  Notification_ID=");
		if( IsNotification_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Notification_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Summary
		dynStr.Append("  Summary=");
		if( IsSummaryNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Summary);
		

		// Body
		dynStr.Append("  Body=");
		if( IsBodyNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Body);
		

		// NotificationType_ID
		dynStr.Append("  NotificationType_ID=");
		if( IsNotificationType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.NotificationType_ID);
		// UserID
		dynStr.Append("  UserID=");
		if( IsUserIDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.UserID);
		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// Department_ID
		dynStr.Append("  Department_ID=");
		if( IsDepartment_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Department_ID);
		// Zone_ID
		dynStr.Append("  Zone_ID=");
		if( IsZone_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Zone_ID);
		// Area_ID
		dynStr.Append("  Area_ID=");
		if( IsArea_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Area_ID);
		// Farm_ID
		dynStr.Append("  Farm_ID=");
		if( IsFarm_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Farm_ID);
		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackage_ID);
		// ProductPackageOrder_ID
		dynStr.Append("  ProductPackageOrder_ID=");
		if( IsProductPackageOrder_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackageOrder_ID);
		// Url
		dynStr.Append("  Url=");
		if( IsUrlNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Url);
		

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
		// Alias
		dynStr.Append("  Alias=");
		if( IsAliasNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Alias);
		return dynStr.ToString();
	}
}
}




