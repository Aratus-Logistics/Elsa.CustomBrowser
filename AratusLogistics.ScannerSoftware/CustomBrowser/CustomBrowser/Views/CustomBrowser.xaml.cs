using CustomBrowser.Constants;
using CustomBrowser.Popup;
using CustomBrowser.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomBrowser.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomBrowser : ContentPage
    {
        private AuthWebView _localWebview;

        private SettingsService _settingsService;

        public CustomBrowser(SettingsService settingsService)
        {
            InitializeComponent();

            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

            _settingsService = settingsService;

            try
            {
                _localWebview = this.webview_mainApplication;

                _localWebview.Username = AppConstants.ARATUSWS_USERNAME;
                _localWebview.Password = AppConstants.ARATUSWS_PASSWORD;

                SetApplicationUrl();
            }
            catch (Exception ex)
            {
                this.DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        public async void SetApplicationUrl()
        {
            try
            {
                var _url = _settingsService.GetPropertyOrDefault(AppConstants.URL_PROPERTYNAME, "");
                if (_url == "")
                {
                    await Navigation.PushAsync(new UrlPopupPage(this, new SettingsService()));
                }
                SetBrowserUrl(_url);

                //string _url = "https://www.aratusws.com/frida_cannon/";
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void SetBrowserUrl(string url)
        {
            _localWebview.Source = new UrlWebViewSource()
            {
                Url = url
            };
        }

        protected override bool OnBackButtonPressed()
        {
            //return base.OnBackButtonPressed();
            return true;
        }
    }
}
