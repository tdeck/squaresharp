using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents inventory information for one of a merchant's item variations.
    /// </summary>
    [DataContract]
    public class InventoryEntry
    {
        /// <summary>
        /// The variation that the entry corresponds to.
        /// </summary>
        [DataMember(Name = "variation_id")]
        public string variationID {get; private set; }

        /// <summary>
        /// The current available quantity of the item variation.
        /// </summary>
        [DataMember(Name = "quantity_on_hand")]
        public int quantityOnHand {get; private set; }
    }
}
