namespace AppCompactApp.Services.Binders
{
    using Android.App;
    using Android.Content;
    using Android.OS;
    using Android.Runtime;
    using Android.Views;
    using Android.Widget;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TimestampBinder : Binder
    {
        public TimestampBinder(SampleService service)
        {
            this.Service = service;
        }

        public SampleService Service { get; private set; }
    }
}