using System;
using Xamarin.Forms;
using System.Threading.Tasks;
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

			Entry entry = new Entry { 
				Placeholder = "username",
				VerticalOptions = LayoutOptions.Center,
				Keyboard = Keyboard.Text                               
			};

			BoxView boxView = new BoxView { 
				Color = Color.Silver,
				WidthRequest = 150,
				HeightRequest = 150,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.Fill
			};

			Image image = new Image {
				Source = "monkey.jpg",
				Aspect = Aspect.AspectFit,
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Fill
			};

			var tapRecognizer = new TapGestureRecognizer();
			tapRecognizer.Tapped += async (sender, e) => {
				image.Opacity = 0.5;
				await Task.Delay(200);
				image.Opacity = 1;
			};

			image.GestureRecognizers.Add(tapRecognizer);

			StackLayout stackLayout = new StackLayout
			{
				Children = {
					labelLarge,
					labelSmall,
					button,
					entry,
					boxView,
					image
				},
				HeightRequest = 1500
			};

			ScrollView scrollView = new ScrollView
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				Content = stackLayout
			};

			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
			this.Content = scrollView;
		}

		void Button_Clicked(object sender, EventArgs e)
		{
			((Button)sender).Text = "It is so!";
		}
	}
}
