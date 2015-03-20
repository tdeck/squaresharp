using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents an item modifier list.
    /// </summary>
    [DataContract]
    public class ModifierList
    {
        /// <summary>
        /// The modifier list's unique ID.
        /// </summary>
        [DataMember]
        public string id;

        /// <summary>
        /// The modifier list's name.
        /// </summary>
        [DataMember]
        public string name;

        /// <summary>
        /// Indicates whether MULTIPLE options or a SINGLE option from the modifier list can be applied to a single item.
        /// </summary>
        [DataMember(Name = "selection_type")]
        public string selectionType;

        /// <summary>
        /// The options included in the modifier list.
        /// </summary>
        [DataMember(Name = "modifier_options")]
        public ModifierOption[] modifierOptions;
    }
}
