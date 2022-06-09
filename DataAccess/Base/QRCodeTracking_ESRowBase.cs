
// <fileinfo name="Base\QRCodeTracking_ESRowBase.cs">
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
/// The base class for <see cref="QRCodeTracking_ESRow"/> that 
/// represents a record in the <c>QRCodeTracking_ES</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="QRCodeTracking_ESRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodeTracking_ESRowBase
{
	/// _qRCodeTracking_ID
	private decimal _qRCodeTracking_ID;
	private bool _qRCodeTracking_IDNull = true;
	/// _qRCodeSerial
	private string _qRCodeSerial;
	private bool _qRCodeSerialNull = true;
	/// _qRCodeContent
	private string _qRCodeContent;
	private bool _qRCodeContentNull = true;
	/// _type
	private string _type;
	private bool _typeNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _ip
	private string _ip;
	private bool _ipNull = true;
	/// _location
	private string _location;
	private bool _locationNull = true;
	/// _trackingDate
	private System.DateTime _trackingDate;
	private bool _trackingDateNull = true;
	/// _status
	private int _status;
	private bool _statusNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="QRCodeTracking_ESRowBase"/> class.
	/// </summary>
	public QRCodeTracking_ESRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeTracking_ID</c> column value.
		/// </summary>
		/// <value>The <c>QRCodeTracking_ID</c> column value.</value>
	public decimal QRCodeTracking_ID
	{
		get
		{
			if(IsQRCodeTracking_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeTracking_ID;
		}
		set
		{
			_qRCodeTracking_IDNull = false;
			_qRCodeTracking_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeTracking_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeTracking_IDNull
	{
		get
		{
			return _qRCodeTracking_IDNull;
		}
		set
		{
			_qRCodeTracking_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeSerial</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodeSerial</c> column value.</value>
	public string QRCodeSerial
	{
		get
		{
			if(IsQRCodeSerialNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeSerial;
		}
		set
		{
			_qRCodeSerialNull = false;
			_qRCodeSerial = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeSerial"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeSerialNull
	{
		get
		{
			return _qRCodeSerialNull;
		}
		set
		{
			_qRCodeSerialNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCodeContent</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodeContent</c> column value.</value>
	public string QRCodeContent
	{
		get
		{
			if(IsQRCodeContentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodeContent;
		}
		set
		{
			_qRCodeContentNull = false;
			_qRCodeContent = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodeContent"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeContentNull
	{
		get
		{
			return _qRCodeContentNull;
		}
		set
		{
			_qRCodeContentNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Type</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Type</c> column value.</value>
	public string Type
	{
		get
		{
			if(IsTypeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _type;
		}
		set
		{
			_typeNull = false;
			_type = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Type"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTypeNull
	{
		get
		{
			return _typeNull;
		}
		set
		{
			_typeNull = value;
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
		/// Gets or sets the <c>IP</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IP</c> column value.</value>
	public string IP
	{
		get
		{
			if(IsIPNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _ip;
		}
		set
		{
			_ipNull = false;
			_ip = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="IP"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIPNull
	{
		get
		{
			return _ipNull;
		}
		set
		{
			_ipNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Location</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Location</c> column value.</value>
	public string Location
	{
		get
		{
			if(IsLocationNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _location;
		}
		set
		{
			_locationNull = false;
			_location = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Location"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocationNull
	{
		get
		{
			return _locationNull;
		}
		set
		{
			_locationNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TrackingDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TrackingDate</c> column value.</value>
	public System.DateTime TrackingDate
	{
		get
		{
			if (IsTrackingDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _trackingDate;
		}
		set
		{
			_trackingDateNull = false;
			_trackingDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TrackingDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTrackingDateNull
	{
		get
		{
			return _trackingDateNull;
		}
		set
		{
			_trackingDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Status</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Status</c> column value.</value>
	public int Status
	{
		get
		{
			if (IsStatusNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _status;
		}
		set
		{
			_statusNull = false;
			_status = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Status"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStatusNull
	{
		get
		{
			return _statusNull;
		}
		set
		{
			_statusNull = value;
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
		// QRCodeTracking_ID
		dynStr.Append("  QRCodeTracking_ID=");
		if( IsQRCodeTracking_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodeTracking_ID);
		

		// QRCodeSerial
		dynStr.Append("  QRCodeSerial=");
		if( IsQRCodeSerialNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodeSerial);
		

		// QRCodeContent
		dynStr.Append("  QRCodeContent=");
		if( IsQRCodeContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodeContent);
		

		// Type
		dynStr.Append("  Type=");
		if( IsTypeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Type);
		

		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID);
		// IP
		dynStr.Append("  IP=");
		if( IsIPNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.IP);
		

		// Location
		dynStr.Append("  Location=");
		if( IsLocationNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Location);
		

		// TrackingDate
		dynStr.Append("  TrackingDate=");
		if( IsTrackingDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.TrackingDate);
		// Status
		dynStr.Append("  Status=");
		if( IsStatusNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Status);
		return dynStr.ToString();
	}
}
}




