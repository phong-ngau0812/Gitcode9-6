
// <fileinfo name="Base\FunctionRowBase.cs">
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
/// The base class for <see cref="FunctionRow"/> that 
/// represents a record in the <c>Function</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="FunctionRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class FunctionRowBase
{
	/// _function_ID
	private int _function_ID;
	private bool _function_IDNull = true;
	/// _functionGroup_ID
	private string _functionGroup_ID;
	private bool _functionGroup_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
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
	/// _functionGroupMenu_ID
	private int _functionGroupMenu_ID;
	private bool _functionGroupMenu_IDNull = true;
	/// _cssClass
	private string _cssClass;
	private bool _cssClassNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="FunctionRowBase"/> class.
	/// </summary>
	public FunctionRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Function_ID</c> column value.
		/// </summary>
		/// <value>The <c>Function_ID</c> column value.</value>
	public int Function_ID
	{
		get
		{
			if(IsFunction_IDNull)
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
		/// Gets or sets the <c>FunctionGroup_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FunctionGroup_ID</c> column value.</value>
	public string FunctionGroup_ID
	{
		get
		{
			if(IsFunctionGroup_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _functionGroup_ID;
		}
		set
		{
			_functionGroup_IDNull = false;
			_functionGroup_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FunctionGroup_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFunctionGroup_IDNull
	{
		get
		{
			return _functionGroup_IDNull;
		}
		set
		{
			_functionGroup_IDNull = value;
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
		/// Gets or sets the <c>FunctionGroupMenu_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FunctionGroupMenu_ID</c> column value.</value>
	public int FunctionGroupMenu_ID
	{
		get
		{
			if (IsFunctionGroupMenu_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _functionGroupMenu_ID;
		}
		set
		{
			_functionGroupMenu_IDNull = false;
			_functionGroupMenu_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FunctionGroupMenu_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFunctionGroupMenu_IDNull
	{
		get
		{
			return _functionGroupMenu_IDNull;
		}
		set
		{
			_functionGroupMenu_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CssClass</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CssClass</c> column value.</value>
	public string CssClass
	{
		get
		{
			if(IsCssClassNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _cssClass;
		}
		set
		{
			_cssClassNull = false;
			_cssClass = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CssClass"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCssClassNull
	{
		get
		{
			return _cssClassNull;
		}
		set
		{
			_cssClassNull = value;
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
		// Function_ID
		dynStr.Append("  Function_ID=");
		if( IsFunction_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Function_ID);
		

		// FunctionGroup_ID
		dynStr.Append("  FunctionGroup_ID=");
		if( IsFunctionGroup_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FunctionGroup_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

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
		// FunctionGroupMenu_ID
		dynStr.Append("  FunctionGroupMenu_ID=");
		if( IsFunctionGroupMenu_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.FunctionGroupMenu_ID);
		// CssClass
		dynStr.Append("  CssClass=");
		if( IsCssClassNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CssClass);
		

		return dynStr.ToString();
	}
}
}




