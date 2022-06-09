
// <fileinfo name="Base\TagRowBase.cs">
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
/// The base class for <see cref="TagRow"/> that 
/// represents a record in the <c>Tag</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="TagRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class TagRowBase
{
	/// _tag_ID
	private int _tag_ID;
	private bool _tag_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="TagRowBase"/> class.
	/// </summary>
	public TagRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Tag_ID</c> column value.
		/// </summary>
		/// <value>The <c>Tag_ID</c> column value.</value>
	public int Tag_ID
	{
		get
		{
			if(IsTag_IDNull)
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
		// Tag_ID
		dynStr.Append("  Tag_ID=");
		if( IsTag_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Tag_ID);
		

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




