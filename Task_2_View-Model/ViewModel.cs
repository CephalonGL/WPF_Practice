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

namespace Task_2_View_Model
{
    public class ViewModel
    {
        public ViewModel()
        {
            Files = new();
            AddItemCommand = new CustomCommand(AddItem);
            RemoveItemCommand = new CustomCommand(RemoveItem);
        }


        private ObservableCollection<File> _files;

        public ObservableCollection<File> Files
        {
            get => _files;
            set => _files = value;
        }

        public void AddItem(object obj)
        {
            OpenFileDialog fileDialog = new();
            fileDialog.ShowDialog();
            Files.Add(new File(fileDialog?.FileName));
        }
        private void RemoveItem(object obj)
        {

        }
        
        public ICommand AddItemCommand
        {
            get;
            private set;
        }

        public ICommand RemoveItemCommand
        {
            get;
            private set;
        }
    }
}
