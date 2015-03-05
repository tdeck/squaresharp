using System.Runtime.Serialization;
using System;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents a payment taken by a Square merchant.
    /// </summary>
    public class Payment
    {
        [DataMember]
        /// <summary>
        /// The payment's unique identifier.
        /// </summary>
        public string id;
        [DataMember(Name = "merchant_id")]
        /// <summary>
        /// The unique identifier of the merchant that took the payment.
        /// </summary>
        public string merchantID;
        [DataMember]
        private string created_at;
        public DateTime createdAt
        {
            get
            {
                return Util.DateHelper.FromISO(this.created_at);
            }
        }
        [DataMember(Name = "creator_id")]
        /// <summary>
        /// The unique identifier of the Square account that took the payment. This value can differ from merchantID if the merchant has mobile staff.
        /// </summary>
        public string creatorID;
        [DataMember]
        /// <summary>
        /// The device that took the payment.
        /// </summary>
        public Device device;
        [DataMember(Name = "payment_url")]
        public string dashboardURL;
        [DataMember(Name = "receipt_url")]
        /// <summary>
        /// The URL of the receipt for the payment.
        /// </summary>
        public string receiptURL;

        [DataMember(Name = "inclusive_tax_money")]
        /// <summary>
        /// The sum of all inclusive taxes associated with the payment.
        /// </summary>
        public Money inclusiveTaxMoney;
        [DataMember(Name = "additive_tax_money")]
        /// <summary>
        /// The sum of all additive taxes associated with the payment.
        /// </summary>
        public Money additiveTaxMoney;
        [DataMember(Name = "tax_money")]
        /// <summary>
        /// The total of all taxes applied to the payment. This is always the sum of inclusiveTaxMoney and additiveTaxMoney.
        /// </summary>
        public Money taxMoney;
        [DataMember(Name = "tip_money")]
        /// <summary>
        /// The total of all tips applied to the payment.
        /// </summary>
        public Money tipMoney;
        [DataMember(Name = "discount_money")]
        /// <summary>
        /// The total of all discounts applied to the payment. This value is always 0 or negative.
        /// </summary>
        public Money discountMoney;
        [DataMember(Name = "total_collected_money")]
        /// <summary>
        /// The total amount of money collected from the buyer for the payment.
        /// </summary>
        public Money totalCollectedMoney;
        [DataMember(Name = "processing_fee_money")]
        /// <summary>
        /// The total of all processing fees collected by Square for the payment. This value is always 0 or negative.
        /// </summary>
        public Money processingFeeMoney;
        [DataMember(Name = "set_total_money")]
        public Money setTotalMoney;
        [DataMember(Name = "refunded_money")]
        /// <summary>
        /// The total of all refunds applied to the payment.
        /// </summary>
        public Money refundedMoney;
        [DataMember(Name = "inclusive_tax")]
        public PaymentTax[] inclusiveTaxes;
        [DataMember(Name = "additive_tax")]
        public PaymentTax[] additiveTaxes;
        [DataMember(Name = "tender")]
        public Tender[] tenders;
        [DataMember]
        /// <summary>
        /// All of the refunds applied to the payment.
        /// </summary>
        public Refund[] refunds;
        [DataMember]
        /// <summary>
        /// The items purchased in the payment.
        /// </summary>
        public PaymentItemization[] itemizations;
    }
}
