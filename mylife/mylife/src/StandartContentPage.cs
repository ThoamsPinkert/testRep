using System;
using mylife.src.constants;

using Xamarin.Forms;

namespace mylife.src
{
	public class StandartContentPage : ContentPage
	{
		private AbsoluteLayout absoluteLayout;
		private StackLayout content;
		private StackLayout menu;
		private StackLayout navBar;
		private Button navButton;
		private Label navSeparator;
		private Label navLabel;

		public StandartContentPage ()
		{
			// set top Padding for iOS to +20
			Padding = new Thickness ( 
				ViewConstants.SIDE_PADDING, 
				ViewConstants.TOP_PADDING + Device.OnPlatform(20, 0, 0), 
				ViewConstants.SIDE_PADDING, 
				ViewConstants.TOP_PADDING);

			// white Background
			BackgroundColor = Color.FromRgb(255, 255, 255);

			navButton = new Button ();
			navButton.Text = "Button";
			navButton.BackgroundColor = Color.FromRgb (255, 0, 0);
			navButton.HeightRequest = 10;
			navButton.Clicked += OnMenuButtonClicked;

			navSeparator = new Label ();
			navSeparator.Text = "1";
			navSeparator.BackgroundColor = Color.FromRgb (0, 0, 255);
			navSeparator.HorizontalOptions = LayoutOptions.CenterAndExpand;

			navLabel = new Label ();
			navLabel.Text = "mylife Software";
			navLabel.BackgroundColor = Color.FromRgb (0, 255, 0);
			navLabel.YAlign = TextAlignment.Center;

			navBar = new StackLayout ();
			navBar.Orientation = StackOrientation.Horizontal;
			navBar.BackgroundColor = Color.FromRgb (100, 100, 100);
			navBar.Children.Add (navButton);
			navBar.Children.Add (navSeparator);
			navBar.Children.Add (navLabel);

			content = new StackLayout ();
			content.Children.Add (navBar);
			content.Children.Add (new Label { Text = "Greetings" });

			AbsoluteLayout.SetLayoutBounds (content, new Rectangle (0, 0, 1, 1));
			AbsoluteLayout.SetLayoutFlags (content, AbsoluteLayoutFlags.All);

			menu = new StackLayout ();
			menu.BackgroundColor = Color.FromRgba (100, 100, 100, 100);
			menu.Children.Add (new Label { Text = "Menu", BackgroundColor = Color.FromRgb(0,255,255) });
			menu.IsVisible = false;

			AbsoluteLayout.SetLayoutBounds (menu, new Rectangle (-ViewConstants.SIDE_PADDING, 100, 1.5, 1));
			AbsoluteLayout.SetLayoutFlags (menu, AbsoluteLayoutFlags.SizeProportional);

			absoluteLayout = new AbsoluteLayout ();
			absoluteLayout.Children.Add (content);
			absoluteLayout.Children.Add (menu);

			Content = absoluteLayout;

			/*Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};*/
		}

		void OnMenuButtonClicked (object sender, EventArgs args)
		{
			if (menu.IsVisible) {
				menu.IsVisible = false;
			} else {
				menu.IsVisible = true;
			}
		}
	}
}


