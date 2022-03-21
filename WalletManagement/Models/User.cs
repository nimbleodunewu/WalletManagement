namespace WalletManagement.Models
{
    public class User
    {
        public User()
        {
        }

        public User(string firstName, string lastName, string userName, string email, string phoneNumber, string passwordHash, string address, string city, string state, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            PasswordHash = passwordHash;
            Address = address;
            City = city;
            State = state;
            Gender = gender;
            Accounts = new List<Account>();
        }

        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }
        public DateTime CreationDate { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
    }
}
