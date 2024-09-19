using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPrettified2.Model;
using WpfPrettified2.ViewModel;

namespace WpfPrettified2
{
    internal class Test
    {
        private void CarTest()
        {
            //skaf en bil
            ICar aCar = CreateCar(1);

        }

        /// <summary>
        /// Factory method
        /// </summary>
        /// <param name="typeOfCar"></param>
        /// <returns></returns>
        private ICar CreateCar(int typeOfCar)
        {
            ICar returnVal = null;
            if (typeOfCar == 1)
            { 
                returnVal = new Car();
            }
            else if (typeOfCar == 2)
            {
                returnVal = new StationWagon();
            }
            return returnVal;
        }


    }
}
