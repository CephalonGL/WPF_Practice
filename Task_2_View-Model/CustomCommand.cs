using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task_2_View_Model
{
    internal class CustomCommand : ICommand
    {
        public CustomCommand(Action<object> executeAction)
        {
            _execute = executeAction;
        }

        private Action<object> _execute;
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (_execute is not null)
            {
                _execute(parameter);   
            }
        }

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
