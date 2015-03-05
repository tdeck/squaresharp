using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents a form and amount of tender provided for a payment.
    /// </summary>
    public class Tender
    {
        [DataMember]
        public string id;
        [DataMember]
        /// <summary>
        /// The type of tender.
        /// </summary>
        public string type;
        [DataMember]
        /// <summary>
        /// A human-readable description of the tender.
        /// </summary>
        public string name;
        [DataMember(Name = "receipt_url")]
        public string receiptURL;
        [DataMember(Name = "card_brand")]
        /// <summary>
        /// The brand of credit card provided. Only present if the tender's type is CREDIT_CARD.
        /// </summary>
        public string cardBrand;
        [DataMember(Name = "pan_suffix")]
        /// <summary>
        /// The last four digits of the credit card provided. Only present if the tender's type is CREDIT_CARD.
        /// </summary>
        public string panSuffix;
        [DataMember(Name = "entry_method")]
        /// <summary>
        /// The method with which the tender was entered.
        /// </summary>
        public string entryMethod;
        [DataMember(Name = "payment_note")]
        /// <summary>
        /// Notes entered by the merchant about the tender at the time of payment, if any. Typically only present for tender with the type OTHER.
        /// </summary>
        public string paymentNote;

        [DataMember(Name = "total_money")]
        /// <summary>
        /// The total amount of money provided in this form of tender.
        /// </summary>
        public Money totalMoney;
        [DataMember(Name = "tendered_money")]
        /// <summary>
        /// The amount of totalMoney applied to the payment.
        /// </summary>
        public Money tenderedMoney;
        [DataMember(Name = "charge_back_money")]
        public Money chargeBackMoney;
        [DataMember(Name = "refunded_money")]
        public Money refundedMoney;
    }
}
