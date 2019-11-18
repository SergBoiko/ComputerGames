using System.ComponentModel.DataAnnotations;

namespace ComputerGames.Presentation.ViewModels
{
    public class UpdateGenreViewModel: CreateGenreViewModel
    {
        [Required]
        public int? Id { get; set; }
    }
}
