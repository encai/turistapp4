using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantAppVersion4.Model;

namespace RestaurantAppVersion4.ViewModel
{
    class SingletonViewModel
    {
        private static SingletonViewModel instance;
        private ObservableCollection<RestaurantModel> _restaurants;
        private ObservableCollection<KategoriModel> _kategorier;

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

        public SingletonViewModel()
        {
            _kategorier = new ObservableCollection<KategoriModel>();
            KategoriModel k1 = new KategoriModel() { ImageUrl = "/Assets/Fastfood.jpg", Name = "Fastfood", Restaurants = new List<RestaurantModel>() };
            KategoriModel k2 = new KategoriModel() { Name = "Familie", Restaurants = new List<RestaurantModel>() };
            KategoriModel k3 = new KategoriModel() { Name = "Fin", Restaurants = new List<RestaurantModel>() };
            _kategorier.Add(k1);
            _kategorier.Add(k2);
            _kategorier.Add(k3);

            //Oprettelse af restauranter:

            RestaurantModel r1 = new RestaurantModel() { ImageURL = "/Assets/jensens1.jpg", Adress = "Skomagergade 38, 4000 Roskilde", Contact = "46 32 25 10", Name = "Jensens Bøfhus", OpenHours = "Søndag-tosdag 11.00-22.00 \nFredag-Lørdag 11.00-23.00", PriceClass = "Normal" };
            RestaurantModel r2 = new RestaurantModel() { ImageURL = "/Assets/prindsen1.jpg", Adress = "Algade 13, 4000 Roskilde", Contact = "46 30 91 00", Name = "Hotel Prindsen", OpenHours = "24-timers åbent", PriceClass = "Dyr" };
            RestaurantModel r3 = new RestaurantModel() { ImageURL = "/Assets/prindsen1.jpg", Adress = "Algade 10 4000 Roskilde", Contact = "46 30 91 00", Name = "Sun Set", OpenHours = "24-timers åbent", PriceClass = "Billig" };
            RestaurantModel r4 = new RestaurantModel() { ImageURL = "/Assets/prindsen1.jpg", Adress = "Algade 12 4000 Roskilde", Contact = "46 30 91 00", Name = "Burger King", OpenHours = "24-timers åbent", PriceClass = "billig" };
            RestaurantModel r5 = new RestaurantModel() { ImageURL = "/Assets/prindsen1.jpg", Adress = "Algade 14, 4000 Roskilde", Contact = "46 30 91 00", Name = "Scandic", OpenHours = "24-timers åbent", PriceClass = "Dyr" };
            RestaurantModel r6 = new RestaurantModel() { ImageURL = "/Assets/prindsen1.jpg", Adress = "Algade 15, 4000 Roskilde", Contact = "46 30 91 00", Name = "Bones", OpenHours = "24-timers åbent", PriceClass = "Dyr" };
          
            Kategorier[1].Restaurants.Add(r1);
            Kategorier[1].Restaurants.Add(r6);
            Kategorier[2].Restaurants.Add(r2);
            Kategorier[2].Restaurants.Add(r5);
            Kategorier[3].Restaurants.Add(r3);
            Kategorier[3].Restaurants.Add(r4);
        }

        public static SingletonViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonViewModel();
                }
                return instance;
            }
        }

    }
}
