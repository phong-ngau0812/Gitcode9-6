
// <fileinfo name="Base\WarehouseImportNoteCollectionBase.cs">
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
using System.Data;
using DbObj;
using SystemFrameWork;

namespace Base
{

    /// <summary>
    /// The base class for <see cref="WarehouseImportNoteCollection"/>. Provides methods 
    /// for common database table operations. 
    /// </summary>
    /// <remarks>
    /// Do not change this source code. Update the <see cref="WarehouseImportNoteCollection"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseImportNoteCollectionBase
        : Base.ConllectionBase

    {
        // Constants
        public const string WarehouseImportNote_IDColumnName = "WarehouseImportNote_ID";
        public const string ProductBrand_IDColumnName = "ProductBrand_ID";
        public const string Warehouse_IDColumnName = "Warehouse_ID";
        public const string WarehouseImportNoteType_IDColumnName = "WarehouseImportNoteType_ID";
        public const string Product_IDColumnName = "Product_ID";
        public const string ProductPackage_IDColumnName = "ProductPackage_ID";
        public const string ProductPackageOrder_IDColumnName = "ProductPackageOrder_ID";
        public const string DescriptionColumnName = "Description";
        public const string ProductTypeColumnName = "ProductType";
        public const string WarehouserColumnName = "Warehouser";
        public const string PositionIDColumnName = "PositionID";
        public const string WarehouseImportNoteCodeColumnName = "WarehouseImportNoteCode";
        public const string Other1ColumnName = "Other1";
        public const string Other2ColumnName = "Other2";
        public const string Other3ColumnName = "Other3";
        public const string CreateByColumnName = "CreateBy";
        public const string CreateDateColumnName = "CreateDate";
        public const string LastEditByColumnName = "LastEditBy";
        public const string LastEditDateColumnName = "LastEditDate";
        public const string ActiveColumnName = "Active";


        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
        /// class with the specified <see cref="Database"/>.
        /// </summary>
        /// <param name="db">The <see cref="Database"/> object.</param>
        public WarehouseImportNoteCollectionBase(Database db) : base(db)
        {
            this.TABLENAME = "WarehouseImportNote";
        }

        public WarehouseImportNoteCollectionBase() : base()
        {
            this.TABLENAME = "WarehouseImportNote";
        }



        /// <summary>
        /// Gets an array of all records from the <c>WarehouseImportNote</c> table.
        /// </summary>
        /// <returns>An array of <see cref="WarehouseImportNoteRow"/> objects.</returns>
        public virtual WarehouseImportNoteRow[] GetAll()
        {
            return MapRecords(CreateGetAllCommand());
        }

        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object that 
        /// includes all records from the <c>WarehouseImportNote</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        public virtual DataTable GetAllAsDataTable()
        {
            string LOCATION = "GetAllAsDataTable()";
            try
            {
                return MapRecordsToDataTable(CreateGetAllCommand());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
        /// to retrieve all records from the <c>WarehouseImportNote</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetAllCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseImportNote_GetAll", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Gets the first <see cref="WarehouseImportNoteRow"/> objects that 
        /// match the search condition.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>An instance of <see cref="WarehouseImportNoteRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public WarehouseImportNoteRow GetRow(string whereSql)
        {
            string LOCATION = "GetRow(string whereSql)";
            try
            {
                int totalRecordCount = -1;
                WarehouseImportNoteRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
                if (0 == rows.Length)
                    return null;
                return rows[0];
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Gets an array of <see cref="WarehouseImportNoteRow"/> objects that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
        /// <returns>An array of <see cref="WarehouseImportNoteRow"/> objects.</returns>
        public WarehouseImportNoteRow[] GetAsArray(string whereSql, string orderBySql)
        {
            string LOCATION = "GetAsArray(string whereSql, string orderBySql)";
            IDataReader reader = null;
            try
            {
                reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql));
                return MapRecords(reader);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                _db.Dispose();
            }
        }

        /// <summary>
        /// Gets an array of <see cref="WarehouseImportNoteRow"/> objects that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example:
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
        /// <param name="startIndex">The index of the first record to return.</param>
        /// <param name="length">The number of records to return.</param>
        /// <param name="totalRecordCount">A reference parameter that returns the total number 
        /// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
        /// <returns>An array of <see cref="WarehouseImportNoteRow"/> objects.</returns>
        public virtual WarehouseImportNoteRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
            IDataReader reader = null;
            IDbCommand cmd = null;
            try
            {
                cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
                reader = _db.ExecuteReader(cmd);
                WarehouseImportNoteRow[] rows = MapRecords(reader);
                reader.Close();
                System.Data.SqlClient.SqlParameter p = (System.Data.SqlClient.SqlParameter)(cmd.Parameters["@rows"]);
                totalRecordCount = (int)p.Value;
                return rows;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                reader.Dispose();
                cmd.Dispose();
                _db.Dispose();
            }
        }

        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        public DataTable GetAsDataTable(string whereSql, string orderBySql)
        {
            string LOCATION = "GetAsDataTable(string whereSql, string orderBySql)";
            IDataReader reader = null;
            try
            {
                reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql));
                return MapRecordsToDataTable(reader);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                reader.Dispose();
                _db.Dispose();
            }

        }

        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
        /// <param name="startIndex">The index of the first record to return.</param>
        /// <param name="length">The number of records to return.</param>
        /// <param name="totalRecordCount">A reference parameter that returns the total number 
        /// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        public virtual DataTable GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = "GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
            IDataReader reader = null;
            IDbCommand cmd = null;
            try
            {
                cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
                reader = _db.ExecuteReader(cmd);
                DataTable table = MapRecordsToDataTable(reader);
                reader.Close();
                System.Data.SqlClient.SqlParameter p = (System.Data.SqlClient.SqlParameter)(cmd.Parameters["@rows"]);
                totalRecordCount = (int)p.Value;
                return table;
            }
            catch (Exception ex)
            {

                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                reader.Dispose();
                cmd.Dispose();
                _db.Dispose();
            }
        }

        /// <summary>
        /// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
        {
            string LOCATION = "CreateGetCommand(string whereSql, string orderBySql)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNote_GetAdHoc", CommandType.StoredProcedure);
                _db.AddParameter(cmd, "where", DbType.String, whereSql);
                _db.AddParameter(cmd, "orderby", DbType.String, orderBySql);
                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
        /// <param name="startIndex">The index of the first record to return.</param>
        /// <param name="length">The number of records to return.</param>		
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql, int startIndex, int length)
        {
            string LOCATION = "CreateGetCommand(string whereSql, string orderBySql, int startIndex, int length)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNote_GetPageAdHoc", CommandType.StoredProcedure);

                _db.AddParameter(cmd, "where", DbType.String, whereSql);
                _db.AddParameter(cmd, "orderby", DbType.String, orderBySql);
                _db.AddParameter(cmd, "startIndex", DbType.Int32, startIndex + 1);
                _db.AddParameter(cmd, "length", DbType.Int32, length);

                IDbDataParameter parameter = _db.AddParameter(cmd, "rows", DbType.Int32, -1);
                parameter.Direction = ParameterDirection.InputOutput;

                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }


        /// <summary>
        /// Gets <see cref="WarehouseImportNoteRow"/> by the primary key.
        /// </summary>
        /// <param name="WarehouseImportNote_ID">The <c>WarehouseImportNote_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseImportNoteRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual WarehouseImportNoteRow GetByPrimaryKey(int WarehouseImportNote_ID)
        {
            string LOCATION = "GetByPrimaryKey(int WarehouseImportNote_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNote_GetByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "WarehouseImportNote_ID", WarehouseImportNote_ID);
                WarehouseImportNoteRow[] tempArray = MapRecords(cmd);
                if (0 == tempArray.Length)
                    return null;

                return tempArray[0];
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }



        /// <summary>
        /// Adds a new record into the <c>WarehouseImportNote</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseImportNoteRow"/> object to be inserted.</param>
        public virtual void Insert(WarehouseImportNoteRow value)
        {
            string LOCATION = "Insert(WarehouseImportNoteRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNote_Insert", CommandType.StoredProcedure);
                // ProductBrand_ID
                if (value.IsProductBrand_IDNull)
                    AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);

                // Warehouse_ID
                if (value.IsWarehouse_IDNull)
                    AddParameter(cmd, "Warehouse_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Warehouse_ID", value.Warehouse_ID);

                // WarehouseImportNoteType_ID
                if (value.IsWarehouseImportNoteType_IDNull)
                    AddParameter(cmd, "WarehouseImportNoteType_ID", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseImportNoteType_ID", value.WarehouseImportNoteType_ID);
                // Product_ID
                if (value.IsProduct_IDNull)
                    AddParameter(cmd, "Product_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Product_ID", value.Product_ID);

                // ProductPackageOrder_ID
                if (value.IsProductPackageOrder_IDNull)
                    AddParameter(cmd, "ProductPackageOrder_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPackageOrder_ID", value.ProductPackageOrder_ID);

                // Description
                if (value.IsDescriptionNull)
                    AddParameter(cmd, "Description", DBNull.Value);
                else
                    AddParameter(cmd, "Description", value.Description);

                // ProductPackage_ID
                if (value.IsProductPackage_IDNull)
                    AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);

                // Warehouser
                if (value.IsWarehouserNull)
                    AddParameter(cmd, "Warehouser", DBNull.Value);
                else
                    AddParameter(cmd, "Warehouser", value.Warehouser);

                // PositionID
                if (value.IsPositionIDNull)
                    AddParameter(cmd, "PositionID", DBNull.Value);
                else
                    AddParameter(cmd, "PositionID", value.PositionID);
                // ProductType
                if (value.IsProductTypeNull)
                    AddParameter(cmd, "ProductType", DBNull.Value);
                else
                    AddParameter(cmd, "ProductType", value.ProductType);

                // CreateBy
                if (value.IsCreateByNull)
                    AddParameter(cmd, "CreateBy", DBNull.Value);
                else
                    AddParameter(cmd, "CreateBy", value.CreateBy);
                // WarehouseImportNoteCode
                if (value.IsWarehouseImportNoteCodeNull)
                    AddParameter(cmd, "WarehouseImportNoteCode", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseImportNoteCode", value.WarehouseImportNoteCode);
                // Other1
                if (value.IsOther1Null)
                    AddParameter(cmd, "Other1", DBNull.Value);
                else
                    AddParameter(cmd, "Other1", value.Other1);
                // Other2
                if (value.IsOther2Null)
                    AddParameter(cmd, "Other2", DBNull.Value);
                else
                    AddParameter(cmd, "Other2", value.Other2);
                // Other3
                if (value.IsOther3Null)
                    AddParameter(cmd, "Other3", DBNull.Value);
                else
                    AddParameter(cmd, "Other3", value.Other3);

                // CreateDate
                if (value.IsCreateDateNull)
                    AddParameter(cmd, "CreateDate", DBNull.Value);
                else
                    AddParameter(cmd, "CreateDate", value.CreateDate);

                // LastEditBy
                if (value.IsLastEditByNull)
                    AddParameter(cmd, "LastEditBy", DBNull.Value);
                else
                    AddParameter(cmd, "LastEditBy", value.LastEditBy);

                // LastEditDate
                if (value.IsLastEditDateNull)
                    AddParameter(cmd, "LastEditDate", DBNull.Value);
                else
                    AddParameter(cmd, "LastEditDate", value.LastEditDate);

                // Active
                if (value.IsActiveNull)
                    AddParameter(cmd, "Active", DBNull.Value);
                else
                    AddParameter(cmd, "Active", value.Active);
                Log.writeLog("wtf", "test");
                value.WarehouseImportNote_ID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Log.writeLog("SaveWarehouseImportNote", ex.ToString());
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }

        /// <summary>
        /// Updates a record in the <c>WarehouseImportNote</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseImportNoteRow"/>
        /// object used to update the table record.</param>
        /// <returns>true if the record was updated; otherwise, false.</returns>
        public virtual bool Update(WarehouseImportNoteRow value)
        {
            string LOCATION = "Update(WarehouseImportNoteRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNote_Update", CommandType.StoredProcedure);
                // ProductBrand_ID
                if (value.IsProductBrand_IDNull)
                    AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);

                // Warehouse_ID
                if (value.IsWarehouse_IDNull)
                    AddParameter(cmd, "Warehouse_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Warehouse_ID", value.Warehouse_ID);

                // WarehouseImportNoteType_ID
                if (value.IsWarehouseImportNoteType_IDNull)
                    AddParameter(cmd, "WarehouseImportNoteType_ID", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseImportNoteType_ID", value.WarehouseImportNoteType_ID);

                // Product_ID
                if (value.IsProduct_IDNull)
                    AddParameter(cmd, "Product_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Product_ID", value.Product_ID);

                // ProductPackageOrder_ID
                if (value.IsProductPackageOrder_IDNull)
                    AddParameter(cmd, "ProductPackageOrder_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPackageOrder_ID", value.ProductPackageOrder_ID);

                // Description
                if (value.IsDescriptionNull)
                    AddParameter(cmd, "Description", DBNull.Value);
                else
                    AddParameter(cmd, "Description", value.Description);

                // ProductPackage_ID
                if (value.IsProductPackage_IDNull)
                    AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);

                // Warehouser
                if (value.IsWarehouserNull)
                    AddParameter(cmd, "Warehouser", DBNull.Value);
                else
                    AddParameter(cmd, "Warehouser", value.Warehouser);

                // PositionID
                if (value.IsPositionIDNull)
                    AddParameter(cmd, "PositionID", DBNull.Value);
                else
                    AddParameter(cmd, "PositionID", value.PositionID);
                // WarehouseImportNoteCode
                if (value.IsWarehouseImportNoteCodeNull)
                    AddParameter(cmd, "WarehouseImportNoteCode", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseImportNoteCode", value.WarehouseImportNoteCode);
                // Other1
                if (value.IsOther1Null)
                    AddParameter(cmd, "Other1", DBNull.Value);
                else
                    AddParameter(cmd, "Other1", value.Other1);
                // Other2
                if (value.IsOther2Null)
                    AddParameter(cmd, "Other2", DBNull.Value);
                else
                    AddParameter(cmd, "Other2", value.Other2);
                // Other3
                if (value.IsOther3Null)
                    AddParameter(cmd, "Other3", DBNull.Value);
                else
                    AddParameter(cmd, "Other3", value.Other3);
                // ProductType
                if (value.IsProductTypeNull)
                    AddParameter(cmd, "ProductType", DBNull.Value);
                else
                    AddParameter(cmd, "ProductType", value.ProductType);
                // LastEditBy
                if (value.IsLastEditByNull)
                    AddParameter(cmd, "LastEditBy", DBNull.Value);
                else
                    AddParameter(cmd, "LastEditBy", value.LastEditBy);
                // Active
                if (value.IsActiveNull)
                    AddParameter(cmd, "Active", DBNull.Value);
                else
                    AddParameter(cmd, "Active", value.Active);

                AddParameter(cmd, "WarehouseImportNote_ID", value.WarehouseImportNote_ID);
                return 0 != cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }

        /// <summary>
        /// Inserts or Updates a record in the <c>WarehouseImportNote</c> table.
        /// If a row with the specified primary key exists then it is updated
        /// otehrwise, a new row is added.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseImportNoteRow"/>
        /// object used to save the table record.</param>
        public virtual void Save(WarehouseImportNoteRow value)
        {
            string LOCATION = "Save(WarehouseImportNoteRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNote_Save", CommandType.StoredProcedure);
                // ProductBrand_ID
                if (value.IsProductBrand_IDNull)
                    AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductBrand_ID", (object)(value.ProductBrand_ID));

                // Warehouse_ID
                if (value.IsWarehouse_IDNull)
                    AddParameter(cmd, "Warehouse_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Warehouse_ID", (object)(value.Warehouse_ID));

                // WarehouseImportNoteType_ID
                if (value.IsWarehouseImportNoteType_IDNull)
                    AddParameter(cmd, "WarehouseImportNoteType_ID", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseImportNoteType_ID", (object)(value.WarehouseImportNoteType_ID));

                // Product_ID
                if (value.IsProduct_IDNull)
                    AddParameter(cmd, "Product_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Product_ID", (object)(value.Product_ID));
                // ProductPackageOrder_ID
                if (value.IsProductPackageOrder_IDNull)
                    AddParameter(cmd, "ProductPackageOrder_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPackageOrder_ID", value.ProductPackageOrder_ID);

                // Description
                if (value.IsDescriptionNull)
                    AddParameter(cmd, "Description", DBNull.Value);
                else
                    AddParameter(cmd, "Description", value.Description);

                // ProductPackage_ID
                if (value.IsProductPackage_IDNull)
                    AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);

                // Warehouser
                if (value.IsWarehouserNull)
                    AddParameter(cmd, "Warehouser", DBNull.Value);
                else
                    AddParameter(cmd, "Warehouser", value.Warehouser);

                // PositionID
                if (value.IsPositionIDNull)
                    AddParameter(cmd, "PositionID", DBNull.Value);
                else
                    AddParameter(cmd, "PositionID", value.PositionID);
                // ProductType
                if (value.IsProductTypeNull)
                    AddParameter(cmd, "ProductType", DBNull.Value);
                else
                    AddParameter(cmd, "ProductType", value.ProductType);
                // WarehouseImportNoteCode
                if (value.IsWarehouseImportNoteCodeNull)
                    AddParameter(cmd, "WarehouseImportNoteCode", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseImportNoteCode", value.WarehouseImportNoteCode);
                // Other1
                if (value.IsOther1Null)
                    AddParameter(cmd, "Other1", DBNull.Value);
                else
                    AddParameter(cmd, "Other1", value.Other1);
                // Other2
                if (value.IsOther2Null)
                    AddParameter(cmd, "Other2", DBNull.Value);
                else
                    AddParameter(cmd, "Other2", value.Other2);
                // Other3
                if (value.IsOther3Null)
                    AddParameter(cmd, "Other3", DBNull.Value);
                else
                    AddParameter(cmd, "Other3", value.Other3);

                // CreateBy
                if (value.IsCreateByNull)
                    AddParameter(cmd, "CreateBy", DBNull.Value);
                else
                    AddParameter(cmd, "CreateBy", (object)(value.CreateBy));

                // LastEditBy
                if (value.IsLastEditByNull)
                    AddParameter(cmd, "LastEditBy", DBNull.Value);
                else
                    AddParameter(cmd, "LastEditBy", (object)(value.LastEditBy));

                // Active
                if (value.IsActiveNull)
                    AddParameter(cmd, "Active", DBNull.Value);
                else
                    AddParameter(cmd, "Active", (object)(value.Active));

                AddParameter(cmd, "WarehouseImportNote_ID", value.WarehouseImportNote_ID);
                value.WarehouseImportNote_ID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }


        public virtual void Update(DataTable table, bool acceptChanges)
        {
            string LOCATION = "Update(DataTable table, bool acceptChanges)";
            try
            {
                DataRowCollection rows = table.Rows;
                for (int i = rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = rows[i];
                    switch (row.RowState)
                    {
                        case DataRowState.Added:
                            Insert(MapRow(row));
                            if (acceptChanges)
                                row.AcceptChanges();
                            break;

                        case DataRowState.Deleted:
                            // Temporary reject changes to be able to access to the PK column(s)
                            row.RejectChanges();
                            try
                            {
                                DeleteByPrimaryKey((int)row["WarehouseImportNote_ID"]);
                            }
                            finally
                            {
                                row.Delete();
                            }
                            if (acceptChanges)
                                row.AcceptChanges();
                            break;

                        case DataRowState.Modified:
                            Update(MapRow(row));
                            if (acceptChanges)
                                row.AcceptChanges();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Deletes the specified object from the <c>WarehouseImportNote</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseImportNoteRow"/> object to delete.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public bool Delete(WarehouseImportNoteRow value)
        {
            return DeleteByPrimaryKey(value.WarehouseImportNote_ID);
        }

        /// <summary>
        /// Deletes a record from the <c>WarehouseImportNote</c> table using
        /// the specified primary key.
        /// </summary>
        /// <param name="WarehouseImportNote_ID">The <c>WarehouseImportNote_ID</c> column value.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public virtual bool DeleteByPrimaryKey(int WarehouseImportNote_ID)
        {
            string LOCATION = "DeleteByPrimaryKey(int WarehouseImportNote_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNote_DeleteByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "WarehouseImportNote_ID", WarehouseImportNote_ID);
                return (0 < cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }

        /// <summary>
        /// Deletes <c>WarehouseImportNote</c> records that match the specified criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. 
        /// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>The number of deleted records.</returns>
        public int Delete(string whereSql)
        {
            string LOCATION = "Delete(string whereSql)";
            try
            {
                return CreateDeleteCommand(whereSql).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }

        /// <summary>
        /// Creates an <see cref="System.Data.IDbCommand"/> object that can be used 
        /// to delete <c>WarehouseImportNote</c> records that match the specified criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. 
        /// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateDeleteCommand(string whereSql)
        {
            string LOCATION = "CreateDeleteCommand(String whereSql)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNote_DeleteAdHoc", CommandType.StoredProcedure);

                _db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Deletes all records from the <c>WarehouseImportNote</c> table.
        /// </summary>
        /// <returns>The number of deleted records.</returns>
        public int DeleteAll()
        {
            string LOCATION = "DeleteAll()";
            try
            {
                return _db.CreateCommand("WarehouseImportNote_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }

        /// <summary>
        /// Reads data using the specified command and returns 
        /// an array of mapped objects.
        /// </summary>
        /// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
        /// <returns>An array of <see cref="WarehouseImportNoteRow"/> objects.</returns>
        protected WarehouseImportNoteRow[] MapRecords(IDbCommand command)
        {
            string LOCATION = "MapRecords(IDbCommand command)";
            IDataReader reader = _db.ExecuteReader(command);
            try
            {
                return MapRecords(reader);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                reader.Dispose();
                _db.Dispose();

            }
        }

        /// <summary>
        /// Reads data from the provided data reader and returns 
        /// an array of mapped objects.
        /// </summary>
        /// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
        /// <returns>An array of <see cref="WarehouseImportNoteRow"/> objects.</returns>
        protected WarehouseImportNoteRow[] MapRecords(IDataReader reader)
        {
            int totalRecordCount = -1;
            return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
        }

        /// <summary>
        /// Reads data from the provided data reader and returns 
        /// an array of mapped objects.
        /// </summary>
        /// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
        /// <param name="startIndex">The index of the first record to map.</param>
        /// <param name="length">The number of records to map.</param>
        /// <param name="totalRecordCount">A reference parameter that returns the total number 
        /// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
        /// <returns>An array of <see cref="WarehouseImportNoteRow"/> objects.</returns>
        protected virtual WarehouseImportNoteRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = " MapRecords(...)";
            if (0 > startIndex)
                throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
            if (0 > length)
                throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

            // WarehouseImportNote_ID
            int WarehouseImportNote_IDColumnIndex = reader.GetOrdinal("WarehouseImportNote_ID");
            // ProductBrand_ID
            int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
            // Warehouse_ID
            int warehouse_IDColumnIndex = reader.GetOrdinal("Warehouse_ID");
            // WarehouseImportNoteType_ID
            int WarehouseImportNoteType_IDColumnIndex = reader.GetOrdinal("WarehouseImportNoteType_ID");
            // Product_ID
            int product_IDColumnIndex = reader.GetOrdinal("Product_ID");
            // productPackage_ID
            int productPackage_IDColumnIndex = reader.GetOrdinal("ProductPackage_ID");
            // Description
            int descriptionColumnIndex = reader.GetOrdinal("Description");
            // productPackageOrder_ID
            int productPackageOrder_IDColumnIndex = reader.GetOrdinal("ProductPackageOrder_ID");
            // ProductType
            int productTypeColumnIndex = reader.GetOrdinal("ProductType");
            // Warehouser
            int warehouserColumnIndex = reader.GetOrdinal("Warehouser");
            // PositionID
            int positionIDColumnIndex = reader.GetOrdinal("PositionID");
            // WarehouseImportNoteCode
            int WarehouseImportNoteCodeColumnIndex = reader.GetOrdinal("WarehouseImportNoteCode");
            // Other1
            int Other1ColumnIndex = reader.GetOrdinal("Other1");
            // Other2
            int Other2ColumnIndex = reader.GetOrdinal("Other2");
            // Other3
            int Other3ColumnIndex = reader.GetOrdinal("Other3");
            // CreateBy
            int createByColumnIndex = reader.GetOrdinal("CreateBy");
            // CreateDate
            int createDateColumnIndex = reader.GetOrdinal("CreateDate");
            // LastEditBy
            int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
            // LastEditDate
            int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
            // Active
            int activeColumnIndex = reader.GetOrdinal("Active");

            System.Collections.ArrayList recordList = new System.Collections.ArrayList();
            int ri = -startIndex;
            while (reader.Read())
            {
                ri++;
                if (ri > 0 && ri <= length)
                {
                    WarehouseImportNoteRow record = new WarehouseImportNoteRow();
                    recordList.Add(record);

                    record.WarehouseImportNote_ID = Convert.ToInt32(reader.GetValue(WarehouseImportNote_IDColumnIndex));
                    if (!reader.IsDBNull(productBrand_IDColumnIndex))
                        record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
                    if (!reader.IsDBNull(warehouse_IDColumnIndex))
                        record.Warehouse_ID = Convert.ToInt32(reader.GetValue(warehouse_IDColumnIndex));
                    if (!reader.IsDBNull(WarehouseImportNoteType_IDColumnIndex))
                        record.WarehouseImportNoteType_ID = Convert.ToInt32(reader.GetValue(WarehouseImportNoteType_IDColumnIndex));
                    if (!reader.IsDBNull(product_IDColumnIndex))
                        record.Product_ID = Convert.ToInt32(reader.GetValue(product_IDColumnIndex));
                    if (!reader.IsDBNull(productTypeColumnIndex))
                        record.ProductType = Convert.ToInt32(reader.GetValue(productTypeColumnIndex));
                    if (!reader.IsDBNull(descriptionColumnIndex))
                        record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
                    if (!reader.IsDBNull(WarehouseImportNoteCodeColumnIndex))
                        record.WarehouseImportNoteCode = Convert.ToString(reader.GetValue(WarehouseImportNoteCodeColumnIndex));
                    if (!reader.IsDBNull(Other1ColumnIndex))
                        record.Other1 = Convert.ToString(reader.GetValue(Other1ColumnIndex));
                    if (!reader.IsDBNull(Other2ColumnIndex))
                        record.Other2 = Convert.ToString(reader.GetValue(Other2ColumnIndex));
                    if (!reader.IsDBNull(Other3ColumnIndex))
                        record.Other3 = Convert.ToString(reader.GetValue(Other3ColumnIndex));
                    if (!reader.IsDBNull(productPackageOrder_IDColumnIndex))
                        record.ProductPackageOrder_ID = Convert.ToInt32(reader.GetValue(productPackageOrder_IDColumnIndex));
                    if (!reader.IsDBNull(productPackage_IDColumnIndex))
                        record.ProductPackage_ID = Convert.ToInt32(reader.GetValue(productPackage_IDColumnIndex));
                    if (!reader.IsDBNull(warehouserColumnIndex))
                        record.Warehouser = Convert.ToString(reader.GetValue(warehouserColumnIndex));
                    if (!reader.IsDBNull(positionIDColumnIndex))
                        record.PositionID = Convert.ToInt32(reader.GetValue(positionIDColumnIndex));
                    if (!reader.IsDBNull(createByColumnIndex))
                        record.CreateBy = reader.GetGuid(createByColumnIndex);
                    if (!reader.IsDBNull(createDateColumnIndex))
                        record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
                    if (!reader.IsDBNull(lastEditByColumnIndex))
                        record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
                    if (!reader.IsDBNull(lastEditDateColumnIndex))
                        record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
                    if (!reader.IsDBNull(activeColumnIndex))
                        record.Active = Convert.ToInt32(reader.GetValue(activeColumnIndex));

                    if (ri == length && 0 != totalRecordCount)
                        break;
                }
            }

            if (0 == totalRecordCount)
                totalRecordCount = ri + startIndex;
            else
                totalRecordCount = -1;

            return (WarehouseImportNoteRow[])(recordList.ToArray(typeof(WarehouseImportNoteRow)));
        }

        /// <summary>
        /// Reads data using the specified command and returns 
        /// a filled <see cref="System.Data.DataTable"/> object.
        /// </summary>
        /// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected DataTable MapRecordsToDataTable(IDbCommand command)
        {
            string LOCATION = "MapRecordsToDataTable(IDbCommand command)";
            IDataReader reader = _db.ExecuteReader(command);
            try
            {
                return MapRecordsToDataTable(reader);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                reader.Dispose();
                _db.Dispose();
            }
        }

        /// <summary>
        /// Reads data from the provided data reader and returns 
        /// a filled <see cref="System.Data.DataTable"/> object.
        /// </summary>
        /// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected DataTable MapRecordsToDataTable(IDataReader reader)
        {
            int totalRecordCount = 0;
            return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
        }

        /// <summary>
        /// Reads data from the provided data reader and returns 
        /// a filled <see cref="System.Data.DataTable"/> object.
        /// </summary>
        /// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
        /// <param name="startIndex">The index of the first record to read.</param>
        /// <param name="length">The number of records to read.</param>
        /// <param name="totalRecordCount">A reference parameter that returns the total number 
        /// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected virtual DataTable MapRecordsToDataTable(IDataReader reader,
                                            int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = "MapRecordsToDataTable(reader,startIndex,length,ref totalRecordCount)";
            if (0 > startIndex)
                throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
            if (0 > length)
                throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");
            int columnCount = reader.FieldCount;
            int ri = -startIndex;

            DataTable dataTable = CreateDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                ri++;
                if (ri > 0 && ri <= length)
                {
                    reader.GetValues(values);
                    dataTable.LoadDataRow(values, true);
                    if (ri == length && 0 != totalRecordCount)
                        break;
                }
            }
            dataTable.EndLoadData();

            if (0 == totalRecordCount)
                totalRecordCount = ri + startIndex;
            else
                totalRecordCount = -1;

            return dataTable;
        }

        /// <summary>
        /// Converts <see cref="System.Data.DataRow"/> to <see cref="WarehouseImportNoteRow"/>.
        /// </summary>
        /// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
        /// <returns>A reference to the <see cref="WarehouseImportNoteRow"/> object.</returns>
        protected virtual WarehouseImportNoteRow MapRow(DataRow row)
        {
            string LOCATION = "WarehouseImportNoteRow MapRow(DataRow row)";
            WarehouseImportNoteRow mappedObject = new WarehouseImportNoteRow();
            DataTable dataTable = row.Table;
            DataColumn dataColumn;
            // Column "WarehouseImportNote_ID"
            dataColumn = dataTable.Columns["WarehouseImportNote_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.WarehouseImportNote_ID = (int)(row[dataColumn]);
            // Column "ProductBrand_ID"
            dataColumn = dataTable.Columns["ProductBrand_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
            // Column "Warehouse_ID"
            dataColumn = dataTable.Columns["Warehouse_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.Warehouse_ID = (int)(row[dataColumn]);
            // Column "WarehouseImportNoteType_ID"
            dataColumn = dataTable.Columns["WarehouseImportNoteType_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.WarehouseImportNoteType_ID = (int)(row[dataColumn]);
            // Column "ProductType"
            dataColumn = dataTable.Columns["ProductType"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductType = (int)(row[dataColumn]);
            // Column "Product_ID"
            dataColumn = dataTable.Columns["Product_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.Product_ID = (int)(row[dataColumn]);
            // Column "ProductPackage_ID"
            dataColumn = dataTable.Columns["ProductPackage_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductPackage_ID = (int)(row[dataColumn]);
            // Column "ProductPackageOrder_ID"
            dataColumn = dataTable.Columns["ProductPackageOrder_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductPackageOrder_ID = (int)(row[dataColumn]);
            // Column "Description"
            dataColumn = dataTable.Columns["Description"];
            if (!row.IsNull(dataColumn))
                mappedObject.Description = (string)(row[dataColumn]);
            // Column "Warehouser"
            dataColumn = dataTable.Columns["Warehouser"];
            if (!row.IsNull(dataColumn))
                mappedObject.Warehouser = (string)(row[dataColumn]);
            // Column "PositionID"
            dataColumn = dataTable.Columns["PositionID"];
            if (!row.IsNull(dataColumn))
                mappedObject.PositionID = (int)(row[dataColumn]);
            // Column "CreateBy"
            dataColumn = dataTable.Columns["CreateBy"];
            if (!row.IsNull(dataColumn))
                mappedObject.CreateBy = (System.Guid)(row[dataColumn]);
            // Column "CreateDate"
            dataColumn = dataTable.Columns["CreateDate"];
            if (!row.IsNull(dataColumn))
                mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
            // Column "LastEditBy"
            dataColumn = dataTable.Columns["LastEditBy"];
            if (!row.IsNull(dataColumn))
                mappedObject.LastEditBy = (System.Guid)(row[dataColumn]);
            // Column "LastEditDate"
            dataColumn = dataTable.Columns["LastEditDate"];
            if (!row.IsNull(dataColumn))
                mappedObject.LastEditDate = (System.DateTime)(row[dataColumn]);
            // Column "Active"
            dataColumn = dataTable.Columns["Active"];
            if (!row.IsNull(dataColumn))
                mappedObject.Active = (int)(row[dataColumn]);
            return mappedObject;
        }

        /// <summary>
        /// Creates a <see cref="System.Data.DataTable"/> object for 
        /// the <c>WarehouseImportNote</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected virtual DataTable CreateDataTable()
        {
            string LOCATION = "CreateDataTable()";
            DataTable dataTable = new DataTable();
            dataTable.TableName = "WarehouseImportNote";
            DataColumn dataColumn;
            // Create the "WarehouseImportNote_ID" column
            dataColumn = dataTable.Columns.Add("WarehouseImportNote_ID", typeof(int));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            // Create the "ProductBrand_ID" column
            dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
            // Create the "Warehouse_ID" column
            dataColumn = dataTable.Columns.Add("Warehouse_ID", typeof(int));
            // Create the "WarehouseImportNoteType_ID" column
            dataColumn = dataTable.Columns.Add("WarehouseImportNoteType_ID", typeof(int));
            // Create the "ProductType" column
            dataColumn = dataTable.Columns.Add("ProductType", typeof(int));
            // Create the "Product_ID" column
            dataColumn = dataTable.Columns.Add("Product_ID", typeof(int));
            // Create the "Amount" column
            dataColumn = dataTable.Columns.Add("ProductPackage_ID", typeof(int));
            // Create the "Amount" column
            dataColumn = dataTable.Columns.Add("ProductPackageOrder_ID", typeof(decimal));
            // Create the "Description" column
            dataColumn = dataTable.Columns.Add("Description", typeof(string));
            dataColumn.MaxLength = 1073741823;
            // Create the "Name" column
            dataColumn = dataTable.Columns.Add("WareHouser", typeof(string));
            dataColumn.MaxLength = 500;
            // Create the "Exporter" column
            dataColumn = dataTable.Columns.Add("PositionID", typeof(int));
            dataColumn.MaxLength = 500;
            // Create the "CreateBy" column
            dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
            // Create the "CreateDate" column
            dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
            // Create the "LastEditBy" column
            dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
            // Create the "LastEditDate" column
            dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
            // Create the "Active" column
            dataColumn = dataTable.Columns.Add("Active", typeof(int));
            return dataTable;
        }

        /// <summary>
        /// Adds a new parameter to the specified command.
        /// </summary>
        /// <param name="cmd">The <see cref="System.Data.IDbCommand"/> object to add the parameter to.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <param name="value">The value of the parameter.</param>
        /// <returns>A reference to the added parameter.</returns>
        protected virtual IDbDataParameter AddParameter(IDbCommand cmd, String paramName, object value)
        {
            string LOCATION = "AddParameter(IDbCommand cmd, String paramName, object value)";
            IDbDataParameter parameter;
            switch (paramName)
            {
                case "WarehouseImportNote_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "ProductBrand_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "Warehouse_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "WarehouseImportNoteType_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "ProductType":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "Product_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "ProductPackage_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Decimal, value);
                    break;

                case "ProductPackageOrder_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Decimal, value);
                    break;

                case "Description":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Warehouser":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "PositionID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "WarehouseImportNoteCode":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Other1":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Other2":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Other3":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "CreateBy":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
                    break;

                case "CreateDate":
                    parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
                    break;

                case "LastEditBy":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
                    break;

                case "LastEditDate":
                    parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
                    break;

                case "Active":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                default:
                    throw new ArgumentException("Unknown parameter name (" + paramName + ").");
            }
            return parameter;
        }

        /// <summary>
        /// Exist <see cref="WarehouseImportNoteRow"/> by the primary key.
        /// </summary>
        /// <param name="WarehouseImportNote_ID">The <c>WarehouseImportNote_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseImportNoteRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual bool Exist(int WarehouseImportNote_ID)
        {
            string LOCATION = "Exist(int WarehouseImportNote_ID)";
            IDbCommand cmd = _db.CreateCommand("WarehouseImportNote_GetByPrimaryKey", CommandType.StoredProcedure);
            AddParameter(cmd, "WarehouseImportNote_ID", WarehouseImportNote_ID);
            WarehouseImportNoteRow[] tempArray = MapRecords(cmd);
            if (0 == tempArray.Length)
                return false;
            return true;
        }

    }
}




