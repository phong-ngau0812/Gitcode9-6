
// <fileinfo name="Base\BNN_CountryRowBase.cs">
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
/// The base class for <see cref="BNN_CountryRow"/> that 
/// represents a record in the <c>BNN_Country</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="BNN_CountryRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_CountryRowBase
{
	/// _country_ID
	private int _country_ID;
	private bool _country_IDNull = true;
	/// _count
	private string _count;
	private bool _countNull = true;
	/// _location
	private string _location;
	private bool _locationNull = true;
	/// _area
	private string _area;
	private bool _areaNull = true;
	/// _climate
	private string _climate;
	private bool _climateNull = true;
	/// _population
	private string _population;
	private bool _populationNull = true;
	/// _videoEmbed
	private string _videoEmbed;
	private bool _videoEmbedNull = true;
	/// _note
	private string _note;
	private bool _noteNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;
	/// _location_ID
	private int _location_ID;
	private bool _location_IDNull = true;
	/// _district_ID
	private int _district_ID;
	private bool _district_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="BNN_CountryRowBase"/> class.
	/// </summary>
	public BNN_CountryRowBase():base()
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
		/// Gets or sets the <c>Count</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Count</c> column value.</value>
	public string Count
	{
		get
		{
			if(IsCountNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _count;
		}
		set
		{
			_countNull = false;
			_count = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Count"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCountNull
	{
		get
		{
			return _countNull;
		}
		set
		{
			_countNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Location</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Location</c> column value.</value>
	public string Location
	{
		get
		{
			if(IsLocationNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _location;
		}
		set
		{
			_locationNull = false;
			_location = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Location"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocationNull
	{
		get
		{
			return _locationNull;
		}
		set
		{
			_locationNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Area</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Area</c> column value.</value>
	public string Area
	{
		get
		{
			if(IsAreaNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _area;
		}
		set
		{
			_areaNull = false;
			_area = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Area"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAreaNull
	{
		get
		{
			return _areaNull;
		}
		set
		{
			_areaNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Climate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Climate</c> column value.</value>
	public string Climate
	{
		get
		{
			if(IsClimateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _climate;
		}
		set
		{
			_climateNull = false;
			_climate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Climate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsClimateNull
	{
		get
		{
			return _climateNull;
		}
		set
		{
			_climateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Population</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Population</c> column value.</value>
	public string Population
	{
		get
		{
			if(IsPopulationNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _population;
		}
		set
		{
			_populationNull = false;
			_population = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Population"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPopulationNull
	{
		get
		{
			return _populationNull;
		}
		set
		{
			_populationNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>VideoEmbed</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>VideoEmbed</c> column value.</value>
	public string VideoEmbed
	{
		get
		{
			if(IsVideoEmbedNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _videoEmbed;
		}
		set
		{
			_videoEmbedNull = false;
			_videoEmbed = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="VideoEmbed"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsVideoEmbedNull
	{
		get
		{
			return _videoEmbedNull;
		}
		set
		{
			_videoEmbedNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Note</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Note</c> column value.</value>
	public string Note
	{
		get
		{
			if(IsNoteNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _note;
		}
		set
		{
			_noteNull = false;
			_note = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Note"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNoteNull
	{
		get
		{
			return _noteNull;
		}
		set
		{
			_noteNull = value;
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
		/// Gets or sets the <c>Location_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Location_ID</c> column value.</value>
	public int Location_ID
	{
		get
		{
			if (IsLocation_IDNull)
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
		/// Gets or sets the <c>District_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>District_ID</c> column value.</value>
	public int District_ID
	{
		get
		{
			if (IsDistrict_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _district_ID;
		}
		set
		{
			_district_IDNull = false;
			_district_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="District_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDistrict_IDNull
	{
		get
		{
			return _district_IDNull;
		}
		set
		{
			_district_IDNull = value;
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
		

		// Count
		dynStr.Append("  Count=");
		if( IsCountNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Count);
		

		// Location
		dynStr.Append("  Location=");
		if( IsLocationNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Location);
		

		// Area
		dynStr.Append("  Area=");
		if( IsAreaNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Area);
		

		// Climate
		dynStr.Append("  Climate=");
		if( IsClimateNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Climate);
		

		// Population
		dynStr.Append("  Population=");
		if( IsPopulationNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Population);
		

		// VideoEmbed
		dynStr.Append("  VideoEmbed=");
		if( IsVideoEmbedNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.VideoEmbed);
		

		// Note
		dynStr.Append("  Note=");
		if( IsNoteNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Note);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		// LastEditDate
		dynStr.Append("  LastEditDate=");
		if( IsLastEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditDate);
		// CreateBy
		dynStr.Append("  CreateBy=");
		if( IsCreateByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateBy);
		// LastEditBy
		dynStr.Append("  LastEditBy=");
		if( IsLastEditByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditBy);
		// Sort
		dynStr.Append("  Sort=");
		if( IsSortNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Sort);
		// Location_ID
		dynStr.Append("  Location_ID=");
		if( IsLocation_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Location_ID);
		// District_ID
		dynStr.Append("  District_ID=");
		if( IsDistrict_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.District_ID);
		return dynStr.ToString();
	}
}
}




