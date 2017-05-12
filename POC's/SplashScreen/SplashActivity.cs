using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading;

namespace SplashScreen
{
    [Activity(MainLauncher = true, Theme = "@style/MyTheme.Splash")]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_splash);
            Thread.Sleep(4000);
            Intent inten = new Intent(this, typeof(MainActivity));
            StartActivity(inten);
            // Create your application here
        }
    }
}