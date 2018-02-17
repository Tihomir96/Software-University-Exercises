using System;

namespace _4.Telephony
{
    public class Smartphone:IPhone
    {
        
        private string phoneNumber;

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                foreach (var character in value)
                {
                    if (char.IsLetter(character))
                    {
                        throw new ArgumentException("Invalid number!");
                    }
                }
                this.phoneNumber = value;
            }
        }
        public string Calling(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
            return $"Calling... {this.PhoneNumber}";
        }

        private string siteUrl;

        public string SiteUrl
        {
            get { return this.siteUrl; }
            set
            {
                foreach (var character in value)
                {
                    if (char.IsDigit(character))
                    {
                        throw new ArgumentException("Invalid URL!");
                    }
                }
                this.siteUrl = value;
            }
        }

        public string Browsing(string siteUrl)
        {
            this.SiteUrl = siteUrl;
            return $"Browsing: {this.SiteUrl}!";
        }

    }
}
