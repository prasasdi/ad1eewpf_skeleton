using BelajarNotifyPropertyChange.Models;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BelajarNotifyPropertyChange.Presentations.PopUpWindow
{
    /// <summary>
    /// Interaction logic for PopUpWindow.xaml
    /// </summary>
    public partial class PopUpWindow : Window
    {
        public PopUpWindow(PopUpViewModel vm, FooModel person)
        {
            vm.Person = person;
            this.DataContext = vm;
            
            InitializeComponent();
        }
    }
}
