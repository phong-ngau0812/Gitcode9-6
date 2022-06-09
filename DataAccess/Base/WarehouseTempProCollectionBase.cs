
// <fileinfo name="Base\WarehouseTempProCollectionBase.cs">
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
    /// The base class for <see cref="WarehouseTempProCollection"/>. Provides methods 
    /// for common database table operations. 
    /// </summary>
    /// <remarks>
    /// Do not change this source code. Update the <see cref="WarehouseTempProCollection"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseTempProCollectionBase
        : Base.ConllectionBase

    {
        // Constants
        public const string WarehouseTempPro_IDColumnName = "WarehouseTempPro_ID";
        public const string ProductNameColumnName = "ProductName";
        public const string ProductSkuEffectColumnName = "ProductSkuEffect";
        public const string ProductSkuColumnName = "ProductSku";
        public const string ProductNumberColumnName = "ProductNumber";
        public const string ProductPackage_IDColumnName = "ProductPackage_ID";
        public const string SerialNumberStartColumnName = "SerialNumberStart";
        public const string SerialNumberEndColumnName = "SerialNumberEnd";
        public const string QRCodeColumnName = "QRCode";
        public const string QRCodePublicColumnName = "QRCodePublic";
        public const string ColorColumnName = "Color";
        public const string ProductImportTypeColumnName = "ProductImportType";
        public const string UnitColumnName = "Unit";
        public const string WeightColumnName = "weight";
        public const string PositionIDColumnName = "PositionID";
        public const string SupplierColumnName = "supplier";
        public const string MadeInColumnName = "MadeIn";
        public const string Pallet_IDColumnName = "Pallet_ID";
        public const string CreatedDateColumnName = "CreatedDate";
        public const string Other1ColumnName = "Other1";
        public const string Other2ColumnName = "Other2";
        public const string Other3ColumnName = "Other3";


        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
        /// class with the specified <see cref="Database"/>.
        /// </summary>
        /// <param name="db">The <see cref="Database"/> object.</param>
        public WarehouseTempProCollectionBase(Database db) : base(db)
        {
            this.TABLENAME = "WarehouseTempPro";
        }

        public WarehouseTempProCollectionBase() : base()
        {
            this.TABLENAME = "WarehouseTempPro";
        }



        /// <summary>
        /// Gets an array of all records from the <c>WarehouseTempPro</c> table.
        /// </summary>
        /// <returns>An array of <see cref="WarehouseTempProRow"/> objects.</returns>
        public virtual WarehouseTempProRow[] GetAll()
        {
            return MapRecords(CreateGetAllCommand());
        }

        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object that 
        /// includes all records from the <c>WarehouseTempPro</c> table.
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
        /// to retrieve all records from the <c>WarehouseTempPro</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetAllCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseTempPro_GetAll", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Gets the first <see cref="WarehouseTempProRow"/> objects that 
        /// match the search condition.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>An instance of <see cref="WarehouseTempProRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public WarehouseTempProRow GetRow(string whereSql)
        {
            string LOCATION = "GetRow(string whereSql)";
            try
            {
                int totalRecordCount = -1;
                WarehouseTempProRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
        /// Gets an array of <see cref="WarehouseTempProRow"/> objects that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
        /// <returns>An array of <see cref="WarehouseTempProRow"/> objects.</returns>
        public WarehouseTempProRow[] GetAsArray(string whereSql, string orderBySql)
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
        /// Gets an array of <see cref="WarehouseTempProRow"/> objects that 
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
        /// <returns>An array of <see cref="WarehouseTempProRow"/> objects.</returns>
        public virtual WarehouseTempProRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
            IDataReader reader = null;
            IDbCommand cmd = null;
            try
            {
                cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
                reader = _db.ExecuteReader(cmd);
                WarehouseTempProRow[] rows = MapRecords(reader);
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
                IDbCommand cmd = _db.CreateCommand("WarehouseTempPro_GetAdHoc", CommandType.StoredProcedure);
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
                IDbCommand cmd = _db.CreateCommand("WarehouseTempPro_GetPageAdHoc", CommandType.StoredProcedure);

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
        /// Gets <see cref="WarehouseTempProRow"/> by the primary key.
        /// </summary>
        /// <param name="warehouseTempPro_ID">The <c>WarehouseTempPro_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseTempProRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual WarehouseTempProRow GetByPrimaryKey(int warehouseTempPro_ID)
        {
            string LOCATION = "GetByPrimaryKey(int warehouseTempPro_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseTempPro_GetByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "WarehouseTempPro_ID", warehouseTempPro_ID);
                WarehouseTempProRow[] tempArray = MapRecords(cmd);
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
        /// Adds a new record into the <c>WarehouseTempPro</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseTempProRow"/> object to be inserted.</param>
        public virtual void Insert(WarehouseTempProRow value)
        {
            string LOCATION = "Insert(WarehouseTempProRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseTempPro_Insert", CommandType.StoredProcedure);
                // ProductName
                if (value.IsProductNameNull)
                    AddParameter(cmd, "ProductName", DBNull.Value);
                else
                    AddParameter(cmd, "ProductName", value.ProductName);

                // ProductSkuEffect
                if (value.IsProductSkuEffectNull)
                    AddParameter(cmd, "ProductSkuEffect", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSkuEffect", value.ProductSkuEffect);

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

                // QRCode
                if (value.IsQRCodeNull)
                    AddParameter(cmd, "QRCode", DBNull.Value);
                else
                    AddParameter(cmd, "QRCode", value.QRCode);

                // QRCodePublic
                if (value.IsQRCodePublicNull)
                    AddParameter(cmd, "QRCodePublic", DBNull.Value);
                else
                    AddParameter(cmd, "QRCodePublic", value.QRCodePublic);

                // Color
                if (value.IsColorNull)
                    AddParameter(cmd, "Color", DBNull.Value);
                else
                    AddParameter(cmd, "Color", value.Color);

                // ProductImportType
                if (value.IsProductImportTypeNull)
                    AddParameter(cmd, "ProductImportType", DBNull.Value);
                else
                    AddParameter(cmd, "ProductImportType", value.ProductImportType);

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

                // PositionID
                if (value.IsPositionIDNull)
                    AddParameter(cmd, "PositionID", DBNull.Value);
                else
                    AddParameter(cmd, "PositionID", value.PositionID);

                // Supplier
                if (value.IsSupplierNull)
                    AddParameter(cmd, "Supplier", DBNull.Value);
                else
                    AddParameter(cmd, "Supplier", value.Supplier);

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

                value.WarehouseTempPro_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
        /// Updates a record in the <c>WarehouseTempPro</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseTempProRow"/>
        /// object used to update the table record.</param>
        /// <returns>true if the record was updated; otherwise, false.</returns>
        public virtual bool Update(WarehouseTempProRow value)
        {
            string LOCATION = "Update(WarehouseTempProRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseTempPro_Update", CommandType.StoredProcedure);
                // ProductName
                if (value.IsProductNameNull)
                    AddParameter(cmd, "ProductName", DBNull.Value);
                else
                    AddParameter(cmd, "ProductName", value.ProductName);
                // ProductSkuEffect
                if (value.IsProductSkuEffectNull)
                    AddParameter(cmd, "ProductSkuEffect", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSkuEffect", value.ProductSkuEffect);
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
                // QRCode
                if (value.IsQRCodeNull)
                    AddParameter(cmd, "QRCode", DBNull.Value);
                else
                    AddParameter(cmd, "QRCode", value.QRCode);
                // QRCodePublic
                if (value.IsQRCodePublicNull)
                    AddParameter(cmd, "QRCodePublic", DBNull.Value);
                else
                    AddParameter(cmd, "QRCodePublic", value.QRCodePublic);
                // Color
                if (value.IsColorNull)
                    AddParameter(cmd, "Color", DBNull.Value);
                else
                    AddParameter(cmd, "Color", value.Color);
                // ProductImportType
                if (value.IsProductImportTypeNull)
                    AddParameter(cmd, "ProductImportType", DBNull.Value);
                else
                    AddParameter(cmd, "ProductImportType", value.ProductImportType);
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
                // PositionID
                if (value.IsPositionIDNull)
                    AddParameter(cmd, "PositionID", DBNull.Value);
                else
                    AddParameter(cmd, "PositionID", value.PositionID);

                // Supplier
                if (value.IsSupplierNull)
                    AddParameter(cmd, "Supplier", DBNull.Value);
                else
                    AddParameter(cmd, "Supplier", value.Supplier);
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
                AddParameter(cmd, "WarehouseTempPro_ID", value.WarehouseTempPro_ID);
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
        /// Inserts or Updates a record in the <c>WarehouseTempPro</c> table.
        /// If a row with the specified primary key exists then it is updated
        /// otehrwise, a new row is added.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseTempProRow"/>
        /// object used to save the table record.</param>
        public virtual void Save(WarehouseTempProRow value)
        {
            string LOCATION = "Save(WarehouseTempProRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseTempPro_Save", CommandType.StoredProcedure);
                // ProductName
                if (value.IsProductNameNull)
                    AddParameter(cmd, "ProductName", DBNull.Value);
                else
                    AddParameter(cmd, "ProductName", (object)(value.ProductName));

                // ProductSkuEffect
                if (value.IsProductSkuEffectNull)
                    AddParameter(cmd, "ProductSkuEffect", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSkuEffect", (object)(value.ProductSkuEffect));

                // ProductSku
                if (value.IsProductSkuNull)
                    AddParameter(cmd, "ProductSku", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSku", (object)(value.ProductSku));

                // ProductNumber
                if (value.IsProductNumberNull)
                    AddParameter(cmd, "ProductNumber", DBNull.Value);
                else
                    AddParameter(cmd, "ProductNumber", (object)(value.ProductNumber));

                // ProductPackage_ID
                if (value.IsProductPackage_IDNull)
                    AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPackage_ID", (object)(value.ProductPackage_ID));

                // SerialNumberStart
                if (value.IsSerialNumberStartNull)
                    AddParameter(cmd, "SerialNumberStart", DBNull.Value);
                else
                    AddParameter(cmd, "SerialNumberStart", (object)(value.SerialNumberStart));

                // SerialNumberEnd
                if (value.IsSerialNumberEndNull)
                    AddParameter(cmd, "SerialNumberEnd", DBNull.Value);
                else
                    AddParameter(cmd, "SerialNumberEnd", (object)(value.SerialNumberEnd));

                // QRCode
                if (value.IsQRCodeNull)
                    AddParameter(cmd, "QRCode", DBNull.Value);
                else
                    AddParameter(cmd, "QRCode", (object)(value.QRCode));

                // QRCodePublic
                if (value.IsQRCodePublicNull)
                    AddParameter(cmd, "QRCodePublic", DBNull.Value);
                else
                    AddParameter(cmd, "QRCodePublic", (object)(value.QRCodePublic));

                // Color
                if (value.IsColorNull)
                    AddParameter(cmd, "Color", DBNull.Value);
                else
                    AddParameter(cmd, "Color", (object)(value.Color));

                // ProductImportType
                if (value.IsProductImportTypeNull)
                    AddParameter(cmd, "ProductImportType", DBNull.Value);
                else
                    AddParameter(cmd, "ProductImportType", (object)(value.ProductImportType));

                // Unit
                if (value.IsUnitNull)
                    AddParameter(cmd, "Unit", DBNull.Value);
                else
                    AddParameter(cmd, "Unit", (object)(value.Unit));

                // Weight
                if (value.IsWeightNull)
                    AddParameter(cmd, "Weight", DBNull.Value);
                else
                    AddParameter(cmd, "Weight", (object)(value.Weight));

                // PositionID
                if (value.IsPositionIDNull)
                    AddParameter(cmd, "PositionID", DBNull.Value);
                else
                    AddParameter(cmd, "PositionID", (object)(value.PositionID));

                // Supplier
                if (value.IsSupplierNull)
                    AddParameter(cmd, "Supplier", DBNull.Value);
                else
                    AddParameter(cmd, "Supplier", (object)(value.Supplier));

                // MadeIn
                if (value.IsMadeInNull)
                    AddParameter(cmd, "MadeIn", DBNull.Value);
                else
                    AddParameter(cmd, "MadeIn", (object)(value.MadeIn));

                // Pallet_ID
                if (value.IsPallet_IDNull)
                    AddParameter(cmd, "Pallet_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Pallet_ID", (object)(value.Pallet_ID));

                // CreatedDate
                if (value.IsCreatedDateNull)
                    AddParameter(cmd, "CreatedDate", DBNull.Value);
                else
                    AddParameter(cmd, "CreatedDate", (object)(value.CreatedDate));

                // Other1
                if (value.IsOther1Null)
                    AddParameter(cmd, "Other1", DBNull.Value);
                else
                    AddParameter(cmd, "Other1", (object)(value.Other1));

                // Other2
                if (value.IsOther2Null)
                    AddParameter(cmd, "Other2", DBNull.Value);
                else
                    AddParameter(cmd, "Other2", (object)(value.Other2));

                // Other3
                if (value.IsOther3Null)
                    AddParameter(cmd, "Other3", DBNull.Value);
                else
                    AddParameter(cmd, "Other3", (object)(value.Other3));

                AddParameter(cmd, "WarehouseTempPro_ID", value.WarehouseTempPro_ID);
                value.WarehouseTempPro_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
                                DeleteByPrimaryKey((int)row["WarehouseTempPro_ID"]);
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
        /// Deletes the specified object from the <c>WarehouseTempPro</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseTempProRow"/> object to delete.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public bool Delete(WarehouseTempProRow value)
        {
            return DeleteByPrimaryKey(value.WarehouseTempPro_ID);
        }

        /// <summary>
        /// Deletes a record from the <c>WarehouseTempPro</c> table using
        /// the specified primary key.
        /// </summary>
        /// <param name="warehouseTempPro_ID">The <c>WarehouseTempPro_ID</c> column value.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public virtual bool DeleteByPrimaryKey(int warehouseTempPro_ID)
        {
            string LOCATION = "DeleteByPrimaryKey(int warehouseTempPro_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseTempPro_DeleteByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "WarehouseTempPro_ID", warehouseTempPro_ID);
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
        /// Deletes <c>WarehouseTempPro</c> records that match the specified criteria.
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
        /// to delete <c>WarehouseTempPro</c> records that match the specified criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. 
        /// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateDeleteCommand(string whereSql)
        {
            string LOCATION = "CreateDeleteCommand(String whereSql)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseTempPro_DeleteAdHoc", CommandType.StoredProcedure);

                _db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Deletes all records from the <c>WarehouseTempPro</c> table.
        /// </summary>
        /// <returns>The number of deleted records.</returns>
        public int DeleteAll()
        {
            string LOCATION = "DeleteAll()";
            try
            {
                return _db.CreateCommand("WarehouseTempPro_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
        /// <returns>An array of <see cref="WarehouseTempProRow"/> objects.</returns>
        protected WarehouseTempProRow[] MapRecords(IDbCommand command)
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
        /// <returns>An array of <see cref="WarehouseTempProRow"/> objects.</returns>
        protected WarehouseTempProRow[] MapRecords(IDataReader reader)
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
        /// <returns>An array of <see cref="WarehouseTempProRow"/> objects.</returns>
        protected virtual WarehouseTempProRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = " MapRecords(...)";
            if (0 > startIndex)
                throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
            if (0 > length)
                throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

            // WarehouseTempPro_ID
            int warehouseTempPro_IDColumnIndex = reader.GetOrdinal("WarehouseTempPro_ID");
            // ProductName
            int productNameColumnIndex = reader.GetOrdinal("ProductName");
            // ProductSkuEffect
            int productSkuEffectColumnIndex = reader.GetOrdinal("ProductSkuEffect");
            // ProductSku
            int productSkuColumnIndex = reader.GetOrdinal("ProductSku");
            // ProductNumber
            int productNumberColumnIndex = reader.GetOrdinal("ProductNumber");
            // ProductPackage_ID
            int productPackage_IDColumnIndex = reader.GetOrdinal("ProductPackage_ID");
            // SerialNumberStart
            int serialNumberStartColumnIndex = reader.GetOrdinal("SerialNumberStart");
            // SerialNumberEnd
            int serialNumberEndColumnIndex = reader.GetOrdinal("SerialNumberEnd");
            // QRCode
            int qRCodeColumnIndex = reader.GetOrdinal("QRCode");
            // QRCodePublic
            int qRCodePublicColumnIndex = reader.GetOrdinal("QRCodePublic");
            // Color
            int colorColumnIndex = reader.GetOrdinal("Color");
            // ProductImportType
            int productImportTypeColumnIndex = reader.GetOrdinal("ProductImportType");
            // Unit
            int unitColumnIndex = reader.GetOrdinal("Unit");
            // Weight
            int weightColumnIndex = reader.GetOrdinal("weight");
            // PositionID
            int positionIDColumnIndex = reader.GetOrdinal("PositionID");
            // Supplier
            int supplierColumnIndex = reader.GetOrdinal("supplier");
            // MadeIn
            int madeInColumnIndex = reader.GetOrdinal("MadeIn");
            // Pallet_ID
            int pallet_IDColumnIndex = reader.GetOrdinal("Pallet_ID");
            // CreatedDate
            int createdDateColumnIndex = reader.GetOrdinal("CreatedDate");
            // Other1
            int other1ColumnIndex = reader.GetOrdinal("Other1");
            // Other2
            int other2ColumnIndex = reader.GetOrdinal("Other2");
            // Other3
            int other3ColumnIndex = reader.GetOrdinal("Other3");

            System.Collections.ArrayList recordList = new System.Collections.ArrayList();
            int ri = -startIndex;
            while (reader.Read())
            {
                ri++;
                if (ri > 0 && ri <= length)
                {
                    WarehouseTempProRow record = new WarehouseTempProRow();
                    recordList.Add(record);

                    record.WarehouseTempPro_ID = Convert.ToInt32(reader.GetValue(warehouseTempPro_IDColumnIndex));
                    if (!reader.IsDBNull(productNameColumnIndex))
                        record.ProductName = Convert.ToString(reader.GetValue(productNameColumnIndex));
                    if (!reader.IsDBNull(productSkuEffectColumnIndex))
                        record.ProductSkuEffect = Convert.ToString(reader.GetValue(productSkuEffectColumnIndex));
                    if (!reader.IsDBNull(productSkuColumnIndex))
                        record.ProductSku = Convert.ToString(reader.GetValue(productSkuColumnIndex));
                    if (!reader.IsDBNull(productNumberColumnIndex))
                        record.ProductNumber = Convert.ToInt32(reader.GetValue(productNumberColumnIndex));
                    if (!reader.IsDBNull(productPackage_IDColumnIndex))
                        record.ProductPackage_ID = Convert.ToInt32(reader.GetValue(productPackage_IDColumnIndex));
                    if (!reader.IsDBNull(serialNumberStartColumnIndex))
                        record.SerialNumberStart = Convert.ToString(reader.GetValue(serialNumberStartColumnIndex));
                    if (!reader.IsDBNull(serialNumberEndColumnIndex))
                        record.SerialNumberEnd = Convert.ToString(reader.GetValue(serialNumberEndColumnIndex));
                    if (!reader.IsDBNull(qRCodeColumnIndex))
                        record.QRCode = Convert.ToString(reader.GetValue(qRCodeColumnIndex));
                    if (!reader.IsDBNull(qRCodePublicColumnIndex))
                        record.QRCodePublic = Convert.ToString(reader.GetValue(qRCodePublicColumnIndex));
                    if (!reader.IsDBNull(colorColumnIndex))
                        record.Color = Convert.ToString(reader.GetValue(colorColumnIndex));
                    if (!reader.IsDBNull(productImportTypeColumnIndex))
                        record.ProductImportType = Convert.ToString(reader.GetValue(productImportTypeColumnIndex));
                    if (!reader.IsDBNull(unitColumnIndex))
                        record.Unit = Convert.ToString(reader.GetValue(unitColumnIndex));
                    if (!reader.IsDBNull(weightColumnIndex))
                        record.Weight = Convert.ToString(reader.GetValue(weightColumnIndex));
                    if (!reader.IsDBNull(positionIDColumnIndex))
                        record.PositionID = Convert.ToInt32(reader.GetValue(positionIDColumnIndex));
                    if (!reader.IsDBNull(supplierColumnIndex))
                        record.Supplier = Convert.ToString(reader.GetValue(supplierColumnIndex));
                    if (!reader.IsDBNull(madeInColumnIndex))
                        record.MadeIn = Convert.ToString(reader.GetValue(madeInColumnIndex));
                    if (!reader.IsDBNull(pallet_IDColumnIndex))
                        record.Pallet_ID = Convert.ToString(reader.GetValue(pallet_IDColumnIndex));
                    if (!reader.IsDBNull(createdDateColumnIndex))
                        record.CreatedDate = Convert.ToDateTime(reader.GetValue(createdDateColumnIndex));
                    if (!reader.IsDBNull(other1ColumnIndex))
                        record.Other1 = Convert.ToString(reader.GetValue(other1ColumnIndex));
                    if (!reader.IsDBNull(other2ColumnIndex))
                        record.Other2 = Convert.ToString(reader.GetValue(other2ColumnIndex));
                    if (!reader.IsDBNull(other3ColumnIndex))
                        record.Other3 = Convert.ToString(reader.GetValue(other3ColumnIndex));

                    if (ri == length && 0 != totalRecordCount)
                        break;
                }
            }

            if (0 == totalRecordCount)
                totalRecordCount = ri + startIndex;
            else
                totalRecordCount = -1;

            return (WarehouseTempProRow[])(recordList.ToArray(typeof(WarehouseTempProRow)));
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
        /// Converts <see cref="System.Data.DataRow"/> to <see cref="WarehouseTempProRow"/>.
        /// </summary>
        /// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
        /// <returns>A reference to the <see cref="WarehouseTempProRow"/> object.</returns>
        protected virtual WarehouseTempProRow MapRow(DataRow row)
        {
            string LOCATION = "WarehouseTempProRow MapRow(DataRow row)";
            WarehouseTempProRow mappedObject = new WarehouseTempProRow();
            DataTable dataTable = row.Table;
            DataColumn dataColumn;
            // Column "WarehouseTempPro_ID"
            dataColumn = dataTable.Columns["WarehouseTempPro_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.WarehouseTempPro_ID = (int)(row[dataColumn]);
            // Column "ProductName"
            dataColumn = dataTable.Columns["ProductName"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductName = (string)(row[dataColumn]);
            // Column "ProductSkuEffect"
            dataColumn = dataTable.Columns["ProductSkuEffect"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductSkuEffect = (string)(row[dataColumn]);
            // Column "ProductSku"
            dataColumn = dataTable.Columns["ProductSku"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductSku = (string)(row[dataColumn]);
            // Column "ProductNumber"
            dataColumn = dataTable.Columns["ProductNumber"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductNumber = (int)(row[dataColumn]);
            // Column "ProductPackage_ID"
            dataColumn = dataTable.Columns["ProductPackage_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductPackage_ID = (int)(row[dataColumn]);
            // Column "SerialNumberStart"
            dataColumn = dataTable.Columns["SerialNumberStart"];
            if (!row.IsNull(dataColumn))
                mappedObject.SerialNumberStart = (string)(row[dataColumn]);
            // Column "SerialNumberEnd"
            dataColumn = dataTable.Columns["SerialNumberEnd"];
            if (!row.IsNull(dataColumn))
                mappedObject.SerialNumberEnd = (string)(row[dataColumn]);
            // Column "QRCode"
            dataColumn = dataTable.Columns["QRCode"];
            if (!row.IsNull(dataColumn))
                mappedObject.QRCode = (string)(row[dataColumn]);
            // Column "QRCodePublic"
            dataColumn = dataTable.Columns["QRCodePublic"];
            if (!row.IsNull(dataColumn))
                mappedObject.QRCodePublic = (string)(row[dataColumn]);
            // Column "Color"
            dataColumn = dataTable.Columns["Color"];
            if (!row.IsNull(dataColumn))
                mappedObject.Color = (string)(row[dataColumn]);
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
            // Column "Supplier"
            dataColumn = dataTable.Columns["Supplier"];
            if (!row.IsNull(dataColumn))
                mappedObject.Supplier = (string)(row[dataColumn]);
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
        /// the <c>WarehouseTempPro</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected virtual DataTable CreateDataTable()
        {
            string LOCATION = "CreateDataTable()";
            DataTable dataTable = new DataTable();
            dataTable.TableName = "WarehouseTempPro";
            DataColumn dataColumn;
            // Create the "WarehouseTempPro_ID" column
            dataColumn = dataTable.Columns.Add("WarehouseTempPro_ID", typeof(int));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            // Create the "ProductName" column
            dataColumn = dataTable.Columns.Add("ProductName", typeof(string));
            dataColumn.MaxLength = 500;
            // Create the "ProductSkuEffect" column
            dataColumn = dataTable.Columns.Add("ProductSkuEffect", typeof(string));
            dataColumn.MaxLength = 100;
            // Create the "ProductSku" column
            dataColumn = dataTable.Columns.Add("ProductSku", typeof(string));
            dataColumn.MaxLength = 100;
            // Create the "ProductNumber" column
            dataColumn = dataTable.Columns.Add("ProductNumber", typeof(int));
            // Create the "ProductPackage_ID" column
            dataColumn = dataTable.Columns.Add("ProductPackage_ID", typeof(int));
            // Create the "SerialNumberStart" column
            dataColumn = dataTable.Columns.Add("SerialNumberStart", typeof(string));
            dataColumn.MaxLength = 50;
            // Create the "SerialNumberEnd" column
            dataColumn = dataTable.Columns.Add("SerialNumberEnd", typeof(string));
            dataColumn.MaxLength = 50;
            // Create the "QRCode" column
            dataColumn = dataTable.Columns.Add("QRCode", typeof(string));
            dataColumn.MaxLength = 100;
            // Create the "QRCodePublic" column
            dataColumn = dataTable.Columns.Add("QRCodePublic", typeof(string));
            dataColumn.MaxLength = 100;
            // Create the "Color" column
            dataColumn = dataTable.Columns.Add("Color", typeof(string));
            dataColumn.MaxLength = 50;
            // Create the "ProductImportType" column
            dataColumn = dataTable.Columns.Add("ProductImportType", typeof(string));
            dataColumn.MaxLength = 100;
            // Create the "Unit" column
            dataColumn = dataTable.Columns.Add("Unit", typeof(string));
            dataColumn.MaxLength = 50;
            // Create the "Weight" column
            dataColumn = dataTable.Columns.Add("Weight", typeof(string));
            dataColumn.Caption = "weight";
            dataColumn.MaxLength = 100;
            // Create the "PositionID" column
            dataColumn = dataTable.Columns.Add("PositionID", typeof(int));
            // Create the "Supplier" column
            dataColumn = dataTable.Columns.Add("Supplier", typeof(string));
            dataColumn.Caption = "supplier";
            dataColumn.MaxLength = 100;
            // Create the "MadeIn" column
            dataColumn = dataTable.Columns.Add("MadeIn", typeof(string));
            dataColumn.MaxLength = 100;
            // Create the "Pallet_ID" column
            dataColumn = dataTable.Columns.Add("Pallet_ID", typeof(string));
            dataColumn.MaxLength = 100;
            // Create the "CreatedDate" column
            dataColumn = dataTable.Columns.Add("CreatedDate", typeof(System.DateTime));
            // Create the "Other1" column
            dataColumn = dataTable.Columns.Add("Other1", typeof(string));
            dataColumn.MaxLength = 100;
            // Create the "Other2" column
            dataColumn = dataTable.Columns.Add("Other2", typeof(string));
            dataColumn.MaxLength = 100;
            // Create the "Other3" column
            dataColumn = dataTable.Columns.Add("Other3", typeof(string));
            dataColumn.MaxLength = 100;
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
                case "WarehouseTempPro_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "ProductName":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "ProductSkuEffect":
                    parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
                    break;

                case "ProductSku":
                    parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
                    break;

                case "ProductNumber":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "ProductPackage_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "SerialNumberStart":
                    parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
                    break;

                case "SerialNumberEnd":
                    parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
                    break;

                case "QRCode":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "QRCodePublic":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Color":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "ProductImportType":
                    parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
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

                case "Supplier":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "MadeIn":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Pallet_ID":
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
        /// Exist <see cref="WarehouseTempProRow"/> by the primary key.
        /// </summary>
        /// <param name="warehouseTempPro_ID">The <c>WarehouseTempPro_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseTempProRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual bool Exist(int warehouseTempPro_ID)
        {
            string LOCATION = "Exist(int warehouseTempPro_ID)";
            IDbCommand cmd = _db.CreateCommand("WarehouseTempPro_GetByPrimaryKey", CommandType.StoredProcedure);
            AddParameter(cmd, "WarehouseTempPro_ID", warehouseTempPro_ID);
            WarehouseTempProRow[] tempArray = MapRecords(cmd);
            if (0 == tempArray.Length)
                return false;
            return true;
        }

    }
}




