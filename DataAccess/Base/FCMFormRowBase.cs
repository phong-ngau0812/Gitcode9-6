
// <fileinfo name="Base\FCMFormRowBase.cs">
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
/// The base class for <see cref="FCMFormRow"/> that 
/// represents a record in the <c>FCMForm</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="FCMFormRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class FCMFormRowBase
{
	/// _form_ID
	private int _form_ID;
	private bool _form_IDNull = true;
	/// _formName
	private string _formName;
	private bool _formNameNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="FCMFormRowBase"/> class.
	/// </summary>
	public FCMFormRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Form_ID</c> column value.
		/// </summary>
		/// <value>The <c>Form_ID</c> column value.</value>
	public int Form_ID
	{
		get
		{
			if(IsForm_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _form_ID;
		}
		set
		{
			_form_IDNull = false;
			_form_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Form_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsForm_IDNull
	{
		get
		{
			return _form_IDNull;
		}
		set
		{
			_form_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FormName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FormName</c> column value.</value>
	public string FormName
	{
		get
		{
			if(IsFormNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _formName;
		}
		set
		{
			_formNameNull = false;
			_formName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FormName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFormNameNull
	{
		get
		{
			return _formNameNull;
		}
		set
		{
			_formNameNull = value;
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
		// Form_ID
		dynStr.Append("  Form_ID=");
		if( IsForm_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Form_ID);
		

		// FormName
		dynStr.Append("  FormName=");
		if( IsFormNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FormName);
		

		return dynStr.ToString();
	}
}
}




