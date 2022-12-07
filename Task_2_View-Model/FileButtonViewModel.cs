using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task_2_Model;

namespace Task_2_View_Model;

public class FileButtonViewModel
{
    private File _file;

    private ICommand _removeCommand;
    public File File
    {
        get => _file;
        set => _file = value;
    }

    public ICommand RemoveCommand
    {
        get => _removeCommand; 
        set => _removeCommand = value;
    }

    public FileButtonViewModel()
    {

    }

    public FileButtonViewModel(File file, ICommand remove)
    {
        File = file;
        RemoveCommand = remove;
    }
}