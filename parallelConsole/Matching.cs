

public class Matching
{

    public async Task<bool> Run(List<Transaction> transactions)
    {
        int count = 0;
        await Parallel.ForEachAsync(transactions, async (transaction, cancellationToken) =>
        {
            await Task.Delay(transaction.Duration, cancellationToken);
            await Task.Run(() => {
                Console.WriteLine($"Transaction {transaction.Id} from {transaction.From} to {transaction.To} for {transaction.Amount} has completed.");
                transaction.Status = "Completed";
                count++;
            });
        });

        Console.WriteLine($"Total transactions completed: {count}");
        return true;
    }
}