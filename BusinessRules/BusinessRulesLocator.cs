using System;
using System.Data;
using DbObj;

public abstract class BusinessRulesLocator
{

    // Table fields
    // Conllection 
    public static Conllection Conllection()
    {
        return new Conllection();
    }
    public static ConllectionPDMan ConllectionPDMan()
    {
        return new ConllectionPDMan();
    }
    // Table fields
    // ActiveLinkBO 
    public static ActiveLinkBO GetActiveLinkBO()
    {
        return new ActiveLinkBO();
    }
    public static ProductStandardBO ProductStandardBO()
    {
        return new ProductStandardBO();
    }
    public static WarehouseSlotActionBO GetWarehouseSlotActionBO()
    {
        return new WarehouseSlotActionBO();
    }

    // AreaBO 
    public static AreaBO GetAreaBO()
    {
        return new AreaBO();
    }

    // ContactBO 
    public static ContactBO GetContactBO()
    {
        return new ContactBO();
    }

    // CountryBO 
    public static CountryBO GetCountryBO()
    {
        return new CountryBO();
    }

    // CustomerBO 
    public static CustomerBO GetCustomerBO()
    {
        return new CustomerBO();
    }

    // DepartmentBO 
    public static DepartmentBO GetDepartmentBO()
    {
        return new DepartmentBO();
    }

    // DepartmentManBO 
    public static DepartmentManBO GetDepartmentManBO()
    {
        return new DepartmentManBO();
    }

    // EmailTemplateBO 
    public static EmailTemplateBO GetEmailTemplateBO()
    {
        return new EmailTemplateBO();
    }

    // FarmBO 
    public static FarmBO GetFarmBO()
    {
        return new FarmBO();
    }

    // FarmGroupBO 
    public static FarmGroupBO GetFarmGroupBO()
    {
        return new FarmGroupBO();
    }

    // FarmGroupInterBO 
    public static FarmGroupInterBO GetFarmGroupInterBO()
    {
        return new FarmGroupInterBO();
    }

    // FarmStatusBO 
    public static FarmStatusBO GetFarmStatusBO()
    {
        return new FarmStatusBO();
    }

    // FCMClientBO 
    public static FCMClientBO GetFCMClientBO()
    {
        return new FCMClientBO();
    }

    // FCMFormBO 
    public static FCMFormBO GetFCMFormBO()
    {
        return new FCMFormBO();
    }



    // FCMMessageBO 
    public static FCMMessageBO GetFCMMessageBO()
    {
        return new FCMMessageBO();
    }
    // FCMMessageForTokkenBO 
    public static FCMMessageForTokkenBO GetFCMMessageForTokkenBO()
    {
        return new FCMMessageForTokkenBO();
    }

    // LanguageBO 
    public static LanguageBO GetLanguageBO()
    {
        return new LanguageBO();
    }

    // LocationBO 
    public static LocationBO GetLocationBO()
    {
        return new LocationBO();
    }

    // LogHandlerBO 
    public static LogHandlerBO GetLogHandlerBO()
    {
        return new LogHandlerBO();
    }

    // MaterialBO 
    public static MaterialBO GetMaterialBO()
    {
        return new MaterialBO();
    }

    // MenuBO 
    public static MenuBO GetMenuBO()
    {
        return new MenuBO();
    }

    // ProductBO 
    public static ProductBO GetProductBO()
    {
        return new ProductBO();
    }

    // ProductBrandBO 
    public static ProductBrandBO GetProductBrandBO()
    {
        return new ProductBrandBO();
    }

    // ProductBrandTypeBO 
    public static ProductBrandTypeBO GetProductBrandTypeBO()
    {
        return new ProductBrandTypeBO();
    }

    // ProductCategoryBO 
    public static ProductCategoryBO GetProductCategoryBO()
    {
        return new ProductCategoryBO();
    }

    // ProductItemBO 
    public static ProductItemBO GetProductItemBO()
    {
        return new ProductItemBO();
    }

    // ProductPackageBO 
    public static ProductPackageBO GetProductPackageBO()
    {
        return new ProductPackageBO();
    }

    // ProductPackageOrderBO 
    public static ProductPackageOrderBO GetProductPackageOrderBO()
    {
        return new ProductPackageOrderBO();
    }

    // ProductPackageOrderMaterialRuleBO 
    public static ProductPackageOrderMaterialRuleBO GetProductPackageOrderMaterialRuleBO()
    {
        return new ProductPackageOrderMaterialRuleBO();
    }

    // ProductPackageOrderStatusBO 
    public static ProductPackageOrderStatusBO GetProductPackageOrderStatusBO()
    {
        return new ProductPackageOrderStatusBO();
    }
    // ProductPackageStatusBO 
    public static ProductPackageStatusBO GetProductPackageStatusBO()
    {
        return new ProductPackageStatusBO();
    }

    // ProductPictureBO 
    public static ProductPictureBO GetProductPictureBO()
    {
        return new ProductPictureBO();
    }

    // ProductTypeBO 
    public static ProductTypeBO GetProductTypeBO()
    {
        return new ProductTypeBO();
    }

    // QualityBO 
    public static QualityBO GetQualityBO()
    {
        return new QualityBO();
    }

    // ReplaceCharBO 
    public static ReplaceCharBO GetReplaceCharBO()
    {
        return new ReplaceCharBO();
    }

    // SettingBO 
    public static SettingBO GetSettingBO()
    {
        return new SettingBO();
    }

    // SitemapBO 
    public static SitemapBO GetSitemapBO()
    {
        return new SitemapBO();
    }

    // SkinBO 
    public static SkinBO GetSkinBO()
    {
        return new SkinBO();
    }

    // SlideShowBO 
    public static SlideShowBO GetSlideShowBO()
    {
        return new SlideShowBO();
    }

    // SMSMessageBO 
    public static SMSMessageBO GetSMSMessageBO()
    {
        return new SMSMessageBO();
    }

    // SMSMessageDraftBO 
    public static SMSMessageDraftBO GetSMSMessageDraftBO()
    {
        return new SMSMessageDraftBO();
    }

    // StoreBO 
    public static StoreBO GetStoreBO()
    {
        return new StoreBO();
    }

    // SysLogBO 
    public static SysLogBO GetSysLogBO()
    {
        return new SysLogBO();
    }

    // TagBO 
    public static TagBO GetTagBO()
    {
        return new TagBO();
    }

    // TagMapBO 
    public static TagMapBO GetTagMapBO()
    {
        return new TagMapBO();
    }
    // TagTypeBO 
    public static TagTypeBO GetTagTypeBO()
    {
        return new TagTypeBO();
    }

    // TaskBO 
    public static TaskBO GetTaskBO()
    {
        return new TaskBO();
    }

    // TaskStatusBO 
    public static TaskStatusBO GetTaskStatusBO()
    {
        return new TaskStatusBO();
    }

    // TaskStepBO 
    public static TaskStepBO GetTaskStepBO()
    {
        return new TaskStepBO();
    }

    // TaskTypeBO 
    public static TaskTypeBO GetTaskTypeBO()
    {
        return new TaskTypeBO();
    }

    // UserNotifyBO 
    public static UserNotifyBO GetUserNotifyBO()
    {
        return new UserNotifyBO();
    }

    //public static SerialRangeBO GetSerialRangeBO()
    //{
    //	return new SerialRangeBO();
    //}
    // WarehouseBO 
    public static WarehouseBO GetWarehouseBO()
    {
        return new WarehouseBO();
    }

    // WarehouseExportBO 
    public static WarehouseExportBO GetWarehouseExportBO()
    {
        return new WarehouseExportBO();
    }

    // WarehouseImportBO 
    public static WarehouseImportBO GetWarehouseImportBO()
    {
        return new WarehouseImportBO();
    }
    // WarehouseImportNote 
    public static WarehouseImportNoteBO GetWarehouseImportNoteBO()
    {
        return new WarehouseImportNoteBO();
    }
    // WarehouseImportNoteDetail 
    public static WarehouseImportNoteDetailBO GetWarehouseImportNoteDetailBO()
    {
        return new WarehouseImportNoteDetailBO();
    }
    // WarehouseExportNote 
    public static WarehouseExportNoteBO GetWarehouseExportNoteBO()
    {
        return new WarehouseExportNoteBO();
    }
    // WarehouseExportNoteDetail 
    public static WarehouseExportNoteDetailBO GetWarehouseExportNoteDetailBO()
    {
        return new WarehouseExportNoteDetailBO();
    }
    // WarehouseExportNoteDetailSlot 
    public static WarehouseExportNoteDetailSlotBO GetWarehouseExportNoteDetailSlotBO()
    {
        return new WarehouseExportNoteDetailSlotBO();
    }
    // WarehouseRack 
    public static WarehouseRackBO GetWarehouseRackBO()
    {
        return new WarehouseRackBO();
    }
    // WarehouseSlot 
    public static WarehouseSlotBO GetWarehouseSlotBO()
    {
        return new WarehouseSlotBO();
    }
    // WarehouseSlotInfor 
    public static WarehouseSlotInforBO GetWarehouseSlotInforBO()
    {
        return new WarehouseSlotInforBO();
    }
    // WarehouseTempProBO 
    public static WarehouseTempProBO GetWarehouseTempProBO()
    {
        return new WarehouseTempProBO();
    }

    // WorkshopBO 
    public static WorkshopBO GetWorkshopBO()
    {
        return new WorkshopBO();
    }
    // ZoneBO 
    public static ZoneBO GetZoneBO()
    {
        return new ZoneBO();
    }
    // TaskTypeBO 
    // BranchBO 
    public static BranchBO GetBranchBO()
    {
        return new BranchBO();
    }


    // CustomerTypeBO 
    public static CustomerTypeBO GetCustomerTypeBO()
    {
        return new CustomerTypeBO();
    }


    // DiscountBO 
    public static DiscountBO GetDiscountBO()
    {
        return new DiscountBO();
    }

    // FunctionBO 
    public static FunctionBO GetFunctionBO()
    {
        return new FunctionBO();
    }

    // FunctionGroupBO 
    public static FunctionGroupBO GetFunctionGroupBO()
    {
        return new FunctionGroupBO();
    }

    // FunctionGroupMenuBO 
    public static FunctionGroupMenuBO GetFunctionGroupMenuBO()
    {
        return new FunctionGroupMenuBO();
    }

    // MaterialCategoryBO 
    public static MaterialCategoryBO GetMaterialCategoryBO()
    {
        return new MaterialCategoryBO();
    }

    // MaterialPriceBO 
    public static MaterialPriceBO GetMaterialPriceBO()
    {
        return new MaterialPriceBO();
    }

    // MinistryBO 
    public static MinistryBO GetMinistryBO()
    {
        return new MinistryBO();
    }

    // NotificationBO 
    public static NotificationBO GetNotificationBO()
    {
        return new NotificationBO();
    }

    // NotificationTypeBO 
    public static NotificationTypeBO GetNotificationTypeBO()
    {
        return new NotificationTypeBO();
    }

    // PageFunctionBO 
    public static PageFunctionBO GetPageFunctionBO()
    {
        return new PageFunctionBO();
    }
    // ProductPackageOrderCategoryBO 
    public static ProductPackageOrderCategoryBO GetProductPackageOrderCategoryBO()
    {
        return new ProductPackageOrderCategoryBO();
    }

    // ProductPackageOrderMaterialBO 
    public static ProductPackageOrderMaterialBO GetProductPackageOrderMaterialBO()
    {
        return new ProductPackageOrderMaterialBO();
    }

    // ProductPackageVsMaterialBO 
    public static ProductPackageVsMaterialBO GetProductPackageVsMaterialBO()
    {
        return new ProductPackageVsMaterialBO();
    }

    // ReadNotificationBO 
    public static ReadNotificationBO GetReadNotificationBO()
    {
        return new ReadNotificationBO();
    }

    // StaffTypeBO 
    public static StaffTypeBO GetStaffTypeBO()
    {
        return new StaffTypeBO();
    }

    // SupplierBO 
    public static SupplierBO GetSupplierBO()
    {
        return new SupplierBO();
    }

    // SystemLogBO 
    public static SystemLogBO GetSystemLogBO()
    {
        return new SystemLogBO();
    }

    // TaskStepVsProductPackageBO 
    public static TaskStepVsProductPackageBO GetTaskStepVsProductPackageBO()
    {
        return new TaskStepVsProductPackageBO();
    }

    // TransporterBO 
    public static TransporterBO GetTransporterBO()
    {
        return new TransporterBO();
    }

    // UserVsPageFunctionBO 
    public static UserVsPageFunctionBO GetUserVsPageFunctionBO()
    {
        return new UserVsPageFunctionBO();
    }

    // WarehouseExportMaterialBO 
    public static WarehouseExportMaterialBO GetWarehouseExportMaterialBO()
    {
        return new WarehouseExportMaterialBO();
    }
    // AccountTypeBO 
    public static AccountTypeBO GetAccountTypeBO()
    {
        return new AccountTypeBO();
    }
    // UserVsProductBrandBO 
    public static UserVsProductBrandBO GetUserVsProductBrandBO()
    {
        return new UserVsProductBrandBO();
    }
    // AgencyBO 
    public static AgencyBO GetAgencyBO()
    {
        return new AgencyBO();
    }
    // TestingCertificatesBO 
    public static TestingCertificatesBO GetTestingCertificatesBO()
    {
        return new TestingCertificatesBO();
    }
    // DistrictBO 
    public static DistrictBO GetDistrictBO()
    {
        return new DistrictBO();
    }

    // WardBO 
    public static WardBO GetWardBO()
    {
        return new WardBO();
    }
    // QRCodePackageBO 
    public static QRCodePackageBO GetQRCodePackageBO()
    {
        return new QRCodePackageBO();
    }

    // QRCodePublicBO 
    public static QRCodePublicBO GetQRCodePublicBO()
    {
        return new QRCodePublicBO();
    }

    // QRCodeSecretBO 
    public static QRCodeSecretBO GetQRCodeSecretBO()
    {
        return new QRCodeSecretBO();
    }

    // QRCodePackageBO 
    public static QRCodeWarehouseBO GetQRCodeWarehouseBO()
    {
        return new QRCodeWarehouseBO();
    }

    // QRCodePublicBO 
    public static QRCodeWarehousePublicBO GetQRCodeWarehousePublicBO()
    {
        return new QRCodeWarehousePublicBO();
    }

    // QRCodeSecretBO 
    public static QRCodeWarehouseSecretBO GetQRCodeWarehouseSecretBO()
    {
        return new QRCodeWarehouseSecretBO();
    }

    // QRCodeStatusBO 
    public static QRCodeStatusBO GetQRCodeStatusBO()
    {
        return new QRCodeStatusBO();
    }
    // ProductPackageVsTaskTypeBO 
    public static ProductPackageVsTaskTypeBO GetProductPackageVsTaskTypeBO()
    {
        return new ProductPackageVsTaskTypeBO();
    }   // ProductPackageHistoryBO 
    public static ProductPackageHistoryBO GetProductPackageHistoryBO()
    {
        return new ProductPackageHistoryBO();
    }

    public static ChainLinkBO GetChainLinkBO()
    {
        return new ChainLinkBO();
    }
    // SalesInformationBO 
    public static SalesInformationBO GetSalesInformationBO()
    {
        return new SalesInformationBO();
    }

    // SalesInformationVsProductBO 
    public static SalesInformationVsProductBO GetSalesInformationVsProductBO()
    {
        return new SalesInformationVsProductBO();
    }

    // SalesInformationVsProductPackageBO 
    public static SalesInformationVsProductPackageBO GetSalesInformationVsProductPackageBO()
    {
        return new SalesInformationVsProductPackageBO();
    }

    // SalesShiftBO 
    public static SalesShiftBO GetSalesShiftBO()
    {
        return new SalesShiftBO();
    }

    // QRCodePackageVsProductPakageBO 
    public static QRCodePackageVsProductPakageBO GetQRCodePackageVsProductPakageBO()
    {
        return new QRCodePackageVsProductPakageBO();
    }
    // QRCodeLocationRegisterBO 
    public static QRCodeLocationRegisterBO GetQRCodeLocationRegisterBO()
    {
        return new QRCodeLocationRegisterBO();
    }
    // Table fields
    // QRCodeCustomerRegisterBO 
    public static QRCodeCustomerRegisterBO GetQRCodeCustomerRegisterBO()
    {
        return new QRCodeCustomerRegisterBO();
    }

    public static QRCodeWarehouseRegisterBO GetQRCodeWarehouseRegisterBO()
    {
        return new QRCodeWarehouseRegisterBO();
    }

    // Table fields
    // QRCodeWorkshopRegisterBO 
    public static QRCodeWorkshopRegisterBO GetQRCodeWorkshopRegisterBO()
    {
        return new QRCodeWorkshopRegisterBO();
    }
    // ProductGalleryBO 
    public static ProductGalleryBO GetProductGalleryBO()
    {
        return new ProductGalleryBO();
    }

    // ProductInfoBO 
    public static ProductInfoBO GetProductInfoBO()
    {
        return new ProductInfoBO();
    }


    // ProductInfoBO 
    public static ProductReviewBO GetProductReviewBO()
    {
        return new ProductReviewBO();
    }


    // QRCodePackageRuleBO 
    public static QRCodePackageRuleBO GetQRCodePackageRuleBO()
    {
        return new QRCodePackageRuleBO();
    }

    // Table fields
    // TaskStepAnswerBO 
    public static TaskStepAnswerBO GetTaskStepAnswerBO()
    {
        return new TaskStepAnswerBO();
    }

    // TaskStepQuestionBO 
    public static TaskStepQuestionBO GetTaskStepQuestionBO()
    {
        return new TaskStepQuestionBO();
    }

    // BaoHiemBO 
    public static BaoHiemBO GetBaoHiemBO()
    {
        return new BaoHiemBO();
    }
    // BNN_BrandBO 
    public static BNN_BrandBO GetBNN_BrandBO()
    {
        return new BNN_BrandBO();
    }

    // BNN_ConfigBO 
    public static BNN_ConfigBO GetBNN_ConfigBO()
    {
        return new BNN_ConfigBO();
    }

    // BNN_DocumentBO 
    public static BNN_DocumentBO GetBNN_DocumentBO()
    {
        return new BNN_DocumentBO();
    }

    // BNN_DocumentCategoryBO 
    public static BNN_DocumentCategoryBO GetBNN_DocumentCategoryBO()
    {
        return new BNN_DocumentCategoryBO();
    }

    // BNN_FeedbackBO 
    public static BNN_FeedbackBO GetBNN_FeedbackBO()
    {
        return new BNN_FeedbackBO();
    }

    // BNN_NewsBO 
    public static BNN_NewsBO GetBNN_NewsBO()
    {
        return new BNN_NewsBO();
    }

    // BNN_NewsCategoryBO 
    public static BNN_NewsCategoryBO GetBNN_NewsCategoryBO()
    {
        return new BNN_NewsCategoryBO();
    }

    // BNN_QualityBO 
    public static BNN_QualityBO GetBNN_QualityBO()
    {
        return new BNN_QualityBO();
    }
    // BNN_BannerBO 
    public static BNN_BannerBO GetBNN_BannerBO()
    {
        return new BNN_BannerBO();
    }


    // BNN_ContactBO 
    public static BNN_ContactBO GetBNN_ContactBO()
    {
        return new BNN_ContactBO();
    }

    // BNN_MemberBO 
    public static BNN_MemberBO GetBNN_MemberBO()
    {
        return new BNN_MemberBO();
    }

    // BNN_QABO 
    public static BNN_QABO GetBNN_QABO()
    {
        return new BNN_QABO();
    }

    // BNN_VideoBO 
    public static BNN_VideoBO GetBNN_VideoBO()
    {
        return new BNN_VideoBO();
    }
    // BNN_BackLinkBO 
    public static BNN_BackLinkBO GetBNN_BackLinkBO()
    {
        return new BNN_BackLinkBO();
    }
    // BNN_RegionBO 
    public static BNN_RegionBO GetBNN_RegionBO()
    {
        return new BNN_RegionBO();
    }

    // BNN_RegionVsLocationBO 
    public static BNN_RegionVsLocationBO GetBNN_RegionVsLocationBO()
    {
        return new BNN_RegionVsLocationBO();
    }
    // BNN_ProductBO 
    public static BNN_ProductBO GetBNN_ProductBO()
    {
        return new BNN_ProductBO();
    }
    // BNN_CountryBO 
    public static BNN_CountryBO GetBNN_CountryBO()
    {
        return new BNN_CountryBO();
    }

    // BNN_CountryVsDocumentBO 
    public static BNN_CountryVsDocumentBO GetBNN_CountryVsDocumentBO()
    {
        return new BNN_CountryVsDocumentBO();
    }
    // BusinessTypeBO 
    public static BusinessTypeBO GetBusinessTypeBO()
    {
        return new BusinessTypeBO();
    }

    // ProductBrandChangeBO 
    public static ProductBrandChangeBO GetProductBrandChangeBO()
    {
        return new ProductBrandChangeBO();
    }

    // ProductChangeBO 
    public static ProductChangeBO GetProductChangeBO()
    {
        return new ProductChangeBO();
    }
    // Account_CheckVNBO 
    public static Account_CheckVNBO GetAccount_CheckVNBO()
    {
        return new Account_CheckVNBO();
    }

    // BNN_NewsVsDocumentBO 
    public static BNN_NewsVsDocumentBO GetBNN_NewsVsDocumentBO()
    {
        return new BNN_NewsVsDocumentBO();
    }
    // BNN_OrderBO 
    public static BNN_OrderBO GetBNN_OrderBO()
    {
        return new BNN_OrderBO();
    }

    // BNN_OrderDetailBO 
    public static BNN_OrderDetailBO GetBNN_OrderDetailBO()
    {
        return new BNN_OrderDetailBO();
    }
    // ProductColorBO 
    public static ProductColorBO GetProductColorBO()
    {
        return new ProductColorBO();
    }
    // ProductSetBO 
    public static ProductSetBO GetProductSetBO()
    {
        return new ProductSetBO();
    }
    // RegionBO 
    public static RegionBO GetRegionBO()
    {
        return new RegionBO();
    }
    // ProductCategory_WebBO 
    public static ProductCategory_WebBO GetProductCategory_WebBO()
    {
        return new ProductCategory_WebBO();
    }
    // ProductVsIconBO 
    public static ProductVsIconBO GetProductVsIconBO()
    {
        return new ProductVsIconBO();
    }
    // WEB_PromotionBO 
    public static WEB_PromotionBO GetWEB_PromotionBO()
    {
        return new WEB_PromotionBO();
    }
    // WEB_SpaceBO 
    public static WEB_SpaceBO GetWEB_SpaceBO()
    {
        return new WEB_SpaceBO();
    }
    // ProductClassifyBO 
    public static ProductClassifyBO GetProductClassifyBO()
    {
        return new ProductClassifyBO();
    }
    // Product_ESBO 
    public static Product_ESBO GetProduct_ESBO()
    {
        return new Product_ESBO();
    }

    // QRCodeLocationRegister_ESBO 
    public static QRCodeLocationRegister_ESBO GetQRCodeLocationRegister_ESBO()
    {
        return new QRCodeLocationRegister_ESBO();
    }

    // QRCodePackage_ESBO 
    public static QRCodePackage_ESBO GetQRCodePackage_ESBO()
    {
        return new QRCodePackage_ESBO();
    }

    // QRCodePackageFragment_ESBO 
    public static QRCodePackageFragment_ESBO GetQRCodePackageFragment_ESBO()
    {
        return new QRCodePackageFragment_ESBO();
    }

    // QRCodePackageRule_ESBO 
    public static QRCodePackageRule_ESBO GetQRCodePackageRule_ESBO()
    {
        return new QRCodePackageRule_ESBO();
    }

    // QRCodePackageVsProductPakage_ESBO 
    public static QRCodePackageVsProductPakage_ESBO GetQRCodePackageVsProductPakage_ESBO()
    {
        return new QRCodePackageVsProductPakage_ESBO();
    }

    // QRCodePublic_ESBO 
    public static QRCodePublic_ESBO GetQRCodePublic_ESBO()
    {
        return new QRCodePublic_ESBO();
    }

    // QRCodeSecret_ESBO 
    public static QRCodeSecret_ESBO GetQRCodeSecret_ESBO()
    {
        return new QRCodeSecret_ESBO();
    }

    // QRCodeStatus_ESBO 
    public static QRCodeStatus_ESBO GetQRCodeStatus_ESBO()
    {
        return new QRCodeStatus_ESBO();
    }

    // QRCodeTracking_ESBO 
    public static QRCodeTracking_ESBO GetQRCodeTracking_ESBO()
    {
        return new QRCodeTracking_ESBO();
    }

    // QRCodeWarehouseRegister_ESBO 
    public static QRCodeWarehouseRegister_ESBO GetQRCodeWarehouseRegister_ESBO()
    {
        return new QRCodeWarehouseRegister_ESBO();
    }

    // QRCodeWorkshopRegister_ESBO 
    public static QRCodeWorkshopRegister_ESBO GetQRCodeWorkshopRegister_ESBO()
    {
        return new QRCodeWorkshopRegister_ESBO();
    }

    // Warehouse_ESBO 
    public static Warehouse_ESBO GetWarehouse_ESBO()
    {
        return new Warehouse_ESBO();
    }
    // ProductCategory_ESBO 
    public static ProductCategory_ESBO GetProductCategory_ESBO()
    {
        return new ProductCategory_ESBO();
    }
    // ProductGallery_ESBO 
    public static ProductGallery_ESBO GetProductGallery_ESBO()
    {
        return new ProductGallery_ESBO();
    }

    // ProductInfo_ESBO 
    public static ProductInfo_ESBO GetProductInfo_ESBO()
    {
        return new ProductInfo_ESBO();
    }
    // WEB_PromotionVsProductBO 
    public static WEB_PromotionVsProductBO GetWEB_PromotionVsProductBO()
    {
        return new WEB_PromotionVsProductBO();
    }
    // WH_MaterialBO 
    public static WH_MaterialBO GetWH_MaterialBO()
    {
        return new WH_MaterialBO();
    }

    // WH_MaterialCategoryBO 
    public static WH_MaterialCategoryBO GetWH_MaterialCategoryBO()
    {
        return new WH_MaterialCategoryBO();
    }
    // WH_DeliveryNoteBO 
    public static WH_DeliveryNoteBO GetWH_DeliveryNoteBO()
    {
        return new WH_DeliveryNoteBO();
    }

    // WH_DeliveryNoteVsMaterialBO 
    public static WH_DeliveryNoteVsMaterialBO GetWH_DeliveryNoteVsMaterialBO()
    {
        return new WH_DeliveryNoteVsMaterialBO();
    }
    // WH_StandardCheckBO 
    public static WH_StandardCheckBO GetWH_StandardCheckBO()
    {
        return new WH_StandardCheckBO();
    }

    // SamplingPlanBO 
    public static SamplingPlanBO GetSamplingPlanBO()
    {
        return new SamplingPlanBO();
    }
    // WH_CheckSheetBO 
    public static WH_CheckSheetBO GetWH_CheckSheetBO()
    {
        return new WH_CheckSheetBO();
    }

    // WH_CheckSheetVsMaterialBO 
    public static WH_CheckSheetVsMaterialBO GetWH_CheckSheetVsMaterialBO()
    {
        return new WH_CheckSheetVsMaterialBO();
    }
    // WH_CheckSheet_DetailBO 
    public static WH_CheckSheet_DetailBO GetWH_CheckSheet_DetailBO()
    {
        return new WH_CheckSheet_DetailBO();
    }
    // WH_OrderBO 
    public static WH_OrderBO GetWH_OrderBO()
    {
        return new WH_OrderBO();
    }

    // WH_OrderVsProductBO 
    public static WH_OrderVsProductBO GetWH_OrderVsProductBO()
    {
        return new WH_OrderVsProductBO();
    }
    // TestParameterBO 
    public static TestParameterBO GetTestParameterBO()
    {
        return new TestParameterBO();
    }
   
    // WH_MaterialVsTestParameterBO 
    public static WH_MaterialVsTestParameterBO GetWH_MaterialVsTestParameterBO()
    {
        return new WH_MaterialVsTestParameterBO();
    }
}

