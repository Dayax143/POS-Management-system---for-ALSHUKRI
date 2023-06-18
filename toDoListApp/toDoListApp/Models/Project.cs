using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace toDoListApp.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }=Guid.NewGuid ().ToString();

        [Required]
        public string Name { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public string Description { get; set; }

        public string UserId { get; set; }

        [ForeignKey("User")]
        public User User { get; set; }= string.Empty;
        public string DescriptionUrl { get; set; }


    }
}
