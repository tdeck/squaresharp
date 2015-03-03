using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class Merchant
    {
        [DataContract]
        public struct PhoneNumber
        {
            [DataMember(Name = "calling_code")]
            public string callingCode;
            [DataMember]
            public string number;
        }

        [DataContract]
        public struct LocationDetails
        {
            [DataMember]
            public string nickname;
        }

        [DataMember]
        public string id;
        [DataMember]
        public string name;
        [DataMember]
        public string email;
        [DataMember(Name = "account_type")]
        public string accountType;
        [DataMember(Name = "account_capabilities")]
        public string[] accountCapabilities;
        [DataMember(Name = "country_code")]
        public string countryCode;
        [DataMember(Name = "language_code")]
        public string languageCode;
        [DataMember(Name = "currency_code")]
        public string currencyCode;
        [DataMember(Name = "business_name")]
        public string businessName;
        [DataMember(Name = "business_address")]
        public GlobalAddress businessAddress;
        [DataMember(Name = "business_phone")]
        public PhoneNumber businessPhone;
        [DataMember(Name = "shipping_address")]
        public GlobalAddress shippingAddress;
        [DataMember(Name = "location_details")]
        public LocationDetails locationDetails;
        [DataMember(Name = "market_url")]
        public string marketURL;
    }
}
