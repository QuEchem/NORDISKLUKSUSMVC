using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NordiskLuksusMVC.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        [ForeignKey("UserID")]

        ICollection<Comment> Comments { get; set; }
    }
}