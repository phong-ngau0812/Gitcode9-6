
// <fileinfo name="Base\WarehouseExportNoteDetailCollectionBase.cs">
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


namespace Base
{

    /// <summary>
    /// The base class for <see cref="WarehouseExportNoteDetailCollection"/>. Provides methods 
    /// for common database table operations. 
    /// </summary>
    /// <remarks>
    /// Do not change this source code. Update the <see cref="WarehouseExportNoteDetailCollection"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseExportNoteDetailCollectionBase
        : Base.ConllectionBase

    {
        // Constants
        public const string WarehouseExportNoteDetailIDColumnName = "WarehouseExportNoteDetailID";
        public const string WarehouseExportNoteIDColumnName = "WarehouseExportNoteID";
        public const string ProductNameColumnName = "ProductName";
        public const string ProductSkuColumnName = "ProductSku";
        public const string ProductSkuEffectColumnName = "ProductSkuEffect";
        public const string ProductNumberColumnName = "ProductNumber";
        public const string ProductNumberRealColumnName = "ProductNumberReal";
        public const string ProductPriorityColumnName = "ProductPriority";
        public const string UnitColumnName = "Unit";
        public const string WeightColumnName = "Weight";
        public const string WeightRealColumnName = "WeightReal";
        public const string CreatedDateColumnName = "CreatedDate";
        public const string Other1ColumnName = "Other1";
        public const string Other2ColumnName = "Other2";
        public const string Other3ColumnName = "Other3";


        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
        /// class with the specified <see cref="Database"/>.
        /// </summary>
        /// <param name="db">The <see cref="Database"/> object.</param>
        public WarehouseExportNoteDetailCollectionBase(Database db) : base(db)
        {
            this.TABLENAME = "WarehouseExportNoteDetail";
        }

        public WarehouseExportNoteDetailCollectionBase() : base()
        {
            this.TABLENAME = "WarehouseExportNoteDetail";
        }



        /// <summary>
        /// Gets an array of all records from the <c>WarehouseExportNoteDetail</c> table.
        /// </summary>
        /// <returns>An array of <see cref="WarehouseExportNoteDetailRow"/> objects.</returns>
        public virtual WarehouseExportNoteDetailRow[] GetAll()
        {
            return MapRecords(CreateGetAllCommand());
        }

        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object that 
        /// includes all records from the <c>WarehouseExportNoteDetail</c> table.
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
        /// to retrieve all records from the <c>WarehouseExportNoteDetail</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetAllCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseExportNoteDetail_GetAll", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        public virtual DataTable GetByWarehouseExportNote_IDAsDataTable(int WarehouseExportNote_ID)
        {
            string LOCATION = "GetByWarehouseExportNote_IDAsDataTable()";
            try
            {
                return MapRecordsToDataTable(GetByWarehouseExportNote_ID(WarehouseExportNote_ID));
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        protected virtual IDbCommand GetByWarehouseExportNote_ID(int WarehouseExportNote_ID)
        {
            string LOCATION = "";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetail_GetByWarehouseExportNote_ID", CommandType.StoredProcedure);
                _db.AddParameter(cmd, "WarehouseExportNoteID", DbType.String, WarehouseExportNote_ID);
                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        

        /// <summary>
        /// Gets the first <see cref="WarehouseExportNoteDetailRow"/> objects that 
        /// match the search condition.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>An instance of <see cref="WarehouseExportNoteDetailRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public WarehouseExportNoteDetailRow GetRow(string whereSql)
        {
            string LOCATION = "GetRow(string whereSql)";
            try
            {
                int totalRecordCount = -1;
                WarehouseExportNoteDetailRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
        /// Gets an array of <see cref="WarehouseExportNoteDetailRow"/> objects that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
        /// <returns>An array of <see cref="WarehouseExportNoteDetailRow"/> objects.</returns>
        public WarehouseExportNoteDetailRow[] GetAsArray(string whereSql, string orderBySql)
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
        /// Gets an array of <see cref="WarehouseExportNoteDetailRow"/> objects that 
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
        /// <returns>An array of <see cref="WarehouseExportNoteDetailRow"/> objects.</returns>
        public virtual WarehouseExportNoteDetailRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
            IDataReader reader = null;
            IDbCommand cmd = null;
            try
            {
                cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
                reader = _db.ExecuteReader(cmd);
                WarehouseExportNoteDetailRow[] rows = MapRecords(reader);
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
                IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetail_GetAdHoc", CommandType.StoredProcedure);
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
                IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetail_GetPageAdHoc", CommandType.StoredProcedure);

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
        /// Gets <see cref="WarehouseExportNoteDetailRow"/> by the primary key.
        /// </summary>
        /// <param name="WarehouseExportNoteDetail_ID">The <c>WarehouseExportNoteDetail_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseExportNoteDetailRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual WarehouseExportNoteDetailRow GetByPrimaryKey(int WarehouseExportNoteDetail_ID)
        {
            string LOCATION = "GetByPrimaryKey(int WarehouseExportNoteDetail_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetail_GetByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "WarehouseExportNoteDetail_ID", WarehouseExportNoteDetail_ID);
                WarehouseExportNoteDetailRow[] tempArray = MapRecords(cmd);
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
        /// Adds a new record into the <c>WarehouseExportNoteDetail</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseExportNoteDetailRow"/> object to be inserted.</param>
        public virtual void Insert(WarehouseExportNoteDetailRow value)
        {
            string LOCATION = "Insert(WarehouseExportNoteDetailRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetail_Insert", CommandType.StoredProcedure);
                // WarehouseExportNoteID
                if (value.IsWarehouseExportNoteIDNull)
                    AddParameter(cmd, "WarehouseExportNoteID", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseExportNoteID", value.WarehouseExportNoteID);

                // ProductName
                if (value.IsProductName_IDNull)
                    AddParameter(cmd, "ProductName", DBNull.Value);
                else
                    AddParameter(cmd, "ProductName", value.ProductName);

                // ProductSku
                if (value.IsProductSkuNull)
                    AddParameter(cmd, "ProductSku", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSku", value.ProductSku);
                // ProductNumber
                if (value.IsProductNumberNull)
                    AddParameter(cmd, "ProductNumber", DBNull.Value);
                else
                    AddParameter(cmd, "ProductNumber", value.ProductNumber);
                // ProductNumberReal
                if (value.IsProductNumberRealNull)
                    AddParameter(cmd, "ProductNumberReal", DBNull.Value);
                else
                    AddParameter(cmd, "ProductNumberReal", value.ProductNumberReal);
                // ProductPriority
                if (value.IsProductPriorityNull)
                    AddParameter(cmd, "ProductPriority", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPriority", value.ProductPriority);

                // ProductSkuEffect
                if (value.IsProductSkuEffectNull)
                    AddParameter(cmd, "ProductSkuEffect", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSkuEffect", value.ProductSkuEffect);

                // Unit
                if (value.IsUnitNull)
                    AddParameter(cmd, "Unit", DBNull.Value);
                else
                    AddParameter(cmd, "Unit", value.Unit);

                // Weight
                if (value.IsWeightNull)
                    AddParameter(cmd, "Weight", DBNull.Value);
                else
                    AddParameter(cmd, "Weight", value.Weight);
                // WeightReal
                if (value.IsWeightRealNull)
                    AddParameter(cmd, "WeightReal", DBNull.Value);
                else
                    AddParameter(cmd, "WeightReal", value.WeightReal);
                // CreatedDate
                if (value.IsCreatedDateNull)
                    AddParameter(cmd, "CreatedDate", DBNull.Value);
                else
                    AddParameter(cmd, "CreatedDate", value.CreatedDate);
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


                value.WarehouseExportNoteDetailID = Convert.ToInt32(cmd.ExecuteScalar());
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
        /// Updates a record in the <c>WarehouseExportNoteDetail</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseExportNoteDetailRow"/>
        /// object used to update the table record.</param>
        /// <returns>true if the record was updated; otherwise, false.</returns>
        public virtual bool Update(WarehouseExportNoteDetailRow value)
        {
            string LOCATION = "Update(WarehouseExportNoteDetailRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetail_Save", CommandType.StoredProcedure);
                // WarehouseExportNoteID
                if (value.IsWarehouseExportNoteIDNull)
                    AddParameter(cmd, "WarehouseExportNoteID", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseExportNoteID", value.WarehouseExportNoteID);

                // ProductName
                if (value.IsProductName_IDNull)
                    AddParameter(cmd, "ProductName", DBNull.Value);
                else
                    AddParameter(cmd, "ProductName", value.ProductName);

                // ProductSku
                if (value.IsProductSkuNull)
                    AddParameter(cmd, "ProductSku", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSku", value.ProductSku);
                // ProductNumber
                if (value.IsProductNumberNull)
                    AddParameter(cmd, "ProductNumber", DBNull.Value);
                else
                    AddParameter(cmd, "ProductNumber", value.ProductNumber);
                // ProductNumberReal
                if (value.IsProductNumberRealNull)
                    AddParameter(cmd, "ProductNumberReal", DBNull.Value);
                else
                    AddParameter(cmd, "ProductNumberReal", value.ProductNumberReal);
                // ProductPriority
                if (value.IsProductPriorityNull)
                    AddParameter(cmd, "ProductPriority", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPriority", value.ProductPriority);

                // ProductSkuEffect
                if (value.IsProductSkuEffectNull)
                    AddParameter(cmd, "ProductSkuEffect", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSkuEffect", value.ProductSkuEffect);

                // Unit
                if (value.IsUnitNull)
                    AddParameter(cmd, "Unit", DBNull.Value);
                else
                    AddParameter(cmd, "Unit", value.Unit);

                // Weight
                if (value.IsWeightNull)
                    AddParameter(cmd, "Weight", DBNull.Value);
                else
                    AddParameter(cmd, "Weight", value.Weight);
                // WeightReal
                if (value.IsWeightRealNull)
                    AddParameter(cmd, "WeightReal", DBNull.Value);
                else
                    AddParameter(cmd, "WeightReal", value.WeightReal);
                // CreatedDate
                if (value.IsCreatedDateNull)
                    AddParameter(cmd, "CreatedDate", DBNull.Value);
                else
                    AddParameter(cmd, "CreatedDate", value.CreatedDate);
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

                AddParameter(cmd, "WarehouseExportNoteDetail_ID", value.WarehouseExportNoteDetailID);
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
        /// Inserts or Updates a record in the <c>WarehouseExportNoteDetail</c> table.
        /// If a row with the specified primary key exists then it is updated
        /// otehrwise, a new row is added.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseExportNoteDetailRow"/>
        /// object used to save the table record.</param>
        public virtual void Save(WarehouseExportNoteDetailRow value)
        {
            string LOCATION = "Save(WarehouseExportNoteDetailRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetail_Save", CommandType.StoredProcedure);
                // WarehouseExportNoteID
                // WarehouseExportNoteID
                if (value.IsWarehouseExportNoteIDNull)
                    AddParameter(cmd, "WarehouseExportNoteID", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseExportNoteID", value.WarehouseExportNoteID);

                // ProductName
                if (value.IsProductName_IDNull)
                    AddParameter(cmd, "ProductName", DBNull.Value);
                else
                    AddParameter(cmd, "ProductName", value.ProductName);

                // ProductSku
                if (value.IsProductSkuNull)
                    AddParameter(cmd, "ProductSku", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSku", value.ProductSku);
                // ProductNumber
                if (value.IsProductNumberNull)
                    AddParameter(cmd, "ProductNumber", DBNull.Value);
                else
                    AddParameter(cmd, "ProductNumber", value.ProductNumber);
                // ProductNumberReal
                if (value.IsProductNumberRealNull)
                    AddParameter(cmd, "ProductNumberReal", DBNull.Value);
                else
                    AddParameter(cmd, "ProductNumberReal", value.ProductNumberReal);
                // ProductPriority
                if (value.IsProductPriorityNull)
                    AddParameter(cmd, "ProductPriority", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPriority", value.ProductPriority);

                // ProductSkuEffect
                if (value.IsProductSkuEffectNull)
                    AddParameter(cmd, "ProductSkuEffect", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSkuEffect", value.ProductSkuEffect);

                // Unit
                if (value.IsUnitNull)
                    AddParameter(cmd, "Unit", DBNull.Value);
                else
                    AddParameter(cmd, "Unit", value.Unit);

                // Weight
                if (value.IsWeightNull)
                    AddParameter(cmd, "Weight", DBNull.Value);
                else
                    AddParameter(cmd, "Weight", value.Weight);
                // WeightReal
                if (value.IsWeightRealNull)
                    AddParameter(cmd, "WeightReal", DBNull.Value);
                else
                    AddParameter(cmd, "WeightReal", value.WeightReal);
                // CreatedDate
                if (value.IsCreatedDateNull)
                    AddParameter(cmd, "CreatedDate", DBNull.Value);
                else
                    AddParameter(cmd, "CreatedDate", value.CreatedDate);
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
                AddParameter(cmd, "WarehouseExportNoteDetail_ID", value.WarehouseExportNoteDetailID);
                value.WarehouseExportNoteDetailID = Convert.ToInt32(cmd.ExecuteScalar());
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
                                DeleteByPrimaryKey((int)row["WarehouseExportNoteDetail_ID"]);
                            }
                            finally
                            {
                                row.Delete();
                            }
                            if (acceptChanges)
                                row.AcceptChanges();
                            break;

                        case DataRowState.Modified:
                            Save(MapRow(row));
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
        /// Deletes the specified object from the <c>WarehouseExportNoteDetail</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseExportNoteDetailRow"/> object to delete.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public bool Delete(WarehouseExportNoteDetailRow value)
        {
            return DeleteByPrimaryKey(value.WarehouseExportNoteDetailID);
        }

        /// <summary>
        /// Deletes a record from the <c>WarehouseExportNoteDetail</c> table using
        /// the specified primary key.
        /// </summary>
        /// <param name="WarehouseExportNoteDetail_ID">The <c>WarehouseExportNoteDetail_ID</c> column value.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public virtual bool DeleteByPrimaryKey(int WarehouseExportNoteDetail_ID)
        {
            string LOCATION = "DeleteByPrimaryKey(int WarehouseExportNoteDetail_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetail_DeleteByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "WarehouseExportNoteDetail_ID", WarehouseExportNoteDetail_ID);
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
        public virtual bool DeleteByWarehouseExportNoteID(int WarehouseExportNoteID)
        {
            string LOCATION = "DeleteByWarehouseExportNoteID(int WarehouseExportNoteID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetail_DeleteByWarehouseExportNoteID", CommandType.StoredProcedure);
                AddParameter(cmd, "WarehouseExportNoteID", WarehouseExportNoteID);
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
        /// Deletes <c>WarehouseExportNoteDetail</c> records that match the specified criteria.
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
        /// to delete <c>WarehouseExportNoteDetail</c> records that match the specified criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. 
        /// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateDeleteCommand(string whereSql)
        {
            string LOCATION = "CreateDeleteCommand(String whereSql)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetail_DeleteAdHoc", CommandType.StoredProcedure);

                _db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Deletes all records from the <c>WarehouseExportNoteDetail</c> table.
        /// </summary>
        /// <returns>The number of deleted records.</returns>
        public int DeleteAll()
        {
            string LOCATION = "DeleteAll()";
            try
            {
                return _db.CreateCommand("WarehouseExportNoteDetail_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
        /// <returns>An array of <see cref="WarehouseExportNoteDetailRow"/> objects.</returns>
        protected WarehouseExportNoteDetailRow[] MapRecords(IDbCommand command)
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
        /// <returns>An array of <see cref="WarehouseExportNoteDetailRow"/> objects.</returns>
        protected WarehouseExportNoteDetailRow[] MapRecords(IDataReader reader)
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
        /// <returns>An array of <see cref="WarehouseExportNoteDetailRow"/> objects.</returns>
        protected virtual WarehouseExportNoteDetailRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = " MapRecords(...)";
            if (0 > startIndex)
                throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
            if (0 > length)
                throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

            // WarehouseExportNoteDetailID
            int WarehouseExportNoteDetailIDColumnIndex = reader.GetOrdinal("WarehouseExportNoteDetailID");
            // WarehouseExportNoteID
            int WarehouseExportNoteIDColumnIndex = reader.GetOrdinal("WarehouseExportNoteID");
            // ProductName
            int ProductNameColumnIndex = reader.GetOrdinal("ProductName");
            // ProductSku
            int ProductSkuColumnIndex = reader.GetOrdinal("ProductSku");
            // ProductNumber
            int ProductNumberColumnIndex = reader.GetOrdinal("ProductNumber");
            // ProductNumberReal
            int ProductNumberRealColumnIndex = reader.GetOrdinal("ProductNumberReal");
            // ProductPriority
            int ProductPriorityColumnIndex = reader.GetOrdinal("ProductPriority");
            // ProductSkuEffect
            int ProductSkuEffectColumnIndex = reader.GetOrdinal("ProductSkuEffect");
            // Unit
            int UnitColumnIndex = reader.GetOrdinal("Unit");
            // Weight
            int WeightColumnIndex = reader.GetOrdinal("Weight");
            // WeightReal
            int WeightRealColumnIndex = reader.GetOrdinal("WeightReal");
            // CreatedDate
            int createdDateColumnIndex = reader.GetOrdinal("CreatedDate");
            // Other1
            int Other1ColumnIndex = reader.GetOrdinal("Other1");
            // Other2
            int Other2ColumnIndex = reader.GetOrdinal("Other2");
            // Other3
            int Other3ColumnIndex = reader.GetOrdinal("Other3");

            System.Collections.ArrayList recordList = new System.Collections.ArrayList();
            int ri = -startIndex;
            while (reader.Read())
            {
                ri++;
                if (ri > 0 && ri <= length)
                {
                    WarehouseExportNoteDetailRow record = new WarehouseExportNoteDetailRow();
                    recordList.Add(record);

                    record.WarehouseExportNoteDetailID = Convert.ToInt32(reader.GetValue(WarehouseExportNoteDetailIDColumnIndex));
                    if (!reader.IsDBNull(WarehouseExportNoteIDColumnIndex))
                        record.WarehouseExportNoteID = Convert.ToInt32(reader.GetValue(WarehouseExportNoteIDColumnIndex));
                    if (!reader.IsDBNull(ProductNameColumnIndex))
                        record.ProductName = Convert.ToString(reader.GetValue(ProductNameColumnIndex));
                    if (!reader.IsDBNull(ProductSkuColumnIndex))
                        record.ProductSku = Convert.ToString(reader.GetValue(ProductSkuColumnIndex));
                    if (!reader.IsDBNull(ProductNumberColumnIndex))
                        record.ProductNumber = Convert.ToInt32(reader.GetValue(ProductNumberColumnIndex));
                    if (!reader.IsDBNull(ProductNumberRealColumnIndex))
                        record.ProductNumberReal = Convert.ToInt32(reader.GetValue(ProductNumberRealColumnIndex));
                    if (!reader.IsDBNull(ProductPriorityColumnIndex))
                        record.ProductPriority = Convert.ToInt32(reader.GetValue(ProductPriorityColumnIndex));
                    if (!reader.IsDBNull(ProductSkuEffectColumnIndex))
                        record.ProductSkuEffect = Convert.ToString(reader.GetValue(ProductSkuEffectColumnIndex));
                    if (!reader.IsDBNull(UnitColumnIndex))
                        record.Unit = Convert.ToString(reader.GetValue(UnitColumnIndex));
                    if (!reader.IsDBNull(WeightColumnIndex))
                        record.Weight = Convert.ToString(reader.GetValue(WeightColumnIndex));
                    if (!reader.IsDBNull(WeightRealColumnIndex))
                        record.WeightReal = Convert.ToString(reader.GetValue(WeightRealColumnIndex));
                    if (!reader.IsDBNull(createdDateColumnIndex))
                        record.CreatedDate = Convert.ToDateTime(reader.GetValue(createdDateColumnIndex));
                    if (!reader.IsDBNull(Other1ColumnIndex))
                        record.Other1 = Convert.ToString(reader.GetValue(Other1ColumnIndex));
                    if (!reader.IsDBNull(Other2ColumnIndex))
                        record.Other2 = Convert.ToString(reader.GetValue(Other2ColumnIndex));
                    if (!reader.IsDBNull(Other3ColumnIndex))
                        record.Other3 = Convert.ToString(reader.GetValue(Other3ColumnIndex));

                    if (ri == length && 0 != totalRecordCount)
                        break;
                }
            }

            if (0 == totalRecordCount)
                totalRecordCount = ri + startIndex;
            else
                totalRecordCount = -1;

            return (WarehouseExportNoteDetailRow[])(recordList.ToArray(typeof(WarehouseExportNoteDetailRow)));
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
        /// Converts <see cref="System.Data.DataRow"/> to <see cref="WarehouseExportNoteDetailRow"/>.
        /// </summary>
        /// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
        /// <returns>A reference to the <see cref="WarehouseExportNoteDetailRow"/> object.</returns>
        protected virtual WarehouseExportNoteDetailRow MapRow(DataRow row)
        {
            string LOCATION = "WarehouseExportNoteDetailRow MapRow(DataRow row)";
            WarehouseExportNoteDetailRow mappedObject = new WarehouseExportNoteDetailRow();
            DataTable dataTable = row.Table;
            DataColumn dataColumn;
            // Column "WarehouseExportNoteDetailID"
            dataColumn = dataTable.Columns["WarehouseExportNoteDetailID"];
            if (!row.IsNull(dataColumn))
                mappedObject.WarehouseExportNoteDetailID = (int)(row[dataColumn]);
            // Column "WarehouseExportNoteID"
            dataColumn = dataTable.Columns["WarehouseExportNoteID"];
            if (!row.IsNull(dataColumn))
                mappedObject.WarehouseExportNoteID = (int)(row[dataColumn]);
            // Column "ProductName"
            dataColumn = dataTable.Columns["ProductName"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductName = (string)(row[dataColumn]);
            // Column "ProductSku"
            dataColumn = dataTable.Columns["ProductSku"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductSku = (string)(row[dataColumn]);
            // Column "ProductNumber"
            dataColumn = dataTable.Columns["ProductNumber"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductNumber = (int)(row[dataColumn]);
            // Column "ProductNumberReal"
            dataColumn = dataTable.Columns["ProductNumberReal"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductNumberReal = (int)(row[dataColumn]);
            // Column "ProductPriority"
            dataColumn = dataTable.Columns["ProductPriority"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductPriority = (int)(row[dataColumn]);
            // Column "ProductSkuEffect"
            dataColumn = dataTable.Columns["ProductSkuEffect"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductSkuEffect = (string)(row[dataColumn]);
            // Column "Unit"
            dataColumn = dataTable.Columns["Unit"];
            if (!row.IsNull(dataColumn))
                mappedObject.Unit = (string)(row[dataColumn]);
            // Column "Weight"
            dataColumn = dataTable.Columns["Weight"];
            if (!row.IsNull(dataColumn))
                mappedObject.Weight = (string)(row[dataColumn]);
            // Column "WeightReal"
            dataColumn = dataTable.Columns["WeightReal"];
            if (!row.IsNull(dataColumn))
                mappedObject.WeightReal = (string)(row[dataColumn]);
            // Column "CreatedDate"
            dataColumn = dataTable.Columns["CreatedDate"];
            if (!row.IsNull(dataColumn))
                mappedObject.CreatedDate = (System.DateTime)(row[dataColumn]);
            // Column "Other1"
            dataColumn = dataTable.Columns["Other1"];
            if (!row.IsNull(dataColumn))
                mappedObject.Other1 = (string)(row[dataColumn]);
            // Column "Other2"
            dataColumn = dataTable.Columns["Other2"];
            if (!row.IsNull(dataColumn))
                mappedObject.Other2 = (string)(row[dataColumn]);
            // Column "Other3"
            dataColumn = dataTable.Columns["Other3"];
            if (!row.IsNull(dataColumn))
                mappedObject.Other3 = (string)(row[dataColumn]);
            return mappedObject;
        }

        /// <summary>
        /// Creates a <see cref="System.Data.DataTable"/> object for 
        /// the <c>WarehouseExportNoteDetail</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected virtual DataTable CreateDataTable()
        {
            string LOCATION = "CreateDataTable()";
            DataTable dataTable = new DataTable();
            dataTable.TableName = "WarehouseExportNoteDetail";
            DataColumn dataColumn;
            // Create the "WarehouseExportNoteDetail_ID" column
            dataColumn = dataTable.Columns.Add("WarehouseExportNoteDetailID", typeof(int));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            // Create the "WarehouseExportNoteID" column
            dataColumn = dataTable.Columns.Add("WarehouseExportNoteID", typeof(int));
            // Create the "ProductName" column
            dataColumn = dataTable.Columns.Add("ProductName", typeof(string));
            // Create the "ProductSkuEffect" column
            dataColumn = dataTable.Columns.Add("ProductSkuEffect", typeof(string));
            // Create the "ProductSku" column
            dataColumn = dataTable.Columns.Add("ProductSku", typeof(string));
            // Create the "ProductNumber" column
            dataColumn = dataTable.Columns.Add("ProductNumber", typeof(int));
            // Create the "ProductNumberReal" column
            dataColumn = dataTable.Columns.Add("ProductNumberReal", typeof(int));
            // Create the "ProductPriority" column
            dataColumn = dataTable.Columns.Add("ProductPriority", typeof(int));
            // Create the "Unit" column
            dataColumn = dataTable.Columns.Add("Unit", typeof(string));
            // Create the "Weight" column
            dataColumn = dataTable.Columns.Add("Weight", typeof(string));
            // Create the "WeightReal" column
            dataColumn = dataTable.Columns.Add("WeightReal", typeof(string));
            // Create the "CreatedDate" column
            dataColumn = dataTable.Columns.Add("CreatedDate", typeof(System.DateTime));
            // Create the "Other1" column
            dataColumn = dataTable.Columns.Add("Other1", typeof(string));
            // Create the "Other2" column
            dataColumn = dataTable.Columns.Add("Other2", typeof(string));
            // Create the "Other3" column
            dataColumn = dataTable.Columns.Add("Other3", typeof(string));
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
                case "WarehouseExportNoteDetailID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "WarehouseExportNoteDetail_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "WarehouseExportNoteID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "ProductName":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "ProductSku":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "ProductNumber":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;
                case "ProductNumberReal":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;
                case "ProductPriority":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "ProductSkuEffect":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Unit":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Weight":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;
                case "WeightReal":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "CreatedDate":
                    parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
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

                default:
                    throw new ArgumentException("Unknown parameter name (" + paramName + ").");
            }
            return parameter;
        }

        /// <summary>
        /// Exist <see cref="WarehouseExportNoteDetailRow"/> by the primary key.
        /// </summary>
        /// <param name="WarehouseExportNoteDetail_ID">The <c>WarehouseExportNoteDetail_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseExportNoteDetailRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual bool Exist(int WarehouseExportNoteDetail_ID)
        {
            string LOCATION = "Exist(int WarehouseExportNoteDetail_ID)";
            IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetail_GetByPrimaryKey", CommandType.StoredProcedure);
            AddParameter(cmd, "WarehouseExportNoteDetail_ID", WarehouseExportNoteDetail_ID);
            WarehouseExportNoteDetailRow[] tempArray = MapRecords(cmd);
            if (0 == tempArray.Length)
                return false;
            return true;
        }

    }
}




