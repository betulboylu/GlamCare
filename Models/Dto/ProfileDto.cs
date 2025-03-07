using System;

namespace GlamCare.Models
{
    /// <summary>
    /// Profile object contains user data
    /// </summary>
    public class ProfileDto
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public int? Age { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public string ShoeSize { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public Diet DietInfo { get; set; }
        public string PersonalityType { get; set; }
        public string ProfileImageUrl { get; set; }
    }
}