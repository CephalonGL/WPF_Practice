using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_ViewModel;
public class RightSideViewModel
{
    
    public RelayCommand GetReversedString { get; set; }
    
    public ObservableCollection<string> ReversedStrings { get; set; }
}
