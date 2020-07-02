using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gifter.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string message { get; set; }

        [Required]
        public int userProfileId { get; set; }

        public UserProfile userProfile { get; set; }
        [Required]
        public int postId { get; set; }

        public Post post { get; set; }
    }
}
