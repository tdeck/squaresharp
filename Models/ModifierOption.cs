using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents an item modifier option.
    /// </summary>
    public class ModifierOption
    {
        [DataMember]
        /// <summary>
        /// The modifier option's unique ID.
        /// </summary>
        public string id;
        [DataMember]
        /// <summary>
        /// The modifier option's name.
        /// </summary>
        public string name;
        [DataMember(Name = "price_money")]
        /// <summary>
        /// The modifier option's price.
        /// </summary>
        public Money priceMoney;
        [DataMember(Name = "on_by_default")]
        /// <summary>
        /// If true, the modifier option is the default option in a modifier list for which selectionType is SINGLE.
        /// </summary>
        public bool onByDefault;
        [DataMember]
        /// <summary>
        /// Indicates the modifier option's list position when displayed in Square Register and the merchant dashboard. If more than one modifier option in the same modifier list has the same ordinal value, those options are displayed in alphabetical order. A modifier list's option with the lowest ordinal value is displayed first.
        /// </summary>
        public uint ordinal;
        [DataMember(Name = "modifier_list_id")]
        /// <summary>
        /// The ID of the modifier list the option belongs to.
        /// </summary>
        public string modifierListID;
    }
}
