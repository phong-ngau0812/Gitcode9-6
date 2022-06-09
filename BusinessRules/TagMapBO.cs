// <fileinfo name="TagMapBO.cs">
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
/// The base class for <see cref="TagMapCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="TagMapCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class TagMapBO
	: BusinessRulesBase
{



	public TagMapRow GetByPrimaryKey(int tagMap_ID)
	{
		string LOCATION = "GetByPrimaryKey(int tagMap_ID)";
		try
		{
			return DataAccessLocator.GetTagMapCollection().GetByPrimaryKey(tagMap_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int tagMap_ID)
	{
		string LOCATION = "Exist(int tagMap_ID)";
		try
		{
			return DataAccessLocator.GetTagMapCollection().Exist(tagMap_ID);
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
			DataAccessLocator.GetTagMapCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(TagMapRow value)
	{
		string LOCATION = "Update(TagMapRow value)";
		try
		{
			return DataAccessLocator.GetTagMapCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(TagMapRow value)
	{
		string LOCATION = "Insert(TagMapRow value)";
		try
		{
			DataAccessLocator.GetTagMapCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int tagMap_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int tagMap_ID)";
		try
		{
			return DataAccessLocator.GetTagMapCollection().DeleteByPrimaryKey(tagMap_ID);
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
			return DataAccessLocator.GetTagMapCollection().Delete(whereSql);
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
			return DataAccessLocator.GetTagMapCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetTagMapCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetTagMapCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}


	
	public TagMapRow[] GetByTag_ID(int tag_ID)
	{
		string LOCATION = "GetByTag_ID(int tag_ID)";
		try
		{
			return DataAccessLocator.GetTagMapCollection().GetByTag_ID(tag_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	
	public DataTable GetByTag_IDAsDataTable(int tag_ID)
	{
		string LOCATION = "GetByTag_ID(int tag_ID)";
		try
		{
			return DataAccessLocator.GetTagMapCollection().GetByTag_IDAsDataTable(tag_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	


}

