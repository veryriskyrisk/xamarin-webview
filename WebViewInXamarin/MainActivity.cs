using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;

using Android.Webkit;
using Android.Widget;
using Android.Views;

namespace WebViewInXamarin
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        WebView web_view;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            web_view = FindViewById<WebView>(Resource.Id.webview);
            web_view.Settings.JavaScriptEnabled = true;
            web_view.SetWebViewClient(new BringBackTheGoodOldWebview());
            web_view.LoadUrl("https://www.xamarin.com/university");

            Button button = FindViewById<Button>(Resource.Id.button);

            button.Click += (sender, args) =>
            {
                EditText editText = FindViewById<EditText>(Resource.Id.address);
                string val = editText.Text;
                web_view.LoadUrl(val);
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }

    public class BringBackTheGoodOldWebview : WebViewClient
    {
        public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
        {
            view.LoadUrl(request.Url.ToString());
            return false;
        }
    }
}
