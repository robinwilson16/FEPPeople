namespace FEPPeople.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string? Forename { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? TokenType { get; set; }
        public string? AccessToken { get; set; }
        public int? ExpiresIn { get; set; }
        public string? RefreshToken { get; set; }
    }
}
