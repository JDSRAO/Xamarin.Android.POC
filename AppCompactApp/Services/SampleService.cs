namespace AppCompactApp.Services
{
    using Android.App;
    using Android.Content;
    using Android.OS;
    using Android.Runtime;
    using Android.Util;
    using Android.Views;
    using Android.Widget;
    using AppCompactApp.Services.Binders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [Service]
    public class SampleService : Service
    {
        static readonly string TAG = typeof(SampleService).FullName;
        //IGetTimestamp timestamper;

        public override void OnCreate()
        {
            // This method is optional, perform any initialization here.
            base.OnCreate();
            Log.Debug(TAG, "OnCreate");
            //timestamper = new UtcTimestamper();
        }

        public override IBinder OnBind(Intent intent)
        {
            Log.Debug(TAG, "OnBind");
            return new TimestampBinder(this);
        }

        public override bool OnUnbind(Intent intent)
        {
            // This method is optional
            Log.Debug(TAG, "OnUnbind");
            return base.OnUnbind(intent);
        }

        public override void OnDestroy()
        {
            // This method is optional
            Log.Debug(TAG, "OnDestroy");
            //timestamper = null;
            base.OnDestroy();
        }

        public string GetTimestamp()
        {
            return "";
            //return timestamper?.GetFormattedTimestamp();
        }
    }
}