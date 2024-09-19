using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrettified2.Model
{
    public static class CarFactory
    {
        public static ICar CreateCar()
        //public static Car CreateCar()
        {
            return new Model.Car { Brand = "Fiat", HP = 100 };
        }

        public enum CarType
        {
            Car,
            Sportscar,
            stationwagon,
            SUV
        }

        public static ICar CreateCar(CarType ct)
        {
            ICar returnCar = null;
            switch (ct)
            {
                case CarType.Car:
                    //returnCar = new Model.Car { Brand = "Fiat", HP = 100 };
                    returnCar = Model.Car.CreateNewCar("Fiat", 100);
                    break;
            }
            return returnCar;

        }
    


        /// <summary>
        /// Create method with use of an interface, this is how it should be
        /// </summary>
        /// <returns></returns>
        public static ICar CreateRandomCar()
        {
            ICar returnCar = null;
            Random random = new Random();
            int rnd = random.Next(4);
            switch (rnd)
            {
                case 0:
                    //returnCar = new Model.Car { Brand = "Fiat", HP = 100 };
                    returnCar = Model.Car.CreateNewCar("Fiat", 100);
                    break;
                case 1:
                    returnCar = new Model.SportsCar { Brand = "Ferrari", HP = 700 };
                    break;
                case 2:
                    returnCar = new Model.StationWagon { Brand = "Alfa", HP = 150 };
                    break;
                case 3:
                    returnCar = new Model.Suv { Brand = "Alfa", HP = 150, DrivingWheels=4 };
                    break;
            }
            return returnCar;

        }

        

    }
}
