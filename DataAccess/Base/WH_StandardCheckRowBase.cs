
// <fileinfo name="Base\WH_StandardCheckRowBase.cs">
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
/// The base class for <see cref="WH_StandardCheckRow"/> that 
/// represents a record in the <c>WH_StandardCheck</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WH_StandardCheckRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_StandardCheckRowBase
{
	/// _wH_StandardCheck_ID
	private int _wH_StandardCheck_ID;
	private bool _wH_StandardCheck_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _wH_MaterialCategory_ID
	private int _wH_MaterialCategory_ID;
	private bool _wH_MaterialCategory_IDNull = true;
	/// _wH_MaterialList_ID
	private string _wH_MaterialList_ID;
	private bool _wH_MaterialList_IDNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;
	/// _sizeBasic
	private string _sizeBasic;
	private bool _sizeBasicNull = true;
	/// _standardTechnique
	private string _standardTechnique;
	private bool _standardTechniqueNull = true;
	/// _testAndTry
	private string _testAndTry;
	private bool _testAndTryNull = true;
	/// _testParameterList_ID
	private string _testParameterList_ID;
	private bool _testParameterList_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WH_StandardCheckRowBase"/> class.
	/// </summary>
	public WH_StandardCheckRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WH_StandardCheck_ID</c> column value.
		/// </summary>
		/// <value>The <c>WH_StandardCheck_ID</c> column value.</value>
	public int WH_StandardCheck_ID
	{
		get
		{
			if(IsWH_StandardCheck_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_StandardCheck_ID;
		}
		set
		{
			_wH_StandardCheck_IDNull = false;
			_wH_StandardCheck_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_StandardCheck_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_StandardCheck_IDNull
	{
		get
		{
			return _wH_StandardCheck_IDNull;
		}
		set
		{
			_wH_StandardCheck_IDNull = value;
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
		/// Gets or sets the <c>WH_MaterialCategory_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WH_MaterialCategory_ID</c> column value.</value>
	public int WH_MaterialCategory_ID
	{
		get
		{
			if (IsWH_MaterialCategory_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_MaterialCategory_ID;
		}
		set
		{
			_wH_MaterialCategory_IDNull = false;
			_wH_MaterialCategory_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_MaterialCategory_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_MaterialCategory_IDNull
	{
		get
		{
			return _wH_MaterialCategory_IDNull;
		}
		set
		{
			_wH_MaterialCategory_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WH_MaterialList_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WH_MaterialList_ID</c> column value.</value>
	public string WH_MaterialList_ID
	{
		get
		{
			if(IsWH_MaterialList_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_MaterialList_ID;
		}
		set
		{
			_wH_MaterialList_IDNull = false;
			_wH_MaterialList_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_MaterialList_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_MaterialList_IDNull
	{
		get
		{
			return _wH_MaterialList_IDNull;
		}
		set
		{
			_wH_MaterialList_IDNull = value;
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
		/// Gets or sets the <c>Active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
	public bool Active
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
		/// Gets or sets the <c>SizeBasic</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SizeBasic</c> column value.</value>
	public string SizeBasic
	{
		get
		{
			if(IsSizeBasicNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sizeBasic;
		}
		set
		{
			_sizeBasicNull = false;
			_sizeBasic = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SizeBasic"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSizeBasicNull
	{
		get
		{
			return _sizeBasicNull;
		}
		set
		{
			_sizeBasicNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StandardTechnique</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StandardTechnique</c> column value.</value>
	public string StandardTechnique
	{
		get
		{
			if(IsStandardTechniqueNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _standardTechnique;
		}
		set
		{
			_standardTechniqueNull = false;
			_standardTechnique = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StandardTechnique"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStandardTechniqueNull
	{
		get
		{
			return _standardTechniqueNull;
		}
		set
		{
			_standardTechniqueNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TestAndTry</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TestAndTry</c> column value.</value>
	public string TestAndTry
	{
		get
		{
			if(IsTestAndTryNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _testAndTry;
		}
		set
		{
			_testAndTryNull = false;
			_testAndTry = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TestAndTry"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTestAndTryNull
	{
		get
		{
			return _testAndTryNull;
		}
		set
		{
			_testAndTryNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TestParameterList_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TestParameterList_ID</c> column value.</value>
	public string TestParameterList_ID
	{
		get
		{
			if(IsTestParameterList_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _testParameterList_ID;
		}
		set
		{
			_testParameterList_IDNull = false;
			_testParameterList_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TestParameterList_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTestParameterList_IDNull
	{
		get
		{
			return _testParameterList_IDNull;
		}
		set
		{
			_testParameterList_IDNull = value;
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
		// WH_StandardCheck_ID
		dynStr.Append("  WH_StandardCheck_ID=");
		if( IsWH_StandardCheck_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WH_StandardCheck_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// WH_MaterialCategory_ID
		dynStr.Append("  WH_MaterialCategory_ID=");
		if( IsWH_MaterialCategory_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WH_MaterialCategory_ID);
		// WH_MaterialList_ID
		dynStr.Append("  WH_MaterialList_ID=");
		if( IsWH_MaterialList_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WH_MaterialList_ID);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// CreateBy
		dynStr.Append("  CreateBy=");
		if( IsCreateByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateBy);
		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		// LastEditBy
		dynStr.Append("  LastEditBy=");
		if( IsLastEditByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditBy);
		// LastEditDate
		dynStr.Append("  LastEditDate=");
		if( IsLastEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditDate);
		// SizeBasic
		dynStr.Append("  SizeBasic=");
		if( IsSizeBasicNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SizeBasic);
		

		// StandardTechnique
		dynStr.Append("  StandardTechnique=");
		if( IsStandardTechniqueNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.StandardTechnique);
		

		// TestAndTry
		dynStr.Append("  TestAndTry=");
		if( IsTestAndTryNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TestAndTry);
		

		// TestParameterList_ID
		dynStr.Append("  TestParameterList_ID=");
		if( IsTestParameterList_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TestParameterList_ID);
		

		return dynStr.ToString();
	}
}
}




