namespace WalletManagement.Dto
{
    public class UserUpdateDto
    {
        public Guid UserId { get; set; }               
        public string Email { get; set; }
        public string PhoneNumber { get; set; }        
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
