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
        private ObservableCollection<KommentarModel> _kommentars;

        public string ComText
        {
            get { return _comText; }
            set { _comText = value; }
        }

        public OpretKommentarHandler(ObservableCollection<KommentarModel> kommentars)
        {
            _kommentars = kommentars;
        }

    }
}
