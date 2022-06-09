
// <fileinfo name="Base\QRCodePackageFragment_ESRowBase.cs">
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
/// The base class for <see cref="QRCodePackageFragment_ESRow"/> that 
/// represents a record in the <c>QRCodePackageFragment_ES</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="QRCodePackageFragment_ESRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodePackageFragment_ESRowBase
{
	/// _qRCodePackageFragment_ID
	private int _qRCodePackageFragment_ID;
	private bool _qRCodePackageFragment_IDNull = true;
	/// _qRCodePackage_ID
	private int _qRCodePackage_ID;
	private bool _qRCodePackage_IDNull = true;
	/// _serialNumberStart
	private string _serialNumberStart;
	private bool _serialNumberStartNull = true;
	/// _serialNumberEnd
	private string _serialNumberEnd;
	private bool _serialNumberEndNull = true;
	/// _qRCodeNumber
	private int _qRCodeNumber;
	private bool _qRCodeNumberNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="QRCodePackageFragment_ESRowBase"/> class.
	/// </summary>
	public QRCodePackageFragment_ESRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>QRCodePackageFragment_ID</c> column value.
		/// </summary>
		/// <value>The <c>QRCodePackageFragment_ID</c> column value.</value>
	public int QRCodePackageFragment_ID
	{
		get
		{
			if(IsQRCodePackageFragment_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodePackageFragment_ID;
		}
		set
		{
			_qRCodePackageFragment_IDNull = false;
			_qRCodePackageFragment_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodePackageFragment_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodePackageFragment_IDNull
	{
		get
		{
			return _qRCodePackageFragment_IDNull;
		}
		set
		{
			_qRCodePackageFragment_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCodePackage_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodePackage_ID</c> column value.</value>
	public int QRCodePackage_ID
	{
		get
		{
			if (IsQRCodePackage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodePackage_ID;
		}
		set
		{
			_qRCodePackage_IDNull = false;
			_qRCodePackage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodePackage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodePackage_IDNull
	{
		get
		{
			return _qRCodePackage_IDNull;
		}
		set
		{
			_qRCodePackage_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SerialNumberStart</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SerialNumberStart</c> column value.</value>
	public string SerialNumberStart
	{
		get
		{
			if(IsSerialNumberStartNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _serialNumberStart;
		}
		set
		{
			_serialNumberStartNull = false;
			_serialNumberStart = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SerialNumberStart"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSerialNumberStartNull
	{
		get
		{
			return _serialNumberStartNull;
		}
		set
		{
			_serialNumberStartNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SerialNumberEnd</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SerialNumberEnd</c> column value.</value>
	public string SerialNumberEnd
	{
		get
		{
			if(IsSerialNumberEndNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _serialNumberEnd;
		}
		set
		{
			_serialNumberEndNull = false;
			_serialNumberEnd = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SerialNumberEnd"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSerialNumberEndNull
	{
		get
		{
			return _serialNumberEndNull;
		}
		set
		{
			_serialNumberEndNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeNumber</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodeNumber</c> column value.</value>
	public int QRCodeNumber
	{
		get
		{
			if (IsQRCodeNumberNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeNumber;
		}
		set
		{
			_qRCodeNumberNull = false;
			_qRCodeNumber = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeNumber"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeNumberNull
	{
		get
		{
			return _qRCodeNumberNull;
		}
		set
		{
			_qRCodeNumberNull = value;
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
		// QRCodePackageFragment_ID
		dynStr.Append("  QRCodePackageFragment_ID=");
		if( IsQRCodePackageFragment_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodePackageFragment_ID);
		

		// QRCodePackage_ID
		dynStr.Append("  QRCodePackage_ID=");
		if( IsQRCodePackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodePackage_ID);
		// SerialNumberStart
		dynStr.Append("  SerialNumberStart=");
		if( IsSerialNumberStartNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SerialNumberStart);
		

		// SerialNumberEnd
		dynStr.Append("  SerialNumberEnd=");
		if( IsSerialNumberEndNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SerialNumberEnd);
		

		// QRCodeNumber
		dynStr.Append("  QRCodeNumber=");
		if( IsQRCodeNumberNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.QRCodeNumber);
		return dynStr.ToString();
	}
}
}




