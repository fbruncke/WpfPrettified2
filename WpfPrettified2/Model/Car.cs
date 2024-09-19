using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrettified2.Model
{
    public class Car : ViewModel.ViewModelBase, Model.ICar
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set {
                brand = value;
                base.Changed();
            }
        }

        private int hp;

        public int HP
        {
            get { return hp; }
            set {
                hp = value;
                base.Changed();
            }
        }

        private String color;

        public String Color
        {
            get { return color; }
            set { color = value; }
        }

       // private Car()
        //{ }


        /// <summary>
        /// Factory method
        /// The Car class can be changed, the user of the CreateNewCar does
        /// not need to know, it will still work after changes
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="hp"></param>
        /// <returns></returns>
        public static ICar CreateNewCar(string brand, int hp, String color="Black")
        {
            return new Car { Brand=brand, HP=hp, Color=color};
        }

        public ICar CreateCar()
        {
            throw new NotImplementedException();
        }
    }
}
