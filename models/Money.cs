[DataContract]
public class Money
{
    [DataMember]
    public decimal amount;    
    [DatMember(Name="currency_code")]
    public string currencyCode;
}
