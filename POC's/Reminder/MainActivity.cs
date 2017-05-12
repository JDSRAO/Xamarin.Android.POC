using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Reminder
{
    [Activity(Label = "Reminder", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        
        #region Widget Initilization

        Button SaveReminder { get; set; }
        TimePicker ReminderTimePicker { get; set; }
        TextView lbl_ReminderDescription { get; set; }
        List<Reminder.Code.Reminder> reminderList { get; set; }
        EditText ReminderDescription { get; set; }
        DatePicker SelectedDate { get; set; }

        #endregion

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

           
            SetContentView(Resource.Layout.Main);

           
            #region Widget Declaration

            SaveReminder = FindViewById<Button>(Resource.Id.btn_Save);
            ReminderTimePicker = FindViewById<TimePicker>(Resource.Id.tp_Date);
            lbl_ReminderDescription = FindViewById<TextView>(Resource.Id.txtView_Description);
            reminderList = new List<Code.Reminder>();
            ReminderDescription = FindViewById<EditText>(Resource.Id.et_Description);
            SelectedDate = FindViewById<DatePicker>(Resource.Id.dp_SelectedDate);

            #endregion

            #region Events

            SaveReminder.Click += SaveReminder_Click;
            
            #endregion

        }

        private void SaveReminder_Click(object sender, EventArgs e)
        {
            var callDialog = new AlertDialog.Builder(this);
            Code.Reminder _reminderData = new Code.Reminder();

           _reminderData.Description = lbl_ReminderDescription.Text;
           _reminderData.Time = Convert.ToDateTime(String.Format
               (
               "{0}:{1}",
               ReminderTimePicker.CurrentHour, 
               ReminderTimePicker.CurrentMinute
               ));
            _reminderData.Date = Convert.ToDateTime(SelectedDate.DateTime);
            reminderList.Add(_reminderData);
            string json = JsonConvert.SerializeObject(_reminderData);
            
            ////MyData tmp = JsonConvert.DeserializeObject<MyData>(json);
            callDialog.SetMessage("Saved Successfully");
            callDialog.SetNeutralButton("Call", delegate {
                Intent intent = new Intent(this, typeof(ShowReminderActivity));
                //Bundle b = new Bundle();
                //b.PutSerializable("ListData", _reminderData);
                intent.PutExtra("reminderValue",json);
                StartActivity(intent);
            });

            callDialog.SetNegativeButton("Cancel", delegate { });

            // Show the alert dialog to the user and wait for response.
            callDialog.Show();
                

        }

    }
}

