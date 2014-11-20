using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turistv4.Model
{
    class Restaurant
    {
        private string _resAddress;
        private string _resPhone;
        private string _resMail;
        private string _resImage;
        private string _resOpenhoursWeekdays;
        private string _resOpenhoursWeekend;
        private string _resName;

        public string ResAddress
        {
            get { return _resAddress; }
            set { _resAddress = value; }
        }

        public string ResPhone
        {
            get { return _resPhone; }
            set { _resPhone = value; }
        }

        public string ResMail
        {
            get { return _resMail; }
            set { _resMail = value; }
        }

        public string ResOpenhoursWeekdays
        {
            get { return _resOpenhoursWeekdays; }
            set { _resOpenhoursWeekdays = value; }
        }

        public string ResImage
        {
            get { return _resImage; }
            set { _resImage = value; }
        }

        public string ResOpenhoursWeekend
        {
            get { return _resOpenhoursWeekend; }
            set { _resOpenhoursWeekend = value; }
        }

        public string ResName
        {
            get { return _resName; }
            set { _resName = value; }
        }
    }
}
