using BelajarNotifyPropertyChange.Presentations.MainWindow;
using BelajarNotifyPropertyChange.Presentations.PopUpWindow;
using Microsoft.Extensions.DependencyInjection;

namespace BelajarNotifyPropertyChange.DependencyInjection
{
    public static class RegisterDependencies
    {
        public static IServiceCollection InitializeServices(this IServiceCollection services)
        {
            // add business logic layer
            //services.AddSingleton<IDataService, DataService>();

            // add domain access layer
            //services.AddSingleton<IUserRepository, UserRepository>();

            // add viewmodel layer
            services.AddTransient<MainWindowViewModel>();
            services.AddTransient<PopUpViewModel>();

            // add view layer, tidak dianjurkan tapi oke ga apa-apa

            return services;
        }
    }
}
