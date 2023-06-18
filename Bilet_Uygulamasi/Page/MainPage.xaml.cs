using Bilet_Uygulamasi.Page;

namespace Bilet_Uygulamasi;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void LogIn_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new LogIn());
    }
}

