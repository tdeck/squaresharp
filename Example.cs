using System.Threading.Tasks;
using System;

namespace SquareSharp
{
    public static class Example
    {
        async static Task getMerchant(Client client)
        {
            Console.WriteLine("Merchant");
            Console.WriteLine("========");

            var merchant = await client.GetMerchant();
            Console.WriteLine("ID: " + merchant.id);
            Console.WriteLine("Name: " + merchant.name);
            Console.WriteLine("Email: " + merchant.email);
            Console.WriteLine("Business: " + merchant.businessName);
            Console.WriteLine(
                "Phone: "
                + merchant.businessPhone.callingCode + " "
                + merchant.businessPhone.number
            );

            Console.WriteLine();
        }

        async static Task getAllPayments(Client client)
        {
            Console.WriteLine("Payments");
            Console.WriteLine("========");

            Console.WriteLine(
                "ID".PadRight(32) +
                "Time".PadRight(24) +
                "Total ¢".PadRight(8)
            );
            foreach (var payment in await client.ListPayments())
            {
                Console.WriteLine(
                    payment.id.PadRight(32) +
                    payment.createdAt.ToString().PadRight(24) +
                    payment.totalCollectedMoney.amount.ToString().PadRight(8)
                );
            }

            Console.WriteLine();
        }

        async static Task getAllRefunds(Client client)
        {
            Console.WriteLine("Refunds");
            Console.WriteLine("=======");

            Console.WriteLine(
                "Time".PadRight(24) +
                "Payment ID".PadRight(32) +
                "Money ¢".PadRight(8) +
                "Reason"
            );

            foreach (var refund in await client.ListRefunds())
            {
                Console.WriteLine(
                    refund.processedAt.ToString().PadRight(24) +
                    refund.paymentID.PadRight(32) +
                    refund.refundedMoney.amount.ToString().PadRight(8) +
                    refund.reason
                );
            }

            Console.WriteLine();
        }

        async static Task getAllItems(Client client)
        {
            Console.WriteLine("Items");
            Console.WriteLine("=====");

            Console.WriteLine(
                "ID".PadRight(64) +
                "Name".PadRight(50) +
                "Description"
            );
            foreach (var item in await client.ListItems())
            {
                Console.WriteLine(
                    item.id.PadRight(64) +
                    item.name.PadRight(50) +
                    item.description
                );
            }

            Console.WriteLine();
        }

        async static Task getAllInventory(Client client)
        {
            Console.WriteLine("Inventory");
            Console.WriteLine("=========");

            Console.WriteLine(
                "Variation ID".PadRight(64) +
                "Quantity"
            );
            foreach (var entry in await client.ListInventory())
            {
                Console.WriteLine(
                    entry.variationID.PadRight(64) +
                    entry.quantityOnHand
                );
            }

            Console.WriteLine();
        }

        public static void Main()
        {
            Console.Write("Token: ");
            var client = new Client(Console.ReadLine().Trim());
            Task.Run(async() =>
                {
                    await getMerchant(client);
                    await getAllPayments(client);
                    await getAllRefunds(client);
                    await getAllItems(client);
                    await getAllInventory(client);
                }
            ).Wait();
        }
    }
}
