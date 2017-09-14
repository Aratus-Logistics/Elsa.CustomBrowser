using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomBrowser.Views
{
    public class AuthWebView : WebView
    {
        public static readonly BindableProperty UsernameProperty = BindableProperty.Create(propertyName: "Username", returnType: typeof(string), declaringType: typeof(AuthWebView), defaultValue: default(string));
        public static readonly BindableProperty PasswordProperty = BindableProperty.Create(propertyName: "Password", returnType: typeof(string), declaringType: typeof(AuthWebView), defaultValue: default(string));

        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }
    }
}