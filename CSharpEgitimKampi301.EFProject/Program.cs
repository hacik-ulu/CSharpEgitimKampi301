using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    static class Program
    {
        // Uygulamanın giriş noktası
        [STAThread]
        static void Main()
        {
            // ServiceCollection üzerinden DI yapılandırmasını yapıyoruz
            var services = new ServiceCollection();

            // DbContext'i ekliyoruz. Eğer DbContext konfigürasyonu varsa burada belirtilebilir.
            services.AddSingleton<EgitimKampiEfTravelDbEntities1>();

            // Form1'i DI ile başlatıyoruz
            services.AddSingleton<Form1>();

            // ServiceProvider üzerinden uygulama başlatılıyor
            var serviceProvider = services.BuildServiceProvider();

            // Form1'i DI konteynerinden alıp başlatıyoruz
            var form = serviceProvider.GetService<Form1>();

            // Form1'i çalıştırıyoruz
            Application.Run(form);
        }
    }
}
