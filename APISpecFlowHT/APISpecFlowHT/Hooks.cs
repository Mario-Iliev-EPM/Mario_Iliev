using Allure.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISpecFlowHT
{
    [Binding]
    public class Hooks
    {
       public static AllureLifecycle allure = AllureLifecycle.Instance;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            allure.CleanupResultDirectory();
        }
    }
}
