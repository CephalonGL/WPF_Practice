using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CommunityToolkit.Mvvm;
using Task_2_View_Model;

namespace Task_2_View;

/// <summary>
/// Interaction logic for customButton.xaml
/// </summary>
public partial class FileButton : UserControl
{
    /// <summary>
    /// Create CustomButton item.
    /// </summary>
    public FileButton()
    {
        InitializeComponent();
    }
}
