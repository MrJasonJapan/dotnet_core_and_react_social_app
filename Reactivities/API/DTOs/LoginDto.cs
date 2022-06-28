namespace API.DTOs
{
    public class LoginDto
    {
        // DTO users send to the server when they login
        public string Email { get; set; }
        public string Password { get; set; }
    }
}