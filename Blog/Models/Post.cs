using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Post
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
        public List<string> TagList { get; set; }
    }
}