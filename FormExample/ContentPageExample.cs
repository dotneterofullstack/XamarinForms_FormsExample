using System;
using Xamarin.Forms;
namespace FormExample
{
	public class ContentPageExample : ContentPage
	{
		public ContentPageExample()
		{
			Label labelLarge = new Label { 
				Text = "Label",
				FontSize = 40,
				HorizontalOptions = LayoutOptions.Center
			};

			Label labelSmall = new Label
			{
				Text = "This control is great for\n" +
					"displaying one or more\n" +
					"lines of text.",
				FontSize = 20,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			Button button = new Button
			{
				Text = "Make it so",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Fill
			};

			button.Clicked += Button_Clicked;

			StackLayout stackLayout = new StackLayout
			{
				Children = {
					labelLarge,
					labelSmall,
					button
				},
				HeightRequest = 1500
			};

			this.Content = stackLayout;
		}

		void Button_Clicked(object sender, EventArgs e)
		{
			((Button)sender).Text = "It is so!";
		}
	}
}
