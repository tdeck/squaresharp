[DataContract]
public class Itemization
{
    [DataMember]
    public string name;
    [DataMember]
    public decimal quantity;
    [DataMember(Name="item_detail")]
    public ItemDetail itemDetail;
    [DataMember]
    public string notes;
    [DataMember(Name="item_variation_name")]
    public string itemVariationName;
    [DataMember(Name="total_money")]
    public Money totalMoney;
    [DataMember(Name="single_quantity_money")]
    public Money singleQuantityMoney;
    [DataMember(Name="gross_sales_money")]
    public Money grossSalesMoney;
    [DataMember(Name="discount_money")]
    public Money discountMoney;
    [DataMember(Name="net_sales_money")]
    public Money netSalesMoney;
    [DataMember]
    public PaymentTax[] taxes;
    [DataMember]
    public PaymentDiscount[] discounts;
    [DataMember]
    public PaymentModifier[] modifiers;
}
