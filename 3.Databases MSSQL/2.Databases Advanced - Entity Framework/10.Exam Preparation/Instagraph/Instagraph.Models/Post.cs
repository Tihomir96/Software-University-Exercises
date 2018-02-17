using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Instagraph.Models
{
    public class Post
    {
        public Post()
        {
            this.Comments=new List<Comment>();
        }
        public int Id { get; set; }
        [Required]
        public string Caption { get; set; }
        [Required]
        public int PictureId { get; set; }
        [Required]
        public Picture Picture { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public ICollection<Comment> Comments { get; set; }
    }
}
