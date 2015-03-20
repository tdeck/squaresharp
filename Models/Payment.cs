using System.Runtime.Serialization;
using System;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents a payment taken by a Square merchant.
    /// </summary>
    [DataContract]
    public class Payment
    {
        /// <summary>
        /// The payment's unique identifier.
        /// </summary>
        [DataMember]
        public string id { get; private set; }

        /// <summary>
        /// The unique identifier of the merchant that took the payment.
        /// </summary>
        [DataMember(Name = "merchant_id")]
        public string merchantID { get; private set; }

        [DataMember]
        private string created_at;
        public DateTime createdAt
        {
            get
            {
                return Util.DateHelper.FromISO(this.created_at);
            }
        }

        /// <summary>
        /// The unique identifier of the Square account that took the payment. This value can differ from merchantID if the merchant has mobile staff.
        /// </summary>
        [DataMember(Name = "creator_id")]
        public string creatorID { get; private set; }

        /// <summary>
        /// The device that took the payment.
        /// </summary>
        [DataMember]
        public Device device { get; private set; }

        [DataMember(Name = "payment_url")]
        public string dashboardURL { get; private set; }

        /// <summary>
        /// The URL of the receipt for the payment.
        /// </summary>
        [DataMember(Name = "receipt_url")]
        public string receiptURL { get; private set; }

        /// <summary>
        /// The sum of all inclusive taxes associated with the payment.
        /// </summary>
        [DataMember(Name = "inclusive_tax_money")]
        public Money inclusiveTaxMoney { get; private set; }

        /// <summary>
        /// The sum of all additive taxes associated with the payment.
        /// </summary>
        [DataMember(Name = "additive_tax_money")]
        public Money additiveTaxMoney { get; private set; }

        /// <summary>
        /// The total of all taxes applied to the payment. This is always the sum of inclusiveTaxMoney and additiveTaxMoney.
        /// </summary>
        [DataMember(Name = "tax_money")]
        public Money taxMoney { get; private set; }

        /// <summary>
        /// The total of all tips applied to the payment.
        /// </summary>
        [DataMember(Name = "tip_money")]
        public Money tipMoney { get; private set; }

        /// <summary>
        /// The total of all discounts applied to the payment. This value is always 0 or negative.
        /// </summary>
        [DataMember(Name = "discount_money")]
        public Money discountMoney { get; private set; }

        /// <summary>
        /// The total amount of money collected from the buyer for the payment.
        /// </summary>
        [DataMember(Name = "total_collected_money")]
        public Money totalCollectedMoney { get; private set; }

        /// <summary>
        /// The total of all processing fees collected by Square for the payment. This value is always 0 or negative.
        /// </summary>
        [DataMember(Name = "processing_fee_money")]
        public Money processingFeeMoney { get; private set; }

        [DataMember(Name = "set_total_money")]
        public Money setTotalMoney { get; private set; }

        /// <summary>
        /// The total of all refunds applied to the payment.
        /// </summary>
        [DataMember(Name = "refunded_money")]
        public Money refundedMoney { get; private set; }

        [DataMember(Name = "inclusive_tax")]
        public PaymentTax[] inclusiveTaxes { get; private set; }

        [DataMember(Name = "additive_tax")]
        public PaymentTax[] additiveTaxes { get; private set; }

        [DataMember(Name = "tender")]
        public Tender[] tenders { get; private set; }

        /// <summary>
        /// All of the refunds applied to the payment.
        /// </summary>
        [DataMember]
        public Refund[] refunds { get; private set; }

        /// <summary>
        /// The items purchased in the payment.
        /// </summary>
        [DataMember]
        public PaymentItemization[] itemizations { get; private set; }
    }
}
