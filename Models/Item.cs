using System.Runtime.Serialization;

namespace SquareSharp.Models
{
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

        [DataMember]
        public string id;
        [DataMember]
        public string name;
        [DataMember]
        public string description;
        [DataMember]
        public string color;
        [DataMember]
        public string visibility;
        [DataMember(Name = "available_online")]
        public bool availableOnline;
        [DataMember(Name = "master_image")]
        public ItemImage masterImage;
        [DataMember]
        public Category category;
        [DataMember]
        public Variation[] variations;
        [DataMember(Name = "modifier_lists")]
        public ModifierList[] modifierLists;

        public Fee[] fees;
    }
}
