using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents a device running Square Register.
    /// </summary>
    [DataContract]
    public class Device
    {
        /// <summary>
        /// The device's Square-issued ID.
        /// </summary>
        [DataMember]
        public string id;

        /// <summary>
        /// The device's merchant-specified name.
        /// </summary>
        [DataMember]
        public string name;
    }
}
