using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAppVersion4.Model
{
   public class Comment : INotifyPropertyChanged
    {
        private int _comRating;
        private string _comText;

        public Comment(int comRating, string comText)
        {
            _comText = comText;
            _comRating = comRating;
        }

        #region text
        public string ComText
        {
            get { return _comText; }
            set
            {
                text_length(value);
                _comText = value;
            }
        }
        private static void text_length(string value)
        {
            if (value.Length >= 10 || value.Length <= 200)
            {
                throw new ArgumentException("Comment skal være mellem 10 og 200 tegn");
            }
        }
        #endregion

        #region rating
        public int ComRating
        {
            get { return _comRating; }
            set
            {
                rating_value(value);
                _comRating = value;
            }
        }


        private static void rating_value(int value)
        {
            if (value <= 0 || 5 <= value)
            {
                throw new ArgumentException("rating skal være mellem  0 og 5");
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
