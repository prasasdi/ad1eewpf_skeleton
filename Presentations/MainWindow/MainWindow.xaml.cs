using BelajarNotifyPropertyChange.Presentations.MainWindow;
using System.Windows;

namespace BelajarNotifyPropertyChange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel vm)
        {
            this.DataContext = vm;
            InitializeComponent();
        }
    }
}
