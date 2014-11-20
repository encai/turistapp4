using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turistv4.Model
{
    class Menu
    {
        private string _MenuName;
        private string _MenuPrice;
        private string _MenuInfo;
        private string _menuImage;

        public string MenuName
        {
            get { return _MenuName; }
            set { _MenuName = value; }
        }

        public string MenuPrice
        {
            get { return _MenuPrice; }
            set { _MenuPrice = value; }
        }

        public string MenuInfo
        {
            get { return _MenuInfo; }
            set { _MenuInfo = value; }
        }

        public string MenuImage
        {
            get { return _menuImage; }
            set { _menuImage = value; }
        }
    }
}
