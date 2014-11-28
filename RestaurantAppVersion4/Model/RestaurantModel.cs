using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.StartScreen;
using Windows.UI.Xaml.Controls;
using RestaurantAppVersion4.Annotations;

namespace RestaurantAppVersion4.Model
{
    class RestaurantModel : INotifyPropertyChanged
    {
        private string _name;
        private string _priceClass;
        private string _adress;
        private string _openHours;
        private string _contact;
        private string _ImageUrl;
        private ObservableCollection<KommentarModel> _kommentarKatalog;
        private KommentarModel _selectedKommentar;

        public ObservableCollection<KommentarModel> KommentarKatalog
        {
            get { return _kommentarKatalog; }
            set { _kommentarKatalog = value; }
        }

        public KommentarModel SelectedKommentar
        {
            get { return _selectedKommentar; }
            set { _selectedKommentar = value; OnPropertyChanged("SelectedKommentar"); }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PriceClass
        {
            get { return _priceClass; }
            set { _priceClass = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public string OpenHours
        {
            get { return _openHours; }
            set { _openHours = value; }
        }

        public string Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        public string ImageURL
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }

        public RestaurantModel()
        {
            
            _kommentarKatalog = new ObservableCollection<KommentarModel>();
        
        }

        public void AddKommentarTwo(string text)
        {
            _kommentarKatalog.Add(new KommentarModel(1, text));
            OnPropertyChanged("KommentarKatalog");
        }

        public void Update()
        {
            OnPropertyChanged();
        }

        public override string ToString()
        {
            return string.Format(_name);
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
