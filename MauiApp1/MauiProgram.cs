using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>();
            // Here we put only essential services

            return builder.Build();
        }
    }
}