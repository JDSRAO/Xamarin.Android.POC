namespace AppCompactApp.Activities
{
    using Android.App;
    using Android.Content;
    using Android.OS;
    using Android.Runtime;
    using Android.Support.V4.View;
    using Android.Views;
    using Android.Widget;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using AppCompactApp.Model;

    [Activity(Label = "ViewPagerActivity")]
    public class ViewPagerActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ViewPagerLayout);
            ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            TreeCatalog treeCatalog = new TreeCatalog();
        }
    }
}