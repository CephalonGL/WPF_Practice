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
public class CustomCommand : ICommand
{
    /// <summary>
    /// Executable action.
    /// </summary>
    private Action<object> ExecuteAction
    {
        get;
        set;
    }
    
    /// <summary>
    /// Change executable statement.
    /// </summary>
    public event EventHandler? CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }

    /// <summary>
    /// Create custom command item.
    /// </summary>
    /// <param name="executeActionAction"></param>
    public CustomCommand(Action<object> executeActionAction)
    {
        ExecuteAction = executeActionAction;
    }

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
        if (ExecuteAction is not null)
        {
            ExecuteAction(parameter);
        }
    }
}
