// <fileinfo name="WH_CheckSheetVsMaterialBO.cs">
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
/// The base class for <see cref="WH_CheckSheetVsMaterialCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WH_CheckSheetVsMaterialCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WH_CheckSheetVsMaterialBO
	: BusinessRulesBase
{



	public WH_CheckSheetVsMaterialRow GetByPrimaryKey(int wH_CheckSheetVsMaterial_ID)
	{
		string LOCATION = "GetByPrimaryKey(int wH_CheckSheetVsMaterial_ID)";
		try
		{
			return DataAccessLocator.GetWH_CheckSheetVsMaterialCollection().GetByPrimaryKey(wH_CheckSheetVsMaterial_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int wH_CheckSheetVsMaterial_ID)
	{
		string LOCATION = "Exist(int wH_CheckSheetVsMaterial_ID)";
		try
		{
			return DataAccessLocator.GetWH_CheckSheetVsMaterialCollection().Exist(wH_CheckSheetVsMaterial_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}


	public void Update(DataTable table)
	{
		string LOCATION = "Update(DataTable table)";
		try
		{
			DataAccessLocator.GetWH_CheckSheetVsMaterialCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WH_CheckSheetVsMaterialRow value)
	{
		string LOCATION = "Update(WH_CheckSheetVsMaterialRow value)";
		try
		{
			return DataAccessLocator.GetWH_CheckSheetVsMaterialCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WH_CheckSheetVsMaterialRow value)
	{
		string LOCATION = "Insert(WH_CheckSheetVsMaterialRow value)";
		try
		{
			DataAccessLocator.GetWH_CheckSheetVsMaterialCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int wH_CheckSheetVsMaterial_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int wH_CheckSheetVsMaterial_ID)";
		try
		{
			return DataAccessLocator.GetWH_CheckSheetVsMaterialCollection().DeleteByPrimaryKey(wH_CheckSheetVsMaterial_ID);
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
			return DataAccessLocator.GetWH_CheckSheetVsMaterialCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWH_CheckSheetVsMaterialCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetWH_CheckSheetVsMaterialCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWH_CheckSheetVsMaterialCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

