using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using BLL;
using CapaPresentacion;

namespace SISTEMA_DE_VENTA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Cargar configuraci�n desde appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();
            services.AddTransient<FormPersonas>();
            services.AddTransient<FormLogin>();


            // Obtener cadena de conexi�n desde configuraci�n
            string connectionString = configuration.GetConnectionString("ConexionBaseDatos");

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString, sqlOptions =>
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5, // N�mero m�ximo de reintentos
                        maxRetryDelay: TimeSpan.FromSeconds(10), // Tiempo m�ximo entre reintentos
                        errorNumbersToAdd: null // Manejo autom�tico de errores transitorios
                    )));

            services.AddTransient<FormLogin>(); // Solo registramos FormLogin

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var loginForm = serviceProvider.GetRequiredService<FormLogin>();
                Application.Run(loginForm);
            }
        }
    }
}
