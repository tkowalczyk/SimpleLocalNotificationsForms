using System;

namespace SimpleLocalNotificationsForms
{
	public interface ILocalNotifications
	{
		void SendLocalNotification(string title, string description, int iconID);
	}
}