using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents a variation of an Item. Every item has at least one variation.
    /// </summary>
    [DataContract]
    public class Variation
    {
        /// <summary>
        /// The item variation's unique ID.
        /// </summary>
        [DataMember]
        public string id;

        /// <summary>
        /// The item variation's name.
        /// </summary>
        [DataMember]
        public string name;

        /// <summary>
        /// The ID of the variation's associated item.
        /// </summary>
        [DataMember(Name = "item_id")]
        public string itemID;

        /// <summary>
        /// Indicates the variation's list position when displayed in Square Register and the merchant dashboard. If more than one variation for the same item has the same ordinal value, those variations are displayed in alphabetical order. An item's variation with the lowest ordinal value is displayed first.
        /// </summary>
        [DataMember]
        public uint ordinal;

        /// <summary>
        /// Indicates whether the item variation's price is fixed or determined at the time of sale.
        /// </summary>
        [DataMember(Name = "pricing_type")]
        public string pricingType;

        /// <summary>
        /// The item variation's price, if any.
        /// </summary>
        [DataMember(Name = "price_money")] 
        public Money priceMoney;

        /// <summary>
        /// The item variation's SKU, if any.
        /// </summary>
        [DataMember]
        public string sku;

        /// <summary>
        /// If true, inventory tracking is active for the variation.
        /// </summary>
        [DataMember(Name = "track_inventory")]
        public bool trackInventory;

        /// <summary>
        /// Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its inventoryAlertThreshold.
        /// </summary>
        [DataMember(Name = "inventory_alert_type")]
        public string inventoryAlertType;

        /// <summary>
        /// If the inventory quantity for the variation is less than or equal to this value and inventoryAlertType is LOW_QUANTITY, the variation displays an alert in the merchant dashboard.
        /// </summary>
        [DataMember(Name = "inventory_alert_threshold")]
        public int inventoryAlertThreshold;

        /// <summary>
        /// Arbitrary metadata associated with the variation. Cannot exceed 255 characters.
        /// </summary>
        [DataMember(Name = "user_data")]
        public string userData;
    }
}
