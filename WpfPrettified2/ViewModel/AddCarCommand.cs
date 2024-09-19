using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrettified2.ViewModel
{
    public class AddCarCommand : ICommandBase
    {
        public AddCarCommand(Action<object> executeAction, Func<object, bool> canExecuteAction) : base(executeAction, canExecuteAction)
        {}
    }
}
