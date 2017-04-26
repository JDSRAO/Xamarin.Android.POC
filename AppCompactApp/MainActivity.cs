namespace AppCompactApp
{
    using Android.App;
    using Android.Content;
    using Android.OS;
    using Android.Runtime;
    using Android.Support.Design.Widget;
    using Android.Support.V4.App;
    using Android.Support.V4.View;
    using Android.Support.V4.Widget;
    using Android.Support.V7.App;
    using Android.Views;
    using Android.Widget;
    using AppCompactApp.Services;
    using AppCompactApp.Services.Conections;
    using Java.Util;
    using System;

    [Activity(Label = "AppCompactApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        DrawerLayout drawerLayout;
        NavigationView navigationView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Enable support action bar to display hamburger
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.Icon);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);

            navigationView.NavigationItemSelected += (sender, e) =>
            {
                Toast.MakeText(this, "selected", ToastLength.Short);
                Intent intent = new Intent(this, typeof(Activity1));
                StartActivity(intent);
                e.MenuItem.SetChecked(true);
                
                //react to click here and swap fragments or navigate
                drawerLayout.CloseDrawers();
            };

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            button.Click += Button_Click;

        }
        
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer(GravityCompat.Start);
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var demoServiceIntent = new Intent(this, typeof(SampleService));
            var demoServiceConnection = new TimestampServiceConnection();
            BindService(demoServiceIntent, demoServiceConnection, Bind.AutoCreate);
            StartActivity(new Intent(this, typeof(Activity1)));

       //     var builder = new Android.Support.V7.App.AlertDialog.Builder(this);

       //     builder.SetTitle("Hello Dialog")
       //.SetMessage("Is this material design?")
       //.SetPositiveButton("Yes", delegate { Console.WriteLine("Yes"); })
       //.SetNegativeButton("No", delegate { Console.WriteLine("No"); });

       //     builder.Create().Show();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        
    }
}

