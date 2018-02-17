using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Instagraph.Models
{
    public class Picture
    {
        public Picture()
        {
            this.Posts = new List<Post>();
            this.Users = new List<User>();
        }
        public int Id { get; set; }
        [Required]
        public string Path { get; set; }
        [Required]
        public decimal Size { get; set; }
        [Required]
        public ICollection<User> Users { get; set; }
        [Required]
        public ICollection<Post> Posts { get; set; }
    }

}
