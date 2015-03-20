using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents a form and amount of tender provided for a payment.
    /// </summary>
    [DataContract]
    public class Tender
    {
        [DataMember]
        public string id;

        /// <summary>
        /// The type of tender.
        /// </summary>
        [DataMember]
        public string type;

        /// <summary>
        /// A human-readable description of the tender.
        /// </summary>
        [DataMember]
        public string name;

        [DataMember(Name = "receipt_url")]
        public string receiptURL;

        /// <summary>
        /// The brand of credit card provided. Only present if the tender's type is CREDIT_CARD.
        /// </summary>
        [DataMember(Name = "card_brand")]
        public string cardBrand;

        /// <summary>
        /// The last four digits of the credit card provided. Only present if the tender's type is CREDIT_CARD.
        /// </summary>
        [DataMember(Name = "pan_suffix")]
        public string panSuffix;

        /// <summary>
        /// The method with which the tender was entered.
        /// </summary>
        [DataMember(Name = "entry_method")]
        public string entryMethod;

        /// <summary>
        /// Notes entered by the merchant about the tender at the time of payment, if any. Typically only present for tender with the type OTHER.
        /// </summary>
        [DataMember(Name = "payment_note")]
        public string paymentNote;

        /// <summary>
        /// The total amount of money provided in this form of tender.
        /// </summary>
        [DataMember(Name = "total_money")]
        public Money totalMoney;

        /// <summary>
        /// The amount of totalMoney applied to the payment.
        /// </summary>
        [DataMember(Name = "tendered_money")]
        public Money tenderedMoney;

        [DataMember(Name = "charge_back_money")]
        public Money chargeBackMoney;

        [DataMember(Name = "refunded_money")]
        public Money refundedMoney;
    }
}
