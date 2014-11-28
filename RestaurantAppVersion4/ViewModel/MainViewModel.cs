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

namespace RestaurantAppVersion4.ViewModel
{ 
    class MainViewModel : INotifyPropertyChanged
    {
        
        private RestaurantModel _selectedResaurant;
        private KategoriModel _selectedKategori;
        private SingletonViewModel _restaurants = SingletonViewModel.Instance;
        private SingletonViewModel _kategorier = SingletonViewModel.Instance;

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
            get { return _restaurants.Restaurants; }
            set { _restaurants.Restaurants = value; OnPropertyChanged("Restaurants"); }
        }

        public ObservableCollection<KategoriModel> Kategorier
        {
            get { return _kategorier.Kategorier; }
            set { _kategorier.Kategorier = value; OnPropertyChanged("Kategorier"); }
        }

        public MainViewModel()
        {    
        }

        public override string ToString()
        {
            return string.Format(_selectedResaurant.Name);
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
