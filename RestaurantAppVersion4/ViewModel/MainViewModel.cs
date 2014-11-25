using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RestaurantAppVersion4.Annotations;
using RestaurantAppVersion4.Model;

namespace RestaurantAppVersion4.Model
{
    class MainViewModel : INotifyPropertyChanged
    {
        
        private ObservableCollection<RestaurantModel> _restaurants;
        private RestaurantModel _selectedResaurant;
        private ObservableCollection<KategoriModel> _kategorier;
        private KategoriModel _selectedKategori;

        public RestaurantModel SelectedResaurant
        {
            get { return _selectedResaurant; }
            set { _selectedResaurant = value; OnPropertyChanged("SelectedResaurant");}
        }

        public KategoriModel SelectedKategori
        {
            get { return _selectedKategori; }
            set { _selectedKategori = value; OnPropertyChanged("SelectedKategori");}
        }

        public ObservableCollection<RestaurantModel> Restaurants
        {
            get { return _restaurants; }
            set { _restaurants = value; }
        }

        public ObservableCollection<KategoriModel> Kategorier
        {
            get { return _kategorier; }
            set { _kategorier = value; }
        }

        public MainViewModel()
        {
            //Oprettelse af kategorier:

            _kategorier = new ObservableCollection<KategoriModel>();
            KategoriModel k1 = new KategoriModel() {ImageUrl = "/Assets/Fastfood.jpg", Name = "Fastfood", Restaurants = new List<RestaurantModel>()};
            KategoriModel k2 = new KategoriModel() {Name = "Familie", Restaurants = new List<RestaurantModel>()};
            KategoriModel k3 = new KategoriModel(){Name = "Fin", Restaurants = new List<RestaurantModel>()};
            _kategorier.Add(k1);
            _kategorier.Add(k2);
            _kategorier.Add(k3);

            //Oprettelse af restauranter:

            RestaurantModel r1 = new RestaurantModel(){ImageURL = "/Assets/jensens1.jpg", Adress = "Skomagergade 38, 4000 Roskilde", Contact = "46 32 25 10", Name = "Jensens Bøfhus", OpenHours = "Søndag-tosdag 11.00-22.00 \nFredag-Lørdag 11.00-23.00", PriceClass = "Normal"};
            RestaurantModel r2 = new RestaurantModel(){ImageURL = "/Assets/prindsen1.jpg", Adress = "Algade 13, 4000 Roskilde", Contact = "46 30 91 00", Name = "Hotel Prindsen", OpenHours = "24-timers åbent", PriceClass = "Dyr"};

            Kategorier[1].Restaurants.Add(r1);
            Kategorier[2].Restaurants.Add(r2);
        }
        #region Propertychanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
