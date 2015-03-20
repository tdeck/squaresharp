using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// A generic representation of a physical address.
    /// </summary>
    [DataContract]
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

        /// <summary>
        /// The first line of the address. Fields that start with addressLine provide the address's most specific details, like street number, street name, and building name. They do not provide less specific details like city, state/province, or country (these details are provided in other fields).
        /// </summary>
        [DataMember(Name = "address_line_1")]
        public string addressLine1;

        /// <summary>
        /// The second line of the address, if any.
        /// </summary>
        [DataMember(Name = "address_line_2")]
        public string addressLine2;

        /// <summary>
        /// The third line of the address, if any.
        /// </summary>
        [DataMember(Name = "address_line_3")]
        public string addressLine3;

        /// <summary>
        /// The fourth line of the address, if any.
        /// </summary>
        [DataMember(Name = "address_line_4")]
        public string addressLine4;

        /// <summary>
        /// The fifth line of the address, if any.
        /// </summary>
        [DataMember(Name = "address_line_5")]
        public string addressLine5;

        /// <summary>
        /// The city or town of the address.
        /// </summary>
        [DataMember]
        public string locality;

        /// <summary>
        /// A civil region within the address's locality, if any.
        /// </summary>
        [DataMember]
        public string sublocality;

        /// <summary>
        /// A civil region within the address's sublocality, if any.
        /// </summary>
        [DataMember(Name = "sublocality_1")]
        public string sublocality1;

        /// <summary>
        /// A civil region within the address's sublocality_1, if any.
        /// </summary>
        [DataMember(Name = "sublocality_2")]
        public string sublocality2;

        /// <summary>
        /// A civil region within the address's sublocality_2, if any.
        /// </summary>
        [DataMember(Name = "sublocality_3")]
        public string sublocality3;

        /// <summary>
        /// A civil region within the address's sublocality_3, if any.
        /// </summary>
        [DataMember(Name = "sublocality_4")]
        public string sublocality4;

        /// <summary>
        /// A civil region within the address's sublocality_4, if any.
        /// </summary>
        [DataMember(Name = "sublocality_5")]
        public string sublocality5;

        /// <summary>
        /// A civil entity within the address's country. In the United States, this is the state.
        /// </summary>
        [DataMember(Name = "administrative_district_level_1")]
        public string administrativeDistrictLevel1;

        /// <summary>
        /// A civil entity within the address's administrativeDistrictLevel1, if any. In the United States, this is the county.
        /// </summary>
        [DataMember(Name = "administrative_district_level_2")]
        public string administrativeDistrictLevel2;

        /// <summary>
        /// A civil entity within the address's administrativeDistrictLevel2, if any.
        /// </summary>
        [DataMember(Name = "administrative_district_level_3")]
        public string administrativeDistrictLevel3;

        /// <summary>
        /// The address's postal code.
        /// </summary>
        [DataMember(Name = "postal_code")]
        public string postalCode;

        /// <summary>
        /// The address's country, in ISO 3166-1-alpha-2 format.
        /// </summary>
        [DataMember(Name = "country_code")]
        public string countryCode;

        [DataMember(Name = "address_coordinates")]
        public Coordinates coordinates;
    }
}
