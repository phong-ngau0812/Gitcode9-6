
// <fileinfo name="Base\ProductPackageHistoryRowBase.cs">
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
/// The base class for <see cref="ProductPackageHistoryRow"/> that 
/// represents a record in the <c>ProductPackageHistory</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductPackageHistoryRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductPackageHistoryRowBase
{
	/// _productPackageHistory_ID
	private int _productPackageHistory_ID;
	private bool _productPackageHistory_IDNull = true;
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;
	/// _sSCC_Logistic
	private string _sSCC_Logistic;
	private bool _sSCC_LogisticNull = true;
	/// _gLN_Receive
	private string _gLN_Receive;
	private bool _gLN_ReceiveNull = true;
	/// _gLN_From
	private string _gLN_From;
	private bool _gLN_FromNull = true;
	/// _gLN_To
	private string _gLN_To;
	private bool _gLN_ToNull = true;
	/// _deliveryDate
	private System.DateTime _deliveryDate;
	private bool _deliveryDateNull = true;
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


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductPackageHistoryRowBase"/> class.
	/// </summary>
	public ProductPackageHistoryRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackageHistory_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductPackageHistory_ID</c> column value.</value>
	public int ProductPackageHistory_ID
	{
		get
		{
			if(IsProductPackageHistory_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackageHistory_ID;
		}
		set
		{
			_productPackageHistory_IDNull = false;
			_productPackageHistory_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackageHistory_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackageHistory_IDNull
	{
		get
		{
			return _productPackageHistory_IDNull;
		}
		set
		{
			_productPackageHistory_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackage_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackage_ID</c> column value.</value>
	public int ProductPackage_ID
	{
		get
		{
			if (IsProductPackage_IDNull)
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
		/// Gets or sets the <c>SSCC_Logistic</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SSCC_Logistic</c> column value.</value>
	public string SSCC_Logistic
	{
		get
		{
			if(IsSSCC_LogisticNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sSCC_Logistic;
		}
		set
		{
			_sSCC_LogisticNull = false;
			_sSCC_Logistic = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SSCC_Logistic"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSSCC_LogisticNull
	{
		get
		{
			return _sSCC_LogisticNull;
		}
		set
		{
			_sSCC_LogisticNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>GLN_Receive</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GLN_Receive</c> column value.</value>
	public string GLN_Receive
	{
		get
		{
			if(IsGLN_ReceiveNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _gLN_Receive;
		}
		set
		{
			_gLN_ReceiveNull = false;
			_gLN_Receive = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GLN_Receive"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGLN_ReceiveNull
	{
		get
		{
			return _gLN_ReceiveNull;
		}
		set
		{
			_gLN_ReceiveNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>GLN_From</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GLN_From</c> column value.</value>
	public string GLN_From
	{
		get
		{
			if(IsGLN_FromNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _gLN_From;
		}
		set
		{
			_gLN_FromNull = false;
			_gLN_From = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GLN_From"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGLN_FromNull
	{
		get
		{
			return _gLN_FromNull;
		}
		set
		{
			_gLN_FromNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>GLN_To</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GLN_To</c> column value.</value>
	public string GLN_To
	{
		get
		{
			if(IsGLN_ToNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _gLN_To;
		}
		set
		{
			_gLN_ToNull = false;
			_gLN_To = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GLN_To"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGLN_ToNull
	{
		get
		{
			return _gLN_ToNull;
		}
		set
		{
			_gLN_ToNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DeliveryDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DeliveryDate</c> column value.</value>
	public System.DateTime DeliveryDate
	{
		get
		{
			if (IsDeliveryDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _deliveryDate;
		}
		set
		{
			_deliveryDateNull = false;
			_deliveryDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DeliveryDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDeliveryDateNull
	{
		get
		{
			return _deliveryDateNull;
		}
		set
		{
			_deliveryDateNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// ProductPackageHistory_ID
		dynStr.Append("  ProductPackageHistory_ID=");
		if( IsProductPackageHistory_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductPackageHistory_ID);
		

		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackage_ID);
		// SSCC_Logistic
		dynStr.Append("  SSCC_Logistic=");
		if( IsSSCC_LogisticNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SSCC_Logistic);
		

		// GLN_Receive
		dynStr.Append("  GLN_Receive=");
		if( IsGLN_ReceiveNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GLN_Receive);
		

		// GLN_From
		dynStr.Append("  GLN_From=");
		if( IsGLN_FromNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GLN_From);
		

		// GLN_To
		dynStr.Append("  GLN_To=");
		if( IsGLN_ToNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GLN_To);
		

		// DeliveryDate
		dynStr.Append("  DeliveryDate=");
		if( IsDeliveryDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.DeliveryDate);
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
		return dynStr.ToString();
	}
}
}




