[DataContract]
public class PaymentModifier
{
    [DataMember]
    public string name; 
    [DataMember(Name="applied_money")]
    public Money appliedMoney;
    [DataMember(Name="modifier_option_id")]
    public string modifierOptionID;
}

