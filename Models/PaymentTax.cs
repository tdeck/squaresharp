using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents a single tax applied to a payment.
    /// </summary>
    public class PaymentTax
    {
        [DataMember]
        /// <summary>
        /// The merchant-defined name of the tax.
        /// </summary>
        public string name;
        [DataMember(Name = "applied_money")]
        /// <summary>
        /// The amount of money that this tax adds to the payment.
        /// </summary>
        public Money appliedMoney;
        [DataMember]
        /// <summary>
        /// The rate of the tax, as a decimal number. A value of 0.07 corresponds to a rate of 7%.
        /// </summary>
        public string rate;
        [DataMember(Name = "inclusion_type")]
        /// <summary>
        /// Whether the tax is an ADDITIVE tax or an INCLUSIVE tax.
        /// </summary>
        public string inclusionType;
        [DataMember(Name = "fee_id")]
        /// <summary>
        /// The ID of the tax, if available. Taxes applied in older versions of Square Register might not have an ID.
        /// </summary>
        public string feeID;
    }
}
