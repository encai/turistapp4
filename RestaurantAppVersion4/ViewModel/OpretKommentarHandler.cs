using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantAppVersion4.Model;

namespace RestaurantAppVersion4.ViewModel
{
    class OpretKommentarHandler
    {
        private string _comText;
  
        public static async void SavePersonsAsync()
        {
            PersistenceFacade.SavePersonsAsJsonAsync(RestaurantModel.KommentarKatalog);
        }

        public static async void LoadPersonsAsync()
        {
            List<KommentarModel> kommentars = await PersistenceFacade.LoadPersonsFromJsonAsync();
            RestaurantModel.KommentarKatalog.Clear();
            foreach (var kommentar in kommentars)
            {
                RestaurantModel.KommentarKatalog.Add(kommentar);
            }
        }
        
        public string ComText
        {
            get { return _comText; }
            set { _comText = value; }
        }
    }
}
