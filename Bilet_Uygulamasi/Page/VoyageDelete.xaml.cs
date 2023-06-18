using Bilet_Uygulamasi.Entity;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bilet_Uygulamasi.Page;

public partial class VoyageDelete : ContentPage
{
    private List<Voyage> sfr;
    private VeriSilViewModel viewModel;

    public VoyageDelete(List<Voyage> sfr)
	{
		InitializeComponent();
        viewModel = new VeriSilViewModel();
        BindingContext = viewModel;

        this.sfr = sfr;
        SeferlerList.ItemsSource = sfr;
    }

    private void SilButton_Clicked(object sender, EventArgs e)
    {
        var veriId = ((Button)sender).CommandParameter;
        viewModel.SilCommand.Execute(veriId);
    }
   
}
