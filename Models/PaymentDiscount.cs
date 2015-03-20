using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents a discount applied to an itemization in a payment.
    /// </summary>
    [DataContract]
    public class PaymentDiscount
    {
        /// <summary>
        /// The discount's name.
        /// </summary>
        [DataMember]
        public string name;

        /// <summary>
        /// The amount of money that this discount adds to the payment (note that this value is always negative or zero).
        /// </summary>
        [DataMember(Name = "applied_money")]
        public Money appliedMoney;

        /// <summary>
        /// The ID of the applied discount, if available. Discounts applied in older versions of Square Register might not have an ID.
        /// </summary>
        [DataMember(Name = "discount_id")]
        public string discountID;
    }
}
