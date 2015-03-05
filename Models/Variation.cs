using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents a variation of an Item. Every item has at least one variation.
    /// </summary>
    public class Variation
    {
        [DataMember]
        /// <summary>
        /// The item variation's unique ID.
        /// </summary>
        public string id;
        [DataMember]
        /// <summary>
        /// The item variation's name.
        /// </summary>
        public string name;
        [DataMember(Name = "item_id")]
        /// <summary>
        /// The ID of the variation's associated item.
        /// </summary>
        public string itemID;
        [DataMember]
        /// <summary>
        /// Indicates the variation's list position when displayed in Square Register and the merchant dashboard. If more than one variation for the same item has the same ordinal value, those variations are displayed in alphabetical order. An item's variation with the lowest ordinal value is displayed first.
        /// </summary>
        public uint ordinal;
        [DataMember(Name = "pricing_type")]
        /// <summary>
        /// Indicates whether the item variation's price is fixed or determined at the time of sale.
        /// </summary>
        public string pricingType;
        [DataMember(Name = "price_money")] 
        /// <summary>
        /// The item variation's price, if any.
        /// </summary>
        public Money priceMoney;
        [DataMember]
        /// <summary>
        /// The item variation's SKU, if any.
        /// </summary>
        public string sku;
        [DataMember(Name = "track_inventory")]
        /// <summary>
        /// If true, inventory tracking is active for the variation.
        /// </summary>
        public bool trackInventory;
        [DataMember(Name = "inventory_alert_type")]
        /// <summary>
        /// Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its inventoryAlertThreshold.
        /// </summary>
        public string inventoryAlertType;
        [DataMember(Name = "inventory_alert_threshold")]
        /// <summary>
        /// If the inventory quantity for the variation is less than or equal to this value and inventoryAlertType is LOW_QUANTITY, the variation displays an alert in the merchant dashboard.
        /// </summary>
        public int inventoryAlertThreshold;
        [DataMember(Name = "user_data")]
        /// <summary>
        /// Arbitrary metadata associated with the variation. Cannot exceed 255 characters.
        /// </summary>
        public string userData;
    }
}
