using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cesi.IntroCS.CoreDataAccess.Entities
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Url { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}
