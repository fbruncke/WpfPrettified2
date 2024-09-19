using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrettified2.Model
{
    public class ElectricCar : ViewModel.ViewModelBase, ICar
    {
        #region cool version
        public string Brand { get; set; } = "Tesla";
        public int HP { get; set; } = 200;

        public static void Initialize() { }

        static ElectricCar()
        {
            Debug.WriteLine("ElectricCar static constructor");
            ElegantCarFactory.Get.RegisterProduct("ECar", new ElectricCar());
        }

        public ICar CreateCar()
        {
            return new ElectricCar();
        }
        private ElectricCar()
        {
        }

        #endregion

    }
}
