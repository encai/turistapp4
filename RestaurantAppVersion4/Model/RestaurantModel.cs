using System;
using System.Collections.Generic;
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

        public override string ToString()
        {
            return Name.ToString();
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
