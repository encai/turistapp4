using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAppVersion4.Model
{
    class KategoriModel : INotifyCollectionChanged
    {
        private List<RestaurantModel> _restaurants;
        private string _name;
        private string _imageUrl;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<RestaurantModel> Restaurants
        {
            get { return _restaurants; }
            set { _restaurants = value; }
        }
        public override string ToString()
        {
            return _name.ToString();
        }

        public string ImageUrl
        {
            get { return _imageUrl; }
            set { _imageUrl = value; }
        }

       



        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
