using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mini_E_Commerce_Web_API.Models
{
    [Table(name:"Users")]
    public class Users
    {
        [Key]
        [Column(name:"UserID")]
        public int userID { get; set; }
        [Column(name:"Username")]
        public string? Username { get; set; }
        [Column(name:"Password")]
        public string? Password { get; set; }
        [Column(name:"EmailID")]
        public string? EmailID {  get; set; }
    }
}
