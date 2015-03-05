using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents inventory information for one of a merchant's item variations.
    /// </summary>
    public class InventoryEntry
    {
        [DataMember(Name = "variation_id")]
        /// <summary>
        /// The variation that the entry corresponds to.
        /// </summary>
        public string variationID;
        [DataMember(Name = "quantity_on_hand")]
        /// <summary>
        /// The current available quantity of the item variation.
        /// </summary>
        public int quantityOnHand;
    }
}
