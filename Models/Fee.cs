using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class Fee
    {
        [DataMember]
        public string id;
        [DataMember]
        public string name;
        [DataMember]
        public decimal rate;
        [DataMember(Name = "calculation_phase")]
        public string calculationPhase;
        [DataMember(Name = "adjustment_type")]
        public string adjustmentType;
        [DataMember(Name = "applies_to_custom_amounts")]
        public bool appliesToCustomAmounts;
        [DataMember]
        public bool enabled;
        [DataMember(Name = "inclusion_type")]
        public string inclusionType;
        [DataMember]
        public string type;
    }
}
