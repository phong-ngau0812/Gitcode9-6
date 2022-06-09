using DbObj;
using System;
using System.Data;


public class DataAccessLocator
        : Base.DataAccessLocatorBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataAccessLocator"/> 
    /// class and opens the database connection.
    /// </summary>
    public DataAccessLocator()
        : base()
    {
    }
    public static DbObj.WarehouseRackCollection GetWarehouseRackCollection()
    {
        return new DbObj.WarehouseRackCollection();
    }
    public static DbObj.WarehouseSlotActionCollection GetWarehouseSlotActionCollection()
    {
        return new DbObj.WarehouseSlotActionCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>SerialRange</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SerialRangeCollection"/> object.</value>
    //public static DbObj.SerialRangeCollection GetSerialRangeCollection()
    //{
    //    return new DbObj.SerialRangeCollection();
    //}
    /// <summary>
    /// Gets an object that represents the <c>WarehouseSlot</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WarehouseSlotCollection"/> object.</value>
    public static DbObj.WarehouseSlotCollection GetWarehouseSlotCollection()
    {
        return new DbObj.WarehouseSlotCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WarehouseSlot</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WarehouseSlotCollection"/> object.</value>
    public static DbObj.ProductStandardCollection GetProductStandardCollection()
    {
        return new DbObj.ProductStandardCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WarehouseSlotInfor</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WarehouseSlotInforCollection"/> object.</value>
    public static DbObj.WarehouseSlotInforCollection GetWarehouseSlotInforCollection()
    {
        return new DbObj.WarehouseSlotInforCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>Conllection</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="Conllection"/> object.</value>
    public static DbObj.Conllection Conllection()
    {
        return new DbObj.Conllection();
    }
    // Table fields
    /// <summary>
    /// Gets an object that represents the <c>ActiveLink</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ActiveLinkCollection"/> object.</value>
    public static DbObj.ActiveLinkCollection GetActiveLinkCollection()
    {
        return new DbObj.ActiveLinkCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Area</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="AreaCollection"/> object.</value>
    public static DbObj.AreaCollection GetAreaCollection()
    {
        return new DbObj.AreaCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Contact</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ContactCollection"/> object.</value>
    public static DbObj.ContactCollection GetContactCollection()
    {
        return new DbObj.ContactCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Country</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="CountryCollection"/> object.</value>
    public static DbObj.CountryCollection GetCountryCollection()
    {
        return new DbObj.CountryCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Customer</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="CustomerCollection"/> object.</value>
    public static DbObj.CustomerCollection GetCustomerCollection()
    {
        return new DbObj.CustomerCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Department</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="DepartmentCollection"/> object.</value>
    public static DbObj.DepartmentCollection GetDepartmentCollection()
    {
        return new DbObj.DepartmentCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>DepartmentMan</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="DepartmentManCollection"/> object.</value>
    public static DbObj.DepartmentManCollection GetDepartmentManCollection()
    {
        return new DbObj.DepartmentManCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>EmailTemplate</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="EmailTemplateCollection"/> object.</value>
    public static DbObj.EmailTemplateCollection GetEmailTemplateCollection()
    {
        return new DbObj.EmailTemplateCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Farm</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="FarmCollection"/> object.</value>
    public static DbObj.FarmCollection GetFarmCollection()
    {
        return new DbObj.FarmCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>FarmGroup</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="FarmGroupCollection"/> object.</value>
    public static DbObj.FarmGroupCollection GetFarmGroupCollection()
    {
        return new DbObj.FarmGroupCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>FarmGroupInter</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="FarmGroupInterCollection"/> object.</value>
    public static DbObj.FarmGroupInterCollection GetFarmGroupInterCollection()
    {
        return new DbObj.FarmGroupInterCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>FarmStatus</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="FarmStatusCollection"/> object.</value>
    public static DbObj.FarmStatusCollection GetFarmStatusCollection()
    {
        return new DbObj.FarmStatusCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>FCMClient</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="FCMClientCollection"/> object.</value>
    public static DbObj.FCMClientCollection GetFCMClientCollection()
    {
        return new DbObj.FCMClientCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>FCMForm</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="FCMFormCollection"/> object.</value>
    public static DbObj.FCMFormCollection GetFCMFormCollection()
    {
        return new DbObj.FCMFormCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>FCMMessage</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="FCMMessageCollection"/> object.</value>
    public static DbObj.FCMMessageCollection GetFCMMessageCollection()
    {
        return new DbObj.FCMMessageCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>FCMMessageForTokken</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="FCMMessageForTokkenCollection"/> object.</value>
    public static DbObj.FCMMessageForTokkenCollection GetFCMMessageForTokkenCollection()
    {
        return new DbObj.FCMMessageForTokkenCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Language</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="LanguageCollection"/> object.</value>
    public static DbObj.LanguageCollection GetLanguageCollection()
    {
        return new DbObj.LanguageCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Location</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="LocationCollection"/> object.</value>
    public static DbObj.LocationCollection GetLocationCollection()
    {
        return new DbObj.LocationCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>LogHandler</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="LogHandlerCollection"/> object.</value>
    public static DbObj.LogHandlerCollection GetLogHandlerCollection()
    {
        return new DbObj.LogHandlerCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Material</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="MaterialCollection"/> object.</value>
    public static DbObj.MaterialCollection GetMaterialCollection()
    {
        return new DbObj.MaterialCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Menu</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="MenuCollection"/> object.</value>
    public static DbObj.MenuCollection GetMenuCollection()
    {
        return new DbObj.MenuCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Product</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductCollection"/> object.</value>
    public static DbObj.ProductCollection GetProductCollection()
    {
        return new DbObj.ProductCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductBrand</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductBrandCollection"/> object.</value>
    public static DbObj.ProductBrandCollection GetProductBrandCollection()
    {
        return new DbObj.ProductBrandCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductBrandType</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductBrandTypeCollection"/> object.</value>
    public static DbObj.ProductBrandTypeCollection GetProductBrandTypeCollection()
    {
        return new DbObj.ProductBrandTypeCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductCategory</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductCategoryCollection"/> object.</value>
    public static DbObj.ProductCategoryCollection GetProductCategoryCollection()
    {
        return new DbObj.ProductCategoryCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductItem</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductItemCollection"/> object.</value>
    public static DbObj.ProductItemCollection GetProductItemCollection()
    {
        return new DbObj.ProductItemCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductPackage</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductPackageCollection"/> object.</value>
    public static DbObj.ProductPackageCollection GetProductPackageCollection()
    {
        return new DbObj.ProductPackageCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductPackageOrder</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductPackageOrderCollection"/> object.</value>
    public static DbObj.ProductPackageOrderCollection GetProductPackageOrderCollection()
    {
        return new DbObj.ProductPackageOrderCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductPackageOrderMaterialRule</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductPackageOrderMaterialRuleCollection"/> object.</value>
    public static DbObj.ProductPackageOrderMaterialRuleCollection GetProductPackageOrderMaterialRuleCollection()
    {
        return new DbObj.ProductPackageOrderMaterialRuleCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductPackageOrderStatus</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductPackageOrderStatusCollection"/> object.</value>
    public static DbObj.ProductPackageOrderStatusCollection GetProductPackageOrderStatusCollection()
    {
        return new DbObj.ProductPackageOrderStatusCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>ProductPackageStatus</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductPackageStatusCollection"/> object.</value>
    public static DbObj.ProductPackageStatusCollection GetProductPackageStatusCollection()
    {
        return new DbObj.ProductPackageStatusCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductPicture</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductPictureCollection"/> object.</value>
    public static DbObj.ProductPictureCollection GetProductPictureCollection()
    {
        return new DbObj.ProductPictureCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductType</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductTypeCollection"/> object.</value>
    public static DbObj.ProductTypeCollection GetProductTypeCollection()
    {
        return new DbObj.ProductTypeCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Quality</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QualityCollection"/> object.</value>
    public static DbObj.QualityCollection GetQualityCollection()
    {
        return new DbObj.QualityCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ReplaceChar</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ReplaceCharCollection"/> object.</value>
    public static DbObj.ReplaceCharCollection GetReplaceCharCollection()
    {
        return new DbObj.ReplaceCharCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Setting</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SettingCollection"/> object.</value>
    public static DbObj.SettingCollection GetSettingCollection()
    {
        return new DbObj.SettingCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Sitemap</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SitemapCollection"/> object.</value>
    public static DbObj.SitemapCollection GetSitemapCollection()
    {
        return new DbObj.SitemapCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Skin</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SkinCollection"/> object.</value>
    public static DbObj.SkinCollection GetSkinCollection()
    {
        return new DbObj.SkinCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>SlideShow</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SlideShowCollection"/> object.</value>
    public static DbObj.SlideShowCollection GetSlideShowCollection()
    {
        return new DbObj.SlideShowCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>SMSMessage</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SMSMessageCollection"/> object.</value>
    public static DbObj.SMSMessageCollection GetSMSMessageCollection()
    {
        return new DbObj.SMSMessageCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>SMSMessageDraft</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SMSMessageDraftCollection"/> object.</value>
    public static DbObj.SMSMessageDraftCollection GetSMSMessageDraftCollection()
    {
        return new DbObj.SMSMessageDraftCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Store</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="StoreCollection"/> object.</value>
    public static DbObj.StoreCollection GetStoreCollection()
    {
        return new DbObj.StoreCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>SysLog</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SysLogCollection"/> object.</value>
    public static DbObj.SysLogCollection GetSysLogCollection()
    {
        return new DbObj.SysLogCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Tag</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TagCollection"/> object.</value>
    public static DbObj.TagCollection GetTagCollection()
    {
        return new DbObj.TagCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>TagMap</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TagMapCollection"/> object.</value>
    public static DbObj.TagMapCollection GetTagMapCollection()
    {
        return new DbObj.TagMapCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>TagType</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TagTypeCollection"/> object.</value>
    public static DbObj.TagTypeCollection GetTagTypeCollection()
    {
        return new DbObj.TagTypeCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Task</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TaskCollection"/> object.</value>
    public static DbObj.TaskCollection GetTaskCollection()
    {
        return new DbObj.TaskCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>TaskStatus</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TaskStatusCollection"/> object.</value>
    public static DbObj.TaskStatusCollection GetTaskStatusCollection()
    {
        return new DbObj.TaskStatusCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>TaskStep</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TaskStepCollection"/> object.</value>
    public static DbObj.TaskStepCollection GetTaskStepCollection()
    {
        return new DbObj.TaskStepCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>TaskType</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TaskTypeCollection"/> object.</value>
    public static DbObj.TaskTypeCollection GetTaskTypeCollection()
    {
        return new DbObj.TaskTypeCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>UserNotify</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="UserNotifyCollection"/> object.</value>
    public static DbObj.UserNotifyCollection GetUserNotifyCollection()
    {
        return new DbObj.UserNotifyCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>WarehouseTempPro</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WarehouseTempProCollection"/> object.</value>
    public static DbObj.WarehouseTempProCollection GetWarehouseTempProCollection()
    {
        return new DbObj.WarehouseTempProCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Warehouse</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WarehouseCollection"/> object.</value>
    public static DbObj.WarehouseCollection GetWarehouseCollection()
    {
        return new DbObj.WarehouseCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>WarehouseExport</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WarehouseExportCollection"/> object.</value>
    public static DbObj.WarehouseExportCollection GetWarehouseExportCollection()
    {
        return new DbObj.WarehouseExportCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>WarehouseImport</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WarehouseImportCollection"/> object.</value>
    public static DbObj.WarehouseImportCollection GetWarehouseImportCollection()
    {
        return new DbObj.WarehouseImportCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WarehouseImportNote</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WarehouseImportNoteCollection"/> object.</value>
    public static DbObj.WarehouseImportNoteCollection GetWarehouseImportNoteCollection()
    {
        return new DbObj.WarehouseImportNoteCollection();
    }
    public static DbObj.WarehouseExportNoteCollection GetWarehouseExportNoteCollection()
    {
        return new DbObj.WarehouseExportNoteCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WarehouseImportNoteDetail</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WarehouseImportNoteDetailCollection"/> object.</value>
    public static DbObj.WarehouseImportNoteDetailCollection GetWarehouseImportNoteDetailCollection()
    {
        return new DbObj.WarehouseImportNoteDetailCollection();
    }
    public static DbObj.WarehouseExportNoteDetailCollection GetWarehouseExportNoteDetailCollection()
    {
        return new DbObj.WarehouseExportNoteDetailCollection();
    }
    public static DbObj.WarehouseExportNoteDetailSlotCollection GetWarehouseExportNoteDetailSlotCollection()
    {
        return new DbObj.WarehouseExportNoteDetailSlotCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Workshop</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WorkshopCollection"/> object.</value>
    public static DbObj.WorkshopCollection GetWorkshopCollection()
    {
        return new DbObj.WorkshopCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>Zone</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ZoneCollection"/> object.</value>
    public static DbObj.ZoneCollection GetZoneCollection()
    {
        return new DbObj.ZoneCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>Branch</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BranchCollection"/> object.</value>
    public static DbObj.BranchCollection GetBranchCollection()
    {
        return new DbObj.BranchCollection();
    }


    /// <summary>
    /// Gets an object that represents the <c>CustomerType</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="CustomerTypeCollection"/> object.</value>
    public static DbObj.CustomerTypeCollection GetCustomerTypeCollection()
    {
        return new DbObj.CustomerTypeCollection();
    }


    /// <summary>
    /// Gets an object that represents the <c>Discount</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="DiscountCollection"/> object.</value>
    public static DbObj.DiscountCollection GetDiscountCollection()
    {
        return new DbObj.DiscountCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Function</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="FunctionCollection"/> object.</value>
    public static DbObj.FunctionCollection GetFunctionCollection()
    {
        return new DbObj.FunctionCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>FunctionGroup</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="FunctionGroupCollection"/> object.</value>
    public static DbObj.FunctionGroupCollection GetFunctionGroupCollection()
    {
        return new DbObj.FunctionGroupCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>FunctionGroupMenu</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="FunctionGroupMenuCollection"/> object.</value>
    public static DbObj.FunctionGroupMenuCollection GetFunctionGroupMenuCollection()
    {
        return new DbObj.FunctionGroupMenuCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>MaterialCategory</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="MaterialCategoryCollection"/> object.</value>
    public static DbObj.MaterialCategoryCollection GetMaterialCategoryCollection()
    {
        return new DbObj.MaterialCategoryCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>MaterialPrice</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="MaterialPriceCollection"/> object.</value>
    public static DbObj.MaterialPriceCollection GetMaterialPriceCollection()
    {
        return new DbObj.MaterialPriceCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Ministry</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="MinistryCollection"/> object.</value>
    public static DbObj.MinistryCollection GetMinistryCollection()
    {
        return new DbObj.MinistryCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Notification</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="NotificationCollection"/> object.</value>
    public static DbObj.NotificationCollection GetNotificationCollection()
    {
        return new DbObj.NotificationCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>NotificationType</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="NotificationTypeCollection"/> object.</value>
    public static DbObj.NotificationTypeCollection GetNotificationTypeCollection()
    {
        return new DbObj.NotificationTypeCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>PageFunction</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="PageFunctionCollection"/> object.</value>
    public static DbObj.PageFunctionCollection GetPageFunctionCollection()
    {
        return new DbObj.PageFunctionCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>ProductPackageOrderCategory</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductPackageOrderCategoryCollection"/> object.</value>
    public static DbObj.ProductPackageOrderCategoryCollection GetProductPackageOrderCategoryCollection()
    {
        return new DbObj.ProductPackageOrderCategoryCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductPackageOrderMaterial</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductPackageOrderMaterialCollection"/> object.</value>
    public static DbObj.ProductPackageOrderMaterialCollection GetProductPackageOrderMaterialCollection()
    {
        return new DbObj.ProductPackageOrderMaterialCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductPackageVsMaterial</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductPackageVsMaterialCollection"/> object.</value>
    public static DbObj.ProductPackageVsMaterialCollection GetProductPackageVsMaterialCollection()
    {
        return new DbObj.ProductPackageVsMaterialCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ReadNotification</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ReadNotificationCollection"/> object.</value>
    public static DbObj.ReadNotificationCollection GetReadNotificationCollection()
    {
        return new DbObj.ReadNotificationCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>StaffType</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="StaffTypeCollection"/> object.</value>
    public static DbObj.StaffTypeCollection GetStaffTypeCollection()
    {
        return new DbObj.StaffTypeCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Supplier</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SupplierCollection"/> object.</value>
    public static DbObj.SupplierCollection GetSupplierCollection()
    {
        return new DbObj.SupplierCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>SystemLog</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SystemLogCollection"/> object.</value>
    public static DbObj.SystemLogCollection GetSystemLogCollection()
    {
        return new DbObj.SystemLogCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>TaskStepVsProductPackage</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TaskStepVsProductPackageCollection"/> object.</value>
    public static DbObj.TaskStepVsProductPackageCollection GetTaskStepVsProductPackageCollection()
    {
        return new DbObj.TaskStepVsProductPackageCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Transporter</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TransporterCollection"/> object.</value>
    public static DbObj.TransporterCollection GetTransporterCollection()
    {
        return new DbObj.TransporterCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>UserVsPageFunction</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="UserVsPageFunctionCollection"/> object.</value>
    public static DbObj.UserVsPageFunctionCollection GetUserVsPageFunctionCollection()
    {
        return new DbObj.UserVsPageFunctionCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>WarehouseExportMaterial</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WarehouseExportMaterialCollection"/> object.</value>
    public static DbObj.WarehouseExportMaterialCollection GetWarehouseExportMaterialCollection()
    {
        return new DbObj.WarehouseExportMaterialCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>AccountType</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="AccountTypeCollection"/> object.</value>
    public static DbObj.AccountTypeCollection GetAccountTypeCollection()
    {
        return new DbObj.AccountTypeCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>UserVsProductBrand</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="UserVsProductBrandCollection"/> object.</value>
    public static DbObj.UserVsProductBrandCollection GetUserVsProductBrandCollection()
    {
        return new DbObj.UserVsProductBrandCollection();
    }

    public static DbObj.AgencyCollection GetAgencyCollection()
    {
        return new DbObj.AgencyCollection();
    }

    public static DbObj.TestingCertificatesCollection GetTestingCertificatesCollection()
    {
        return new DbObj.TestingCertificatesCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>District</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="DistrictCollection"/> object.</value>
    public static DbObj.DistrictCollection GetDistrictCollection()
    {
        return new DbObj.DistrictCollection();
    }


    /// <summary>
    /// Gets an object that represents the <c>Ward</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WardCollection"/> object.</value>
    public static DbObj.WardCollection GetWardCollection()
    {
        return new DbObj.WardCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>QRCodePackage</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodePackageCollection"/> object.</value>
    public static DbObj.QRCodePackageCollection GetQRCodePackageCollection()
    {
        return new DbObj.QRCodePackageCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodePublic</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodePublicCollection"/> object.</value>
    public static DbObj.QRCodePublicCollection GetQRCodePublicCollection()
    {
        return new DbObj.QRCodePublicCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodeSecret</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeSecretCollection"/> object.</value>
    public static DbObj.QRCodeSecretCollection GetQRCodeSecretCollection()
    {
        return new DbObj.QRCodeSecretCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>QRCodeWarehouse</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeWarehouseCollection"/> object.</value>
    public static DbObj.QRCodeWarehouseCollection QRCodeWarehouseCollection()
    {
        return new DbObj.QRCodeWarehouseCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodeWarehousePublic</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeWarehousePublicCollection"/> object.</value>
    public static DbObj.QRCodeWarehousePublicCollection GetQRCodeWarehousePublicCollection()
    {
        return new DbObj.QRCodeWarehousePublicCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodeWarehouseSecret</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeWarehouseSecretCollection"/> object.</value>
    public static DbObj.QRCodeWarehouseSecretCollection GetQRCodeWarehouseSecretCollection()
    {
        return new DbObj.QRCodeWarehouseSecretCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodeStatus</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeStatusCollection"/> object.</value>
    public static DbObj.QRCodeStatusCollection GetQRCodeStatusCollection()
    {
        return new DbObj.QRCodeStatusCollection();
    }
    public static DbObj.ProductPackageVsTaskTypeCollection GetProductPackageVsTaskTypeCollection()
    {
        return new DbObj.ProductPackageVsTaskTypeCollection();
    }   /// <summary>
        /// Gets an object that represents the <c>ProductPackageHistory</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="ProductPackageHistoryCollection"/> object.</value>
    public static DbObj.ProductPackageHistoryCollection GetProductPackageHistoryCollection()
    {
        return new DbObj.ProductPackageHistoryCollection();
    }

    // Table fields
    /// <summary>
    /// Gets an object that represents the <c>ChainLink</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ChainLinkCollection"/> object.</value>
    public static DbObj.ChainLinkCollection GetChainLinkCollection()
    {
        return new DbObj.ChainLinkCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>SalesInformation</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SalesInformationCollection"/> object.</value>
    public static DbObj.SalesInformationCollection GetSalesInformationCollection()
    {
        return new DbObj.SalesInformationCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>SalesInformationVsProduct</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SalesInformationVsProductCollection"/> object.</value>
    public static DbObj.SalesInformationVsProductCollection GetSalesInformationVsProductCollection()
    {
        return new DbObj.SalesInformationVsProductCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>SalesInformationVsProductPackage</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SalesInformationVsProductPackageCollection"/> object.</value>
    public static DbObj.SalesInformationVsProductPackageCollection GetSalesInformationVsProductPackageCollection()
    {
        return new DbObj.SalesInformationVsProductPackageCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>SalesShift</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SalesShiftCollection"/> object.</value>
    public static DbObj.SalesShiftCollection GetSalesShiftCollection()
    {
        return new DbObj.SalesShiftCollection();
    }

    // Table fields
    /// <summary>
    /// Gets an object that represents the <c>QRCodePackageVsProductPakage</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodePackageVsProductPakageCollection"/> object.</value>
    public static DbObj.QRCodePackageVsProductPakageCollection GetQRCodePackageVsProductPakageCollection()
    {
        return new DbObj.QRCodePackageVsProductPakageCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>QRCodeLocationRegister</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeLocationRegisterCollection"/> object.</value>
    public static DbObj.QRCodeLocationRegisterCollection GetQRCodeLocationRegisterCollection()
    {
        return new DbObj.QRCodeLocationRegisterCollection();
    }

    // Table fields
    /// <summary>
    /// Gets an object that represents the <c>QRCodeCustomerRegister</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeCustomerRegisterCollection"/> object.</value>
    public static DbObj.QRCodeCustomerRegisterCollection GetQRCodeCustomerRegisterCollection()
    {
        return new DbObj.QRCodeCustomerRegisterCollection();
    }

    // Table fields
    /// <summary>
    /// Gets an object that represents the <c>QRCodeWarehouseRegister</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeWarehouseRegisterCollection"/> object.</value>
    public static DbObj.QRCodeWarehouseRegisterCollection GetQRCodeWarehouseRegisterCollection()
    {
        return new DbObj.QRCodeWarehouseRegisterCollection();
    }

    // Table fields
    /// <summary>
    /// Gets an object that represents the <c>QRCodeWorkshopRegister</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeWorkshopRegisterCollection"/> object.</value>
    public static DbObj.QRCodeWorkshopRegisterCollection GetQRCodeWorkshopRegisterCollection()
    {
        return new DbObj.QRCodeWorkshopRegisterCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>ProductGallery</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductGalleryCollection"/> object.</value>
    public static DbObj.ProductGalleryCollection GetProductGalleryCollection()
    {
        return new DbObj.ProductGalleryCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductInfo</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductInfoCollection"/> object.</value>
    public static DbObj.ProductInfoCollection GetProductInfoCollection()
    {
        return new DbObj.ProductInfoCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductInfo</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductInfoCollection"/> object.</value>
    public static DbObj.ProductReviewCollection GetProductReviewCollection()
    {
        return new DbObj.ProductReviewCollection();
    }



    /// <summary>
    /// Gets an object that represents the <c>QRCodePackageRule</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodePackageRuleCollection"/> object.</value>
    public static DbObj.QRCodePackageRuleCollection GetQRCodePackageRuleCollection()
    {
        return new DbObj.QRCodePackageRuleCollection();
    }

    // Table fields
    /// <summary>
    /// Gets an object that represents the <c>TaskStepAnswer</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TaskStepAnswerCollection"/> object.</value>
    public static DbObj.TaskStepAnswerCollection GetTaskStepAnswerCollection()
    {
        return new DbObj.TaskStepAnswerCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>TaskStepQuestion</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TaskStepQuestionCollection"/> object.</value>
    public static DbObj.TaskStepQuestionCollection GetTaskStepQuestionCollection()
    {
        return new DbObj.TaskStepQuestionCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>BaoHiem</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BaoHiemCollection"/> object.</value>
    public static DbObj.BaoHiemCollection GetBaoHiemCollection()
    {
        return new DbObj.BaoHiemCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>BNN_Brand</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_BrandCollection"/> object.</value>
    public static DbObj.BNN_BrandCollection GetBNN_BrandCollection()
    {
        return new DbObj.BNN_BrandCollection();
    }


    /// <summary>
    /// Gets an object that represents the <c>BNN_Document</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_DocumentCollection"/> object.</value>
    public static DbObj.BNN_DocumentCollection GetBNN_DocumentCollection()
    {
        return new DbObj.BNN_DocumentCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_DocumentCategory</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_DocumentCategoryCollection"/> object.</value>
    public static DbObj.BNN_DocumentCategoryCollection GetBNN_DocumentCategoryCollection()
    {
        return new DbObj.BNN_DocumentCategoryCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_Feedback</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_FeedbackCollection"/> object.</value>
    public static DbObj.BNN_FeedbackCollection GetBNN_FeedbackCollection()
    {
        return new DbObj.BNN_FeedbackCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_News</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_NewsCollection"/> object.</value>
    public static DbObj.BNN_NewsCollection GetBNN_NewsCollection()
    {
        return new DbObj.BNN_NewsCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_NewsCategory</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_NewsCategoryCollection"/> object.</value>
    public static DbObj.BNN_NewsCategoryCollection GetBNN_NewsCategoryCollection()
    {
        return new DbObj.BNN_NewsCategoryCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_Quality</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_QualityCollection"/> object.</value>
    public static DbObj.BNN_QualityCollection GetBNN_QualityCollection()
    {
        return new DbObj.BNN_QualityCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_Banner</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_BannerCollection"/> object.</value>
    public static DbObj.BNN_BannerCollection GetBNN_BannerCollection()
    {
        return new DbObj.BNN_BannerCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_Config</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_ConfigCollection"/> object.</value>
    public static DbObj.BNN_ConfigCollection GetBNN_ConfigCollection()
    {
        return new DbObj.BNN_ConfigCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_Contact</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_ContactCollection"/> object.</value>
    public static DbObj.BNN_ContactCollection GetBNN_ContactCollection()
    {
        return new DbObj.BNN_ContactCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_Member</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_MemberCollection"/> object.</value>
    public static DbObj.BNN_MemberCollection GetBNN_MemberCollection()
    {
        return new DbObj.BNN_MemberCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_QA</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_QACollection"/> object.</value>
    public static DbObj.BNN_QACollection GetBNN_QACollection()
    {
        return new DbObj.BNN_QACollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_Video</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_VideoCollection"/> object.</value>
    public static DbObj.BNN_VideoCollection GetBNN_VideoCollection()
    {
        return new DbObj.BNN_VideoCollection();
    }
    public static DbObj.BNN_BackLinkCollection GetBNN_BackLinkCollection()
    {
        return new DbObj.BNN_BackLinkCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>BNN_Region</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_RegionCollection"/> object.</value>
    public static DbObj.BNN_RegionCollection GetBNN_RegionCollection()
    {
        return new DbObj.BNN_RegionCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_RegionVsLocation</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_RegionVsLocationCollection"/> object.</value>
    public static DbObj.BNN_RegionVsLocationCollection GetBNN_RegionVsLocationCollection()
    {
        return new DbObj.BNN_RegionVsLocationCollection();
    }
    /// <value>A reference to the <see cref="BNN_ProductCollection"/> object.</value>
    public static DbObj.BNN_ProductCollection GetBNN_ProductCollection()
    {
        return new DbObj.BNN_ProductCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>BNN_Country</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_CountryCollection"/> object.</value>
    public static DbObj.BNN_CountryCollection GetBNN_CountryCollection()
    {
        return new DbObj.BNN_CountryCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_CountryVsDocument</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_CountryVsDocumentCollection"/> object.</value>
    public static DbObj.BNN_CountryVsDocumentCollection GetBNN_CountryVsDocumentCollection()
    {
        return new DbObj.BNN_CountryVsDocumentCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>BusinessType</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BusinessTypeCollection"/> object.</value>
    public static DbObj.BusinessTypeCollection GetBusinessTypeCollection()
    {
        return new DbObj.BusinessTypeCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>ProductBrandChange</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductBrandChangeCollection"/> object.</value>
    public static DbObj.ProductBrandChangeCollection GetProductBrandChangeCollection()
    {
        return new DbObj.ProductBrandChangeCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductChange</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductChangeCollection"/> object.</value>
    public static DbObj.ProductChangeCollection GetProductChangeCollection()
    {
        return new DbObj.ProductChangeCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>Account_CheckVN</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="Account_CheckVNCollection"/> object.</value>
    public static DbObj.Account_CheckVNCollection GetAccount_CheckVNCollection()
    {
        return new DbObj.Account_CheckVNCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_NewsVsDocument</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_NewsVsDocumentCollection"/> object.</value>
    public static DbObj.BNN_NewsVsDocumentCollection GetBNN_NewsVsDocumentCollection()
    {
        return new DbObj.BNN_NewsVsDocumentCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>BNN_Order</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_OrderCollection"/> object.</value>
    public static DbObj.BNN_OrderCollection GetBNN_OrderCollection()
    {
        return new DbObj.BNN_OrderCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>BNN_OrderDetail</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="BNN_OrderDetailCollection"/> object.</value>
    public static DbObj.BNN_OrderDetailCollection GetBNN_OrderDetailCollection()
    {
        return new DbObj.BNN_OrderDetailCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>ProductColor</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductColorCollection"/> object.</value>
    public static DbObj.ProductColorCollection GetProductColorCollection()
    {
        return new DbObj.ProductColorCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>ProductSet</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductSetCollection"/> object.</value>
    public static DbObj.ProductSetCollection GetProductSetCollection()
    {
        return new DbObj.ProductSetCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>Region</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="RegionCollection"/> object.</value>
    public static DbObj.RegionCollection GetRegionCollection()
    {
        return new DbObj.RegionCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>ProductCategory_Web</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductCategory_WebCollection"/> object.</value>
    public static DbObj.ProductCategory_WebCollection GetProductCategory_WebCollection()
    {
        return new DbObj.ProductCategory_WebCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>ProductVsIcon</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductVsIconCollection"/> object.</value>
    public static DbObj.ProductVsIconCollection GetProductVsIconCollection()
    {
        return new DbObj.ProductVsIconCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WEB_Promotion</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WEB_PromotionCollection"/> object.</value>
    public static DbObj.WEB_PromotionCollection GetWEB_PromotionCollection()
    {
        return new DbObj.WEB_PromotionCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WEB_Space</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WEB_SpaceCollection"/> object.</value>
    public static DbObj.WEB_SpaceCollection GetWEB_SpaceCollection()
    {
        return new DbObj.WEB_SpaceCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>ProductClassify</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductClassifyCollection"/> object.</value>
    public static DbObj.ProductClassifyCollection GetProductClassifyCollection()
    {
        return new DbObj.ProductClassifyCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>Product_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="Product_ESCollection"/> object.</value>
    public static DbObj.Product_ESCollection GetProduct_ESCollection()
    {
        return new DbObj.Product_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodeLocationRegister_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeLocationRegister_ESCollection"/> object.</value>
    public static DbObj.QRCodeLocationRegister_ESCollection GetQRCodeLocationRegister_ESCollection()
    {
        return new DbObj.QRCodeLocationRegister_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodePackage_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodePackage_ESCollection"/> object.</value>
    public static DbObj.QRCodePackage_ESCollection GetQRCodePackage_ESCollection()
    {
        return new DbObj.QRCodePackage_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodePackageFragment_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodePackageFragment_ESCollection"/> object.</value>
    public static DbObj.QRCodePackageFragment_ESCollection GetQRCodePackageFragment_ESCollection()
    {
        return new DbObj.QRCodePackageFragment_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodePackageRule_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodePackageRule_ESCollection"/> object.</value>
    public static DbObj.QRCodePackageRule_ESCollection GetQRCodePackageRule_ESCollection()
    {
        return new DbObj.QRCodePackageRule_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodePackageVsProductPakage_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodePackageVsProductPakage_ESCollection"/> object.</value>
    public static DbObj.QRCodePackageVsProductPakage_ESCollection GetQRCodePackageVsProductPakage_ESCollection()
    {
        return new DbObj.QRCodePackageVsProductPakage_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodePublic_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodePublic_ESCollection"/> object.</value>
    public static DbObj.QRCodePublic_ESCollection GetQRCodePublic_ESCollection()
    {
        return new DbObj.QRCodePublic_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodeSecret_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeSecret_ESCollection"/> object.</value>
    public static DbObj.QRCodeSecret_ESCollection GetQRCodeSecret_ESCollection()
    {
        return new DbObj.QRCodeSecret_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodeStatus_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeStatus_ESCollection"/> object.</value>
    public static DbObj.QRCodeStatus_ESCollection GetQRCodeStatus_ESCollection()
    {
        return new DbObj.QRCodeStatus_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodeTracking_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeTracking_ESCollection"/> object.</value>
    public static DbObj.QRCodeTracking_ESCollection GetQRCodeTracking_ESCollection()
    {
        return new DbObj.QRCodeTracking_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodeWarehouseRegister_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeWarehouseRegister_ESCollection"/> object.</value>
    public static DbObj.QRCodeWarehouseRegister_ESCollection GetQRCodeWarehouseRegister_ESCollection()
    {
        return new DbObj.QRCodeWarehouseRegister_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>QRCodeWorkshopRegister_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="QRCodeWorkshopRegister_ESCollection"/> object.</value>
    public static DbObj.QRCodeWorkshopRegister_ESCollection GetQRCodeWorkshopRegister_ESCollection()
    {
        return new DbObj.QRCodeWorkshopRegister_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>Warehouse_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="Warehouse_ESCollection"/> object.</value>
    public static DbObj.Warehouse_ESCollection GetWarehouse_ESCollection()
    {
        return new DbObj.Warehouse_ESCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>ProductCategory_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductCategory_ESCollection"/> object.</value>
    public static DbObj.ProductCategory_ESCollection GetProductCategory_ESCollection()
    {
        return new DbObj.ProductCategory_ESCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>ProductGallery_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductGallery_ESCollection"/> object.</value>
    public static DbObj.ProductGallery_ESCollection GetProductGallery_ESCollection()
    {
        return new DbObj.ProductGallery_ESCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>ProductInfo_ES</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="ProductInfo_ESCollection"/> object.</value>
    public static DbObj.ProductInfo_ESCollection GetProductInfo_ESCollection()
    {
        return new DbObj.ProductInfo_ESCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WEB_PromotionVsProduct</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WEB_PromotionVsProductCollection"/> object.</value>
    public static DbObj.WEB_PromotionVsProductCollection GetWEB_PromotionVsProductCollection()
    {
        return new DbObj.WEB_PromotionVsProductCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WH_Material</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WH_MaterialCollection"/> object.</value>
    public static DbObj.WH_MaterialCollection GetWH_MaterialCollection()
    {
        return new DbObj.WH_MaterialCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>WH_MaterialCategory</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WH_MaterialCategoryCollection"/> object.</value>
    public static DbObj.WH_MaterialCategoryCollection GetWH_MaterialCategoryCollection()
    {
        return new DbObj.WH_MaterialCategoryCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WH_DeliveryNote</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WH_DeliveryNoteCollection"/> object.</value>
    public static DbObj.WH_DeliveryNoteCollection GetWH_DeliveryNoteCollection()
    {
        return new DbObj.WH_DeliveryNoteCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>WH_DeliveryNoteVsMaterial</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WH_DeliveryNoteVsMaterialCollection"/> object.</value>
    public static DbObj.WH_DeliveryNoteVsMaterialCollection GetWH_DeliveryNoteVsMaterialCollection()
    {
        return new DbObj.WH_DeliveryNoteVsMaterialCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WH_StandardCheck</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WH_StandardCheckCollection"/> object.</value>
    public static DbObj.WH_StandardCheckCollection GetWH_StandardCheckCollection()
    {
        return new DbObj.WH_StandardCheckCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>SamplingPlan</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="SamplingPlanCollection"/> object.</value>
    public static DbObj.SamplingPlanCollection GetSamplingPlanCollection()
    {
        return new DbObj.SamplingPlanCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WH_CheckSheet</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WH_CheckSheetCollection"/> object.</value>
    public static DbObj.WH_CheckSheetCollection GetWH_CheckSheetCollection()
    {
        return new DbObj.WH_CheckSheetCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>WH_CheckSheetVsMaterial</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WH_CheckSheetVsMaterialCollection"/> object.</value>
    public static DbObj.WH_CheckSheetVsMaterialCollection GetWH_CheckSheetVsMaterialCollection()
    {
        return new DbObj.WH_CheckSheetVsMaterialCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WH_CheckSheet_Detail</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WH_CheckSheet_DetailCollection"/> object.</value>
    public static DbObj.WH_CheckSheet_DetailCollection GetWH_CheckSheet_DetailCollection()
    {
        return new DbObj.WH_CheckSheet_DetailCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WH_Order</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WH_OrderCollection"/> object.</value>
    public static DbObj.WH_OrderCollection GetWH_OrderCollection()
    {
        return new DbObj.WH_OrderCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>WH_OrderVsProduct</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WH_OrderVsProductCollection"/> object.</value>
    public static DbObj.WH_OrderVsProductCollection GetWH_OrderVsProductCollection()
    {
        return new DbObj.WH_OrderVsProductCollection();
    }

    /// <summary>
    /// Gets an object that represents the <c>TestParameter</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="TestParameterCollection"/> object.</value>
    public static DbObj.TestParameterCollection GetTestParameterCollection()
    {
        return new DbObj.TestParameterCollection();
    }
    /// <summary>
    /// Gets an object that represents the <c>WH_MaterialVsTestParameter</c> table.
    /// </summary>
    /// <value>A reference to the <see cref="WH_MaterialVsTestParameterCollection"/> object.</value>
    public static DbObj.WH_MaterialVsTestParameterCollection GetWH_MaterialVsTestParameterCollection()
    {
        return new DbObj.WH_MaterialVsTestParameterCollection();
    }


}