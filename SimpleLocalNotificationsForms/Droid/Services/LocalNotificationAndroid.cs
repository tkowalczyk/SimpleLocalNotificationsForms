using System;
using SimpleLocalNotificationsForms.Droid;
using Android.App;
using Android.Content;

[assembly: Xamarin.Forms.Dependency (typeof (LocalNotificationAndroid))]
namespace SimpleLocalNotificationsForms.Droid
{
	public class LocalNotificationAndroid : ILocalNotifications
	{
		public LocalNotificationAndroid ()
		{
		}

		#region ILocalNotifications implementation

		public void SendLocalNotification (string title, string description, int iconID)
		{
			// Instantiate the builder and set notification elements:
			Notification.Builder builder = new Notification.Builder (Application.Context)
				.SetContentTitle (title)
				.SetContentText (description)
				.SetSmallIcon (Resource.Drawable.icon);

			// Build the notification:
			Notification notification = builder.Build();

			// Get the notification manager:
			NotificationManager notificationManager =
				Application.Context.GetSystemService (Context.NotificationService) as NotificationManager;

			// Publish the notification:
			const int notificationId = 0;
			notificationManager.Notify (notificationId, notification);
		}

		#endregion
	}
}