using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents a device running Square Register.
    /// </summary>
    public class Device
    {
        [DataMember]
        /// <summary>
        /// The device's Square-issued ID.
        /// </summary>
        public string id;
        [DataMember]
        /// <summary>
        /// The device's merchant-specified name.
        /// </summary>
        public string name;
    }
}
