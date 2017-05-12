namespace AppCompactApp.Services.Conections
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

    public class TimestampServiceConnection : Java.Lang.Object, IServiceConnection
    {
        static readonly string TAG = typeof(TimestampServiceConnection).FullName;

        public bool IsConnected { get; private set; }

        public TimestampBinder Binder { get; private set; }

        public TimestampServiceConnection()
        {
            IsConnected = false;
            Binder = null;
        }

        public void OnServiceConnected(ComponentName name, IBinder binder)
        {
            Binder = binder as TimestampBinder;
            IsConnected = Binder != null;
            Log.Debug(TAG, $"OnServiceConnected {name.ClassName}");
        }

        public void OnServiceDisconnected(ComponentName name)
        {
            Log.Debug(TAG, $"OnServiceDisconnected {name.ClassName}");
            IsConnected = false;
            Binder = null;
        }
    }
}