using Bilet_Uygulamasi.Entity;
using Bilet_Uygulamasi.Services;

namespace Bilet_Uygulamasi.Page;

public partial class VoyageAdd : ContentPage
{
    IVoyageService voyageService;
    public VoyageAdd()
	{
		InitializeComponent();
        voyageService = new VoyageService();
    }
    private DateTime selectedDate;
    
    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        selectedDate = e.NewDate;
    }
    private async void btnKaydet_Clicked(object sender, EventArgs e)
    {
        var priceText = FiyatEkle.Text;
        if (int.TryParse(priceText, out int price))
        {
            TimeSpan selectedTime = TimePicker.Time;
            DateTime today = DateTime.Today;
            DateTime selectedDateTime = today.Date + selectedTime;

            var voyage = new Voyage()
            {
                Date = selectedDate,
                DeparturePoint = KalkisYeri.SelectedItem.ToString(),
                Destination = VarisYeri.SelectedItem.ToString(),
                Time = selectedDateTime,
                Price = price,
                AddDate= DateTime.Now

            };

            await voyageService.Add(voyage);

            await DisplayAlert("Mesaj", "Sefer Eklendi!", "Tamam");
            KalkisYeri.SelectedItem = null;
            VarisYeri.SelectedItem = null;
            TimePicker.Time = new TimeSpan(0, 0, 0);
            FiyatEkle.Text = string.Empty;

        }
       
        else
        {
            await DisplayAlert("Hata", "Geçersiz fiyat giriþi!", "Tamam");
        }
       
    }
}