using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents details of an item purchased in a payment.
    /// </summary>
    [DataContract]
    public class PaymentItemDetail
    {
        /// <summary>
        /// The name of the item's merchant-defined category, if any.
        /// </summary>
        [DataMember(Name = "category_name")]
        public string categoryName;

        /// <summary>
        /// The item's merchant-defined SKU, if any.
        /// </summary>
        [DataMember]
        public string sku;

        /// <summary>
        /// The unique ID of the item purchased, if any.
        /// </summary>
        [DataMember(Name = "item_id")]
        public string itemID;

        /// <summary>
        /// The unique ID of the item variation purchased, if any.
        /// </summary>
        [DataMember(Name = "item_variation_id")]
        public string variationID;
    }
}
