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

namespace Reminder
{
    [Activity(Label = "ShowReminder")]
    public class ShowReminderActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ShowReminder);
            // Create your application here

            //Intent passedIntent = getIntent();
            //Reminder.Code.Reminder my_class = (Reminder.Code.Reminder)passedIntent.getSerializableExtra("mu");

            string text = Intent.GetStringExtra("reminderValue") ?? "Data not available";
           // Intent passedinte = new Intent();
           //var a = passedinte.GetSerializableExtra("ListData");
        }
    }
}