[DataContract]
public class Payment
{
    [DataMember]
    public string id;
    [DataMember(Name="merchant_id")]
    public string merchantID;
    [DataMember]
    private string created_at; // TODO
    [DataMember(Name="creator_id")]
    public string creatorID;
    [DataMember]
    public Device device;
    [DataMember(Name="payment_url")]
    public string dashboardURL;
    [DataMember(Name="receipt_url")]
    public string receiptURL;
    
    [DataMember(Name="inclusive_tax_money")]
    public Money inclusiveTaxMoney;
    [DataMember(Name="additive_tax_money")]
    public Money additiveTaxMoney;
    [DataMember(Name="tax_money")]
    public Money taxMoney;
    [DataMember(Name="tip_money")]
    public Money tipMoney;
    [DataMember(Name="discount_money")]
    public Money discountMoney;
    [DataMember(Name="total_collected_money")]
    public Money totalCollectedMoney;
    [DataMember(Name="processing_fee_money")]
    public Money processingFeeMoney;
    [DataMember(Name="set_total_money")]
    public Money setTotalMoney;
    [DataMember(Name="refunded_money")]
    public Money refundedMoney;
    [DataMember(Name="inclusive_tax")]
    public PaymentTax[] inclusiveTaxes;
    [DataMember(Name="additive_tax")]
    public PaymentTax[] additiveTaxes;
    [DataMember(Name="tender")]
    public Tender[] tenders;
    [DataMember]
    public Refund[] refunds;
    [DataMember]
    public Itemization[] itemizations;
}
