using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace AdminPanel.Models
{
    public class ProfileViewModel
    {
        public string Name { get; set; }

        [Display(Name = "Upload New Image")]
        public IFormFile? ProfileImageFile { get; set; }

        [Display(Name = "New Password")]
        [DataType(DataType.Password)]
        public string? NewPassword { get; set; }

        public string? CurrentImage { get; set; }
    }
}
