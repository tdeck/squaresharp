using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// A generic representation of a physical address.
    /// </summary>
    public class GlobalAddress
    {
        [DataContract]
        public struct Coordinates
        {
            [DataMember]
            public decimal latitude;
            [DataMember]
            public decimal longitude;
        }

        [DataMember(Name = "address_line_1")]
        /// <summary>
        /// The first line of the address. Fields that start with addressLine provide the address's most specific details, like street number, street name, and building name. They do not provide less specific details like city, state/province, or country (these details are provided in other fields).
        /// </summary>
        public string addressLine1;
        [DataMember(Name = "address_line_2")]
        /// <summary>
        /// The second line of the address, if any.
        /// </summary>
        public string addressLine2;
        [DataMember(Name = "address_line_3")]
        /// <summary>
        /// The third line of the address, if any.
        /// </summary>
        public string addressLine3;
        [DataMember(Name = "address_line_4")]
        /// <summary>
        /// The fourth line of the address, if any.
        /// </summary>
        public string addressLine4;
        [DataMember(Name = "address_line_5")]
        /// <summary>
        /// The fifth line of the address, if any.
        /// </summary>
        public string addressLine5;

        [DataMember]
        /// <summary>
        /// The city or town of the address.
        /// </summary>
        public string locality;
        [DataMember]
        /// <summary>
        /// A civil region within the address's locality, if any.
        /// </summary>
        public string sublocality;
        [DataMember(Name = "sublocality_1")]
        /// <summary>
        /// A civil region within the address's sublocality, if any.
        /// </summary>
        public string sublocality1;
        [DataMember(Name = "sublocality_2")]
        /// <summary>
        /// A civil region within the address's sublocality_1, if any.
        /// </summary>
        public string sublocality2;
        [DataMember(Name = "sublocality_3")]
        /// <summary>
        /// A civil region within the address's sublocality_2, if any.
        /// </summary>
        public string sublocality3;
        [DataMember(Name = "sublocality_4")]
        /// <summary>
        /// A civil region within the address's sublocality_3, if any.
        /// </summary>
        public string sublocality4;
        [DataMember(Name = "sublocality_5")]
        /// <summary>
        /// A civil region within the address's sublocality_4, if any.
        /// </summary>
        public string sublocality5;

        [DataMember(Name = "administrative_district_level_1")]
        /// <summary>
        /// A civil entity within the address's country. In the United States, this is the state.
        /// </summary>
        public string administrativeDistrictLevel1;
        [DataMember(Name = "administrative_district_level_2")]
        /// <summary>
        /// A civil entity within the address's administrativeDistrictLevel1, if any. In the United States, this is the county.
        /// </summary>
        public string administrativeDistrictLevel2;
        [DataMember(Name = "administrative_district_level_3")]
        /// <summary>
        /// A civil entity within the address's administrativeDistrictLevel2, if any.
        /// </summary>
        public string administrativeDistrictLevel3;

        [DataMember(Name = "postal_code")]
        /// <summary>
        /// The address's postal code.
        /// </summary>
        public string postalCode;
        [DataMember(Name = "country_code")]
        /// <summary>
        /// The address's country, in ISO 3166-1-alpha-2 format.
        /// </summary>
        public string countryCode;

        [DataMember(Name = "address_coordinates")]
        public Coordinates coordinates;
    }
}
