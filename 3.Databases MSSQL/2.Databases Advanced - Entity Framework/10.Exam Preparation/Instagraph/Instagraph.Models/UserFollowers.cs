﻿namespace Instagraph.Models
{
    public class UserFollowers
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int FollowerId { get; set; }
        public User Follower { get; set; }

    }
}
