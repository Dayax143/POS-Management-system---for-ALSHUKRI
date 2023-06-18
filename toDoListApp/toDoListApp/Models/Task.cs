using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace toDoListApp.Models
{
    public class Task
    {
        public string Id { get; set; }  
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; }

        [ForeignKey("user")]
        public string P_id { get; set; }
        public string user { get; set; }
    }
}
