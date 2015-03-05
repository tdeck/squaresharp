using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class ItemDetail
    {
        [DataMember(Name = "category_name")]
        public string categoryName;
        [DataMember]
        public string sku;
        [DataMember(Name = "item_id")]
        public string itemID;
        [DataMember(Name = "item_variation_id")]
        public string variationID;
    }
}
