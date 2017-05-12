using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TabbedApplication
{
    [Activity(Label = "Tabbed Application", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            var tab = this.ActionBar.NewTab();
            tab.SetText("Tab1");
            tab.SetIcon(Resource.Drawable.Icon);

            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e) {
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer,
                    new SampleTabFragment());
            };

            this.ActionBar.AddTab(tab);

            var tab1 = this.ActionBar.NewTab();
            tab1.SetText("Tab2");
            tab1.SetIcon(Resource.Drawable.Icon);

            tab1.TabSelected += delegate (object sender, ActionBar.TabEventArgs e) {
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer,
                    new ComplexTab());
            };

            this.ActionBar.AddTab(tab1);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

