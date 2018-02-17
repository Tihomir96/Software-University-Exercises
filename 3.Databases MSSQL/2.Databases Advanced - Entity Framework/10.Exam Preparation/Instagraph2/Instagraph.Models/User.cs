
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Instagraph.Models
{
    public class User
    {
        public User()
        {
            this.Followers = new List<UserFollower>();
            this.Comments = new List<Comment>();
            this.Posts = new List<Post>();
            this.UsersFollowing = new List<UserFollower>();
        }
        public int Id { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int ProfilePictureId { get; set; }
        [Required]
        public Picture ProfilePicture { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public ICollection<UserFollower> Followers { get; set; }
        [Required]
        public ICollection<UserFollower> UsersFollowing { get; set; }
        [Required]
        public ICollection<Post> Posts { get; set; }
        [Required]
        public ICollection<Comment> Comments { get; set; }
    }
}
