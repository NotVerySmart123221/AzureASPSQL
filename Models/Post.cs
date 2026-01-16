using System.ComponentModel.DataAnnotations;

namespace AzureASPSQLAPI.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}