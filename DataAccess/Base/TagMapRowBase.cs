
// <fileinfo name="Base\TagMapRowBase.cs">
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
/// The base class for <see cref="TagMapRow"/> that 
/// represents a record in the <c>TagMap</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="TagMapRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class TagMapRowBase
{
	/// _tagMap_ID
	private int _tagMap_ID;
	private bool _tagMap_IDNull = true;
	/// _tag_ID
	private int _tag_ID;
	private bool _tag_IDNull = true;
	/// _tagType_ID
	private int _tagType_ID;
	private bool _tagType_IDNull = true;
	/// _value_ID
	private int _value_ID;
	private bool _value_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="TagMapRowBase"/> class.
	/// </summary>
	public TagMapRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>TagMap_ID</c> column value.
		/// </summary>
		/// <value>The <c>TagMap_ID</c> column value.</value>
	public int TagMap_ID
	{
		get
		{
			if(IsTagMap_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _tagMap_ID;
		}
		set
		{
			_tagMap_IDNull = false;
			_tagMap_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TagMap_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTagMap_IDNull
	{
		get
		{
			return _tagMap_IDNull;
		}
		set
		{
			_tagMap_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Tag_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Tag_ID</c> column value.</value>
	public int Tag_ID
	{
		get
		{
			if (IsTag_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _tag_ID;
		}
		set
		{
			_tag_IDNull = false;
			_tag_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Tag_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTag_IDNull
	{
		get
		{
			return _tag_IDNull;
		}
		set
		{
			_tag_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TagType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TagType_ID</c> column value.</value>
	public int TagType_ID
	{
		get
		{
			if (IsTagType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _tagType_ID;
		}
		set
		{
			_tagType_IDNull = false;
			_tagType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TagType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTagType_IDNull
	{
		get
		{
			return _tagType_IDNull;
		}
		set
		{
			_tagType_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Value_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Value_ID</c> column value.</value>
	public int Value_ID
	{
		get
		{
			if (IsValue_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _value_ID;
		}
		set
		{
			_value_IDNull = false;
			_value_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Value_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsValue_IDNull
	{
		get
		{
			return _value_IDNull;
		}
		set
		{
			_value_IDNull = value;
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
		// TagMap_ID
		dynStr.Append("  TagMap_ID=");
		if( IsTagMap_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TagMap_ID);
		

		// Tag_ID
		dynStr.Append("  Tag_ID=");
		if( IsTag_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Tag_ID);
		// TagType_ID
		dynStr.Append("  TagType_ID=");
		if( IsTagType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.TagType_ID);
		// Value_ID
		dynStr.Append("  Value_ID=");
		if( IsValue_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Value_ID);
		return dynStr.ToString();
	}
}
}




