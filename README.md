# SquareSharp

SquareSharp is a C# client library for the [Square Connect API](https://docs.connect.squareup.com/). Currently it is read-only, but I'm working to make it more comprehensive.

# Usage
```csharp
// Create a client
var client = new SquareClient("<your-access-token"); // Do not check your token into GitHub

// Get some merchant details
var merchant = await SquareClient.GetMerchant();
Console.WriteLine("ID: " + merchant.id);
Console.WriteLine("Name: " + merchant.name);
Console.WriteLine("Email: " + merchant.email);
Console.WriteLine("Business: " + merchant.businessName);

// Grab a list of payments and print their amounts
var payments = await SquareClient.ListPayments();
foreach (var payment in payments)
{
    Console.WriteLine(payment.totalCollectedMoney.amount + "¢")
}
```
# Development
I am actively developing SquareSharp, and happy to take contributions as well. Please report any bugs you find through the GitHub bug tracker.

# License
[MIT License](http://troy.mit-license.org/)