
// <fileinfo name="Base\CountryRowBase.cs">
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
/// The base class for <see cref="CountryRow"/> that 
/// represents a record in the <c>Country</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="CountryRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class CountryRowBase
{
	/// _country_ID
	private int _country_ID;
	private bool _country_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="CountryRowBase"/> class.
	/// </summary>
	public CountryRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Country_ID</c> column value.
		/// </summary>
		/// <value>The <c>Country_ID</c> column value.</value>
	public int Country_ID
	{
		get
		{
			if(IsCountry_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _country_ID;
		}
		set
		{
			_country_IDNull = false;
			_country_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Country_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCountry_IDNull
	{
		get
		{
			return _country_IDNull;
		}
		set
		{
			_country_IDNull = value;
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
		// Country_ID
		dynStr.Append("  Country_ID=");
		if( IsCountry_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Country_ID);
		

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




