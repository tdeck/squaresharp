using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class InventoryEntry
    {
        [DataMember(Name = "variation_id")]
        public string variationID;
        [DataMember(Name = "quantity_on_hand")]
        public int quantityOnHand;
    }
}
