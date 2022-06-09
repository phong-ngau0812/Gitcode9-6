
// <fileinfo name="Base\ProductStandardRowBase.cs">
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
/// The base class for <see cref="ProductStandardRow"/> that 
/// represents a record in the <c>ProductStandard</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductStandardRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductStandardRowBase
{
	/// _productStandard_ID
	private int _productStandard_ID;
	private bool _productStandard_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _createdDate
	private System.DateTime _createdDate;
	private bool _createdDateNull = true;
	/// _createdBy
	private string _createdBy;
	private bool _createdByNull = true;
	/// _other1
	private string _other1;
	private bool _other1Null = true;
	/// _other2
	private string _other2;
	private bool _other2Null = true;
	/// _other3
	private string _other3;
	private bool _other3Null = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductStandardRowBase"/> class.
	/// </summary>
	public ProductStandardRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductStandard_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductStandard_ID</c> column value.</value>
	public int ProductStandard_ID
	{
		get
		{
			if (IsProductStandard_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productStandard_ID;
		}
		set
		{
			_productStandard_IDNull = false;
			_productStandard_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductStandard_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductStandard_IDNull
	{
		get
		{
			return _productStandard_IDNull;
		}
		set
		{
			_productStandard_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Product_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Product_ID</c> column value.</value>
	public int Product_ID
	{
		get
		{
			if (IsProduct_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _product_ID;
		}
		set
		{
			_product_IDNull = false;
			_product_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Product_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProduct_IDNull
	{
		get
		{
			return _product_IDNull;
		}
		set
		{
			_product_IDNull = value;
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
		/// Gets or sets the <c>CreatedDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CreatedDate</c> column value.</value>
	public System.DateTime CreatedDate
	{
		get
		{
			if (IsCreatedDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _createdDate;
		}
		set
		{
			_createdDateNull = false;
			_createdDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CreatedDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCreatedDateNull
	{
		get
		{
			return _createdDateNull;
		}
		set
		{
			_createdDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CreatedBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CreatedBy</c> column value.</value>
	public string CreatedBy
	{
		get
		{
			if(IsCreatedByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _createdBy;
		}
		set
		{
			_createdByNull = false;
			_createdBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CreatedBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCreatedByNull
	{
		get
		{
			return _createdByNull;
		}
		set
		{
			_createdByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>other1</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>other1</c> column value.</value>
	public string Other1
	{
		get
		{
			if(IsOther1Null)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _other1;
		}
		set
		{
			_other1Null = false;
			_other1 = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Other1"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOther1Null
	{
		get
		{
			return _other1Null;
		}
		set
		{
			_other1Null = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>other2</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>other2</c> column value.</value>
	public string Other2
	{
		get
		{
			if(IsOther2Null)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _other2;
		}
		set
		{
			_other2Null = false;
			_other2 = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Other2"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOther2Null
	{
		get
		{
			return _other2Null;
		}
		set
		{
			_other2Null = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>other3</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>other3</c> column value.</value>
	public string Other3
	{
		get
		{
			if(IsOther3Null)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _other3;
		}
		set
		{
			_other3Null = false;
			_other3 = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Other3"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOther3Null
	{
		get
		{
			return _other3Null;
		}
		set
		{
			_other3Null = value;
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
		// ProductStandard_ID
		dynStr.Append("  ProductStandard_ID=");
		if( IsProductStandard_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductStandard_ID);
		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID);
		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// CreatedDate
		dynStr.Append("  CreatedDate=");
		if( IsCreatedDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreatedDate);
		// CreatedBy
		dynStr.Append("  CreatedBy=");
		if( IsCreatedByNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CreatedBy);
		

		// Other1
		dynStr.Append("  Other1=");
		if( IsOther1Null)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Other1);
		

		// Other2
		dynStr.Append("  Other2=");
		if( IsOther2Null)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Other2);
		

		// Other3
		dynStr.Append("  Other3=");
		if( IsOther3Null)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Other3);
		

		return dynStr.ToString();
	}
}
}




