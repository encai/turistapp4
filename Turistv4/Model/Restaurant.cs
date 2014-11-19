using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turistv4.Model
{
    class Restaurant
    {
        private string _res_address;
        private string _res_phone;
        private string _res_mail;
        private string _res_image;
        private string _res_openhours_weekdays;
        private string _res_openhours_weekend;
        private string _res_Name;

        public string ResAddress
        {
            get { return _res_address; }
            set { _res_address = value; }
        }

        public string ResPhone
        {
            get { return _res_phone; }
            set { _res_phone = value; }
        }

        public string ResMail
        {
            get { return _res_mail; }
            set { _res_mail = value; }
        }

        public string ResOpenhoursWeekdays
        {
            get { return _res_openhours_weekdays; }
            set { _res_openhours_weekdays = value; }
        }

        public string ResImage
        {
            get { return _res_image; }
            set { _res_image = value; }
        }

        public string ResOpenhoursWeekend
        {
            get { return _res_openhours_weekend; }
            set { _res_openhours_weekend = value; }
        }

        public string ResName
        {
            get { return _res_Name; }
            set { _res_Name = value; }
        }
    }
}
