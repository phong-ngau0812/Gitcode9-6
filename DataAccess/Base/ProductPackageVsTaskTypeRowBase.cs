
// <fileinfo name="Base\ProductPackageVsTaskTypeRowBase.cs">
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
/// The base class for <see cref="ProductPackageVsTaskTypeRow"/> that 
/// represents a record in the <c>ProductPackageVsTaskType</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductPackageVsTaskTypeRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductPackageVsTaskTypeRowBase
{
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;
	/// _taskType_ID
	private int _taskType_ID;
	private bool _taskType_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductPackageVsTaskTypeRowBase"/> class.
	/// </summary>
	public ProductPackageVsTaskTypeRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackage_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductPackage_ID</c> column value.</value>
	public int ProductPackage_ID
	{
		get
		{
			if(IsProductPackage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackage_ID;
		}
		set
		{
			_productPackage_IDNull = false;
			_productPackage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackage_IDNull
	{
		get
		{
			return _productPackage_IDNull;
		}
		set
		{
			_productPackage_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TaskType_ID</c> column value.
		/// </summary>
		/// <value>The <c>TaskType_ID</c> column value.</value>
	public int TaskType_ID
	{
		get
		{
			if(IsTaskType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _taskType_ID;
		}
		set
		{
			_taskType_IDNull = false;
			_taskType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TaskType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTaskType_IDNull
	{
		get
		{
			return _taskType_IDNull;
		}
		set
		{
			_taskType_IDNull = value;
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
		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductPackage_ID);
		

		// TaskType_ID
		dynStr.Append("  TaskType_ID=");
		if( IsTaskType_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TaskType_ID);
		

		return dynStr.ToString();
	}
}
}




