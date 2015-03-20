using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents a modifier option applied to an itemization in a payment.
    /// </summary>
    [DataContract]
    public class PaymentModifier
    {
        /// <summary>
        /// The modifier option's name.
        /// </summary>
        [DataMember]
        public string name;

        /// <summary>
        /// The amount of money that this modifier option adds to the payment.
        /// </summary>
        [DataMember(Name = "applied_money")]
        public Money appliedMoney;

        /// <summary>
        /// The ID of the applied modifier option, if available. Modifier options applied in older versions of Square Register might not have an ID.
        /// </summary>
        [DataMember(Name = "modifier_option_id")]
        public string modifierOptionID;
    }
}
