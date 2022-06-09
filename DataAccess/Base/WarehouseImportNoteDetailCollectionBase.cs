
// <fileinfo name="Base\WarehouseImportNoteDetailCollectionBase.cs">
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
    /// The base class for <see cref="WarehouseImportNoteDetailCollection"/>. Provides methods 
    /// for common database table operations. 
    /// </summary>
    /// <remarks>
    /// Do not change this source code. Update the <see cref="WarehouseImportNoteDetailCollection"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseImportNoteDetailCollectionBase
        : Base.ConllectionBase

    {
        // Constants
        public const string WarehouseImportNoteDetailIDColumnName = "WarehouseImportNoteDetailID";
        public const string WarehouseImportNoteIDColumnName = "WarehouseImportNoteID";
        public const string ProductNameColumnName = "ProductName";
        public const string ProductSkuColumnName = "ProductSku";
        public const string ProductNumberColumnName = "ProductNumber";
        public const string ProductSkuEffectColumnName = "ProductSkuEffect";
        public const string SerialNumberStartColumnName = "SerialNumberStart";
        public const string SerialNumberEndColumnName = "SerialNumberEnd";
        public const string ColorColumnName = "Color";
        public const string ProductPackage_IDColumnName = "ProductPackage_ID";
        public const string UnitColumnName = "Unit";
        public const string ProductImportTypeColumnName = "ProductImportType";
        public const string WeightColumnName = "Weight";
        public const string PositionIDColumnName = "PositionID";
        public const string supplierColumnName = "supplier";
        public const string MadeInColumnName = "MadeIn";
        public const string Pallet_IDColumnName = "Pallet_ID";
        public const string ProductPartNumberColumnName = "ProductPartNumber";
        public const string ProductPartDetailColumnName = "ProductPartDetail";
        public const string CreatedDateColumnName = "CreatedDate";
        public const string QrCodeWarehousePublicColumnName = "QrCodeWarehousePublic";


        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
        /// class with the specified <see cref="Database"/>.
        /// </summary>
        /// <param name="db">The <see cref="Database"/> object.</param>
        public WarehouseImportNoteDetailCollectionBase(Database db) : base(db)
        {
            this.TABLENAME = "WarehouseImportNoteDetail";
        }

        public WarehouseImportNoteDetailCollectionBase() : base()
        {
            this.TABLENAME = "WarehouseImportNoteDetail";
        }



        /// <summary>
        /// Gets an array of all records from the <c>WarehouseImportNoteDetail</c> table.
        /// </summary>
        /// <returns>An array of <see cref="WarehouseImportNoteDetailRow"/> objects.</returns>
        public virtual WarehouseImportNoteDetailRow[] GetAll()
        {
            return MapRecords(CreateGetAllCommand());
        }

        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object that 
        /// includes all records from the <c>WarehouseImportNoteDetail</c> table.
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
        /// to retrieve all records from the <c>WarehouseImportNoteDetail</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetAllCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseImportNoteDetail_GetAll", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        public virtual DataTable GetByWarehouseImportNote_IDAsDataTable(int WarehouseImportNote_ID)
        {
            string LOCATION = "GetByWarehouseImportNote_IDAsDataTable()";
            try
            {
                return MapRecordsToDataTable(GetByWarehouseImportNote_ID(WarehouseImportNote_ID));
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        protected virtual IDbCommand GetByWarehouseImportNote_ID(int WarehouseImportNote_ID)
        {
            string LOCATION = "";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNoteDetail_GetByWarehouseImportNote_ID", CommandType.StoredProcedure);
                _db.AddParameter(cmd, "WarehouseImportNoteID", DbType.String, WarehouseImportNote_ID);
                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        

        /// <summary>
        /// Gets the first <see cref="WarehouseImportNoteDetailRow"/> objects that 
        /// match the search condition.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>An instance of <see cref="WarehouseImportNoteDetailRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public WarehouseImportNoteDetailRow GetRow(string whereSql)
        {
            string LOCATION = "GetRow(string whereSql)";
            try
            {
                int totalRecordCount = -1;
                WarehouseImportNoteDetailRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
        /// Gets an array of <see cref="WarehouseImportNoteDetailRow"/> objects that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
        /// <returns>An array of <see cref="WarehouseImportNoteDetailRow"/> objects.</returns>
        public WarehouseImportNoteDetailRow[] GetAsArray(string whereSql, string orderBySql)
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
        /// Gets an array of <see cref="WarehouseImportNoteDetailRow"/> objects that 
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
        /// <returns>An array of <see cref="WarehouseImportNoteDetailRow"/> objects.</returns>
        public virtual WarehouseImportNoteDetailRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
            IDataReader reader = null;
            IDbCommand cmd = null;
            try
            {
                cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
                reader = _db.ExecuteReader(cmd);
                WarehouseImportNoteDetailRow[] rows = MapRecords(reader);
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
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNoteDetail_GetAdHoc", CommandType.StoredProcedure);
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
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNoteDetail_GetPageAdHoc", CommandType.StoredProcedure);

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
        /// Gets <see cref="WarehouseImportNoteDetailRow"/> by the primary key.
        /// </summary>
        /// <param name="WarehouseImportNoteDetail_ID">The <c>WarehouseImportNoteDetail_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseImportNoteDetailRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual WarehouseImportNoteDetailRow GetByPrimaryKey(int WarehouseImportNoteDetail_ID)
        {
            string LOCATION = "GetByPrimaryKey(int WarehouseImportNoteDetail_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNoteDetail_GetByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "WarehouseImportNoteDetail_ID", WarehouseImportNoteDetail_ID);
                WarehouseImportNoteDetailRow[] tempArray = MapRecords(cmd);
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
        /// Adds a new record into the <c>WarehouseImportNoteDetail</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseImportNoteDetailRow"/> object to be inserted.</param>
        public virtual void Insert(WarehouseImportNoteDetailRow value)
        {
            string LOCATION = "Insert(WarehouseImportNoteDetailRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNoteDetail_Insert", CommandType.StoredProcedure);
                // WarehouseImportNoteID
                if (value.IsWarehouseImportNoteIDNull)
                    AddParameter(cmd, "WarehouseImportNoteID", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseImportNoteID", value.WarehouseImportNoteID);

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

                // ProductSkuEffect
                if (value.IsProductSkuEffectNull)
                    AddParameter(cmd, "ProductSkuEffect", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSkuEffect", value.ProductSkuEffect);
                // ProductPackage_ID
                if (value.IsProductPackage_IDNull)
                    AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
                // SerialNumberStart
                if (value.IsSerialNumberStartNull)
                    AddParameter(cmd, "SerialNumberStart", DBNull.Value);
                else
                    AddParameter(cmd, "SerialNumberStart", value.SerialNumberStart);
                // SerialNumberEnd
                if (value.IsSerialNumberEndNull)
                    AddParameter(cmd, "SerialNumberEnd", DBNull.Value);
                else
                    AddParameter(cmd, "SerialNumberEnd", value.SerialNumberEnd);
                // Color
                if (value.IsColorNull)
                    AddParameter(cmd, "Color", DBNull.Value);
                else
                    AddParameter(cmd, "Color", value.Color);

                // Unit
                if (value.IsUnitNull)
                    AddParameter(cmd, "Unit", DBNull.Value);
                else
                    AddParameter(cmd, "Unit", value.Unit);

                // Description
                if (value.IsWeightNull)
                    AddParameter(cmd, "Weight", DBNull.Value);
                else
                    AddParameter(cmd, "Weight", value.Weight);

                // ProductImportType
                if (value.IsProductImportTypeNull)
                    AddParameter(cmd, "ProductImportType", DBNull.Value);
                else
                    AddParameter(cmd, "ProductImportType", value.ProductImportType);

                // PositionID
                if (value.IsPositionIDNull)
                    AddParameter(cmd, "PositionID", DBNull.Value);
                else
                    AddParameter(cmd, "PositionID", value.PositionID);

                // supplier
                if (value.IssupplierNull)
                    AddParameter(cmd, "supplier", DBNull.Value);
                else
                    AddParameter(cmd, "supplier", value.supplier);
                // MadeIn
                if (value.IsMadeInNull)
                    AddParameter(cmd, "MadeIn", DBNull.Value);
                else
                    AddParameter(cmd, "MadeIn", value.MadeIn);
                // Pallet_ID
                if (value.IsPallet_IDNull)
                    AddParameter(cmd, "Pallet_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Pallet_ID", value.Pallet_ID);
                if (value.IsProductPartNumberNull)
                    AddParameter(cmd, "ProductPartNumber", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPartNumber", value.ProductPartNumber);
                if (value.IsProductPartDetailNull)
                    AddParameter(cmd, "ProductPartDetail", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPartDetail", value.ProductPartDetail);
                if (value.QrCodeWarehousePublicNull)
                    AddParameter(cmd, "QrCodeWarehousePublic", DBNull.Value);
                else
                    AddParameter(cmd, "QrCodeWarehousePublic", value.QrCodeWarehousePublic);

                value.WarehouseImportNoteDetailID = Convert.ToInt32(cmd.ExecuteScalar());
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
        /// Updates a record in the <c>WarehouseImportNoteDetail</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseImportNoteDetailRow"/>
        /// object used to update the table record.</param>
        /// <returns>true if the record was updated; otherwise, false.</returns>
        public virtual bool Update(WarehouseImportNoteDetailRow value)
        {
            string LOCATION = "Update(WarehouseImportNoteDetailRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNoteDetail_Update", CommandType.StoredProcedure);
                // WarehouseImportNoteID
                if (value.IsWarehouseImportNoteIDNull)
                    AddParameter(cmd, "WarehouseImportNoteID", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseImportNoteID", value.WarehouseImportNoteID);

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

                // ProductSkuEffect
                if (value.IsProductSkuEffectNull)
                    AddParameter(cmd, "ProductSkuEffect", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSkuEffect", value.ProductSkuEffect);
                // ProductPackage_ID
                if (value.IsProductPackage_IDNull)
                    AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
                // SerialNumberStart
                if (value.IsSerialNumberStartNull)
                    AddParameter(cmd, "SerialNumberStart", DBNull.Value);
                else
                    AddParameter(cmd, "SerialNumberStart", value.SerialNumberStart);
                // SerialNumberEnd
                if (value.IsSerialNumberEndNull)
                    AddParameter(cmd, "SerialNumberEnd", DBNull.Value);
                else
                    AddParameter(cmd, "SerialNumberEnd", value.SerialNumberEnd);
                // Color
                if (value.IsColorNull)
                    AddParameter(cmd, "Color", DBNull.Value);
                else
                    AddParameter(cmd, "Color", value.Color);

                // Unit
                if (value.IsUnitNull)
                    AddParameter(cmd, "Unit", DBNull.Value);
                else
                    AddParameter(cmd, "Unit", value.Unit);

                // Description
                if (value.IsWeightNull)
                    AddParameter(cmd, "Weight", DBNull.Value);
                else
                    AddParameter(cmd, "Weight", value.Weight);

                // ProductImportType
                if (value.IsProductImportTypeNull)
                    AddParameter(cmd, "ProductImportType", DBNull.Value);
                else
                    AddParameter(cmd, "ProductImportType", value.ProductImportType);

                // PositionID
                if (value.IsPositionIDNull)
                    AddParameter(cmd, "PositionID", DBNull.Value);
                else
                    AddParameter(cmd, "PositionID", value.PositionID);

                // supplier
                if (value.IssupplierNull)
                    AddParameter(cmd, "supplier", DBNull.Value);
                else
                    AddParameter(cmd, "supplier", value.supplier);
                // MadeIn
                if (value.IsMadeInNull)
                    AddParameter(cmd, "MadeIn", DBNull.Value);
                else
                    AddParameter(cmd, "MadeIn", value.MadeIn);
                // Pallet_ID
                if (value.IsPallet_IDNull)
                    AddParameter(cmd, "Pallet_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Pallet_ID", value.Pallet_ID);
                if (value.IsProductPartNumberNull)
                    AddParameter(cmd, "ProductPartNumber", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPartNumber", value.ProductPartNumber);
                if (value.IsProductPartDetailNull)
                    AddParameter(cmd, "ProductPartDetail", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPartDetail", value.ProductPartDetail);
                if (value.QrCodeWarehousePublicNull)
                    AddParameter(cmd, "QrCodeWarehousePublic", DBNull.Value);
                else
                    AddParameter(cmd, "QrCodeWarehousePublic", value.QrCodeWarehousePublic);

                AddParameter(cmd, "WarehouseImportNoteDetail_ID", value.WarehouseImportNoteDetailID);
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
        /// Inserts or Updates a record in the <c>WarehouseImportNoteDetail</c> table.
        /// If a row with the specified primary key exists then it is updated
        /// otehrwise, a new row is added.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseImportNoteDetailRow"/>
        /// object used to save the table record.</param>
        public virtual void Save(WarehouseImportNoteDetailRow value)
        {
            string LOCATION = "Save(WarehouseImportNoteDetailRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNoteDetail_Save", CommandType.StoredProcedure);
                // WarehouseImportNoteID
                if (value.IsWarehouseImportNoteIDNull)
                    AddParameter(cmd, "WarehouseImportNoteID", DBNull.Value);
                else
                    AddParameter(cmd, "WarehouseImportNoteID", value.WarehouseImportNoteID);

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

                // ProductSkuEffect
                if (value.IsProductSkuEffectNull)
                    AddParameter(cmd, "ProductSkuEffect", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSkuEffect", value.ProductSkuEffect);
                // ProductPackage_ID
                if (value.IsProductPackage_IDNull)
                    AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
                // SerialNumberStart
                if (value.IsSerialNumberStartNull)
                    AddParameter(cmd, "SerialNumberStart", DBNull.Value);
                else
                    AddParameter(cmd, "SerialNumberStart", value.SerialNumberStart);
                // SerialNumberEnd
                if (value.IsSerialNumberEndNull)
                    AddParameter(cmd, "SerialNumberEnd", DBNull.Value);
                else
                    AddParameter(cmd, "SerialNumberEnd", value.SerialNumberEnd);
                // Color
                if (value.IsColorNull)
                    AddParameter(cmd, "Color", DBNull.Value);
                else
                    AddParameter(cmd, "Color", value.Color);

                // Unit
                if (value.IsUnitNull)
                    AddParameter(cmd, "Unit", DBNull.Value);
                else
                    AddParameter(cmd, "Unit", value.Unit);

                // Description
                if (value.IsWeightNull)
                    AddParameter(cmd, "Weight", DBNull.Value);
                else
                    AddParameter(cmd, "Weight", value.Weight);

                // ProductImportType
                if (value.IsProductImportTypeNull)
                    AddParameter(cmd, "ProductImportType", DBNull.Value);
                else
                    AddParameter(cmd, "ProductImportType", value.ProductImportType);

                // PositionID
                if (value.IsPositionIDNull)
                    AddParameter(cmd, "PositionID", DBNull.Value);
                else
                    AddParameter(cmd, "PositionID", value.PositionID);

                // supplier
                if (value.IssupplierNull)
                    AddParameter(cmd, "supplier", DBNull.Value);
                else
                    AddParameter(cmd, "supplier", value.supplier);
                // MadeIn
                if (value.IsMadeInNull)
                    AddParameter(cmd, "MadeIn", DBNull.Value);
                else
                    AddParameter(cmd, "MadeIn", value.MadeIn);
                // Pallet_ID
                if (value.IsPallet_IDNull)
                    AddParameter(cmd, "Pallet_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Pallet_ID", value.Pallet_ID);
                if (value.IsProductPartNumberNull)
                    AddParameter(cmd, "ProductPartNumber", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPartNumber", value.ProductPartNumber);
                if (value.IsProductPartDetailNull)
                    AddParameter(cmd, "ProductPartDetail", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPartDetail", value.ProductPartDetail);
                if (value.QrCodeWarehousePublicNull)
                    AddParameter(cmd, "QrCodeWarehousePublic", DBNull.Value);
                else
                    AddParameter(cmd, "QrCodeWarehousePublic", value.QrCodeWarehousePublic);

                AddParameter(cmd, "WarehouseImportNoteDetail_ID", value.WarehouseImportNoteDetailID);
                value.WarehouseImportNoteDetailID = Convert.ToInt32(cmd.ExecuteScalar());
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
                                DeleteByPrimaryKey((int)row["WarehouseImportNoteDetail_ID"]);
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
        /// Deletes the specified object from the <c>WarehouseImportNoteDetail</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseImportNoteDetailRow"/> object to delete.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public bool Delete(WarehouseImportNoteDetailRow value)
        {
            return DeleteByPrimaryKey(value.WarehouseImportNoteDetailID);
        }

        /// <summary>
        /// Deletes a record from the <c>WarehouseImportNoteDetail</c> table using
        /// the specified primary key.
        /// </summary>
        /// <param name="WarehouseImportNoteDetail_ID">The <c>WarehouseImportNoteDetail_ID</c> column value.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public virtual bool DeleteByPrimaryKey(int WarehouseImportNoteDetail_ID)
        {
            string LOCATION = "DeleteByPrimaryKey(int WarehouseImportNoteDetail_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNoteDetail_DeleteByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "WarehouseImportNoteDetail_ID", WarehouseImportNoteDetail_ID);
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
        public virtual bool DeleteByWarehouseImportNoteID(int WarehouseImportNoteID)
        {
            string LOCATION = "DeleteByWarehouseImportNoteID(int WarehouseImportNoteID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNoteDetail_DeleteByWarehouseImportNoteID", CommandType.StoredProcedure);
                AddParameter(cmd, "WarehouseImportNoteID", WarehouseImportNoteID);
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
        /// Deletes <c>WarehouseImportNoteDetail</c> records that match the specified criteria.
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
        /// to delete <c>WarehouseImportNoteDetail</c> records that match the specified criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. 
        /// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateDeleteCommand(string whereSql)
        {
            string LOCATION = "CreateDeleteCommand(String whereSql)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseImportNoteDetail_DeleteAdHoc", CommandType.StoredProcedure);

                _db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Deletes all records from the <c>WarehouseImportNoteDetail</c> table.
        /// </summary>
        /// <returns>The number of deleted records.</returns>
        public int DeleteAll()
        {
            string LOCATION = "DeleteAll()";
            try
            {
                return _db.CreateCommand("WarehouseImportNoteDetail_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
        /// <returns>An array of <see cref="WarehouseImportNoteDetailRow"/> objects.</returns>
        protected WarehouseImportNoteDetailRow[] MapRecords(IDbCommand command)
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
        /// <returns>An array of <see cref="WarehouseImportNoteDetailRow"/> objects.</returns>
        protected WarehouseImportNoteDetailRow[] MapRecords(IDataReader reader)
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
        /// <returns>An array of <see cref="WarehouseImportNoteDetailRow"/> objects.</returns>
        protected virtual WarehouseImportNoteDetailRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = " MapRecords(...)";
            if (0 > startIndex)
                throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
            if (0 > length)
                throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

            // WarehouseImportNoteDetailID
            int WarehouseImportNoteDetailIDColumnIndex = reader.GetOrdinal("WarehouseImportNoteDetailID");
            // WarehouseImportNoteID
            int WarehouseImportNoteIDColumnIndex = reader.GetOrdinal("WarehouseImportNoteID");
            // ProductName
            int ProductNameColumnIndex = reader.GetOrdinal("ProductName");
            // ProductSku
            int ProductSkuColumnIndex = reader.GetOrdinal("ProductSku");
            // ProductNumber
            int ProductNumberColumnIndex = reader.GetOrdinal("ProductNumber");
            // ProductSkuEffect
            int ProductSkuEffectColumnIndex = reader.GetOrdinal("ProductSkuEffect");
            // SerialNumberStart
            int SerialNumberStartColumnIndex = reader.GetOrdinal("SerialNumberStart");
            // SerialNumberEnd
            int SerialNumberEndColumnIndex = reader.GetOrdinal("SerialNumberEnd");
            // Color
            int ColorColumnIndex = reader.GetOrdinal("Color");
            // ProductPackage_ID
            int ProductPackage_IDColumnIndex = reader.GetOrdinal("ProductPackage_ID");
            // ProductImportType
            int ProductImportTypeColumnIndex = reader.GetOrdinal("ProductImportType");
            // Unit
            int UnitColumnIndex = reader.GetOrdinal("Unit");
            // Weight
            int WeightColumnIndex = reader.GetOrdinal("Weight");
            // PositionID
            int positionIDColumnIndex = reader.GetOrdinal("PositionID");
            // supplier
            int supplierColumnIndex = reader.GetOrdinal("supplier");
            // MadeIn
            int MadeInColumnIndex = reader.GetOrdinal("MadeIn");
            // Pallet_ID
            int Pallet_IDColumnIndex = reader.GetOrdinal("Pallet_ID");
            // Pallet_ID
            int ProductPartDetailColumnIndex = reader.GetOrdinal("ProductPartDetail");
            // ProductPartNumber
            int ProductPartNumberColumnIndex = reader.GetOrdinal("ProductPartNumber");
            // CreatedDate
            int createdDateColumnIndex = reader.GetOrdinal("CreatedDate");
            // QrCodeWarehousePublic
            int QrCodeWarehousePublicColumnIndex = reader.GetOrdinal("QrCodeWarehousePublic");

            System.Collections.ArrayList recordList = new System.Collections.ArrayList();
            int ri = -startIndex;
            while (reader.Read())
            {
                ri++;
                if (ri > 0 && ri <= length)
                {
                    WarehouseImportNoteDetailRow record = new WarehouseImportNoteDetailRow();
                    recordList.Add(record);

                    record.WarehouseImportNoteDetailID = Convert.ToInt32(reader.GetValue(WarehouseImportNoteDetailIDColumnIndex));
                    if (!reader.IsDBNull(WarehouseImportNoteIDColumnIndex))
                        record.WarehouseImportNoteID = Convert.ToInt32(reader.GetValue(WarehouseImportNoteIDColumnIndex));
                    if (!reader.IsDBNull(ProductNameColumnIndex))
                        record.ProductName = Convert.ToString(reader.GetValue(ProductNameColumnIndex));
                    if (!reader.IsDBNull(ProductSkuColumnIndex))
                        record.ProductSku = Convert.ToString(reader.GetValue(ProductSkuColumnIndex));
                    if (!reader.IsDBNull(ProductNumberColumnIndex))
                        record.ProductNumber = Convert.ToInt32(reader.GetValue(ProductNumberColumnIndex));
                    if (!reader.IsDBNull(ProductSkuEffectColumnIndex))
                        record.ProductSkuEffect = Convert.ToString(reader.GetValue(ProductSkuEffectColumnIndex));
                    if (!reader.IsDBNull(SerialNumberStartColumnIndex))
                        record.SerialNumberStart = Convert.ToString(reader.GetValue(SerialNumberStartColumnIndex));
                    if (!reader.IsDBNull(SerialNumberEndColumnIndex))
                        record.SerialNumberEnd = Convert.ToString(reader.GetValue(SerialNumberEndColumnIndex));
                    if (!reader.IsDBNull(ColorColumnIndex))
                        record.Color = Convert.ToString(reader.GetValue(ColorColumnIndex));
                    if (!reader.IsDBNull(ProductPackage_IDColumnIndex))
                        record.ProductPackage_ID = Convert.ToInt32(reader.GetValue(ProductPackage_IDColumnIndex));
                    if (!reader.IsDBNull(ProductImportTypeColumnIndex))
                        record.ProductImportType = Convert.ToString(reader.GetValue(ProductImportTypeColumnIndex));
                    if (!reader.IsDBNull(UnitColumnIndex))
                        record.Unit = Convert.ToString(reader.GetValue(UnitColumnIndex));
                    if (!reader.IsDBNull(WeightColumnIndex))
                        record.Weight = Convert.ToString(reader.GetValue(WeightColumnIndex));
                    if (!reader.IsDBNull(positionIDColumnIndex))
                        record.PositionID = Convert.ToInt32(reader.GetValue(positionIDColumnIndex));
                    if (!reader.IsDBNull(supplierColumnIndex))
                        record.supplier = Convert.ToString(reader.GetValue(supplierColumnIndex));
                    if (!reader.IsDBNull(MadeInColumnIndex))
                        record.MadeIn = Convert.ToString(reader.GetValue(MadeInColumnIndex));
                    if (!reader.IsDBNull(Pallet_IDColumnIndex))
                        record.Pallet_ID = Convert.ToString(reader.GetValue(Pallet_IDColumnIndex));
                    if (!reader.IsDBNull(ProductPartDetailColumnIndex))
                        record.ProductPartNumber = Convert.ToString(reader.GetValue(ProductPartDetailColumnIndex));
                    if (!reader.IsDBNull(ProductPartNumberColumnIndex))
                        record.ProductPartDetail = Convert.ToString(reader.GetValue(ProductPartNumberColumnIndex));
                    if (!reader.IsDBNull(createdDateColumnIndex))
                        record.CreatedDate = Convert.ToDateTime(reader.GetValue(createdDateColumnIndex));
                    if (!reader.IsDBNull(QrCodeWarehousePublicColumnIndex))
                        record.QrCodeWarehousePublic = Convert.ToString(reader.GetValue(QrCodeWarehousePublicColumnIndex));

                    if (ri == length && 0 != totalRecordCount)
                        break;
                }
            }

            if (0 == totalRecordCount)
                totalRecordCount = ri + startIndex;
            else
                totalRecordCount = -1;

            return (WarehouseImportNoteDetailRow[])(recordList.ToArray(typeof(WarehouseImportNoteDetailRow)));
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
        /// Converts <see cref="System.Data.DataRow"/> to <see cref="WarehouseImportNoteDetailRow"/>.
        /// </summary>
        /// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
        /// <returns>A reference to the <see cref="WarehouseImportNoteDetailRow"/> object.</returns>
        protected virtual WarehouseImportNoteDetailRow MapRow(DataRow row)
        {
            string LOCATION = "WarehouseImportNoteDetailRow MapRow(DataRow row)";
            WarehouseImportNoteDetailRow mappedObject = new WarehouseImportNoteDetailRow();
            DataTable dataTable = row.Table;
            DataColumn dataColumn;
            // Column "WarehouseImportNoteDetailID"
            dataColumn = dataTable.Columns["WarehouseImportNoteDetailID"];
            if (!row.IsNull(dataColumn))
                mappedObject.WarehouseImportNoteDetailID = (int)(row[dataColumn]);
            // Column "WarehouseImportNoteID"
            dataColumn = dataTable.Columns["WarehouseImportNoteID"];
            if (!row.IsNull(dataColumn))
                mappedObject.WarehouseImportNoteID = (int)(row[dataColumn]);
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
            // Column "ProductSkuEffect"
            dataColumn = dataTable.Columns["ProductSkuEffect"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductSkuEffect = (string)(row[dataColumn]);
            // Column "SerialNumberStart"
            dataColumn = dataTable.Columns["SerialNumberStart"];
            if (!row.IsNull(dataColumn))
                mappedObject.SerialNumberStart = (string)(row[dataColumn]);
            // Column "SerialNumberEnd"
            dataColumn = dataTable.Columns["SerialNumberEnd"];
            if (!row.IsNull(dataColumn))
                mappedObject.SerialNumberEnd = (string)(row[dataColumn]);
            // Column "Color"
            dataColumn = dataTable.Columns["Color"];
            if (!row.IsNull(dataColumn))
                mappedObject.Color = (string)(row[dataColumn]);
            // Column "ProductPackage_ID"
            dataColumn = dataTable.Columns["ProductPackage_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductPackage_ID = (int)(row[dataColumn]);
            // Column "ProductImportType"
            dataColumn = dataTable.Columns["ProductImportType"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductImportType = (string)(row[dataColumn]);
            // Column "Unit"
            dataColumn = dataTable.Columns["Unit"];
            if (!row.IsNull(dataColumn))
                mappedObject.Unit = (string)(row[dataColumn]);
            // Column "Weight"
            dataColumn = dataTable.Columns["Weight"];
            if (!row.IsNull(dataColumn))
                mappedObject.Weight = (string)(row[dataColumn]);
            // Column "PositionID"
            dataColumn = dataTable.Columns["PositionID"];
            if (!row.IsNull(dataColumn))
                mappedObject.PositionID = (int)(row[dataColumn]);
            // Column "supplier"
            dataColumn = dataTable.Columns["supplier"];
            if (!row.IsNull(dataColumn))
                mappedObject.supplier = (string)(row[dataColumn]);
            // Column "MadeIn"
            dataColumn = dataTable.Columns["MadeIn"];
            if (!row.IsNull(dataColumn))
                mappedObject.MadeIn = (string)(row[dataColumn]);
            // Column "Pallet_ID"
            dataColumn = dataTable.Columns["Pallet_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.Pallet_ID = (string)(row[dataColumn]);
            // Column "CreatedDate"
            dataColumn = dataTable.Columns["CreatedDate"];
            if (!row.IsNull(dataColumn))
                mappedObject.CreatedDate = (System.DateTime)(row[dataColumn]);
            dataColumn = dataTable.Columns["QrCodeWarehousePublic"];
            if (!row.IsNull(dataColumn))
                mappedObject.QrCodeWarehousePublic = (string)(row[dataColumn]);
            return mappedObject;
        }

        /// <summary>
        /// Creates a <see cref="System.Data.DataTable"/> object for 
        /// the <c>WarehouseImportNoteDetail</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected virtual DataTable CreateDataTable()
        {
            string LOCATION = "CreateDataTable()";
            DataTable dataTable = new DataTable();
            dataTable.TableName = "WarehouseImportNoteDetail";
            DataColumn dataColumn;
            // Create the "WarehouseImportNoteDetail_ID" column
            dataColumn = dataTable.Columns.Add("WarehouseImportNoteDetailID", typeof(int));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            // Create the "WarehouseImportNoteID" column
            dataColumn = dataTable.Columns.Add("WarehouseImportNoteID", typeof(int));
            // Create the "ProductName" column
            dataColumn = dataTable.Columns.Add("ProductName", typeof(string));
            // Create the "ProductSkuEffect" column
            dataColumn = dataTable.Columns.Add("ProductSkuEffect", typeof(string));
            // Create the "ProductSku" column
            dataColumn = dataTable.Columns.Add("ProductSku", typeof(string));
            // Create the "ProductNumber" column
            dataColumn = dataTable.Columns.Add("ProductNumber", typeof(int));
            // Create the "ProductPackage_ID" column
            dataColumn = dataTable.Columns.Add("ProductPackage_ID", typeof(int));
            // Create the "SerialNumberStart" column
            dataColumn = dataTable.Columns.Add("SerialNumberStart", typeof(string));
            // Create the "SerialNumberEnd" column
            dataColumn = dataTable.Columns.Add("SerialNumberEnd", typeof(string));
            // Create the "Color" column
            dataColumn = dataTable.Columns.Add("Color", typeof(string));
            // Create the "ProductImportType" column
            dataColumn = dataTable.Columns.Add("ProductImportType", typeof(string));
            // Create the "Unit" column
            dataColumn = dataTable.Columns.Add("Unit", typeof(string));
            // Create the "Weight" column
            dataColumn = dataTable.Columns.Add("Weight", typeof(string));
            // Create the "PositionID" column
            dataColumn = dataTable.Columns.Add("PositionID", typeof(int));
            // Create the "supplier" column
            dataColumn = dataTable.Columns.Add("supplier", typeof(string));
            // Create the "MadeIn" column
            dataColumn = dataTable.Columns.Add("MadeIn", typeof(string));
            // Create the "Pallet_ID" column
            dataColumn = dataTable.Columns.Add("Pallet_ID", typeof(string));
            // Create the "ProductPartNumber" column
            dataColumn = dataTable.Columns.Add("ProductPartNumber", typeof(string));
            // Create the "ProductPartDetail column
            dataColumn = dataTable.Columns.Add("ProductPartDetail", typeof(string));
            // Create the "CreatedDate" column
            dataColumn = dataTable.Columns.Add("CreatedDate", typeof(System.DateTime));
            // Create the "QrCodeWarehousePublic column
            dataColumn = dataTable.Columns.Add("QrCodeWarehousePublic", typeof(string));
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
                case "WarehouseImportNoteDetailID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "WarehouseImportNoteDetail_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "WarehouseImportNoteID":
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

                case "Color":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "ProductSkuEffect":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "ProductPackage_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "SerialNumberStart":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "SerialNumberEnd":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "ProductImportType":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Unit":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Weight":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "PositionID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "supplier":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;
                case "MadeIn":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;
                case "Pallet_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;
                case "ProductPartNumber":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;
                case "ProductPartDetail":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "CreatedDate":
                    parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
                    break;
                case "QrCodeWarehousePublic":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                default:
                    throw new ArgumentException("Unknown parameter name (" + paramName + ").");
            }
            return parameter;
        }

        /// <summary>
        /// Exist <see cref="WarehouseImportNoteDetailRow"/> by the primary key.
        /// </summary>
        /// <param name="WarehouseImportNoteDetail_ID">The <c>WarehouseImportNoteDetail_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseImportNoteDetailRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual bool Exist(int WarehouseImportNoteDetail_ID)
        {
            string LOCATION = "Exist(int WarehouseImportNoteDetail_ID)";
            IDbCommand cmd = _db.CreateCommand("WarehouseImportNoteDetail_GetByPrimaryKey", CommandType.StoredProcedure);
            AddParameter(cmd, "WarehouseImportNoteDetail_ID", WarehouseImportNoteDetail_ID);
            WarehouseImportNoteDetailRow[] tempArray = MapRecords(cmd);
            if (0 == tempArray.Length)
                return false;
            return true;
        }

    }
}




