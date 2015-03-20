using System.Runtime.Serialization;

namespace SquareSharp.Models
{
    /// <summary>
    /// Represents an amount of money.
    /// </summary>
    [DataContract]
    public class Money
    {
        public Money(int amount, string currencyCode = "USD")
        {
            this.amount = amount;
            this.currencyCode = currencyCode;
        }
        
        /// <summary>
        /// The amount of money, in the smallest unit of the applicable currency. For US dollars, this value is in cents. This value is always an integer.
        /// </summary>
        [DataMember]
        public int amount;

        /// <summary>
        /// The type of currency involved in the current payment. The currency code for US dollars is USD.
        /// </summary>
        [DataMember(Name = "currency_code")]
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
