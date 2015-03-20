using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents a single tax applied to a payment.
    /// </summary>
    [DataContract]
    public class PaymentTax
    {
        /// <summary>
        /// The merchant-defined name of the tax.
        /// </summary>
        [DataMember]
        public string name;

        /// <summary>
        /// The amount of money that this tax adds to the payment.
        /// </summary>
        [DataMember(Name = "applied_money")]
        public Money appliedMoney;

        /// <summary>
        /// The rate of the tax, as a decimal number. A value of 0.07 corresponds to a rate of 7%.
        /// </summary>
        [DataMember]
        public string rate;

        /// <summary>
        /// Whether the tax is an ADDITIVE tax or an INCLUSIVE tax.
        /// </summary>
        [DataMember(Name = "inclusion_type")]
        public string inclusionType;

        /// <summary>
        /// The ID of the tax, if available. Taxes applied in older versions of Square Register might not have an ID.
        /// </summary>
        [DataMember(Name = "fee_id")]
        public string feeID;
    }
}
