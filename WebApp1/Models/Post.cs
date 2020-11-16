using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        // Relatied propertise 
        public int UserID { get; set; }
    }
}