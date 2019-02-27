using System;
using Xamarin.Forms;

namespace HelloGlide
{
	public partial class MainPage : ContentPage
	{
		readonly Uri uri = new Uri ("https://pbs.twimg.com/media/DZ_B8cEU8AASnUI.jpg");

		public MainPage ()
		{
			InitializeComponent ();

			for (int i = 0; i < 100; i++) {
				_grid.RowDefinitions.Add (new RowDefinition { Height = 100 });

				for (int j = 0; j < 4; j++) {
					var image = new Image {
						Source = ImageSource.FromUri (uri)
					};
					Grid.SetRow (image, i);
					Grid.SetColumn (image, j);
					_grid.Children.Add (image);
				}
			}
		}
	}
}
