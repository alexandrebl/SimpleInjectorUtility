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
