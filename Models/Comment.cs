using System.ComponentModel.DataAnnotations;

namespace AzureASPSQLAPI.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; } = string.Empty;
        public int PostId { get; set; }
    }
}