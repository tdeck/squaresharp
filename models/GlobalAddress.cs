[DataContract]
public class GlobalAddress
{
    [DataContract]
    public static struct Coordinates
    {
        [DataMember]
        public decimal latitude;
        [DataMember]
        public decimal longitude;
    }

    // TODO maybe shove these into an array?
    [DataMember(Name="address_line_1")]
    public string addressLine1;
    [DataMember(Name="address_line_2")]
    public string addressLine2;
    [DataMember(Name="address_line_3")]
    public string addressLine3;
    [DataMember(Name="address_line_4")]
    public string addressLine4;
    [DataMember(Name="address_line_5")]
    public string addressLine5;

    [DataMember]
    public string locality;
    [DataMember]
    public string sublocality;
    [DataMember(Name="sublocality_1")]
    public string sublocality1;
    [DataMember(Name="sublocality_2")]
    public string sublocality2;
    [DataMember(Name="sublocality_3")]
    public string sublocality3;
    [DataMember(Name="sublocality_4")]
    public string sublocality4;
    [DataMember(Name="sublocality_5")]
    public string sublocality5;

    [DataMember(Name="administrative_district_level_1")]
    public string administrativeDistrictLevel1;
    [DataMember(Name="administrative_district_level_2")]
    public string administrativeDistrictLevel2;
    [DataMember(Name="administrative_district_level_3")]
    public string administrativeDistrictLevel3;

    [DataMember(Name="postal_code")]
    public string postalCode;
    [DataMember(Name="country_code")]
    public string countryCode;
    
    [DataMember(Name="address_coordinates")]
    public Coordinates coordinates;
}
