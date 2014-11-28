using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RestaurantAppVersion4.Annotations;

namespace RestaurantAppVersion4.Model
{
   public class KommentarModel : INotifyPropertyChanged
    {
        private string _comText;
        private int _comRating;

        public KommentarModel(int comRating, string comText)
        {
            _comRating = comRating;
            _comText = comText;
        }

        public string ComText
        {
            get { return _comText; }
            set
            {
                text_length(value);
                _comText = value;
            }
        }

        public int ComRating
        {
            get { return _comRating; }
            set
            {
                rating_value(value);
                _comRating = value;
            }
        }

        private static void text_length(string value)
        {
            if (value.Length >= 10 || value.Length <= 200)
            {
                throw new ArgumentException("Comment skal være mellem 10 og 200 tegn");
            }
        }

        private static void rating_value(int value)
        {
            if (value <= 0 || 5 <= value)
            {
                throw new ArgumentException("rating skal være mellem  0 og 5");
            }
        }

        public override string ToString()
        {
            return string.Format(_comText);
        }

        #region PorpertyChanged

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
