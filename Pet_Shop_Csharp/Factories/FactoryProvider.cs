using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Pet_Shop_Csharp.Factories
{
    public static class FactoryProvider
    {
        public static IFactory GetFactory()
        {
            var factoryType = ConfigurationManager.AppSettings["factoryType"];
            switch (factoryType)
            {
                case "file":
                    return new FileFactory();
                default:
                    return new MemoryFactory();
            }

        }

    }
}
