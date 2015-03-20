using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents a merchant's item.
    /// </summary>
    [DataContract]
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

        /// <summary>
        /// The item's unique ID.
        /// </summary>
        [DataMember]
        public string id { get; private set; } // For now we don't support custom IDs

        /// <summary>
        /// The item's name.
        /// </summary>
        [DataMember]
        public string name;

        /// <summary>
        /// The item's description, if any.
        /// </summary>
        [DataMember]
        public string description;

        /// <summary>
        /// The color of the item's display label in Square Register, if not the default color. The default color is 9da2a6.
        /// </summary>
        [DataMember]
        public string color;

        /// <summary>
        /// Indicates whether the item is viewable in Square Market (PUBLIC) or PRIVATE.
        /// </summary>
        [DataMember]
        public string visibility;

        /// <summary>
        /// The text of the item's display label in Square Register. Only up to the first five characters of the string are used.
        /// </summary>
        [DataMember]
        public string abbreviation;

        /// <summary>
        /// If true, the item is available for purchase from Square Market.
        /// </summary>
        [DataMember(Name = "available_online")]
        public bool availableOnline;

        /// <summary>
        /// The item's master image, if any.
        /// </summary>
        [DataMember(Name = "master_image")]
        public ItemImage masterImage { get; private set; }

        /// <summary>
        /// The category the item belongs to, if any.
        /// </summary>
        [DataMember]
        public Category category; // TODO + category_id

        /// <summary>
        /// The item's variations.
        /// </summary>
        [DataMember]
        public Variation[] variations { get; private set; };

        /// <summary>
        /// The modifier lists that apply to the item, if any.
        /// </summary>
        [DataMember(Name = "modifier_lists")]
        public ModifierList[] modifierLists { get; private set; }

        /// <summary>
        /// The fees that apply to the item, if any.
        /// </summary>
        [DataMember]
        public Fee[] fees { get; private set; }
    }
}
