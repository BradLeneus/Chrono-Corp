using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Service;
using ChronoCorp.View;
using ChronoCorp.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Data;
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

            var loginWindow = _serviceProvider.GetRequiredService<LoginView>();
            loginWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration)
        {
            // Configure Logging
            services.AddLogging();

            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(configuration.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 31))));

            // Register Services
            services.AddSingleton<IEmployeeService, EmployeeService>();
            services.AddSingleton<IAuthService, AuthService>();

            // Register ViewModels
            //services.AddSingleton<IMainViewModel, MainViewModel>();
            services.AddSingleton<LoginViewModel>();

            // Register Views
            services.AddSingleton<LoginView>();
            services.AddSingleton<MainWindow>();
        }

        private void OnExit(object sender, ExitEventArgs e)
        {
            // Dispose of services if needed
            if (_serviceProvider is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }

}
