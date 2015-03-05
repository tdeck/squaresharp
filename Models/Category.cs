using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents an item category.
    /// </summary>
    public class Category
    {
        [DataMember]
        /// <summary>
        /// The category's unique ID.
        /// </summary>
        public string id;
        [DataMember]
        /// <summary>
        /// The category's name.
        /// </summary>
        public string name;
    }
}
