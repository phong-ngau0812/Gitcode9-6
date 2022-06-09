
// <fileinfo name="Base\TagTypeRowBase.cs">
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
/// The base class for <see cref="TagTypeRow"/> that 
/// represents a record in the <c>TagType</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="TagTypeRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class TagTypeRowBase
{
	/// _tagType_ID
	private int _tagType_ID;
	private bool _tagType_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="TagTypeRowBase"/> class.
	/// </summary>
	public TagTypeRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>TagType_ID</c> column value.
		/// </summary>
		/// <value>The <c>TagType_ID</c> column value.</value>
	public int TagType_ID
	{
		get
		{
			if(IsTagType_IDNull)
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// TagType_ID
		dynStr.Append("  TagType_ID=");
		if( IsTagType_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TagType_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		return dynStr.ToString();
	}
}
}




