
// <fileinfo name="Base\BNN_RegionVsLocationRowBase.cs">
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
/// The base class for <see cref="BNN_RegionVsLocationRow"/> that 
/// represents a record in the <c>BNN_RegionVsLocation</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="BNN_RegionVsLocationRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_RegionVsLocationRowBase
{
	/// _region_ID
	private int _region_ID;
	private bool _region_IDNull = true;
	/// _location_ID
	private int _location_ID;
	private bool _location_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="BNN_RegionVsLocationRowBase"/> class.
	/// </summary>
	public BNN_RegionVsLocationRowBase():base()
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
		/// Gets or sets the <c>Location_ID</c> column value.
		/// </summary>
		/// <value>The <c>Location_ID</c> column value.</value>
	public int Location_ID
	{
		get
		{
			if(IsLocation_IDNull)
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
		

		// Location_ID
		dynStr.Append("  Location_ID=");
		if( IsLocation_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Location_ID);
		

		return dynStr.ToString();
	}
}
}




