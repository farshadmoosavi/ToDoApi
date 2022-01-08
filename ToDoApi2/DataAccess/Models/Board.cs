using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public class Board : EntityBase
    {        
        public string BoardName { get; set; }
        public ICollection<ToDo> ToDoss { get; set; }
    }
}
