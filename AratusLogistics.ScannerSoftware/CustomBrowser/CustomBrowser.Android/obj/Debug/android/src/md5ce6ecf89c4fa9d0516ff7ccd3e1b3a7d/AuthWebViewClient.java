package md5ce6ecf89c4fa9d0516ff7ccd3e1b3a7d;


public class AuthWebViewClient
	extends android.webkit.WebViewClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onReceivedHttpAuthRequest:(Landroid/webkit/WebView;Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/lang/String;)V:GetOnReceivedHttpAuthRequest_Landroid_webkit_WebView_Landroid_webkit_HttpAuthHandler_Ljava_lang_String_Ljava_lang_String_Handler\n" +
			"n_shouldOverrideUrlLoading:(Landroid/webkit/WebView;Ljava/lang/String;)Z:GetShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("CustomBrowser.Droid.CustomRenderer.AuthWebViewClient, CustomBrowser.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AuthWebViewClient.class, __md_methods);
	}


	public AuthWebViewClient () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AuthWebViewClient.class)
			mono.android.TypeManager.Activate ("CustomBrowser.Droid.CustomRenderer.AuthWebViewClient, CustomBrowser.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public AuthWebViewClient (java.lang.String p0, java.lang.String p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == AuthWebViewClient.class)
			mono.android.TypeManager.Activate ("CustomBrowser.Droid.CustomRenderer.AuthWebViewClient, CustomBrowser.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public void onReceivedHttpAuthRequest (android.webkit.WebView p0, android.webkit.HttpAuthHandler p1, java.lang.String p2, java.lang.String p3)
	{
		n_onReceivedHttpAuthRequest (p0, p1, p2, p3);
	}

	private native void n_onReceivedHttpAuthRequest (android.webkit.WebView p0, android.webkit.HttpAuthHandler p1, java.lang.String p2, java.lang.String p3);


	public boolean shouldOverrideUrlLoading (android.webkit.WebView p0, java.lang.String p1)
	{
		return n_shouldOverrideUrlLoading (p0, p1);
	}

	private native boolean n_shouldOverrideUrlLoading (android.webkit.WebView p0, java.lang.String p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
