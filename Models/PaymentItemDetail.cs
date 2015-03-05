using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents details of an item purchased in a payment.
    /// </summary>
    public class PaymentItemDetail
    {
        [DataMember(Name = "category_name")]
        /// <summary>
        /// The name of the item's merchant-defined category, if any.
        /// </summary>
        public string categoryName;
        [DataMember]
        /// <summary>
        /// The item's merchant-defined SKU, if any.
        /// </summary>
        public string sku;
        [DataMember(Name = "item_id")]
        /// <summary>
        /// The unique ID of the item purchased, if any.
        /// </summary>
        public string itemID;
        [DataMember(Name = "item_variation_id")]
        /// <summary>
        /// The unique ID of the item variation purchased, if any.
        /// </summary>
        public string variationID;
    }
}
