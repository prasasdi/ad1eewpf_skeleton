using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarNotifyPropertyChange.ViewModel
{
    public class FooViewModel
    {
        private readonly IServiceProvider _serviceProvider;
        public FooViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


    }

}
