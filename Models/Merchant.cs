using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents a Square merchant.
    /// </summary>
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
        /// <summary>
        /// The merchant's unique identifier.
        /// </summary>
        public string id;
        [DataMember]
        /// <summary>
        /// The merchant's name.
        /// </summary>
        public string name;
        [DataMember]
        /// <summary>
        /// The merchant's email address.
        /// </summary>
        public string email;
        [DataMember(Name = "account_type")]
        public string accountType;
        [DataMember(Name = "account_capabilities")]
        public string[] accountCapabilities;
        [DataMember(Name = "country_code")]
        /// <summary>
        /// The country associated with the merchant's account, in ISO 3166-1-alpha-2 format.
        /// </summary>
        public string countryCode;
        [DataMember(Name = "language_code")]
        /// <summary>
        /// The language associated with the merchant's account, in BCP 47 format.
        /// </summary>
        public string languageCode;
        [DataMember(Name = "currency_code")]
        public string currencyCode;
        [DataMember(Name = "business_name")]
        /// <summary>
        /// The name of the merchant's business.
        /// </summary>
        public string businessName;
        [DataMember(Name = "business_address")]
        /// <summary>
        /// The address of the merchant's business.
        /// </summary>
        public GlobalAddress businessAddress;
        [DataMember(Name = "business_phone")]
        /// <summary>
        /// The phone number of the merchant's business.
        /// </summary>
        public PhoneNumber businessPhone;
        [DataMember(Name = "shipping_address")]
        public GlobalAddress shippingAddress;
        [DataMember(Name = "location_details")]
        public LocationDetails locationDetails;
        [DataMember(Name = "market_url")]
        public string marketURL;
    }
}
