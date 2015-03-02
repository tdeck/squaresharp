using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    public class Money
    {
        [DataMember]
        public decimal amount;
        [DataMember(Name = "currency_code")]
        public string currencyCode;
    }
}