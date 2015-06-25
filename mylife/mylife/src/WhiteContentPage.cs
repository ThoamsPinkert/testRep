using System;

using mylife.src.constants;

using Xamarin.Forms;

namespace mylife.src
{
	public class WhiteContentPage : ContentPage
	{
		public WhiteContentPage ()
		{
			// set top Padding for iOS to +20
			Padding = new Thickness ( 
				ViewConstants.SIDE_PADDING, 
				ViewConstants.TOP_PADDING + Device.OnPlatform(20, 0, 0), 
				ViewConstants.SIDE_PADDING, 
				ViewConstants.TOP_PADDING);

			// white Background
			BackgroundColor = Color.FromRgb(255, 255, 255);

			/*Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};*/
		}
	}
}


