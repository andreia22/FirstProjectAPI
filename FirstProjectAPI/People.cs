using Microsoft.AspNetCore.Identity;

namespace FirstProjectAPI
{
    public class People
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
       
    }
}
