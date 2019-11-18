using System.ComponentModel.DataAnnotations;

namespace ComputerGames.Presentation.ViewModels
{
    public class UpdatePublisherViewModel: CreatePublisherViewModel
    {
        [Required]
        public int? Id { get; set; }
    }
}
