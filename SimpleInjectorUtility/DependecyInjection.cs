using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using UtilityHelperTools.Libraries;

namespace SimpleInjectorUtility {

    /// <summary>
    /// Dependency Injection controller
    /// </summary>
    public class DependecyInjection {

        /// <summary>
        /// Get container instance
        /// </summary>
        /// <returns></returns>
        public static Container GetContainerInstance() {
            //Return
            return DependencyInjectionLibrary<Container>.GetContainerInstance();
        }
    }
}
