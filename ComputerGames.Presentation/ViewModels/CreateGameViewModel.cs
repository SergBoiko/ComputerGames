using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGames.Presentation.ViewModels
{
    public class CreateGameViewModel
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int? GenreId { get; set; }

        [Required]
        public int? PublisherId { get; set; }
    }
}
