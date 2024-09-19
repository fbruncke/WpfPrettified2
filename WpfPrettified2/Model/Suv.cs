using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrettified2.Model
{
    public class Suv :  ViewModel.ViewModelBase, ICar
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
                base.Changed();
            }
        }

        private int hp;

        public int HP
        {
            get { return hp; }
            set
            {
                hp = value;
                base.Changed();
            }
        }

        private int drivingWheels;

        public int DrivingWheels
        {
            get { return drivingWheels; }
            set { drivingWheels = value; base.Changed(); }
        }

        public ICar CreateCar()
        {
            throw new NotImplementedException();
        }
    }
}
