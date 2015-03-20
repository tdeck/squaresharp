using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents an item modifier option.
    /// </summary>
    [DataContract]
    public class ModifierOption
    {
        /// <summary>
        /// The modifier option's unique ID.
        /// </summary>
        [DataMember]
        public string id;

        /// <summary>
        /// The modifier option's name.
        /// </summary>
        [DataMember]
        public string name;

        /// <summary>
        /// The modifier option's price.
        /// </summary>
        [DataMember(Name = "price_money")]
        public Money priceMoney;

        /// <summary>
        /// If true, the modifier option is the default option in a modifier list for which selectionType is SINGLE.
        /// </summary>
        [DataMember(Name = "on_by_default")]
        public bool onByDefault;

        /// <summary>
        /// Indicates the modifier option's list position when displayed in Square Register and the merchant dashboard. If more than one modifier option in the same modifier list has the same ordinal value, those options are displayed in alphabetical order. A modifier list's option with the lowest ordinal value is displayed first.
        /// </summary>
        [DataMember]
        public uint ordinal;

        /// <summary>
        /// The ID of the modifier list the option belongs to.
        /// </summary>
        [DataMember(Name = "modifier_list_id")]
        public string modifierListID;
    }
}
