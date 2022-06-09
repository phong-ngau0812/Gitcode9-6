
// <fileinfo name="DbObj\Conllection.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			You can update this source code manually. If the file
//			already exists it will not be rewritten by the generator.
//		</remarks>
//		<generator rewritefile="False" >Smc SaleFrame1.0</generator>
// </fileinfo>


using Base;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DbObj
{

    public class Conllection
            : Base.ConllectionBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Conllection"/> class.
        /// </summary>
        public Conllection()
        {
        }

        public DataTable GetListLocationByRegion(int Region_ID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetListLocationByRegion_ID");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Region_ID", Region_ID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetChartZone", ex);
            }
            return dtResult;
        }

        public DataSet GetProductBrand_pagging(int currentPage, int recodperpage, int PageSize, string Name, int Ministry_ID, int Branch_ID, int Location_ID, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetProductBrand_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currentPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@PageSize", PageSize));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@Ministry_ID", Ministry_ID));
                cmd.Parameters.Add(new SqlParameter("@Branch_ID", Branch_ID));
                cmd.Parameters.Add(new SqlParameter("@Location_ID", Location_ID));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProductBrand_pagging", ex);
            }
            return dtResult;
        }
        public DataSet GetProductBrand_pagging3(int currentPage, int recodperpage, int PageSize, string Name, int Branch_ID, int District_ID, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetProductBrand_paging3");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currentPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@PageSize", PageSize));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@DepartmentMan_ID", Branch_ID));
                cmd.Parameters.Add(new SqlParameter("@District_ID", District_ID));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProductBrand_pagging", ex);
            }
            return dtResult;
        }

        public DataSet GetProduct_pagging(int currentPage, int recodperpage, int PageSize, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spProduct_pagging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currentPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@PageSize", PageSize));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProduct_pagging", ex);
            }
            return dtResult;
        }
        public DataSet GetSearchProduct_pagging(int currentPage, int recodperpage, int PageSize, string keyword, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spSearchProduct_pagging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currentPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@PageSize", PageSize));
                cmd.Parameters.Add(new SqlParameter("@Keyword", keyword));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProduct_pagging", ex);
            }
            return dtResult;
        }
        public DataSet GetDocument_paging(int currentPage, int recodperpage, int PageSize, string Title, int DocumentCategory_ID, DateTime StartDate, DateTime EndDate, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetDocument_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currentPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@PageSize", PageSize));
                cmd.Parameters.Add(new SqlParameter("@Title", Title));
                cmd.Parameters.Add(new SqlParameter("@DocumentCategory_ID", DocumentCategory_ID));
                cmd.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetDocument_paging", ex);
            }
            return dtResult;
        }
        public DataSet GetVideo_paging(int currentPage, int recodperpage, int PageSize, string Title, DateTime StartDate, DateTime EndDate, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetVieo_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currentPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@PageSize", PageSize));
                cmd.Parameters.Add(new SqlParameter("@Title", Title));
                cmd.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetDocument_paging", ex);
            }
            return dtResult;
        }

        public DataSet GetNews_paging3(int currentPage, int recodperpage, int PageSize, string Title, DateTime StartDate, DateTime EndDate, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetNews_paging3");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currentPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@PageSize", PageSize));
                cmd.Parameters.Add(new SqlParameter("@Title", Title));
                cmd.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetDocument_paging", ex);
            }
            return dtResult;
        }
        public DataSet GetNews_paging2(int currentPage, int recodperpage, int PageSize, string Title, DateTime StartDate, DateTime EndDate, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetNews_paging2");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currentPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@PageSize", PageSize));
                cmd.Parameters.Add(new SqlParameter("@Title", Title));
                cmd.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetDocument_paging", ex);
            }
            return dtResult;
        }
        public DataSet Search_GetNews_paging(int currentPage, int recodperpage, int PageSize, string Title, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spSearch_GetNews_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currentPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@PageSize", PageSize));
                cmd.Parameters.Add(new SqlParameter("@Title", Title));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("Search_GetNews_paging", ex);
            }
            return dtResult;
        }
        public DataTable GetChartZone(int ProductBrand_ID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetChartZone");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetChartZone", ex);
            }
            return dtResult;
        }
        public DataTable WarehouseRack_GetByPrimary(int ID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("WarehouseRack_GetByPrimary");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Rack_ID", ID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("WarehouseRack_GetByPrimary", ex);
            }
        }
        public DataTable GetChartWarehouseExport(int Year, int ProductBrand_ID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetChartWarehouseExport");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Year", Year));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetWarehouseExport", ex);
            }
            return dtResult;
        }
        public void UpdateStatusProductIDPromotion(int StatusProduct, int Promotion_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdatePromotion", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Status", StatusProduct));
                cmd.Parameters.Add(new SqlParameter("@Promotion_ID", Promotion_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("ProductItemQRCodeCreate", ex);
            }
        }
        public void UpdateStatusProductIDHome(int StatusProduct, string ListProduct_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdateAllListProductID", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Status", StatusProduct));
                cmd.Parameters.Add(new SqlParameter("@ListProductID", ListProduct_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("ProductItemQRCodeCreate", ex);
            }
        }
        public void UpdateStatusProductIDNew(int StatusProduct, string ListProduct_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdateAllListProductIDNew", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Status", StatusProduct));
                cmd.Parameters.Add(new SqlParameter("@ListProductID", ListProduct_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("ProductItemQRCodeCreate", ex);
            }
        }
        public void UpdateStatusProductIDQRCode(int StatusProduct, string ListProduct_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdateAllListProductIDQRCode", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Status", StatusProduct));
                cmd.Parameters.Add(new SqlParameter("@ListProductID", ListProduct_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("ProductItemQRCodeCreate", ex);
            }
        }
        public void UpdateStatusProductIDHot(int StatusProduct, string ListProduct_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdateAllListProductIDHot", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Status", StatusProduct));
                cmd.Parameters.Add(new SqlParameter("@ListProductID", ListProduct_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("ProductItemQRCodeCreate", ex);
            }
        }
        public void UpdateStatusProductIDActive(int StatusProduct, string ListProduct_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdateAllListProductIDActive", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Status", StatusProduct));
                cmd.Parameters.Add(new SqlParameter("@ListProductID", ListProduct_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("ProductItemQRCodeCreate", ex);
            }
        }
        public DataTable GetChartWarehouseProductExport(int Year, int ProductBrand_ID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetChartWarehouseProductExport");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Year", Year));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetWarehouseExport", ex);
            }
            return dtResult;
        }
        public DataSet GetCountProduct(int ProductBrand_ID)
        {
            DataSet dtResult = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("sp_getCountProduct");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("getchartQRCode", ex);
            }
            return dtResult;
        }
        public DataTable GetChartQRCode(int Year, int ProductBrand_ID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetChartQRCode");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Year", Year));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("getchartQRCode", ex);
            }
            return dtResult;
        }

        public DataTable GetChartProductBrand(int Year)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetChartProductBrand");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Year", Year));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProductSearch", ex);
            }
            return dtResult;
        }
        public DataTable GetProduct(int ProductCategory_ID, int Quality_ID, DateTime FromDate, DateTime ToDate)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetProduct");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductCategory_ID", ProductCategory_ID));
                cmd.Parameters.Add(new SqlParameter("@Quality_ID", Quality_ID));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProductSearch", ex);
            }
            return dtResult;
        }
        public DataTable GetProductCategory()
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetProductCategory");
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProductSearch", ex);
            }
            return dtResult;
        }
        //Start Check
        public DataTable CheckExistPromotion(int Product_ID, int Status)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("CheckExistPromotion");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@Status", Status));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProductSearch", ex);
            }
            return dtResult;
        }
        //End Check

        public DataTable GetMaterialCategory()
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetMaterialCategory");
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetMaterialSearch", ex);
            }
            return dtResult;
        }
        public DataTable GetProductCategoryES()
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetProductCategoryES");
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProductSearch", ex);
            }
            return dtResult;
        }
        public DataTable GetBusinessType()
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetBusinessType");
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetBusinessType", ex);
            }
            return dtResult;
        }
        public DataSet GetProductV2(int currPage, int recodperpage, int Pagesize, int ProductCategory_ID, int Quality_ID, int ProductBrand_ID, int Country_ID, string CreateBy, DateTime FromDate, DateTime ToDate, string Name, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetProductV2(int currPage, int recodperpage, int Pagesize, int ProductCategory_ID, int Quality_ID , int ProductBrand_ID, int Country_ID, string CreateBy, DateTime FromDate, DateTime ToDate, string Name, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetProduct_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductCategory_ID", ProductCategory_ID));
                cmd.Parameters.Add(new SqlParameter("@Quality_ID", Quality_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Country_ID", Country_ID));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet GetProductV3(int currPage, int recodperpage, int Pagesize, int ProductCategory_ID, int ProductSet_ID, int Color_ID, string Size, int Material_ID, int Quality_ID, int ProductBrand_ID, int Country_ID,int ProductInWarehouse, string CreateBy, DateTime FromDate, DateTime ToDate, string ListCategoryID, string Name, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetProductV2(int currPage, int recodperpage, int Pagesize, int ProductCategory_ID, int Quality_ID , int ProductBrand_ID, int Country_ID, string CreateBy, DateTime FromDate, DateTime ToDate, string Name, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetProduct_pagingV3");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductCategory_ID", ProductCategory_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductSet_ID", ProductSet_ID));
                cmd.Parameters.Add(new SqlParameter("@Color_ID", Color_ID));
                cmd.Parameters.Add(new SqlParameter("@Size", Size));
                cmd.Parameters.Add(new SqlParameter("@Material_ID", Material_ID));
                cmd.Parameters.Add(new SqlParameter("@Quality_ID", Quality_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Country_ID", Country_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductInWarehouse", ProductInWarehouse));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@ListCategoryID", ListCategoryID));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet GetMaterialDN(int currPage, int recodperpage, int Pagesize, int WH_DeliveryNote_ID, int Supplier_ID, string CreateBy, DateTime FromDate, DateTime ToDate, string Code, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetMaterialDN(int currPage, int recodperpage, int Pagesize, int WH_DeliveryNote_ID, int Supplier_ID, string CreateBy, DateTime FromDate, DateTime ToDate, string Code, string Where, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("DeliveryNoteDN");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@WH_DeliveryNote_ID", WH_DeliveryNote_ID));
                cmd.Parameters.Add(new SqlParameter("@Supplier_ID", Supplier_ID));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@Code", Code));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet GetProductV3ES(int currPage, int recodperpage, int Pagesize, int ProductCategory_ID, int Quality_ID, int ProductBrand_ID, int Country_ID, int Location_ID, int District_ID, int Ward_ID, int DepartmentMan_ID, string CreateBy, DateTime FromDate, DateTime ToDate, string ListCategoryID, string Name, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetProductV2(int currPage, int recodperpage, int Pagesize, int ProductCategory_ID, int Quality_ID , int ProductBrand_ID, int Country_ID, string CreateBy, DateTime FromDate, DateTime ToDate, string Name, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetProduct_pagingV3ES");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductCategory_ID", ProductCategory_ID));
                cmd.Parameters.Add(new SqlParameter("@Quality_ID", Quality_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Country_ID", Country_ID));
                cmd.Parameters.Add(new SqlParameter("@Location_ID", Location_ID));
                cmd.Parameters.Add(new SqlParameter("@District_ID", District_ID));
                cmd.Parameters.Add(new SqlParameter("@Ward_ID", Ward_ID));
                cmd.Parameters.Add(new SqlParameter("@DepartmentMan_ID", DepartmentMan_ID));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@ListCategoryID", ListCategoryID));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        //StandardCheck use Proc
        public DataSet GetStandard(int currPage, int recodperpage, int Pagesize,int WH_StandardCheck_ID, int WH_MaterialCategory_ID,  string CreateBy, DateTime FromDate, DateTime ToDate, string WH_MaterialList_ID, string Name,string Description, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetStandard(int currPage, int recodperpage, int Pagesize,int WH_StandardCheck_ID, int WH_MaterialCategory_ID,  string CreateBy, DateTime FromDate, DateTime ToDate, string WH_MaterialList_ID, string Name,string Description, string Where, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("pdStandardCheck");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@WH_StandardCheck_ID", WH_StandardCheck_ID));
                cmd.Parameters.Add(new SqlParameter("@WH_MaterialCategory_ID", WH_MaterialCategory_ID));
                
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@WH_MaterialList_ID", WH_MaterialList_ID));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@Description", Description));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        //--------------------------------------------------------

        public DataSet GetPromotion(int currPage, int recodperpage, int Pagesize, DateTime FromDate, DateTime ToDate, string Name, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetPromotion(int currPage, int recodperpage, int Pagesize, DateTime FromDate, DateTime ToDate, string Name, string Where, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetPromotion_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet GetProductReview(int currPage, int recodperpage, int Pagesize, int Product_ID, int Approved, DateTime FromDate, DateTime ToDate, string FullName)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetProductReviewV2(int currPage, int recodperpage, int Pagesize, int Product_ID, int Approved ,  DateTime FromDate, DateTime ToDate, string FullName, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetProductReview");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@Approved", Approved));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@FullName", FullName));
                //cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }

        public DataSet GetProductPackageV2(int currPage, int recodperpage, int Pagesize, int ProductPackage_ID, int ProductBrand_ID, int Workshop_ID, int ProductPackageStatus_ID, string CreateBy, DateTime FromDate, DateTime ToDate, string CODE, string SGIN, string Name, string ProductBrandList, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetProductPackageV2(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Workshop_ID, int ProductPackageStatus_ID,  string CreateBy, DateTime FromDate, DateTime ToDate,string CODE, string SGIN, string Name, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetProductPackage_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductPackage_ID", ProductPackage_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Workshop_ID", Workshop_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductPackageStatus_ID", ProductPackageStatus_ID));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@CODE", CODE));
                cmd.Parameters.Add(new SqlParameter("@SGIN", SGIN));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@ProductBrandList", ProductBrandList));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet GetProductPackageV3(int currPage, int recodperpage, int Pagesize, int ProductPackage_ID, int Zone_ID, int ProductBrand_ID, int Workshop_ID, int ProductPackageStatus_ID, string CreateBy, DateTime FromDate, DateTime ToDate, string CODE, string SGIN, string Name, string ProductBrandList, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetProductPackageV2(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Workshop_ID, int ProductPackageStatus_ID,  string CreateBy, DateTime FromDate, DateTime ToDate,string CODE, string SGIN, string Name, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetProductPackage_paging_V1");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductPackage_ID", ProductPackage_ID));
                cmd.Parameters.Add(new SqlParameter("@Zone_ID", Zone_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Workshop_ID", Workshop_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductPackageStatus_ID", ProductPackageStatus_ID));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@CODE", CODE));
                cmd.Parameters.Add(new SqlParameter("@SGIN", SGIN));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@ProductBrandList", ProductBrandList));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet GetQRCodePackageV2(int currPage, int recodperpage, int Pagesize, int QRCodePackage_ID, int ProductBrand_ID, int QRCodeStatus_ID, int QRCodePackageType_ID, string CreateBy, DateTime FromDate, DateTime ToDate, string Name, string Serial, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetQRCodePackageV2(int currPage, int recodperpage, int Pagesize, int QRCodePackage_ID, int ProductBrand_ID,  int QRCodeStatus_ID, int QRCodePackageType_ID,  string CreateBy, DateTime FromDate, DateTime ToDate,string Name, string Serial,  string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetQRCodePackage_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodeStatus_ID", QRCodeStatus_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackageType_ID", QRCodePackageType_ID));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@Serial", Serial));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet QRCodeWarehouseV2(int currPage, int recodperpage, int Pagesize, string ProductPackage_ID, int ProductID, int ProductType, int QRCodePackageType_ID, string CreateBy, DateTime FromDate, DateTime ToDate, string Name, string Serial, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "QRCodeWarehouseV2(int currPage, int recodperpage, int Pagesize, int QRCodePackage_ID, int ProductBrand_ID,  int QRCodeStatus_ID, int QRCodePackageType_ID,  string CreateBy, DateTime FromDate, DateTime ToDate,string Name, string Serial,  string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetQRCodeWareHouse2_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductPackage_ID", ProductPackage_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductID", ProductID));
                cmd.Parameters.Add(new SqlParameter("@ProductType", ProductType));
                cmd.Parameters.Add(new SqlParameter("@QRCodeWarehouseType_ID", QRCodePackageType_ID));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@Serial", Name));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public void ProductItemQRCodeCreate(int number, int ProductPackage_ID, Guid CreateBy, int ItemCount)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("ProductItemQRCodeCreate_V2", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@number", number));
                cmd.Parameters.Add(new SqlParameter("@ProductPackage_ID", ProductPackage_ID));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@ItemCount", ItemCount));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("ProductItemQRCodeCreate", ex);
            }
        }
        public void UpdateUserVsPageFunction(string UserId, string PageFunction_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdateUserVsPageFunction", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
                cmd.Parameters.Add(new SqlParameter("@PageFunction_ID", PageFunction_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("ProductItemQRCodeCreate", ex);
            }
        }
        public void UpdateUserVsPageFunctionProductBrand(string UserId)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdateUserVsPageFunctionProductBrand", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("ProductItemQRCodeCreate", ex);
            }
        }
        public void UpdateUserVsPageFunctionProductBrandV2(string UserId, string GroupFunctionID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdateUserVsPageFunctionProductBrand_V2", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
                cmd.Parameters.Add(new SqlParameter("@GroupFunctionID", GroupFunctionID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("ProductItemQRCodeCreate", ex);
            }
        }
        public void UpdateUserVsPageFunctionProductBrandShort(string UserId)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdateUserVsPageFunctionProductBrand_Short", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("UpdateUserVsPageFunctionProductBrandShort", ex);
            }
        }

        public DataTable GetProductPackageOrder(int ProductBrand_ID, int ProductPackageOrderCategory_ID, int ProductPackageOrder_ID, int Status, int Approve, DateTime FromDate, DateTime ToDate, string Name, string orderby)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetProductPackageOrder");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductPackageOrderCategory_ID", ProductPackageOrderCategory_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductPackageOrder_ID", ProductPackageOrder_ID));
                cmd.Parameters.Add(new SqlParameter("@Status", Status));
                cmd.Parameters.Add(new SqlParameter("@Approve", Approve));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProductSearch", ex);
            }
            return dtResult;
        }

        public DataSet GetFarmV2(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Zone_ID, int Area_ID, string Name, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetFarmV2(int currPage ,int recodperpage,int Pagesize ,int ProductBrand_ID ,int Zone_ID ,int Area_ID ,string Name ,string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetFarm_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Zone_ID", Zone_ID));
                cmd.Parameters.Add(new SqlParameter("@Area_ID", Area_ID));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }


        public DataSet GetWorkshop_paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Department_ID, int workshop_id, string Name, string orderby, string workshop_list)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetWorkshop_paging(int currPage ,int recodperpage,int Pagesize ,int ProductBrand_ID ,int Department_ID  ,string Name ,string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetWorkshop_paging_1");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Department_ID", Department_ID));
                cmd.Parameters.Add(new SqlParameter("@workshop_id", workshop_id));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                cmd.Parameters.Add(new SqlParameter("@workshop_list", workshop_list));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }

        public DataSet spGetWarehouseExport_paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int ProductPackageOrder_ID, string Name, DateTime FromDate, DateTime ToDate, string orderby, string UserId)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "spGetWarehouseExport_paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int ProductPackageOrder_ID, string Name, DateTime FromDate, DateTime ToDate, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetWarehouseExport");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductPackageOrder_ID", ProductPackageOrder_ID));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }

        public DataTable GetPrintWarehouseExport(int WarehouseExport_ID)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "GetprintWarehouseExport(int WarehouseExport_ID  )";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetprintWarehouseExport");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@WarehouseExport_ID", WarehouseExport_ID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable GetReadySLot(string Where)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "WarehouseSlot_GetReadySlot";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("WarehouseSlot_GetReadySlot");
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable GetAllSlot(int Slot)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "WarehouseSlot_GetAllSlot";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("WarehouseSlot_GetAllSlot");
                cmd.Parameters.Add(new SqlParameter("@Slot_ID", Slot));
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable GetSLotByWhere(string Where, string orderby)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "GetSLotByWhere";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("WarehouseSlot_GetSLotByWhere");
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@OrderBy", orderby));
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable GetRackByWhereProductSku(string Where, string ProductSku, string orderby)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "WarehouseRack_GetAllRackByProductSku";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("WarehouseRack_GetAllRackByProductSku");
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@ProductSku", ProductSku));
                cmd.Parameters.Add(new SqlParameter("@OrderBy", orderby));
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable GetReadySLotPriority(string Where, string Sku)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "WarehouseSlot_GetReadySLotPriority";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("WarehouseSlot_GetReadySLotPriority");
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@ProductSku", Sku));
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable GetSlotExport(string Where, string Sku)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "WarehouseSlot_GetSlotExport";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("WarehouseSlot_GetSlotExport");
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@ProductSku", Sku));
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable GetSlotExportAmount(string Where, string Sku)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "WarehouseSlot_GetSlotExportAmount";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("WarehouseSlot_GetSlotExportAmount");
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@ProductSku", Sku));
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable GetSlotExport_PartProduct(string Where, string Sku, string ProductPartDetailID)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "WarehouseSlot_GetSlotExport_PartProduct";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("WarehouseSlot_GetSlotExport_PartProduct");
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@ProductSku", Sku));
                cmd.Parameters.Add(new SqlParameter("@ProductPartDetailID", ProductPartDetailID));
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable GetSlotExportAmount_PartProduct(string Where, string Sku, string ProductPartDetailID)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "WarehouseSlot_GetSlotExportAmount_partProduct";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("WarehouseSlot_GetSlotExportAmount_PartProduct");
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@ProductSku", Sku));
                cmd.Parameters.Add(new SqlParameter("@ProductPartDetailID", ProductPartDetailID));
                cmd.CommandType = CommandType.StoredProcedure;
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }

        public DataSet spGetWarehouseImport_paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Warehouse_ID, DateTime FromDate, DateTime ToDate, string orderby, string UserId)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "spGetWarehouseImport_paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Warehouse_ID, DateTime FromDate, DateTime ToDate, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetWarehouseImport");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Warehouse_ID", Warehouse_ID));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet spGetWarehouseImportNote_paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Warehouse_ID, string Code, int Active, DateTime FromDate, DateTime ToDate, string orderby, string UserId)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "spGetWarehouseImportNote_paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Warehouse_ID,string NoteCode,int Active, DateTime FromDate, DateTime ToDate, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetWarehouseImportNote");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Warehouse_ID", Warehouse_ID));
                cmd.Parameters.Add(new SqlParameter("@WarehouseImportNoteCode", Code));
                cmd.Parameters.Add(new SqlParameter("@Active", Active));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet spGetWareHouseReport_paging(int currPage, int recodperpage, int Pagesize, int ProductID, int productType, string productSku, int productCategory, int DepartmentID,string IsProductPart, string Serial, DateTime FromDate, DateTime ToDate, string orderby, string UserId)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "spGetWareHouseReport_paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Warehouse_ID,string NoteCode,int Active, DateTime FromDate, DateTime ToDate, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetWareHouseReport_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductID", ProductID));
                cmd.Parameters.Add(new SqlParameter("@productType", productType));
                cmd.Parameters.Add(new SqlParameter("@productSku", productSku));
                cmd.Parameters.Add(new SqlParameter("@productCategory", productCategory));
                cmd.Parameters.Add(new SqlParameter("@DepartmentID", DepartmentID));
                cmd.Parameters.Add(new SqlParameter("@IsProductPart", IsProductPart));
                cmd.Parameters.Add(new SqlParameter("@Serial", Serial));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable spGetWareHouseProductReport_ByProductID(int ProductID, string ProductImportType)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "spGetWareHouseProductReport_ByProductID(int ProductID, string ProductImportType)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetWareHouseProductReport_ByProductID");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductID", ProductID));
                cmd.Parameters.Add(new SqlParameter("@ProductImportType", ProductImportType));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable spGetWareHouseProductReportExport_ByProductID(int ProductID, string ProductImportType)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "spGetWareHouseProductReportExport_ByProductID(int ProductID, string ProductImportType)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetWareHouseProductReportExport_ByProductID");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductID", ProductID));
                cmd.Parameters.Add(new SqlParameter("@ProductImportType", ProductImportType));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet spGetWareHouseReport_Export(string where,DateTime FromDate, DateTime ToDate, string orderby, string UserId)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "spGetWareHouseReport_paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Warehouse_ID,string NoteCode,int Active, DateTime FromDate, DateTime ToDate, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetWareHouseReport_Export");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                cmd.Parameters.Add(new SqlParameter("@Where", where));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet spGetWarehouseTempPro_paging(int currPage, int recodperpage, int Pagesize, int ProductPackage_ID, DateTime FromDate, DateTime ToDate, string orderby, string UserId)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "spGetWarehouseImportNote_paging(int currPage, int recodperpage, int Pagesize, int ProductPackage_ID, DateTime FromDate, DateTime ToDate, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetWarehouseTempPro_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductPackage_ID", ProductPackage_ID));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet spGetWarehouseExportNote_paging(int currPage, int recodperpage, int Pagesize, int Agency_ID, int Warehouse_ID, string Code, string ProductBill, int Active, DateTime FromDate, DateTime ToDate, string orderby, string UserId)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "spGetWarehouseExportNote_paging(int currPage, int recodperpage, int Pagesize, int Agency_ID, int Warehouse_ID, string Code, string ProductBill, int Active, DateTime FromDate, DateTime ToDate, string orderby, string UserId)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetWarehouseExportNote");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@Agency_ID", Agency_ID));
                cmd.Parameters.Add(new SqlParameter("@Warehouse_ID", Warehouse_ID));
                cmd.Parameters.Add(new SqlParameter("@ExportNoteCode", Code));
                cmd.Parameters.Add(new SqlParameter("@ProductBill_ID", ProductBill));
                cmd.Parameters.Add(new SqlParameter("@Active", Active));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }

        public DataTable spGetWarehouseProduct_paging(int ProductBrand_ID, int Warehouse_ID, int ProductPackage_ID, int Product_ID, DateTime FromDate, DateTime ToDate, string orderby)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "spGetWarehouseProduct_paging(int ProductBrand_ID ,int Warehouse_ID,  int ProductPackage_ID, int Product_ID, DateTime FromDate, DateTime ToDate, string orderby )";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetWarehouseProduct_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Warehouse_ID", Warehouse_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductPackage_ID", ProductPackage_ID));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataTable WarehouseTempPro_SelectSerialRanger(string SerialStart, string SerialEnd)
        {
            DataTable dtResult = new DataTable();
            string LOCATION = "WarehouseTempPro_SelectSerialRanger";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("WarehouseTempPro_SelectSerialRanger");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SerialNumberStart", SerialStart));
                cmd.Parameters.Add(new SqlParameter("@SerialNumberEnd", SerialEnd));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }

        public DataTable GetMenu(string UserId)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GenerateMENU");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProductSearch", ex);
            }
            return dtResult;
        }
        public DataTable GetTaskNotification(int ProductPackage_ID, int Day)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetTaskNear1");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductPackage_ID", ProductPackage_ID));
                cmd.Parameters.Add(new SqlParameter("@Day", Day));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetTaskNotification", ex);
            }
            return dtResult;
        }
        public DataTable CheckPermission(string UserId, string Url)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("CheckPermission");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
                cmd.Parameters.Add(new SqlParameter("@Url", Url));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("CheckPermission", ex);
            }
            return dtResult;
        }
        public DataTable GetNotification(int ProductBrand_ID, int Department_ID, int Zone_ID, int Area_ID, string UserID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetNotification");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Department_ID", Department_ID));
                cmd.Parameters.Add(new SqlParameter("@Zone_ID", Zone_ID));
                cmd.Parameters.Add(new SqlParameter("@Area_ID", Area_ID));
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetNotification", ex);
            }
            return dtResult;
        }
        public DataTable GetNotificationWareHouse(int ProductBrand_ID, int Department_ID, int Zone_ID, int Area_ID, string UserID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetNotificationWarehouse");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Department_ID", Department_ID));
                cmd.Parameters.Add(new SqlParameter("@Zone_ID", Zone_ID));
                cmd.Parameters.Add(new SqlParameter("@Area_ID", Area_ID));
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetNotification", ex);
            }
            return dtResult;
        }

        public DataTable GetNotificationAccept(int ProductBrand_ID, int Department_ID, int Zone_ID, int Area_ID, string UserID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetNotificationAccept");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Department_ID", Department_ID));
                cmd.Parameters.Add(new SqlParameter("@Zone_ID", Zone_ID));
                cmd.Parameters.Add(new SqlParameter("@Area_ID", Area_ID));
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetNotificationAccept", ex);
            }
            return dtResult;
        }

        public DataTable GetNotificationAcceptQL(string UserID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetNotificationAcceptQL");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetNotificationAccept", ex);
            }
            return dtResult;
        }
        public DataTable GetNotificationExport(int ProductBrand_ID, int Department_ID, int Zone_ID, int Area_ID, string UserID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetNotificationExport");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Department_ID", Department_ID));
                cmd.Parameters.Add(new SqlParameter("@Zone_ID", Zone_ID));
                cmd.Parameters.Add(new SqlParameter("@Area_ID", Area_ID));
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetNotificationExport", ex);
            }
            return dtResult;
        }
        public DataTable GetNotificationGiamSat(int ProductBrand_ID, int Department_ID, int Zone_ID, int Area_ID, string UserID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetNotificationGiamSat");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Department_ID", Department_ID));
                cmd.Parameters.Add(new SqlParameter("@Zone_ID", Zone_ID));
                cmd.Parameters.Add(new SqlParameter("@Area_ID", Area_ID));
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetNotificationGiamSat", ex);
            }
            return dtResult;
        }
        public DataTable GetNotificationQLVung(int ProductBrand_ID, int Department_ID, int Zone_ID, int Area_ID, string UserID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetNotificationQLVung");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Department_ID", Department_ID));
                cmd.Parameters.Add(new SqlParameter("@Zone_ID", Zone_ID));
                cmd.Parameters.Add(new SqlParameter("@Area_ID", Area_ID));
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetNotificationGiamSat", ex);
            }
            return dtResult;
        }
        public DataTable QRCodeCountByRange(int QRCodePackage_ID, string SerialNumberStart, string SerialNumberEnd)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("QRCodeCountByRange");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SerialNumberStart", SerialNumberStart));
                cmd.Parameters.Add(new SqlParameter("@SerialNumberEnd", SerialNumberEnd));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodeCountByRange", ex);
            }
            return dtResult;
        }
        public DataTable QRCodeCountByRangeCancel(int QRCodePackage_ID, int QRCodeStatus_ID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("QRCodeCountByRangeCancel");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodeStatus_ID", QRCodeStatus_ID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodeCountByRangeCancel", ex);
            }
            return dtResult;
        }

        public DataTable GetQRCodeSerialNumCancel(int QRCodePackage_ID, int QRCodeStatus_ID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetQRCodeSerialNumCancel");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodeStatus_ID", QRCodeStatus_ID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetQRCodeSerialNumCancel", ex);
            }
            return dtResult;
        }

        public DataTable spGetQRCodeReport(int ProductBrand_ID, int product_ID, int QRCodeStatus_ID, int QRCodePackageType_ID, DateTime FromDate, DateTime ToDate)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetQRCodeReport");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@product_ID", product_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodeStatus_ID", QRCodeStatus_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackageType_ID", QRCodePackageType_ID));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("spGetQRCodeReport", ex);
            }
            return dtResult;
        }

        public void QRCodePackageUpdateSerialNumber(string QRCodePackage_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePackageUpdateSerialNumber", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePackageUpdateSerialNumber", ex);
            }
        }
        public void QRCodePackageUpdateSerialNumberES(string QRCodePackage_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePackageUpdateSerialNumberES", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePackageUpdateSerialNumber", ex);
            }
        }
        public void UpdatePromotionProduct(string ListProductID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdatePromotionProduct", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ListProductID", ListProductID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("UpdatePromotionProduct", ex);
            }
        }

        public void QRCodePublicCreate(int Number, int Length, int Product_ID, int QRCodePackage_ID, bool SoundEnable, Guid CreateBy, int ItemCount)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePublicCreate", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@ItemCount", ItemCount));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePublicCreate", ex);
            }
        }
        public void QRCodePublicCreate_V2(int Number, int Length, int Product_ID, int QRCodePackage_ID, bool SoundEnable, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePublicCreate_V2", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePublicCreate_V2", ex);
            }
        }
        public void QRCodePublicCreate_V2ES(int Number, int Length, int Product_ID, int QRCodePackage_ID, bool SoundEnable, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePublicCreate_V2ES", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePublicCreate_V2", ex);
            }
        }
        public void QRCodePublicAnonymousCreate(int Number, int Length, int Product_ID, int ProductBrand_ID, int QRCodePackage_ID, bool SoundEnable, Guid CreateBy, int ItemCount)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePublicAnonymousCreate", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@ItemCount", ItemCount));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePublicAnonymousCreate", ex);
            }
        }
        public void QRCodePublicAnonymousCreate_V2(int Number, int Length, int Product_ID, int ProductBrand_ID, int QRCodePackage_ID, bool SoundEnable, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePublicAnonymousCreate_V2", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePublicAnonymousCreate_V2", ex);
            }
        }
        public void QRCodePublicAnonymousCreate_V2ES(int Number, int Length, int Product_ID, int ProductBrand_ID, int QRCodePackage_ID, bool SoundEnable, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePublicAnonymousCreate_V2ES", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePublicAnonymousCreate_V2", ex);
            }
        }
        public void UpdateWarrantyDateProduct(int WarrantyDate, int ProductSet_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("UpdateWarrantyDateProduct", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@WarrantyDate", WarrantyDate));
                cmd.Parameters.Add(new SqlParameter("@ProductSet_ID", ProductSet_ID));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("UpdateWarrantyDateProduct", ex);
            }
        }
        public void QRCodeSecretCreate(int Number, int Length, int Product_ID, int QRCodePackage_ID, bool SoundEnable, bool SMSEnable, Guid CreateBy, int ItemCount)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodeSecretCreate", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@SMSEnable", SMSEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@ItemCount", ItemCount));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodeSecretCreate", ex);
            }
        }
        public void QRCodeSecretCreate_V2(int Number, int Length, int Product_ID, int QRCodePackage_ID, bool SoundEnable, bool SMSEnable, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodeSecretCreate_V2", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@SMSEnable", SMSEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodeSecretCreate_V2", ex);
            }
        }
        public void QRCodeSecretCreate_V2ES(int Number, int Length, int Product_ID, int QRCodePackage_ID, bool SoundEnable, bool SMSEnable, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodeSecretCreate_V2ES", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@SMSEnable", SMSEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodeSecretCreate_V2", ex);
            }
        }
        public void QRCodeSecretCreate_V3(int Number, int Length, int Product_ID, int ProductPartDetailID, int QRCodeWarehouse_ID, string PartDetail,string Standard, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodeWarehouseSecretCreate", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductPartDetailID", ProductPartDetailID));
                cmd.Parameters.Add(new SqlParameter("@QRCodeWarehouse_ID", QRCodeWarehouse_ID));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@PartDetail", PartDetail));
                cmd.Parameters.Add(new SqlParameter("@ProductStandard", Standard));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodeSecretCreate_V3", ex);
            }
        }
        public int ProductPartDetail_Save(int Product_ID, int ProductPartNumber, string ProductPartDetail, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("ProductPartDetail_Save", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductPartNumber", ProductPartNumber));
                cmd.Parameters.Add(new SqlParameter("@ProductPartDetail", ProductPartDetail));
                cmd.Parameters.Add(new SqlParameter("@CreatedUser", CreateBy));
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("ProductPartDetail_Save", ex);
            }
        }
        public void WarehouseTempPro_CreatePublicQRCode(int Number, int Length, string Product_Sku, int WarehouseTempPro_ID, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseTempPro_CreatePublicQRCode", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_Sku", Product_Sku));
                cmd.Parameters.Add(new SqlParameter("@WarehouseTempPro_ID", WarehouseTempPro_ID));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("WarehouseTempPro_CreatePublicQRCode", ex);
            }
        }

        public void QRCodeSecretAnonymousCreate(int Number, int Length, int Product_ID, int ProductBrand_ID, int QRCodePackage_ID, bool SoundEnable, bool SMSEnable, Guid CreateBy, int ItemCount)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodeSecretAnonymousCreate", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@SMSEnable", SMSEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@ItemCount", ItemCount));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodeSecretAnonymousCreate", ex);
            }
        }
        public void QRCodeSecretAnonymousCreate_V2(int Number, int Length, int Product_ID, int ProductBrand_ID, int QRCodePackage_ID, bool SoundEnable, bool SMSEnable, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodeSecretAnonymousCreate_V2", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@SMSEnable", SMSEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodeSecretAnonymousCreate_V2", ex);
            }
        }
        public void QRCodeSecretAnonymousCreate_V2ES(int Number, int Length, int Product_ID, int ProductBrand_ID, int QRCodePackage_ID, bool SoundEnable, bool SMSEnable, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodeSecretAnonymousCreate_V2ES", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@Number", Number));
                cmd.Parameters.Add(new SqlParameter("@Length", Length));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@SMSEnable", SMSEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodeSecretAnonymousCreate_V2", ex);
            }
        }
        public void QRCodePublicSplit(int Number, string SerialNumberStart, string SerialNumberEnd, string SerialNumberList, int Product_ID, int QRCodePackageSource_ID, int QRCodePackage_ID, int QRCodeSplitType, int ItemCount)
        {
            //try
            //{
            //    IDbCommand cmd = _db.CreateCommand("QRCodePublicSplit", CommandType.StoredProcedure);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandTimeout = 500;
            //    cmd.Parameters.Add(new SqlParameter("@Number", Number));
            //    cmd.Parameters.Add(new SqlParameter("@SerialNumberStart", SerialNumberStart));
            //    cmd.Parameters.Add(new SqlParameter("@SerialNumberEnd", SerialNumberEnd));
            //    cmd.Parameters.Add(new SqlParameter("@SerialNumberList", SerialNumberList));
            //    cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
            //    cmd.Parameters.Add(new SqlParameter("@QRCodePackageSource_ID", QRCodePackageSource_ID));
            //    cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
            //    cmd.Parameters.Add(new SqlParameter("@QRCodeSplitType", QRCodeSplitType));
            //    cmd.Parameters.Add(new SqlParameter("@ItemCount", ItemCount));
            //    cmd.ExecuteScalar();
            //}
            //catch (Exception ex)
            //{
            //    throw new Exceptions.DatabaseException("QRCodePublicSplit", ex);
            //}
        }
        public void QRCodeSecretSplit(int Number, string SerialNumberStart, string SerialNumberEnd, string SerialNumberList, int Product_ID, int QRCodePackageSource_ID, int QRCodePackage_ID, int QRCodeSplitType, int ItemCount)
        {
            //try
            //{
            //    IDbCommand cmd = _db.CreateCommand("QRCodeSecretSplit", CommandType.StoredProcedure);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandTimeout = 500;
            //    cmd.Parameters.Add(new SqlParameter("@Number", Number));
            //    cmd.Parameters.Add(new SqlParameter("@SerialNumberStart", SerialNumberStart));
            //    cmd.Parameters.Add(new SqlParameter("@SerialNumberEnd", SerialNumberEnd));
            //    cmd.Parameters.Add(new SqlParameter("@SerialNumberList", SerialNumberList));
            //    cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
            //    cmd.Parameters.Add(new SqlParameter("@QRCodePackageSource_ID", QRCodePackageSource_ID));
            //    cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
            //    cmd.Parameters.Add(new SqlParameter("@QRCodeSplitType", QRCodeSplitType));
            //    cmd.Parameters.Add(new SqlParameter("@ItemCount", ItemCount));
            //    cmd.ExecuteScalar();
            //}
            //catch (Exception ex)
            //{
            //    throw new Exceptions.DatabaseException("QRCodeSecretSplit", ex);
            //}
        }


        public void QRCodePackage_SetStatus(int QRCodePackage_ID, int QRCodeStatus_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePackage_SetStatus", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodeStatus_ID", QRCodeStatus_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePackage_SetStatus", ex);
            }
        }

        public void QRCodePackage_SetCancel(int QRCodePackage_ID, int QRCodeStatus_ID, string SerialNumberStart, string SerialNumberEnd)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePackage_SetCancel", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@QRCodeStatus_ID", QRCodeStatus_ID));
                cmd.Parameters.Add(new SqlParameter("@SerialNumberStart", SerialNumberStart));
                cmd.Parameters.Add(new SqlParameter("@SerialNumberEnd", SerialNumberEnd));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePackage_SetStatus", ex);
            }
        }

        public void QRCodePackage_FragmentCalculator(int QRCodePackage_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePackage_FragmentCalculator", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("InsertHistory_TaskType", ex);
            }
        }
        public void QRCodePackage_SetSoundEnable(int QRCodePackage_ID, bool SoundEnable)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePackage_SetSoundEnable", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePackage_SetSoundEnable", ex);
            }
        }
        public void InsertHistory_TaskType(int ProductPackage_ID, Guid CreateBy)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("InsertHistory_TaskType", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductPackage_ID", ProductPackage_ID));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("InsertHistory_TaskType", ex);
            }
        }

        public void QRCodePackage_Delete(int QRCodePackage_ID)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePackage_Delete", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@QRCodePackage_ID", QRCodePackage_ID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("InsertHistory_TaskType", ex);
            }
        }
        public void QRCodePublicPrimaryCreate(int Product_ID, bool SoundEnable, Guid CreateBy, string QRCodeContent)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodePublicPrimaryCreate", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                cmd.Parameters.Add(new SqlParameter("@SoundEnable", SoundEnable));
                cmd.Parameters.Add(new SqlParameter("@CreateBy", CreateBy));
                cmd.Parameters.Add(new SqlParameter("@QRCodeContent", QRCodeContent));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodePublicPrimaryCreate", ex);
            }
        }
        public void QRCodeUndoSplit(int QRCodePackageSource_ID, int ProductBrand_ID, int ItemCount)
        {
            try
            {
                IDbCommand cmd = _db.CreateCommand("QRCodeUndoSplit", CommandType.StoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@QRCodePackageSource_ID", QRCodePackageSource_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@ItemCount", ItemCount));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("QRCodeUndoSplit", ex);
            }
        }
        public DataTable GetReview(int ProductInfo_ID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetRewiew");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductInfo_ID", ProductInfo_ID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProductSearch", ex);
            }
            return dtResult;
        }
        public DataTable GetProductOther(int ProductBrand_ID, int Product_ID)
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetProductOther");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Product_ID", Product_ID));
                return Retrieve(cmd);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException("GetProductOther", ex);
            }
            return dtResult;
        }
        public DataSet GetNews_Paging(int currPage, int recodperpage, int Pagesize, string Title, int NewsCategory_ID, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetNews_Paging(int currPage, int recodperpage, int Pagesize, string Title, int NewsCategory_ID, string Where, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetNews_paging");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperPage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@Name", Title));
                cmd.Parameters.Add(new SqlParameter("@NewsCategory_ID", NewsCategory_ID));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet GetProduct_Paging1(int currPage, int recodperpage, int Pagesize, string Title, int Location_ID, int Region_ID, string Where, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetProduct_Paging1(int currPage, int recodperpage, int Pagesize, string Title, int Location_ID, int Region_ID, string Where, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetProduct_paging1");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperPage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@Name", Title));
                cmd.Parameters.Add(new SqlParameter("@Location_ID", Location_ID));
                cmd.Parameters.Add(new SqlParameter("@Region_ID", Region_ID));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }

        public DataSet GetRequestProductList_Paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Location_ID, int District_ID, int Rank_ID, int DepartmentMan_ID, int ProductChange_Status, DateTime FromDate, DateTime ToDate)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetRequestList_Paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Location_ID, int District_ID, int Rank_ID, int ProductChange_Status)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetRequestChangeInfoProduct");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperPage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Location_ID", Location_ID));
                cmd.Parameters.Add(new SqlParameter("@District_ID", District_ID));
                cmd.Parameters.Add(new SqlParameter("@Rank_ID", Rank_ID));
                cmd.Parameters.Add(new SqlParameter("@DepartmentMan_ID", DepartmentMan_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductChange_Status", ProductChange_Status));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet GetRequestProductBrandList_Paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Location_ID, int District_ID, int Rank_ID, int DepartmentMan_ID, int ProductBrandChange_Status, DateTime FromDate, DateTime ToDate)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = "GetRequestProductBrandList_Paging(int currPage, int recodperpage, int Pagesize, int ProductBrand_ID, int Location_ID, int District_ID, int Rank_ID, int ProductChange_Status)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetRequestChangeInfoProductBrand");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currentPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperPage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductBrand_ID", ProductBrand_ID));
                cmd.Parameters.Add(new SqlParameter("@Location_ID", Location_ID));
                cmd.Parameters.Add(new SqlParameter("@District_ID", District_ID));
                cmd.Parameters.Add(new SqlParameter("@Rank_ID", Rank_ID));
                cmd.Parameters.Add(new SqlParameter("@DepartmentMan_ID", DepartmentMan_ID));
                cmd.Parameters.Add(new SqlParameter("@ProductBrandChange_Status", ProductBrandChange_Status));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        public DataSet GetProductBrand_Paging1(int currPage, int recodperpage, int Pagesize, int ProductBrandType_ID_List, string Name, int FunctionGroup_ID, int Location_ID, DateTime FromDate, DateTime ToDate, string orderby)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = " GetProductBrand_Paging1(int currPage, int recodperpage, int Pagesize, int ProductBrandType_ID_List,string Name, int FunctionGroup_ID, int Location_ID, DateTime FromDate, DateTime ToDate, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetProductBrand_paging1");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductBrandType_ID_List", ProductBrandType_ID_List));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@FunctionGroup_ID", FunctionGroup_ID));
                cmd.Parameters.Add(new SqlParameter("@Location_ID", Location_ID));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }

        public DataSet GetProductBrand_PagingV2(int currPage, int recodperpage, int Pagesize, int ProductBrandType_ID_List, string Name, int FunctionGroup_ID, int Location_ID, DateTime FromDate, DateTime ToDate, string orderby, string SalesID)
        {
            DataSet dtResult = new DataSet();
            string LOCATION = " GetProductBrand_Paging1(int currPage, int recodperpage, int Pagesize, int ProductBrandType_ID_List,string Name, int FunctionGroup_ID, int Location_ID, DateTime FromDate, DateTime ToDate, string orderby)";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("spGetProductBrand_pagingV2");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@currPage", currPage));
                cmd.Parameters.Add(new SqlParameter("@recodperpage", recodperpage));
                cmd.Parameters.Add(new SqlParameter("@Pagesize", Pagesize));
                cmd.Parameters.Add(new SqlParameter("@ProductBrandType_ID_List", ProductBrandType_ID_List));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@FunctionGroup_ID", FunctionGroup_ID));
                cmd.Parameters.Add(new SqlParameter("@Location_ID", Location_ID));
                cmd.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                cmd.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                cmd.Parameters.Add(new SqlParameter("@orderby", orderby));
                cmd.Parameters.Add(new SqlParameter("@SalesID", SalesID));
                return Retrieve(cmd).DataSet;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            return dtResult;
        }
        ~Conllection()
        {
        }

    }
}

