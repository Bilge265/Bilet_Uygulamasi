using Bilet_Uygulamasi.Entity;
using Bilet_Uygulamasi.Services;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bilet_Uygulamasi.Page
{
    public class VeriSilViewModel : INotifyPropertyChanged
    {

        IVoyageService voyageService;
       

        public VeriSilViewModel()
        {
            voyageService = new VoyageService();
            SilCommand = new Command<int>(Sil);
            
        }
       

        public Command<int> SilCommand { get; }
     
   

        private async void Sil(int veriId)
        {
            bool result = await App.Current.MainPage.DisplayAlert("Onay", "Silmek istediğinize emin misiniz?", "Evet", "Hayır");
            if (result)
            {
                if (int.TryParse(veriId.ToString(), out int id))
                {
                    await voyageService.Delete(id);
                   
                    await App.Current.MainPage.DisplayAlert("Başarılı", "Veri silindi.", "Tamam");
                    
                }
               
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
     
    }
}
