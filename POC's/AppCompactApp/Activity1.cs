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
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android.Support.V4.View;

namespace AppCompactApp
{
    [Activity(Label = "Activity1")]
    public class Activity1 : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout1);
            Button btn_next = FindViewById<Button>(Resource.Id.btn_next);
            btn_next.Click += delegate 
            {
                Intent intent = new Intent(this, typeof(RecyclerActivity));
                StartActivity(intent);
            };
        }
    }
}