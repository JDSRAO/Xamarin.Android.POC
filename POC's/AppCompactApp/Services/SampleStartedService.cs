/// <summary>
/// Started service example
/// </summary>
namespace AppCompactApp.Services
{
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

    [Service]
    public class SampleStartedService : Service
    {
        private static Notification.Builder builder;
        private static NotificationManager notificationManager;
        private static Notification notification;
        private static readonly int notificationId = 1;

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        [return: GeneratedEnum]
        public override StartCommandResult OnStartCommand(Intent intent, [GeneratedEnum] StartCommandFlags flags, int startId)
        {
            ShowNotification("Service Started", "Sample service", notificationId);
            //return base.OnStartCommand(intent, flags, startId);
            return StartCommandResult.Sticky;
        }

        private void ShowNotification(string title,string message, int notificationId)
        {
            Notification notification = CreateNotification(title, message);
            notificationManager = GetSystemService(Context.NotificationService) as NotificationManager;
            notificationManager.Notify(notificationId, notification);
        }

        private Notification CreateNotification(string title, string message)
        {
            builder = new Notification.Builder(this);
            builder.SetContentTitle(title);
            builder.SetContentText(message);
            
            //builder.SetContentIntent(intent);
            //builder.SetSmallIcon(smallIcon);
            notification = builder.Build();
            return notification;
        }

        private Notification UpdateNotification(Notification.Builder builder, string title, string message)
        {
            if (builder != null)
            {
                // Update the existing notification builder content:
                builder.SetContentTitle("Updated Notification");
                builder.SetContentText("Changed to this message.");

                // Build a notification object with updated content:
                notification = builder.Build();
                return notification;
            }
            return null;
        }
    }
}