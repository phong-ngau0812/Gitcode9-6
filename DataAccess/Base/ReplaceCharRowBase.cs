
// <fileinfo name="Base\ReplaceCharRowBase.cs">
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
/// The base class for <see cref="ReplaceCharRow"/> that 
/// represents a record in the <c>ReplaceChar</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ReplaceCharRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ReplaceCharRowBase
{
	/// _replaceChar_ID
	private int _replaceChar_ID;
	private bool _replaceChar_IDNull = true;
	/// _oldChar
	private string _oldChar;
	private bool _oldCharNull = true;
	/// _newChar
	private string _newChar;
	private bool _newCharNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ReplaceCharRowBase"/> class.
	/// </summary>
	public ReplaceCharRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ReplaceChar_ID</c> column value.
		/// </summary>
		/// <value>The <c>ReplaceChar_ID</c> column value.</value>
	public int ReplaceChar_ID
	{
		get
		{
			if(IsReplaceChar_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _replaceChar_ID;
		}
		set
		{
			_replaceChar_IDNull = false;
			_replaceChar_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ReplaceChar_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsReplaceChar_IDNull
	{
		get
		{
			return _replaceChar_IDNull;
		}
		set
		{
			_replaceChar_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>OldChar</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>OldChar</c> column value.</value>
	public string OldChar
	{
		get
		{
			if(IsOldCharNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _oldChar;
		}
		set
		{
			_oldCharNull = false;
			_oldChar = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="OldChar"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOldCharNull
	{
		get
		{
			return _oldCharNull;
		}
		set
		{
			_oldCharNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>NewChar</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>NewChar</c> column value.</value>
	public string NewChar
	{
		get
		{
			if(IsNewCharNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _newChar;
		}
		set
		{
			_newCharNull = false;
			_newChar = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="NewChar"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNewCharNull
	{
		get
		{
			return _newCharNull;
		}
		set
		{
			_newCharNull = value;
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
		// ReplaceChar_ID
		dynStr.Append("  ReplaceChar_ID=");
		if( IsReplaceChar_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ReplaceChar_ID);
		

		// OldChar
		dynStr.Append("  OldChar=");
		if( IsOldCharNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.OldChar);
		

		// NewChar
		dynStr.Append("  NewChar=");
		if( IsNewCharNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.NewChar);
		

		return dynStr.ToString();
	}
}
}




