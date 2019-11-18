using System.ComponentModel.DataAnnotations;

namespace ComputerGames.Presentation.ViewModels
{
    public class CreateGenreViewModel
    {
        [Required]
        [MaxLength(600)]
        public string Description { get; set; }
    }
}
