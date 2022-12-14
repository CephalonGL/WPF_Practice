using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Task_2_Model;

namespace Task_2_View_Model;

/// <summary>
/// Main view-model
/// </summary>
public class MainViewModel
{
    /// <summary>
    /// Store all files.
    /// </summary>
    private ObservableCollection<FileButtonViewModel> _fileButtons;

    /// <summary>
    /// Store all files.
    /// </summary>
    public ObservableCollection<FileButtonViewModel> FileButtons
    {
        get => _fileButtons;
        set => _fileButtons = value;
    }

    /// <summary>
    /// Store link to AddItem method.
    /// </summary>
    public ICommand AddItemCommand
    {
        get;
        private set;
    }

    /// <summary>
    /// Store link to RemoveItem method.
    /// </summary>
    public ICommand RemoveItemCommand
    {
        get;
        private set;
    }

    /// <summary>
    /// Creates ViewModel item.
    /// </summary>
    public MainViewModel()
    {
        FileButtons = new();
        AddItemCommand = new CustomCommand(AddItem);
        RemoveItemCommand = new CustomCommand(RemoveItem);
    }

    /// <summary>
    /// Add new file to collection.
    /// </summary>
    /// <param name="parameter">object</param>
    public void AddItem(object parameter)
    {
        OpenFileDialog fileDialog = new();
        fileDialog.ShowDialog();
        if (fileDialog is not null)
        {
            var newFile = new File(fileDialog.FileName);
            FileButtons.Add(new FileButtonViewModel(
                newFile, RemoveItemCommand));
        }
    }

    /// <summary>
    /// Delete file from collection.
    /// </summary>
    /// <param name="parameter">object</param>
    private void RemoveItem(object parameter)
    {

        FileButtons.Remove(parameter as FileButtonViewModel);
    }
}
