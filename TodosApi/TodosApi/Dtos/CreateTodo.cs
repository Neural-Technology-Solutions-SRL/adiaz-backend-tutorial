using System.ComponentModel.DataAnnotations;

namespace TodosApi.Dtos
{
    public class CreateTodo
    {
        [Required]
        public string? Title { get; set; }
    }
}
