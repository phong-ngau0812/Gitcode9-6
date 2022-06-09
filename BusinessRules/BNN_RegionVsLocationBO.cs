// <fileinfo name="BNN_RegionVsLocationBO.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
// </fileinfo>


using System;
using System.Data;

using DbObj;


/// <summary>
/// The base class for <see cref="BNN_RegionVsLocationCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BNN_RegionVsLocationCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class BNN_RegionVsLocationBO
	: BusinessRulesBase
{



	public BNN_RegionVsLocationRow GetByPrimaryKey(int region_ID, int location_ID)
	{
		string LOCATION = "GetByPrimaryKey(int region_ID, int location_ID)";
		try
		{
			return DataAccessLocator.GetBNN_RegionVsLocationCollection().GetByPrimaryKey(region_ID, location_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int region_ID, int location_ID)
	{
		string LOCATION = "Exist(int region_ID, int location_ID)";
		try
		{
			return DataAccessLocator.GetBNN_RegionVsLocationCollection().Exist(region_ID, location_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}




	public void Insert(BNN_RegionVsLocationRow value)
	{
		string LOCATION = "Insert(BNN_RegionVsLocationRow value)";
		try
		{
			DataAccessLocator.GetBNN_RegionVsLocationCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int region_ID, int location_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int region_ID, int location_ID)";
		try
		{
			return DataAccessLocator.GetBNN_RegionVsLocationCollection().DeleteByPrimaryKey(region_ID, location_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public int Delete(string whereSql)
	{
		string LOCATION = "Delete(string whereSql)";
		try
		{
			return DataAccessLocator.GetBNN_RegionVsLocationCollection().Delete(whereSql);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public DataTable GetAllAsDataTable()
	{
		string LOCATION = "GetAllAsDataTable()";
		try
		{
			return DataAccessLocator.GetBNN_RegionVsLocationCollection().GetAllAsDataTable();
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	
	public DataTable GetAsDataTable(string whereSql, string orderBySql)
	{
		string LOCATION = "GetAsDataTable(string whereSql, string orderBySql)";
		try
		{
			return DataAccessLocator.GetBNN_RegionVsLocationCollection().GetAsDataTable(whereSql, orderBySql);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	
	public DataTable GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		try
		{
			return DataAccessLocator.GetBNN_RegionVsLocationCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

