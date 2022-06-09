
// <fileinfo name="Base\SitemapRowBase.cs">
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
/// The base class for <see cref="SitemapRow"/> that 
/// represents a record in the <c>Sitemap</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="SitemapRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SitemapRowBase
{
	/// _id
	private int _id;
	private bool _idNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _link
	private string _link;
	private bool _linkNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
	/// _languageID
	private string _languageID;
	private bool _languageIDNull = true;
	/// _parentID
	private int _parentID;
	private bool _parentIDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="SitemapRowBase"/> class.
	/// </summary>
	public SitemapRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>id</c> column value.
		/// </summary>
		/// <value>The <c>id</c> column value.</value>
	public int Id
	{
		get
		{
			if(IsIdNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _id;
		}
		set
		{
			_idNull = false;
			_id = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Id"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIdNull
	{
		get
		{
			return _idNull;
		}
		set
		{
			_idNull = value;
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
		/// Gets or sets the <c>Sort</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Sort</c> column value.</value>
	public int Sort
	{
		get
		{
			if (IsSortNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sort;
		}
		set
		{
			_sortNull = false;
			_sort = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Sort"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSortNull
	{
		get
		{
			return _sortNull;
		}
		set
		{
			_sortNull = value;
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
		/// Gets or sets the <c>LanguageID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LanguageID</c> column value.</value>
	public string LanguageID
	{
		get
		{
			if(IsLanguageIDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _languageID;
		}
		set
		{
			_languageIDNull = false;
			_languageID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LanguageID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLanguageIDNull
	{
		get
		{
			return _languageIDNull;
		}
		set
		{
			_languageIDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ParentID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ParentID</c> column value.</value>
	public int ParentID
	{
		get
		{
			if (IsParentIDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _parentID;
		}
		set
		{
			_parentIDNull = false;
			_parentID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ParentID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsParentIDNull
	{
		get
		{
			return _parentIDNull;
		}
		set
		{
			_parentIDNull = value;
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
		// Id
		dynStr.Append("  Id=");
		if( IsIdNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Id);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Link
		dynStr.Append("  Link=");
		if( IsLinkNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Link);
		

		// Sort
		dynStr.Append("  Sort=");
		if( IsSortNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Sort);
		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// LanguageID
		dynStr.Append("  LanguageID=");
		if( IsLanguageIDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.LanguageID);
		

		// ParentID
		dynStr.Append("  ParentID=");
		if( IsParentIDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ParentID);
		return dynStr.ToString();
	}
}
}




