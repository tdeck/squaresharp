using System.Runtime.Serialization;
using System;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents a refund initiated by a Square merchant.
    /// </summary>
    [DataContract]
    public class Refund
    {
        /// <summary>
        /// The type of refund (FULL or PARTIAL).
        /// </summary>
        [DataMember]
        public string type;

        /// <summary>
        /// The merchant-specified reason for the refund.
        /// </summary>
        [DataMember]
        public string reason;

        /// <summary>
        /// The amount of money refunded. This amount is always negative.
        /// </summary>
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

        /// <summary>
        /// The Square-issued ID of the payment the refund is applied to.
        /// </summary>
        [DataMember(Name = "payment_id")]
        public string paymentID;
    }
}
