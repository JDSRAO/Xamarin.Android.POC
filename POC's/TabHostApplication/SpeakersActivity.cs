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

namespace TabHostApplication
{
    [Activity(Label = "SpeakersActivity")]
    public class SpeakersActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            TextView textview = new TextView(this);
            textview.Text = "This is the My Schedule tab";
            SetContentView(textview);
            SetContentView(Resource.Layout.layout2);
        }
    }
}