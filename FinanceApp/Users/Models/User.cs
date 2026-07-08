using UserEntity = FinanceApp.Users.Models.User;
using FinanceApp.Loans.Models;
using FinanceApp.Savings.Models;

namespace FinanceApp.Users.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public List<UserEntity> Loans { get; set; } = new List<UserEntity>();
        public List<Saving> Savings { get; set; } = new List<Saving>();
    }
}