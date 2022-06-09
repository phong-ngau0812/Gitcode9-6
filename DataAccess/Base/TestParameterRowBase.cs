
// <fileinfo name="Base\TestParameterRowBase.cs">
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
/// The base class for <see cref="TestParameterRow"/> that 
/// represents a record in the <c>TestParameter</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="TestParameterRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class TestParameterRowBase
{
	/// _testParameter_ID
	private int _testParameter_ID;
	private bool _testParameter_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _unit
	private string _unit;
	private bool _unitNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _testTutorial
	private string _testTutorial;
	private bool _testTutorialNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="TestParameterRowBase"/> class.
	/// </summary>
	public TestParameterRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>TestParameter_ID</c> column value.
		/// </summary>
		/// <value>The <c>TestParameter_ID</c> column value.</value>
	public int TestParameter_ID
	{
		get
		{
			if(IsTestParameter_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _testParameter_ID;
		}
		set
		{
			_testParameter_IDNull = false;
			_testParameter_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TestParameter_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTestParameter_IDNull
	{
		get
		{
			return _testParameter_IDNull;
		}
		set
		{
			_testParameter_IDNull = value;
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
		/// Gets or sets the <c>Unit</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Unit</c> column value.</value>
	public string Unit
	{
		get
		{
			if(IsUnitNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _unit;
		}
		set
		{
			_unitNull = false;
			_unit = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Unit"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUnitNull
	{
		get
		{
			return _unitNull;
		}
		set
		{
			_unitNull = value;
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
		/// Gets or sets the <c>TestTutorial</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TestTutorial</c> column value.</value>
	public string TestTutorial
	{
		get
		{
			if(IsTestTutorialNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _testTutorial;
		}
		set
		{
			_testTutorialNull = false;
			_testTutorial = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TestTutorial"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTestTutorialNull
	{
		get
		{
			return _testTutorialNull;
		}
		set
		{
			_testTutorialNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// TestParameter_ID
		dynStr.Append("  TestParameter_ID=");
		if( IsTestParameter_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TestParameter_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Unit
		dynStr.Append("  Unit=");
		if( IsUnitNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Unit);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// TestTutorial
		dynStr.Append("  TestTutorial=");
		if( IsTestTutorialNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TestTutorial);
		

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
		// CreateBy
		dynStr.Append("  CreateBy=");
		if( IsCreateByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateBy);
		// LastEditDate
		dynStr.Append("  LastEditDate=");
		if( IsLastEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditDate);
		// LastEditBy
		dynStr.Append("  LastEditBy=");
		if( IsLastEditByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditBy);
		return dynStr.ToString();
	}
}
}




