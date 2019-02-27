using Android.App;
using Android.Content.PM;
using Android.OS;

namespace HelloGlide.Droid
{
	[Activity (Label = "HelloGlide", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate (savedInstanceState);
			Xamarin.Forms.Forms.Init (this, savedInstanceState);
			Android.Glide.Forms.Init (debug: true);
			LoadApplication (new App ());
		}
	}
}