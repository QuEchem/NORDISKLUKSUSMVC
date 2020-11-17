using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NordiskLuksusMVC.Models
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string comment { get; set; }
        [ForeignKey("UserID")]

        public User User { get; set; }

        public int? UserID { get; set; }
    }
}