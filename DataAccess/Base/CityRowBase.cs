
// <fileinfo name="Base\CityRowBase.cs">
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
/// The base class for <see cref="CityRow"/> that 
/// represents a record in the <c>City</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="CityRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class CityRowBase
{
	/// _city_ID
	private int _city_ID;
	private bool _city_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;
	/// _code
	private string _code;
	private bool _codeNull = true;
	/// _level
	private string _level;
	private bool _levelNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="CityRowBase"/> class.
	/// </summary>
	public CityRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>City_ID</c> column value.
		/// </summary>
		/// <value>The <c>City_ID</c> column value.</value>
	public int City_ID
	{
		get
		{
			if(IsCity_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _city_ID;
		}
		set
		{
			_city_IDNull = false;
			_city_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="City_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCity_IDNull
	{
		get
		{
			return _city_IDNull;
		}
		set
		{
			_city_IDNull = value;
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
		/// Gets or sets the <c>Level</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Level</c> column value.</value>
	public string Level
	{
		get
		{
			if(IsLevelNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _level;
		}
		set
		{
			_levelNull = false;
			_level = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Level"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLevelNull
	{
		get
		{
			return _levelNull;
		}
		set
		{
			_levelNull = value;
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
		// City_ID
		dynStr.Append("  City_ID=");
		if( IsCity_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.City_ID);
		

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
		// Code
		dynStr.Append("  Code=");
		if( IsCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Code);
		

		// Level
		dynStr.Append("  Level=");
		if( IsLevelNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Level);
		

		return dynStr.ToString();
	}
}
}




