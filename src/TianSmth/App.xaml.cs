using System;
using TianSmth.Services;
using TianSmth.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TianSmth
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
