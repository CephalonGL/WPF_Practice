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
public class ViewModel
{
    /// <summary>
    /// Creates ViewModel item.
    /// </summary>
    public ViewModel()
    {
        Files = new();
        AddItemCommand = new CustomCommand(AddItem);
        RemoveItemCommand = new CustomCommand(RemoveItem);
    }

    /// <summary>
    /// Store all files.
    /// </summary>
    private ObservableCollection<File> _files;

    /// <summary>
    /// Store all files.
    /// </summary>
    public ObservableCollection<File> Files
    {
        get => _files;
        set => _files = value;
    }

    /// <summary>
    /// Add new file to collection.
    /// </summary>
    /// <param name="obj">object</param>
    public void AddItem(object obj)
    {
        OpenFileDialog fileDialog = new();
        fileDialog.ShowDialog();
        Files.Add(new File(fileDialog?.FileName));
    }

    /// <summary>
    /// Delete file from collection.
    /// </summary>
    /// <param name="obj"></param>
    private void RemoveItem(object obj)
    {

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
}
