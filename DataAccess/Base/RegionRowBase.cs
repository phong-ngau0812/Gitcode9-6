
// <fileinfo name="Base\RegionRowBase.cs">
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
/// The base class for <see cref="RegionRow"/> that 
/// represents a record in the <c>Region</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="RegionRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class RegionRowBase
{
	/// _region_ID
	private int _region_ID;
	private bool _region_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="RegionRowBase"/> class.
	/// </summary>
	public RegionRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Region_ID</c> column value.
		/// </summary>
		/// <value>The <c>Region_ID</c> column value.</value>
	public int Region_ID
	{
		get
		{
			if(IsRegion_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _region_ID;
		}
		set
		{
			_region_IDNull = false;
			_region_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Region_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsRegion_IDNull
	{
		get
		{
			return _region_IDNull;
		}
		set
		{
			_region_IDNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// Region_ID
		dynStr.Append("  Region_ID=");
		if( IsRegion_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Region_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		return dynStr.ToString();
	}
}
}




