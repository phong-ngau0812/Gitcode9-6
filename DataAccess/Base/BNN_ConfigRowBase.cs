
// <fileinfo name="Base\BNN_ConfigRowBase.cs">
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
/// The base class for <see cref="BNN_ConfigRow"/> that 
/// represents a record in the <c>BNN_Config</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="BNN_ConfigRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_ConfigRowBase
{
	/// _config_ID
	private int _config_ID;
	private bool _config_IDNull = true;
	/// _logo
	private string _logo;
	private bool _logoNull = true;
	/// _companyName
	private string _companyName;
	private bool _companyNameNull = true;
	/// _title
	private string _title;
	private bool _titleNull = true;
	/// _map
	private string _map;
	private bool _mapNull = true;
	/// _keyword
	private string _keyword;
	private bool _keywordNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _facebook
	private string _facebook;
	private bool _facebookNull = true;
	/// _twitter
	private string _twitter;
	private bool _twitterNull = true;
	/// _youtube
	private string _youtube;
	private bool _youtubeNull = true;
	/// _google
	private string _google;
	private bool _googleNull = true;
	/// _footer
	private string _footer;
	private bool _footerNull = true;
	/// _displayName
	private string _displayName;
	private bool _displayNameNull = true;
	/// _emailAddress
	private string _emailAddress;
	private bool _emailAddressNull = true;
	/// _password
	private string _password;
	private bool _passwordNull = true;
	/// _sMTPServer
	private string _sMTPServer;
	private bool _sMTPServerNull = true;
	/// _sMTPPort
	private int _sMTPPort;
	private bool _sMTPPortNull = true;
	/// _isSSL
	private bool _isSSL;
	private bool _isSSLNull = true;
	/// _mailServer
	private string _mailServer;
	private bool _mailServerNull = true;
	/// _serverPort
	private int _serverPort;
	private bool _serverPortNull = true;
	/// _introduction
	private string _introduction;
	private bool _introductionNull = true;
	/// _guide
	private string _guide;
	private bool _guideNull = true;
	/// _location_ID
	private int _location_ID;
	private bool _location_IDNull = true;
	/// _district_ID
	private int _district_ID;
	private bool _district_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="BNN_ConfigRowBase"/> class.
	/// </summary>
	public BNN_ConfigRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Config_ID</c> column value.
		/// </summary>
		/// <value>The <c>Config_ID</c> column value.</value>
	public int Config_ID
	{
		get
		{
			if(IsConfig_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _config_ID;
		}
		set
		{
			_config_IDNull = false;
			_config_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Config_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsConfig_IDNull
	{
		get
		{
			return _config_IDNull;
		}
		set
		{
			_config_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Logo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Logo</c> column value.</value>
	public string Logo
	{
		get
		{
			if(IsLogoNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _logo;
		}
		set
		{
			_logoNull = false;
			_logo = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Logo"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLogoNull
	{
		get
		{
			return _logoNull;
		}
		set
		{
			_logoNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CompanyName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CompanyName</c> column value.</value>
	public string CompanyName
	{
		get
		{
			if(IsCompanyNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _companyName;
		}
		set
		{
			_companyNameNull = false;
			_companyName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CompanyName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCompanyNameNull
	{
		get
		{
			return _companyNameNull;
		}
		set
		{
			_companyNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Title</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Title</c> column value.</value>
	public string Title
	{
		get
		{
			if(IsTitleNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _title;
		}
		set
		{
			_titleNull = false;
			_title = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Title"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTitleNull
	{
		get
		{
			return _titleNull;
		}
		set
		{
			_titleNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Map</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Map</c> column value.</value>
	public string Map
	{
		get
		{
			if(IsMapNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _map;
		}
		set
		{
			_mapNull = false;
			_map = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Map"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMapNull
	{
		get
		{
			return _mapNull;
		}
		set
		{
			_mapNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Keyword</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Keyword</c> column value.</value>
	public string Keyword
	{
		get
		{
			if(IsKeywordNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _keyword;
		}
		set
		{
			_keywordNull = false;
			_keyword = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Keyword"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsKeywordNull
	{
		get
		{
			return _keywordNull;
		}
		set
		{
			_keywordNull = value;
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
		/// Gets or sets the <c>Facebook</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Facebook</c> column value.</value>
	public string Facebook
	{
		get
		{
			if(IsFacebookNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _facebook;
		}
		set
		{
			_facebookNull = false;
			_facebook = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Facebook"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFacebookNull
	{
		get
		{
			return _facebookNull;
		}
		set
		{
			_facebookNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Twitter</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Twitter</c> column value.</value>
	public string Twitter
	{
		get
		{
			if(IsTwitterNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _twitter;
		}
		set
		{
			_twitterNull = false;
			_twitter = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Twitter"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTwitterNull
	{
		get
		{
			return _twitterNull;
		}
		set
		{
			_twitterNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Youtube</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Youtube</c> column value.</value>
	public string Youtube
	{
		get
		{
			if(IsYoutubeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _youtube;
		}
		set
		{
			_youtubeNull = false;
			_youtube = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Youtube"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsYoutubeNull
	{
		get
		{
			return _youtubeNull;
		}
		set
		{
			_youtubeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Google</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Google</c> column value.</value>
	public string Google
	{
		get
		{
			if(IsGoogleNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _google;
		}
		set
		{
			_googleNull = false;
			_google = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Google"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGoogleNull
	{
		get
		{
			return _googleNull;
		}
		set
		{
			_googleNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Footer</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Footer</c> column value.</value>
	public string Footer
	{
		get
		{
			if(IsFooterNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _footer;
		}
		set
		{
			_footerNull = false;
			_footer = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Footer"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFooterNull
	{
		get
		{
			return _footerNull;
		}
		set
		{
			_footerNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DisplayName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DisplayName</c> column value.</value>
	public string DisplayName
	{
		get
		{
			if(IsDisplayNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _displayName;
		}
		set
		{
			_displayNameNull = false;
			_displayName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DisplayName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDisplayNameNull
	{
		get
		{
			return _displayNameNull;
		}
		set
		{
			_displayNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>EmailAddress</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EmailAddress</c> column value.</value>
	public string EmailAddress
	{
		get
		{
			if(IsEmailAddressNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _emailAddress;
		}
		set
		{
			_emailAddressNull = false;
			_emailAddress = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EmailAddress"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailAddressNull
	{
		get
		{
			return _emailAddressNull;
		}
		set
		{
			_emailAddressNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Password</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Password</c> column value.</value>
	public string Password
	{
		get
		{
			if(IsPasswordNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _password;
		}
		set
		{
			_passwordNull = false;
			_password = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Password"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPasswordNull
	{
		get
		{
			return _passwordNull;
		}
		set
		{
			_passwordNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SMTPServer</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SMTPServer</c> column value.</value>
	public string SMTPServer
	{
		get
		{
			if(IsSMTPServerNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sMTPServer;
		}
		set
		{
			_sMTPServerNull = false;
			_sMTPServer = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SMTPServer"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSMTPServerNull
	{
		get
		{
			return _sMTPServerNull;
		}
		set
		{
			_sMTPServerNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SMTPPort</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SMTPPort</c> column value.</value>
	public int SMTPPort
	{
		get
		{
			if (IsSMTPPortNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sMTPPort;
		}
		set
		{
			_sMTPPortNull = false;
			_sMTPPort = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SMTPPort"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSMTPPortNull
	{
		get
		{
			return _sMTPPortNull;
		}
		set
		{
			_sMTPPortNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>IsSSL</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IsSSL</c> column value.</value>
	public bool IsSSL
	{
		get
		{
			if (IsIsSSLNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _isSSL;
		}
		set
		{
			_isSSLNull = false;
			_isSSL = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="IsSSL"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIsSSLNull
	{
		get
		{
			return _isSSLNull;
		}
		set
		{
			_isSSLNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>MailServer</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MailServer</c> column value.</value>
	public string MailServer
	{
		get
		{
			if(IsMailServerNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _mailServer;
		}
		set
		{
			_mailServerNull = false;
			_mailServer = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MailServer"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMailServerNull
	{
		get
		{
			return _mailServerNull;
		}
		set
		{
			_mailServerNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ServerPort</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ServerPort</c> column value.</value>
	public int ServerPort
	{
		get
		{
			if (IsServerPortNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _serverPort;
		}
		set
		{
			_serverPortNull = false;
			_serverPort = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ServerPort"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsServerPortNull
	{
		get
		{
			return _serverPortNull;
		}
		set
		{
			_serverPortNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Introduction</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Introduction</c> column value.</value>
	public string Introduction
	{
		get
		{
			if(IsIntroductionNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _introduction;
		}
		set
		{
			_introductionNull = false;
			_introduction = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Introduction"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIntroductionNull
	{
		get
		{
			return _introductionNull;
		}
		set
		{
			_introductionNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Guide</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Guide</c> column value.</value>
	public string Guide
	{
		get
		{
			if(IsGuideNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _guide;
		}
		set
		{
			_guideNull = false;
			_guide = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Guide"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGuideNull
	{
		get
		{
			return _guideNull;
		}
		set
		{
			_guideNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Location_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Location_ID</c> column value.</value>
	public int Location_ID
	{
		get
		{
			if (IsLocation_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _location_ID;
		}
		set
		{
			_location_IDNull = false;
			_location_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Location_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocation_IDNull
	{
		get
		{
			return _location_IDNull;
		}
		set
		{
			_location_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>District_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>District_ID</c> column value.</value>
	public int District_ID
	{
		get
		{
			if (IsDistrict_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _district_ID;
		}
		set
		{
			_district_IDNull = false;
			_district_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="District_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDistrict_IDNull
	{
		get
		{
			return _district_IDNull;
		}
		set
		{
			_district_IDNull = value;
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
		// Config_ID
		dynStr.Append("  Config_ID=");
		if( IsConfig_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Config_ID);
		

		// Logo
		dynStr.Append("  Logo=");
		if( IsLogoNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Logo);
		

		// CompanyName
		dynStr.Append("  CompanyName=");
		if( IsCompanyNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CompanyName);
		

		// Title
		dynStr.Append("  Title=");
		if( IsTitleNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Title);
		

		// Map
		dynStr.Append("  Map=");
		if( IsMapNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Map);
		

		// Keyword
		dynStr.Append("  Keyword=");
		if( IsKeywordNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Keyword);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// Facebook
		dynStr.Append("  Facebook=");
		if( IsFacebookNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Facebook);
		

		// Twitter
		dynStr.Append("  Twitter=");
		if( IsTwitterNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Twitter);
		

		// Youtube
		dynStr.Append("  Youtube=");
		if( IsYoutubeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Youtube);
		

		// Google
		dynStr.Append("  Google=");
		if( IsGoogleNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Google);
		

		// Footer
		dynStr.Append("  Footer=");
		if( IsFooterNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Footer);
		

		// DisplayName
		dynStr.Append("  DisplayName=");
		if( IsDisplayNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DisplayName);
		

		// EmailAddress
		dynStr.Append("  EmailAddress=");
		if( IsEmailAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.EmailAddress);
		

		// Password
		dynStr.Append("  Password=");
		if( IsPasswordNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Password);
		

		// SMTPServer
		dynStr.Append("  SMTPServer=");
		if( IsSMTPServerNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SMTPServer);
		

		// SMTPPort
		dynStr.Append("  SMTPPort=");
		if( IsSMTPPortNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.SMTPPort);
		// IsSSL
		dynStr.Append("  IsSSL=");
		if( IsIsSSLNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.IsSSL);
		// MailServer
		dynStr.Append("  MailServer=");
		if( IsMailServerNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.MailServer);
		

		// ServerPort
		dynStr.Append("  ServerPort=");
		if( IsServerPortNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ServerPort);
		// Introduction
		dynStr.Append("  Introduction=");
		if( IsIntroductionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Introduction);
		

		// Guide
		dynStr.Append("  Guide=");
		if( IsGuideNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Guide);
		

		// Location_ID
		dynStr.Append("  Location_ID=");
		if( IsLocation_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Location_ID);
		// District_ID
		dynStr.Append("  District_ID=");
		if( IsDistrict_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.District_ID);
		return dynStr.ToString();
	}
}
}




