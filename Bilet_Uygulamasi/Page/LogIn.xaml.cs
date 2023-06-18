namespace Bilet_Uygulamasi.Page;

public partial class LogIn : ContentPage
{
	public LogIn()
	{
		InitializeComponent();
	}
    private async void Home_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new HomePage());
    }
}