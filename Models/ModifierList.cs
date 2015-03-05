using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents an item modifier list.
    /// </summary>
    public class ModifierList
    {
        [DataMember]
        /// <summary>
        /// The modifier list's unique ID.
        /// </summary>
        public string id;
        [DataMember]
        /// <summary>
        /// The modifier list's name.
        /// </summary>
        public string name;
        [DataMember(Name = "selection_type")]
        /// <summary>
        /// Indicates whether MULTIPLE options or a SINGLE option from the modifier list can be applied to a single item.
        /// </summary>
        public string selectionType;
        [DataMember(Name = "modifier_options")]
        /// <summary>
        /// The options included in the modifier list.
        /// </summary>
        public ModifierOption[] modifierOptions;
    }
}
