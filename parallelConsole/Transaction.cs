
public class Transaction
{
    public int Id { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public decimal Amount { get; set; }
    public int Duration { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }
}