using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BelajarNotifyPropertyChange.Extensions;
using BelajarNotifyPropertyChange.Models;
using BelajarNotifyPropertyChange.Presentations.PopUpWindow;
using Microsoft.Extensions.DependencyInjection;

namespace BelajarNotifyPropertyChange.Presentations.MainWindow
{
    public class MainWindowViewModel
    {
        private readonly IServiceProvider _serviceProvider;
        public MainWindowViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            //register commands
            OpenPageCmd = new RelayCommand(OpenPage, () => !_isAPageOpen);
            OpenPageCmdNonDisable = new RelayCommand(OpenBPage);

            Person = new();
        }

        public FooModel Person { get; set; }

        #region Commands
        public ICommand OpenPageCmd { get; }
        private bool _isAPageOpen = false;
        private void OpenPage() 
        {
            _isAPageOpen = true;
            (OpenPageCmd as RelayCommand)?.RaiseCanExecuteChanged();

            var window = new PopUpWindow.PopUpWindow(_serviceProvider.GetRequiredService<PopUpViewModel>(), Person);
            window.Closed += (s, e) =>
            {
                _isAPageOpen = false;
                (OpenPageCmd as RelayCommand)?.RaiseCanExecuteChanged();
            };

            window.Show();
        }

        public ICommand OpenPageCmdNonDisable { get; }
        private bool _isBPageOpen = false;
        Window PageB;
        private void OpenBPage()
        {
            if (PageB != null && PageB.IsLoaded)
            {
                PageB.Activate(); // Berikan fokus ke window yang sudah terbuka
                return;
            }

            _isBPageOpen = true;
            (OpenPageCmdNonDisable as RelayCommand)?.RaiseCanExecuteChanged();

            PageB = new PopUpWindow.PopUpWindow(_serviceProvider.GetRequiredService<PopUpViewModel>(), Person);
            PageB.Closed += (s, e) =>
            {
                _isBPageOpen = false;
                (OpenPageCmdNonDisable as RelayCommand)?.RaiseCanExecuteChanged();
            };

            PageB.Show();
        }

        #endregion
    }
}
