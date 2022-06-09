
// <fileinfo name="Base\SkinRowBase.cs">
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
/// The base class for <see cref="SkinRow"/> that 
/// represents a record in the <c>Skin</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="SkinRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SkinRowBase
{
	/// _skin_ID
	private int _skin_ID;
	private bool _skin_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="SkinRowBase"/> class.
	/// </summary>
	public SkinRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Skin_ID</c> column value.
		/// </summary>
		/// <value>The <c>Skin_ID</c> column value.</value>
	public int Skin_ID
	{
		get
		{
			if(IsSkin_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _skin_ID;
		}
		set
		{
			_skin_IDNull = false;
			_skin_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Skin_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSkin_IDNull
	{
		get
		{
			return _skin_IDNull;
		}
		set
		{
			_skin_IDNull = value;
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
		// Skin_ID
		dynStr.Append("  Skin_ID=");
		if( IsSkin_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Skin_ID);
		

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




