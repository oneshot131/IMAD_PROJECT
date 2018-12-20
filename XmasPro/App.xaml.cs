using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XmasPro
{
    public partial class App : Application
    {
        public static string DATABASE_PATH = string.Empty;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainScreen());
            MainPage = new NavigationPage(new TaskScreen());
            MainPage = new NavigationPage(new ForfeitScreen());
            MainPage = new NavigationPage(new MainPage());

        }

        public App(string DB_path)
        {
            InitializeComponent();

            DATABASE_PATH = DB_path;

            MainPage = new NavigationPage(new MainScreen());
            MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new TaskScreen());
            MainPage = new NavigationPage(new ForfeitScreen());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
