namespace JoseCerezoTallerEnClase
{
    public partial class GridLayoutPage : ContentPage
    {
        public GridLayoutPage()
        {
            InitializeComponent();
        }

		private async void Button_Clicked(object sender, EventArgs e)
		{
            await Navigation.PushAsync(new StackLayoutPage());
		}
	}
}
