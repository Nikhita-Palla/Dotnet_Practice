using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst_Article_MVC.Models
{
    public class ArticleModel
    {
        [Key]
        public int ArticleId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishedDate {  get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime LastModifiedDate { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public virtual UserModel UserName { get; set; }

        [Required]
        public string CategoryId { get; set; }
        public virtual UserModel CategoryName { get; set; }

    }
    
}