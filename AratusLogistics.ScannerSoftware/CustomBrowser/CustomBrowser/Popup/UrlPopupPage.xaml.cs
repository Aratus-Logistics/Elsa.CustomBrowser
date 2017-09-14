using CustomBrowser.Constants;
using CustomBrowser.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomBrowser.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrlPopupPage : ContentPage
    {
        private SettingsService _settingsService;

        private CustomBrowser.Views.CustomBrowser _parentWindow;

        public UrlPopupPage(CustomBrowser.Views.CustomBrowser parentView, SettingsService settingsService)
        {
            InitializeComponent();

            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

            this._parentWindow = parentView;
            this._settingsService = settingsService;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
        protected override bool OnBackButtonPressed()
        {
            // Prevent hide popup
            // base.OnBackButtonPressed();
            return true;
        }

        private void btn_ok_Clicked(object sender, EventArgs e)
        {
            string txb_url_value = this.txb_url.Text;
            if (txb_url_value != "" && txb_url_value != null)
            {
                _settingsService.AddOrUpdateProperty(AppConstants.URL_PROPERTYNAME, this.txb_url.Text.Trim());
                _parentWindow.SetBrowserUrl(this.txb_url.Text.Trim());

                Navigation.PopAsync();
            }
            else
            {
                this.txb_url.Placeholder = "This field need to be set before submitting";
                this.txb_url.BackgroundColor = Color.FromHex("F94545");
            }
        }
    }
}