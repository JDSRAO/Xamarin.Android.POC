using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Reminder
{
    [Activity(Label = "Reminder", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            #region Widget Inititalization

            Button SaveReminder = FindViewById<Button>(Resource.Id.btn_Save);
            TimePicker ReminderTimePicker = FindViewById<TimePicker>(Resource.Id.tp_Date);
            TextView ReminderDescription = FindViewById<TextView>(Resource.Id.txtView_Description);

            #endregion


            #region Events

            SaveReminder.Click += SaveReminder_Click;
            
            #endregion

        }

        private void SaveReminder_Click(object sender, EventArgs e)
        {
            var callDialog = new AlertDialog.Builder(this);
            
            if (Reminder.Code.ReminderOperations.Save())
            {
                callDialog.SetMessage("Saved Successfully");
                callDialog.SetNeutralButton("Call", delegate {    });
                callDialog.SetNegativeButton("Cancel", delegate { });

                // Show the alert dialog to the user and wait for response.
                callDialog.Show();
            }
            else
            {
                callDialog.SetMessage("Error while saving");
                callDialog.SetNeutralButton("Call", delegate { });
                callDialog.SetNegativeButton("Cancel", delegate { });

                // Show the alert dialog to the user and wait for response.
                callDialog.Show();
            }

        }
    }
}

