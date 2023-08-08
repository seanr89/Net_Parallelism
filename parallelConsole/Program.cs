// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Path: parallelConsole/Program.cs
// See https://aka.ms/new-console-template for more information



List<Transaction> transactions = new List<Transaction>();

Random random = new Random();
for (int i = 0; i < 150; i++)
{
    transactions.Add(new Transaction
    {
        Id = i,
        From = "Account" + i,
        To = "Account" + (i + 1),
        Amount = random.Next(0, 120),
        Duration = random.Next(50, 250),
        Date = DateTime.Now,
        Status = "Pending"
    });
}

var matching = new Matching();
var resp = await matching.Run(transactions);

Console.WriteLine($"All transactions completed: {resp}");
