using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents an item purchased in a payment.
    /// </summary>
    public class PaymentItemization
    {
        [DataMember]
        /// <summary>
        /// The item's name.
        /// </summary>
        public string name;
        [DataMember]
        /// <summary>
        /// The quantity of the item purchased. This can be a decimal value.
        /// </summary>
        public decimal quantity;
        [DataMember(Name = "item_detail")]
        /// <summary>
        /// Details of the item, including its unique identifier and the identifier of the item variation purchased.
        /// </summary>
        public PaymentItemDetail itemDetail;
        [DataMember]
        /// <summary>
        /// Notes entered by the merchant about the item at the time of payment, if any.
        /// </summary>
        public string notes;
        [DataMember(Name = "item_variation_name")]
        /// <summary>
        /// The name of the item variation purchased.
        /// </summary>
        public string itemVariationName;
        [DataMember(Name = "total_money")]
        /// <summary>
        /// The total cost of the item, including all taxes and discounts.
        /// </summary>
        public Money totalMoney;
        [DataMember(Name = "single_quantity_money")]
        /// <summary>
        /// The cost of a single unit of this item.
        /// </summary>
        public Money singleQuantityMoney;
        [DataMember(Name = "gross_sales_money")]
        /// <summary>
        /// The total cost of the itemization, not including taxes or discounts.
        /// </summary>
        public Money grossSalesMoney;
        [DataMember(Name = "discount_money")]
        /// <summary>
        /// The total of all discounts applied to the itemization.
        /// </summary>
        public Money discountMoney;
        [DataMember(Name = "net_sales_money")]
        public Money netSalesMoney;
        [DataMember]
        /// <summary>
        /// All taxes applied to this itemization.
        /// </summary>
        public PaymentTax[] taxes;
        [DataMember]
        /// <summary>
        /// All discounts applied to this itemization.
        /// </summary>
        public PaymentDiscount[] discounts;
        [DataMember]
        /// <summary>
        /// All modifier options applied to this itemization.
        /// </summary>
        public PaymentModifier[] modifiers;
    }
}
