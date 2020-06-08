namespace HireHero.Shared.Models
{
    public class Request
    {
        public string Id { get; set; }
        public string Powers { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Fullname { get; }

        public Request()
        {
            Fullname = $"{Firstname} {Lastname}";
        }
    }
}
