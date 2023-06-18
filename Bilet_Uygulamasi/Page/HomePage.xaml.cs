using Bilet_Uygulamasi.Entity;
using Bilet_Uygulamasi.Services;
using System.Windows.Input;

namespace Bilet_Uygulamasi.Page;

public partial class HomePage : ContentPage
{
   

    IVoyageService voyageService;
    public HomePage()
	{
		InitializeComponent();

        voyageService = new VoyageService();

     
    }
    private async void Add_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new VoyageAdd());
    }
    private async void Delete_Clicked(object sender, EventArgs e)
    {
        var sfr = await voyageService.GetVoyages();
        await Navigation.PushAsync(new VoyageDelete(sfr));
    }
    private async void Update_Clicked(object sender, EventArgs e)
    {
        var sfr = await voyageService.GetVoyages();
        await Navigation.PushAsync(new VoyageUpdate(sfr));
    }
    private async void Voyage_Clicked(object sender, EventArgs e)
    {
        var sfr =await voyageService.GetVoyages();
        await Navigation.PushAsync(new VoyagePage(sfr));
      
    }
    private async void Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new MainPage());
    }
}