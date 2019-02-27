using System;
using Xamarin.Forms;

namespace HelloGlide
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			var uri = new Uri("https://pbs.twimg.com/media/DZ_B8cEU8AASnUI.jpg");
			for (var i = 0; i < 100; i++)
			{
				MainGrid.RowDefinitions.Add(new RowDefinition { Height = 100 });

				for (var j = 0; j < 4; j++)
				{
					var image = new Image
					{
						Source = ImageSource.FromUri(uri)
					};
					Grid.SetRow(image, i);
					Grid.SetColumn(image, j);
					MainGrid.Children.Add(image);
				}
			}
		}
	}
}
