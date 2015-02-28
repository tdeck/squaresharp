[DataContract]
public class Refund
{
    [DataMember]
    public string type;
    [DataMember]
    public string reason;
    [DataMember(name="refunded_money")]
    public Money refundedMoney;
    [DataMember]
    private string created_at; // TODO
    [DataMember]
    private string processed_at; // TODO
    [DataMember(name="payment_id")]
    public string paymentID;
}
