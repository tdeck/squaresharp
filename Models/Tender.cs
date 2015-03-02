using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class Tender
    {
        [DataMember]
        public string id;
        [DataMember]
        public string type;
        [DataMember]
        public string name;
        [DataMember(Name = "receipt_url")]
        public string receiptURL;
        [DataMember(Name = "card_brand")]
        public string cardBrand;
        [DataMember(Name = "pan_suffix")]
        public string panSuffix;
        [DataMember(Name = "entry_method")]
        public string entryMethod;
        [DataMember(Name = "payment_note")]
        public string paymentNote;

        [DataMember(Name = "total_money")]
        public Money totalMoney;
        [DataMember(Name = "tendered_money")]
        public Money tenderedMoney;
        [DataMember(Name = "charge_back_money")]
        public Money chargeBackMoney;
        [DataMember(Name = "refunded_money")]
        public Money refundedMoney;
    }
}