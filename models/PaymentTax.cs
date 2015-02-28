[DataContract]
public class PaymentTax
{
    [DataMember]
    public string name;
    [DatMember(name="applied_money")]
    public Money appliedMoney;
    [DataMember]
    public string rate;
    [DataMember(name="inclusion_type")]
    public string inclusionType;
    [DataMember(name="fee_id")]
    public string feeID;
}
