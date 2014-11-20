using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turistv4.Model
{
    class Category
    {
        private string _catImg;
        private string _catName;

        public string CatImg
        {
            get { return _catImg; }
            set { _catImg = value; }
        }

        public string CatName
        {
            get { return _catName; }
            set { _catName = value; }
        }
    }
}
