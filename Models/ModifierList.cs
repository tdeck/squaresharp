using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class ModifierList
    {
        [DataMember]
        public string id;
        [DataMember]
        public string name;
        [DataMember(Name = "selection_type")]
        public string selectionType;
        [DataMember(Name = "modifier_options")]
        public ModifierOption[] modifierOptions;
    }
}
