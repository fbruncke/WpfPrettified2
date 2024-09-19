using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfPrettified2.Model;

namespace WpfPrettified2.ViewModel
{
    class MainWindowViewModel
    {
        //*************** Instances variables *****************
        ObservableCollection<Model.Bike> bikes; //Bike instances are created conventionally
        ObservableCollection<Model.ICar> cars; //Car instances are created by a factory

        private ICommand addCarCommand = null;

        private ICommand addRandomCarCommand = null;

        private ICommand addBikeCommand = null;

        private ICommand addCoolCarCommand = null;

        //*************** getters and setter *****************


        public ObservableCollection<Model.Bike> Bikes
        {
            get { return bikes; }
            set { bikes = value; }
        }

        public ObservableCollection<Model.ICar> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public ICommand AddCarCmd => addCarCommand ?? (addCarCommand = new AddCarCommand(AddCar, CanAddCar));

        public ICommand AddRandomCarCmd => addRandomCarCommand ?? (addRandomCarCommand = new AddRandomCarCommand(AddRandomCar, obj => true));



        //public ICommand AddBikeCmd2 => addBikeCommand ?? (
        //    addBikeCommand = new AddBikeCommand(
        //    obj => bikes.Add(new Model.Bike { Brand = "Cube", NumberOfGears = 27 }) , obj => true) );


        public ICommand AddCoolCarCmd => addCoolCarCommand ?? (

            addCoolCarCommand = new AddCoolCarCommand(
                (obj) => {
                    Debug.WriteLine("Button pressed");
                    Cars.Add(ElegantCarFactory.Get.CreateProduct("ECar"));
                }, obj => true) 
            );
            //obj => this.Cars.Add(Model.CarFactory.CreateRandomCar()), obj => true));
            

        public ICommand AddBikeCmd
        {
            get
            {
                if (addBikeCommand == null)
                {
                    addBikeCommand = new AddBikeCommand(AddBike, CanAddBike);
                }
                return addBikeCommand;
            }
        }


        /// <summary>
        /// The constructor
        /// </summary>
        public MainWindowViewModel()
        {
            bikes = new ObservableCollection<Model.Bike>();
            bikes.Add(new Model.Bike { Brand = "SCO", NumberOfGears = 7 });

            cars = new ObservableCollection<Model.ICar>();
            //Conventional cosntructor call, if the constructor is private then 
            //this would not be possible        
            cars.Add(new Model.Car { Brand = "Ford", HP = 300, Color="Red" });
        }


        //*************** methods invoked by the view "event handlers" trough the ICommand *****************
        private void AddCar(object commandParameter)
        {
            //this.Cars.Add(new Model.Car { Brand = "Opel", HP = 200 });
            this.Cars.Add(Model.Car.CreateNewCar("Porsche", 500, "Grey"));
        }

        private void AddRandomCar(object commandParameter)
        {
            //this.Cars.Add(new Model.Car { Brand = "Opel", HP = 200 });
            //this.Cars.Add(Model.Car.CreateNewCar("Porsche", 500));
            this.Cars.Add( Model.CarFactory.CreateRandomCar() );
        }

                

        private bool CanAddCar(object commandParameter)
        {
            return Cars.Count < 10;
        }
        

        private void AddBike(object commandParameter)
        {
            bikes.Add(new Model.Bike { Brand = "Cube", NumberOfGears = 27 });
        }           

        private bool CanAddBike(object commandParameter)
        {
            return Bikes.Count < 5;
        }
        
    }
}
