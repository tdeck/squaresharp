using System.Runtime.Serialization;
using System;

namespace SquareSharp.Models
{
    [DataContract]
    public class Refund
    {
        [DataMember]
        public string type;
        [DataMember]
        public string reason;
        [DataMember(Name = "refunded_money")]
        public Money refundedMoney;
        [DataMember]
        private string created_at;
        public DateTime createdAt
        {
            get
            {
                return Util.DateHelper.FromISO(this.created_at);
            }
        }
        [DataMember]
        private string processed_at;
        public DateTime processedAt
        {
            get
            {
                return Util.DateHelper.FromISO(this.processed_at);
            }
        }
        [DataMember(Name = "payment_id")]
        public string paymentID;
    }
}