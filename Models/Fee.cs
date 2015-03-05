using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents a tax or other fee that can be applied to a payment.
    /// </summary>
    public class Fee
    {
        [DataMember]
        /// <summary>
        /// The fee's unique ID.
        /// </summary>
        public string id;
        [DataMember]
        /// <summary>
        /// The fee's name.
        /// </summary>
        public string name;
        [DataMember]
        /// <summary>
        /// The rate of the fee, as a decimal number. A value of 0.07 corresponds to a rate of 7%.
        /// </summary>
        public decimal rate;
        [DataMember(Name = "calculation_phase")]
        /// <summary>
        /// Forthcoming.
        /// </summary>
        public string calculationPhase;
        [DataMember(Name = "adjustment_type")]
        /// <summary>
        /// The type of adjustment the fee applies to a payment. Currently, this value is TAX for all fees.
        /// </summary>
        public string adjustmentType;
        [DataMember(Name = "applies_to_custom_amounts")]
        /// <summary>
        /// If true, the fee applies to custom amounts entered into Square Register that are not associated with a particular item.
        /// </summary>
        public bool appliesToCustomAmounts;
        [DataMember]
        /// <summary>
        /// If true, the fee is applied to all appropriate items. If false, the fee is not applied at all.
        /// </summary>
        public bool enabled;
        [DataMember(Name = "inclusion_type")]
        /// <summary>
        /// Whether the fee is ADDITIVE or INCLUSIVE.
        /// </summary>
        public string inclusionType;
        [DataMember]
        /// <summary>
        /// In countries with multiple classifications for sales taxes, indicates which classification the fee falls under. Currently relevant only to Canadian merchants.
        /// </summary>
        public string type;
    }
}
