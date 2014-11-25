using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMap.Test
{
    public class BootStrapper
    {

        public static void ConfigureStructureMap()
        {
            ObjectFactory.Initialize(x =>
            {
                x.PullConfigurationFromAppConfig = true;
            });
        }

        //public static void ConfigureStructureMap()
        //{
        //    ObjectFactory.Configure(x =>
        //    {
        //        x.AddRegistry<ControllerRegisty>();
        //    });
        //}
        //private class ControllerRegisty : Registry
        //{
        //    public ControllerRegisty()
        //    {
        //        For<IContractValidator>().Use<ContractValidator>();
        //        For<IContractRepository>().Use<ContractRepository>().Ctor<string>("connectionString").Is("connectionString1").Ctor<string>("connectionString2").Is("connectionString2");
        //    }

        //}

        //public static void ConfigureStructureMap()
        //{
        //    ObjectFactory.Initialize(x =>
        //   {
        //       //是指如果用户请求IContractValidator的实例，那么StructureMap会调用ContractValidator类的构造函数并返回此实例
        //       x.For<IContractValidator>().Use<ContractValidator>();
        //       //以下调用只能用于Repository的构造函数只有1个String类型的参数， 否则抛错
        //       x.For<IContractRepository>().Use<ContractRepository>().Ctor<string>().Is("connectionString1");

        //       //如果Repository的构造函数有多个相同类型的参数，就必须使用Ctor([参数名])指定每一个参数的值， 否则抛错
        //       x.For<IContractRepository>().Use<ContractRepository>().Ctor<string>("connectionString").Is("connectionString1").Ctor<string>("connectionString2").Is("connectionString2");

        //       //如果Repository的构造函数的某个参数需要来自于配置文件， 可以使用Ctor<>().EqualToAppSeting() 指定对应的AppSetting的Key/Value
        //       x.For<IContractRepository>().Use<ContractRepository>().Ctor<string>("connectionString").Is("connectionString1").Ctor<string>("connectionString2").EqualToAppSetting("connection");
        //   });
        //}

    }
}
