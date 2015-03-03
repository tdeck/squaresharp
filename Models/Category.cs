using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class Category
    {
        [DataMember]
        public string id;
        [DataMember]
        public string name;
    }
}
