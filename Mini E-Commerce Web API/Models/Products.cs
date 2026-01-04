using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mini_E_Commerce_Web_API.Models
{
    [Table(name:"Products")]
    public class Products
    {
        [Key]
        [Column(name:"ID")]
        public int Id { get; set; }
        [Column(name:"Name")]
        public string? Name { get; set; }
        [Column(name:"Description")]
        public string? Description { get; set; }
        [Column(name:"Image")]
        public string? Image {  get; set; }
    }
}
