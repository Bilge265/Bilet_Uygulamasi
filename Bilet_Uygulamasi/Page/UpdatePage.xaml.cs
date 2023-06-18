using Bilet_Uygulamasi.Entity;

namespace Bilet_Uygulamasi.Page;

public partial class UpdatePage : ContentPage
{
    private Voyage seciliSefer;

    public UpdatePage(Voyage seciliSefer)
	{
		InitializeComponent();
        this.seciliSefer = seciliSefer;
      
    }

    private async void btnGeri_Clicked(object sender, EventArgs e)
    {

        await Navigation.PopModalAsync();
    }
}