using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ToDo : EntityBase
    {        
        public string ToDoTitle { get; set; }
        public status ToDoStatus { get; set; }
        public DateTime ToDoCreated { get; set; }
        public DateTime ToDoUpdated { get; set; }
        public int BoardId { get; set; }
        [ForeignKey("BoardId")]
        public Board Board { get; set; }

    }
    public enum status 
    {
        init = 1, 
        started = 2,
        ongoing = 3,
        done = 4
    }
}
