using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class PaymentDiscount
    {
        [DataMember]
        public string name;
        [DataMember(Name = "applied_money")]
        public Money appliedMoney;
        [DataMember(Name = "discount_id")]
        public string discountID;
    }
}