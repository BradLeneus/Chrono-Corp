using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Service;
using ChronoCorp.View;
using ChronoCorp.ViewModel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace ChronoCorp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            ConfigureServices(serviceCollection, configuration);

            _serviceProvider = serviceCollection.BuildServiceProvider();
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();

            var loginWindow = _serviceProvider.GetRequiredService<LoginView>();
            loginWindow.Show();

            var addEmployee = _serviceProvider.GetRequiredService<AddEmployeeView>();
        }

        private void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration)
        {
            // Logging
            services.AddLogging();

            // DbContext
            services.AddSingleton(new ApplicationDbContext());

            // Services
            services.AddTransient<IMessagerieService, MessagerieService>();
            services.AddTransient<ICeduleQuartService, CeduleQuartService>();
            services.AddTransient<IDemandeCongeService, DemandeCongeService>();
            services.AddTransient<IFichePaieService, FichePaieService>();
            services.AddTransient<ITypeQuartService, TypeQuartService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddSingleton<IAuthService, AuthService>();

            // ViewModels
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<AddEmployeeViewModel>();
            services.AddSingleton<EditEmployeeViewModel>();

            // Views
            services.AddSingleton<LoginView>();
            services.AddSingleton<MainWindow>();
            services.AddSingleton<AddEmployeeView>();
            services.AddSingleton<EditEmployeeView>();
        }

        private void OnExit(object sender, ExitEventArgs e)
        {
            if (_serviceProvider is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }

}
