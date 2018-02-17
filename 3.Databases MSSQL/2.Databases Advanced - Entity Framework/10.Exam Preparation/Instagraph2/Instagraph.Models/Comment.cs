﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Instagraph.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public Post Post { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public User User { get; set; }


    }
}
