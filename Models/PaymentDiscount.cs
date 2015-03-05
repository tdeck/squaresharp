using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents a discount applied to an itemization in a payment.
    /// </summary>
    public class PaymentDiscount
    {
        [DataMember]
        /// <summary>
        /// The discount's name.
        /// </summary>
        public string name;
        [DataMember(Name = "applied_money")]
        /// <summary>
        /// The amount of money that this discount adds to the payment (note that this value is always negative or zero).
        /// </summary>
        public Money appliedMoney;
        [DataMember(Name = "discount_id")]
        /// <summary>
        /// The ID of the applied discount, if available. Discounts applied in older versions of Square Register might not have an ID.
        /// </summary>
        public string discountID;
    }
}
