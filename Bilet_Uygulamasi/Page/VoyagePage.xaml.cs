using Bilet_Uygulamasi.Entity;

namespace Bilet_Uygulamasi.Page;

public partial class VoyagePage : ContentPage
{
    private List<Voyage> sfr;

    public VoyagePage(List<Voyage> sfr)
	{
		InitializeComponent();
        this.sfr = sfr;

        SeferlerListView.ItemsSource = sfr;
    }

}