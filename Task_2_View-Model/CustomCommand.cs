using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task_2_View_Model;

/// <summary>
/// Custom command.
/// </summary>
internal class CustomCommand : ICommand
{

    /// <summary>
    /// Create custom command item.
    /// </summary>
    /// <param name="executeAction"></param>
    public CustomCommand(Action<object> executeAction)
    {
        _execute = executeAction;
    }

    /// <summary>
    /// 
    /// </summary>
    private Action<object> _execute;

    /// <summary>
    /// Return true if command can be executed and false otherwise.
    /// </summary>
    /// <param name="parameter">Command to execute.</param>
    /// <returns>True if can execute, false otherwise.</returns>
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    /// <summary>
    /// Execute command.
    /// </summary>
    /// <param name="parameter">Command to execute.</param>
    public void Execute(object? parameter)
    {
        if (_execute is not null)
        {
            _execute(parameter);
        }
    }

    /// <summary>
    /// Change executable statement.
    /// </summary>
    public event EventHandler? CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}
