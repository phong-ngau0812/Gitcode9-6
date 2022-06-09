
// <fileinfo name="SystemConfig.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
// </fileinfo>


using System.Web;
using System.Configuration;


/// <summary>
/// The base class for the <see cref="asiaticadb"/> class that 
/// represents a connection to the <c>asiaticadb</c> database. 
/// </summary>
/// <remarks>
/// Do not change this source code. Modify the AsiaWondersDB class
/// if you need to add or change some functionality.
/// </remarks>

public class SystemConfig
{
    	
	public static string GetConnectionString()
	{
        //return ConfigurationManager.ConnectionStrings["MasterNewsDependency"].ConnectionString;
        return System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"].ToString();
	}

    public static string GetLicenseKey()
    {
        return "po2UhpWVhpSfkYaUiJaGlZeIl5SIn5+fnw==";
    }

}



