namespace HireHero.Shared.Models
{
    public class Hero
    {
        public string Name { get; set; }
        public double HourPrice { get; set; }
        public string Currency { get; set; }
        public string[] Powers { get; set; }

        public string GetFormattedSalary() => $"{Currency}{HourPrice}";
    }
}