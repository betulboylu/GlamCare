using Microsoft.AspNetCore.Identity;

namespace GlamCare.Models
{
    /// <summary>
    /// Application User
    /// </summary>
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public int? Age { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public string ShoeSize { get; set; }
        public HairColor HairColor { get; set; }
        public EyeColor EyeColor { get; set; }
        public string DietInfo { get; set; }
        public Personality PersonalityType { get; set; }
        public string ProfileImageUrl { get; set; }

    }
}
