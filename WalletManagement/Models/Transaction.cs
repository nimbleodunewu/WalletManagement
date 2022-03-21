namespace WalletManagement.Models
{
    public class Transaction
    {
        public Guid TransactionId { get; set;}
        public Account Account { get; set;}
        public Guid Counterparty { get; set;}
        public double Amount { get; set;}
        public string Direction { get; set;}
        public string Narration { get; set;}
        public DateTime CreationDate { get; set;}
    }
}
