
// <fileinfo name="Base\WarehouseSlotInforCollectionBase.cs">
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
    /// The base class for <see cref="WarehouseSlotInforCollection"/>. Provides methods 
    /// for common database table operations. 
    /// </summary>
    /// <remarks>
    /// Do not change this source code. Update the <see cref="WarehouseSlotInforCollection"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseSlotInforCollectionBase
        : Base.ConllectionBase

    {
        // Constants
        public const string SlotInfor_IDColumnName = "SlotInfor_ID";
        public const string Slot_IDColumnName = "Slot_ID";
        public const string ProductSkuColumnName = "ProductSku";
        public const string ProductSkuEffectColumnName = "ProductSkuEffect";
        public const string Amount = "Amount";
        public const string CreatedDateColumnName = "CreatedDate";
        public const string LastEditDateColumnName = "LastEditDate";
        public const string Other1 = "Other1";
        public const string Other2 = "Other2";
        public const string Other3 = "Other3";
        public const string IsOldProduct = "IsOldProduct";


        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
        /// class with the specified <see cref="Database"/>.
        /// </summary>
        /// <param name="db">The <see cref="Database"/> object.</param>
        public WarehouseSlotInforCollectionBase(Database db) : base(db)
        {
            this.TABLENAME = "WarehouseSlotInfor";
        }

        public WarehouseSlotInforCollectionBase() : base()
        {
            this.TABLENAME = "WarehouseSlotInfor";
        }



        /// <summary>
        /// Gets an array of all records from the <c>WarehouseSlotInfor</c> table.
        /// </summary>
        /// <returns>An array of <see cref="WarehouseSlotInforRow"/> objects.</returns>
        public virtual WarehouseSlotInforRow[] GetAll()
        {
            return MapRecords(CreateGetAllCommand());
        }
        public virtual WarehouseSlotInforRow[] GetReadySlot()
        {
            return MapRecords(CreateGetReadSlotCommand());
        }

        protected virtual IDbCommand CreateGetReadSlotCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseSlotInfor_GetReadSlot", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object that 
        /// includes all records from the <c>WarehouseSlotInfor</c> table.
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
        public virtual DataTable GetAllReadyAsDataTable()
        {
            string LOCATION = "GetAllReadyAsDataTable()";
            try
            {
                return MapRecordsToDataTable(CreateGetAllReadyCommand());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        protected virtual IDbCommand CreateGetAllReadyCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseSlotInfor_GetReadySlot", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
        /// to retrieve all records from the <c>WarehouseSlotInfor</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetAllCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseSlotInfor_GetAll", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        /// <summary>
        /// Gets the first <see cref="WarehouseSlotInforRow"/> objects that 
        /// match the search condition.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>An instance of <see cref="WarehouseSlotInforRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public WarehouseSlotInforRow GetRow(string whereSql)
        {
            string LOCATION = "GetRow(string whereSql)";
            try
            {
                int totalRecordCount = -1;
                WarehouseSlotInforRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
        /// Gets an array of <see cref="WarehouseSlotInforRow"/> objects that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
        /// <returns>An array of <see cref="WarehouseSlotInforRow"/> objects.</returns>
        public WarehouseSlotInforRow[] GetAsArray(string whereSql, string orderBySql)
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
        /// Gets an array of <see cref="WarehouseSlotInforRow"/> objects that 
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
        /// <returns>An array of <see cref="WarehouseSlotInforRow"/> objects.</returns>
        public virtual WarehouseSlotInforRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
            IDataReader reader = null;
            IDbCommand cmd = null;
            try
            {
                cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
                reader = _db.ExecuteReader(cmd);
                WarehouseSlotInforRow[] rows = MapRecords(reader);
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
                IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_GetAdHoc", CommandType.StoredProcedure);
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
                IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_GetPageAdHoc", CommandType.StoredProcedure);

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
        /// Gets <see cref="WarehouseSlotInforRow"/> by the primary key.
        /// </summary>
        /// <param name="slot_ID">The <c>Slot_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseSlotInforRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual WarehouseSlotInforRow[] GetBySlot_ID(int slot_ID)
        {
            string LOCATION = "GetBySlot_ID(int slot_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_GetBySlot_ID", CommandType.StoredProcedure);
                AddParameter(cmd, "Slot_ID", slot_ID);
                WarehouseSlotInforRow[] tempArray = MapRecords(cmd);
                if (0 == tempArray.Length)
                    return null;

                return tempArray;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        /// <summary>
        /// Gets <see cref="WarehouseSlotInforRow"/> by the primary key.
        /// </summary>
        /// <param name="slot_ID">The <c>Slot_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseSlotInforRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual WarehouseSlotInforRow GetByPrimaryKey(int SlotInfor_ID)
        {
            string LOCATION = "GetByPrimaryKey(int SlotInfor_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_GetByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "SlotInfor_ID", SlotInfor_ID);
                WarehouseSlotInforRow[] tempArray = MapRecords(cmd);
                if (0 == tempArray.Length)
                    return null;

                return tempArray[0];
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        public virtual int UpdateAmount(int Slot_ID, int Amount, string Serial)
        {
            string LOCATION = "UpdateAmount(int Slot_ID, int Amount, string Serial)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_UpdateAmount", CommandType.StoredProcedure);
                // Amount
                if (Amount == null)
                    AddParameter(cmd, "Amount", DBNull.Value);
                else
                    AddParameter(cmd, "Amount", Amount);

                // Slot_ID
                if (Slot_ID == null)
                    AddParameter(cmd, "Slot_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Slot_ID", Slot_ID);
                if (Serial == null)
                    AddParameter(cmd, "Other1", DBNull.Value);
                else
                    AddParameter(cmd, "Other1", Serial);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return -1;
        }



        /// <summary>
        /// Adds a new record into the <c>WarehouseSlotInfor</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseSlotInforRow"/> object to be inserted.</param>
        public virtual void Insert(WarehouseSlotInforRow value)
        {
            string LOCATION = "Insert(WarehouseSlotInforRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_Insert", CommandType.StoredProcedure);

                // Amount
                if (value.IsAmountNull)
                    AddParameter(cmd, "Amount", DBNull.Value);
                else
                    AddParameter(cmd, "Amount", value.Amount);

                // Slot_ID
                if (value.IsSlot_IDNull)
                    AddParameter(cmd, "Slot_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Slot_ID", value.Slot_ID);

                // ProductSku
                if (value.IsProductSkuNull)
                    AddParameter(cmd, "ProductSku", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSku", value.ProductSku);

                // ProductSkuEffect
                if (value.IsProductSkuEffectNull)
                    AddParameter(cmd, "SlotName", DBNull.Value);
                else
                    AddParameter(cmd, "SlotName", value.ProductSkuEffect);
                // CreatedDate
                if (value.IsCreatedDateNull)
                    AddParameter(cmd, "CreatedDate", DBNull.Value);
                else
                    AddParameter(cmd, "CreatedDate", value.CreatedDate);

                // EditDate
                if (value.IsEditDateNull)
                    AddParameter(cmd, "EditDate", DBNull.Value);
                else
                    AddParameter(cmd, "EditDate", value.EditDate);
                // ProductPartNumber
                if (value.IsProductPartNumberNull)
                    AddParameter(cmd, "ProductPartNumber", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPartNumber", value.ProductPartNumber);
                // ProductPartDetail
                if (value.IsProductPartDetailNull)
                    AddParameter(cmd, "ProductPartDetail", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPartDetail", value.ProductPartDetail);
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
                // IsOldProduct
                if (value.IsOldProductNull)
                    AddParameter(cmd, "IsOldProduct", DBNull.Value);
                else
                    AddParameter(cmd, "IsOldProduct", value.IsOldProduct);

                value.Slot_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
        /// Updates a record in the <c>WarehouseSlotInfor</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseSlotInforRow"/>
        /// object used to update the table record.</param>
        /// <returns>true if the record was updated; otherwise, false.</returns>
        public virtual bool Save(WarehouseSlotInforRow value)
        {
            string LOCATION = "Save(WarehouseSlotInforRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_Save", CommandType.StoredProcedure);

                // Amount
                if (value.IsAmountNull)
                    AddParameter(cmd, "Amount", DBNull.Value);
                else
                    AddParameter(cmd, "Amount", value.Amount);

                // Slot_ID
                if (value.IsSlot_IDNull)
                    AddParameter(cmd, "Slot_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Slot_ID", value.Slot_ID);

                // ProductSku
                if (value.IsProductSkuNull)
                    AddParameter(cmd, "ProductSku", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSku", value.ProductSku);

                // ProductSkuEffect
                if (value.IsProductSkuEffectNull)
                    AddParameter(cmd, "ProductSkuEffect", DBNull.Value);
                else
                    AddParameter(cmd, "ProductSkuEffect", value.ProductSkuEffect);
                // CreatedDate
                if (value.IsCreatedDateNull)
                    AddParameter(cmd, "CreatedDate", DBNull.Value);
                else
                    AddParameter(cmd, "CreatedDate", value.CreatedDate);

                // EditDate
                if (value.IsEditDateNull)
                    AddParameter(cmd, "EditDate", DBNull.Value);
                else
                    AddParameter(cmd, "EditDate", value.EditDate);
                // ProductPartNumber
                if (value.IsProductPartNumberNull)
                    AddParameter(cmd, "ProductPartNumber", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPartNumber", value.ProductPartNumber);
                // ProductPartDetail
                if (value.IsProductPartDetailNull)
                    AddParameter(cmd, "ProductPartDetail", DBNull.Value);
                else
                    AddParameter(cmd, "ProductPartDetail", value.ProductPartDetail);
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
                // IsOldProduct
                if (value.IsOldProductNull)
                    AddParameter(cmd, "IsOldProduct", DBNull.Value);
                else
                    AddParameter(cmd, "IsOldProduct", value.IsOldProduct);

                AddParameter(cmd, "SlotInfor_ID", value.SlotInfor_ID);
                value.SlotInfor_ID = (int)cmd.ExecuteScalar();
                return value.SlotInfor_ID > 0;
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
                                DeleteByPrimaryKey((int)row["SlotInfor_ID"]);
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
        /// Deletes the specified object from the <c>WarehouseSlotInfor</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseSlotInforRow"/> object to delete.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public bool Delete(WarehouseSlotInforRow value)
        {
            return DeleteByPrimaryKey(value.SlotInfor_ID);
        }

        /// <summary>
        /// Deletes a record from the <c>WarehouseSlotInfor</c> table using
        /// the specified primary key.
        /// </summary>
        /// <param name="slot_ID">The <c>Slot_ID</c> column value.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public virtual bool DeleteByPrimaryKey(int SlotInfor_ID)
        {
            string LOCATION = "DeleteByPrimaryKey(int slot_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_DeleteByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "SlotInfor_ID", SlotInfor_ID);
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
        /// Deletes a record from the <c>WarehouseSlotInfor</c> table using
        /// the specified primary key.
        /// </summary>
        /// <param name="slot_ID">The <c>Slot_ID</c> column value.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public virtual bool DeleteBySlot_ID(int slot_ID)
        {
            string LOCATION = "DeleteByPrimaryKey(int slot_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_DeleteBySlot_ID", CommandType.StoredProcedure);
                AddParameter(cmd, "Slot_ID", slot_ID);
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
        /// Deletes <c>WarehouseSlotInfor</c> records that match the specified criteria.
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
        /// to delete <c>WarehouseSlotInfor</c> records that match the specified criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. 
        /// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateDeleteCommand(string whereSql)
        {
            string LOCATION = "CreateDeleteCommand(String whereSql)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_DeleteAdHoc", CommandType.StoredProcedure);

                _db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Deletes all records from the <c>WarehouseSlotInfor</c> table.
        /// </summary>
        /// <returns>The number of deleted records.</returns>
        public int DeleteAll()
        {
            string LOCATION = "DeleteAll()";
            try
            {
                return _db.CreateCommand("WarehouseSlotInfor_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
        /// <returns>An array of <see cref="WarehouseSlotInforRow"/> objects.</returns>
        protected WarehouseSlotInforRow[] MapRecords(IDbCommand command)
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
        /// <returns>An array of <see cref="WarehouseSlotInforRow"/> objects.</returns>
        protected WarehouseSlotInforRow[] MapRecords(IDataReader reader)
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
        /// <returns>An array of <see cref="WarehouseSlotInforRow"/> objects.</returns>
        protected virtual WarehouseSlotInforRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = " MapRecords(...)";
            if (0 > startIndex)
                throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
            if (0 > length)
                throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

            // SlotInfor_ID
            int SlotInfor_IDColumnIndex = reader.GetOrdinal("SlotInfor_ID");
            // Slot_ID
            int slot_IDColumnIndex = reader.GetOrdinal("Slot_ID");
            // ProductSku
            int ProductSkuColumnIndex = reader.GetOrdinal("ProductSku");
            // ProductSkuEffect
            int ProductSkuEffectColumnIndex = reader.GetOrdinal("ProductSkuEffect");
            // Amount
            int AmountColumnIndex = reader.GetOrdinal("Amount");
            // CreatedDate
            int CreatedDateColumnIndex = reader.GetOrdinal("CreatedDate");
            // EditDate
            int editDateColumnIndex = reader.GetOrdinal("EditDate");
            // ProductPartNumber
            int ProductPartNumberColumnIndex = reader.GetOrdinal("ProductPartNumber");
            // ProductPartDetail
            int ProductPartDetailColumnIndex = reader.GetOrdinal("ProductPartDetail");
            // Other1
            int Other1ColumnIndex = reader.GetOrdinal("Other1");
            // Other2
            int Other2ColumnIndex = reader.GetOrdinal("Other2");
            // Other3
            int Other3ColumnIndex = reader.GetOrdinal("Other3");
            // IsOldProduct
            int IsOldProductColumnIndex = reader.GetOrdinal("IsOldProduct");

            System.Collections.ArrayList recordList = new System.Collections.ArrayList();
            int ri = -startIndex;
            while (reader.Read())
            {
                ri++;
                if (ri > 0 && ri <= length)
                {
                    WarehouseSlotInforRow record = new WarehouseSlotInforRow();
                    recordList.Add(record);

                    record.SlotInfor_ID = Convert.ToInt32(reader.GetValue(SlotInfor_IDColumnIndex));
                    record.Slot_ID = Convert.ToInt32(reader.GetValue(slot_IDColumnIndex));
                    if (!reader.IsDBNull(ProductSkuColumnIndex))
                        record.ProductSku = Convert.ToString(reader.GetValue(ProductSkuColumnIndex));
                    if (!reader.IsDBNull(ProductSkuEffectColumnIndex))
                        record.ProductSkuEffect = Convert.ToString(reader.GetValue(ProductSkuEffectColumnIndex));
                    if (!reader.IsDBNull(AmountColumnIndex))
                        record.Amount = Convert.ToInt32(reader.GetValue(AmountColumnIndex));
                    if (!reader.IsDBNull(CreatedDateColumnIndex))
                        record.CreatedDate = Convert.ToDateTime(reader.GetValue(CreatedDateColumnIndex));
                    if (!reader.IsDBNull(editDateColumnIndex))
                        record.EditDate = Convert.ToDateTime(reader.GetValue(editDateColumnIndex));
                    if (!reader.IsDBNull(ProductPartNumberColumnIndex))
                        record.ProductPartNumber = Convert.ToString(reader.GetValue(ProductPartNumberColumnIndex));
                    if (!reader.IsDBNull(ProductPartDetailColumnIndex))
                        record.ProductPartDetail = Convert.ToString(reader.GetValue(ProductPartDetailColumnIndex));
                    if (!reader.IsDBNull(Other1ColumnIndex))
                        record.Other1 = Convert.ToString(reader.GetValue(Other1ColumnIndex));
                    if (!reader.IsDBNull(Other2ColumnIndex))
                        record.Other2 = Convert.ToString(reader.GetValue(Other2ColumnIndex));
                    if (!reader.IsDBNull(Other3ColumnIndex))
                        record.Other3 = Convert.ToString(reader.GetValue(Other3ColumnIndex));
                    if (!reader.IsDBNull(IsOldProductColumnIndex))
                        record.IsOldProduct = Convert.ToInt32(reader.GetValue(IsOldProductColumnIndex)); 

                    if (ri == length && 0 != totalRecordCount)
                        break;
                }
            }

            if (0 == totalRecordCount)
                totalRecordCount = ri + startIndex;
            else
                totalRecordCount = -1;

            return (WarehouseSlotInforRow[])(recordList.ToArray(typeof(WarehouseSlotInforRow)));
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
        /// Converts <see cref="System.Data.DataRow"/> to <see cref="WarehouseSlotInforRow"/>.
        /// </summary>
        /// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
        /// <returns>A reference to the <see cref="WarehouseSlotInforRow"/> object.</returns>
        protected virtual WarehouseSlotInforRow MapRow(DataRow row)
        {
            string LOCATION = "WarehouseSlotInforRow MapRow(DataRow row)";
            WarehouseSlotInforRow mappedObject = new WarehouseSlotInforRow();
            DataTable dataTable = row.Table;
            DataColumn dataColumn;
            // Column "SlotInfor_ID"
            dataColumn = dataTable.Columns["SlotInfor_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.SlotInfor_ID = (int)(row[dataColumn]);
            // Column "Slot_ID"
            dataColumn = dataTable.Columns["Slot_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.Slot_ID = (int)(row[dataColumn]);
            // Column "ProductSku"
            dataColumn = dataTable.Columns["ProductSku"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductSku = (string)(row[dataColumn]);
            // Column "ProductSkuEffect"
            dataColumn = dataTable.Columns["ProductSkuEffect"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductSkuEffect = (string)(row[dataColumn]);
            // Column "Amount"
            dataColumn = dataTable.Columns["Amount"];
            if (!row.IsNull(dataColumn))
                mappedObject.Amount = (int)(row[dataColumn]);
            // Column "CreatedDate"
            dataColumn = dataTable.Columns["CreatedDate"];
            if (!row.IsNull(dataColumn))
                mappedObject.CreatedDate = (System.DateTime)(row[dataColumn]);
            // Column "EditDate"
            dataColumn = dataTable.Columns["EditDate"];
            if (!row.IsNull(dataColumn))
                mappedObject.EditDate = (System.DateTime)(row[dataColumn]);
            // Column "ProductPartNumber"
            dataColumn = dataTable.Columns["ProductPartNumber"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductPartNumber = (string)(row[dataColumn]);
            // Column "ProductPartDetail"
            dataColumn = dataTable.Columns["ProductPartDetail"];
            if (!row.IsNull(dataColumn))
                mappedObject.ProductPartDetail = (string)(row[dataColumn]);
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
            // Column "IsOldProduct"
            dataColumn = dataTable.Columns["IsOldProduct"];
            if (!row.IsNull(dataColumn))
                mappedObject.IsOldProduct = (int)(row[dataColumn]);
            return mappedObject; 
        }

        /// <summary>
        /// Creates a <see cref="System.Data.DataTable"/> object for 
        /// the <c>WarehouseSlotInfor</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected virtual DataTable CreateDataTable()
        {
            string LOCATION = "CreateDataTable()";
            DataTable dataTable = new DataTable();
            dataTable.TableName = "WarehouseSlotInfor";
            DataColumn dataColumn;
            // Create the "Slot_ID" column
            dataColumn = dataTable.Columns.Add("SlotInfor_ID", typeof(int));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            // Create the "SlotInfor" column
            dataColumn = dataTable.Columns.Add("Slot_ID", typeof(int));
            dataColumn.AllowDBNull = false;
            // Create the "ProductSku" column
            dataColumn = dataTable.Columns.Add("ProductSku", typeof(string));
            dataColumn.MaxLength = 1000;
            // Create the "ProductSkuEfect" column
            dataColumn = dataTable.Columns.Add("ProductSkuEfect", typeof(string));
            // Create the "Amount" column
            dataColumn = dataTable.Columns.Add("Amount", typeof(int));
            // Create the "CreatedDate" column
            dataColumn = dataTable.Columns.Add("CreatedDate", typeof(System.DateTime));
            // Create the "LastEditBy" column
            dataColumn = dataTable.Columns.Add("EditDate", typeof(System.DateTime));
            // Create the "ProductPartNumber" column
            dataColumn = dataTable.Columns.Add("ProductPartNumber", typeof(string));
            // Create the "ProductPartDetail" column
            dataColumn = dataTable.Columns.Add("ProductPartDetail", typeof(string));
            // Create the "Other1" column
            dataColumn = dataTable.Columns.Add("Other1", typeof(string));
            // Create the "Other2" column
            dataColumn = dataTable.Columns.Add("Other2", typeof(string));
            // Create the "Other3" column
            dataColumn = dataTable.Columns.Add("Other3", typeof(string));
            // Create the "IsOldProduct" column
            dataColumn = dataTable.Columns.Add("IsOldProduct", typeof(string));
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
                case "SlotInfor_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "Slot_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "ProductSku":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "ProductSkuEffect":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Amount":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;
                case "CreatedDate":
                    parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
                    break;

                case "EditDate":
                    parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
                    break;

                case "ProductPartNumber":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "ProductPartDetail":
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

                case "IsOldProduct":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                default:
                    throw new ArgumentException("Unknown parameter name (" + paramName + ").");
            }
            return parameter;
        }

        /// <summary>
        /// Exist <see cref="WarehouseSlotInforRow"/> by the primary key.
        /// </summary>
        /// <param name="slot_ID">The <c>Slot_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseSlotInforRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual bool Exist(int slotInfor_ID)
        {
            string LOCATION = "Exist(int slotInfor_ID)";
            IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_GetByPrimaryKey", CommandType.StoredProcedure);
            AddParameter(cmd, "SlotInfor_ID", slotInfor_ID);
            WarehouseSlotInforRow[] tempArray = MapRecords(cmd);
            if (0 == tempArray.Length)
                return false;
            return true;
        }

    }
}




