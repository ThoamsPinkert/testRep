using System;

using Xamarin.Forms;

namespace mylife.src
{
	public class MFContentPage : WhiteContentPage
	{
		public MFContentPage () : base()
		{
			Content = new StackLayout { 
				Children = {

					new NavBar(),

					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


