
// <fileinfo name="Base\SettingRowBase.cs">
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
/// The base class for <see cref="SettingRow"/> that 
/// represents a record in the <c>Setting</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="SettingRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SettingRowBase
{
	/// _setting_ID
	private int _setting_ID;
	private bool _setting_IDNull = true;
	/// _adminName
	private string _adminName;
	private bool _adminNameNull = true;
	/// _emailSupport
	private string _emailSupport;
	private bool _emailSupportNull = true;
	/// _emailOrder
	private string _emailOrder;
	private bool _emailOrderNull = true;
	/// _emailSenderSMTP
	private string _emailSenderSMTP;
	private bool _emailSenderSMTPNull = true;
	/// _emailSenderPort
	private string _emailSenderPort;
	private bool _emailSenderPortNull = true;
	/// _emailSenderSSL
	private bool _emailSenderSSL;
	private bool _emailSenderSSLNull = true;
	/// _emailSender
	private string _emailSender;
	private bool _emailSenderNull = true;
	/// _emailSenderPassword
	private string _emailSenderPassword;
	private bool _emailSenderPasswordNull = true;
	/// _telephone
	private string _telephone;
	private bool _telephoneNull = true;
	/// _appStatus
	private bool _appStatus;
	private bool _appStatusNull = true;
	/// _counter
	private int _counter;
	private bool _counterNull = true;
	/// _defaultLanguage_ID
	private int _defaultLanguage_ID;
	private bool _defaultLanguage_IDNull = true;
	/// _defaultSkin_ID
	private int _defaultSkin_ID;
	private bool _defaultSkin_IDNull = true;
	/// _websiteName
	private string _websiteName;
	private bool _websiteNameNull = true;
	/// _metaDescriptionDefault
	private string _metaDescriptionDefault;
	private bool _metaDescriptionDefaultNull = true;
	/// _metaKeywordsDefault
	private string _metaKeywordsDefault;
	private bool _metaKeywordsDefaultNull = true;
	/// _metaTitleDefault
	private string _metaTitleDefault;
	private bool _metaTitleDefaultNull = true;
	/// _googleAnalytics
	private string _googleAnalytics;
	private bool _googleAnalyticsNull = true;
	/// _otherCode
	private string _otherCode;
	private bool _otherCodeNull = true;
	/// _facebookPageID
	private string _facebookPageID;
	private bool _facebookPageIDNull = true;
	/// _codeCheckVN
	private string _codeCheckVN;
	private bool _codeCheckVNNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="SettingRowBase"/> class.
	/// </summary>
	public SettingRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Setting_ID</c> column value.
		/// </summary>
		/// <value>The <c>Setting_ID</c> column value.</value>
	public int Setting_ID
	{
		get
		{
			if(IsSetting_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _setting_ID;
		}
		set
		{
			_setting_IDNull = false;
			_setting_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Setting_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSetting_IDNull
	{
		get
		{
			return _setting_IDNull;
		}
		set
		{
			_setting_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AdminName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AdminName</c> column value.</value>
	public string AdminName
	{
		get
		{
			if(IsAdminNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _adminName;
		}
		set
		{
			_adminNameNull = false;
			_adminName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AdminName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAdminNameNull
	{
		get
		{
			return _adminNameNull;
		}
		set
		{
			_adminNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>EmailSupport</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EmailSupport</c> column value.</value>
	public string EmailSupport
	{
		get
		{
			if(IsEmailSupportNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _emailSupport;
		}
		set
		{
			_emailSupportNull = false;
			_emailSupport = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EmailSupport"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailSupportNull
	{
		get
		{
			return _emailSupportNull;
		}
		set
		{
			_emailSupportNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>EmailOrder</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EmailOrder</c> column value.</value>
	public string EmailOrder
	{
		get
		{
			if(IsEmailOrderNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _emailOrder;
		}
		set
		{
			_emailOrderNull = false;
			_emailOrder = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EmailOrder"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailOrderNull
	{
		get
		{
			return _emailOrderNull;
		}
		set
		{
			_emailOrderNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>EmailSenderSMTP</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EmailSenderSMTP</c> column value.</value>
	public string EmailSenderSMTP
	{
		get
		{
			if(IsEmailSenderSMTPNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _emailSenderSMTP;
		}
		set
		{
			_emailSenderSMTPNull = false;
			_emailSenderSMTP = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EmailSenderSMTP"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailSenderSMTPNull
	{
		get
		{
			return _emailSenderSMTPNull;
		}
		set
		{
			_emailSenderSMTPNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>EmailSenderPort</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EmailSenderPort</c> column value.</value>
	public string EmailSenderPort
	{
		get
		{
			if(IsEmailSenderPortNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _emailSenderPort;
		}
		set
		{
			_emailSenderPortNull = false;
			_emailSenderPort = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EmailSenderPort"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailSenderPortNull
	{
		get
		{
			return _emailSenderPortNull;
		}
		set
		{
			_emailSenderPortNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>EmailSenderSSL</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EmailSenderSSL</c> column value.</value>
	public bool EmailSenderSSL
	{
		get
		{
			if (IsEmailSenderSSLNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _emailSenderSSL;
		}
		set
		{
			_emailSenderSSLNull = false;
			_emailSenderSSL = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EmailSenderSSL"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailSenderSSLNull
	{
		get
		{
			return _emailSenderSSLNull;
		}
		set
		{
			_emailSenderSSLNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>EmailSender</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EmailSender</c> column value.</value>
	public string EmailSender
	{
		get
		{
			if(IsEmailSenderNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _emailSender;
		}
		set
		{
			_emailSenderNull = false;
			_emailSender = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EmailSender"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailSenderNull
	{
		get
		{
			return _emailSenderNull;
		}
		set
		{
			_emailSenderNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>EmailSenderPassword</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EmailSenderPassword</c> column value.</value>
	public string EmailSenderPassword
	{
		get
		{
			if(IsEmailSenderPasswordNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _emailSenderPassword;
		}
		set
		{
			_emailSenderPasswordNull = false;
			_emailSenderPassword = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EmailSenderPassword"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailSenderPasswordNull
	{
		get
		{
			return _emailSenderPasswordNull;
		}
		set
		{
			_emailSenderPasswordNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Telephone</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Telephone</c> column value.</value>
	public string Telephone
	{
		get
		{
			if(IsTelephoneNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _telephone;
		}
		set
		{
			_telephoneNull = false;
			_telephone = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Telephone"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTelephoneNull
	{
		get
		{
			return _telephoneNull;
		}
		set
		{
			_telephoneNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AppStatus</c> column value.
		/// </summary>
		/// <value>The <c>AppStatus</c> column value.</value>
	public bool AppStatus
	{
		get
		{
			if(IsAppStatusNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _appStatus;
		}
		set
		{
			_appStatusNull = false;
			_appStatus = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AppStatus"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAppStatusNull
	{
		get
		{
			return _appStatusNull;
		}
		set
		{
			_appStatusNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Counter</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Counter</c> column value.</value>
	public int Counter
	{
		get
		{
			if (IsCounterNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _counter;
		}
		set
		{
			_counterNull = false;
			_counter = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Counter"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCounterNull
	{
		get
		{
			return _counterNull;
		}
		set
		{
			_counterNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DefaultLanguage_ID</c> column value.
		/// </summary>
		/// <value>The <c>DefaultLanguage_ID</c> column value.</value>
	public int DefaultLanguage_ID
	{
		get
		{
			if(IsDefaultLanguage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _defaultLanguage_ID;
		}
		set
		{
			_defaultLanguage_IDNull = false;
			_defaultLanguage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DefaultLanguage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDefaultLanguage_IDNull
	{
		get
		{
			return _defaultLanguage_IDNull;
		}
		set
		{
			_defaultLanguage_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DefaultSkin_ID</c> column value.
		/// </summary>
		/// <value>The <c>DefaultSkin_ID</c> column value.</value>
	public int DefaultSkin_ID
	{
		get
		{
			if(IsDefaultSkin_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _defaultSkin_ID;
		}
		set
		{
			_defaultSkin_IDNull = false;
			_defaultSkin_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DefaultSkin_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDefaultSkin_IDNull
	{
		get
		{
			return _defaultSkin_IDNull;
		}
		set
		{
			_defaultSkin_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WebsiteName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WebsiteName</c> column value.</value>
	public string WebsiteName
	{
		get
		{
			if(IsWebsiteNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _websiteName;
		}
		set
		{
			_websiteNameNull = false;
			_websiteName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WebsiteName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWebsiteNameNull
	{
		get
		{
			return _websiteNameNull;
		}
		set
		{
			_websiteNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>MetaDescriptionDefault</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MetaDescriptionDefault</c> column value.</value>
	public string MetaDescriptionDefault
	{
		get
		{
			if(IsMetaDescriptionDefaultNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _metaDescriptionDefault;
		}
		set
		{
			_metaDescriptionDefaultNull = false;
			_metaDescriptionDefault = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MetaDescriptionDefault"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMetaDescriptionDefaultNull
	{
		get
		{
			return _metaDescriptionDefaultNull;
		}
		set
		{
			_metaDescriptionDefaultNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>MetaKeywordsDefault</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MetaKeywordsDefault</c> column value.</value>
	public string MetaKeywordsDefault
	{
		get
		{
			if(IsMetaKeywordsDefaultNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _metaKeywordsDefault;
		}
		set
		{
			_metaKeywordsDefaultNull = false;
			_metaKeywordsDefault = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MetaKeywordsDefault"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMetaKeywordsDefaultNull
	{
		get
		{
			return _metaKeywordsDefaultNull;
		}
		set
		{
			_metaKeywordsDefaultNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>MetaTitleDefault</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MetaTitleDefault</c> column value.</value>
	public string MetaTitleDefault
	{
		get
		{
			if(IsMetaTitleDefaultNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _metaTitleDefault;
		}
		set
		{
			_metaTitleDefaultNull = false;
			_metaTitleDefault = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MetaTitleDefault"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMetaTitleDefaultNull
	{
		get
		{
			return _metaTitleDefaultNull;
		}
		set
		{
			_metaTitleDefaultNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>GoogleAnalytics</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GoogleAnalytics</c> column value.</value>
	public string GoogleAnalytics
	{
		get
		{
			if(IsGoogleAnalyticsNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _googleAnalytics;
		}
		set
		{
			_googleAnalyticsNull = false;
			_googleAnalytics = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GoogleAnalytics"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGoogleAnalyticsNull
	{
		get
		{
			return _googleAnalyticsNull;
		}
		set
		{
			_googleAnalyticsNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>OtherCode</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>OtherCode</c> column value.</value>
	public string OtherCode
	{
		get
		{
			if(IsOtherCodeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _otherCode;
		}
		set
		{
			_otherCodeNull = false;
			_otherCode = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="OtherCode"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOtherCodeNull
	{
		get
		{
			return _otherCodeNull;
		}
		set
		{
			_otherCodeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FacebookPageID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FacebookPageID</c> column value.</value>
	public string FacebookPageID
	{
		get
		{
			if(IsFacebookPageIDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _facebookPageID;
		}
		set
		{
			_facebookPageIDNull = false;
			_facebookPageID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FacebookPageID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFacebookPageIDNull
	{
		get
		{
			return _facebookPageIDNull;
		}
		set
		{
			_facebookPageIDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CodeCheckVN</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CodeCheckVN</c> column value.</value>
	public string CodeCheckVN
	{
		get
		{
			if(IsCodeCheckVNNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _codeCheckVN;
		}
		set
		{
			_codeCheckVNNull = false;
			_codeCheckVN = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CodeCheckVN"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCodeCheckVNNull
	{
		get
		{
			return _codeCheckVNNull;
		}
		set
		{
			_codeCheckVNNull = value;
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
		// Setting_ID
		dynStr.Append("  Setting_ID=");
		if( IsSetting_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Setting_ID);
		

		// AdminName
		dynStr.Append("  AdminName=");
		if( IsAdminNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.AdminName);
		

		// EmailSupport
		dynStr.Append("  EmailSupport=");
		if( IsEmailSupportNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.EmailSupport);
		

		// EmailOrder
		dynStr.Append("  EmailOrder=");
		if( IsEmailOrderNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.EmailOrder);
		

		// EmailSenderSMTP
		dynStr.Append("  EmailSenderSMTP=");
		if( IsEmailSenderSMTPNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.EmailSenderSMTP);
		

		// EmailSenderPort
		dynStr.Append("  EmailSenderPort=");
		if( IsEmailSenderPortNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.EmailSenderPort);
		

		// EmailSenderSSL
		dynStr.Append("  EmailSenderSSL=");
		if( IsEmailSenderSSLNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.EmailSenderSSL);
		// EmailSender
		dynStr.Append("  EmailSender=");
		if( IsEmailSenderNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.EmailSender);
		

		// EmailSenderPassword
		dynStr.Append("  EmailSenderPassword=");
		if( IsEmailSenderPasswordNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.EmailSenderPassword);
		

		// Telephone
		dynStr.Append("  Telephone=");
		if( IsTelephoneNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Telephone);
		

		// AppStatus
		dynStr.Append("  AppStatus=");
		if( IsAppStatusNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.AppStatus);
		

		// Counter
		dynStr.Append("  Counter=");
		if( IsCounterNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Counter);
		// DefaultLanguage_ID
		dynStr.Append("  DefaultLanguage_ID=");
		if( IsDefaultLanguage_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DefaultLanguage_ID);
		

		// DefaultSkin_ID
		dynStr.Append("  DefaultSkin_ID=");
		if( IsDefaultSkin_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.DefaultSkin_ID);
		

		// WebsiteName
		dynStr.Append("  WebsiteName=");
		if( IsWebsiteNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WebsiteName);
		

		// MetaDescriptionDefault
		dynStr.Append("  MetaDescriptionDefault=");
		if( IsMetaDescriptionDefaultNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.MetaDescriptionDefault);
		

		// MetaKeywordsDefault
		dynStr.Append("  MetaKeywordsDefault=");
		if( IsMetaKeywordsDefaultNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.MetaKeywordsDefault);
		

		// MetaTitleDefault
		dynStr.Append("  MetaTitleDefault=");
		if( IsMetaTitleDefaultNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.MetaTitleDefault);
		

		// GoogleAnalytics
		dynStr.Append("  GoogleAnalytics=");
		if( IsGoogleAnalyticsNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GoogleAnalytics);
		

		// OtherCode
		dynStr.Append("  OtherCode=");
		if( IsOtherCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.OtherCode);
		

		// FacebookPageID
		dynStr.Append("  FacebookPageID=");
		if( IsFacebookPageIDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FacebookPageID);
		

		// CodeCheckVN
		dynStr.Append("  CodeCheckVN=");
		if( IsCodeCheckVNNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CodeCheckVN);
		

		return dynStr.ToString();
	}
}
}




