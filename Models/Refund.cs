using System.Runtime.Serialization;
using System;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents a refund initiated by a Square merchant.
    /// </summary>
    public class Refund
    {
        [DataMember]
        /// <summary>
        /// The type of refund (FULL or PARTIAL).
        /// </summary>
        public string type;
        [DataMember]
        /// <summary>
        /// The merchant-specified reason for the refund.
        /// </summary>
        public string reason;
        [DataMember(Name = "refunded_money")]
        /// <summary>
        /// The amount of money refunded. This amount is always negative.
        /// </summary>
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
        /// <summary>
        /// The Square-issued ID of the payment the refund is applied to.
        /// </summary>
        public string paymentID;
    }
}
