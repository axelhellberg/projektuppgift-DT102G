using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projektuppgift.Models
{
    public class Post
    {
        public int PostId { get; set; }
        
        [Required]
        [DisplayName("Title")]
        public string PostTitle { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [StringLength(500)]
        public string Content { get; set; }
        public string Timestamp { get; set; } = DateTime.Now.ToString();
        [Required]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
