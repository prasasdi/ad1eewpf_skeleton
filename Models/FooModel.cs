using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BelajarNotifyPropertyChange.Models
{
    public class FooModel : INotifyPropertyChanged
    {
        private string name;

        //Declare event
        public event PropertyChangedEventHandler? PropertyChanged;

        public FooModel() { }

        public FooModel(string name)
        {
            this.name = name;
        }

        // getter setter
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
