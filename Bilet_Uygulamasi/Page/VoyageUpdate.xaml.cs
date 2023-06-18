using Bilet_Uygulamasi.Entity;
using System.Collections.ObjectModel;

namespace Bilet_Uygulamasi.Page;

public partial class VoyageUpdate : ContentPage
{
    private List<Voyage> sfr;
    public VoyageUpdate(List<Voyage> sfr)
	{
		InitializeComponent();

        this.sfr = sfr;
        SeferlerList.ItemsSource = sfr;
    }
   
    private async void SeferlerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var seciliSefer = (Voyage)SeferlerList.SelectedItem;
        if (seciliSefer != null)
        {
            await Navigation.PushModalAsync(new UpdatePage(seciliSefer));
        }
    }
}