using System;
using Xamarin.Forms;

namespace SimpleLocalNotificationsForms
{
	public class MainView : ContentPage
	{
		public MainView ()
		{
			Button sendLocalNotificaionButton = new Button () 
			{
				Text = "Notify me!",
			};

			sendLocalNotificaionButton.Clicked += (sender, e) => 
			{
				DependencyService.Get<ILocalNotifications>().SendLocalNotification(
					"Notification title",
					"Notification content / description",
					0
				);
			};

			StackLayout layout = new StackLayout () 
			{
				VerticalOptions = LayoutOptions.Center,
				Children = {
					sendLocalNotificaionButton
				}
			};

			this.Content = layout;
		}
	}
}