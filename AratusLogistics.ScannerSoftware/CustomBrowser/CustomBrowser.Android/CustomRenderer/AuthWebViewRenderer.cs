using Xamarin.Forms.Platform.Android;
using CustomBrowser.Views;
using Android.Webkit;
using WebView = Xamarin.Forms.WebView;
using AuthWebView = CustomBrowser.Views.AuthWebView;
using Xamarin.Forms;
using CustomBrowser.Droid.CustomRenderer;
using System.Threading.Tasks;
using System.Threading;
using System;

[assembly: ExportRenderer(typeof(AuthWebView), typeof(AuthWebViewRenderer))]
namespace CustomBrowser.Droid.CustomRenderer
{
    public class AuthWebViewRenderer : WebViewRenderer
    {
        AuthWebViewClient _authWebClient = null;
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            var _webView = e.NewElement as AuthWebView;
            if (_webView != null)
            {          
                if (_authWebClient == null)
                {
                    _authWebClient = new AuthWebViewClient(_webView.Username, _webView.Password);
                }
                Control.SetWebViewClient(_authWebClient);
            }
        }
    }
    public class AuthWebViewClient : WebViewClient
    {
        private string Username
        {
            get;
        }
        private string Password
        {
            get;
        }
        public AuthWebViewClient(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public override void OnReceivedHttpAuthRequest(Android.Webkit.WebView view, HttpAuthHandler handler, string host, string realm)
        {
            handler.Proceed(Username, Password);
        }

        public override bool ShouldOverrideUrlLoading(Android.Webkit.WebView view, string url)
        {
            view.LoadUrl(url);
            return true;
        }
    }

    internal class JavascriptCallback : Java.Lang.Object, IValueCallback
    {
        public JavascriptCallback(Action<string> callback)
        {
            _callback = callback;
        }

        private Action<string> _callback;
        public void OnReceiveValue(Java.Lang.Object value)
        {
            _callback?.Invoke(Convert.ToString(value));
        }
    }
}