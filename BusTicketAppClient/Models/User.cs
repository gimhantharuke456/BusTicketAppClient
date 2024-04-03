#nullable disable

namespace BusTickitAppClient.Models
{
    public class User
    {
        public int? UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public string Nic { get; set; }
        public string PasswordHash { get; set; }

    }
}