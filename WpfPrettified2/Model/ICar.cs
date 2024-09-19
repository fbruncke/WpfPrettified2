using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrettified2.Model
{
    /// <summary>
    /// Interface defining the Cars
    /// Now the factory can instantiate all sorts of cars which implement the interface
    /// </summary>
    public interface ICar
    {
        string Brand { get; set; }

        int HP { get; set; }

        #region cool version
        ICar CreateCar();
        #endregion

    }
}
