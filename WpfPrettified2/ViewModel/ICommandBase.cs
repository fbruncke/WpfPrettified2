using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfPrettified2.ViewModel
{
    public abstract class ICommandBase : ICommand
    {
        //Generic delegates
        protected Action<object> _executeAction;
        protected Func<object, bool> _canExecuteAction;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="executeAction"></param>
        /// <param name="canExecuteAction"></param>
        protected ICommandBase(Action<object> executeAction, Func<object, bool> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }

        /// <summary>
        /// Event handler
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Can execute, the method which enables or disables the UI element trough the Command Manager
        /// Will just forward invoke the call
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            Boolean returnVal = true;
            if (_canExecuteAction != null)
                returnVal = _canExecuteAction(parameter);
            return returnVal;
        }

        /// <summary>
        /// The method which executes when an UI element is clicked
        /// WIll just forward invoke the call
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _executeAction?.Invoke(parameter);
        }
    }
}
