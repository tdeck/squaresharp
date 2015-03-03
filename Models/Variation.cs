using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class Variation
    {
        [DataMember]
        public string id;
        [DataMember]
        public string name;
        [DataMember(Name = "item_id")]
        public string itemID;
        [DataMember]
        public uint ordinal;
        [DataMember(Name = "pricing_type")]
        public string pricingType;
        [DataMember(Name = "price_money")] 
        public Money priceMoney;
        [DataMember]
        public string sku;
        [DataMember(Name = "track_inventory")]
        public bool trackInventory;
        [DataMember(Name = "inventory_alert_type")]
        public string inventoryAlertType;
        [DataMember(Name = "inventory_alert_threshold")]
        public int inventoryAlertThreshold;
        [DataMember(Name = "user_data")]
        public string userData;
    }
}
