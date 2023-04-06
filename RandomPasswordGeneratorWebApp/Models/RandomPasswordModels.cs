namespace RandomPasswordGeneratorWebApp.Models
{
    public class RandomPasswordModels
    {
        public int Length { get; set; }
        public bool UPPERCASE { get; set; }
        public bool SPECIALCHARACTER { get; set; }
        public string RPassword { get; set; } = "DefaultPassword";
    }
}
