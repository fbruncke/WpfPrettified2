using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrettified2.Model
{
    public class Bike : ViewModel.ViewModelBase
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

        private int numberOfGears;

        public int NumberOfGears
        {
            get { return numberOfGears; }
            set
            {
                numberOfGears = value;
                base.Changed();
            }
        }
    
    }
}
