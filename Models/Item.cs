using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents a merchant's item.
    /// </summary>
    public class Item
    {
        [DataContract]
        public struct ItemImage
        {
           [DataMember] 
           public string id;
           [DataMember]
           public string url;
        }

        [DataMember]
        /// <summary>
        /// The item's unique ID.
        /// </summary>
        public string id;
        [DataMember]
        /// <summary>
        /// The item's name.
        /// </summary>
        public string name;
        [DataMember]
        /// <summary>
        /// The item's description, if any.
        /// </summary>
        public string description;
        [DataMember]
        /// <summary>
        /// The color of the item's display label in Square Register, if not the default color. The default color is 9da2a6.
        /// </summary>
        public string color;
        [DataMember]
        /// <summary>
        /// Indicates whether the item is viewable in Square Market (PUBLIC) or PRIVATE.
        /// </summary>
        public string visibility;
        [DataMember(Name = "available_online")]
        /// <summary>
        /// If true, the item is available for purchase from Square Market.
        /// </summary>
        public bool availableOnline;
        [DataMember(Name = "master_image")]
        /// <summary>
        /// The item's master image, if any.
        /// </summary>
        public ItemImage masterImage;
        [DataMember]
        /// <summary>
        /// The category the item belongs to, if any.
        /// </summary>
        public Category category;
        [DataMember]
        /// <summary>
        /// The item's variations.
        /// </summary>
        public Variation[] variations;
        [DataMember(Name = "modifier_lists")]
        /// <summary>
        /// The modifier lists that apply to the item, if any.
        /// </summary>
        public ModifierList[] modifierLists;

        /// <summary>
        /// The fees that apply to the item, if any.
        /// </summary>
        public Fee[] fees;
    }
}
