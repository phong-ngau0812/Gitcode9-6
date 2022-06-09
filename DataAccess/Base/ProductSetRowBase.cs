
// <fileinfo name="Base\ProductSetRowBase.cs">
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
/// The base class for <see cref="ProductSetRow"/> that 
/// represents a record in the <c>ProductSet</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductSetRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductSetRowBase
{
	/// _productSet_ID
	private int _productSet_ID;
	private bool _productSet_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
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
	/// _warrantyDate
	private int _warrantyDate;
	private bool _warrantyDateNull = true;
	/// _keyWord
	private string _keyWord;
	private bool _keyWordNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductSetRowBase"/> class.
	/// </summary>
	public ProductSetRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductSet_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductSet_ID</c> column value.</value>
	public int ProductSet_ID
	{
		get
		{
			if(IsProductSet_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productSet_ID;
		}
		set
		{
			_productSet_IDNull = false;
			_productSet_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductSet_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductSet_IDNull
	{
		get
		{
			return _productSet_IDNull;
		}
		set
		{
			_productSet_IDNull = value;
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
		/// Gets or sets the <c>WarrantyDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WarrantyDate</c> column value.</value>
	public int WarrantyDate
	{
		get
		{
			if (IsWarrantyDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warrantyDate;
		}
		set
		{
			_warrantyDateNull = false;
			_warrantyDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarrantyDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarrantyDateNull
	{
		get
		{
			return _warrantyDateNull;
		}
		set
		{
			_warrantyDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>KeyWord</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>KeyWord</c> column value.</value>
	public string KeyWord
	{
		get
		{
			if(IsKeyWordNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _keyWord;
		}
		set
		{
			_keyWordNull = false;
			_keyWord = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="KeyWord"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsKeyWordNull
	{
		get
		{
			return _keyWordNull;
		}
		set
		{
			_keyWordNull = value;
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
		// ProductSet_ID
		dynStr.Append("  ProductSet_ID=");
		if( IsProductSet_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductSet_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

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
		// WarrantyDate
		dynStr.Append("  WarrantyDate=");
		if( IsWarrantyDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WarrantyDate);
		// KeyWord
		dynStr.Append("  KeyWord=");
		if( IsKeyWordNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.KeyWord);
		

		return dynStr.ToString();
	}
}
}




