using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Effects;

namespace WpfPrettified2.Model
{
    public  class ElegantCarFactory
    {
        #region cool version
        private Dictionary<String, ICar> registredeCarTypes = new Dictionary<String, ICar>();        
        
        private static ElegantCarFactory ecf;

        public static ElegantCarFactory Get
        {
            get { return ecf=ecf??new ElegantCarFactory(); }            
        }

        /// <summary>
        /// Singleton
        /// </summary>
        private ElegantCarFactory() { }

        public void RegisterProduct(String productID, ICar c)
        {
            #region reflection
            /*
             * .net framework factories examples
            var type = ConfigurationManager.AppSettings[""];
            var factory = Activator.CreateInstance(Type.GetType(type))as ICar;

            var test = DbProviderFactories.GetFactory("");
            test.CreatePermission(System.Security.Permissions.PermissionState.None);

            DataTable table = DbProviderFactories.GetFactoryClasses();
            */
            #endregion reflection

            registredeCarTypes.Add(productID, c);
        }

        public ICar CreateProduct(String productID)
        {
            if (registredeCarTypes.TryGetValue(productID, out ICar car)) return car.CreateCar();
            else return null;
        }

        #endregion
    }
}
