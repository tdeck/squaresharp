using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class Device
    {
        [DataMember]
        public string id;
        [DataMember]
        public string name;
    }
}