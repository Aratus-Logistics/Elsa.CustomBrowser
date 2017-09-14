using CustomBrowser.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace CustomBrowser
{
    public partial class App : Application
    {
        private NavigationPage _navitagionPage = new NavigationPage(new CustomBrowser.Views.CustomBrowser(new SettingsService()));

        public App()
        {
            InitializeComponent();

            _navitagionPage.Title = "Elsa Scan";
            NavigationPage.SetHasNavigationBar(this, false);

            MainPage = _navitagionPage;
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
