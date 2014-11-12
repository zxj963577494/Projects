using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using Web;

namespace Web
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // 在应用程序启动时运行的代码
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            InitActiveRecord();
        }

        private void InitActiveRecord()
        {
            try
            {
                string NHibernateFilePath = Server.MapPath("~/NHibernate.config");
                XmlConfigurationSource source = new XmlConfigurationSource(NHibernateFilePath);
                ActiveRecordStarter.Initialize(source,typeof(Model.Category),typeof(Model.Post), typeof(Model.Comment));
            }
            catch (Exception)
            {

                throw;
            }

        }


        void Application_End(object sender, EventArgs e)
        {
            //  在应用程序关闭时运行的代码

        }

        void Application_Error(object sender, EventArgs e)
        {
            // 在出现未处理的错误时运行的代码

        }
    }
}
