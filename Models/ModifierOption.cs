using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class ModifierOption
    {
        [DataMember]
        public string id;
        [DataMember]
        public string name;
        [DataMember(Name = "price_money")]
        public Money priceMoney;
        [DataMember(Name = "on_by_default")]
        public bool onByDefault;
        [DataMember]
        public uint ordinal;
        [DataMember(Name = "modifier_list_id")]
        public string modifierListID;
    }
}
