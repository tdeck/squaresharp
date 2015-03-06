using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    [DataContract]
    /// <summary>
    /// Represents an amount of money.
    /// </summary>
    public class Money
    {
        [DataMember]
        /// <summary>
        /// The amount of money, in the smallest unit of the applicable currency. For US dollars, this value is in cents. This value is always an integer.
        /// </summary>
        public decimal amount;
        [DataMember(Name = "currency_code")]
        /// <summary>
        /// The type of currency involved in the current payment. The currency code for US dollars is USD.
        /// </summary>
        public string currencyCode;

        public override string ToString()
        {
            // This is a rather crude currency formatter
            switch (currencyCode) {
                case "USD":
                case "CAD":
                    return (amount / 100).ToString("C");
                case "JPY":
                    return "¥" + amount;
                default:
                    return amount + " " + currencyCode;
            }
        }
    }
}
