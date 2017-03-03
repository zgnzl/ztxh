using System;

namespace _69zg.Models
{
    public class Users
    {
        private string uid;
        private string uname;
        private string urealname;
        private string utel;
        private string uemai;
        private string uaddr;
        private DateTime ulogdate;

        public string Uname
        {
            get
            {
                return uname;
            }

            set
            {
                uname = value;
            }
        }

        public string Urealname
        {
            get
            {
                return urealname;
            }

            set
            {
                urealname = value;
            }
        }

        public string Utel
        {
            get
            {
                return utel;
            }

            set
            {
                utel = value;
            }
        }

        public string Uemai
        {
            get
            {
                return uemai;
            }

            set
            {
                uemai = value;
            }
        }

        public string Uaddr
        {
            get
            {
                return uaddr;
            }

            set
            {
                uaddr = value;
            }
        }

        public DateTime Ulogdate
        {
            get
            {
                return ulogdate;
            }

            set
            {
                ulogdate = value;
            }
        }

        public string Uid
        {
            get
            {
                return uid;
            }

            set
            {
                uid = value;
            }
        }
    }
}