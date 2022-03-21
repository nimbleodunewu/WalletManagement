namespace WalletManagement.Models
{
    public class Account
    {
        public Guid AccountId { get; set; }
        //public User User { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; }
        public Currency Currency { get; set; }
        public double Limit { get; set; }
        public double MinimumBalance { get; set; }
        public DateTime CreationDate { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
