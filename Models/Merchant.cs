using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents a Square merchant.
    /// </summary>
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

        /// <summary>
        /// The merchant's unique identifier.
        /// </summary>
        [DataMember]
        public string id;

        /// <summary>
        /// The merchant's name.
        /// </summary>
        [DataMember]
        public string name;

        /// <summary>
        /// The merchant's email address.
        /// </summary>
        [DataMember]
        public string email;

        [DataMember(Name = "account_type")]
        public string accountType;
        [DataMember(Name = "account_capabilities")]
        public string[] accountCapabilities;
        /// <summary>
        /// The country associated with the merchant's account, in ISO 3166-1-alpha-2 format.
        /// </summary>
        [DataMember(Name = "country_code")]
        public string countryCode;

        /// <summary>
        /// The language associated with the merchant's account, in BCP 47 format.
        /// </summary>
        [DataMember(Name = "language_code")]
        public string languageCode;

        [DataMember(Name = "currency_code")]
        public string currencyCode;
        /// <summary>
        /// The name of the merchant's business.
        /// </summary>
        [DataMember(Name = "business_name")]
        public string businessName;

        /// <summary>
        /// The address of the merchant's business.
        /// </summary>
        [DataMember(Name = "business_address")]
        public GlobalAddress businessAddress;

        /// <summary>
        /// The phone number of the merchant's business.
        /// </summary>
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
