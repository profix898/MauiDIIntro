using SimpleInjector;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiApp1
{
    public partial class App : Application
    {
        private Container container;

        public App()
        {
            InitializeComponent();

            bool performUpgrade = true;
            if (performUpgrade)
            {
                var introPage = new IntroPage();
                introPage.Completed += InitApp;

                MainPage = introPage;
            }
            else
                InitApp();
        }

        public void InitApp()
        {
            // Here we register all app-specific services
            // (some of which might be in the build-in container already)
            container = new Container();
            container.Register<TimeService>();
            container.Register<MainPage>();
            // ...

            MainPage = container.GetInstance<MainPage>();
        }
    }
}
