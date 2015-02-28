[DataContract]
public class Tender
{
    [DataMember]
    public string id;
    [DataMember]
    public string type;
    [DataMember]
    public string name;
    [DataMember(name="receipt_url")]
    public string receiptURL;
    [DataMember(name="card_brand")]
    public string cardBrand;
    [DataMember(name="pan_suffix")]
    public string panSuffix;
    [DataMember(name="entry_method")]
    public string entryMethod;
    [DataMember(name="payment_note")]
    public string paymentNote;

    [DataMember(name="total_money")]
    public Money totalMoney;
    [DataMember(name="tendered_money")]
    public Money tenderedMoney;
    [DataMember(name="charge_back_money")]
    public Money chargeBackMoney;
    [DataMember(name="refunded_money")]
    public Money refundedMoney;
}
