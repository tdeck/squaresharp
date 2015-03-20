using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents an item purchased in a payment.
    /// </summary>
    [DataContract]
    public class PaymentItemization
    {
        /// <summary>
        /// The item's name.
        /// </summary>
        [DataMember]
        public string name;

        /// <summary>
        /// The quantity of the item purchased. This can be a decimal value.
        /// </summary>
        [DataMember]
        public decimal quantity;

        /// <summary>
        /// Details of the item, including its unique identifier and the identifier of the item variation purchased.
        /// </summary>
        [DataMember(Name = "item_detail")]
        public PaymentItemDetail itemDetail;

        /// <summary>
        /// Notes entered by the merchant about the item at the time of payment, if any.
        /// </summary>
        [DataMember]
        public string notes;

        /// <summary>
        /// The name of the item variation purchased.
        /// </summary>
        [DataMember(Name = "item_variation_name")]
        public string itemVariationName;

        /// <summary>
        /// The total cost of the item, including all taxes and discounts.
        /// </summary>
        [DataMember(Name = "total_money")]
        public Money totalMoney;

        /// <summary>
        /// The cost of a single unit of this item.
        /// </summary>
        [DataMember(Name = "single_quantity_money")]
        public Money singleQuantityMoney;

        /// <summary>
        /// The total cost of the itemization, not including taxes or discounts.
        /// </summary>
        [DataMember(Name = "gross_sales_money")]
        public Money grossSalesMoney;

        /// <summary>
        /// The total of all discounts applied to the itemization.
        /// </summary>
        [DataMember(Name = "discount_money")]
        public Money discountMoney;

        [DataMember(Name = "net_sales_money")]
        public Money netSalesMoney;

        /// <summary>
        /// All taxes applied to this itemization.
        /// </summary>
        [DataMember]
        public PaymentTax[] taxes;

        /// <summary>
        /// All discounts applied to this itemization.
        /// </summary>
        [DataMember]
        public PaymentDiscount[] discounts;

        /// <summary>
        /// All modifier options applied to this itemization.
        /// </summary>
        [DataMember]
        public PaymentModifier[] modifiers;
    }
}
