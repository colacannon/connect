using ConnectApp.Services;
using ConnectApp.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConnectApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            Boolean isLogin = Preferences.Get("isLogin", false);
            if (isLogin)
            {
                MainPage = new AppShell();
                Shell.Current.GoToAsync("//AboutPage"); //go to AppShell with Default Page(ItemsPage), you also could go to other pages  
            }
            else
            {
                MainPage = new LoginPage();
            }

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
