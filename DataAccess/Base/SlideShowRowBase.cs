
// <fileinfo name="Base\SlideShowRowBase.cs">
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
/// The base class for <see cref="SlideShowRow"/> that 
/// represents a record in the <c>SlideShow</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="SlideShowRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SlideShowRowBase
{
	/// _slide_ID
	private int _slide_ID;
	private bool _slide_IDNull = true;
	/// _image
	private string _image;
	private bool _imageNull = true;
	/// _link
	private string _link;
	private bool _linkNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="SlideShowRowBase"/> class.
	/// </summary>
	public SlideShowRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Slide_ID</c> column value.
		/// </summary>
		/// <value>The <c>Slide_ID</c> column value.</value>
	public int Slide_ID
	{
		get
		{
			if(IsSlide_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _slide_ID;
		}
		set
		{
			_slide_IDNull = false;
			_slide_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Slide_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSlide_IDNull
	{
		get
		{
			return _slide_IDNull;
		}
		set
		{
			_slide_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Image</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Image</c> column value.</value>
	public string Image
	{
		get
		{
			if(IsImageNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _image;
		}
		set
		{
			_imageNull = false;
			_image = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Image"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsImageNull
	{
		get
		{
			return _imageNull;
		}
		set
		{
			_imageNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Link</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Link</c> column value.</value>
	public string Link
	{
		get
		{
			if(IsLinkNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _link;
		}
		set
		{
			_linkNull = false;
			_link = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Link"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLinkNull
	{
		get
		{
			return _linkNull;
		}
		set
		{
			_linkNull = value;
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
		// Slide_ID
		dynStr.Append("  Slide_ID=");
		if( IsSlide_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Slide_ID);
		

		// Image
		dynStr.Append("  Image=");
		if( IsImageNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Image);
		

		// Link
		dynStr.Append("  Link=");
		if( IsLinkNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Link);
		

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




