using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class PaymentTax
    {
        [DataMember]
        public string name;
        [DataMember(Name = "applied_money")]
        public Money appliedMoney;
        [DataMember]
        public string rate;
        [DataMember(Name = "inclusion_type")]
        public string inclusionType;
        [DataMember(Name = "fee_id")]
        public string feeID;
    }
}