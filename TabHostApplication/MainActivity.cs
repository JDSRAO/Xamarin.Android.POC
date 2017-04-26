using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TabHostApplication
{
    [Activity(MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : TabActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            CreateTab(typeof(WhatsOnActivity), "whats_on", "What's On", Resource.Drawable.Icon);
            CreateTab(typeof(SpeakersActivity), "speakers", "Speakers", Resource.Drawable.Icon);
            CreateTab(typeof(SessionsActivity), "sessions", "Sessions", Resource.Drawable.Icon);
            CreateTab(typeof(MyScheduleActivity), "my_schedule", "My Schedule", Resource.Drawable.Icon);

        }

        private void CreateTab(Type activityType, string tag, string label, int drawableId)
        {
            var intent = new Intent(this, activityType);
            intent.AddFlags(ActivityFlags.NewTask);

            var spec = TabHost.NewTabSpec(tag);
            //var drawableIcon = Resource.Drawable.(drawableId);
            //spec.SetIndicator(label, drawableIcon);
            spec.SetIndicator(label);
            spec.SetContent(intent);

            TabHost.AddTab(spec);
        }
    }
}

