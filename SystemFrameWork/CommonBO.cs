using System;
using System.Collections.Generic;
using System.Text;
using System.Web;


namespace SystemFrameWork
{
    /// <summary>
    /// Đây là class xây dựng các phương thức dùng chung trong hệ thống
    /// </summary>
    public class CommonBO
    {
        public static String HomePhysicalPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory.ToString();
            }
        }

        public static String HomePath
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["Domain"].ToString();
            }
        }
        public static String GetCountryFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["Country"].ToString();
            }
        }

        public static String GetCountryFolderHomePath
        {
            get
            {
                return HomePath + GetCountryFolder;
            }
        }

        public static String GetCountryFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetCountryFolder;
            }
        }


        public static String GetActivitiesFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["Activities"].ToString();
            }
        }

        public static String GetActivitiesFolderHomePath
        {
            get
            {
                return HomePath + GetActivitiesFolder;
            }
        }

        public static String GetActivitiesFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetActivitiesFolder;
            }
        }

        public static String GetAttractionsFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["Attractions"].ToString();
            }
        }

        public static String GetAttractionsFolderHomePath
        {
            get
            {
                return HomePath + GetAttractionsFolder;
            }
        }

        public static String GetAttractionsFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetAttractionsFolder;
            }
        }

        public static String GetTourFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["Tour"].ToString();
            }
        }

        public static String GetTourFolderHomePath
        {
            get
            {
                return HomePath + GetTourFolder;
            }
        }

        public static String GetTourFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetTourFolder;
            }
        }
        public static String GetStaffFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["Staff"].ToString();
            }
        }

        public static String GetStaffFolderHomePath
        {
            get
            {
                return HomePath + GetStaffFolder;
            }
        }

        public static String GetStaffFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetStaffFolder;
            }
        }

        public static String GetHotelFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["Hotel"].ToString();
            }
        }

        public static String GetHotelFolderHomePath
        {
            get
            {
                return HomePath + GetHotelFolder;
            }
        }

        public static String GetHotelFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetHotelFolder;
            }
        }

        public static String GetTravelGuideFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["TravelGuide"].ToString();
            }
        }

        public static String GetTravelGuideFolderHomePath
        {
            get
            {
                return HomePath + GetTravelGuideFolder;
            }
        }

        public static String GetTravelGuideFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetTravelGuideFolder;
            }
        }

        public static String GetTestimonialFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["Testimonial"].ToString();
            }
        }

        public static String GetTestimonialFolderHomePath
        {
            get
            {
                return HomePath + GetTestimonialFolder;
            }
        }

        public static String GetTestimonialFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetTestimonialFolder;
            }
        }

        public static String GetAboutFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["About"].ToString();
            }
        }

        public static String GetAboutFolderHomePath
        {
            get
            {
                return HomePath + GetAboutFolder;
            }
        }

        public static String GetAboutFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetAboutFolder;
            }
        }

        public static String GetBannerHomeFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["BannerHome"].ToString();
            }
        }

        public static String GetBannerHomeFolderHomePath
        {
            get
            {
                return HomePath + GetBannerHomeFolder;
            }
        }

        public static String GetBannerHomeFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetBannerHomeFolder;
            }
        }

        public static String GetTravelReportFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["TravelReport"].ToString();
            }
        }

        public static String GetTravelReportFolderHomePath
        {
            get
            {
                return HomePath + GetTravelReportFolder;
            }
        }

        public static String GetTravelReportFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetTravelReportFolder;
            }
        }

        public static String GetNewsFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["News"].ToString();
            }
        }

        public static String GetNewsFolderHomePath
        {
            get
            {
                return HomePath + GetNewsFolder;
            }
        }

        public static String GetNewsFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetNewsFolder;
            }
        }

        public static String GetPromotionFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["Promotion"].ToString();
            }
        }

        public static String GetPromotionFolderHomePath
        {
            get
            {
                return HomePath + GetPromotionFolder;
            }
        }

        public static String GetPromotionFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetPromotionFolder;
            }
        }

        public static String GetPartnerFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["Partner"].ToString();
            }
        }

        public static String GetPartnerFolderHomePath
        {
            get
            {
                return HomePath + GetPartnerFolder;
            }
        }

        public static String GetPartnerFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetPartnerFolder;
            }
        }


        public static String GetExclusiveFolder
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["Exclusive"].ToString();
            }
        }

        public static String GetExclusiveFolderHomePath
        {
            get
            {
                return HomePath + GetExclusiveFolder;
            }
        }

        public static String GetExclusiveFolderPhysicalPath
        {
            get
            {
                return HomePhysicalPath + GetExclusiveFolder;
            }
        }

    }

}

