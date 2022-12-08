using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using Task_3_Model;

namespace Task_3_ViewModel;
public class MainViewModel
{
    public int SelectedIndex { get; set; }

    public ObservableCollection<CustomString> CustomStrings { get; set; }

    public RelayCommand AddItemCommand { get; set; }

    public RelayCommand<int> RemoveItemCommand { get; set; }


    MainViewModel()
    {
        AddItemCommand = new(() =>
        {
            CustomStrings.Add(new CustomString());
        });

        RemoveItemCommand = new((int index) =>
        {
            if (index == -1)
            {
                return;
            }
            CustomStrings.RemoveAt(index);
        });
    }
}
