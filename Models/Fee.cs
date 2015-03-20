using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents a tax or other fee that can be applied to a payment.
    /// </summary>
    [DataContract]
    public class Fee
    {
        /// <summary>
        /// The fee's unique ID.
        /// </summary>
        [DataMember]
        public string id;

        /// <summary>
        /// The fee's name.
        /// </summary>
        [DataMember]
        public string name;

        /// <summary>
        /// The rate of the fee, as a decimal number. A value of 0.07 corresponds to a rate of 7%.
        /// </summary>
        [DataMember]
        public decimal rate;

        /// <summary>
        /// Forthcoming.
        /// </summary>
        [DataMember(Name = "calculation_phase")]
        public string calculationPhase;

        /// <summary>
        /// The type of adjustment the fee applies to a payment. Currently, this value is TAX for all fees.
        /// </summary>
        [DataMember(Name = "adjustment_type")]
        public string adjustmentType;

        /// <summary>
        /// If true, the fee applies to custom amounts entered into Square Register that are not associated with a particular item.
        /// </summary>
        [DataMember(Name = "applies_to_custom_amounts")]
        public bool appliesToCustomAmounts;

        /// <summary>
        /// If true, the fee is applied to all appropriate items. If false, the fee is not applied at all.
        /// </summary>
        [DataMember]
        public bool enabled;

        /// <summary>
        /// Whether the fee is ADDITIVE or INCLUSIVE.
        /// </summary>
        [DataMember(Name = "inclusion_type")]
        public string inclusionType;

        /// <summary>
        /// In countries with multiple classifications for sales taxes, indicates which classification the fee falls under. Currently relevant only to Canadian merchants.
        /// </summary>
        [DataMember]
        public string type;
    }
}
