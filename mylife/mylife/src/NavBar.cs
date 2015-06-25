using System;

using Xamarin.Forms;

namespace mylife.src
{
	public class NavBar : StackLayout
	{
		public NavBar ()
		{
			
			Orientation = StackOrientation.Horizontal;
			BackgroundColor = Color.FromRgb (100, 100, 100);
			Children.Add(new Button { Text = "Button", BackgroundColor = Color.FromRgb(255, 0, 0), HeightRequest = 10 });
			Children.Add(new Label { Text = "1", BackgroundColor = Color.FromRgb(0, 0, 255), HorizontalOptions = LayoutOptions.CenterAndExpand });
			Children.Add(new Label { Text = "mylife Software", BackgroundColor = Color.FromRgb(0, 255, 0), YAlign = TextAlignment.Center });
		}
	}
}

