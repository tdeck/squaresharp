using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents a modifier option applied to an itemization in a payment.
    /// </summary>
    public class PaymentModifier
    {
        [DataMember]
        /// <summary>
        /// The modifier option's name.
        /// </summary>
        public string name;
        [DataMember(Name = "applied_money")]
        /// <summary>
        /// The amount of money that this modifier option adds to the payment.
        /// </summary>
        public Money appliedMoney;
        [DataMember(Name = "modifier_option_id")]
        /// <summary>
        /// The ID of the applied modifier option, if available. Modifier options applied in older versions of Square Register might not have an ID.
        /// </summary>
        public string modifierOptionID;
    }
}
