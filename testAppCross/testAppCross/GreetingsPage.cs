using System;

using Xamarin.Forms;

namespace testAppCross
{
	public class GreetingsPage : ContentPage
	{
		public GreetingsPage ()
		{
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);

			Label label = new Label ();
			label.Text = "Greetings, Xamarin Forms!";

			this.Content = label;

			/*Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};*/
		}
	}
}


