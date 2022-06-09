
// <fileinfo name="Base\PageFunctionRowBase.cs">
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
/// The base class for <see cref="PageFunctionRow"/> that 
/// represents a record in the <c>PageFunction</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="PageFunctionRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class PageFunctionRowBase
{
	/// _pageFunction_ID
	private int _pageFunction_ID;
	private bool _pageFunction_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _url
	private string _url;
	private bool _urlNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;
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
	/// _function_ID
	private int _function_ID;
	private bool _function_IDNull = true;
	/// _displayMenu
	private int _displayMenu;
	private bool _displayMenuNull = true;
	/// _folder
	private string _folder;
	private bool _folderNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="PageFunctionRowBase"/> class.
	/// </summary>
	public PageFunctionRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>PageFunction_ID</c> column value.
		/// </summary>
		/// <value>The <c>PageFunction_ID</c> column value.</value>
	public int PageFunction_ID
	{
		get
		{
			if(IsPageFunction_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _pageFunction_ID;
		}
		set
		{
			_pageFunction_IDNull = false;
			_pageFunction_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PageFunction_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPageFunction_IDNull
	{
		get
		{
			return _pageFunction_IDNull;
		}
		set
		{
			_pageFunction_IDNull = value;
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
		/// Gets or sets the <c>Function_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Function_ID</c> column value.</value>
	public int Function_ID
	{
		get
		{
			if (IsFunction_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _function_ID;
		}
		set
		{
			_function_IDNull = false;
			_function_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Function_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFunction_IDNull
	{
		get
		{
			return _function_IDNull;
		}
		set
		{
			_function_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DisplayMenu</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DisplayMenu</c> column value.</value>
	public int DisplayMenu
	{
		get
		{
			if (IsDisplayMenuNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _displayMenu;
		}
		set
		{
			_displayMenuNull = false;
			_displayMenu = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DisplayMenu"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDisplayMenuNull
	{
		get
		{
			return _displayMenuNull;
		}
		set
		{
			_displayMenuNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Folder</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Folder</c> column value.</value>
	public string Folder
	{
		get
		{
			if(IsFolderNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _folder;
		}
		set
		{
			_folderNull = false;
			_folder = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Folder"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFolderNull
	{
		get
		{
			return _folderNull;
		}
		set
		{
			_folderNull = value;
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
		// PageFunction_ID
		dynStr.Append("  PageFunction_ID=");
		if( IsPageFunction_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PageFunction_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Url
		dynStr.Append("  Url=");
		if( IsUrlNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Url);
		

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
		// Function_ID
		dynStr.Append("  Function_ID=");
		if( IsFunction_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Function_ID);
		// DisplayMenu
		dynStr.Append("  DisplayMenu=");
		if( IsDisplayMenuNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.DisplayMenu);
		// Folder
		dynStr.Append("  Folder=");
		if( IsFolderNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Folder);
		

		return dynStr.ToString();
	}
}
}




