using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents an item category.
    /// </summary>
    [DataContract]
    public class Category
    {
        /// <summary>
        /// The category's unique ID.
        /// </summary>
        [DataMember]
        public string id { get; private set; }

        /// <summary>
        /// The category's name.
        /// </summary>
        [DataMember]
        public string name;
    }
}
