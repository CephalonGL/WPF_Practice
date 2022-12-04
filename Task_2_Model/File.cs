using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm;

namespace Task_2_Model;

/// <summary>
/// Store information about file.
/// </summary>
public class File : INotifyPropertyChanged
{
    /// <summary>
    /// Store file name.
    /// </summary>
    private string _name;

    /// <summary>
    /// Store file name.
    /// </summary>
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    /// <summary>
    /// Create file item.
    /// </summary>
    /// <param name="name">File name.</param>
    public File(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Notify system about changing of file properties.
    /// </summary>
    /// <param name="propertyName"></param>
    private void OnPropertyChanged(string? propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <summary>
    /// Invoke when property changed.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;
}