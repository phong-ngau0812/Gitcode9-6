
// <fileinfo name="Base\DepartmentManRowBase.cs">
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
/// The base class for <see cref="DepartmentManRow"/> that 
/// represents a record in the <c>DepartmentMan</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="DepartmentManRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class DepartmentManRowBase
{
	/// _departmentMan_ID
	private int _departmentMan_ID;
	private bool _departmentMan_IDNull = true;
	/// _parent_ID
	private int _parent_ID;
	private bool _parent_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="DepartmentManRowBase"/> class.
	/// </summary>
	public DepartmentManRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>DepartmentMan_ID</c> column value.
		/// </summary>
		/// <value>The <c>DepartmentMan_ID</c> column value.</value>
	public int DepartmentMan_ID
	{
		get
		{
			if(IsDepartmentMan_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _departmentMan_ID;
		}
		set
		{
			_departmentMan_IDNull = false;
			_departmentMan_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DepartmentMan_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDepartmentMan_IDNull
	{
		get
		{
			return _departmentMan_IDNull;
		}
		set
		{
			_departmentMan_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Parent_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Parent_ID</c> column value.</value>
	public int Parent_ID
	{
		get
		{
			if (IsParent_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _parent_ID;
		}
		set
		{
			_parent_IDNull = false;
			_parent_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Parent_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsParent_IDNull
	{
		get
		{
			return _parent_IDNull;
		}
		set
		{
			_parent_IDNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// DepartmentMan_ID
		dynStr.Append("  DepartmentMan_ID=");
		if( IsDepartmentMan_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DepartmentMan_ID);
		

		// Parent_ID
		dynStr.Append("  Parent_ID=");
		if( IsParent_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Parent_ID);
		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Sort
		dynStr.Append("  Sort=");
		if( IsSortNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Sort);
		return dynStr.ToString();
	}
}
}




