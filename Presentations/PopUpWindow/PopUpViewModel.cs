using BelajarNotifyPropertyChange.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace BelajarNotifyPropertyChange.Presentations.PopUpWindow
{
    public class PopUpViewModel : IDisposable
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScope _scope;
        public PopUpViewModel(IServiceProvider serviceProvider) 
        { 
            _serviceProvider = serviceProvider;
            _scope = _serviceProvider.CreateScope();
        }

        public FooModel Person { get; set; }

        private bool _disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // Dispose resource di sini
                _scope.Dispose();
            }

            _disposed = true;
        }
    }
}
